using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace Medicamentos
{
    public partial class RecoverForm : MaterialForm
    {
        Connector connector = new Connector();

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public static string UserRandom = Encryption.RandomString();

        public static string EmailText = " ";

        int tokenAttempts = 1;

        public RecoverForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void butSendCode_Click(object sender, EventArgs e)
        {
            // Check If Email Exists In Database => If It Returns true:
            // 1- Send Email With Code To Recover Password
            // 2- Insert Email And Code Provided Into A Table With Temporary Information In MySQL

            if (connector.Count("SELECT COUNT(*) FROM user_registos WHERE email = '" + PassRecoverEmailtxt.Text + "'") == true)
            {
                if(frmLogin.trad)
                    Email.SendEmail(PassRecoverEmailtxt.Text, string.Format("Olá! O código para recuperação de password é: {0}", UserRandom), "Recuperação de password");
                else
                    Email.SendEmail(PassRecoverEmailtxt.Text, string.Format("Hello! Your code to recover account is: {0}", UserRandom), "Password Recover");

                connector.Insert("INSERT INTO recuperar_pass (email,hash_code,hash_expiration,hash_code_used) VALUES('" + PassRecoverEmailtxt.Text + "','" + UserRandom + "', now() + INTERVAL 10 MINUTE, 0)");

            }

            else
            {
                if(frmLogin.trad)
                    MessageBox.Show("Se o email for válido enviaremos o código!", "Recuperação de password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("If Email is valid we will send you a verification code!", "Recover", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void butAuthentication_Click(object sender, EventArgs e)
        {
            // // If It Matches :
            // 1- Update The Table "tokens" (column "token_used" In The Same Row As Email with 1), So That We Know The Code Has Been Used And Cannot Be Used Again
            // 2- Goes To New Password Form

            // If It Does Not Matches :
            // 1- Display A Message Box Saying The Code Is Incorrect And Increase Variable "tokenAttempts"
            // 2- If We Reach The Maximum Number Of Attempts:
            // 2.1- Delete All The Temporary Information Stored On tokens table (MySQL)
            // 2.2- Go Back To Login_Form


            if (connector.ValidateToken("SELECT COUNT(*) FROM recuperar_pass WHERE hash_code = '" + VerifyCodetxt.Text + "' AND email = '" + PassRecoverEmailtxt.Text + "'", "DELETE FROM recuperar_pass WHERE hash_expiration < NOW() OR hash_code_used = 1") == true)
            {
                connector.Update("UPDATE recuperar_pass SET hash_code_used = 1 WHERE email = '" + PassRecoverEmailtxt.Text + "'");

                EmailText = PassRecoverEmailtxt.Text;

                FrmNewPass frm = new FrmNewPass();
                frm.Show();
                this.Hide();
            }
            else
            {
                if(frmLogin.trad)
                    MessageBox.Show("Código incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Your code is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                tokenAttempts++;
            }

            if (tokenAttempts == 4)
            {
                if (frmLogin.trad)
                    MessageBox.Show("Atingiu o limite de tentativas. O acesso falhou", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("You reach the maximum number of attempts... You registration will fail", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                connector.Delete("DELETE FROM pass_recovery WHERE email = '" + PassRecoverEmailtxt.Text + "'");

                frmLogin lf = new frmLogin();
                lf.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmLogin inicio = new frmLogin();
            inicio.Show();
            this.Hide();
        }

        private void RecoverForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:

                    string txt1;
                    string txt2;

                    if (frmLogin.trad)
                    {
                        txt1 = "Tem a certeza que deseja sair?";
                        txt2 = "Sair";
                    }
                    else
                    {
                        txt1 = "Are you sure?";
                        txt2 = "Exit";
                    }
                    if (MessageBox.Show(txt1, txt2, MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                    break;
            }
        }

        private void RecoverForm_Load(object sender, EventArgs e)
        {
            if (frmLogin.trad)
            {
                imgRFI.Visible = false;
                imgRFP.Visible = true;
                this.Text = "Verificação de identidade";
                VerifyCodetxt.Hint = "Código";
                butAuthentication.Text = "Autenticação";
                butSendCode.Text = "Enviar código";
            }
        }
    }
}
