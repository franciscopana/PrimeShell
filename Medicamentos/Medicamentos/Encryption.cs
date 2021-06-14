using System;
using System.Security.Cryptography;
using System.Text;

namespace Medicamentos
{
    class Encryption
    {
        public const int SaltByteSize = 24;
        public const int HashByteSize = 20;
        public const int Pbkdf2Iterations = 1000;
        public const int IterationIndex = 0;
        public const int SaltIndex = 1;
        public const int Pbkdf2Index = 2;

        public static string HashPassword(string password)
        {
            var cryptoProvider = new RNGCryptoServiceProvider();

            // Fill An Array Of Bytes With A Strong Sequence of Random Values to Generate Salt

            byte[] salt = new byte[SaltByteSize];
            cryptoProvider.GetBytes(salt);

            // Generate Hash 

            byte[] hash = GetPbkdf2Bytes(password, salt, Pbkdf2Iterations, HashByteSize);

            // String That Will Be Saved On Database, Convert Byte Array in Base64String

            return Pbkdf2Iterations + ":" + Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash);
        }

        public static bool ValidatePassword(string password, string correctHash)
        {
            if (correctHash == null)
            {
                return false;
            }

            else
            {
                // Splits The String Hash Stored On DataBase In Substrings

                char[] delimiter = { ':' };
                var split = correctHash.Split(delimiter);   
                var iterations = Int32.Parse(split[IterationIndex]);
                var salt = Convert.FromBase64String(split[SaltIndex]);
                var hash = Convert.FromBase64String(split[Pbkdf2Index]);

                // Generate A New Array Of Bytes (Hash) With The Password Entered By The User

                var testHash = GetPbkdf2Bytes(password, salt, iterations, hash.Length);

                // Check If The New Array of Bytes (Hash) Is The Same As The One Stored On Database

                return SlowEquals(hash, testHash);
            }

        }


        private static bool SlowEquals(byte[] a, byte[] b)
        {
            // See If The Two Byte Arrays With The Pseudo Random Keys Are Equal To Validate Login

            // Takes The Logical Operator Exclusive-or of a byte of a(array of bytes) with a corresponding byte of b (array of bytes). 

            // That will be 0 if the two bytes are the same, or non-zero if they're different.

            // Therefore, diff will be set to non-zero in an iteration if a difference was found between the inputs in that iteration.

            // Concluding, the final result in diff will be non-zero if any difference is found between corresponding bytes of a and b, and 0 only if all bytes(and the lengths) of a and b are equal.

            var diff = (uint)a.Length ^ (uint)b.Length;

            for (int i = 0; i < a.Length && i < b.Length; i++)
            {
                diff |= (uint)(a[i] ^ b[i]);
            }

            return diff == 0;
        }


        private static byte[] GetPbkdf2Bytes(string password, byte[] salt, int iterations, int outputBytes)
        {
            // Using Salt And Password To Derive Key, Returning A Byte Array With The Key (Pseudo Random Bytes)

            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt);
            pbkdf2.IterationCount = iterations;
            return pbkdf2.GetBytes(outputBytes);
        }


        public static string RandomString(int length = 8)
        {
            // Generate A Random String Of Characters To Reset Password Or Confirm Registration

            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            StringBuilder res = new StringBuilder();

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                // Fill An Array Of Bytes With A Strong Sequence of Random Values
                // Gets A 32 Unsigned Integer From The Bytes of The Array
                // Appends The String Representation Of The Unicode Characters In A Specified Array With Given Lenght

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }

            string RandomData = res.ToString();

            return RandomData;
        }
    }
}
