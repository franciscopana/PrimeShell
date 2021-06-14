using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace Medicamentos
{
    public partial class frmLogin : MaterialForm
    {
        Connector connector = new Connector();

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public static string reference = "";

        public static bool trad = false;

        public static string sureexit;

        public static string exit;

        string wrongdata;
        string dataerror;
        string fill;
        string emptyalues;

        public frmLogin()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void butAceder_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show(fill, emptyalues, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (connector.ValidatePassword("SELECT password FROM user_registos WHERE name= '" + txtUser.Text + "'", txtPass.Text) == true)
                {
                    reference = txtUser.Text;

                    frmMed next = new frmMed();
                    next.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show(wrongdata, dataerror, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Text = "";
                    txtPass.Text = "";
                    txtUser.Focus();
                    chkVerPass.Checked = false;
                }
            }
        }

        private void chkVerPass_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPass.Password == true)
                txtPass.Password = false;
            else
                txtPass.Password = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistar registar = new frmRegistar();
            registar.Show();
            this.Hide();
        }

        private void lblForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecoverForm recpass = new RecoverForm();
            recpass.Show();
            this.Hide();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    if (MessageBox.Show(sureexit, exit, MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
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

        private void SetPortuguese()
        {
            this.Text = "Bem-vindo!";
            txtUser.Hint = "Nome de utilizador";
            txtPass.Hint = "Palavra passe";
            lblForgot.Text = "Esqueceu a sua password?";
            chkVerPass.Text = "Ver";
            butAceder.Text = "Entrar";
            linkLabel1.Text = "Não tem uma conta?\nRegiste-se agora!";

            sureexit = "Tem a certeza que deseja sair?";
            exit = "Sair";
            wrongdata = "Dados incorretos, confirme o nome de utilizador ou a palavra-passe";
            dataerror = "Validação falhou";
            fill = "Preencha os campos primeiro";
            emptyalues = "Valores em falta";
        }

        private void SetEnglish()
        {
            sureexit = "Are you sure you want to exit?";
            exit = "Exit";
            wrongdata = "Data entered was not correct...Please check your password or username";
            dataerror = "Data error";
            fill = "Fill all input box's before trying to login";
            emptyalues = "Empty values";
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if(trad==false)
            {
                SetEnglish();
                cmbLanguages.SelectedIndex = 0;
            }
            else
            {
                SetPortuguese();
                cmbLanguages.SelectedIndex = 1;
            }
                
        }

        private void cmbLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbLanguages.SelectedIndex == 0)
            {
                trad = false;
                this.Text = "Welcome!";
                txtUser.Hint = "Username";
                txtPass.Hint = "Password";
                lblForgot.Text = "Forgot your password?";
                chkVerPass.Text = "Show";
                butAceder.Text = "Login";
                linkLabel1.Text = "Don't have an account?\nRegister now!";

                SetEnglish();
            }
            else
            {
                trad = true;
                SetPortuguese();
            }
        }
    }
}
