
namespace Medicamentos
{
    partial class RecoverForm
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
            this.butAuthentication = new MaterialSkin.Controls.MaterialButton();
            this.butSendCode = new MaterialSkin.Controls.MaterialButton();
            this.VerifyCodetxt = new MaterialSkin.Controls.MaterialTextBox();
            this.PassRecoverEmailtxt = new MaterialSkin.Controls.MaterialTextBox();
            this.imgRFI = new System.Windows.Forms.PictureBox();
            this.imgRFP = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgRFI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRFP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // butAuthentication
            // 
            this.butAuthentication.AutoSize = false;
            this.butAuthentication.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butAuthentication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAuthentication.Depth = 0;
            this.butAuthentication.DrawShadows = true;
            this.butAuthentication.HighEmphasis = true;
            this.butAuthentication.Icon = null;
            this.butAuthentication.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.butAuthentication.Location = new System.Drawing.Point(394, 354);
            this.butAuthentication.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butAuthentication.MouseState = MaterialSkin.MouseState.HOVER;
            this.butAuthentication.Name = "butAuthentication";
            this.butAuthentication.Size = new System.Drawing.Size(145, 50);
            this.butAuthentication.TabIndex = 48;
            this.butAuthentication.Text = "Authentication";
            this.butAuthentication.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butAuthentication.UseAccentColor = false;
            this.butAuthentication.UseVisualStyleBackColor = true;
            this.butAuthentication.Click += new System.EventHandler(this.butAuthentication_Click);
            // 
            // butSendCode
            // 
            this.butSendCode.AutoSize = false;
            this.butSendCode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butSendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSendCode.Depth = 0;
            this.butSendCode.DrawShadows = true;
            this.butSendCode.HighEmphasis = true;
            this.butSendCode.Icon = null;
            this.butSendCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.butSendCode.Location = new System.Drawing.Point(394, 294);
            this.butSendCode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butSendCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.butSendCode.Name = "butSendCode";
            this.butSendCode.Size = new System.Drawing.Size(145, 50);
            this.butSendCode.TabIndex = 47;
            this.butSendCode.Text = "Send Code";
            this.butSendCode.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butSendCode.UseAccentColor = false;
            this.butSendCode.UseVisualStyleBackColor = true;
            this.butSendCode.Click += new System.EventHandler(this.butSendCode_Click);
            // 
            // VerifyCodetxt
            // 
            this.VerifyCodetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VerifyCodetxt.Depth = 0;
            this.VerifyCodetxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.VerifyCodetxt.Hint = "Code";
            this.VerifyCodetxt.Location = new System.Drawing.Point(54, 354);
            this.VerifyCodetxt.MaxLength = 50;
            this.VerifyCodetxt.MouseState = MaterialSkin.MouseState.OUT;
            this.VerifyCodetxt.Multiline = false;
            this.VerifyCodetxt.Name = "VerifyCodetxt";
            this.VerifyCodetxt.Size = new System.Drawing.Size(333, 50);
            this.VerifyCodetxt.TabIndex = 46;
            this.VerifyCodetxt.Text = "";
            // 
            // PassRecoverEmailtxt
            // 
            this.PassRecoverEmailtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassRecoverEmailtxt.Depth = 0;
            this.PassRecoverEmailtxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.PassRecoverEmailtxt.Hint = "Gmail";
            this.PassRecoverEmailtxt.Location = new System.Drawing.Point(54, 294);
            this.PassRecoverEmailtxt.MaxLength = 50;
            this.PassRecoverEmailtxt.MouseState = MaterialSkin.MouseState.OUT;
            this.PassRecoverEmailtxt.Multiline = false;
            this.PassRecoverEmailtxt.Name = "PassRecoverEmailtxt";
            this.PassRecoverEmailtxt.Size = new System.Drawing.Size(333, 50);
            this.PassRecoverEmailtxt.TabIndex = 45;
            this.PassRecoverEmailtxt.Text = "";
            // 
            // imgRFI
            // 
            this.imgRFI.Image = global::Medicamentos.Properties.Resources.imgRFI2;
            this.imgRFI.Location = new System.Drawing.Point(45, 154);
            this.imgRFI.Name = "imgRFI";
            this.imgRFI.Size = new System.Drawing.Size(515, 111);
            this.imgRFI.TabIndex = 55;
            this.imgRFI.TabStop = false;
            // 
            // imgRFP
            // 
            this.imgRFP.Image = global::Medicamentos.Properties.Resources.imgRFP;
            this.imgRFP.Location = new System.Drawing.Point(45, 154);
            this.imgRFP.Name = "imgRFP";
            this.imgRFP.Size = new System.Drawing.Size(485, 111);
            this.imgRFP.TabIndex = 54;
            this.imgRFP.TabStop = false;
            this.imgRFP.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Medicamentos.Properties.Resources.back_button;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(54, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RecoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 485);
            this.Controls.Add(this.imgRFI);
            this.Controls.Add(this.imgRFP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butAuthentication);
            this.Controls.Add(this.butSendCode);
            this.Controls.Add(this.VerifyCodetxt);
            this.Controls.Add(this.PassRecoverEmailtxt);
            this.MaximizeBox = false;
            this.Name = "RecoverForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identity Verification";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RecoverForm_FormClosing);
            this.Load += new System.EventHandler(this.RecoverForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgRFI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRFP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton butAuthentication;
        private MaterialSkin.Controls.MaterialButton butSendCode;
        private MaterialSkin.Controls.MaterialTextBox VerifyCodetxt;
        private MaterialSkin.Controls.MaterialTextBox PassRecoverEmailtxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgRFP;
        private System.Windows.Forms.PictureBox imgRFI;
    }
}