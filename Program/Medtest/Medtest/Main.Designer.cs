namespace Medtest
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
            this.panel_authorization = new System.Windows.Forms.Panel();
            this.panel_bottom_authorization = new System.Windows.Forms.Panel();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_last_name = new System.Windows.Forms.Label();
            this.textBox_last_name = new System.Windows.Forms.TextBox();
            this.label_first_name = new System.Windows.Forms.Label();
            this.textBox_first_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.panel_head_authorization = new System.Windows.Forms.Panel();
            this.label_head_authorization_panel = new System.Windows.Forms.Label();
            this.panel_head_main = new System.Windows.Forms.Panel();
            this.label_head_main = new System.Windows.Forms.Label();
            this.panel_bottom_main = new System.Windows.Forms.Panel();
            this.label_copyright = new System.Windows.Forms.Label();
            this.sendBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panel_settings = new System.Windows.Forms.Panel();
            this.button_settings_check = new System.Windows.Forms.Button();
            this.textBox_ip_server_settings = new System.Windows.Forms.TextBox();
            this.button_settings_save = new System.Windows.Forms.Button();
            this.label_ip_settings = new System.Windows.Forms.Label();
            this.panel_head_settings = new System.Windows.Forms.Panel();
            this.label_head_settings = new System.Windows.Forms.Label();
            this.panel_authorization.SuspendLayout();
            this.panel_bottom_authorization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_head_authorization.SuspendLayout();
            this.panel_head_main.SuspendLayout();
            this.panel_bottom_main.SuspendLayout();
            this.panel_settings.SuspendLayout();
            this.panel_head_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_authorization
            // 
            this.panel_authorization.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel_authorization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_authorization.Controls.Add(this.panel_bottom_authorization);
            this.panel_authorization.Controls.Add(this.panel_head_authorization);
            this.panel_authorization.Location = new System.Drawing.Point(382, 190);
            this.panel_authorization.Name = "panel_authorization";
            this.panel_authorization.Size = new System.Drawing.Size(498, 249);
            this.panel_authorization.TabIndex = 9;
            // 
            // panel_bottom_authorization
            // 
            this.panel_bottom_authorization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_bottom_authorization.Controls.Add(this.button_cancel);
            this.panel_bottom_authorization.Controls.Add(this.button_next);
            this.panel_bottom_authorization.Controls.Add(this.textBox_password);
            this.panel_bottom_authorization.Controls.Add(this.label_last_name);
            this.panel_bottom_authorization.Controls.Add(this.textBox_last_name);
            this.panel_bottom_authorization.Controls.Add(this.label_first_name);
            this.panel_bottom_authorization.Controls.Add(this.textBox_first_name);
            this.panel_bottom_authorization.Controls.Add(this.textBox_surname);
            this.panel_bottom_authorization.Controls.Add(this.pictureBox1);
            this.panel_bottom_authorization.Controls.Add(this.label_password);
            this.panel_bottom_authorization.Controls.Add(this.label_surname);
            this.panel_bottom_authorization.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom_authorization.Location = new System.Drawing.Point(0, 26);
            this.panel_bottom_authorization.Name = "panel_bottom_authorization";
            this.panel_bottom_authorization.Size = new System.Drawing.Size(496, 221);
            this.panel_bottom_authorization.TabIndex = 1;
            // 
            // button_cancel
            // 
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.Image = global::Medtest.Properties.Resources.button2;
            this.button_cancel.Location = new System.Drawing.Point(227, 172);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(117, 31);
            this.button_cancel.TabIndex = 10;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_next
            // 
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_next.Image = global::Medtest.Properties.Resources.button1;
            this.button_next.Location = new System.Drawing.Point(364, 172);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(117, 31);
            this.button_next.TabIndex = 9;
            this.button_next.Text = "Далее";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(300, 130);
            this.textBox_password.MaxLength = 4;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(181, 22);
            this.textBox_password.TabIndex = 8;
            // 
            // label_last_name
            // 
            this.label_last_name.AutoSize = true;
            this.label_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_last_name.Location = new System.Drawing.Point(210, 76);
            this.label_last_name.Name = "label_last_name";
            this.label_last_name.Size = new System.Drawing.Size(71, 16);
            this.label_last_name.TabIndex = 7;
            this.label_last_name.Text = "Отчество";
            // 
            // textBox_last_name
            // 
            this.textBox_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_last_name.Location = new System.Drawing.Point(300, 73);
            this.textBox_last_name.Name = "textBox_last_name";
            this.textBox_last_name.Size = new System.Drawing.Size(181, 22);
            this.textBox_last_name.TabIndex = 6;
            // 
            // label_first_name
            // 
            this.label_first_name.AutoSize = true;
            this.label_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_first_name.Location = new System.Drawing.Point(247, 46);
            this.label_first_name.Name = "label_first_name";
            this.label_first_name.Size = new System.Drawing.Size(34, 16);
            this.label_first_name.TabIndex = 5;
            this.label_first_name.Text = "Имя";
            // 
            // textBox_first_name
            // 
            this.textBox_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_first_name.Location = new System.Drawing.Point(300, 43);
            this.textBox_first_name.Name = "textBox_first_name";
            this.textBox_first_name.Size = new System.Drawing.Size(181, 22);
            this.textBox_first_name.TabIndex = 4;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_surname.Location = new System.Drawing.Point(300, 13);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(181, 22);
            this.textBox_surname.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Medtest.Properties.Resources.med1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 219);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_password.Location = new System.Drawing.Point(224, 133);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(57, 16);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Пароль";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_surname.Location = new System.Drawing.Point(214, 16);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(67, 16);
            this.label_surname.TabIndex = 0;
            this.label_surname.Text = "Фамилия";
            // 
            // panel_head_authorization
            // 
            this.panel_head_authorization.BackColor = System.Drawing.Color.Tan;
            this.panel_head_authorization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_head_authorization.Controls.Add(this.label_head_authorization_panel);
            this.panel_head_authorization.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head_authorization.Location = new System.Drawing.Point(0, 0);
            this.panel_head_authorization.Name = "panel_head_authorization";
            this.panel_head_authorization.Size = new System.Drawing.Size(496, 25);
            this.panel_head_authorization.TabIndex = 0;
            // 
            // label_head_authorization_panel
            // 
            this.label_head_authorization_panel.AutoSize = true;
            this.label_head_authorization_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_head_authorization_panel.Location = new System.Drawing.Point(2, 2);
            this.label_head_authorization_panel.Name = "label_head_authorization_panel";
            this.label_head_authorization_panel.Size = new System.Drawing.Size(200, 18);
            this.label_head_authorization_panel.TabIndex = 0;
            this.label_head_authorization_panel.Tag = "";
            this.label_head_authorization_panel.Text = "Контрольное тестирование";
            // 
            // panel_head_main
            // 
            this.panel_head_main.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_head_main.Controls.Add(this.label_head_main);
            this.panel_head_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head_main.Location = new System.Drawing.Point(0, 0);
            this.panel_head_main.Name = "panel_head_main";
            this.panel_head_main.Size = new System.Drawing.Size(1262, 25);
            this.panel_head_main.TabIndex = 10;
            // 
            // label_head_main
            // 
            this.label_head_main.AutoSize = true;
            this.label_head_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_head_main.ForeColor = System.Drawing.Color.White;
            this.label_head_main.Location = new System.Drawing.Point(3, 5);
            this.label_head_main.Name = "label_head_main";
            this.label_head_main.Size = new System.Drawing.Size(502, 18);
            this.label_head_main.TabIndex = 1;
            this.label_head_main.Text = "Тест на профессиальную компетентность медицинской сестры в ЛПУ";
            // 
            // panel_bottom_main
            // 
            this.panel_bottom_main.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_bottom_main.Controls.Add(this.label_copyright);
            this.panel_bottom_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom_main.Location = new System.Drawing.Point(0, 603);
            this.panel_bottom_main.Name = "panel_bottom_main";
            this.panel_bottom_main.Size = new System.Drawing.Size(1262, 25);
            this.panel_bottom_main.TabIndex = 11;
            // 
            // label_copyright
            // 
            this.label_copyright.AutoSize = true;
            this.label_copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_copyright.ForeColor = System.Drawing.Color.White;
            this.label_copyright.Location = new System.Drawing.Point(3, 2);
            this.label_copyright.Name = "label_copyright";
            this.label_copyright.Size = new System.Drawing.Size(580, 18);
            this.label_copyright.TabIndex = 0;
            this.label_copyright.Text = "© Verderian 2013          Все права защищены. Копирование материалов запрещено.";
            // 
            // sendBackgroundWorker
            // 
            this.sendBackgroundWorker.WorkerReportsProgress = true;
            this.sendBackgroundWorker.WorkerSupportsCancellation = true;
            this.sendBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.sendBackgroundWorker_DoWork);
            // 
            // panel_settings
            // 
            this.panel_settings.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel_settings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_settings.Controls.Add(this.button_settings_check);
            this.panel_settings.Controls.Add(this.textBox_ip_server_settings);
            this.panel_settings.Controls.Add(this.button_settings_save);
            this.panel_settings.Controls.Add(this.label_ip_settings);
            this.panel_settings.Controls.Add(this.panel_head_settings);
            this.panel_settings.Location = new System.Drawing.Point(482, 31);
            this.panel_settings.Name = "panel_settings";
            this.panel_settings.Size = new System.Drawing.Size(383, 142);
            this.panel_settings.TabIndex = 12;
            this.panel_settings.Visible = false;
            this.panel_settings.VisibleChanged += new System.EventHandler(this.panel_settings_VisibleChanged);
            // 
            // button_settings_check
            // 
            this.button_settings_check.Location = new System.Drawing.Point(133, 96);
            this.button_settings_check.Name = "button_settings_check";
            this.button_settings_check.Size = new System.Drawing.Size(115, 28);
            this.button_settings_check.TabIndex = 5;
            this.button_settings_check.Text = "Проверить";
            this.button_settings_check.UseVisualStyleBackColor = true;
            this.button_settings_check.Click += new System.EventHandler(this.button_settings_check_Click);
            // 
            // textBox_ip_server_settings
            // 
            this.textBox_ip_server_settings.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ip_server_settings.Location = new System.Drawing.Point(170, 53);
            this.textBox_ip_server_settings.Name = "textBox_ip_server_settings";
            this.textBox_ip_server_settings.Size = new System.Drawing.Size(199, 23);
            this.textBox_ip_server_settings.TabIndex = 3;
            // 
            // button_settings_save
            // 
            this.button_settings_save.Location = new System.Drawing.Point(254, 96);
            this.button_settings_save.Name = "button_settings_save";
            this.button_settings_save.Size = new System.Drawing.Size(115, 28);
            this.button_settings_save.TabIndex = 2;
            this.button_settings_save.Text = "Сохранить";
            this.button_settings_save.UseVisualStyleBackColor = true;
            this.button_settings_save.Click += new System.EventHandler(this.button_settings_save_Click);
            // 
            // label_ip_settings
            // 
            this.label_ip_settings.AutoSize = true;
            this.label_ip_settings.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ip_settings.Location = new System.Drawing.Point(13, 56);
            this.label_ip_settings.Name = "label_ip_settings";
            this.label_ip_settings.Size = new System.Drawing.Size(126, 15);
            this.label_ip_settings.TabIndex = 1;
            this.label_ip_settings.Text = "IP adress сервера";
            // 
            // panel_head_settings
            // 
            this.panel_head_settings.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_head_settings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_head_settings.Controls.Add(this.label_head_settings);
            this.panel_head_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head_settings.Location = new System.Drawing.Point(0, 0);
            this.panel_head_settings.Name = "panel_head_settings";
            this.panel_head_settings.Size = new System.Drawing.Size(381, 33);
            this.panel_head_settings.TabIndex = 0;
            // 
            // label_head_settings
            // 
            this.label_head_settings.AutoSize = true;
            this.label_head_settings.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_head_settings.Location = new System.Drawing.Point(3, 9);
            this.label_head_settings.Name = "label_head_settings";
            this.label_head_settings.Size = new System.Drawing.Size(70, 15);
            this.label_head_settings.TabIndex = 0;
            this.label_head_settings.Text = "Настройки";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1262, 628);
            this.Controls.Add(this.panel_settings);
            this.Controls.Add(this.panel_bottom_main);
            this.Controls.Add(this.panel_head_main);
            this.Controls.Add(this.panel_authorization);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Main";
            this.Text = "Тест на профессиальную компетентность медицинской сестры в ЛПУ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.VisibleChanged += new System.EventHandler(this.Main_VisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.panel_authorization.ResumeLayout(false);
            this.panel_bottom_authorization.ResumeLayout(false);
            this.panel_bottom_authorization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_head_authorization.ResumeLayout(false);
            this.panel_head_authorization.PerformLayout();
            this.panel_head_main.ResumeLayout(false);
            this.panel_head_main.PerformLayout();
            this.panel_bottom_main.ResumeLayout(false);
            this.panel_bottom_main.PerformLayout();
            this.panel_settings.ResumeLayout(false);
            this.panel_settings.PerformLayout();
            this.panel_head_settings.ResumeLayout(false);
            this.panel_head_settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_authorization;
        private System.Windows.Forms.Panel panel_bottom_authorization;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_last_name;
        private System.Windows.Forms.TextBox textBox_last_name;
        private System.Windows.Forms.Label label_first_name;
        private System.Windows.Forms.TextBox textBox_first_name;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Panel panel_head_authorization;
        private System.Windows.Forms.Label label_head_authorization_panel;
        private System.Windows.Forms.Panel panel_head_main;
        private System.Windows.Forms.Label label_head_main;
        private System.Windows.Forms.Panel panel_bottom_main;
        private System.Windows.Forms.Label label_copyright;
        private System.ComponentModel.BackgroundWorker sendBackgroundWorker;
        private System.Windows.Forms.Panel panel_settings;
        private System.Windows.Forms.Button button_settings_check;
        private System.Windows.Forms.TextBox textBox_ip_server_settings;
        private System.Windows.Forms.Button button_settings_save;
        private System.Windows.Forms.Label label_ip_settings;
        private System.Windows.Forms.Panel panel_head_settings;
        private System.Windows.Forms.Label label_head_settings;
    }
}

