namespace Server_for_Medtest
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запуститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диаграммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьЛогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.узнатьIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_connect_db = new System.Windows.Forms.Panel();
            this.button_authorization_cancel = new System.Windows.Forms.Button();
            this.button_authorization_connect = new System.Windows.Forms.Button();
            this.label_authorization_head = new System.Windows.Forms.Label();
            this.textBox_authorization_name_db = new System.Windows.Forms.TextBox();
            this.label_authorization_name_bd = new System.Windows.Forms.Label();
            this.textBox_authorization_password = new System.Windows.Forms.TextBox();
            this.label_authorization_password = new System.Windows.Forms.Label();
            this.textBox_authorization_name_user = new System.Windows.Forms.TextBox();
            this.label_authorization_name_user = new System.Windows.Forms.Label();
            this.textBox_authorization_name_server = new System.Windows.Forms.TextBox();
            this.label_authorization_name_server = new System.Windows.Forms.Label();
            this.richTextBox_log = new System.Windows.Forms.RichTextBox();
            this.label_status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sendProgressBar = new System.Windows.Forms.ProgressBar();
            this.panel_settings = new System.Windows.Forms.Panel();
            this.label_info = new System.Windows.Forms.Label();
            this.button_settings_cancel = new System.Windows.Forms.Button();
            this.textBox_settings_name_server = new System.Windows.Forms.TextBox();
            this.button_settings_save = new System.Windows.Forms.Button();
            this.label_settings_head = new System.Windows.Forms.Label();
            this.button_settings_open = new System.Windows.Forms.Button();
            this.textBox_settings_path = new System.Windows.Forms.TextBox();
            this.label_settings_path = new System.Windows.Forms.Label();
            this.textBox_settings_name_db = new System.Windows.Forms.TextBox();
            this.label_settings_name_db = new System.Windows.Forms.Label();
            this.textBox_settings_password = new System.Windows.Forms.TextBox();
            this.label_settings_password = new System.Windows.Forms.Label();
            this.textBox_settings_name_user = new System.Windows.Forms.TextBox();
            this.label_settings_name_user = new System.Windows.Forms.Label();
            this.label_settings_name_server = new System.Windows.Forms.Label();
            this.receiveBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.sendBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.receiveBackgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.panel_connect_db.SuspendLayout();
            this.panel_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(474, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zToolStripMenuItem
            // 
            this.zToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запуститьToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.zToolStripMenuItem.Name = "zToolStripMenuItem";
            this.zToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.zToolStripMenuItem.Text = "Сервер";
            // 
            // запуститьToolStripMenuItem
            // 
            this.запуститьToolStripMenuItem.Name = "запуститьToolStripMenuItem";
            this.запуститьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.запуститьToolStripMenuItem.Text = "Запустить";
            this.запуститьToolStripMenuItem.Click += new System.EventHandler(this.запуститьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.диаграммаToolStripMenuItem,
            this.очиститьЛогToolStripMenuItem,
            this.узнатьIPToolStripMenuItem,
            this.toolStripSeparator2,
            this.настройкиToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // диаграммаToolStripMenuItem
            // 
            this.диаграммаToolStripMenuItem.Name = "диаграммаToolStripMenuItem";
            this.диаграммаToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.диаграммаToolStripMenuItem.Text = "Диаграмма клиентов";
            // 
            // очиститьЛогToolStripMenuItem
            // 
            this.очиститьЛогToolStripMenuItem.Name = "очиститьЛогToolStripMenuItem";
            this.очиститьЛогToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.очиститьЛогToolStripMenuItem.Text = "Очистить лог";
            this.очиститьЛогToolStripMenuItem.Click += new System.EventHandler(this.очиститьЛогToolStripMenuItem_Click);
            // 
            // узнатьIPToolStripMenuItem
            // 
            this.узнатьIPToolStripMenuItem.Name = "узнатьIPToolStripMenuItem";
            this.узнатьIPToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.узнатьIPToolStripMenuItem.Text = "Узнать IP сервера";
            this.узнатьIPToolStripMenuItem.Click += new System.EventHandler(this.узнатьIPToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem1});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.оПрограммеToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem1_Click);
            // 
            // panel_connect_db
            // 
            this.panel_connect_db.Controls.Add(this.button_authorization_cancel);
            this.panel_connect_db.Controls.Add(this.button_authorization_connect);
            this.panel_connect_db.Controls.Add(this.label_authorization_head);
            this.panel_connect_db.Controls.Add(this.textBox_authorization_name_db);
            this.panel_connect_db.Controls.Add(this.label_authorization_name_bd);
            this.panel_connect_db.Controls.Add(this.textBox_authorization_password);
            this.panel_connect_db.Controls.Add(this.label_authorization_password);
            this.panel_connect_db.Controls.Add(this.textBox_authorization_name_user);
            this.panel_connect_db.Controls.Add(this.label_authorization_name_user);
            this.panel_connect_db.Controls.Add(this.textBox_authorization_name_server);
            this.panel_connect_db.Controls.Add(this.label_authorization_name_server);
            this.panel_connect_db.Location = new System.Drawing.Point(0, 33);
            this.panel_connect_db.Name = "panel_connect_db";
            this.panel_connect_db.Size = new System.Drawing.Size(189, 222);
            this.panel_connect_db.TabIndex = 19;
            // 
            // button_authorization_cancel
            // 
            this.button_authorization_cancel.Location = new System.Drawing.Point(288, 289);
            this.button_authorization_cancel.Name = "button_authorization_cancel";
            this.button_authorization_cancel.Size = new System.Drawing.Size(64, 23);
            this.button_authorization_cancel.TabIndex = 21;
            this.button_authorization_cancel.Text = "Отмена";
            this.button_authorization_cancel.UseVisualStyleBackColor = true;
            this.button_authorization_cancel.Click += new System.EventHandler(this.button_authorization_cancel_Click);
            // 
            // button_authorization_connect
            // 
            this.button_authorization_connect.Location = new System.Drawing.Point(122, 289);
            this.button_authorization_connect.Name = "button_authorization_connect";
            this.button_authorization_connect.Size = new System.Drawing.Size(160, 23);
            this.button_authorization_connect.TabIndex = 20;
            this.button_authorization_connect.Text = "Соединить";
            this.button_authorization_connect.UseVisualStyleBackColor = true;
            this.button_authorization_connect.Click += new System.EventHandler(this.button_authorization_connect_Click);
            // 
            // label_authorization_head
            // 
            this.label_authorization_head.AutoSize = true;
            this.label_authorization_head.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_authorization_head.Location = new System.Drawing.Point(164, 9);
            this.label_authorization_head.Name = "label_authorization_head";
            this.label_authorization_head.Size = new System.Drawing.Size(142, 20);
            this.label_authorization_head.TabIndex = 19;
            this.label_authorization_head.Text = "Соединение с БД";
            // 
            // textBox_authorization_name_db
            // 
            this.textBox_authorization_name_db.Location = new System.Drawing.Point(122, 253);
            this.textBox_authorization_name_db.Name = "textBox_authorization_name_db";
            this.textBox_authorization_name_db.Size = new System.Drawing.Size(230, 20);
            this.textBox_authorization_name_db.TabIndex = 18;
            // 
            // label_authorization_name_bd
            // 
            this.label_authorization_name_bd.AutoSize = true;
            this.label_authorization_name_bd.Location = new System.Drawing.Point(119, 227);
            this.label_authorization_name_bd.Name = "label_authorization_name_bd";
            this.label_authorization_name_bd.Size = new System.Drawing.Size(51, 13);
            this.label_authorization_name_bd.TabIndex = 17;
            this.label_authorization_name_bd.Text = "Имя БД:";
            // 
            // textBox_authorization_password
            // 
            this.textBox_authorization_password.Location = new System.Drawing.Point(122, 194);
            this.textBox_authorization_password.Name = "textBox_authorization_password";
            this.textBox_authorization_password.Size = new System.Drawing.Size(230, 20);
            this.textBox_authorization_password.TabIndex = 16;
            // 
            // label_authorization_password
            // 
            this.label_authorization_password.AutoSize = true;
            this.label_authorization_password.Location = new System.Drawing.Point(119, 168);
            this.label_authorization_password.Name = "label_authorization_password";
            this.label_authorization_password.Size = new System.Drawing.Size(48, 13);
            this.label_authorization_password.TabIndex = 15;
            this.label_authorization_password.Text = "Пароль:";
            // 
            // textBox_authorization_name_user
            // 
            this.textBox_authorization_name_user.Location = new System.Drawing.Point(122, 131);
            this.textBox_authorization_name_user.Name = "textBox_authorization_name_user";
            this.textBox_authorization_name_user.Size = new System.Drawing.Size(230, 20);
            this.textBox_authorization_name_user.TabIndex = 14;
            // 
            // label_authorization_name_user
            // 
            this.label_authorization_name_user.AutoSize = true;
            this.label_authorization_name_user.Location = new System.Drawing.Point(119, 105);
            this.label_authorization_name_user.Name = "label_authorization_name_user";
            this.label_authorization_name_user.Size = new System.Drawing.Size(106, 13);
            this.label_authorization_name_user.TabIndex = 13;
            this.label_authorization_name_user.Text = "Имя пользователя:";
            // 
            // textBox_authorization_name_server
            // 
            this.textBox_authorization_name_server.Location = new System.Drawing.Point(122, 71);
            this.textBox_authorization_name_server.Name = "textBox_authorization_name_server";
            this.textBox_authorization_name_server.Size = new System.Drawing.Size(230, 20);
            this.textBox_authorization_name_server.TabIndex = 12;
            // 
            // label_authorization_name_server
            // 
            this.label_authorization_name_server.AutoSize = true;
            this.label_authorization_name_server.Location = new System.Drawing.Point(119, 45);
            this.label_authorization_name_server.Name = "label_authorization_name_server";
            this.label_authorization_name_server.Size = new System.Drawing.Size(77, 13);
            this.label_authorization_name_server.TabIndex = 11;
            this.label_authorization_name_server.Text = "Имя сервера:";
            // 
            // richTextBox_log
            // 
            this.richTextBox_log.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_log.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_log.Location = new System.Drawing.Point(12, 103);
            this.richTextBox_log.MaximumSize = new System.Drawing.Size(460, 266);
            this.richTextBox_log.Name = "richTextBox_log";
            this.richTextBox_log.ReadOnly = true;
            this.richTextBox_log.Size = new System.Drawing.Size(447, 257);
            this.richTextBox_log.TabIndex = 18;
            this.richTextBox_log.Text = "";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_status.Location = new System.Drawing.Point(380, 33);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(82, 15);
            this.label_status.TabIndex = 17;
            this.label_status.Text = "Не работает";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Процесс принятия файла";
            // 
            // sendProgressBar
            // 
            this.sendProgressBar.Location = new System.Drawing.Point(12, 51);
            this.sendProgressBar.Name = "sendProgressBar";
            this.sendProgressBar.Size = new System.Drawing.Size(450, 33);
            this.sendProgressBar.TabIndex = 15;
            // 
            // panel_settings
            // 
            this.panel_settings.Controls.Add(this.label_info);
            this.panel_settings.Controls.Add(this.button_settings_cancel);
            this.panel_settings.Controls.Add(this.textBox_settings_name_server);
            this.panel_settings.Controls.Add(this.button_settings_save);
            this.panel_settings.Controls.Add(this.label_settings_head);
            this.panel_settings.Controls.Add(this.button_settings_open);
            this.panel_settings.Controls.Add(this.textBox_settings_path);
            this.panel_settings.Controls.Add(this.label_settings_path);
            this.panel_settings.Controls.Add(this.textBox_settings_name_db);
            this.panel_settings.Controls.Add(this.label_settings_name_db);
            this.panel_settings.Controls.Add(this.textBox_settings_password);
            this.panel_settings.Controls.Add(this.label_settings_password);
            this.panel_settings.Controls.Add(this.textBox_settings_name_user);
            this.panel_settings.Controls.Add(this.label_settings_name_user);
            this.panel_settings.Controls.Add(this.label_settings_name_server);
            this.panel_settings.Location = new System.Drawing.Point(299, 33);
            this.panel_settings.Name = "panel_settings";
            this.panel_settings.Size = new System.Drawing.Size(175, 222);
            this.panel_settings.TabIndex = 20;
            this.panel_settings.Visible = false;
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(18, 58);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(432, 13);
            this.label_info.TabIndex = 35;
            this.label_info.Text = "Для подключения к БД с новыми параметрами необходим перезапуск программы";
            // 
            // button_settings_cancel
            // 
            this.button_settings_cancel.Location = new System.Drawing.Point(247, 288);
            this.button_settings_cancel.Name = "button_settings_cancel";
            this.button_settings_cancel.Size = new System.Drawing.Size(118, 23);
            this.button_settings_cancel.TabIndex = 34;
            this.button_settings_cancel.Text = "Отмена";
            this.button_settings_cancel.UseVisualStyleBackColor = true;
            this.button_settings_cancel.Click += new System.EventHandler(this.button_settings_cancel_Click);
            // 
            // textBox_settings_name_server
            // 
            this.textBox_settings_name_server.Location = new System.Drawing.Point(183, 92);
            this.textBox_settings_name_server.Name = "textBox_settings_name_server";
            this.textBox_settings_name_server.Size = new System.Drawing.Size(230, 20);
            this.textBox_settings_name_server.TabIndex = 33;
            // 
            // button_settings_save
            // 
            this.button_settings_save.Location = new System.Drawing.Point(123, 288);
            this.button_settings_save.Name = "button_settings_save";
            this.button_settings_save.Size = new System.Drawing.Size(118, 23);
            this.button_settings_save.TabIndex = 32;
            this.button_settings_save.Text = "Сохранить";
            this.button_settings_save.UseVisualStyleBackColor = true;
            this.button_settings_save.Click += new System.EventHandler(this.button_settings_save_Click);
            // 
            // label_settings_head
            // 
            this.label_settings_head.AutoSize = true;
            this.label_settings_head.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_settings_head.Location = new System.Drawing.Point(204, 18);
            this.label_settings_head.Name = "label_settings_head";
            this.label_settings_head.Size = new System.Drawing.Size(91, 20);
            this.label_settings_head.TabIndex = 31;
            this.label_settings_head.Text = "Настройки";
            // 
            // button_settings_open
            // 
            this.button_settings_open.Location = new System.Drawing.Point(383, 249);
            this.button_settings_open.Name = "button_settings_open";
            this.button_settings_open.Size = new System.Drawing.Size(30, 20);
            this.button_settings_open.TabIndex = 30;
            this.button_settings_open.Text = "...";
            this.button_settings_open.UseVisualStyleBackColor = true;
            this.button_settings_open.Click += new System.EventHandler(this.button_settings_open_Click);
            // 
            // textBox_settings_path
            // 
            this.textBox_settings_path.Location = new System.Drawing.Point(72, 250);
            this.textBox_settings_path.Name = "textBox_settings_path";
            this.textBox_settings_path.Size = new System.Drawing.Size(305, 20);
            this.textBox_settings_path.TabIndex = 29;
            // 
            // label_settings_path
            // 
            this.label_settings_path.AutoSize = true;
            this.label_settings_path.Location = new System.Drawing.Point(70, 224);
            this.label_settings_path.Name = "label_settings_path";
            this.label_settings_path.Size = new System.Drawing.Size(162, 13);
            this.label_settings_path.TabIndex = 28;
            this.label_settings_path.Text = "Путь сохранения результатов:";
            // 
            // textBox_settings_name_db
            // 
            this.textBox_settings_name_db.Location = new System.Drawing.Point(183, 189);
            this.textBox_settings_name_db.Name = "textBox_settings_name_db";
            this.textBox_settings_name_db.Size = new System.Drawing.Size(230, 20);
            this.textBox_settings_name_db.TabIndex = 26;
            // 
            // label_settings_name_db
            // 
            this.label_settings_name_db.AutoSize = true;
            this.label_settings_name_db.Location = new System.Drawing.Point(70, 192);
            this.label_settings_name_db.Name = "label_settings_name_db";
            this.label_settings_name_db.Size = new System.Drawing.Size(51, 13);
            this.label_settings_name_db.TabIndex = 25;
            this.label_settings_name_db.Text = "Имя БД:";
            // 
            // textBox_settings_password
            // 
            this.textBox_settings_password.Location = new System.Drawing.Point(183, 157);
            this.textBox_settings_password.Name = "textBox_settings_password";
            this.textBox_settings_password.Size = new System.Drawing.Size(230, 20);
            this.textBox_settings_password.TabIndex = 24;
            // 
            // label_settings_password
            // 
            this.label_settings_password.AutoSize = true;
            this.label_settings_password.Location = new System.Drawing.Point(70, 160);
            this.label_settings_password.Name = "label_settings_password";
            this.label_settings_password.Size = new System.Drawing.Size(48, 13);
            this.label_settings_password.TabIndex = 23;
            this.label_settings_password.Text = "Пароль:";
            // 
            // textBox_settings_name_user
            // 
            this.textBox_settings_name_user.Location = new System.Drawing.Point(183, 125);
            this.textBox_settings_name_user.Name = "textBox_settings_name_user";
            this.textBox_settings_name_user.Size = new System.Drawing.Size(230, 20);
            this.textBox_settings_name_user.TabIndex = 22;
            // 
            // label_settings_name_user
            // 
            this.label_settings_name_user.AutoSize = true;
            this.label_settings_name_user.Location = new System.Drawing.Point(70, 128);
            this.label_settings_name_user.Name = "label_settings_name_user";
            this.label_settings_name_user.Size = new System.Drawing.Size(106, 13);
            this.label_settings_name_user.TabIndex = 21;
            this.label_settings_name_user.Text = "Имя пользователя:";
            // 
            // label_settings_name_server
            // 
            this.label_settings_name_server.AutoSize = true;
            this.label_settings_name_server.Location = new System.Drawing.Point(70, 95);
            this.label_settings_name_server.Name = "label_settings_name_server";
            this.label_settings_name_server.Size = new System.Drawing.Size(77, 13);
            this.label_settings_name_server.TabIndex = 19;
            this.label_settings_name_server.Text = "Имя сервера:";
            // 
            // receiveBackgroundWorker
            // 
            this.receiveBackgroundWorker.WorkerReportsProgress = true;
            this.receiveBackgroundWorker.WorkerSupportsCancellation = true;
            this.receiveBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.receiveBackgroundWorker_DoWork);
            this.receiveBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.receiveBackgroundWorker_RunWorkerCompleted);
            // 
            // sendBackgroundWorker
            // 
            this.sendBackgroundWorker.WorkerReportsProgress = true;
            this.sendBackgroundWorker.WorkerSupportsCancellation = true;
            this.sendBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.sendBackgroundWorker_DoWork);
            this.sendBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.sendBackgroundWorker_RunWorkerCompleted);
            // 
            // receiveBackgroundWorker2
            // 
            this.receiveBackgroundWorker2.WorkerReportsProgress = true;
            this.receiveBackgroundWorker2.WorkerSupportsCancellation = true;
            this.receiveBackgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.receiveBackgroundWorker2_DoWork);
            this.receiveBackgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.receiveBackgroundWorker2_RunWorkerCompleted);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 372);
            this.Controls.Add(this.panel_settings);
            this.Controls.Add(this.panel_connect_db);
            this.Controls.Add(this.richTextBox_log);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendProgressBar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Server for Medtest";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_connect_db.ResumeLayout(false);
            this.panel_connect_db.PerformLayout();
            this.panel_settings.ResumeLayout(false);
            this.panel_settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запуститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диаграммаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Panel panel_connect_db;
        private System.Windows.Forms.Button button_authorization_cancel;
        private System.Windows.Forms.Button button_authorization_connect;
        private System.Windows.Forms.Label label_authorization_head;
        private System.Windows.Forms.TextBox textBox_authorization_name_db;
        private System.Windows.Forms.Label label_authorization_name_bd;
        private System.Windows.Forms.TextBox textBox_authorization_password;
        private System.Windows.Forms.Label label_authorization_password;
        private System.Windows.Forms.TextBox textBox_authorization_name_user;
        private System.Windows.Forms.Label label_authorization_name_user;
        private System.Windows.Forms.TextBox textBox_authorization_name_server;
        private System.Windows.Forms.Label label_authorization_name_server;
        private System.Windows.Forms.RichTextBox richTextBox_log;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar sendProgressBar;
        private System.Windows.Forms.Panel panel_settings;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.Label label_settings_head;
        private System.Windows.Forms.Button button_settings_open;
        private System.Windows.Forms.TextBox textBox_settings_path;
        private System.Windows.Forms.Label label_settings_path;
        private System.Windows.Forms.TextBox textBox_settings_name_db;
        private System.Windows.Forms.Label label_settings_name_db;
        private System.Windows.Forms.TextBox textBox_settings_password;
        private System.Windows.Forms.Label label_settings_password;
        private System.Windows.Forms.TextBox textBox_settings_name_user;
        private System.Windows.Forms.Label label_settings_name_user;
        private System.Windows.Forms.Label label_settings_name_server;
        private System.ComponentModel.BackgroundWorker receiveBackgroundWorker;
        private System.Windows.Forms.Button button_settings_save;
        private System.Windows.Forms.TextBox textBox_settings_name_server;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_settings_cancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem узнатьIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьЛогToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label_info;
        private System.ComponentModel.BackgroundWorker sendBackgroundWorker;
        private System.ComponentModel.BackgroundWorker receiveBackgroundWorker2;
    }
}

