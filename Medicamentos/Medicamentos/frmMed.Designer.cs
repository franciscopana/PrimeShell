
namespace Medicamentos
{
    partial class frmMed
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMed));
            this.tabctrlApp = new MaterialSkin.Controls.MaterialTabControl();
            this.tabCarac = new System.Windows.Forms.TabPage();
            this.img0i = new System.Windows.Forms.PictureBox();
            this.txtIMC = new MaterialSkin.Controls.MaterialTextBox();
            this.img0p = new System.Windows.Forms.PictureBox();
            this.butGravarCarac = new MaterialSkin.Controls.MaterialButton();
            this.cmbAtFis = new MaterialSkin.Controls.MaterialComboBox();
            this.txtAltura = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPeso = new MaterialSkin.Controls.MaterialTextBox();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.img1i = new System.Windows.Forms.PictureBox();
            this.img1p = new System.Windows.Forms.PictureBox();
            this.txtPrazoValidade = new MaterialSkin.Controls.MaterialTextBox();
            this.butChrome = new MaterialSkin.Controls.MaterialButton();
            this.butAddMed = new MaterialSkin.Controls.MaterialButton();
            this.txtAddPreco = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAddQuant = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAddNome = new MaterialSkin.Controls.MaterialTextBox();
            this.tabStock = new System.Windows.Forms.TabPage();
            this.txtSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.butRemoverStock = new MaterialSkin.Controls.MaterialButton();
            this.dataStock = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabGraficos = new System.Windows.Forms.TabPage();
            this.chartPrice = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMedQuantidade = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabAddNot = new System.Windows.Forms.TabPage();
            this.butAddRing = new MaterialSkin.Controls.MaterialButton();
            this.txtIntervalo = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSuspender = new MaterialSkin.Controls.MaterialButton();
            this.cmbRings = new MaterialSkin.Controls.MaterialComboBox();
            this.btnAlarme = new MaterialSkin.Controls.MaterialButton();
            this.txtDescription = new MaterialSkin.Controls.MaterialTextBox();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.img4i = new System.Windows.Forms.PictureBox();
            this.img4p = new System.Windows.Forms.PictureBox();
            this.tabNotfs = new System.Windows.Forms.TabPage();
            this.dtAlarmes = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStart2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBreak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTimers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butRemoveAlarm = new MaterialSkin.Controls.MaterialButton();
            this.tabSOS = new System.Windows.Forms.TabPage();
            this.img6i = new System.Windows.Forms.PictureBox();
            this.txtMessage = new MaterialSkin.Controls.MaterialTextBox();
            this.butEmergency = new MaterialSkin.Controls.MaterialButton();
            this.butAddEm = new MaterialSkin.Controls.MaterialButton();
            this.txtEmName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmGmail = new MaterialSkin.Controls.MaterialTextBox();
            this.butRemEm = new MaterialSkin.Controls.MaterialButton();
            this.dtEmergency = new System.Windows.Forms.DataGridView();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img6p = new System.Windows.Forms.PictureBox();
            this.tabSair = new System.Windows.Forms.TabPage();
            this.img8i2 = new System.Windows.Forms.PictureBox();
            this.img8p2 = new System.Windows.Forms.PictureBox();
            this.txtReport = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.img8i = new System.Windows.Forms.PictureBox();
            this.img8p = new System.Windows.Forms.PictureBox();
            this.chlkVer = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtDelPass = new MaterialSkin.Controls.MaterialTextBox();
            this.butSession = new MaterialSkin.Controls.MaterialButton();
            this.butAccount = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon3 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon4 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon5 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon6 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon7 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon8 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.tabctrlApp.SuspendLayout();
            this.tabCarac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img0i)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img0p)).BeginInit();
            this.tabAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img1i)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1p)).BeginInit();
            this.tabStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStock)).BeginInit();
            this.tabGraficos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMedQuantidade)).BeginInit();
            this.tabAddNot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img4i)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4p)).BeginInit();
            this.tabNotfs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlarmes)).BeginInit();
            this.tabSOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img6i)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmergency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img6p)).BeginInit();
            this.tabSair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img8i2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img8p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img8i)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img8p)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabctrlApp
            // 
            this.tabctrlApp.Controls.Add(this.tabCarac);
            this.tabctrlApp.Controls.Add(this.tabAdd);
            this.tabctrlApp.Controls.Add(this.tabStock);
            this.tabctrlApp.Controls.Add(this.tabGraficos);
            this.tabctrlApp.Controls.Add(this.tabAddNot);
            this.tabctrlApp.Controls.Add(this.tabNotfs);
            this.tabctrlApp.Controls.Add(this.tabSOS);
            this.tabctrlApp.Controls.Add(this.tabSair);
            this.tabctrlApp.Depth = 0;
            this.tabctrlApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabctrlApp.ImageList = this.imageList1;
            this.tabctrlApp.Location = new System.Drawing.Point(3, 3);
            this.tabctrlApp.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabctrlApp.Multiline = true;
            this.tabctrlApp.Name = "tabctrlApp";
            this.tabctrlApp.SelectedIndex = 0;
            this.tabctrlApp.Size = new System.Drawing.Size(880, 514);
            this.tabctrlApp.TabIndex = 0;
            // 
            // tabCarac
            // 
            this.tabCarac.BackColor = System.Drawing.Color.White;
            this.tabCarac.Controls.Add(this.img0i);
            this.tabCarac.Controls.Add(this.txtIMC);
            this.tabCarac.Controls.Add(this.img0p);
            this.tabCarac.Controls.Add(this.butGravarCarac);
            this.tabCarac.Controls.Add(this.cmbAtFis);
            this.tabCarac.Controls.Add(this.txtAltura);
            this.tabCarac.Controls.Add(this.txtPeso);
            this.tabCarac.ImageKey = "Daco_4361990.png";
            this.tabCarac.Location = new System.Drawing.Point(4, 39);
            this.tabCarac.Name = "tabCarac";
            this.tabCarac.Padding = new System.Windows.Forms.Padding(3);
            this.tabCarac.Size = new System.Drawing.Size(872, 471);
            this.tabCarac.TabIndex = 4;
            this.tabCarac.Text = "Phisiology";
            // 
            // img0i
            // 
            this.img0i.Image = global::Medicamentos.Properties.Resources.img0i;
            this.img0i.Location = new System.Drawing.Point(25, 89);
            this.img0i.Name = "img0i";
            this.img0i.Size = new System.Drawing.Size(404, 226);
            this.img0i.TabIndex = 6;
            this.img0i.TabStop = false;
            // 
            // txtIMC
            // 
            this.txtIMC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIMC.Depth = 0;
            this.txtIMC.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtIMC.Hint = "IMC";
            this.txtIMC.Location = new System.Drawing.Point(445, 154);
            this.txtIMC.MaxLength = 50;
            this.txtIMC.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIMC.Multiline = false;
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.ReadOnly = true;
            this.txtIMC.Size = new System.Drawing.Size(318, 50);
            this.txtIMC.TabIndex = 5;
            this.txtIMC.Text = "";
            // 
            // img0p
            // 
            this.img0p.Image = global::Medicamentos.Properties.Resources.apCar3;
            this.img0p.Location = new System.Drawing.Point(25, 55);
            this.img0p.Name = "img0p";
            this.img0p.Size = new System.Drawing.Size(404, 278);
            this.img0p.TabIndex = 4;
            this.img0p.TabStop = false;
            this.img0p.Visible = false;
            // 
            // butGravarCarac
            // 
            this.butGravarCarac.AutoSize = false;
            this.butGravarCarac.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butGravarCarac.Depth = 0;
            this.butGravarCarac.DrawShadows = true;
            this.butGravarCarac.HighEmphasis = true;
            this.butGravarCarac.Icon = null;
            this.butGravarCarac.Location = new System.Drawing.Point(445, 279);
            this.butGravarCarac.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butGravarCarac.MouseState = MaterialSkin.MouseState.HOVER;
            this.butGravarCarac.Name = "butGravarCarac";
            this.butGravarCarac.Size = new System.Drawing.Size(318, 36);
            this.butGravarCarac.TabIndex = 3;
            this.butGravarCarac.Text = "Update";
            this.butGravarCarac.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butGravarCarac.UseAccentColor = false;
            this.butGravarCarac.UseVisualStyleBackColor = true;
            this.butGravarCarac.Click += new System.EventHandler(this.butGravarCarac_Click);
            // 
            // cmbAtFis
            // 
            this.cmbAtFis.AutoResize = false;
            this.cmbAtFis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbAtFis.Depth = 0;
            this.cmbAtFis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbAtFis.DropDownHeight = 174;
            this.cmbAtFis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAtFis.DropDownWidth = 121;
            this.cmbAtFis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbAtFis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbAtFis.FormattingEnabled = true;
            this.cmbAtFis.Hint = "Physical Activity Level";
            this.cmbAtFis.IntegralHeight = false;
            this.cmbAtFis.ItemHeight = 43;
            this.cmbAtFis.Items.AddRange(new object[] {
            "1 - I never exercise",
            "2 - I rarely exercise",
            "3 - I exercise almost everyday",
            "4 - I exercise everyday"});
            this.cmbAtFis.Location = new System.Drawing.Point(445, 210);
            this.cmbAtFis.MaxDropDownItems = 4;
            this.cmbAtFis.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbAtFis.Name = "cmbAtFis";
            this.cmbAtFis.Size = new System.Drawing.Size(318, 49);
            this.cmbAtFis.StartIndex = 0;
            this.cmbAtFis.TabIndex = 2;
            // 
            // txtAltura
            // 
            this.txtAltura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAltura.Depth = 0;
            this.txtAltura.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtAltura.Hint = "Height";
            this.txtAltura.Location = new System.Drawing.Point(611, 98);
            this.txtAltura.MaxLength = 50;
            this.txtAltura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAltura.Multiline = false;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(152, 50);
            this.txtAltura.TabIndex = 1;
            this.txtAltura.Text = "";
            this.txtAltura.Leave += new System.EventHandler(this.txtAltura_Leave);
            // 
            // txtPeso
            // 
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeso.Depth = 0;
            this.txtPeso.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtPeso.Hint = "Weight";
            this.txtPeso.Location = new System.Drawing.Point(445, 98);
            this.txtPeso.MaxLength = 50;
            this.txtPeso.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPeso.Multiline = false;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(152, 50);
            this.txtPeso.TabIndex = 0;
            this.txtPeso.Text = "";
            this.txtPeso.Leave += new System.EventHandler(this.txtPeso_Leave);
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.Color.White;
            this.tabAdd.Controls.Add(this.img1i);
            this.tabAdd.Controls.Add(this.img1p);
            this.tabAdd.Controls.Add(this.txtPrazoValidade);
            this.tabAdd.Controls.Add(this.butChrome);
            this.tabAdd.Controls.Add(this.butAddMed);
            this.tabAdd.Controls.Add(this.txtAddPreco);
            this.tabAdd.Controls.Add(this.txtAddQuant);
            this.tabAdd.Controls.Add(this.txtAddNome);
            this.tabAdd.ImageKey = "medicine-3260.png";
            this.tabAdd.Location = new System.Drawing.Point(4, 39);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(872, 471);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "New Medication";
            // 
            // img1i
            // 
            this.img1i.Image = global::Medicamentos.Properties.Resources.img1i;
            this.img1i.Location = new System.Drawing.Point(33, 104);
            this.img1i.Name = "img1i";
            this.img1i.Size = new System.Drawing.Size(434, 250);
            this.img1i.TabIndex = 15;
            this.img1i.TabStop = false;
            // 
            // img1p
            // 
            this.img1p.Image = global::Medicamentos.Properties.Resources.aa;
            this.img1p.Location = new System.Drawing.Point(33, 88);
            this.img1p.Name = "img1p";
            this.img1p.Size = new System.Drawing.Size(434, 286);
            this.img1p.TabIndex = 14;
            this.img1p.TabStop = false;
            this.img1p.Visible = false;
            // 
            // txtPrazoValidade
            // 
            this.txtPrazoValidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrazoValidade.Depth = 0;
            this.txtPrazoValidade.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtPrazoValidade.Hint = "Expiration Date (YYYY/MM/DD)";
            this.txtPrazoValidade.Location = new System.Drawing.Point(488, 220);
            this.txtPrazoValidade.MaxLength = 50;
            this.txtPrazoValidade.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrazoValidade.Multiline = false;
            this.txtPrazoValidade.Name = "txtPrazoValidade";
            this.txtPrazoValidade.Size = new System.Drawing.Size(268, 50);
            this.txtPrazoValidade.TabIndex = 13;
            this.txtPrazoValidade.Text = "";
            this.txtPrazoValidade.Leave += new System.EventHandler(this.txtPrazoValidade_Leave);
            // 
            // butChrome
            // 
            this.butChrome.AutoSize = false;
            this.butChrome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butChrome.Depth = 0;
            this.butChrome.DrawShadows = true;
            this.butChrome.HighEmphasis = true;
            this.butChrome.Icon = null;
            this.butChrome.Location = new System.Drawing.Point(488, 335);
            this.butChrome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butChrome.MouseState = MaterialSkin.MouseState.HOVER;
            this.butChrome.Name = "butChrome";
            this.butChrome.Size = new System.Drawing.Size(268, 35);
            this.butChrome.TabIndex = 4;
            this.butChrome.Text = "Check Official Documentation";
            this.butChrome.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butChrome.UseAccentColor = false;
            this.butChrome.UseVisualStyleBackColor = true;
            this.butChrome.Click += new System.EventHandler(this.butChrome_Click);
            // 
            // butAddMed
            // 
            this.butAddMed.AutoSize = false;
            this.butAddMed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butAddMed.Depth = 0;
            this.butAddMed.DrawShadows = true;
            this.butAddMed.HighEmphasis = true;
            this.butAddMed.Icon = null;
            this.butAddMed.Location = new System.Drawing.Point(488, 288);
            this.butAddMed.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butAddMed.MouseState = MaterialSkin.MouseState.HOVER;
            this.butAddMed.Name = "butAddMed";
            this.butAddMed.Size = new System.Drawing.Size(268, 35);
            this.butAddMed.TabIndex = 3;
            this.butAddMed.Text = "Add Pills";
            this.butAddMed.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butAddMed.UseAccentColor = false;
            this.butAddMed.UseVisualStyleBackColor = true;
            this.butAddMed.Click += new System.EventHandler(this.butAddMed_Click);
            // 
            // txtAddPreco
            // 
            this.txtAddPreco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddPreco.Depth = 0;
            this.txtAddPreco.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtAddPreco.Hint = "Price (€)";
            this.txtAddPreco.Location = new System.Drawing.Point(630, 154);
            this.txtAddPreco.MaxLength = 50;
            this.txtAddPreco.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAddPreco.Multiline = false;
            this.txtAddPreco.Name = "txtAddPreco";
            this.txtAddPreco.Size = new System.Drawing.Size(126, 50);
            this.txtAddPreco.TabIndex = 2;
            this.txtAddPreco.Text = "";
            this.txtAddPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddPreco_KeyPress);
            // 
            // txtAddQuant
            // 
            this.txtAddQuant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddQuant.Depth = 0;
            this.txtAddQuant.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtAddQuant.Hint = "Quantity";
            this.txtAddQuant.Location = new System.Drawing.Point(488, 154);
            this.txtAddQuant.MaxLength = 50;
            this.txtAddQuant.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAddQuant.Multiline = false;
            this.txtAddQuant.Name = "txtAddQuant";
            this.txtAddQuant.Size = new System.Drawing.Size(126, 50);
            this.txtAddQuant.TabIndex = 1;
            this.txtAddQuant.Text = "";
            this.txtAddQuant.Leave += new System.EventHandler(this.txtAddQuant_Leave);
            // 
            // txtAddNome
            // 
            this.txtAddNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddNome.Depth = 0;
            this.txtAddNome.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtAddNome.Hint = "Medication Name";
            this.txtAddNome.Location = new System.Drawing.Point(488, 88);
            this.txtAddNome.MaxLength = 50;
            this.txtAddNome.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAddNome.Multiline = false;
            this.txtAddNome.Name = "txtAddNome";
            this.txtAddNome.Size = new System.Drawing.Size(268, 50);
            this.txtAddNome.TabIndex = 0;
            this.txtAddNome.Text = "";
            // 
            // tabStock
            // 
            this.tabStock.BackColor = System.Drawing.Color.White;
            this.tabStock.Controls.Add(this.txtSearch);
            this.tabStock.Controls.Add(this.butRemoverStock);
            this.tabStock.Controls.Add(this.dataStock);
            this.tabStock.ImageKey = "empty-white-box.png";
            this.tabStock.Location = new System.Drawing.Point(4, 39);
            this.tabStock.Name = "tabStock";
            this.tabStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabStock.Size = new System.Drawing.Size(872, 471);
            this.tabStock.TabIndex = 0;
            this.tabStock.Text = "Your Stock";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtSearch.Hint = "Search";
            this.txtSearch.Location = new System.Drawing.Point(77, 31);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(263, 50);
            this.txtSearch.TabIndex = 40;
            this.txtSearch.Text = "";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // butRemoverStock
            // 
            this.butRemoverStock.AutoSize = false;
            this.butRemoverStock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butRemoverStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butRemoverStock.Depth = 0;
            this.butRemoverStock.DrawShadows = true;
            this.butRemoverStock.HighEmphasis = true;
            this.butRemoverStock.Icon = null;
            this.butRemoverStock.Location = new System.Drawing.Point(77, 361);
            this.butRemoverStock.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butRemoverStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.butRemoverStock.Name = "butRemoverStock";
            this.butRemoverStock.Size = new System.Drawing.Size(146, 35);
            this.butRemoverStock.TabIndex = 39;
            this.butRemoverStock.Text = "Remove";
            this.butRemoverStock.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butRemoverStock.UseAccentColor = false;
            this.butRemoverStock.UseVisualStyleBackColor = true;
            this.butRemoverStock.Click += new System.EventHandler(this.butRemoverStock_Click);
            // 
            // dataStock
            // 
            this.dataStock.AllowUserToAddRows = false;
            this.dataStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataStock.Location = new System.Drawing.Point(77, 97);
            this.dataStock.Name = "dataStock";
            this.dataStock.Size = new System.Drawing.Size(623, 255);
            this.dataStock.TabIndex = 38;
            this.dataStock.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStock_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 220;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Expiration Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 180;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // tabGraficos
            // 
            this.tabGraficos.BackColor = System.Drawing.Color.White;
            this.tabGraficos.Controls.Add(this.chartPrice);
            this.tabGraficos.Controls.Add(this.chartMedQuantidade);
            this.tabGraficos.ImageKey = "bar+chart+currency+finance+report+statistics+icon-1320086011433421741_32.png";
            this.tabGraficos.Location = new System.Drawing.Point(4, 39);
            this.tabGraficos.Name = "tabGraficos";
            this.tabGraficos.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraficos.Size = new System.Drawing.Size(872, 471);
            this.tabGraficos.TabIndex = 2;
            this.tabGraficos.Text = "Stats";
            // 
            // chartPrice
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPrice.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPrice.Legends.Add(legend1);
            this.chartPrice.Location = new System.Drawing.Point(466, 6);
            this.chartPrice.Name = "chartPrice";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPrice.Series.Add(series1);
            this.chartPrice.Size = new System.Drawing.Size(363, 342);
            this.chartPrice.TabIndex = 3;
            this.chartPrice.Text = "chart1";
            // 
            // chartMedQuantidade
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMedQuantidade.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMedQuantidade.Legends.Add(legend2);
            this.chartMedQuantidade.Location = new System.Drawing.Point(6, 6);
            this.chartMedQuantidade.Name = "chartMedQuantidade";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Medication quantity";
            this.chartMedQuantidade.Series.Add(series2);
            this.chartMedQuantidade.Size = new System.Drawing.Size(488, 342);
            this.chartMedQuantidade.TabIndex = 2;
            this.chartMedQuantidade.Text = "chart1";
            // 
            // tabAddNot
            // 
            this.tabAddNot.BackColor = System.Drawing.Color.White;
            this.tabAddNot.Controls.Add(this.butAddRing);
            this.tabAddNot.Controls.Add(this.txtIntervalo);
            this.tabAddNot.Controls.Add(this.btnSuspender);
            this.tabAddNot.Controls.Add(this.cmbRings);
            this.tabAddNot.Controls.Add(this.btnAlarme);
            this.tabAddNot.Controls.Add(this.txtDescription);
            this.tabAddNot.Controls.Add(this.dateEnd);
            this.tabAddNot.Controls.Add(this.dateStart);
            this.tabAddNot.Controls.Add(this.img4i);
            this.tabAddNot.Controls.Add(this.img4p);
            this.tabAddNot.ImageKey = "add-notification.png";
            this.tabAddNot.Location = new System.Drawing.Point(4, 39);
            this.tabAddNot.Name = "tabAddNot";
            this.tabAddNot.Size = new System.Drawing.Size(872, 471);
            this.tabAddNot.TabIndex = 5;
            this.tabAddNot.Text = "Add Reminder";
            // 
            // butAddRing
            // 
            this.butAddRing.AutoSize = false;
            this.butAddRing.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butAddRing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAddRing.Depth = 0;
            this.butAddRing.DrawShadows = true;
            this.butAddRing.HighEmphasis = true;
            this.butAddRing.Icon = null;
            this.butAddRing.Location = new System.Drawing.Point(500, 137);
            this.butAddRing.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butAddRing.MouseState = MaterialSkin.MouseState.HOVER;
            this.butAddRing.Name = "butAddRing";
            this.butAddRing.Size = new System.Drawing.Size(264, 25);
            this.butAddRing.TabIndex = 36;
            this.butAddRing.Text = "Add Ringtone";
            this.butAddRing.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butAddRing.UseAccentColor = false;
            this.butAddRing.UseVisualStyleBackColor = true;
            this.butAddRing.Click += new System.EventHandler(this.butAddRing_Click);
            // 
            // txtIntervalo
            // 
            this.txtIntervalo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIntervalo.Depth = 0;
            this.txtIntervalo.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtIntervalo.Hint = "Time Gap";
            this.txtIntervalo.Location = new System.Drawing.Point(500, 282);
            this.txtIntervalo.MaxLength = 50;
            this.txtIntervalo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIntervalo.Multiline = false;
            this.txtIntervalo.Name = "txtIntervalo";
            this.txtIntervalo.Size = new System.Drawing.Size(264, 50);
            this.txtIntervalo.TabIndex = 33;
            this.txtIntervalo.Text = "";
            this.txtIntervalo.Leave += new System.EventHandler(this.txtIntervalo_Leave);
            // 
            // btnSuspender
            // 
            this.btnSuspender.AutoSize = false;
            this.btnSuspender.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSuspender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuspender.Depth = 0;
            this.btnSuspender.DrawShadows = true;
            this.btnSuspender.HighEmphasis = true;
            this.btnSuspender.Icon = null;
            this.btnSuspender.Location = new System.Drawing.Point(635, 341);
            this.btnSuspender.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSuspender.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSuspender.Name = "btnSuspender";
            this.btnSuspender.Size = new System.Drawing.Size(129, 35);
            this.btnSuspender.TabIndex = 32;
            this.btnSuspender.Text = "Suspend";
            this.btnSuspender.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSuspender.UseAccentColor = false;
            this.btnSuspender.UseVisualStyleBackColor = true;
            this.btnSuspender.Click += new System.EventHandler(this.btnSuspender_Click);
            // 
            // cmbRings
            // 
            this.cmbRings.AutoResize = false;
            this.cmbRings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbRings.Depth = 0;
            this.cmbRings.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbRings.DropDownHeight = 174;
            this.cmbRings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRings.DropDownWidth = 121;
            this.cmbRings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbRings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbRings.FormattingEnabled = true;
            this.cmbRings.Hint = "Ring";
            this.cmbRings.IntegralHeight = false;
            this.cmbRings.ItemHeight = 43;
            this.cmbRings.Location = new System.Drawing.Point(500, 171);
            this.cmbRings.MaxDropDownItems = 4;
            this.cmbRings.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbRings.Name = "cmbRings";
            this.cmbRings.Size = new System.Drawing.Size(264, 49);
            this.cmbRings.Sorted = true;
            this.cmbRings.StartIndex = 0;
            this.cmbRings.TabIndex = 31;
            // 
            // btnAlarme
            // 
            this.btnAlarme.AutoSize = false;
            this.btnAlarme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAlarme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlarme.Depth = 0;
            this.btnAlarme.DrawShadows = true;
            this.btnAlarme.HighEmphasis = true;
            this.btnAlarme.Icon = null;
            this.btnAlarme.Location = new System.Drawing.Point(500, 341);
            this.btnAlarme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAlarme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAlarme.Name = "btnAlarme";
            this.btnAlarme.Size = new System.Drawing.Size(129, 35);
            this.btnAlarme.TabIndex = 30;
            this.btnAlarme.Text = "Add Alarm";
            this.btnAlarme.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAlarme.UseAccentColor = false;
            this.btnAlarme.UseVisualStyleBackColor = true;
            this.btnAlarme.Click += new System.EventHandler(this.btnAlarme_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Depth = 0;
            this.txtDescription.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtDescription.Hint = "Description";
            this.txtDescription.Location = new System.Drawing.Point(501, 226);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescription.Multiline = false;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(263, 50);
            this.txtDescription.TabIndex = 29;
            this.txtDescription.Text = "";
            // 
            // dateEnd
            // 
            this.dateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateEnd.Location = new System.Drawing.Point(500, 102);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(264, 26);
            this.dateEnd.TabIndex = 28;
            // 
            // dateStart
            // 
            this.dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateStart.Location = new System.Drawing.Point(500, 70);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(264, 26);
            this.dateStart.TabIndex = 27;
            // 
            // img4i
            // 
            this.img4i.Image = global::Medicamentos.Properties.Resources.img4i;
            this.img4i.Location = new System.Drawing.Point(20, 85);
            this.img4i.Name = "img4i";
            this.img4i.Size = new System.Drawing.Size(440, 310);
            this.img4i.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img4i.TabIndex = 35;
            this.img4i.TabStop = false;
            // 
            // img4p
            // 
            this.img4p.Image = global::Medicamentos.Properties.Resources.imgAddNot2;
            this.img4p.Location = new System.Drawing.Point(20, 69);
            this.img4p.Name = "img4p";
            this.img4p.Size = new System.Drawing.Size(440, 310);
            this.img4p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img4p.TabIndex = 34;
            this.img4p.TabStop = false;
            this.img4p.Visible = false;
            // 
            // tabNotfs
            // 
            this.tabNotfs.BackColor = System.Drawing.Color.White;
            this.tabNotfs.Controls.Add(this.dtAlarmes);
            this.tabNotfs.Controls.Add(this.butRemoveAlarm);
            this.tabNotfs.ImageKey = "icon512.png";
            this.tabNotfs.Location = new System.Drawing.Point(4, 39);
            this.tabNotfs.Name = "tabNotfs";
            this.tabNotfs.Size = new System.Drawing.Size(872, 471);
            this.tabNotfs.TabIndex = 3;
            this.tabNotfs.Text = "Rem. Collection";
            // 
            // dtAlarmes
            // 
            this.dtAlarmes.AllowUserToAddRows = false;
            this.dtAlarmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAlarmes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colStart2,
            this.colEnd,
            this.colBreak,
            this.colTimers,
            this.colSong});
            this.dtAlarmes.Location = new System.Drawing.Point(16, 47);
            this.dtAlarmes.Name = "dtAlarmes";
            this.dtAlarmes.Size = new System.Drawing.Size(794, 277);
            this.dtAlarmes.TabIndex = 37;
            this.dtAlarmes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtAlarmes_CellMouseClick);
            // 
            // colName
            // 
            this.colName.HeaderText = "Description";
            this.colName.Name = "colName";
            this.colName.Width = 200;
            // 
            // colStart2
            // 
            this.colStart2.HeaderText = "Start Date";
            this.colStart2.Name = "colStart2";
            this.colStart2.Width = 180;
            // 
            // colEnd
            // 
            this.colEnd.HeaderText = "End Date";
            this.colEnd.Name = "colEnd";
            this.colEnd.Width = 180;
            // 
            // colBreak
            // 
            this.colBreak.HeaderText = "Time";
            this.colBreak.Name = "colBreak";
            this.colBreak.Width = 70;
            // 
            // colTimers
            // 
            this.colTimers.HeaderText = "Id";
            this.colTimers.Name = "colTimers";
            this.colTimers.ReadOnly = true;
            this.colTimers.Visible = false;
            this.colTimers.Width = 50;
            // 
            // colSong
            // 
            this.colSong.HeaderText = "Music";
            this.colSong.Name = "colSong";
            this.colSong.ReadOnly = true;
            this.colSong.Width = 120;
            // 
            // butRemoveAlarm
            // 
            this.butRemoveAlarm.AutoSize = false;
            this.butRemoveAlarm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butRemoveAlarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butRemoveAlarm.Depth = 0;
            this.butRemoveAlarm.DrawShadows = true;
            this.butRemoveAlarm.HighEmphasis = true;
            this.butRemoveAlarm.Icon = null;
            this.butRemoveAlarm.Location = new System.Drawing.Point(16, 333);
            this.butRemoveAlarm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butRemoveAlarm.MouseState = MaterialSkin.MouseState.HOVER;
            this.butRemoveAlarm.Name = "butRemoveAlarm";
            this.butRemoveAlarm.Size = new System.Drawing.Size(126, 35);
            this.butRemoveAlarm.TabIndex = 36;
            this.butRemoveAlarm.Text = "Remove";
            this.butRemoveAlarm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butRemoveAlarm.UseAccentColor = false;
            this.butRemoveAlarm.UseVisualStyleBackColor = true;
            this.butRemoveAlarm.Click += new System.EventHandler(this.butRemoveAlarm_Click);
            // 
            // tabSOS
            // 
            this.tabSOS.Controls.Add(this.img6i);
            this.tabSOS.Controls.Add(this.txtMessage);
            this.tabSOS.Controls.Add(this.butEmergency);
            this.tabSOS.Controls.Add(this.butAddEm);
            this.tabSOS.Controls.Add(this.txtEmName);
            this.tabSOS.Controls.Add(this.txtEmGmail);
            this.tabSOS.Controls.Add(this.butRemEm);
            this.tabSOS.Controls.Add(this.dtEmergency);
            this.tabSOS.Controls.Add(this.img6p);
            this.tabSOS.ImageKey = "pngwing.com.png";
            this.tabSOS.Location = new System.Drawing.Point(4, 39);
            this.tabSOS.Name = "tabSOS";
            this.tabSOS.Padding = new System.Windows.Forms.Padding(3);
            this.tabSOS.Size = new System.Drawing.Size(872, 471);
            this.tabSOS.TabIndex = 7;
            this.tabSOS.Text = "SOS";
            this.tabSOS.UseVisualStyleBackColor = true;
            // 
            // img6i
            // 
            this.img6i.Image = global::Medicamentos.Properties.Resources.IMGRFi32;
            this.img6i.Location = new System.Drawing.Point(43, 24);
            this.img6i.Name = "img6i";
            this.img6i.Size = new System.Drawing.Size(715, 90);
            this.img6i.TabIndex = 47;
            this.img6i.TabStop = false;
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Depth = 0;
            this.txtMessage.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMessage.Hint = "Message (optional)";
            this.txtMessage.Location = new System.Drawing.Point(506, 355);
            this.txtMessage.MaxLength = 50;
            this.txtMessage.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMessage.Multiline = false;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(265, 50);
            this.txtMessage.TabIndex = 46;
            this.txtMessage.Text = "";
            // 
            // butEmergency
            // 
            this.butEmergency.AutoSize = false;
            this.butEmergency.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butEmergency.BackColor = System.Drawing.Color.Red;
            this.butEmergency.Depth = 0;
            this.butEmergency.DrawShadows = true;
            this.butEmergency.HighEmphasis = true;
            this.butEmergency.Icon = null;
            this.butEmergency.Location = new System.Drawing.Point(43, 355);
            this.butEmergency.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butEmergency.MouseState = MaterialSkin.MouseState.HOVER;
            this.butEmergency.Name = "butEmergency";
            this.butEmergency.Size = new System.Drawing.Size(443, 50);
            this.butEmergency.TabIndex = 44;
            this.butEmergency.Text = "SOS";
            this.butEmergency.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butEmergency.UseAccentColor = false;
            this.butEmergency.UseVisualStyleBackColor = false;
            this.butEmergency.Click += new System.EventHandler(this.butEmergency_Click);
            // 
            // butAddEm
            // 
            this.butAddEm.AutoSize = false;
            this.butAddEm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butAddEm.Depth = 0;
            this.butAddEm.DrawShadows = true;
            this.butAddEm.HighEmphasis = true;
            this.butAddEm.Icon = null;
            this.butAddEm.Location = new System.Drawing.Point(506, 250);
            this.butAddEm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butAddEm.MouseState = MaterialSkin.MouseState.HOVER;
            this.butAddEm.Name = "butAddEm";
            this.butAddEm.Size = new System.Drawing.Size(265, 36);
            this.butAddEm.TabIndex = 43;
            this.butAddEm.Text = "Add to contacts";
            this.butAddEm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butAddEm.UseAccentColor = false;
            this.butAddEm.UseVisualStyleBackColor = true;
            this.butAddEm.Click += new System.EventHandler(this.butAddEm_Click);
            // 
            // txtEmName
            // 
            this.txtEmName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmName.Depth = 0;
            this.txtEmName.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtEmName.Hint = "Name";
            this.txtEmName.Location = new System.Drawing.Point(506, 135);
            this.txtEmName.MaxLength = 50;
            this.txtEmName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmName.Multiline = false;
            this.txtEmName.Name = "txtEmName";
            this.txtEmName.Size = new System.Drawing.Size(265, 50);
            this.txtEmName.TabIndex = 42;
            this.txtEmName.Text = "";
            // 
            // txtEmGmail
            // 
            this.txtEmGmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmGmail.Depth = 0;
            this.txtEmGmail.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtEmGmail.Hint = "Gmail";
            this.txtEmGmail.Location = new System.Drawing.Point(506, 191);
            this.txtEmGmail.MaxLength = 50;
            this.txtEmGmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmGmail.Multiline = false;
            this.txtEmGmail.Name = "txtEmGmail";
            this.txtEmGmail.Size = new System.Drawing.Size(265, 50);
            this.txtEmGmail.TabIndex = 41;
            this.txtEmGmail.Text = "";
            this.txtEmGmail.Leave += new System.EventHandler(this.txtEmGmail_Leave);
            // 
            // butRemEm
            // 
            this.butRemEm.AutoSize = false;
            this.butRemEm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butRemEm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butRemEm.Depth = 0;
            this.butRemEm.DrawShadows = true;
            this.butRemEm.HighEmphasis = true;
            this.butRemEm.Icon = null;
            this.butRemEm.Location = new System.Drawing.Point(506, 296);
            this.butRemEm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butRemEm.MouseState = MaterialSkin.MouseState.HOVER;
            this.butRemEm.Name = "butRemEm";
            this.butRemEm.Size = new System.Drawing.Size(265, 35);
            this.butRemEm.TabIndex = 40;
            this.butRemEm.Text = "Remove";
            this.butRemEm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butRemEm.UseAccentColor = false;
            this.butRemEm.UseVisualStyleBackColor = true;
            this.butRemEm.Click += new System.EventHandler(this.butRemEm_Click);
            // 
            // dtEmergency
            // 
            this.dtEmergency.AllowUserToAddRows = false;
            this.dtEmergency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEmergency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNome,
            this.colGmail});
            this.dtEmergency.Location = new System.Drawing.Point(43, 135);
            this.dtEmergency.Name = "dtEmergency";
            this.dtEmergency.Size = new System.Drawing.Size(443, 196);
            this.dtEmergency.TabIndex = 0;
            this.dtEmergency.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtEmergency_CellMouseClick);
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Name";
            this.colNome.Name = "colNome";
            this.colNome.Width = 150;
            // 
            // colGmail
            // 
            this.colGmail.HeaderText = "Gmail";
            this.colGmail.Name = "colGmail";
            this.colGmail.Width = 250;
            // 
            // img6p
            // 
            this.img6p.Image = global::Medicamentos.Properties.Resources.IMGRFP32;
            this.img6p.Location = new System.Drawing.Point(43, 11);
            this.img6p.Name = "img6p";
            this.img6p.Size = new System.Drawing.Size(715, 118);
            this.img6p.TabIndex = 45;
            this.img6p.TabStop = false;
            this.img6p.Visible = false;
            // 
            // tabSair
            // 
            this.tabSair.Controls.Add(this.img8i2);
            this.tabSair.Controls.Add(this.img8p2);
            this.tabSair.Controls.Add(this.txtReport);
            this.tabSair.Controls.Add(this.img8i);
            this.tabSair.Controls.Add(this.img8p);
            this.tabSair.Controls.Add(this.chlkVer);
            this.tabSair.Controls.Add(this.txtDelPass);
            this.tabSair.Controls.Add(this.butSession);
            this.tabSair.Controls.Add(this.butAccount);
            this.tabSair.ImageKey = "—Pngtree—vector logout icon_4184683.png";
            this.tabSair.Location = new System.Drawing.Point(4, 39);
            this.tabSair.Name = "tabSair";
            this.tabSair.Size = new System.Drawing.Size(872, 471);
            this.tabSair.TabIndex = 6;
            this.tabSair.Text = "Logout";
            this.tabSair.UseVisualStyleBackColor = true;
            // 
            // img8i2
            // 
            this.img8i2.Image = global::Medicamentos.Properties.Resources.img8i2;
            this.img8i2.Location = new System.Drawing.Point(56, 248);
            this.img8i2.Name = "img8i2";
            this.img8i2.Size = new System.Drawing.Size(373, 90);
            this.img8i2.TabIndex = 11;
            this.img8i2.TabStop = false;
            // 
            // img8p2
            // 
            this.img8p2.Image = global::Medicamentos.Properties.Resources.img8p2;
            this.img8p2.Location = new System.Drawing.Point(56, 248);
            this.img8p2.Name = "img8p2";
            this.img8p2.Size = new System.Drawing.Size(373, 80);
            this.img8p2.TabIndex = 10;
            this.img8p2.TabStop = false;
            this.img8p2.Visible = false;
            // 
            // txtReport
            // 
            this.txtReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReport.Depth = 0;
            this.txtReport.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtReport.Hint = "Report message (optional)";
            this.txtReport.Location = new System.Drawing.Point(508, 199);
            this.txtReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(242, 139);
            this.txtReport.TabIndex = 9;
            this.txtReport.Text = "";
            // 
            // img8i
            // 
            this.img8i.Image = global::Medicamentos.Properties.Resources.img8i;
            this.img8i.Location = new System.Drawing.Point(42, 82);
            this.img8i.Name = "img8i";
            this.img8i.Size = new System.Drawing.Size(387, 160);
            this.img8i.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img8i.TabIndex = 8;
            this.img8i.TabStop = false;
            // 
            // img8p
            // 
            this.img8p.Image = global::Medicamentos.Properties.Resources.img8p;
            this.img8p.Location = new System.Drawing.Point(56, 82);
            this.img8p.Name = "img8p";
            this.img8p.Size = new System.Drawing.Size(373, 160);
            this.img8p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img8p.TabIndex = 7;
            this.img8p.TabStop = false;
            this.img8p.Visible = false;
            // 
            // chlkVer
            // 
            this.chlkVer.AutoSize = true;
            this.chlkVer.Depth = 0;
            this.chlkVer.Location = new System.Drawing.Point(675, 159);
            this.chlkVer.Margin = new System.Windows.Forms.Padding(0);
            this.chlkVer.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chlkVer.MouseState = MaterialSkin.MouseState.HOVER;
            this.chlkVer.Name = "chlkVer";
            this.chlkVer.Ripple = true;
            this.chlkVer.Size = new System.Drawing.Size(75, 37);
            this.chlkVer.TabIndex = 3;
            this.chlkVer.Text = "Show";
            this.chlkVer.UseVisualStyleBackColor = true;
            this.chlkVer.CheckedChanged += new System.EventHandler(this.chlkVer_CheckedChanged);
            // 
            // txtDelPass
            // 
            this.txtDelPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDelPass.Depth = 0;
            this.txtDelPass.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtDelPass.Hint = "Password";
            this.txtDelPass.Location = new System.Drawing.Point(508, 106);
            this.txtDelPass.MaxLength = 50;
            this.txtDelPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDelPass.Multiline = false;
            this.txtDelPass.Name = "txtDelPass";
            this.txtDelPass.Password = true;
            this.txtDelPass.Size = new System.Drawing.Size(242, 50);
            this.txtDelPass.TabIndex = 2;
            this.txtDelPass.Text = "";
            this.txtDelPass.TextChanged += new System.EventHandler(this.txtDelPass_TextChanged);
            // 
            // butSession
            // 
            this.butSession.AutoSize = false;
            this.butSession.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSession.Depth = 0;
            this.butSession.DrawShadows = true;
            this.butSession.HighEmphasis = true;
            this.butSession.Icon = null;
            this.butSession.Location = new System.Drawing.Point(65, 357);
            this.butSession.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butSession.MouseState = MaterialSkin.MouseState.HOVER;
            this.butSession.Name = "butSession";
            this.butSession.Size = new System.Drawing.Size(364, 37);
            this.butSession.TabIndex = 1;
            this.butSession.Text = "Logout";
            this.butSession.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butSession.UseAccentColor = false;
            this.butSession.UseVisualStyleBackColor = true;
            this.butSession.Click += new System.EventHandler(this.butSession_Click);
            // 
            // butAccount
            // 
            this.butAccount.AutoSize = false;
            this.butAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAccount.Depth = 0;
            this.butAccount.DrawShadows = true;
            this.butAccount.Enabled = false;
            this.butAccount.HighEmphasis = true;
            this.butAccount.Icon = null;
            this.butAccount.Location = new System.Drawing.Point(508, 357);
            this.butAccount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.butAccount.Name = "butAccount";
            this.butAccount.Size = new System.Drawing.Size(242, 37);
            this.butAccount.TabIndex = 0;
            this.butAccount.Text = "Delete Account";
            this.butAccount.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butAccount.UseAccentColor = false;
            this.butAccount.UseVisualStyleBackColor = true;
            this.butAccount.Click += new System.EventHandler(this.butAccount_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "empty-white-box.png");
            this.imageList1.Images.SetKeyName(1, "medicine-3260.png");
            this.imageList1.Images.SetKeyName(2, "bar+chart+currency+finance+report+statistics+icon-1320086011433421741_32.png");
            this.imageList1.Images.SetKeyName(3, "icon512.png");
            this.imageList1.Images.SetKeyName(4, "noun_clock face_781184.png");
            this.imageList1.Images.SetKeyName(5, "Daco_4361990.png");
            this.imageList1.Images.SetKeyName(6, "noun_Add Time_47879.png");
            this.imageList1.Images.SetKeyName(7, "add-notification.png");
            this.imageList1.Images.SetKeyName(8, "—Pngtree—vector logout icon_4184683.png");
            this.imageList1.Images.SetKeyName(9, "pngwing.com.png");
            // 
            // timer1
            // 
            this.timer1.Tag = "timer1";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon2.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon2.Icon")));
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            this.notifyIcon2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon2_MouseDoubleClick);
            // 
            // timer2
            // 
            this.timer2.Tag = "timer2";
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // notifyIcon3
            // 
            this.notifyIcon3.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon3.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon3.Icon")));
            this.notifyIcon3.Text = "notifyIcon3";
            this.notifyIcon3.Visible = true;
            this.notifyIcon3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon3_MouseDoubleClick);
            // 
            // timer3
            // 
            this.timer3.Tag = "timer3";
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick_1);
            // 
            // notifyIcon4
            // 
            this.notifyIcon4.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon4.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon4.Icon")));
            this.notifyIcon4.Text = "notifyIcon4";
            this.notifyIcon4.Visible = true;
            this.notifyIcon4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon4_MouseDoubleClick);
            // 
            // timer4
            // 
            this.timer4.Tag = "timer4";
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick_1);
            // 
            // notifyIcon5
            // 
            this.notifyIcon5.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon5.Icon")));
            this.notifyIcon5.Text = "notifyIcon5";
            this.notifyIcon5.Visible = true;
            this.notifyIcon5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon5_MouseDoubleClick);
            // 
            // timer5
            // 
            this.timer5.Tag = "timer5";
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // notifyIcon6
            // 
            this.notifyIcon6.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon6.Icon")));
            this.notifyIcon6.Text = "notifyIcon6";
            this.notifyIcon6.Visible = true;
            this.notifyIcon6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon6_MouseDoubleClick);
            // 
            // timer6
            // 
            this.timer6.Tag = "timer6";
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // notifyIcon7
            // 
            this.notifyIcon7.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon7.Icon")));
            this.notifyIcon7.Text = "notifyIcon7";
            this.notifyIcon7.Visible = true;
            this.notifyIcon7.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon7_MouseDoubleClick);
            // 
            // timer7
            // 
            this.timer7.Tag = "timer7";
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // notifyIcon8
            // 
            this.notifyIcon8.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon8.Icon")));
            this.notifyIcon8.Text = "notifyIcon8";
            this.notifyIcon8.Visible = true;
            this.notifyIcon8.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon8_MouseDoubleClick);
            // 
            // timer8
            // 
            this.timer8.Tag = "timer8";
            this.timer8.Tick += new System.EventHandler(this.timer8_Tick);
            // 
            // frmMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 520);
            this.Controls.Add(this.tabctrlApp);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabctrlApp;
            this.MaximizeBox = false;
            this.Name = "frmMed";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrimeShell";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMed_FormClosing);
            this.Load += new System.EventHandler(this.frmMed_Load);
            this.tabctrlApp.ResumeLayout(false);
            this.tabCarac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img0i)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img0p)).EndInit();
            this.tabAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img1i)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1p)).EndInit();
            this.tabStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataStock)).EndInit();
            this.tabGraficos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMedQuantidade)).EndInit();
            this.tabAddNot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img4i)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4p)).EndInit();
            this.tabNotfs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtAlarmes)).EndInit();
            this.tabSOS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img6i)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmergency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img6p)).EndInit();
            this.tabSair.ResumeLayout(false);
            this.tabSair.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img8i2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img8p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img8i)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img8p)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabctrlApp;
        private System.Windows.Forms.TabPage tabStock;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabGraficos;
        private System.Windows.Forms.TabPage tabNotfs;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabCarac;
        private System.Windows.Forms.PictureBox img0p;
        private MaterialSkin.Controls.MaterialButton butGravarCarac;
        private MaterialSkin.Controls.MaterialComboBox cmbAtFis;
        private MaterialSkin.Controls.MaterialTextBox txtAltura;
        private MaterialSkin.Controls.MaterialTextBox txtPeso;
        private MaterialSkin.Controls.MaterialButton butAddMed;
        private MaterialSkin.Controls.MaterialTextBox txtAddPreco;
        private MaterialSkin.Controls.MaterialTextBox txtAddQuant;
        private MaterialSkin.Controls.MaterialTextBox txtAddNome;
        private MaterialSkin.Controls.MaterialButton butChrome;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private MaterialSkin.Controls.MaterialTextBox txtPrazoValidade;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NotifyIcon notifyIcon3;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.NotifyIcon notifyIcon4;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.TabPage tabAddNot;
        private System.Windows.Forms.DataGridView dtAlarmes;
        private MaterialSkin.Controls.MaterialButton butRemoveAlarm;
        private MaterialSkin.Controls.MaterialTextBox txtIntervalo;
        private MaterialSkin.Controls.MaterialButton btnSuspender;
        private MaterialSkin.Controls.MaterialComboBox cmbRings;
        private MaterialSkin.Controls.MaterialButton btnAlarme;
        private MaterialSkin.Controls.MaterialTextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.PictureBox img4p;
        private System.Windows.Forms.PictureBox img1p;
        private System.Windows.Forms.DataGridView dataStock;
        private MaterialSkin.Controls.MaterialTextBox txtIMC;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMedQuantidade;
        private MaterialSkin.Controls.MaterialButton butRemoverStock;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TabPage tabSair;
        private MaterialSkin.Controls.MaterialTextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStart2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBreak;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSong;
        private System.Windows.Forms.PictureBox img0i;
        private System.Windows.Forms.PictureBox img1i;
        private System.Windows.Forms.PictureBox img4i;
        private System.Windows.Forms.NotifyIcon notifyIcon5;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.NotifyIcon notifyIcon6;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.NotifyIcon notifyIcon7;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.NotifyIcon notifyIcon8;
        private System.Windows.Forms.Timer timer8;
        private MaterialSkin.Controls.MaterialButton butAddRing;
        private System.Windows.Forms.TabPage tabSOS;
        private MaterialSkin.Controls.MaterialButton butEmergency;
        private MaterialSkin.Controls.MaterialButton butAddEm;
        private MaterialSkin.Controls.MaterialTextBox txtEmName;
        private MaterialSkin.Controls.MaterialTextBox txtEmGmail;
        private MaterialSkin.Controls.MaterialButton butRemEm;
        private System.Windows.Forms.DataGridView dtEmergency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGmail;
        private System.Windows.Forms.PictureBox img6p;
        private MaterialSkin.Controls.MaterialTextBox txtMessage;
        private System.Windows.Forms.PictureBox img6i;
        private MaterialSkin.Controls.MaterialButton butSession;
        private MaterialSkin.Controls.MaterialButton butAccount;
        private MaterialSkin.Controls.MaterialTextBox txtDelPass;
        private MaterialSkin.Controls.MaterialCheckbox chlkVer;
        private System.Windows.Forms.PictureBox img8p;
        private System.Windows.Forms.PictureBox img8i;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtReport;
        private System.Windows.Forms.PictureBox img8p2;
        private System.Windows.Forms.PictureBox img8i2;
    }
}