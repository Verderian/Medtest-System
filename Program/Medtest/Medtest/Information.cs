using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medtest
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        //Кнопка отмена в информации
        private void button_information_cancel_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Sections = "";
            Properties.Settings.Default.Sections_competence = "";
            Properties.Settings.Default.Save();
            //предыдущая форма делается видимой
            Sections F = new Sections();
            F.Show();
            //текущая закрывается
            this.Close();
        }

        /// <summary>
        /// Сообщение отправки серверу
        /// </summary>
        private string message;

        //Кнопка отмена в структуре
        private void button_structure_cancel_Click(object sender, EventArgs e)
        {
            panel_information.Visible = true;
            panel_structure.Visible = false;
            panel_structure.Dock = DockStyle.None;
        }
        
        private void Information_Load(object sender, EventArgs e)
        {
            panel_information.Location = new Point(Form.ActiveForm.Width / 2 - panel_information.Width / 2,
                                                Form.ActiveForm.Height / 2 - panel_information.Height / 2);
            string[] enter = Properties.Settings.Default.People.Split('|');
            message = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList[0] + "\n4\n" + enter[0] + "\n";
            label_surname.Text = enter[1];
            label_first_name.Text = enter[2];
            label_last_name.Text = enter[3];
            label_data.Text = enter[4].Remove(10);
            label_category.Text = enter[5];
            label_section_people.Text = enter[6];
            enter = Properties.Settings.Default.Sections.Split('|');
            message += enter[0];
            label_time.Text = enter[2] + " минут";
            label_name_section_structure.Text = "Название раздела: " + enter[1];
            richTextBox_competence_1.Text = enter[3];
            richTextBox_competence_2.Text = enter[5];
            richTextBox_competence_3.Text = enter[7];
            richTextBox_competence_4.Text = enter[9];
            richTextBox_competence_5.Text = enter[11];
            richTextBox_competence_6.Text = enter[13];
            richTextBox_competence_7.Text = enter[15];
            richTextBox_competence_8.Text = enter[17];
            richTextBox_competence_9.Text = enter[19];
            richTextBox_competence_10.Text = enter[21];
            richTextBox_question_1.Text = enter[4];
            richTextBox_question_2.Text = enter[6];
            richTextBox_question_3.Text = enter[8];
            richTextBox_question_4.Text = enter[10];
            richTextBox_question_5.Text = enter[12];
            richTextBox_question_6.Text = enter[14];
            richTextBox_question_7.Text = enter[16];
            richTextBox_question_8.Text = enter[18];
            richTextBox_question_9.Text = enter[20];
            richTextBox_question_10.Text = enter[22];
        }

        //Кнопка помощь
        private void button_help_information_Click(object sender, EventArgs e)
        {
            Help F = new Help();
            F.Show();
        }

        //Кнопка структуры
        private void button_structure_information_Click(object sender, EventArgs e)
        {
            panel_information.Visible = false;
            panel_structure.Visible = true;
            panel_structure.Dock = DockStyle.Fill;
        }

        //Кнопка начала
        private void button_begin_information_Click(object sender, EventArgs e)
        {
            Send send = new Send(Properties.Settings.Default.IP_server, message);
            Receive receive = new Receive();
            string message_new = receive.Receives();
            Properties.Settings.Default.Question = message_new;
            Properties.Settings.Default.Save();
            if (message_new != "Нет")
            {
                Test F = new Test();
                F.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы исчерпали все возможные попытки для данного теста!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Горячие клавиши
        private void Information_KeyDown(object sender, KeyEventArgs e)
        {
            //клавиша, показывавающая информацию о продукте
            if (e.KeyCode == Keys.F1)
            {
                AboutBox1 F = new AboutBox1();
                F.Show();
            }
        }
    }
}
