namespace Medtest_DB_Editor
{
    partial class Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menu_panel = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортВXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.командыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сделатьЗапросПоБазеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_panel = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_add = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Update = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_txt = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Excell = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_Query = new System.Windows.Forms.ToolStripButton();
            this.dictCategBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medtest_dbDataSet1 = new Medtest_DB_Editor.Medtest_dbDataSet1();
            this.passwordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.participantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attemptsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_authorization_name_server = new System.Windows.Forms.Label();
            this.textBox_authorization_name_server = new System.Windows.Forms.TextBox();
            this.panel_authorization = new System.Windows.Forms.Panel();
            this.button_authorization_cancel = new System.Windows.Forms.Button();
            this.button_authorization_connect = new System.Windows.Forms.Button();
            this.label_authorization_head = new System.Windows.Forms.Label();
            this.textBox_authorization_name_BD = new System.Windows.Forms.TextBox();
            this.label_authorization_name_bd = new System.Windows.Forms.Label();
            this.textBox_authorization_password = new System.Windows.Forms.TextBox();
            this.label_authorization_password = new System.Windows.Forms.Label();
            this.textBox_authorization_name_user = new System.Windows.Forms.TextBox();
            this.label_authorization_name_user = new System.Windows.Forms.Label();
            this.participantsTableAdapter = new Medtest_DB_Editor.Medtest_dbDataSet1TableAdapters.ParticipantsTableAdapter();
            this.dictCategTableAdapter = new Medtest_DB_Editor.Medtest_dbDataSet1TableAdapters.DictCategTableAdapter();
            this.sectionsTableAdapter = new Medtest_DB_Editor.Medtest_dbDataSet1TableAdapters.SectionsTableAdapter();
            this.passwordsTableAdapter = new Medtest_DB_Editor.Medtest_dbDataSet1TableAdapters.PasswordsTableAdapter();
            this.attemptsTableAdapter = new Medtest_DB_Editor.Medtest_dbDataSet1TableAdapters.AttemptsTableAdapter();
            this.resultsTableAdapter = new Medtest_DB_Editor.Medtest_dbDataSet1TableAdapters.ResultsTableAdapter();
            this.questionsTableAdapter = new Medtest_DB_Editor.Medtest_dbDataSet1TableAdapters.QuestionsTableAdapter();
            this.tableAdapterManager = new Medtest_DB_Editor.Medtest_dbDataSet1TableAdapters.TableAdapterManager();
            this.сompetenceTableAdapter = new Medtest_DB_Editor.Medtest_dbDataSet1TableAdapters.СompetenceTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоПопытокDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.запуститьТестированиеDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.компетенция1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вопросов1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.компетенция2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вопросов2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.компетенция3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вопросов3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.компетенция4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вопросов4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.компетенция5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вопросов5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.компетенция6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вопросов6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.компетенция7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вопросов7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.компетенция8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вопросов8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.компетенция9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вопросов9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.компетенция10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вопросов10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сompetenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияУчастникаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеРазделаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.итогDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процент1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процент2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процент3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процент4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процент5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процент6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процент7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процент8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процент9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процент10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tab_control_results = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.Resultsitog_datagrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.Attempts_datagrid = new System.Windows.Forms.DataGridView();
            this.фамилияУчастникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.названиеРазделаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.количествоПопытокDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Passwords_datagrid = new System.Windows.Forms.DataGridView();
            this.названиеОтделенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.парольDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.Questions_datagrid = new System.Windows.Forms.DataGridView();
            this.вопросDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.убранИзТестаDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ответ1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цель1DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ответ2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цель2DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ответ3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цель3DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ответ4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цель4DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ответ5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цель5DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.цельТекстDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_add_not_test = new System.Windows.Forms.CheckBox();
            this.checkBox_add_type_ans = new System.Windows.Forms.CheckBox();
            this.textBox_add_string_ans = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_add_var_5 = new System.Windows.Forms.CheckBox();
            this.textBox_add_var_5 = new System.Windows.Forms.TextBox();
            this.checkBox_add_var_4 = new System.Windows.Forms.CheckBox();
            this.checkBox_add_var_3 = new System.Windows.Forms.CheckBox();
            this.checkBox_add_var_2 = new System.Windows.Forms.CheckBox();
            this.checkBox_add_var_1 = new System.Windows.Forms.CheckBox();
            this.textBox_add_var_1 = new System.Windows.Forms.TextBox();
            this.textBox_add_var_3 = new System.Windows.Forms.TextBox();
            this.textBox_add_var_2 = new System.Windows.Forms.TextBox();
            this.textBox_add_var_4 = new System.Windows.Forms.TextBox();
            this.richtext_add_question = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_question_clear = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Sections_datagrid = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Participants_datagrid = new System.Windows.Forms.DataGridView();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.отделениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.парольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabcontrol_head = new System.Windows.Forms.TabControl();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_panel.SuspendLayout();
            this.toolStrip_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dictCategBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medtest_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attemptsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).BeginInit();
            this.panel_authorization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сompetenceBindingSource)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tab_control_results.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resultsitog_datagrid)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Attempts_datagrid)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Passwords_datagrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Questions_datagrid)).BeginInit();
            this.tabPage10.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sections_datagrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Participants_datagrid)).BeginInit();
            this.tabcontrol_head.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_panel
            // 
            this.menu_panel.Enabled = false;
            this.menu_panel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.командыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(1274, 24);
            this.menu_panel.TabIndex = 1;
            this.menu_panel.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.экспортВXMLToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // экспортВXMLToolStripMenuItem
            // 
            this.экспортВXMLToolStripMenuItem.Name = "экспортВXMLToolStripMenuItem";
            this.экспортВXMLToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.экспортВXMLToolStripMenuItem.Text = "Экспорт в XML";
            this.экспортВXMLToolStripMenuItem.Click += new System.EventHandler(this.экспортВXMLToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.выходToolStripMenuItem.Text = "Вы&ход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // командыToolStripMenuItem
            // 
            this.командыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сделатьЗапросПоБазеToolStripMenuItem,
            this.toolStripSeparator2,
            this.настройкиToolStripMenuItem});
            this.командыToolStripMenuItem.Name = "командыToolStripMenuItem";
            this.командыToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.командыToolStripMenuItem.Text = "Сервис";
            // 
            // сделатьЗапросПоБазеToolStripMenuItem
            // 
            this.сделатьЗапросПоБазеToolStripMenuItem.Name = "сделатьЗапросПоБазеToolStripMenuItem";
            this.сделатьЗапросПоБазеToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.сделатьЗапросПоБазеToolStripMenuItem.Text = "Сделать запрос по базе";
            this.сделатьЗапросПоБазеToolStripMenuItem.Click += new System.EventHandler(this.сделатьЗапросПоБазеToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Спра&вка";
            // 
            // опрограммеToolStripMenuItem
            // 
            this.опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            this.опрограммеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.опрограммеToolStripMenuItem.Text = "&О программе...";
            this.опрограммеToolStripMenuItem.Click += new System.EventHandler(this.опрограммеToolStripMenuItem_Click);
            // 
            // toolStrip_panel
            // 
            this.toolStrip_panel.Enabled = false;
            this.toolStrip_panel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_add,
            this.toolStripButton_Save,
            this.toolStripButton_Delete,
            this.toolStripButton_Update,
            this.toolStripSeparator6,
            this.toolStripButton_txt,
            this.toolStripButton_Excell,
            this.toolStripSeparator3,
            this.toolStrip_Query});
            this.toolStrip_panel.Location = new System.Drawing.Point(0, 24);
            this.toolStrip_panel.Name = "toolStrip_panel";
            this.toolStrip_panel.Size = new System.Drawing.Size(1274, 25);
            this.toolStrip_panel.TabIndex = 2;
            this.toolStrip_panel.Text = "toolStrip2";
            // 
            // toolStripButton_add
            // 
            this.toolStripButton_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_add.Image = global::Medtest_DB_Editor.Properties.Resources.Symbol_Add;
            this.toolStripButton_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_add.Name = "toolStripButton_add";
            this.toolStripButton_add.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_add.Text = "Добавить";
            this.toolStripButton_add.Click += new System.EventHandler(this.toolStripButton_add_Click);
            // 
            // toolStripButton_Save
            // 
            this.toolStripButton_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Save.Image = global::Medtest_DB_Editor.Properties.Resources.Save_Check;
            this.toolStripButton_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Save.Name = "toolStripButton_Save";
            this.toolStripButton_Save.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Save.Text = "Сохранить";
            this.toolStripButton_Save.Click += new System.EventHandler(this.toolStripButton_Save_Click);
            // 
            // toolStripButton_Delete
            // 
            this.toolStripButton_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Delete.Image = global::Medtest_DB_Editor.Properties.Resources.Symbol_Delete;
            this.toolStripButton_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Delete.Name = "toolStripButton_Delete";
            this.toolStripButton_Delete.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Delete.Text = "Удалить";
            this.toolStripButton_Delete.Click += new System.EventHandler(this.toolStripButton_Delete_Click);
            // 
            // toolStripButton_Update
            // 
            this.toolStripButton_Update.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Update.Image = global::Medtest_DB_Editor.Properties.Resources.Symbol_Refresh_4;
            this.toolStripButton_Update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Update.Name = "toolStripButton_Update";
            this.toolStripButton_Update.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Update.Text = "Обновить";
            this.toolStripButton_Update.Click += new System.EventHandler(this.toolStripButton_Update_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_txt
            // 
            this.toolStripButton_txt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_txt.Image = global::Medtest_DB_Editor.Properties.Resources.Document_2;
            this.toolStripButton_txt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_txt.Name = "toolStripButton_txt";
            this.toolStripButton_txt.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_txt.Text = "Показать в .txt";
            this.toolStripButton_txt.Click += new System.EventHandler(this.toolStripButton_txt_Click);
            // 
            // toolStripButton_Excell
            // 
            this.toolStripButton_Excell.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Excell.Image = global::Medtest_DB_Editor.Properties.Resources.excel;
            this.toolStripButton_Excell.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Excell.Name = "toolStripButton_Excell";
            this.toolStripButton_Excell.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Excell.Text = "Показать в Excell";
            this.toolStripButton_Excell.Click += new System.EventHandler(this.toolStripButton_Excell_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip_Query
            // 
            this.toolStrip_Query.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Query.Image = global::Medtest_DB_Editor.Properties.Resources.Bulb_On;
            this.toolStrip_Query.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Query.Name = "toolStrip_Query";
            this.toolStrip_Query.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Query.Text = "Сделать запрос по базе данных";
            this.toolStrip_Query.Click += new System.EventHandler(this.toolStrip_Query_Click);
            // 
            // dictCategBindingSource
            // 
            this.dictCategBindingSource.DataMember = "DictCateg";
            this.dictCategBindingSource.DataSource = this.medtest_dbDataSet1;
            // 
            // medtest_dbDataSet1
            // 
            this.medtest_dbDataSet1.DataSetName = "Medtest_dbDataSet1";
            this.medtest_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passwordsBindingSource
            // 
            this.passwordsBindingSource.DataMember = "Passwords";
            this.passwordsBindingSource.DataSource = this.medtest_dbDataSet1;
            // 
            // participantsBindingSource
            // 
            this.participantsBindingSource.DataMember = "Participants";
            this.participantsBindingSource.DataSource = this.medtest_dbDataSet1;
            // 
            // sectionsBindingSource
            // 
            this.sectionsBindingSource.DataMember = "Sections";
            this.sectionsBindingSource.DataSource = this.medtest_dbDataSet1;
            // 
            // questionsBindingSource
            // 
            this.questionsBindingSource.DataMember = "Questions";
            this.questionsBindingSource.DataSource = this.medtest_dbDataSet1;
            // 
            // attemptsBindingSource
            // 
            this.attemptsBindingSource.DataMember = "Attempts";
            this.attemptsBindingSource.DataSource = this.medtest_dbDataSet1;
            // 
            // resultsBindingSource
            // 
            this.resultsBindingSource.DataMember = "Results";
            this.resultsBindingSource.DataSource = this.medtest_dbDataSet1;
            // 
            // label_authorization_name_server
            // 
            this.label_authorization_name_server.AutoSize = true;
            this.label_authorization_name_server.Location = new System.Drawing.Point(19, 55);
            this.label_authorization_name_server.Name = "label_authorization_name_server";
            this.label_authorization_name_server.Size = new System.Drawing.Size(77, 13);
            this.label_authorization_name_server.TabIndex = 0;
            this.label_authorization_name_server.Text = "Имя сервера:";
            // 
            // textBox_authorization_name_server
            // 
            this.textBox_authorization_name_server.Location = new System.Drawing.Point(22, 81);
            this.textBox_authorization_name_server.Name = "textBox_authorization_name_server";
            this.textBox_authorization_name_server.Size = new System.Drawing.Size(230, 20);
            this.textBox_authorization_name_server.TabIndex = 1;
            this.textBox_authorization_name_server.Text = "VERDERIAN";
            // 
            // panel_authorization
            // 
            this.panel_authorization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_authorization.Controls.Add(this.button_authorization_cancel);
            this.panel_authorization.Controls.Add(this.button_authorization_connect);
            this.panel_authorization.Controls.Add(this.label_authorization_head);
            this.panel_authorization.Controls.Add(this.textBox_authorization_name_BD);
            this.panel_authorization.Controls.Add(this.label_authorization_name_bd);
            this.panel_authorization.Controls.Add(this.textBox_authorization_password);
            this.panel_authorization.Controls.Add(this.label_authorization_password);
            this.panel_authorization.Controls.Add(this.textBox_authorization_name_user);
            this.panel_authorization.Controls.Add(this.label_authorization_name_user);
            this.panel_authorization.Controls.Add(this.textBox_authorization_name_server);
            this.panel_authorization.Controls.Add(this.label_authorization_name_server);
            this.panel_authorization.Location = new System.Drawing.Point(610, 49);
            this.panel_authorization.Name = "panel_authorization";
            this.panel_authorization.Size = new System.Drawing.Size(274, 338);
            this.panel_authorization.TabIndex = 1;
            // 
            // button_authorization_cancel
            // 
            this.button_authorization_cancel.Location = new System.Drawing.Point(188, 299);
            this.button_authorization_cancel.Name = "button_authorization_cancel";
            this.button_authorization_cancel.Size = new System.Drawing.Size(64, 23);
            this.button_authorization_cancel.TabIndex = 10;
            this.button_authorization_cancel.Text = "Отмена";
            this.button_authorization_cancel.UseVisualStyleBackColor = true;
            this.button_authorization_cancel.Click += new System.EventHandler(this.button_authorization_cancel_Click);
            // 
            // button_authorization_connect
            // 
            this.button_authorization_connect.Location = new System.Drawing.Point(22, 299);
            this.button_authorization_connect.Name = "button_authorization_connect";
            this.button_authorization_connect.Size = new System.Drawing.Size(160, 23);
            this.button_authorization_connect.TabIndex = 9;
            this.button_authorization_connect.Text = "Соединить";
            this.button_authorization_connect.UseVisualStyleBackColor = true;
            this.button_authorization_connect.Click += new System.EventHandler(this.button_authorization_connect_Click);
            // 
            // label_authorization_head
            // 
            this.label_authorization_head.AutoSize = true;
            this.label_authorization_head.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_authorization_head.Location = new System.Drawing.Point(44, 16);
            this.label_authorization_head.Name = "label_authorization_head";
            this.label_authorization_head.Size = new System.Drawing.Size(192, 20);
            this.label_authorization_head.TabIndex = 8;
            this.label_authorization_head.Text = "Соединение с сервером";
            // 
            // textBox_authorization_name_BD
            // 
            this.textBox_authorization_name_BD.Location = new System.Drawing.Point(22, 263);
            this.textBox_authorization_name_BD.Name = "textBox_authorization_name_BD";
            this.textBox_authorization_name_BD.Size = new System.Drawing.Size(230, 20);
            this.textBox_authorization_name_BD.TabIndex = 7;
            this.textBox_authorization_name_BD.Text = "Medtest_db";
            // 
            // label_authorization_name_bd
            // 
            this.label_authorization_name_bd.AutoSize = true;
            this.label_authorization_name_bd.Location = new System.Drawing.Point(19, 237);
            this.label_authorization_name_bd.Name = "label_authorization_name_bd";
            this.label_authorization_name_bd.Size = new System.Drawing.Size(51, 13);
            this.label_authorization_name_bd.TabIndex = 6;
            this.label_authorization_name_bd.Text = "Имя БД:";
            // 
            // textBox_authorization_password
            // 
            this.textBox_authorization_password.Location = new System.Drawing.Point(22, 204);
            this.textBox_authorization_password.Name = "textBox_authorization_password";
            this.textBox_authorization_password.Size = new System.Drawing.Size(230, 20);
            this.textBox_authorization_password.TabIndex = 5;
            this.textBox_authorization_password.Text = "12345";
            // 
            // label_authorization_password
            // 
            this.label_authorization_password.AutoSize = true;
            this.label_authorization_password.Location = new System.Drawing.Point(19, 178);
            this.label_authorization_password.Name = "label_authorization_password";
            this.label_authorization_password.Size = new System.Drawing.Size(48, 13);
            this.label_authorization_password.TabIndex = 4;
            this.label_authorization_password.Text = "Пароль:";
            // 
            // textBox_authorization_name_user
            // 
            this.textBox_authorization_name_user.Location = new System.Drawing.Point(22, 141);
            this.textBox_authorization_name_user.Name = "textBox_authorization_name_user";
            this.textBox_authorization_name_user.Size = new System.Drawing.Size(230, 20);
            this.textBox_authorization_name_user.TabIndex = 3;
            this.textBox_authorization_name_user.Text = "sa";
            // 
            // label_authorization_name_user
            // 
            this.label_authorization_name_user.AutoSize = true;
            this.label_authorization_name_user.Location = new System.Drawing.Point(19, 115);
            this.label_authorization_name_user.Name = "label_authorization_name_user";
            this.label_authorization_name_user.Size = new System.Drawing.Size(106, 13);
            this.label_authorization_name_user.TabIndex = 2;
            this.label_authorization_name_user.Text = "Имя пользователя:";
            // 
            // participantsTableAdapter
            // 
            this.participantsTableAdapter.ClearBeforeFill = true;
            // 
            // dictCategTableAdapter
            // 
            this.dictCategTableAdapter.ClearBeforeFill = true;
            // 
            // sectionsTableAdapter
            // 
            this.sectionsTableAdapter.ClearBeforeFill = true;
            // 
            // passwordsTableAdapter
            // 
            this.passwordsTableAdapter.ClearBeforeFill = true;
            // 
            // attemptsTableAdapter
            // 
            this.attemptsTableAdapter.ClearBeforeFill = true;
            // 
            // resultsTableAdapter
            // 
            this.resultsTableAdapter.ClearBeforeFill = true;
            // 
            // questionsTableAdapter
            // 
            this.questionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnswersTableAdapter = null;
            this.tableAdapterManager.AttemptsTableAdapter = this.attemptsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DictCategTableAdapter = this.dictCategTableAdapter;
            this.tableAdapterManager.ParticipantsTableAdapter = this.participantsTableAdapter;
            this.tableAdapterManager.PasswordsTableAdapter = this.passwordsTableAdapter;
            this.tableAdapterManager.QuestionsTableAdapter = this.questionsTableAdapter;
            this.tableAdapterManager.ResultsTableAdapter = this.resultsTableAdapter;
            this.tableAdapterManager.SectionsTableAdapter = this.sectionsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Medtest_DB_Editor.Medtest_dbDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.СompetenceTableAdapter = this.сompetenceTableAdapter;
            // 
            // сompetenceTableAdapter
            // 
            this.сompetenceTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // времяDataGridViewTextBoxColumn
            // 
            this.времяDataGridViewTextBoxColumn.DataPropertyName = "Время";
            this.времяDataGridViewTextBoxColumn.HeaderText = "Время";
            this.времяDataGridViewTextBoxColumn.Name = "времяDataGridViewTextBoxColumn";
            // 
            // количествоПопытокDataGridViewTextBoxColumn
            // 
            this.количествоПопытокDataGridViewTextBoxColumn.DataPropertyName = "Количество попыток";
            this.количествоПопытокDataGridViewTextBoxColumn.HeaderText = "Количество попыток";
            this.количествоПопытокDataGridViewTextBoxColumn.Name = "количествоПопытокDataGridViewTextBoxColumn";
            // 
            // запуститьТестированиеDataGridViewCheckBoxColumn
            // 
            this.запуститьТестированиеDataGridViewCheckBoxColumn.DataPropertyName = "Запустить тестирование";
            this.запуститьТестированиеDataGridViewCheckBoxColumn.HeaderText = "Запустить тестирование";
            this.запуститьТестированиеDataGridViewCheckBoxColumn.Name = "запуститьТестированиеDataGridViewCheckBoxColumn";
            // 
            // компетенция1DataGridViewTextBoxColumn
            // 
            this.компетенция1DataGridViewTextBoxColumn.DataPropertyName = "Компетенция 1";
            this.компетенция1DataGridViewTextBoxColumn.HeaderText = "Компетенция 1";
            this.компетенция1DataGridViewTextBoxColumn.Name = "компетенция1DataGridViewTextBoxColumn";
            // 
            // вопросов1DataGridViewTextBoxColumn
            // 
            this.вопросов1DataGridViewTextBoxColumn.DataPropertyName = "Вопросов 1";
            this.вопросов1DataGridViewTextBoxColumn.HeaderText = "Вопросов 1";
            this.вопросов1DataGridViewTextBoxColumn.Name = "вопросов1DataGridViewTextBoxColumn";
            // 
            // компетенция2DataGridViewTextBoxColumn
            // 
            this.компетенция2DataGridViewTextBoxColumn.DataPropertyName = "Компетенция 2";
            this.компетенция2DataGridViewTextBoxColumn.HeaderText = "Компетенция 2";
            this.компетенция2DataGridViewTextBoxColumn.Name = "компетенция2DataGridViewTextBoxColumn";
            // 
            // вопросов2DataGridViewTextBoxColumn
            // 
            this.вопросов2DataGridViewTextBoxColumn.DataPropertyName = "Вопросов 2";
            this.вопросов2DataGridViewTextBoxColumn.HeaderText = "Вопросов 2";
            this.вопросов2DataGridViewTextBoxColumn.Name = "вопросов2DataGridViewTextBoxColumn";
            // 
            // компетенция3DataGridViewTextBoxColumn
            // 
            this.компетенция3DataGridViewTextBoxColumn.DataPropertyName = "Компетенция 3";
            this.компетенция3DataGridViewTextBoxColumn.HeaderText = "Компетенция 3";
            this.компетенция3DataGridViewTextBoxColumn.Name = "компетенция3DataGridViewTextBoxColumn";
            // 
            // вопросов3DataGridViewTextBoxColumn
            // 
            this.вопросов3DataGridViewTextBoxColumn.DataPropertyName = "Вопросов 3";
            this.вопросов3DataGridViewTextBoxColumn.HeaderText = "Вопросов 3";
            this.вопросов3DataGridViewTextBoxColumn.Name = "вопросов3DataGridViewTextBoxColumn";
            // 
            // компетенция4DataGridViewTextBoxColumn
            // 
            this.компетенция4DataGridViewTextBoxColumn.DataPropertyName = "Компетенция 4";
            this.компетенция4DataGridViewTextBoxColumn.HeaderText = "Компетенция 4";
            this.компетенция4DataGridViewTextBoxColumn.Name = "компетенция4DataGridViewTextBoxColumn";
            // 
            // вопросов4DataGridViewTextBoxColumn
            // 
            this.вопросов4DataGridViewTextBoxColumn.DataPropertyName = "Вопросов 4";
            this.вопросов4DataGridViewTextBoxColumn.HeaderText = "Вопросов 4";
            this.вопросов4DataGridViewTextBoxColumn.Name = "вопросов4DataGridViewTextBoxColumn";
            // 
            // компетенция5DataGridViewTextBoxColumn
            // 
            this.компетенция5DataGridViewTextBoxColumn.DataPropertyName = "Компетенция 5";
            this.компетенция5DataGridViewTextBoxColumn.HeaderText = "Компетенция 5";
            this.компетенция5DataGridViewTextBoxColumn.Name = "компетенция5DataGridViewTextBoxColumn";
            // 
            // вопросов5DataGridViewTextBoxColumn
            // 
            this.вопросов5DataGridViewTextBoxColumn.DataPropertyName = "Вопросов 5";
            this.вопросов5DataGridViewTextBoxColumn.HeaderText = "Вопросов 5";
            this.вопросов5DataGridViewTextBoxColumn.Name = "вопросов5DataGridViewTextBoxColumn";
            // 
            // компетенция6DataGridViewTextBoxColumn
            // 
            this.компетенция6DataGridViewTextBoxColumn.DataPropertyName = "Компетенция 6";
            this.компетенция6DataGridViewTextBoxColumn.HeaderText = "Компетенция 6";
            this.компетенция6DataGridViewTextBoxColumn.Name = "компетенция6DataGridViewTextBoxColumn";
            // 
            // вопросов6DataGridViewTextBoxColumn
            // 
            this.вопросов6DataGridViewTextBoxColumn.DataPropertyName = "Вопросов 6";
            this.вопросов6DataGridViewTextBoxColumn.HeaderText = "Вопросов 6";
            this.вопросов6DataGridViewTextBoxColumn.Name = "вопросов6DataGridViewTextBoxColumn";
            // 
            // компетенция7DataGridViewTextBoxColumn
            // 
            this.компетенция7DataGridViewTextBoxColumn.DataPropertyName = "Компетенция 7";
            this.компетенция7DataGridViewTextBoxColumn.HeaderText = "Компетенция 7";
            this.компетенция7DataGridViewTextBoxColumn.Name = "компетенция7DataGridViewTextBoxColumn";
            // 
            // вопросов7DataGridViewTextBoxColumn
            // 
            this.вопросов7DataGridViewTextBoxColumn.DataPropertyName = "Вопросов 7";
            this.вопросов7DataGridViewTextBoxColumn.HeaderText = "Вопросов 7";
            this.вопросов7DataGridViewTextBoxColumn.Name = "вопросов7DataGridViewTextBoxColumn";
            // 
            // компетенция8DataGridViewTextBoxColumn
            // 
            this.компетенция8DataGridViewTextBoxColumn.DataPropertyName = "Компетенция 8";
            this.компетенция8DataGridViewTextBoxColumn.HeaderText = "Компетенция 8";
            this.компетенция8DataGridViewTextBoxColumn.Name = "компетенция8DataGridViewTextBoxColumn";
            // 
            // вопросов8DataGridViewTextBoxColumn
            // 
            this.вопросов8DataGridViewTextBoxColumn.DataPropertyName = "Вопросов 8";
            this.вопросов8DataGridViewTextBoxColumn.HeaderText = "Вопросов 8";
            this.вопросов8DataGridViewTextBoxColumn.Name = "вопросов8DataGridViewTextBoxColumn";
            // 
            // компетенция9DataGridViewTextBoxColumn
            // 
            this.компетенция9DataGridViewTextBoxColumn.DataPropertyName = "Компетенция 9";
            this.компетенция9DataGridViewTextBoxColumn.HeaderText = "Компетенция 9";
            this.компетенция9DataGridViewTextBoxColumn.Name = "компетенция9DataGridViewTextBoxColumn";
            // 
            // вопросов9DataGridViewTextBoxColumn
            // 
            this.вопросов9DataGridViewTextBoxColumn.DataPropertyName = "Вопросов 9";
            this.вопросов9DataGridViewTextBoxColumn.HeaderText = "Вопросов 9";
            this.вопросов9DataGridViewTextBoxColumn.Name = "вопросов9DataGridViewTextBoxColumn";
            // 
            // компетенция10DataGridViewTextBoxColumn
            // 
            this.компетенция10DataGridViewTextBoxColumn.DataPropertyName = "Компетенция 10";
            this.компетенция10DataGridViewTextBoxColumn.HeaderText = "Компетенция 10";
            this.компетенция10DataGridViewTextBoxColumn.Name = "компетенция10DataGridViewTextBoxColumn";
            // 
            // вопросов10DataGridViewTextBoxColumn
            // 
            this.вопросов10DataGridViewTextBoxColumn.DataPropertyName = "Вопросов 10";
            this.вопросов10DataGridViewTextBoxColumn.HeaderText = "Вопросов 10";
            this.вопросов10DataGridViewTextBoxColumn.Name = "вопросов10DataGridViewTextBoxColumn";
            // 
            // сompetenceBindingSource
            // 
            this.сompetenceBindingSource.DataMember = "Сompetence";
            this.сompetenceBindingSource.DataSource = this.medtest_dbDataSet1;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // фамилияУчастникаDataGridViewTextBoxColumn1
            // 
            this.фамилияУчастникаDataGridViewTextBoxColumn1.DataPropertyName = "Фамилия участника";
            this.фамилияУчастникаDataGridViewTextBoxColumn1.HeaderText = "Фамилия участника";
            this.фамилияУчастникаDataGridViewTextBoxColumn1.Name = "фамилияУчастникаDataGridViewTextBoxColumn1";
            // 
            // названиеРазделаDataGridViewTextBoxColumn1
            // 
            this.названиеРазделаDataGridViewTextBoxColumn1.DataPropertyName = "Название раздела";
            this.названиеРазделаDataGridViewTextBoxColumn1.HeaderText = "Название раздела";
            this.названиеРазделаDataGridViewTextBoxColumn1.Name = "названиеРазделаDataGridViewTextBoxColumn1";
            // 
            // итогDataGridViewTextBoxColumn
            // 
            this.итогDataGridViewTextBoxColumn.DataPropertyName = "Итог";
            this.итогDataGridViewTextBoxColumn.HeaderText = "Итог";
            this.итогDataGridViewTextBoxColumn.Name = "итогDataGridViewTextBoxColumn";
            // 
            // процент1DataGridViewTextBoxColumn
            // 
            this.процент1DataGridViewTextBoxColumn.DataPropertyName = "Процент 1";
            this.процент1DataGridViewTextBoxColumn.HeaderText = "Процент 1";
            this.процент1DataGridViewTextBoxColumn.Name = "процент1DataGridViewTextBoxColumn";
            // 
            // процент2DataGridViewTextBoxColumn
            // 
            this.процент2DataGridViewTextBoxColumn.DataPropertyName = "Процент 2";
            this.процент2DataGridViewTextBoxColumn.HeaderText = "Процент 2";
            this.процент2DataGridViewTextBoxColumn.Name = "процент2DataGridViewTextBoxColumn";
            // 
            // процент3DataGridViewTextBoxColumn
            // 
            this.процент3DataGridViewTextBoxColumn.DataPropertyName = "Процент 3";
            this.процент3DataGridViewTextBoxColumn.HeaderText = "Процент 3";
            this.процент3DataGridViewTextBoxColumn.Name = "процент3DataGridViewTextBoxColumn";
            // 
            // процент4DataGridViewTextBoxColumn
            // 
            this.процент4DataGridViewTextBoxColumn.DataPropertyName = "Процент 4";
            this.процент4DataGridViewTextBoxColumn.HeaderText = "Процент 4";
            this.процент4DataGridViewTextBoxColumn.Name = "процент4DataGridViewTextBoxColumn";
            // 
            // процент5DataGridViewTextBoxColumn
            // 
            this.процент5DataGridViewTextBoxColumn.DataPropertyName = "Процент 5";
            this.процент5DataGridViewTextBoxColumn.HeaderText = "Процент 5";
            this.процент5DataGridViewTextBoxColumn.Name = "процент5DataGridViewTextBoxColumn";
            // 
            // процент6DataGridViewTextBoxColumn
            // 
            this.процент6DataGridViewTextBoxColumn.DataPropertyName = "Процент 6";
            this.процент6DataGridViewTextBoxColumn.HeaderText = "Процент 6";
            this.процент6DataGridViewTextBoxColumn.Name = "процент6DataGridViewTextBoxColumn";
            // 
            // процент7DataGridViewTextBoxColumn
            // 
            this.процент7DataGridViewTextBoxColumn.DataPropertyName = "Процент 7";
            this.процент7DataGridViewTextBoxColumn.HeaderText = "Процент 7";
            this.процент7DataGridViewTextBoxColumn.Name = "процент7DataGridViewTextBoxColumn";
            // 
            // процент8DataGridViewTextBoxColumn
            // 
            this.процент8DataGridViewTextBoxColumn.DataPropertyName = "Процент 8";
            this.процент8DataGridViewTextBoxColumn.HeaderText = "Процент 8";
            this.процент8DataGridViewTextBoxColumn.Name = "процент8DataGridViewTextBoxColumn";
            // 
            // процент9DataGridViewTextBoxColumn
            // 
            this.процент9DataGridViewTextBoxColumn.DataPropertyName = "Процент 9";
            this.процент9DataGridViewTextBoxColumn.HeaderText = "Процент 9";
            this.процент9DataGridViewTextBoxColumn.Name = "процент9DataGridViewTextBoxColumn";
            // 
            // процент10DataGridViewTextBoxColumn
            // 
            this.процент10DataGridViewTextBoxColumn.DataPropertyName = "Процент 10";
            this.процент10DataGridViewTextBoxColumn.HeaderText = "Процент 10";
            this.процент10DataGridViewTextBoxColumn.Name = "процент10DataGridViewTextBoxColumn";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tab_control_results);
            this.tabPage6.Controls.Add(this.groupBox3);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1266, 503);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Результаты";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tab_control_results
            // 
            this.tab_control_results.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tab_control_results.Controls.Add(this.tabPage7);
            this.tab_control_results.Controls.Add(this.tabPage8);
            this.tab_control_results.Controls.Add(this.tabPage12);
            this.tab_control_results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_control_results.Location = new System.Drawing.Point(161, 0);
            this.tab_control_results.Multiline = true;
            this.tab_control_results.Name = "tab_control_results";
            this.tab_control_results.SelectedIndex = 0;
            this.tab_control_results.Size = new System.Drawing.Size(1105, 503);
            this.tab_control_results.TabIndex = 4;
            this.tab_control_results.SelectedIndexChanged += new System.EventHandler(this.tab_control_results_SelectedIndexChanged);
            // 
            // tabPage7
            // 
            this.tabPage7.AutoScroll = true;
            this.tabPage7.Controls.Add(this.Resultsitog_datagrid);
            this.tabPage7.Location = new System.Drawing.Point(23, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1078, 495);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Итоговые результаты";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // Resultsitog_datagrid
            // 
            this.Resultsitog_datagrid.AllowUserToAddRows = false;
            this.Resultsitog_datagrid.AllowUserToDeleteRows = false;
            this.Resultsitog_datagrid.AutoGenerateColumns = false;
            this.Resultsitog_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Resultsitog_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37});
            this.Resultsitog_datagrid.DataSource = this.resultsBindingSource;
            this.Resultsitog_datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Resultsitog_datagrid.Location = new System.Drawing.Point(3, 3);
            this.Resultsitog_datagrid.Name = "Resultsitog_datagrid";
            this.Resultsitog_datagrid.Size = new System.Drawing.Size(1072, 489);
            this.Resultsitog_datagrid.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Фамилия участника";
            this.dataGridViewTextBoxColumn25.DataSource = this.participantsBindingSource;
            this.dataGridViewTextBoxColumn25.DisplayMember = "Фамилия";
            this.dataGridViewTextBoxColumn25.HeaderText = "Фамилия участника";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn25.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn25.ValueMember = "ID";
            this.dataGridViewTextBoxColumn25.Width = 130;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Название раздела";
            this.dataGridViewTextBoxColumn26.DataSource = this.sectionsBindingSource;
            this.dataGridViewTextBoxColumn26.DisplayMember = "Название";
            this.dataGridViewTextBoxColumn26.HeaderText = "Название раздела";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn26.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn26.ValueMember = "ID";
            this.dataGridViewTextBoxColumn26.Width = 200;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Итог";
            this.dataGridViewTextBoxColumn27.HeaderText = "Итог";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Процент 1";
            this.dataGridViewTextBoxColumn28.HeaderText = "Процент 1";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Процент 2";
            this.dataGridViewTextBoxColumn29.HeaderText = "Процент 2";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Процент 3";
            this.dataGridViewTextBoxColumn30.HeaderText = "Процент 3";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "Процент 4";
            this.dataGridViewTextBoxColumn31.HeaderText = "Процент 4";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Процент 5";
            this.dataGridViewTextBoxColumn32.HeaderText = "Процент 5";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Процент 6";
            this.dataGridViewTextBoxColumn33.HeaderText = "Процент 6";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "Процент 7";
            this.dataGridViewTextBoxColumn34.HeaderText = "Процент 7";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "Процент 8";
            this.dataGridViewTextBoxColumn35.HeaderText = "Процент 8";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "Процент 9";
            this.dataGridViewTextBoxColumn36.HeaderText = "Процент 9";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "Процент 10";
            this.dataGridViewTextBoxColumn37.HeaderText = "Процент 10";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.chart1);
            this.tabPage8.Location = new System.Drawing.Point(23, 4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1078, 495);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Диаграмма";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1072, 489);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 503);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Отделения";
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.passwordsBindingSource;
            this.listBox2.DisplayMember = "Название отделения";
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(3, 16);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(155, 484);
            this.listBox2.TabIndex = 0;
            this.listBox2.ValueMember = "ID";
            this.listBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDoubleClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.Attempts_datagrid);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1266, 503);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Попытки";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Attempts_datagrid
            // 
            this.Attempts_datagrid.AllowUserToAddRows = false;
            this.Attempts_datagrid.AllowUserToDeleteRows = false;
            this.Attempts_datagrid.AutoGenerateColumns = false;
            this.Attempts_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Attempts_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фамилияУчастникаDataGridViewTextBoxColumn,
            this.названиеРазделаDataGridViewTextBoxColumn,
            this.количествоПопытокDataGridViewTextBoxColumn1});
            this.Attempts_datagrid.DataSource = this.attemptsBindingSource;
            this.Attempts_datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Attempts_datagrid.Location = new System.Drawing.Point(0, 0);
            this.Attempts_datagrid.Name = "Attempts_datagrid";
            this.Attempts_datagrid.Size = new System.Drawing.Size(1266, 503);
            this.Attempts_datagrid.TabIndex = 1;
            // 
            // фамилияУчастникаDataGridViewTextBoxColumn
            // 
            this.фамилияУчастникаDataGridViewTextBoxColumn.DataPropertyName = "Фамилия участника";
            this.фамилияУчастникаDataGridViewTextBoxColumn.DataSource = this.participantsBindingSource;
            this.фамилияУчастникаDataGridViewTextBoxColumn.DisplayMember = "Фамилия";
            this.фамилияУчастникаDataGridViewTextBoxColumn.HeaderText = "Фамилия участника";
            this.фамилияУчастникаDataGridViewTextBoxColumn.Name = "фамилияУчастникаDataGridViewTextBoxColumn";
            this.фамилияУчастникаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.фамилияУчастникаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.фамилияУчастникаDataGridViewTextBoxColumn.ValueMember = "ID";
            this.фамилияУчастникаDataGridViewTextBoxColumn.Width = 150;
            // 
            // названиеРазделаDataGridViewTextBoxColumn
            // 
            this.названиеРазделаDataGridViewTextBoxColumn.DataPropertyName = "Название раздела";
            this.названиеРазделаDataGridViewTextBoxColumn.DataSource = this.sectionsBindingSource;
            this.названиеРазделаDataGridViewTextBoxColumn.DisplayMember = "Название";
            this.названиеРазделаDataGridViewTextBoxColumn.HeaderText = "Название раздела";
            this.названиеРазделаDataGridViewTextBoxColumn.Name = "названиеРазделаDataGridViewTextBoxColumn";
            this.названиеРазделаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.названиеРазделаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.названиеРазделаDataGridViewTextBoxColumn.ValueMember = "ID";
            this.названиеРазделаDataGridViewTextBoxColumn.Width = 200;
            // 
            // количествоПопытокDataGridViewTextBoxColumn1
            // 
            this.количествоПопытокDataGridViewTextBoxColumn1.DataPropertyName = "Количество попыток";
            this.количествоПопытокDataGridViewTextBoxColumn1.HeaderText = "Количество попыток";
            this.количествоПопытокDataGridViewTextBoxColumn1.Name = "количествоПопытокDataGridViewTextBoxColumn1";
            this.количествоПопытокDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Passwords_datagrid);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1266, 503);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Пароли";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Passwords_datagrid
            // 
            this.Passwords_datagrid.AllowUserToAddRows = false;
            this.Passwords_datagrid.AllowUserToDeleteRows = false;
            this.Passwords_datagrid.AutoGenerateColumns = false;
            this.Passwords_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Passwords_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеОтделенияDataGridViewTextBoxColumn,
            this.парольDataGridViewTextBoxColumn1});
            this.Passwords_datagrid.DataSource = this.passwordsBindingSource;
            this.Passwords_datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Passwords_datagrid.Location = new System.Drawing.Point(0, 0);
            this.Passwords_datagrid.Name = "Passwords_datagrid";
            this.Passwords_datagrid.Size = new System.Drawing.Size(1266, 503);
            this.Passwords_datagrid.TabIndex = 0;
            // 
            // названиеОтделенияDataGridViewTextBoxColumn
            // 
            this.названиеОтделенияDataGridViewTextBoxColumn.DataPropertyName = "Название отделения";
            this.названиеОтделенияDataGridViewTextBoxColumn.HeaderText = "Название отделения";
            this.названиеОтделенияDataGridViewTextBoxColumn.Name = "названиеОтделенияDataGridViewTextBoxColumn";
            this.названиеОтделенияDataGridViewTextBoxColumn.Width = 170;
            // 
            // парольDataGridViewTextBoxColumn1
            // 
            this.парольDataGridViewTextBoxColumn1.DataPropertyName = "Пароль";
            this.парольDataGridViewTextBoxColumn1.HeaderText = "Пароль";
            this.парольDataGridViewTextBoxColumn1.Name = "парольDataGridViewTextBoxColumn1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl1);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1266, 503);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Вопросы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(227, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1039, 503);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.Questions_datagrid);
            this.tabPage9.Location = new System.Drawing.Point(23, 4);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1012, 495);
            this.tabPage9.TabIndex = 0;
            this.tabPage9.Text = "Просмотреть вопросы";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // Questions_datagrid
            // 
            this.Questions_datagrid.AllowUserToAddRows = false;
            this.Questions_datagrid.AllowUserToDeleteRows = false;
            this.Questions_datagrid.AutoGenerateColumns = false;
            this.Questions_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Questions_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.вопросDataGridViewTextBoxColumn,
            this.убранИзТестаDataGridViewCheckBoxColumn,
            this.ответ1DataGridViewTextBoxColumn,
            this.цель1DataGridViewCheckBoxColumn,
            this.ответ2DataGridViewTextBoxColumn,
            this.цель2DataGridViewCheckBoxColumn,
            this.ответ3DataGridViewTextBoxColumn,
            this.цель3DataGridViewCheckBoxColumn,
            this.ответ4DataGridViewTextBoxColumn,
            this.цель4DataGridViewCheckBoxColumn,
            this.ответ5DataGridViewTextBoxColumn,
            this.цель5DataGridViewCheckBoxColumn,
            this.цельТекстDataGridViewTextBoxColumn});
            this.Questions_datagrid.DataSource = this.questionsBindingSource;
            this.Questions_datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Questions_datagrid.Location = new System.Drawing.Point(3, 3);
            this.Questions_datagrid.Name = "Questions_datagrid";
            this.Questions_datagrid.ReadOnly = true;
            this.Questions_datagrid.Size = new System.Drawing.Size(1006, 489);
            this.Questions_datagrid.TabIndex = 67;
            // 
            // вопросDataGridViewTextBoxColumn
            // 
            this.вопросDataGridViewTextBoxColumn.DataPropertyName = "Вопрос";
            this.вопросDataGridViewTextBoxColumn.HeaderText = "Вопрос";
            this.вопросDataGridViewTextBoxColumn.Name = "вопросDataGridViewTextBoxColumn";
            this.вопросDataGridViewTextBoxColumn.ReadOnly = true;
            this.вопросDataGridViewTextBoxColumn.Width = 400;
            // 
            // убранИзТестаDataGridViewCheckBoxColumn
            // 
            this.убранИзТестаDataGridViewCheckBoxColumn.DataPropertyName = "Убран из теста";
            this.убранИзТестаDataGridViewCheckBoxColumn.HeaderText = "Убран из теста";
            this.убранИзТестаDataGridViewCheckBoxColumn.Name = "убранИзТестаDataGridViewCheckBoxColumn";
            this.убранИзТестаDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ответ1DataGridViewTextBoxColumn
            // 
            this.ответ1DataGridViewTextBoxColumn.DataPropertyName = "Ответ 1";
            this.ответ1DataGridViewTextBoxColumn.HeaderText = "Ответ 1";
            this.ответ1DataGridViewTextBoxColumn.Name = "ответ1DataGridViewTextBoxColumn";
            this.ответ1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // цель1DataGridViewCheckBoxColumn
            // 
            this.цель1DataGridViewCheckBoxColumn.DataPropertyName = "Цель 1";
            this.цель1DataGridViewCheckBoxColumn.HeaderText = "Цель 1";
            this.цель1DataGridViewCheckBoxColumn.Name = "цель1DataGridViewCheckBoxColumn";
            this.цель1DataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ответ2DataGridViewTextBoxColumn
            // 
            this.ответ2DataGridViewTextBoxColumn.DataPropertyName = "Ответ 2";
            this.ответ2DataGridViewTextBoxColumn.HeaderText = "Ответ 2";
            this.ответ2DataGridViewTextBoxColumn.Name = "ответ2DataGridViewTextBoxColumn";
            this.ответ2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // цель2DataGridViewCheckBoxColumn
            // 
            this.цель2DataGridViewCheckBoxColumn.DataPropertyName = "Цель 2";
            this.цель2DataGridViewCheckBoxColumn.HeaderText = "Цель 2";
            this.цель2DataGridViewCheckBoxColumn.Name = "цель2DataGridViewCheckBoxColumn";
            this.цель2DataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ответ3DataGridViewTextBoxColumn
            // 
            this.ответ3DataGridViewTextBoxColumn.DataPropertyName = "Ответ 3";
            this.ответ3DataGridViewTextBoxColumn.HeaderText = "Ответ 3";
            this.ответ3DataGridViewTextBoxColumn.Name = "ответ3DataGridViewTextBoxColumn";
            this.ответ3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // цель3DataGridViewCheckBoxColumn
            // 
            this.цель3DataGridViewCheckBoxColumn.DataPropertyName = "Цель 3";
            this.цель3DataGridViewCheckBoxColumn.HeaderText = "Цель 3";
            this.цель3DataGridViewCheckBoxColumn.Name = "цель3DataGridViewCheckBoxColumn";
            this.цель3DataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ответ4DataGridViewTextBoxColumn
            // 
            this.ответ4DataGridViewTextBoxColumn.DataPropertyName = "Ответ 4";
            this.ответ4DataGridViewTextBoxColumn.HeaderText = "Ответ 4";
            this.ответ4DataGridViewTextBoxColumn.Name = "ответ4DataGridViewTextBoxColumn";
            this.ответ4DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // цель4DataGridViewCheckBoxColumn
            // 
            this.цель4DataGridViewCheckBoxColumn.DataPropertyName = "Цель 4";
            this.цель4DataGridViewCheckBoxColumn.HeaderText = "Цель 4";
            this.цель4DataGridViewCheckBoxColumn.Name = "цель4DataGridViewCheckBoxColumn";
            this.цель4DataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ответ5DataGridViewTextBoxColumn
            // 
            this.ответ5DataGridViewTextBoxColumn.DataPropertyName = "Ответ 5";
            this.ответ5DataGridViewTextBoxColumn.HeaderText = "Ответ 5";
            this.ответ5DataGridViewTextBoxColumn.Name = "ответ5DataGridViewTextBoxColumn";
            this.ответ5DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // цель5DataGridViewCheckBoxColumn
            // 
            this.цель5DataGridViewCheckBoxColumn.DataPropertyName = "Цель 5";
            this.цель5DataGridViewCheckBoxColumn.HeaderText = "Цель 5";
            this.цель5DataGridViewCheckBoxColumn.Name = "цель5DataGridViewCheckBoxColumn";
            this.цель5DataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // цельТекстDataGridViewTextBoxColumn
            // 
            this.цельТекстDataGridViewTextBoxColumn.DataPropertyName = "Цель текст";
            this.цельТекстDataGridViewTextBoxColumn.HeaderText = "Цель текст";
            this.цельТекстDataGridViewTextBoxColumn.Name = "цельТекстDataGridViewTextBoxColumn";
            this.цельТекстDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.groupBox6);
            this.tabPage10.Controls.Add(this.richtext_add_question);
            this.tabPage10.Controls.Add(this.groupBox4);
            this.tabPage10.Location = new System.Drawing.Point(23, 4);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(1012, 495);
            this.tabPage10.TabIndex = 1;
            this.tabPage10.Text = "Добавить вопрос";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.panel3);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(3, 186);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1006, 214);
            this.groupBox6.TabIndex = 61;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ответы";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.checkBox_add_not_test);
            this.panel3.Controls.Add(this.checkBox_add_type_ans);
            this.panel3.Controls.Add(this.textBox_add_string_ans);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.checkBox_add_var_5);
            this.panel3.Controls.Add(this.textBox_add_var_5);
            this.panel3.Controls.Add(this.checkBox_add_var_4);
            this.panel3.Controls.Add(this.checkBox_add_var_3);
            this.panel3.Controls.Add(this.checkBox_add_var_2);
            this.panel3.Controls.Add(this.checkBox_add_var_1);
            this.panel3.Controls.Add(this.textBox_add_var_1);
            this.panel3.Controls.Add(this.textBox_add_var_3);
            this.panel3.Controls.Add(this.textBox_add_var_2);
            this.panel3.Controls.Add(this.textBox_add_var_4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Calibri", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 192);
            this.panel3.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(665, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "Убран из теста";
            // 
            // checkBox_add_not_test
            // 
            this.checkBox_add_not_test.AutoSize = true;
            this.checkBox_add_not_test.Location = new System.Drawing.Point(761, 168);
            this.checkBox_add_not_test.Name = "checkBox_add_not_test";
            this.checkBox_add_not_test.Size = new System.Drawing.Size(15, 14);
            this.checkBox_add_not_test.TabIndex = 38;
            this.checkBox_add_not_test.UseVisualStyleBackColor = true;
            // 
            // checkBox_add_type_ans
            // 
            this.checkBox_add_type_ans.AutoSize = true;
            this.checkBox_add_type_ans.Location = new System.Drawing.Point(595, 168);
            this.checkBox_add_type_ans.Name = "checkBox_add_type_ans";
            this.checkBox_add_type_ans.Size = new System.Drawing.Size(15, 14);
            this.checkBox_add_type_ans.TabIndex = 37;
            this.checkBox_add_type_ans.UseVisualStyleBackColor = true;
            this.checkBox_add_type_ans.CheckedChanged += new System.EventHandler(this.checkBox_add_type_ans_CheckedChanged);
            // 
            // textBox_add_string_ans
            // 
            this.textBox_add_string_ans.Enabled = false;
            this.textBox_add_string_ans.Location = new System.Drawing.Point(112, 164);
            this.textBox_add_string_ans.Name = "textBox_add_string_ans";
            this.textBox_add_string_ans.Size = new System.Drawing.Size(477, 22);
            this.textBox_add_string_ans.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Строковый ответ";
            // 
            // checkBox_add_var_5
            // 
            this.checkBox_add_var_5.AutoSize = true;
            this.checkBox_add_var_5.Location = new System.Drawing.Point(7, 137);
            this.checkBox_add_var_5.Name = "checkBox_add_var_5";
            this.checkBox_add_var_5.Size = new System.Drawing.Size(15, 14);
            this.checkBox_add_var_5.TabIndex = 36;
            this.checkBox_add_var_5.UseVisualStyleBackColor = true;
            // 
            // textBox_add_var_5
            // 
            this.textBox_add_var_5.Font = new System.Drawing.Font("Calibri", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_add_var_5.Location = new System.Drawing.Point(28, 132);
            this.textBox_add_var_5.Name = "textBox_add_var_5";
            this.textBox_add_var_5.Size = new System.Drawing.Size(584, 22);
            this.textBox_add_var_5.TabIndex = 35;
            // 
            // checkBox_add_var_4
            // 
            this.checkBox_add_var_4.AutoSize = true;
            this.checkBox_add_var_4.Location = new System.Drawing.Point(7, 104);
            this.checkBox_add_var_4.Name = "checkBox_add_var_4";
            this.checkBox_add_var_4.Size = new System.Drawing.Size(15, 14);
            this.checkBox_add_var_4.TabIndex = 34;
            this.checkBox_add_var_4.UseVisualStyleBackColor = true;
            // 
            // checkBox_add_var_3
            // 
            this.checkBox_add_var_3.AutoSize = true;
            this.checkBox_add_var_3.Location = new System.Drawing.Point(7, 73);
            this.checkBox_add_var_3.Name = "checkBox_add_var_3";
            this.checkBox_add_var_3.Size = new System.Drawing.Size(15, 14);
            this.checkBox_add_var_3.TabIndex = 33;
            this.checkBox_add_var_3.UseVisualStyleBackColor = true;
            // 
            // checkBox_add_var_2
            // 
            this.checkBox_add_var_2.AutoSize = true;
            this.checkBox_add_var_2.Location = new System.Drawing.Point(7, 42);
            this.checkBox_add_var_2.Name = "checkBox_add_var_2";
            this.checkBox_add_var_2.Size = new System.Drawing.Size(15, 14);
            this.checkBox_add_var_2.TabIndex = 32;
            this.checkBox_add_var_2.UseVisualStyleBackColor = true;
            // 
            // checkBox_add_var_1
            // 
            this.checkBox_add_var_1.AutoSize = true;
            this.checkBox_add_var_1.Location = new System.Drawing.Point(7, 11);
            this.checkBox_add_var_1.Name = "checkBox_add_var_1";
            this.checkBox_add_var_1.Size = new System.Drawing.Size(15, 14);
            this.checkBox_add_var_1.TabIndex = 31;
            this.checkBox_add_var_1.UseVisualStyleBackColor = true;
            // 
            // textBox_add_var_1
            // 
            this.textBox_add_var_1.Font = new System.Drawing.Font("Calibri", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_add_var_1.Location = new System.Drawing.Point(28, 6);
            this.textBox_add_var_1.Name = "textBox_add_var_1";
            this.textBox_add_var_1.Size = new System.Drawing.Size(584, 22);
            this.textBox_add_var_1.TabIndex = 21;
            // 
            // textBox_add_var_3
            // 
            this.textBox_add_var_3.Font = new System.Drawing.Font("Calibri", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_add_var_3.Location = new System.Drawing.Point(28, 68);
            this.textBox_add_var_3.Name = "textBox_add_var_3";
            this.textBox_add_var_3.Size = new System.Drawing.Size(584, 22);
            this.textBox_add_var_3.TabIndex = 25;
            // 
            // textBox_add_var_2
            // 
            this.textBox_add_var_2.Font = new System.Drawing.Font("Calibri", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_add_var_2.Location = new System.Drawing.Point(28, 37);
            this.textBox_add_var_2.Name = "textBox_add_var_2";
            this.textBox_add_var_2.Size = new System.Drawing.Size(584, 22);
            this.textBox_add_var_2.TabIndex = 23;
            // 
            // textBox_add_var_4
            // 
            this.textBox_add_var_4.Font = new System.Drawing.Font("Calibri", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_add_var_4.Location = new System.Drawing.Point(28, 99);
            this.textBox_add_var_4.Name = "textBox_add_var_4";
            this.textBox_add_var_4.Size = new System.Drawing.Size(584, 22);
            this.textBox_add_var_4.TabIndex = 27;
            // 
            // richtext_add_question
            // 
            this.richtext_add_question.Dock = System.Windows.Forms.DockStyle.Top;
            this.richtext_add_question.Font = new System.Drawing.Font("Calibri", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richtext_add_question.Location = new System.Drawing.Point(3, 57);
            this.richtext_add_question.Name = "richtext_add_question";
            this.richtext_add_question.Size = new System.Drawing.Size(1006, 129);
            this.richtext_add_question.TabIndex = 62;
            this.richtext_add_question.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_question_clear);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1006, 54);
            this.groupBox4.TabIndex = 60;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Функции";
            // 
            // button_question_clear
            // 
            this.button_question_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_question_clear.Location = new System.Drawing.Point(144, 20);
            this.button_question_clear.Name = "button_question_clear";
            this.button_question_clear.Size = new System.Drawing.Size(135, 28);
            this.button_question_clear.TabIndex = 4;
            this.button_question_clear.Text = "Очистить";
            this.button_question_clear.UseVisualStyleBackColor = true;
            this.button_question_clear.Click += new System.EventHandler(this.button_question_clear_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(6, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 503);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Компетенции";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.сompetenceBindingSource;
            this.listBox1.DisplayMember = "Компетенция";
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 484);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "ID";
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Sections_datagrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1266, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Разделы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Sections_datagrid
            // 
            this.Sections_datagrid.AllowUserToAddRows = false;
            this.Sections_datagrid.AllowUserToDeleteRows = false;
            this.Sections_datagrid.AutoGenerateColumns = false;
            this.Sections_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sections_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.Sections_datagrid.DataSource = this.sectionsBindingSource;
            this.Sections_datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sections_datagrid.Location = new System.Drawing.Point(3, 3);
            this.Sections_datagrid.Name = "Sections_datagrid";
            this.Sections_datagrid.Size = new System.Drawing.Size(1260, 497);
            this.Sections_datagrid.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Participants_datagrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1266, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Участники";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Participants_datagrid
            // 
            this.Participants_datagrid.AllowUserToAddRows = false;
            this.Participants_datagrid.AllowUserToDeleteRows = false;
            this.Participants_datagrid.AutoGenerateColumns = false;
            this.Participants_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Participants_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn,
            this.категорияDataGridViewTextBoxColumn,
            this.отделениеDataGridViewTextBoxColumn,
            this.парольDataGridViewTextBoxColumn});
            this.Participants_datagrid.DataSource = this.participantsBindingSource;
            this.Participants_datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Participants_datagrid.Location = new System.Drawing.Point(3, 3);
            this.Participants_datagrid.Name = "Participants_datagrid";
            this.Participants_datagrid.Size = new System.Drawing.Size(1260, 497);
            this.Participants_datagrid.TabIndex = 0;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.Width = 130;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.Width = 130;
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            // 
            // категорияDataGridViewTextBoxColumn
            // 
            this.категорияDataGridViewTextBoxColumn.DataPropertyName = "Категория";
            this.категорияDataGridViewTextBoxColumn.DataSource = this.dictCategBindingSource;
            this.категорияDataGridViewTextBoxColumn.DisplayMember = "Категория";
            this.категорияDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.категорияDataGridViewTextBoxColumn.Name = "категорияDataGridViewTextBoxColumn";
            this.категорияDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.категорияDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.категорияDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // отделениеDataGridViewTextBoxColumn
            // 
            this.отделениеDataGridViewTextBoxColumn.DataPropertyName = "Отделение";
            this.отделениеDataGridViewTextBoxColumn.DataSource = this.passwordsBindingSource;
            this.отделениеDataGridViewTextBoxColumn.DisplayMember = "Название отделения";
            this.отделениеDataGridViewTextBoxColumn.HeaderText = "Отделение";
            this.отделениеDataGridViewTextBoxColumn.Name = "отделениеDataGridViewTextBoxColumn";
            this.отделениеDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.отделениеDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.отделениеDataGridViewTextBoxColumn.ValueMember = "ID";
            this.отделениеDataGridViewTextBoxColumn.Width = 150;
            // 
            // парольDataGridViewTextBoxColumn
            // 
            this.парольDataGridViewTextBoxColumn.DataPropertyName = "Пароль";
            this.парольDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.парольDataGridViewTextBoxColumn.Name = "парольDataGridViewTextBoxColumn";
            // 
            // tabcontrol_head
            // 
            this.tabcontrol_head.Controls.Add(this.tabPage1);
            this.tabcontrol_head.Controls.Add(this.tabPage2);
            this.tabcontrol_head.Controls.Add(this.tabPage3);
            this.tabcontrol_head.Controls.Add(this.tabPage4);
            this.tabcontrol_head.Controls.Add(this.tabPage5);
            this.tabcontrol_head.Controls.Add(this.tabPage6);
            this.tabcontrol_head.Controls.Add(this.tabPage11);
            this.tabcontrol_head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol_head.Location = new System.Drawing.Point(0, 49);
            this.tabcontrol_head.Multiline = true;
            this.tabcontrol_head.Name = "tabcontrol_head";
            this.tabcontrol_head.SelectedIndex = 0;
            this.tabcontrol_head.Size = new System.Drawing.Size(1274, 529);
            this.tabcontrol_head.TabIndex = 3;
            this.tabcontrol_head.Visible = false;
            this.tabcontrol_head.SelectedIndexChanged += new System.EventHandler(this.tabcontrol_head_SelectedIndexChanged);
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(1266, 503);
            this.tabPage11.TabIndex = 6;
            this.tabPage11.Text = "Компетенции";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(23, 4);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(1078, 495);
            this.tabPage12.TabIndex = 2;
            this.tabPage12.Text = "Попытки";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Время";
            this.dataGridViewTextBoxColumn3.HeaderText = "Время";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Количество попыток";
            this.dataGridViewTextBoxColumn4.HeaderText = "Количество попыток";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Запустить тестирование";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Запустить тестирование";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Компетенция 1";
            this.dataGridViewTextBoxColumn5.DataSource = this.сompetenceBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "Компетенция";
            this.dataGridViewTextBoxColumn5.HeaderText = "Компетенция 1";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "ID";
            this.dataGridViewTextBoxColumn5.Width = 300;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Вопросов 1";
            this.dataGridViewTextBoxColumn6.HeaderText = "Вопросов 1";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Компетенция 2";
            this.dataGridViewTextBoxColumn7.DataSource = this.сompetenceBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "Компетенция";
            this.dataGridViewTextBoxColumn7.HeaderText = "Компетенция 2";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "ID";
            this.dataGridViewTextBoxColumn7.Width = 300;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Вопросов 2";
            this.dataGridViewTextBoxColumn8.HeaderText = "Вопросов 2";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Компетенция 3";
            this.dataGridViewTextBoxColumn9.DataSource = this.сompetenceBindingSource;
            this.dataGridViewTextBoxColumn9.DisplayMember = "Компетенция";
            this.dataGridViewTextBoxColumn9.HeaderText = "Компетенция 3";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.ValueMember = "ID";
            this.dataGridViewTextBoxColumn9.Width = 300;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Вопросов 3";
            this.dataGridViewTextBoxColumn10.HeaderText = "Вопросов 3";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Компетенция 4";
            this.dataGridViewTextBoxColumn11.DataSource = this.сompetenceBindingSource;
            this.dataGridViewTextBoxColumn11.DisplayMember = "Компетенция";
            this.dataGridViewTextBoxColumn11.HeaderText = "Компетенция 4";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn11.ValueMember = "ID";
            this.dataGridViewTextBoxColumn11.Width = 300;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Вопросов 4";
            this.dataGridViewTextBoxColumn12.HeaderText = "Вопросов 4";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Компетенция 5";
            this.dataGridViewTextBoxColumn13.DataSource = this.сompetenceBindingSource;
            this.dataGridViewTextBoxColumn13.DisplayMember = "Компетенция";
            this.dataGridViewTextBoxColumn13.HeaderText = "Компетенция 5";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn13.ValueMember = "ID";
            this.dataGridViewTextBoxColumn13.Width = 300;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Вопросов 5";
            this.dataGridViewTextBoxColumn14.HeaderText = "Вопросов 5";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Компетенция 6";
            this.dataGridViewTextBoxColumn15.DataSource = this.сompetenceBindingSource;
            this.dataGridViewTextBoxColumn15.DisplayMember = "Компетенция";
            this.dataGridViewTextBoxColumn15.HeaderText = "Компетенция 6";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn15.ValueMember = "ID";
            this.dataGridViewTextBoxColumn15.Width = 300;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Вопросов 6";
            this.dataGridViewTextBoxColumn16.HeaderText = "Вопросов 6";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Компетенция 7";
            this.dataGridViewTextBoxColumn17.DataSource = this.сompetenceBindingSource;
            this.dataGridViewTextBoxColumn17.DisplayMember = "Компетенция";
            this.dataGridViewTextBoxColumn17.HeaderText = "Компетенция 7";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn17.ValueMember = "ID";
            this.dataGridViewTextBoxColumn17.Width = 300;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Вопросов 7";
            this.dataGridViewTextBoxColumn18.HeaderText = "Вопросов 7";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Компетенция 8";
            this.dataGridViewTextBoxColumn19.DataSource = this.сompetenceBindingSource;
            this.dataGridViewTextBoxColumn19.DisplayMember = "Компетенция";
            this.dataGridViewTextBoxColumn19.HeaderText = "Компетенция 8";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn19.ValueMember = "ID";
            this.dataGridViewTextBoxColumn19.Width = 300;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Вопросов 8";
            this.dataGridViewTextBoxColumn20.HeaderText = "Вопросов 8";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Компетенция 9";
            this.dataGridViewTextBoxColumn21.DataSource = this.сompetenceBindingSource;
            this.dataGridViewTextBoxColumn21.DisplayMember = "Компетенция";
            this.dataGridViewTextBoxColumn21.HeaderText = "Компетенция 9";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn21.ValueMember = "ID";
            this.dataGridViewTextBoxColumn21.Width = 300;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Вопросов 9";
            this.dataGridViewTextBoxColumn22.HeaderText = "Вопросов 9";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Компетенция 10";
            this.dataGridViewTextBoxColumn23.DataSource = this.сompetenceBindingSource;
            this.dataGridViewTextBoxColumn23.DisplayMember = "Компетенция";
            this.dataGridViewTextBoxColumn23.HeaderText = "Компетенция 10";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn23.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn23.ValueMember = "ID";
            this.dataGridViewTextBoxColumn23.Width = 300;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Вопросов 10";
            this.dataGridViewTextBoxColumn24.HeaderText = "Вопросов 10";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 578);
            this.Controls.Add(this.panel_authorization);
            this.Controls.Add(this.tabcontrol_head);
            this.Controls.Add(this.toolStrip_panel);
            this.Controls.Add(this.menu_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menu_panel;
            this.Name = "Main";
            this.Text = "Medtest DBE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            this.toolStrip_panel.ResumeLayout(false);
            this.toolStrip_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dictCategBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medtest_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attemptsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).EndInit();
            this.panel_authorization.ResumeLayout(false);
            this.panel_authorization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сompetenceBindingSource)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tab_control_results.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Resultsitog_datagrid)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Attempts_datagrid)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Passwords_datagrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Questions_datagrid)).EndInit();
            this.tabPage10.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Sections_datagrid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Participants_datagrid)).EndInit();
            this.tabcontrol_head.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_panel;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem опрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip_panel;
        private System.Windows.Forms.ToolStripButton toolStripButton_add;
        private System.Windows.Forms.ToolStripButton toolStripButton_Save;
        private System.Windows.Forms.ToolStripButton toolStripButton_Delete;
        private System.Windows.Forms.ToolStripButton toolStripButton_Update;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton_txt;
        private System.Windows.Forms.ToolStripButton toolStripButton_Excell;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem командыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сделатьЗапросПоБазеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStrip_Query;
        private System.Windows.Forms.Panel panel_authorization;
        private System.Windows.Forms.TextBox textBox_authorization_name_server;
        private System.Windows.Forms.Label label_authorization_name_server;
        private System.Windows.Forms.TextBox textBox_authorization_name_BD;
        private System.Windows.Forms.Label label_authorization_name_bd;
        private System.Windows.Forms.TextBox textBox_authorization_password;
        private System.Windows.Forms.Label label_authorization_password;
        private System.Windows.Forms.TextBox textBox_authorization_name_user;
        private System.Windows.Forms.Label label_authorization_name_user;
        private System.Windows.Forms.Button button_authorization_cancel;
        private System.Windows.Forms.Button button_authorization_connect;
        private System.Windows.Forms.Label label_authorization_head;
        private Medtest_dbDataSet1 medtest_dbDataSet1;
        private System.Windows.Forms.BindingSource participantsBindingSource;
        private Medtest_dbDataSet1TableAdapters.ParticipantsTableAdapter participantsTableAdapter;
        private System.Windows.Forms.BindingSource dictCategBindingSource;
        private Medtest_dbDataSet1TableAdapters.DictCategTableAdapter dictCategTableAdapter;
        private System.Windows.Forms.BindingSource sectionsBindingSource;
        private Medtest_dbDataSet1TableAdapters.SectionsTableAdapter sectionsTableAdapter;
        private System.Windows.Forms.BindingSource passwordsBindingSource;
        private Medtest_dbDataSet1TableAdapters.PasswordsTableAdapter passwordsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоВопросовDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource attemptsBindingSource;
        private Medtest_dbDataSet1TableAdapters.AttemptsTableAdapter attemptsTableAdapter;
        private System.Windows.Forms.BindingSource resultsBindingSource;
        private Medtest_dbDataSet1TableAdapters.ResultsTableAdapter resultsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерПопыткиDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource questionsBindingSource;
        private Medtest_dbDataSet1TableAdapters.QuestionsTableAdapter questionsTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem экспортВXMLToolStripMenuItem;
        private System.Windows.Forms.DataGridViewComboBoxColumn названиеРазделаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn типОтветовDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.BindingSource сompetenceBindingSource;
        private Medtest_dbDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private Medtest_dbDataSet1TableAdapters.СompetenceTableAdapter сompetenceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоПопытокDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn запуститьТестированиеDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn компетенция1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вопросов1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn компетенция2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вопросов2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn компетенция3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вопросов3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn компетенция4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вопросов4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn компетенция5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вопросов5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn компетенция6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вопросов6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn компетенция7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вопросов7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn компетенция8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вопросов8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn компетенция9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вопросов9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn компетенция10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вопросов10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияУчастникаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеРазделаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn итогDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn процент1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn процент2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn процент3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn процент4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn процент5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn процент6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn процент7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn процент8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn процент9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn процент10DataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabControl tab_control_results;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView Resultsitog_datagrid;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView Attempts_datagrid;
        private System.Windows.Forms.DataGridViewComboBoxColumn фамилияУчастникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn названиеРазделаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоПопытокDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView Passwords_datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеОтделенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn парольDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.DataGridView Questions_datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn вопросDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn убранИзТестаDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ответ1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn цель1DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ответ2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn цель2DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ответ3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn цель3DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ответ4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn цель4DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ответ5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn цель5DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цельТекстDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_add_not_test;
        private System.Windows.Forms.CheckBox checkBox_add_type_ans;
        private System.Windows.Forms.TextBox textBox_add_string_ans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_add_var_5;
        private System.Windows.Forms.TextBox textBox_add_var_5;
        private System.Windows.Forms.CheckBox checkBox_add_var_4;
        private System.Windows.Forms.CheckBox checkBox_add_var_3;
        private System.Windows.Forms.CheckBox checkBox_add_var_2;
        private System.Windows.Forms.CheckBox checkBox_add_var_1;
        private System.Windows.Forms.TextBox textBox_add_var_1;
        private System.Windows.Forms.TextBox textBox_add_var_3;
        private System.Windows.Forms.TextBox textBox_add_var_2;
        private System.Windows.Forms.TextBox textBox_add_var_4;
        private System.Windows.Forms.RichTextBox richtext_add_question;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_question_clear;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Sections_datagrid;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.DataGridView Participants_datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn категорияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn отделениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn парольDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabcontrol_head;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.TabPage tabPage11;

    }
}

