using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medtest
{
    public partial class Sections : Form
    {
        public Sections()
        {
            InitializeComponent();
        }

        private void Sections_Load(object sender, EventArgs e)
        {
            panel_sections.Location = new Point(Form.ActiveForm.Width/2 - panel_sections.Width/2,
                                                Form.ActiveForm.Height/2 - panel_sections.Height/2);

            string message = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList[0] + "\n2";

            Send send = new Send(Properties.Settings.Default.IP_server, message);
            Receive receive = new Receive();
            message = receive.Receives();
            enter = message.Split('\n');
            for (int i = 0; i < enter.Length - 1; i++)
            {
                string[] sections = enter[i].Split('|');
                comboBox_sections.Items.Add(sections[1]);
            }
        }

        /// <summary>
        /// Набор строк содержащий разделы тестирования со всеми параметрами
        /// </summary>
        private string[] enter;

        //Кнопка отмена
        private void button_cancel_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.People = "";
            Properties.Settings.Default.Save();
            //предыдущая форма делается видимой
            Main F = new Main();
            F.Visible = true;
            //текущая закрывается
            this.Close();
        }

        //Кнопка далее
        private void button_next_Click(object sender, EventArgs e)
        {
            if (comboBox_sections.Text != "")
            {
                string message = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList[0] + "\n3\n" +
                                 enter[comboBox_sections.SelectedIndex].Split('|')[0];
                Send send = new Send(Properties.Settings.Default.IP_server, message);
                Receive receive = new Receive();
                message = receive.Receives();
                Properties.Settings.Default.Sections = enter[comboBox_sections.SelectedIndex];
                Properties.Settings.Default.Sections_competence = message;
                Properties.Settings.Default.Save();
                Information F = new Information();
                F.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Раздел теста не выбран", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Горячие клавиши
        private void Sections_KeyDown(object sender, KeyEventArgs e)
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
