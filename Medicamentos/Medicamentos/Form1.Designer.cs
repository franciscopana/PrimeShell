
namespace Medicamentos
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblForgot = new System.Windows.Forms.LinkLabel();
            this.chkVerPass = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtPass = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUser = new MaterialSkin.Controls.MaterialTextBox();
            this.butAceder = new MaterialSkin.Controls.MaterialButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbLanguages = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForgot
            // 
            this.lblForgot.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lblForgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblForgot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblForgot.LinkColor = System.Drawing.Color.Black;
            this.lblForgot.Location = new System.Drawing.Point(64, 382);
            this.lblForgot.Name = "lblForgot";
            this.lblForgot.Size = new System.Drawing.Size(206, 25);
            this.lblForgot.TabIndex = 13;
            this.lblForgot.TabStop = true;
            this.lblForgot.Text = "Forgot your password?";
            this.lblForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblForgot_LinkClicked);
            // 
            // chkVerPass
            // 
            this.chkVerPass.AutoSize = true;
            this.chkVerPass.Depth = 0;
            this.chkVerPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkVerPass.Location = new System.Drawing.Point(343, 376);
            this.chkVerPass.Margin = new System.Windows.Forms.Padding(0);
            this.chkVerPass.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkVerPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkVerPass.Name = "chkVerPass";
            this.chkVerPass.Ripple = true;
            this.chkVerPass.Size = new System.Drawing.Size(75, 37);
            this.chkVerPass.TabIndex = 10;
            this.chkVerPass.Text = "Show";
            this.chkVerPass.UseVisualStyleBackColor = true;
            this.chkVerPass.CheckedChanged += new System.EventHandler(this.chkVerPass_CheckedChanged);
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Depth = 0;
            this.txtPass.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtPass.Hint = "Password";
            this.txtPass.Location = new System.Drawing.Point(68, 323);
            this.txtPass.MaxLength = 50;
            this.txtPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.Password = true;
            this.txtPass.Size = new System.Drawing.Size(350, 50);
            this.txtPass.TabIndex = 9;
            this.txtPass.Text = "";
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Depth = 0;
            this.txtUser.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtUser.Hint = "Username";
            this.txtUser.Location = new System.Drawing.Point(68, 267);
            this.txtUser.MaxLength = 50;
            this.txtUser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUser.Multiline = false;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(350, 50);
            this.txtUser.TabIndex = 8;
            this.txtUser.Text = "";
            // 
            // butAceder
            // 
            this.butAceder.AutoSize = false;
            this.butAceder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butAceder.Depth = 0;
            this.butAceder.DrawShadows = true;
            this.butAceder.HighEmphasis = true;
            this.butAceder.Icon = null;
            this.butAceder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.butAceder.Location = new System.Drawing.Point(163, 438);
            this.butAceder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butAceder.MouseState = MaterialSkin.MouseState.HOVER;
            this.butAceder.Name = "butAceder";
            this.butAceder.Size = new System.Drawing.Size(158, 36);
            this.butAceder.TabIndex = 7;
            this.butAceder.Text = "Login";
            this.butAceder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butAceder.UseAccentColor = false;
            this.butAceder.UseVisualStyleBackColor = true;
            this.butAceder.Click += new System.EventHandler(this.butAceder_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(140, 492);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(206, 43);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Don\'t have an account? Register Now!";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Medicamentos.Properties.Resources.loginescolhido;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(163, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // cmbLanguages
            // 
            this.cmbLanguages.AutoResize = false;
            this.cmbLanguages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbLanguages.Depth = 0;
            this.cmbLanguages.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbLanguages.DropDownHeight = 118;
            this.cmbLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguages.DropDownWidth = 121;
            this.cmbLanguages.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbLanguages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbLanguages.FormattingEnabled = true;
            this.cmbLanguages.IntegralHeight = false;
            this.cmbLanguages.ItemHeight = 29;
            this.cmbLanguages.Items.AddRange(new object[] {
            "EN",
            "PT"});
            this.cmbLanguages.Location = new System.Drawing.Point(391, 27);
            this.cmbLanguages.MaxDropDownItems = 4;
            this.cmbLanguages.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbLanguages.Name = "cmbLanguages";
            this.cmbLanguages.Size = new System.Drawing.Size(86, 35);
            this.cmbLanguages.StartIndex = 0;
            this.cmbLanguages.TabIndex = 15;
            this.cmbLanguages.UseTallSize = false;
            this.cmbLanguages.SelectedIndexChanged += new System.EventHandler(this.cmbLanguages_SelectedIndexChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 555);
            this.Controls.Add(this.cmbLanguages);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblForgot);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkVerPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.butAceder);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblForgot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCheckbox chkVerPass;
        private MaterialSkin.Controls.MaterialTextBox txtPass;
        private MaterialSkin.Controls.MaterialTextBox txtUser;
        private MaterialSkin.Controls.MaterialButton butAceder;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MaterialSkin.Controls.MaterialComboBox cmbLanguages;
    }
}

