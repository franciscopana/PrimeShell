using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Medicamentos
{
    public partial class frmMed : MaterialForm
    {
        Connector connnector = new Connector();

        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        private Dictionary<string, Timer> timers = new Dictionary<string, Timer>();

        //int selected;

        string selectRow;

        string emergencyMail;

        bool first_set = true;

        bool aux = true;

        bool aux2 = true;

        bool limit = false;

        bool flag = true;

        string music_path_1;

        string music_path_2;

        string music_path_3;

        string music_path_4;

        string music_path_5;

        string music_path_6;

        string music_path_7;

        string music_path_8;

        DateTime date_end_1;

        DateTime date_end_2;

        DateTime date_end_3;

        DateTime date_end_4;

        DateTime date_end_5;

        DateTime date_end_6;

        DateTime date_end_7;

        DateTime date_end_8;

        string medquant = "Medication quantity";
        string infomissing = "Absence of information";
        string error = "Error";
        string maxalarms = "There only can be 8 alarms at a time! Select one of them to replace by the new reminder";
        string warning = "Warning";
        string surereminder = "Your reminder will be added";
        string sure = "Are you sure?";

        public frmMed()
        {
            InitializeComponent();
            InitializeDialogFields();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void frmMed_Load(object sender, EventArgs e)
        {

            // fazer a tradução caso a língua esteja em português

            if (frmLogin.trad)
            {
                tabctrlApp.TabPages[0].Text = "Características";
                tabctrlApp.TabPages[1].Text = "Nova medicação";
                tabctrlApp.TabPages[2].Text = "Stock";
                tabctrlApp.TabPages[3].Text = "Estatísticas";
                tabctrlApp.TabPages[4].Text = "Ad. alarme";
                tabctrlApp.TabPages[5].Text = "Alarmes";
                tabctrlApp.TabPages[7].Text = "Sair";

                txtPeso.Hint = "Peso";
                txtAltura.Hint = "Altura";
                cmbAtFis.Hint = "Nível de atividade";
                butGravarCarac.Text = "Atualizar";

                txtAddNome.Hint = "Nome da medicação";
                txtAddPreco.Hint = "Preço (€)";
                txtAddQuant.Hint = "Quantidade";
                txtPrazoValidade.Hint = "Prazo de validade (AAAA/MM/DD)";
                butAddMed.Text = "Adicionar";
                butChrome.Text = "Consultar informação oficial";

                dataStock.Columns[0].HeaderText = "Nome";
                dataStock.Columns[1].HeaderText = "Quantidade";
                dataStock.Columns[2].HeaderText = "Prazo de validade";
                dataStock.Columns[3].HeaderText = "Preço";

                cmbRings.Hint = "Toque";
                txtDescription.Hint = "Descrição";
                txtIntervalo.Hint = "Intervalo de tempo";
                btnAlarme.Text = "Adicionar";
                btnSuspender.Text = "Suspender";
                butAddRing.Text = "Adicionar toque";

                txtSearch.Hint = "Pesquisar";

                butRemoverStock.Text = butRemoveAlarm.Text = butRemEm.Text = "Remover";

                medquant = "Quantidade de medicação";
                chartMedQuantidade.Series[0].Name = medquant;

                dtAlarmes.Columns[0].HeaderText = "Descrição";
                dtAlarmes.Columns[1].HeaderText = "Início";
                dtAlarmes.Columns[2].HeaderText = "Fim";
                dtAlarmes.Columns[3].HeaderText = "Intervalo";
                dtAlarmes.Columns[5].HeaderText = "Música";

                cmbAtFis.Items.Clear();
                cmbAtFis.Items.Add("1 - nunca pratico exercício");
                cmbAtFis.Items.Add("2 - raramente pratico exercício");
                cmbAtFis.Items.Add("3 - pratico exercício frequentemente");
                cmbAtFis.Items.Add("4 - pratico exercício todos os dias");

                dtEmergency.Columns[0].HeaderText = "Nome";
                txtEmName.Hint = "Nome";
                txtEmGmail.Hint = "Gmail";
                butAddEm.Text = "Adicionar aos contactos";
                txtMessage.Hint = "Mensagem (opcional)";

                txtDelPass.Hint = "Palavra-passe";
                chlkVer.Text = "Ver";
                butAccount.Text = "Apagar conta";
                butSession.Text = "Terminar sessão";


                infomissing = "Informações em falta";
                error = "Erro";
                maxalarms = "No máximo pode adicionar 8 alarmes! Selecione um dos alarmes na tabela para o substituir.";
                warning = "Aviso";
                surereminder = "O alarme será adicionado";
                sure = "Tem a certeza?";


                img0i.Visible = false;
                img0p.Visible = true;
                img1i.Visible = false;
                img1p.Visible = true;
                img4i.Visible = false;
                img4p.Visible = true;
                img6i.Visible = false;
                img6p.Visible = true;
                img8i.Visible = false;
                img8i2.Visible = false;
                img8p.Visible = true;
                img8p2.Visible = true;
            }

            string phisiologypath = Environment.CurrentDirectory + "//" + frmLogin.reference + "//Phisiology.txt";

            string stockpath = Environment.CurrentDirectory + "//" + frmLogin.reference + "//Stock.txt";

            string emergencypath = Environment.CurrentDirectory + "//" + frmLogin.reference + "//Emergency.txt";

            if (File.Exists(phisiologypath))
            {
                try
                {
                    List<string> carac_fis = new List<string> { };

                    StreamReader reader = new StreamReader(phisiologypath);

                    while (reader.Peek() >= 0)
                    {
                        carac_fis.Add(reader.ReadLine());
                    }

                    reader.Close();

                    txtPeso.Text = carac_fis[0].ToString();
                    txtAltura.Text = carac_fis[1].ToString();
                    txtIMC.Text = carac_fis[2].ToString();
                    cmbAtFis.SelectedIndex = int.Parse(carac_fis[3]);
                }
                catch
                {

                }

            }

            if (File.Exists(stockpath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(stockpath);

                    for (int i = 0; i < lines.Length; i = i + 4)
                    {
                        dataStock.Rows.Add(lines[i], lines[i + 1], lines[i + 2], lines[i + 3]);
                    }

                    for (int i = 0; i < dataStock.Rows.Count; i++)
                    {
                        DateTime validade = DateTime.ParseExact(dataStock.Rows[i].Cells[2].Value.ToString(), "yyyy/MM/dd", CultureInfo.InvariantCulture);
                        if (validade < DateTime.Now)
                            dataStock.Rows[i].DefaultCellStyle.BackColor = Color.Tomato;
                    }

                    loadGraphs();
                }
                // Carregar informações do stock.txt na tabela
                catch
                {

                }
            }

            if (File.Exists(emergencypath))
            {
                try
                {
                    string[] contacts = File.ReadAllLines(emergencypath);

                    for (int n = 0; n < contacts.Length; n = n + 2)
                    {
                        dtEmergency.Rows.Add(contacts[n], contacts[n + 1]);
                    }
                }
                catch
                {

                }
            }


            // Carregar os ringtones na cmb
            string[] filesarray = Directory.GetFiles(Environment.CurrentDirectory + "\\Ringtones", "*wav");

            foreach (var file in filesarray)
            {
                cmbRings.Items.Add(Path.GetFileNameWithoutExtension(file));
            }

            cmbRings.Sorted = true;
            cmbRings.SelectedIndex = 6;
        }




        // Código Alarmes //


        private void btnAlarme_Click(object sender, EventArgs e)
        {
            if (cmbRings.SelectedIndex == -1 || txtDescription.Text == "" || txtIntervalo.Text == "")
            {
                MessageBox.Show(infomissing, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> keyList = new List<string>(this.timers.Keys);
            if (keyList.Contains(txtDescription.Text))
            {
                if (frmLogin.trad)
                {
                    MessageBox.Show("Não pode  adicionar descrições repetidas", "Descrição já adicionada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This description has already been added", "You can't repeat descriptions",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtDescription.Clear();
                txtDescription.Focus();
                return;
            }

            if (MessageBox.Show(surereminder, sure, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (first_set)
            {
                if (flag)
                {
                    flag = false;

                    InitializeNotifyBalloon(notifyIcon1);
                    SetupTimer(timer1);
                    timers.Add(txtDescription.Text, timer1);
                    date_end_1 = dateEnd.Value;
                    music_path_1 = cmbRings.Text;
                    dtAlarmes.Rows.Add(txtDescription.Text, dateStart.Value.ToString(), dateEnd.Value.ToString(), txtIntervalo.Text, "timer1", cmbRings.Text);
                }

                else
                {
                    flag = true;

                    InitializeNotifyBalloon(notifyIcon2);
                    SetupTimer(timer2);
                    timers.Add(txtDescription.Text, timer2);
                    date_end_2 = dateEnd.Value;
                    music_path_2 = cmbRings.Text;
                    dtAlarmes.Rows.Add(txtDescription.Text, dateStart.Value.ToString(), dateEnd.Value.ToString(), txtIntervalo.Text, "timer2", cmbRings.Text);

                    first_set = false;
                }
            }

            else if (aux == true)
            {
                if (flag)
                {

                    flag = false;

                    InitializeNotifyBalloon(notifyIcon3);
                    SetupTimer(timer3);
                    timers.Add(txtDescription.Text, timer3);
                    date_end_3 = dateEnd.Value;
                    music_path_3 = cmbRings.Text;
                    dtAlarmes.Rows.Add(txtDescription.Text, dateStart.Value.ToString(), dateEnd.Value.ToString(), txtIntervalo.Text, "timer3", cmbRings.Text);
                }
                else
                {

                    flag = true;

                    InitializeNotifyBalloon(notifyIcon4);
                    SetupTimer(timer4);
                    timers.Add(txtDescription.Text, timer4);
                    date_end_4 = dateEnd.Value;
                    music_path_4 = cmbRings.Text;
                    dtAlarmes.Rows.Add(txtDescription.Text, dateStart.Value.ToString(), dateEnd.Value.ToString(), txtIntervalo.Text, "timer4", cmbRings.Text);

                    aux = false;
                }
            }

            else if (aux2 == true)
            {
                if (flag)
                {

                    flag = false;

                    InitializeNotifyBalloon(notifyIcon5);
                    SetupTimer(timer5);
                    timers.Add(txtDescription.Text, timer5);
                    date_end_5 = dateEnd.Value;
                    music_path_5 = cmbRings.Text;
                    dtAlarmes.Rows.Add(txtDescription.Text, dateStart.Value.ToString(), dateEnd.Value.ToString(), txtIntervalo.Text, "timer5", cmbRings.Text);
                }
                else
                {

                    flag = true;

                    InitializeNotifyBalloon(notifyIcon6);
                    SetupTimer(timer6);
                    timers.Add(txtDescription.Text, timer6);
                    date_end_6 = dateEnd.Value;
                    music_path_6 = cmbRings.Text;
                    dtAlarmes.Rows.Add(txtDescription.Text, dateStart.Value.ToString(), dateEnd.Value.ToString(), txtIntervalo.Text, "timer6", cmbRings.Text);

                    aux2 = false;
                }
            }

            else
            {
                if (flag == true && limit == true)
                {

                    if (dtAlarmes.SelectedRows.Count > 0)
                    {
                        if (selectRow == "timer1")
                        {
                            butRemoveAlarm_Click(sender, e);

                            first_set = true;

                            limit = false;
                        }

                        if (selectRow == "timer2")
                        {
                            butRemoveAlarm_Click(sender, e);

                            first_set = true;

                            flag = false;
                        }

                        if (selectRow == "timer3")
                        {
                            butRemoveAlarm_Click(sender, e);

                            aux = true;
                        }

                        if (selectRow == "timer4")
                        {
                            butRemoveAlarm_Click(sender, e);

                            aux = true;

                            flag = false;

                        }

                        if (selectRow == "timer5")
                        {
                            butRemoveAlarm_Click(sender, e);

                            aux2 = true;
                        }

                        if (selectRow == "timer6")
                        {
                            butRemoveAlarm_Click(sender, e);

                            aux2 = true;
                            flag = false;
                        }

                        if (selectRow == "timer7")
                        {
                            butRemoveAlarm_Click(sender, e);

                            limit = false;
                        }

                        if (selectRow == "timer8")
                        {
                            butRemoveAlarm_Click(sender, e);

                            flag = false;
                        }
                    }

                    else
                    {
                        MessageBox.Show(maxalarms, warning, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    return;
                }

                if (flag)
                {
                    flag = false;

                    InitializeNotifyBalloon(notifyIcon7);
                    SetupTimer(timer7);
                    timers.Add(txtDescription.Text, timer7);
                    date_end_7 = dateEnd.Value;
                    music_path_7 = cmbRings.Text;
                    dtAlarmes.Rows.Add(txtDescription.Text, dateStart.Value.ToString(), dateEnd.Value.ToString(), txtIntervalo.Text, "timer7", cmbRings.Text);
                }
                else
                {
                    flag = true;

                    InitializeNotifyBalloon(notifyIcon8);
                    SetupTimer(timer8);
                    timers.Add(txtDescription.Text, timer8);
                    date_end_8 = dateEnd.Value;
                    music_path_8 = cmbRings.Text;
                    dtAlarmes.Rows.Add(txtDescription.Text, dateStart.Value.ToString(), dateEnd.Value.ToString(), txtIntervalo.Text, "timer8", cmbRings.Text);

                    limit = true;
                }
            }

            txtDescription.Text = "";
            txtIntervalo.Clear();

            if (frmLogin.trad)
                MessageBox.Show("Alarme adicionado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Alarm Ready", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSuspender_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
        }

        private void InitializeDialogFields()
        {
            dateStart.Value = DateTime.Now;
            dateEnd.Value = DateTime.Now + TimeSpan.FromMinutes(30);
        }

        private void InitializeNotifyBalloon(NotifyIcon notify)
        {
            string text;
            if (frmLogin.trad)
                text = "Lembrete de medicação";
            else
                text = "Medication Reminder";

            notify.BalloonTipIcon = ToolTipIcon.Info;
            notify.BalloonTipTitle = text;
            notify.BalloonTipText = txtDescription.Text;
        }

        private void SetupTimer(Timer timer)
        {
            timer.Interval = int.Parse(txtIntervalo.Text) * 1000 * 60;
            timer.Start();
        }

        private bool CheckIfStartTimeHappened()
        {
            if (DateTime.Now > dateStart.Value)
                return true;

            return false;
        }

        private bool CheckIfWeReachedTheEndTime(Timer timer, DateTime date)
        {
            if (DateTime.Now > date)
            {
                for (int v = 0; v < dtAlarmes.Rows.Count; v++)
                {
                    if (string.Equals(dtAlarmes[4, v].Value as string, timer.Tag))
                    {
                        dtAlarmes.Rows.RemoveAt(v);
                    }
                }

                timer.Stop();

                if (frmLogin.trad)
                    MessageBox.Show("O alarme foi removido porque o tempo limite foi ultrapassado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Your reminder has been removed because the end date has already been expired", "Deleted Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            else
                return false;
        }

        private void ShowReminder(NotifyIcon notify, string music_path)
        {
            notify.ShowBalloonTip(2);

            if (File.Exists(Application.StartupPath + "\\Ringtones\\" + music_path + ".wav"))
            {
                wplayer.URL = Path.GetDirectoryName(Application.ExecutablePath) + "\\Ringtones\\" + music_path + ".wav";
                wplayer.controls.play();
                wplayer.settings.setMode("loop", true);
            }
            else
            {
                if (frmLogin.trad)
                    MessageBox.Show("Não há uma música disponível", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("There is No File To Be Played", "Empty File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtAlarmes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtAlarmes.Rows[e.RowIndex];
                selectRow = row.Cells[4].Value.ToString();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // check to see if we reached the start time
            if (CheckIfStartTimeHappened())
            {
                // show the bubble in the task bar hear
                if (CheckIfWeReachedTheEndTime(timer1, date_end_1))
                    return;
                else
                {
                    ShowReminder(notifyIcon1, music_path_1);
                }
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            // check to see if we reached the start time
            if (CheckIfStartTimeHappened())
            {
                // show the bubble in the task bar hear
                if (CheckIfWeReachedTheEndTime(timer2, date_end_2))
                    return;
                else
                {
                    ShowReminder(notifyIcon2, music_path_2);
                }
            }
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            // check to see if we reached the start time
            if (CheckIfStartTimeHappened())
            {
                // show the bubble in the task bar hear
                if (CheckIfWeReachedTheEndTime(timer3, date_end_3))
                    return;
                else
                {
                    ShowReminder(notifyIcon3, music_path_3);
                }
            }
        }

        private void timer4_Tick_1(object sender, EventArgs e)
        {
            // check to see if we reached the start time
            if (CheckIfStartTimeHappened())
            {
                // show the bubble in the task bar hear
                if (CheckIfWeReachedTheEndTime(timer4, date_end_4))
                    return;
                else
                {
                    ShowReminder(notifyIcon4, music_path_4);
                }
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            // check to see if we reached the start time
            if (CheckIfStartTimeHappened())
            {
                // show the bubble in the task bar hear
                if (CheckIfWeReachedTheEndTime(timer5, date_end_5))
                    return;
                else
                {
                    ShowReminder(notifyIcon5, music_path_5);
                }
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            // check to see if we reached the start time
            if (CheckIfStartTimeHappened())
            {
                // show the bubble in the task bar hear
                if (CheckIfWeReachedTheEndTime(timer6, date_end_6))
                    return;
                else
                {
                    ShowReminder(notifyIcon6, music_path_6);
                }
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            // check to see if we reached the start time
            if (CheckIfStartTimeHappened())
            {
                // show the bubble in the task bar hear
                if (CheckIfWeReachedTheEndTime(timer7, date_end_7))
                    return;
                else
                {
                    ShowReminder(notifyIcon7, music_path_7);
                }
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            // check to see if we reached the start time
            if (CheckIfStartTimeHappened())
            {
                // show the bubble in the task bar hear
                if (CheckIfWeReachedTheEndTime(timer8, date_end_8))
                    return;
                else
                {
                    ShowReminder(notifyIcon8, music_path_8);
                }
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void notifyIcon2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void notifyIcon3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void notifyIcon4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void notifyIcon5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void notifyIcon6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void notifyIcon7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void notifyIcon8_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Código Alarmes => End //




        // Navegadores Internet //


        private void butChrome_Click(object sender, EventArgs e)
        {
            try
            {
                browser(@"HKEY_CLASSES_ROOT\ChromeHTML\shell\open\command");
            }
            catch
            {
                try
                {
                    browser(@"HKEY_LOCAL_MACHINE\SOFTWARE\Classes\FirefoxURL-308046B0AF4A39CB\shell\open\command");
                }
                catch
                {
                    Process.Start("microsoft-edge:https://extranet.infarmed.pt/INFOMED-fo/index.xhtml");
                }
            }
        }

        private void browser(string exe)
        {
            string path = Microsoft.Win32.Registry.GetValue(exe, null, null) as string;

            if (path != null)
            {
                string[] split = path.Split('\"');

                path = split.Length >= 2 ? split[1] : null;
            }
            Process.Start(path, "https://extranet.infarmed.pt/INFOMED-fo/index.xhtml");
        }


        // Navegadores Internet => End //



        // Phisiology //


        private void butGravarCarac_Click(object sender, EventArgs e)
        {
            if (txtPeso.Text == "" || txtAltura.Text == "")
            {
                MessageBox.Show(infomissing, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StreamWriter stream = new StreamWriter(Environment.CurrentDirectory + "//" + frmLogin.reference + "//Phisiology.txt");

            stream.Write(txtPeso.Text + Environment.NewLine + txtAltura.Text + Environment.NewLine + txtIMC.Text + Environment.NewLine + cmbAtFis.SelectedIndex.ToString());

            stream.Close();

            if (frmLogin.trad)
                MessageBox.Show("Informações guardadas", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Saved Informations", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CalcularIMC(double peso, double altura)
        {
            double imc = Math.Round(peso / Math.Pow(altura, 2), 1);

            txtIMC.Text = imc.ToString();
        }


        private void txtPeso_Leave(object sender, EventArgs e)
        {
            if (txtPeso.Text == "")
                return;

            try
            {
                double peso = double.Parse(txtPeso.Text);

                if (txtAltura.Text != "")
                    CalcularIMC(peso, double.Parse(txtAltura.Text) / 100);
            }
            catch
            {
                if (frmLogin.trad)
                    MessageBox.Show("Valor inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtPeso.Clear();
                txtPeso.Focus();
            }
        }


        private void txtAltura_Leave(object sender, EventArgs e)
        {
            if (txtAltura.Text == "")
                return;

            try
            {
                double altura = double.Parse(txtAltura.Text) / 100;

                if (txtPeso.Text != "")
                    CalcularIMC(double.Parse(txtPeso.Text), altura);
            }
            catch
            {
                if (frmLogin.trad)
                    MessageBox.Show("Valor inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtAltura.Clear();
                txtAltura.Focus();
            }
        }


        // Phisiology => End //




        // Add Medication //


        private void butAddMed_Click(object sender, EventArgs e)
        {


            if (txtAddNome.Text == "" || txtAddPreco.Text == "" || txtAddQuant.Text == "" || txtPrazoValidade.Text == "")
            {
                if (frmLogin.trad)
                    MessageBox.Show("Informações em falta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Absence of Information", "Lacking Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            string text;
            if (frmLogin.trad)
                text = "A medicação será adicionada";
            else
                text = "Your pill will be added";

            if (MessageBox.Show(text, sure, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }

            dataStock.Rows.Add(txtAddNome.Text, txtAddQuant.Text, txtPrazoValidade.Text, txtAddPreco.Text);


            txtAddNome.Clear();
            txtAddQuant.Clear();
            txtAddPreco.Clear();
            txtPrazoValidade.Clear();

            loadGraphs();
        }

        private void butRemoverStock_Click(object sender, EventArgs e)
        {
            if (dataStock.SelectedRows.Count == 0)
            {
                if (frmLogin.trad)
                    MessageBox.Show("Selecione um medicamento primeiro", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Select your pill first and foremost!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            string text;
            if (frmLogin.trad)
                text = "A medicação será removida";
            else
                text = "Your medication will be removed";

            if (MessageBox.Show(text, sure, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                foreach (DataGridViewRow item in dataStock.SelectedRows)
                {
                    dataStock.Rows.RemoveAt(item.Index);
                }

                loadGraphs();
            }
        }


        private void txtEmGmail_Leave(object sender, EventArgs e)
        {
            if (txtEmGmail.Text == "")
                return;

            if (!Email.IsGmailValid(txtEmGmail.Text))
            {
                if (frmLogin.trad)
                {
                    MessageBox.Show("Apenas aceitamos registos de endereço Gmail", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("We only accept Gmail adresses", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtEmGmail.Clear();
                txtEmGmail.Focus();
            }
        }

        private void txtIntervalo_Leave(object sender, EventArgs e)
        {
            leaveAuxiliar(txtIntervalo.Text, txtIntervalo);
        }

        private void txtAddQuant_Leave(object sender, EventArgs e)
        {
            leaveAuxiliar(txtAddQuant.Text, txtAddQuant);
        }

        private void dataStock_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            loadGraphs();
        }

        private void txtPrazoValidade_Leave(object sender, EventArgs e)
        {
            if (txtPrazoValidade.Text == "")
            {
                return;
            }

            if (frmRegistar.Datas(txtPrazoValidade.Text))
            {
                try
                {
                    DateTime.ParseExact(txtPrazoValidade.Text, "yyyy/MM/dd", CultureInfo.InvariantCulture);
                }
                catch
                {
                    if (frmLogin.trad)
                        MessageBox.Show("Atenção ao formato pedido", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Pay attention to data format", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (frmLogin.trad)
                    MessageBox.Show("Atenção ao formato pedido", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Pay attention to data format", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtPrazoValidade.Clear();
                txtPrazoValidade.Focus();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.ToLower();

            dataStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                foreach (DataGridViewRow row in dataStock.Rows)
                {
                    if (dataStock.SelectedRows.Count > 0)
                    {
                        row.Selected = false;
                    }

                    if (row.Cells[0].Value.ToString().ToLower().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void txtAddPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            char sepratorChar = 's';

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                if (txtAddPreco.Text.Length == 0) e.Handled = true;

                if (txtAddPreco.SelectionStart == 0) e.Handled = true;

                if (alreadyExist(txtAddPreco.Text, ref sepratorChar)) e.Handled = true;

                // check if '.' is in middle of a number and after it is not a number greater than 99

                if (txtAddPreco.SelectionStart != txtAddPreco.Text.Length && e.Handled == false)
                {
                    // '.' is in the middle

                    string AfterDotString = txtAddPreco.Text.Substring(txtAddPreco.SelectionStart);

                    if (AfterDotString.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }

            //Check if a number pressed

            if (Char.IsDigit(e.KeyChar))
            {
                //Check if a dot exist

                if (alreadyExist(txtAddPreco.Text, ref sepratorChar))
                {
                    int sepratorPosition = txtAddPreco.Text.IndexOf(sepratorChar);

                    string afterSepratorString = txtAddPreco.Text.Substring(sepratorPosition + 1);

                    if (txtAddPreco.SelectionStart > sepratorPosition && afterSepratorString.Length > 1)
                    {
                        e.Handled = true;
                    }

                }
            }
        }

        private bool alreadyExist(string _text, ref char KeyChar)
        {
            if (_text.IndexOf('.') > -1)
            {
                KeyChar = '.';
                return true;
            }

            return false;
        }


        // Add Medication => End //




        // Add Alarm DataGridView //


        private void butRemoveAlarm_Click(object sender, EventArgs e)
        {
            if (dtAlarmes.SelectedRows.Count == 0)
            {
                if (frmLogin.trad)
                    MessageBox.Show("Selecione um alarme primeiro", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Select an alarm first and foremost!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            string text;
            if (frmLogin.trad)
                text = "O alarme será removido";
            else
                text = "Your alarm will be removed";

            if (MessageBox.Show(text, sure, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                foreach (DataGridViewRow item in dtAlarmes.SelectedRows)
                {
                    if (timers.TryGetValue(dtAlarmes.Rows[item.Index].Cells["colName"].Value.ToString(), out Timer value) == true)
                    {
                        wplayer.controls.stop();

                        value.Stop();

                        timers.Remove(dtAlarmes.Rows[item.Index].Cells["colName"].Value.ToString());
                    }
                    else
                    {
                        MessageBox.Show(error);
                    }

                    dtAlarmes.Rows.RemoveAt(item.Index);
                }
            }
        }


        // Add Alarm DatagridView => End //



        // Emergência //

        private void butAddEm_Click(object sender, EventArgs e)
        {
            if (txtEmName.Text == "" || txtEmGmail.Text == "")
            {
                if (frmLogin.trad)
                {
                    MessageBox.Show("Informações em falta", error, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Missing informations", error, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }
            dtEmergency.Rows.Add(txtEmName.Text, txtEmGmail.Text);
            txtEmGmail.Clear();
            txtEmName.Clear();
            txtEmName.Focus();
        }

        private void butRemEm_Click(object sender, EventArgs e)
        {
            if (dtEmergency.SelectedRows.Count == 0)
            {
                if (frmLogin.trad)
                    MessageBox.Show("Selecione um contacto primeiro", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Select a contact first and foremost!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            string text;
            if (frmLogin.trad)
                text = "O contacto será removido";
            else
                text = "This contact will be removed";

            if (MessageBox.Show(text, sure, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                foreach (DataGridViewRow item in dtEmergency.SelectedRows)
                {
                    dtEmergency.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void butEmergency_Click(object sender, EventArgs e)
        {
            if (dtEmergency.SelectedRows.Count > 0 && dtEmergency.SelectedRows.Count < 2)
            {
                if (Email.IsGmailValid(emergencyMail) == true)
                {
                    if (txtMessage.Text == "")
                    {
                        Email.SendEmail(emergencyMail, frmLogin.reference + " sent you an emergency request from our app. Please enter in contact as fast as possible", "SOS - " + frmLogin.reference, true);
                    }
                    else
                    {
                        Email.SendEmail(emergencyMail, txtMessage.Text, "SOS - " + frmLogin.reference, true);
                    }
                }

                else
                {
                    if (frmLogin.trad)
                        MessageBox.Show("Endereço Gmail inválido", error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Your Gmail address is not valid!", error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                if (frmLogin.trad)
                    MessageBox.Show("Selecione a linha do contacto na tabela. Apenas 1 de cada vez", "Informação em falta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("You must select the row of the contact in the table... Just one row for each click!", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtEmergency_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtEmergency.Rows[e.RowIndex];
                emergencyMail = row.Cells[1].Value.ToString();
            }
        }


        // Gráficos //


        private void loadGraphs()
        {
            // Gráfico Medicação //

            foreach (var series in chartMedQuantidade.Series)
            {
                series.Points.Clear();
            }

            chartMedQuantidade.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chartMedQuantidade.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;

            chartMedQuantidade.ChartAreas["ChartArea1"].BackColor = Color.Transparent;

            for (int i = 0; i < dataStock.Rows.Count; i++)
            {
                chartMedQuantidade.Series[medquant].Points.AddXY(dataStock[0, i].Value, dataStock[1, i].Value.ToString());
            }


            // Gráfico Orçamento //

            foreach (var series in chartPrice.Series)
            {
                series.Points.Clear();
            }

            chartPrice.ChartAreas["ChartArea1"].BackColor = Color.Transparent;

            for (int i = 0; i < dataStock.Rows.Count; i++)
            {
                chartPrice.Series["Series1"].Points.AddXY(dataStock[0, i].Value, dataStock[3, i].Value);

            }
        }


        private void SaveInfos()
        {
            // Guardar o stock no ficheiro quando o programa é fechado

            StreamWriter fich = new StreamWriter(Environment.CurrentDirectory + "//" + frmLogin.reference + "//Stock.txt");

            for (int row = 0; row < dataStock.Rows.Count; row++)
            {
                int colCount = dataStock.Rows[row].Cells.Count;

                for (int col = 0; col < colCount; col++)
                {
                    fich.WriteLine(dataStock.Rows[row].Cells[col].Value.ToString());

                }
            }
            fich.Close();

            StreamWriter fichEmergency = new StreamWriter(Environment.CurrentDirectory + "//" + frmLogin.reference + "//Emergency.txt");

            for (int row = 0; row < dtEmergency.Rows.Count; row++)
            {
                int colCount = dtEmergency.Rows[row].Cells.Count;

                for (int col = 0; col < colCount; col++)
                {
                    fichEmergency.WriteLine(dtEmergency.Rows[row].Cells[col].Value.ToString());

                }
            }
            fichEmergency.Close();
        }


        private void frmMed_FormClosing(object sender, FormClosingEventArgs e)
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

                    if (MessageBox.Show(txt1, txt2, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        SaveInfos();
                        string text1;
                        string text2;
                        if (frmLogin.trad)
                        {
                            text1 = "Gostaria de apenas suspender a aplicação de forma a manter os seus alarmes?";
                            text2 = "Sair";
                        }
                        else
                        {
                            text1 = "Would you like to suspend your application so that you can be reminded about your medication anytime?";
                            text2 = "Leave";
                        }

                        if (MessageBox.Show(text1, text2, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            if (frmLogin.trad)
                                MessageBox.Show("A aplicação será encerrada e os alarmes serão desativados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Your application will close. You will stop to receive medication reminders", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            Environment.Exit(0);
                        }
                        else
                        {
                            e.Cancel = true;
                            this.ShowInTaskbar = false;
                            this.Hide();
                        }
                    }
                    break;
            }
        }




        // Funções de Simplificação


        private void leaveAuxiliar(string cena, MaterialTextBox box)
        {
            if (cena == "")
                return;

            try
            {
                int.Parse(cena);
            }
            catch
            {
                if (frmLogin.trad)
                    MessageBox.Show("Valor inválido", error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Invalid Input", error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                box.Clear();
                box.Focus();
            }
        }


        private void butAddRing_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = "c:\\";
            ofd.Filter = "Wav Files|*.wav";
            ofd.FilterIndex = 0;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = ofd.SafeFileName;
                string selectedFilePath = Path.GetDirectoryName(ofd.FileName);
                string targetPath = Environment.CurrentDirectory + "\\Ringtones";

                // Use Path class to manipulate file and directory paths.
                string sourceFile = Path.Combine(selectedFilePath, selectedFileName);
                string destFile = Path.Combine(targetPath, selectedFileName);

                // To copy a file to another location and
                // overwrite the destination file if it already exists.
                File.Copy(sourceFile, destFile, true);

                cmbRings.Items.Add(Path.GetFileNameWithoutExtension(ofd.SafeFileName));

                if (frmLogin.trad)
                    MessageBox.Show("Toque adicionado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ringtone was added with success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void butAccount_Click(object sender, EventArgs e)
        {
            string text1;
            string text2;

            if(frmLogin.trad)
            {
                text1 = "Tem a certeza que deseja remover a sua conta?";
                text2 = "Apagar conta";
            }
            else
            {
                text1 = "Are you sure you want to remove your account?";
                text2 = "Delete acccount";
            }
            if (MessageBox.Show(text1, text2, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Directory.Delete(Environment.CurrentDirectory + "\\" + frmLogin.reference, true);

                connnector.Delete("Delete FROM user_registos WHERE name = '" + frmLogin.reference + "'");

                if(txtReport.Text!="")
                {
                    Email.SendEmail("primeshell.official@gmail.com",txtReport.Text, "Account Deleted - Report", emergency:false, cancel:true);
                }

                Application.Restart();

                Environment.Exit(0);
            }
        }

        private void butSession_Click(object sender, EventArgs e)
        {
            string texto;
            if (frmLogin.trad)
                texto = "Se terminar sessão a sua atividade será encerrada e os alarmes serão encerrados";
            else
                texto = "If you end your activity, your reminders will be disabled";

            if (MessageBox.Show(texto, sure, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SaveInfos();

                if (dtAlarmes.Rows.Count > 0)
                {
                    wplayer.controls.stop();

                    for (int i = 0; i < dtAlarmes.Rows.Count; i++)
                    {

                        if (timers.TryGetValue(dtAlarmes.Rows[i].Cells["colName"].Value.ToString(), out Timer value) == true)
                        {
                            value.Stop();

                            timers.Remove(dtAlarmes.Rows[i].Cells["colName"].Value.ToString());
                        }
                        else
                        {
                            MessageBox.Show(error);
                        }
                    }
                }

                frmLogin inicio = new frmLogin();
                inicio.Show();
                this.Hide();
            }
        }

        private void txtDelPass_TextChanged(object sender, EventArgs e)
        {

            if (connnector.ValidatePassword("SELECT password FROM user_registos WHERE name= '" + frmLogin.reference + "'", txtDelPass.Text) == true)
            {
                butAccount.Enabled = true;
           
            }
            else
            {
                butAccount.Enabled = false;
            }
        }

        private void chlkVer_CheckedChanged(object sender, EventArgs e)
        {
            if (chlkVer.Checked)
            {
                txtDelPass.Password = false;
            }
            else
            {
                txtDelPass.Password = true;
            }
        }

    }
}
