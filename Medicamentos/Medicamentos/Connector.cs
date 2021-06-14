using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Medicamentos
{
    class Connector
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private static string TableValue;

        public Connector()
        {
            Initialize();
        }

        private void Initialize()
        {
            // Public Ip Address
            server = "188.80.238.219";

            // Name Database Mysql
            database = "medications";

            // Use root user
            uid = "root";

            // Password To Acess Db Externally
            password = "lolpotxd1";

            string connectionString;

            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {

            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert(string query)
        {
            //open connection
            if (OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                CloseConnection();
            }
        }

        //Update statement
        public void Update(string query)
        {

            //Open connection
            if (OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                CloseConnection();
            }
        }

        //Delete statement
        public void Delete(string query)
        {

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        //Select statement
        public string Select(string query)
        {

            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    TableValue = dataReader.GetString(0);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                return TableValue;
            }

            else
            {
                return null;
            }
        }


        //Count statement
        public bool Count(string query)
        {

            //Open Connection
            if (OpenConnection() == true)
            {
                MySqlCommand cmddatabase = new MySqlCommand(query, connection);

                int result = Convert.ToInt32(cmddatabase.ExecuteScalar());

                if (result == 0)
                {
                    connection.Close();
                    return false;
                }
                else
                {
                    connection.Close();
                    return true;
                }
            }

            else
            {
                connection.Close();
                return false;
            }
        }

        public bool ValidateToken(string query, string sentence)
        {

            Delete(sentence);

            if (Count(query) == false)
            {
                return false;
            }

            else
            {
                return true;
            }
        }


        public void Register(string query, string queryregistatrion)
        {
            if (Count(query) == false)
            {
                Insert(queryregistatrion);
            }
            else
            {
                MessageBox.Show("Email Already Exists In Database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public bool ValidatePassword(string query, string password)
        {
            string correcthash = Select(query);

            if (Encryption.ValidatePassword(password, correcthash) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
