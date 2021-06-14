using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace Medicamentos
{
    public partial class FrmNewPass : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        Connector connector = new Connector();

        public FrmNewPass()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void butResetPass_Click(object sender, EventArgs e)
        {
            // Update The New Password In The Defenitive "users" Table In MySql. Plus We Insert Their Passsword Hashed With A Salt

            if (txtNewPass.Text == txtConfirmPass.Text)
            {
                connector.Update("UPDATE user_registos SET password= '" + Encryption.HashPassword(txtConfirmPass.Text) + "'  WHERE email= '" + RecoverForm.EmailText + "'");

                if (frmLogin.trad)
                    MessageBox.Show("Palavra-passe alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Password Successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmLogin lf = new frmLogin();
                lf.Show();
                this.Hide();
            }
            else
            {
                if (frmLogin.trad)
                    MessageBox.Show("As palavras-passe não correspondem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Passwords doesn't match!", "Failed Procedure", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNewPass.Text = "";
                txtConfirmPass.Text = "";
                txtNewPass.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmLogin inicio = new frmLogin();
            inicio.Show();
            this.Hide();
        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckbox1.Checked)
            {
                txtNewPass.Password = false;
                txtConfirmPass.Password = false;
            }
            else
            {
                txtNewPass.Password = true;
                txtConfirmPass.Password = true;
            }
        }

        private void FrmNewPass_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FrmNewPass_Load(object sender, EventArgs e)
        {
            if(frmLogin.trad)
            {
                txtNewPass.Hint = "Nova palavra-passe";
                txtConfirmPass.Hint = "Confirmar palavra-passe";
                butResetPass.Text = "Guardar";
                materialCheckbox1.Text = "Ver";
                this.Text = "Recuperação de password";
            }
        }
    }
}
