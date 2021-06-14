
namespace Medicamentos
{
    partial class frmRegistar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistar));
            this.tabctrlRegisto = new MaterialSkin.Controls.MaterialTabControl();
            this.page0 = new System.Windows.Forms.TabPage();
            this.cmbDistritos = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbGenero = new MaterialSkin.Controls.MaterialComboBox();
            this.txtTelefone = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMorada = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNumeroCC = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDataNasc = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbNacionalidade = new MaterialSkin.Controls.MaterialComboBox();
            this.txtNome = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.page1 = new System.Windows.Forms.TabPage();
            this.butEnviarEmail = new MaterialSkin.Controls.MaterialButton();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtResetPass = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPass2 = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.butVerificar = new MaterialSkin.Controls.MaterialButton();
            this.txtVerificacao = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabctrlRegisto.SuspendLayout();
            this.page0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.page1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabctrlRegisto
            // 
            this.tabctrlRegisto.Controls.Add(this.page0);
            this.tabctrlRegisto.Controls.Add(this.page1);
            this.tabctrlRegisto.Depth = 0;
            this.tabctrlRegisto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabctrlRegisto.ImageList = this.imageList1;
            this.tabctrlRegisto.Location = new System.Drawing.Point(3, 3);
            this.tabctrlRegisto.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabctrlRegisto.Multiline = true;
            this.tabctrlRegisto.Name = "tabctrlRegisto";
            this.tabctrlRegisto.SelectedIndex = 0;
            this.tabctrlRegisto.Size = new System.Drawing.Size(757, 525);
            this.tabctrlRegisto.TabIndex = 0;
            // 
            // page0
            // 
            this.page0.BackColor = System.Drawing.Color.White;
            this.page0.Controls.Add(this.cmbDistritos);
            this.page0.Controls.Add(this.cmbGenero);
            this.page0.Controls.Add(this.txtTelefone);
            this.page0.Controls.Add(this.txtMorada);
            this.page0.Controls.Add(this.txtNumeroCC);
            this.page0.Controls.Add(this.txtDataNasc);
            this.page0.Controls.Add(this.cmbNacionalidade);
            this.page0.Controls.Add(this.txtNome);
            this.page0.Controls.Add(this.pictureBox2);
            this.page0.Controls.Add(this.pictureBox1);
            this.page0.ImageKey = "exames.png";
            this.page0.Location = new System.Drawing.Point(4, 39);
            this.page0.Name = "page0";
            this.page0.Padding = new System.Windows.Forms.Padding(3);
            this.page0.Size = new System.Drawing.Size(749, 482);
            this.page0.TabIndex = 0;
            this.page0.Text = "Informations";
            // 
            // cmbDistritos
            // 
            this.cmbDistritos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cmbDistritos.Depth = 0;
            this.cmbDistritos.Font = new System.Drawing.Font("Roboto", 12F);
            this.cmbDistritos.Hint = "City";
            this.cmbDistritos.Location = new System.Drawing.Point(383, 334);
            this.cmbDistritos.MaxLength = 9;
            this.cmbDistritos.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbDistritos.Multiline = false;
            this.cmbDistritos.Name = "cmbDistritos";
            this.cmbDistritos.Size = new System.Drawing.Size(306, 50);
            this.cmbDistritos.TabIndex = 47;
            this.cmbDistritos.Text = "";
            // 
            // cmbGenero
            // 
            this.cmbGenero.AutoResize = false;
            this.cmbGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbGenero.Depth = 0;
            this.cmbGenero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbGenero.DropDownHeight = 174;
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.DropDownWidth = 121;
            this.cmbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Hint = "Gender";
            this.cmbGenero.IntegralHeight = false;
            this.cmbGenero.ItemHeight = 43;
            this.cmbGenero.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.cmbGenero.Location = new System.Drawing.Point(60, 200);
            this.cmbGenero.MaxDropDownItems = 4;
            this.cmbGenero.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(310, 49);
            this.cmbGenero.StartIndex = 0;
            this.cmbGenero.TabIndex = 46;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Depth = 0;
            this.txtTelefone.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtTelefone.Hint = "Phone number";
            this.txtTelefone.Location = new System.Drawing.Point(383, 269);
            this.txtTelefone.MaxLength = 9;
            this.txtTelefone.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefone.Multiline = false;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(306, 50);
            this.txtTelefone.TabIndex = 42;
            this.txtTelefone.Text = "";
            this.txtTelefone.Leave += new System.EventHandler(this.txtTelefone_Leave);
            // 
            // txtMorada
            // 
            this.txtMorada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMorada.Depth = 0;
            this.txtMorada.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMorada.Hint = "Address";
            this.txtMorada.Location = new System.Drawing.Point(60, 334);
            this.txtMorada.MaxLength = 100;
            this.txtMorada.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMorada.Multiline = false;
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(310, 50);
            this.txtMorada.TabIndex = 44;
            this.txtMorada.Text = "";
            // 
            // txtNumeroCC
            // 
            this.txtNumeroCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroCC.Depth = 0;
            this.txtNumeroCC.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtNumeroCC.Hint = "Health card number";
            this.txtNumeroCC.Location = new System.Drawing.Point(60, 269);
            this.txtNumeroCC.MaxLength = 9;
            this.txtNumeroCC.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumeroCC.Multiline = false;
            this.txtNumeroCC.Name = "txtNumeroCC";
            this.txtNumeroCC.Size = new System.Drawing.Size(310, 50);
            this.txtNumeroCC.TabIndex = 41;
            this.txtNumeroCC.Text = "";
            this.txtNumeroCC.Leave += new System.EventHandler(this.txtNumeroCC_Leave);
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataNasc.Depth = 0;
            this.txtDataNasc.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtDataNasc.Hint = " Birthday (YYYY/MM/DD)";
            this.txtDataNasc.Location = new System.Drawing.Point(383, 132);
            this.txtDataNasc.MaxLength = 50;
            this.txtDataNasc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDataNasc.Multiline = false;
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(306, 50);
            this.txtDataNasc.TabIndex = 40;
            this.txtDataNasc.Text = "";
            this.txtDataNasc.Leave += new System.EventHandler(this.txtDataNasc_Leave);
            // 
            // cmbNacionalidade
            // 
            this.cmbNacionalidade.AutoResize = false;
            this.cmbNacionalidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbNacionalidade.Depth = 0;
            this.cmbNacionalidade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbNacionalidade.DropDownHeight = 174;
            this.cmbNacionalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNacionalidade.DropDownWidth = 121;
            this.cmbNacionalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbNacionalidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbNacionalidade.FormattingEnabled = true;
            this.cmbNacionalidade.Hint = "Nationality";
            this.cmbNacionalidade.IntegralHeight = false;
            this.cmbNacionalidade.ItemHeight = 43;
            this.cmbNacionalidade.Items.AddRange(new object[] {
            "",
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "The Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo, Democratic Republic of the",
            "Congo, Republic of the",
            "Costa Rica",
            "Côte d’Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor (Timor-Leste)",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "The Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea, North",
            "Korea, South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia, Federated States of",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar (Burma)",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Macedonia",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Sudan, South",
            "Suriname",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.cmbNacionalidade.Location = new System.Drawing.Point(383, 200);
            this.cmbNacionalidade.MaxDropDownItems = 4;
            this.cmbNacionalidade.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbNacionalidade.Name = "cmbNacionalidade";
            this.cmbNacionalidade.Size = new System.Drawing.Size(306, 49);
            this.cmbNacionalidade.StartIndex = 0;
            this.cmbNacionalidade.TabIndex = 39;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtNome.Hint = "Username";
            this.txtNome.Location = new System.Drawing.Point(60, 132);
            this.txtNome.MaxLength = 100;
            this.txtNome.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(310, 50);
            this.txtNome.TabIndex = 38;
            this.txtNome.Text = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Medicamentos.Properties.Resources.next_button;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(653, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Medicamentos.Properties.Resources.back_button;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(60, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // page1
            // 
            this.page1.BackColor = System.Drawing.Color.White;
            this.page1.Controls.Add(this.butEnviarEmail);
            this.page1.Controls.Add(this.materialCheckbox1);
            this.page1.Controls.Add(this.txtResetPass);
            this.page1.Controls.Add(this.txtPass2);
            this.page1.Controls.Add(this.txtEmail2);
            this.page1.Controls.Add(this.materialCheckbox2);
            this.page1.Controls.Add(this.butVerificar);
            this.page1.Controls.Add(this.txtVerificacao);
            this.page1.Controls.Add(this.pictureBox3);
            this.page1.ImageKey = "conf.png";
            this.page1.Location = new System.Drawing.Point(4, 39);
            this.page1.Name = "page1";
            this.page1.Padding = new System.Windows.Forms.Padding(3);
            this.page1.Size = new System.Drawing.Size(749, 482);
            this.page1.TabIndex = 1;
            this.page1.Text = "Check";
            // 
            // butEnviarEmail
            // 
            this.butEnviarEmail.AutoSize = false;
            this.butEnviarEmail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butEnviarEmail.Depth = 0;
            this.butEnviarEmail.DrawShadows = true;
            this.butEnviarEmail.HighEmphasis = true;
            this.butEnviarEmail.Icon = null;
            this.butEnviarEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.butEnviarEmail.Location = new System.Drawing.Point(457, 269);
            this.butEnviarEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butEnviarEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.butEnviarEmail.Name = "butEnviarEmail";
            this.butEnviarEmail.Size = new System.Drawing.Size(228, 36);
            this.butEnviarEmail.TabIndex = 45;
            this.butEnviarEmail.Text = "Send code by email";
            this.butEnviarEmail.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butEnviarEmail.UseAccentColor = false;
            this.butEnviarEmail.UseVisualStyleBackColor = true;
            this.butEnviarEmail.Click += new System.EventHandler(this.butEnviarEmail_Click);
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.AutoSize = true;
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialCheckbox1.Location = new System.Drawing.Point(609, 170);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(75, 37);
            this.materialCheckbox1.TabIndex = 44;
            this.materialCheckbox1.Text = "Show";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            this.materialCheckbox1.CheckedChanged += new System.EventHandler(this.materialCheckbox1_CheckedChanged);
            // 
            // txtResetPass
            // 
            this.txtResetPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResetPass.Depth = 0;
            this.txtResetPass.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtResetPass.Hint = "Confirm password";
            this.txtResetPass.Location = new System.Drawing.Point(375, 117);
            this.txtResetPass.MaxLength = 100;
            this.txtResetPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtResetPass.Multiline = false;
            this.txtResetPass.Name = "txtResetPass";
            this.txtResetPass.Password = true;
            this.txtResetPass.Size = new System.Drawing.Size(309, 50);
            this.txtResetPass.TabIndex = 43;
            this.txtResetPass.Text = "";
            // 
            // txtPass2
            // 
            this.txtPass2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass2.Depth = 0;
            this.txtPass2.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtPass2.Hint = "Password";
            this.txtPass2.Location = new System.Drawing.Point(60, 117);
            this.txtPass2.MaxLength = 100;
            this.txtPass2.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPass2.Multiline = false;
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Password = true;
            this.txtPass2.Size = new System.Drawing.Size(309, 50);
            this.txtPass2.TabIndex = 42;
            this.txtPass2.Text = "";
            // 
            // txtEmail2
            // 
            this.txtEmail2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail2.Depth = 0;
            this.txtEmail2.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtEmail2.Hint = "Email";
            this.txtEmail2.Location = new System.Drawing.Point(61, 210);
            this.txtEmail2.MaxLength = 100;
            this.txtEmail2.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail2.Multiline = false;
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Size = new System.Drawing.Size(624, 50);
            this.txtEmail2.TabIndex = 41;
            this.txtEmail2.Text = "";
            // 
            // materialCheckbox2
            // 
            this.materialCheckbox2.AutoSize = true;
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialCheckbox2.Location = new System.Drawing.Point(295, 372);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(75, 37);
            this.materialCheckbox2.TabIndex = 40;
            this.materialCheckbox2.Text = "Show";
            this.materialCheckbox2.UseVisualStyleBackColor = true;
            this.materialCheckbox2.CheckedChanged += new System.EventHandler(this.materialCheckbox2_CheckedChanged);
            // 
            // butVerificar
            // 
            this.butVerificar.AutoSize = false;
            this.butVerificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butVerificar.Depth = 0;
            this.butVerificar.DrawShadows = true;
            this.butVerificar.Enabled = false;
            this.butVerificar.HighEmphasis = true;
            this.butVerificar.Icon = null;
            this.butVerificar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.butVerificar.Location = new System.Drawing.Point(61, 371);
            this.butVerificar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butVerificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.butVerificar.Name = "butVerificar";
            this.butVerificar.Size = new System.Drawing.Size(107, 36);
            this.butVerificar.TabIndex = 39;
            this.butVerificar.Text = "Check";
            this.butVerificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butVerificar.UseAccentColor = false;
            this.butVerificar.UseVisualStyleBackColor = true;
            this.butVerificar.Click += new System.EventHandler(this.butVerificar_Click);
            // 
            // txtVerificacao
            // 
            this.txtVerificacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVerificacao.Depth = 0;
            this.txtVerificacao.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtVerificacao.Hint = "Verification code";
            this.txtVerificacao.Location = new System.Drawing.Point(61, 314);
            this.txtVerificacao.MaxLength = 50;
            this.txtVerificacao.MouseState = MaterialSkin.MouseState.OUT;
            this.txtVerificacao.Multiline = false;
            this.txtVerificacao.Name = "txtVerificacao";
            this.txtVerificacao.Password = true;
            this.txtVerificacao.Size = new System.Drawing.Size(309, 50);
            this.txtVerificacao.TabIndex = 38;
            this.txtVerificacao.Text = "";
            this.txtVerificacao.TextChanged += new System.EventHandler(this.txtVerificacao_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Medicamentos.Properties.Resources.back_button;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(60, 64);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "conf.png");
            this.imageList1.Images.SetKeyName(1, "exames.png");
            // 
            // frmRegistar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 531);
            this.Controls.Add(this.tabctrlRegisto);
            this.DrawerTabControl = this.tabctrlRegisto;
            this.MinimizeBox = false;
            this.Name = "frmRegistar";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegistar_FormClosing);
            this.Load += new System.EventHandler(this.frmRegistar_Load);
            this.tabctrlRegisto.ResumeLayout(false);
            this.page0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.page1.ResumeLayout(false);
            this.page1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabctrlRegisto;
        private System.Windows.Forms.TabPage page0;
        private System.Windows.Forms.TabPage page1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialComboBox cmbGenero;
        public MaterialSkin.Controls.MaterialTextBox txtTelefone;
        public MaterialSkin.Controls.MaterialTextBox txtMorada;
        public MaterialSkin.Controls.MaterialTextBox txtNumeroCC;
        private MaterialSkin.Controls.MaterialTextBox txtDataNasc;
        private MaterialSkin.Controls.MaterialComboBox cmbNacionalidade;
        private MaterialSkin.Controls.MaterialTextBox txtNome;
        private MaterialSkin.Controls.MaterialButton butEnviarEmail;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        public MaterialSkin.Controls.MaterialTextBox txtResetPass;
        public MaterialSkin.Controls.MaterialTextBox txtPass2;
        public MaterialSkin.Controls.MaterialTextBox txtEmail2;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialButton butVerificar;
        private MaterialSkin.Controls.MaterialTextBox txtVerificacao;
        public MaterialSkin.Controls.MaterialTextBox cmbDistritos;
    }
}