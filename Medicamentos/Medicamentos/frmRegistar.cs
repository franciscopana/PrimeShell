using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Medicamentos
{
    public partial class frmRegistar : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        Connector connnector = new Connector();

        public static string MailRandom = Encryption.RandomString();

        int codeAttempts = 1;

        public static string warning = "Warning";
        public static string info = "Information";
        public static string error = "Error";
        string regwillfail = "Your registration will fail";
        string invalidvalue = "Invalid value";
        string missingdata = "Fill all input box's before trying to register";
        string regfailled = "Failed Register";
        string wrongpass = "Password doesn't match";
        string usernameexists = "Name or Email are being used by someone! Please introduce new credentials!";
        string gmail = "You just acknowledge gmail addresses as valid credentials!";
        string regisucc = "Your account was created with success!";
        string invalidcode = "Invalid code";
        string maxattemps = "You reach the maximum number of attemps!";
        string sendemail = "Hello! In order to finish your registration, please use this code: {0}";
        string authmail = "Account Authentication";


        public static List<string> nacionalidades = new List<string> { "Afeganistão", "Albânia",
            "Alemanha", "Angola", "Argentina", "Argélia", "Austrália", "Azerbaijão", "Bielorússia",
            "Brasil", "Bulgária", "Bélgica", "Cabo verde", "Canadá", "Chile", "China", "Colômbia",
            "Coreia do Sul", "Croácia", "Cuba", "Dinamarca", "Egito", "Emirados Árabes Unidos",
            "Equador", "Eslováquia", "Eslovénia", "Estados Unidos da América", "Estónia",
            "Finlândia", "França", "Georgia", "Grécia", "Hungria", "Iraque", "Irlanda", "Islândia",
            "Israel", "Itália", "Jamaica", "Japão", "Luxemburgo", "Malta", "Marrocos", "Moldávia",
            "Moçambique", "México", "Nigéria", "Noruega", "Nova Zelândia", "Paraguai",
            "Países Baixos", "Polónia", "Portugal", "Reino Unido", "Repúplica dominicana",
            "Roménia", "Rússia", "Suécia", "Suíça", "Sérvia", "Ucrânia", "Uruguai", "Venezuela"};

        public static List<string> generos = new List<string>() { "Masculino", "Feminino", "Outro" };

        public frmRegistar()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void butEnviarEmail_Click(object sender, EventArgs e)
        {
            
            if (txtPass2.Text == "" || txtResetPass.Text == "" || txtNome.Text == "" || txtMorada.Text == "" || txtDataNasc.Text == "" || txtNumeroCC.Text == "" || txtEmail2.Text == "" || txtTelefone.Text == "" || cmbNacionalidade.Text == "" || cmbDistritos.Text == "" || cmbGenero.Text == "")
            {
                MessageBox.Show(missingdata, regfailled, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtPass2.Text != txtResetPass.Text)
                MessageBox.Show(wrongpass, error, MessageBoxButtons.OK, MessageBoxIcon.Error);


            else
            {
                // We Check If It Is A Valid Email => If the functions returns true:
                // 1- Check If The Email Already Exists On Database => If Returns false ( Don´t Exist):
                // 2- Send Confirmation Email With Code
                // 3- Insert Email And Code Provided Into A Table With Temporary Information In MySQL
                // 4- Goes To Verification Code Form

                if (Email.IsGmailValid(txtEmail2.Text) == true)
                {
                    if (connnector.Count("SELECT COUNT(*) FROM user_registos WHERE email = '" + txtEmail2.Text + "'") == false && connnector.Count("SELECT COUNT(*) FROM user_registos WHERE name = '" + txtNome.Text + "'") == false)
                    {
                        Email.SendEmail(txtEmail2.Text, string.Format(sendemail, MailRandom), authmail);

                        connnector.Insert("INSERT INTO confirmar_email (email,hash_code,hash_expiration,hash_code_used) VALUES('" + txtEmail2.Text + "','" + MailRandom + "', now() + INTERVAL 10 MINUTE, 0)");

                        tabctrlRegisto.SelectedIndex = 1;

                        butVerificar.Enabled = true;
                    }

                    else
                    {
                        MessageBox.Show(usernameexists, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        materialCheckbox1.Checked = false;
                    }
                }

                else
                {
                    MessageBox.Show(gmail, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail2.Text = "";
                    txtEmail2.Focus();
                }
            }
        }

        private void butVerificar_Click(object sender, EventArgs e)
        {
            // Check If The Code Inserted By The User Matches The Token Stored in MySql (Register_Form) In The Same Row As The Email (Register_Form)

            // If It Matches :
            // 1- Update The Table mailtokens (column "mail_token_used" In The Same Row As Email with 1), So That We Know The Code Has Been Used And Cannot Be Used Again
            // 2- Insert All The Users Information In The Defenitive "users" Table In MySql. Plus We Insert Their Passsword Hashed With A Salt
            // 3- Goes To ChatBox Form

            // If It Does Not Matches :
            // 1- Display A Message Box Saying The Code Is Incorrect And Increase Variable "codeattempts"
            // 2- If We Reach The Maximum Number Of Attempts:
            // 2.1- Delete All The Temporary Information Stored On mailtokens table (MySQL)
            // 2.2- Go Back To Login_Form


            if (connnector.ValidateToken("SELECT COUNT(*) FROM confirmar_email WHERE hash_code = '" + txtVerificacao.Text + "' AND email = '" + txtEmail2.Text + "'", "DELETE FROM confirmar_email WHERE hash_expiration < NOW() OR hash_code_used = 1") == true)
            {
                connnector.Update("UPDATE confirmar_email SET hash_code_used = 1 WHERE email = '" + txtEmail2.Text + "'");
                connnector.Register("SELECT COUNT(*) FROM user_registos WHERE email = '" + txtEmail2.Text + "'", "INSERT INTO user_registos (name,email,phone,password,distrito,morada,gender,nacionalidade,birthday,num_utente,register_date) VALUES('" + txtNome.Text + "', '" + txtEmail2.Text + "', '" + txtTelefone.Text + "','" + Encryption.HashPassword(txtResetPass.Text) + "','" + cmbDistritos.Text + "','" + txtMorada.Text + "','" + cmbGenero.Text + "','" + cmbNacionalidade.Text + "','" + txtDataNasc.Text + "','" + txtNumeroCC.Text + "',now())");

                System.IO.Directory.CreateDirectory(txtNome.Text);

                MessageBox.Show(regisucc, info, MessageBoxButtons.OK, MessageBoxIcon.Information);


                frmLogin.reference = txtNome.Text;
                frmMed ChildForm = new frmMed();
                ChildForm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show(invalidcode, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                codeAttempts++;
            }


            if (codeAttempts == 4)
            {
                MessageBox.Show(maxattemps, warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                connnector.Delete("DELETE FROM confirmar_email WHERE email = '" + txtEmail2.Text + "'");

                frmLogin.reference = txtNome.Text;
                frmLogin lf = new frmLogin();
                lf.Show();
                this.Hide();
            }
        }

        public static bool Datas(string data)
        {
            Regex regex = new Regex(@"^\d{4}[\-\/\s]?((((0[13578])|(1[02]))[\-\/\s]?(([0-2][0-9])|(3[01])))|(((0[469])|(11))[\-\/\s]?(([0-2][0-9])|(30)))|(02[\-\/\s]?[0-2][0-9]))$");

            Match match = regex.Match(data);

            if (match.Success)
                return true;

            else
                return false;
        }


        public static bool IsPhoneValid(string phone)
        {
            if (phone == "")
                return true;

            Regex regex = new Regex(@"^9[1236][0-9]{7}$|^2[3-9][1-9][0-9]{6}$|^2[12][0-9]{7}$");

            Match match = regex.Match(phone);

            if (match.Success)
                return true;


            else
                return false;
        }
        private void frmRegistar_Load(object sender, EventArgs e)
        {
            cmbNacionalidade.SelectedItem = "Portugal";

            if (frmLogin.trad)
            {
                cmbNacionalidade.Items.Clear();
                for (int i = 0; i < nacionalidades.Count; i++)
                    cmbNacionalidade.Items.Add(nacionalidades[i]);
                cmbNacionalidade.SelectedIndex = 52;

                cmbGenero.Items.Clear();
                for (int i = 0; i < generos.Count; i++)
                    cmbGenero.Items.Add(generos[i]);

                this.Text = "Registo";
                tabctrlRegisto.TabPages[0].Text = "Informações";
                tabctrlRegisto.TabPages[1].Text = "Verificação";

                txtNome.Hint = "Nome de utilizador";
                txtDataNasc.Hint = "Data de nascimento (AAAA/MM/DD)";
                cmbGenero.Hint = "Género";
                cmbNacionalidade.Hint = "Nacionalidade";
                txtNumeroCC.Hint = "Número de sistema de saúde";
                txtTelefone.Hint = "Telemóvel/ telefone";
                txtMorada.Hint = "Morada";
                cmbDistritos.Hint = "Cidade";
                txtPass2.Hint = "Palavra-passe";
                txtResetPass.Hint = "Confirmar palavra passe";
                materialCheckbox1.Text = "Ver";
                butEnviarEmail.Text = "Enviar email com o código";
                txtVerificacao.Hint = "Código de verificação";
                butVerificar.Text = "Verificar";
                materialCheckbox2.Text = "Ver";
                regwillfail = "O registo não será concluído";
                invalidvalue = "Valor inváildo";
                error = "Erro";
                missingdata = "Preencha todos os campos primeiro";
                regfailled = "O registo falhou";
                wrongpass = "Palavra-passe errada";
                usernameexists = "Este nome de utilizador já foi escolhido, por favor indique outro";
                gmail = "Só aceitamos registos com endereço Gmail";
                info = "Informação";
                regisucc = "A sua conta foi criada com sucesso!";
                invalidcode = "Código inválido";
                maxattemps = "Atingiu o limite de tentativas";
                sendemail = "Olá! Aqui está o código de verificação: {0}";
                authmail = "Autenticação de conta";
                warning = "Aviso";
            }
        }

        private void txtDataNasc_Leave(object sender, EventArgs e)
        {
            if (txtDataNasc.Text == "")
                return;

            if (Datas(txtDataNasc.Text))
            {
                try
                {
                    DateTime data = DateTime.ParseExact(txtDataNasc.Text,
                    "yyyy/MM/dd", CultureInfo.InvariantCulture);
                    
                    if (data > DateTime.Now)
                    {
                        MessageBox.Show(invalidvalue, error,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtDataNasc.Clear();
                        txtDataNasc.Focus();
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show(invalidvalue, error,MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDataNasc.Clear();
                    txtDataNasc.Focus();
                }
            }
            else
            {
                MessageBox.Show(invalidvalue, error,MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataNasc.Clear();
                txtDataNasc.Focus();
            }
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            if (!IsPhoneValid(txtTelefone.Text))
            {
                MessageBox.Show(invalidvalue, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefone.Clear();
                txtTelefone.Focus();
            }
        }

        private void txtNumeroCC_Leave(object sender, EventArgs e)
        {
            if (txtNumeroCC.Text == "")
                return;
            if(txtNumeroCC.Text.Length!=9)
            {
                MessageBox.Show(invalidvalue, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroCC.Clear();
                txtNumeroCC.Focus();
                return;
            }
            try
            {
                int.Parse(txtNumeroCC.Text);
                return;
            }
            catch
            {
                MessageBox.Show(invalidvalue, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroCC.Clear();
                txtNumeroCC.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(regwillfail, frmLogin.exit, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            frmLogin ChildForm = new frmLogin();

            ChildForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabctrlRegisto.SelectedIndex = 1;
            txtPass2.Focus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tabctrlRegisto.SelectedIndex = 0;
            txtNome.Focus();
        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckbox1.Checked)
            {
                txtPass2.Password = false;
                txtResetPass.Password = false;
            }
            else
            {
                txtPass2.Password = true;
                txtResetPass.Password = true;
            }
        }

        private void materialCheckbox2_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckbox2.Checked)
            {
                txtVerificacao.Password = false;
            }
            else
            {
                txtVerificacao.Password = true;
            }
        }

        private void txtVerificacao_TextChanged(object sender, EventArgs e)
        {
            butVerificar.Enabled = txtVerificacao.Text != "";
        }


        private void frmRegistar_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    if (MessageBox.Show(frmLogin.sureexit, frmLogin.exit, MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
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
    }
}
