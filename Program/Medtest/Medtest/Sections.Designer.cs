namespace Medtest
{
    partial class Sections
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
            this.panel_bottom_main = new System.Windows.Forms.Panel();
            this.label_copyright = new System.Windows.Forms.Label();
            this.panel_head_sections = new System.Windows.Forms.Panel();
            this.label_head_sections = new System.Windows.Forms.Label();
            this.panel_sections = new System.Windows.Forms.Panel();
            this.panel_bottom_sections_panel = new System.Windows.Forms.Panel();
            this.comboBox_sections = new System.Windows.Forms.ComboBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_head_sections_panel = new System.Windows.Forms.Panel();
            this.label_head_sections_panel = new System.Windows.Forms.Label();
            this.panel_bottom_main.SuspendLayout();
            this.panel_head_sections.SuspendLayout();
            this.panel_sections.SuspendLayout();
            this.panel_bottom_sections_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_head_sections_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom_main
            // 
            this.panel_bottom_main.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_bottom_main.Controls.Add(this.label_copyright);
            this.panel_bottom_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom_main.Location = new System.Drawing.Point(0, 603);
            this.panel_bottom_main.Name = "panel_bottom_main";
            this.panel_bottom_main.Size = new System.Drawing.Size(1262, 25);
            this.panel_bottom_main.TabIndex = 13;
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
            // panel_head_sections
            // 
            this.panel_head_sections.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_head_sections.Controls.Add(this.label_head_sections);
            this.panel_head_sections.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head_sections.Location = new System.Drawing.Point(0, 0);
            this.panel_head_sections.Name = "panel_head_sections";
            this.panel_head_sections.Size = new System.Drawing.Size(1262, 25);
            this.panel_head_sections.TabIndex = 12;
            // 
            // label_head_sections
            // 
            this.label_head_sections.AutoSize = true;
            this.label_head_sections.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_head_sections.ForeColor = System.Drawing.Color.White;
            this.label_head_sections.Location = new System.Drawing.Point(3, 5);
            this.label_head_sections.Name = "label_head_sections";
            this.label_head_sections.Size = new System.Drawing.Size(502, 18);
            this.label_head_sections.TabIndex = 1;
            this.label_head_sections.Text = "Тест на профессиальную компетентность медицинской сестры в ЛПУ";
            // 
            // panel_sections
            // 
            this.panel_sections.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel_sections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_sections.Controls.Add(this.panel_bottom_sections_panel);
            this.panel_sections.Controls.Add(this.panel_head_sections_panel);
            this.panel_sections.Location = new System.Drawing.Point(386, 248);
            this.panel_sections.Name = "panel_sections";
            this.panel_sections.Size = new System.Drawing.Size(491, 133);
            this.panel_sections.TabIndex = 14;
            // 
            // panel_bottom_sections_panel
            // 
            this.panel_bottom_sections_panel.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel_bottom_sections_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_bottom_sections_panel.Controls.Add(this.comboBox_sections);
            this.panel_bottom_sections_panel.Controls.Add(this.button_cancel);
            this.panel_bottom_sections_panel.Controls.Add(this.button_next);
            this.panel_bottom_sections_panel.Controls.Add(this.pictureBox1);
            this.panel_bottom_sections_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom_sections_panel.Location = new System.Drawing.Point(0, 26);
            this.panel_bottom_sections_panel.Name = "panel_bottom_sections_panel";
            this.panel_bottom_sections_panel.Size = new System.Drawing.Size(489, 105);
            this.panel_bottom_sections_panel.TabIndex = 1;
            // 
            // comboBox_sections
            // 
            this.comboBox_sections.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_sections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sections.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_sections.FormattingEnabled = true;
            this.comboBox_sections.Location = new System.Drawing.Point(13, 14);
            this.comboBox_sections.Name = "comboBox_sections";
            this.comboBox_sections.Size = new System.Drawing.Size(259, 23);
            this.comboBox_sections.TabIndex = 11;
            // 
            // button_cancel
            // 
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.Image = global::Medtest.Properties.Resources.button2;
            this.button_cancel.Location = new System.Drawing.Point(13, 57);
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
            this.button_next.Location = new System.Drawing.Point(155, 57);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(117, 31);
            this.button_next.TabIndex = 9;
            this.button_next.Text = "Далее";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Medtest.Properties.Resources.med2;
            this.pictureBox1.Location = new System.Drawing.Point(281, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 103);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel_head_sections_panel
            // 
            this.panel_head_sections_panel.BackColor = System.Drawing.Color.Tan;
            this.panel_head_sections_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_head_sections_panel.Controls.Add(this.label_head_sections_panel);
            this.panel_head_sections_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head_sections_panel.Location = new System.Drawing.Point(0, 0);
            this.panel_head_sections_panel.Name = "panel_head_sections_panel";
            this.panel_head_sections_panel.Size = new System.Drawing.Size(489, 25);
            this.panel_head_sections_panel.TabIndex = 0;
            // 
            // label_head_sections_panel
            // 
            this.label_head_sections_panel.AutoSize = true;
            this.label_head_sections_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_head_sections_panel.Location = new System.Drawing.Point(2, 2);
            this.label_head_sections_panel.Name = "label_head_sections_panel";
            this.label_head_sections_panel.Size = new System.Drawing.Size(173, 18);
            this.label_head_sections_panel.TabIndex = 0;
            this.label_head_sections_panel.Tag = "";
            this.label_head_sections_panel.Text = "Выберете раздел теста";
            // 
            // Sections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1262, 628);
            this.Controls.Add(this.panel_sections);
            this.Controls.Add(this.panel_bottom_main);
            this.Controls.Add(this.panel_head_sections);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Sections";
            this.Text = "Тест на профессиальную компетентность медицинской сестры в ЛПУ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sections_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sections_KeyDown);
            this.panel_bottom_main.ResumeLayout(false);
            this.panel_bottom_main.PerformLayout();
            this.panel_head_sections.ResumeLayout(false);
            this.panel_head_sections.PerformLayout();
            this.panel_sections.ResumeLayout(false);
            this.panel_bottom_sections_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_head_sections_panel.ResumeLayout(false);
            this.panel_head_sections_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_bottom_main;
        private System.Windows.Forms.Label label_copyright;
        private System.Windows.Forms.Panel panel_head_sections;
        private System.Windows.Forms.Label label_head_sections;
        private System.Windows.Forms.Panel panel_sections;
        private System.Windows.Forms.Panel panel_bottom_sections_panel;
        private System.Windows.Forms.ComboBox comboBox_sections;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_head_sections_panel;
        private System.Windows.Forms.Label label_head_sections_panel;
    }
}