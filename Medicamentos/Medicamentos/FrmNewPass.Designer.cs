
namespace Medicamentos
{
    partial class FrmNewPass
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
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.butResetPass = new MaterialSkin.Controls.MaterialButton();
            this.txtConfirmPass = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNewPass = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.AutoSize = true;
            this.materialCheckbox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialCheckbox1.Location = new System.Drawing.Point(329, 264);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(75, 37);
            this.materialCheckbox1.TabIndex = 39;
            this.materialCheckbox1.Text = "Show";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            this.materialCheckbox1.CheckedChanged += new System.EventHandler(this.materialCheckbox1_CheckedChanged);
            // 
            // butResetPass
            // 
            this.butResetPass.AutoSize = false;
            this.butResetPass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butResetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butResetPass.Depth = 0;
            this.butResetPass.DrawShadows = true;
            this.butResetPass.HighEmphasis = true;
            this.butResetPass.Icon = null;
            this.butResetPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.butResetPass.Location = new System.Drawing.Point(42, 263);
            this.butResetPass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butResetPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.butResetPass.Name = "butResetPass";
            this.butResetPass.Size = new System.Drawing.Size(162, 37);
            this.butResetPass.TabIndex = 38;
            this.butResetPass.Text = "Save Changes";
            this.butResetPass.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butResetPass.UseAccentColor = false;
            this.butResetPass.UseVisualStyleBackColor = true;
            this.butResetPass.Click += new System.EventHandler(this.butResetPass_Click);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPass.Depth = 0;
            this.txtConfirmPass.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtConfirmPass.Hint = "Confirm Password";
            this.txtConfirmPass.Location = new System.Drawing.Point(42, 204);
            this.txtConfirmPass.MaxLength = 50;
            this.txtConfirmPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConfirmPass.Multiline = false;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Password = true;
            this.txtConfirmPass.Size = new System.Drawing.Size(362, 50);
            this.txtConfirmPass.TabIndex = 37;
            this.txtConfirmPass.Text = "";
            // 
            // txtNewPass
            // 
            this.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPass.Depth = 0;
            this.txtNewPass.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtNewPass.Hint = "New Password";
            this.txtNewPass.Location = new System.Drawing.Point(42, 148);
            this.txtNewPass.MaxLength = 50;
            this.txtNewPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNewPass.Multiline = false;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Password = true;
            this.txtNewPass.Size = new System.Drawing.Size(362, 50);
            this.txtNewPass.TabIndex = 36;
            this.txtNewPass.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Medicamentos.Properties.Resources.back_button;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(42, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmNewPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 383);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialCheckbox1);
            this.Controls.Add(this.butResetPass);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtNewPass);
            this.MaximizeBox = false;
            this.Name = "FrmNewPass";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recover Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNewPass_FormClosing);
            this.Load += new System.EventHandler(this.FrmNewPass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialButton butResetPass;
        private MaterialSkin.Controls.MaterialTextBox txtConfirmPass;
        private MaterialSkin.Controls.MaterialTextBox txtNewPass;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}