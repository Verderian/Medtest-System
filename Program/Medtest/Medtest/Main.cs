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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region Initialize_const
        private struct SendArgument
        {
            /// <summary>
            /// IP адрес сервера
            /// </summary>
            public string Hostname;

            /// <summary>
            /// Сообщение для передачи
            /// </summary>
            public string Message;
        }
        #endregion Initialize_const

        private void Main_Load(object sender, EventArgs e)
        {
            panel_authorization.Location = new Point(ActiveForm.Width/2 - panel_authorization.Width/2,
                                                     ActiveForm.Height/2 - panel_authorization.Height/2);

            string message = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList[0] + "\n0";
            sendBackgroundWorker.RunWorkerAsync(
                new SendArgument()
                    {
                        Hostname = Properties.Settings.Default.IP_server,
                        Message = message
                    });
        }

        private void sendBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                SendArgument argumen = (SendArgument) e.Argument;
                TcpClient client = new TcpClient(argumen.Hostname, 20000);

                using (NetworkStream outputStream = client.GetStream())
                using (BinaryWriter writer = new BinaryWriter(outputStream))
                {
                    writer.Write(argumen.Message);
                }
                client.Close();

                Receive receive = new Receive();
                if (receive.Receives() == "Server" & panel_settings.Visible)
                {
                    MessageBox.Show("Сервер работает", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                DialogResult result =
                    MessageBox.Show("Внимание! Ошибка при подключении к серверу. Вы хотите изменить IP сервера?",
                                    "Обновление", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    panel_settings.Invoke((MethodInvoker) delegate
                        {
                            panel_settings.Visible = true;
                        });
                    panel_settings.Invoke((MethodInvoker) delegate
                        {
                            panel_authorization.Visible = false;
                        });
                }
                else
                {
                    Application.Exit();
                }
            }
        }
        
        //Кнопка отмена
        private void button_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Очищаем поля для следующего клиента
        private void Main_VisibleChanged(object sender, EventArgs e)
        {
            textBox_surname.Clear();
            textBox_last_name.Clear();
            textBox_first_name.Clear();
            textBox_password.Clear();
        }

        //Горячие клавиши
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            //клавиша, показывавающая информацию о продукте
            if (e.KeyCode == Keys.F1)
            {
                AboutBox1 F = new AboutBox1();
                F.Show();
            }
            //клавиша, открытия настроек
            if (e.Shift && e.Alt && e.KeyCode == Keys.Enter)
            {
                panel_settings.Visible = true;
                panel_settings.Location = new Point(ActiveForm.Width/2 - panel_settings.Width/2,
                                                    ActiveForm.Height/2 - panel_settings.Height/2);
                panel_authorization.Visible = false;
            }
        }

        //Отображение настроек
        private void panel_settings_VisibleChanged(object sender, EventArgs e)
        {
            textBox_ip_server_settings.Text = Properties.Settings.Default.IP_server;
            panel_settings.Location = new Point(ActiveForm.Width/2 - panel_settings.Width/2,
                                                ActiveForm.Height/2 - panel_settings.Height/2);
            label_head_settings.Text = "Настройки - " +
                                       System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList[0];
        }

        //Сохранение настроек
        private void button_settings_save_Click(object sender, EventArgs e)
        {
            panel_settings.Visible = false;
            panel_authorization.Visible = true;
            Properties.Settings.Default.IP_server = textBox_ip_server_settings.Text;
            Properties.Settings.Default.Save();
        }

        //Проверка нового адреса
        private void button_settings_check_Click(object sender, EventArgs e)
        {
            string message = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList[0] + "\n0";
            sendBackgroundWorker.RunWorkerAsync(
                new SendArgument()
                    {
                        Hostname = textBox_ip_server_settings.Text,
                        Message = message
                    });
        }

        //кнопка далее
        private void button_next_Click(object sender, EventArgs e)
        {
            string message = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList[0] + "\n1\n" +
                             textBox_surname.Text + "\n" + textBox_first_name.Text + "\n" + textBox_last_name.Text +
                             "\n" + textBox_password.Text;
            Send send = new Send(Properties.Settings.Default.IP_server, message);
            Receive receive = new Receive();
            message = receive.Receives();
            if (message != "Нет")
            {
                ActiveForm.Visible = false;
                Sections F = new Sections();
                Properties.Settings.Default.People = message;
                Properties.Settings.Default.Save();
                F.Show();
            }
            else
            {
                MessageBox.Show("Данный участник не зарегистрирован в базе данных", "Ошибка", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
