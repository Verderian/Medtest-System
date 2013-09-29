using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_for_Medtest
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //Локальные переменные
        #region Initialize_const
        /// <summary>
        /// Тип сообщения который передает клиент:
        /// 0 - Проверка что сервер работет,
        /// 1 - Авторизация пользователя,
        /// 2 - Запрос списка тестов,
        /// 3 - Запрос выбранного теста,
        /// 4 - Запрос вопросов по выбранному тесту,
        /// 5 - Передача результатов.
        /// </summary>
        private int message_type;

        /// <summary>
        /// Показывает какой receiveBackgroundWorker сейчас работает
        /// </summary>
        private int background_number = 0;
        /// <summary>
        /// Строка соединения с БД
        /// </summary>
        private string connectionString;

        struct SendArgument
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

        //Загрузка формы
        private void Main_Load(object sender, EventArgs e)
        {
            richTextBox_log.Text += "Запуск программы в " + Convert.ToString(DateTime.Now);
            //Получаем IP-адрес сервера и добавляем его в заголовок формы
            this.Text += " - " + System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList[0].ToString();
            //Выводим панель для соединения с БД
            panel_connect_db.Dock = DockStyle.Fill;
            textBox_authorization_name_server.Text = Properties.Settings.Default.Server_name;
            textBox_authorization_name_user.Text = Properties.Settings.Default.User_name;
            textBox_authorization_password.Text = Properties.Settings.Default.Password;
            textBox_authorization_name_db.Text = Properties.Settings.Default.Name_db;
        }

        //Авторизация в БД
        #region Authorization
        //Кнопка соединения с БД
        private void button_authorization_connect_Click(object sender, EventArgs e)
        {
            //проверка что заполнены все необходимые поля
            if (textBox_authorization_name_db.Text != "" & textBox_authorization_name_server.Text != "" &
                textBox_authorization_name_user.Text != "" & textBox_authorization_password.Text != "")
            {
                connectionString = @"Data Source=" + textBox_authorization_name_server.Text + "; user=" +
                                   textBox_authorization_name_user.Text + "; Password=" +
                                   textBox_authorization_password.Text + "; Initial Catalog=" +
                                   textBox_authorization_name_db.Text + ";";
                //проверяем что соединение с выбранной базой данных доступно
                try
                {
                    SqlConnection sqlConnection;
                    sqlConnection = new SqlConnection(connectionString);
                    sqlConnection.Open();
                    sqlConnection.Close();
                    panel_connect_db.Visible = false;
                    menuStrip1.Enabled = true;
                    richTextBox_log.Text += "\nСоединение с базой прошло проверку в " + Convert.ToString(DateTime.Now);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка соединения с сервером", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполнены не все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Кнопка отмены при соединении с БД
        private void button_authorization_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion Authorization

        #region Menu
        //Запуск сервера
        private void запуститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            запуститьToolStripMenuItem.Enabled = false;
            receiveBackgroundWorker.RunWorkerAsync();
        }

        //Выход из приложения
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Очистка лога
        private void очиститьЛогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_log.Clear();
        }

        //Открыть настроки
        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label_status.Text != "Работает")
            {
                panel_settings.Dock = DockStyle.Fill;
                panel_settings.Visible = true;
                textBox_settings_name_server.Text = Properties.Settings.Default.Server_name;
                textBox_settings_name_user.Text = Properties.Settings.Default.User_name;
                textBox_settings_password.Text = Properties.Settings.Default.Password;
                textBox_settings_name_db.Text = Properties.Settings.Default.Name_db;
                textBox_settings_path.Text = Properties.Settings.Default.Path;
            }
            else
            {
                MessageBox.Show("Для получения доступа к настройкам нужно остановить сервер", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Получаем IP-адрес сервера
        private void узнатьIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList[0].ToString());
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox F = new AboutBox();
            F.Show();
        }
        #endregion Menu

        //Горячие клавиши
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            //клавиша, показывавающая информацию о продукте
            if (e.KeyCode == Keys.F1)
            {
                AboutBox F = new AboutBox();
                F.Show();
            }
        }

        //Настройки
        #region Settings
        //кнопка сохранения изменений
        private void button_settings_save_Click(object sender, EventArgs e)
        {
            panel_settings.Visible = false;
            Properties.Settings.Default.Server_name = textBox_settings_name_server.Text;
            Properties.Settings.Default.User_name = textBox_settings_name_user.Text;
            Properties.Settings.Default.Password = textBox_settings_password.Text;
            Properties.Settings.Default.Name_db = textBox_settings_name_db.Text;
            Properties.Settings.Default.Path = textBox_settings_path.Text;
            Properties.Settings.Default.Save();
        }

        //Кнопка отображения пути к выбранной папке
        private void button_settings_open_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_settings_path.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        //Кнопка отмены сохранения изменений
        private void button_settings_cancel_Click(object sender, EventArgs e)
        {
            panel_settings.Visible = false;
        }
        #endregion Settings

        private void receiveBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            label_status.Invoke((MethodInvoker) delegate
                {
                    label_status.Text = "Работает";
                });
            richTextBox_log.Invoke((MethodInvoker)delegate
                {
                    richTextBox_log.Text += "\n\nСервер запущен\nЗапуск прослушивания в " +
                                            Convert.ToString(DateTime.Now);
                });
            background_number = 1;

            TcpListener listener = new TcpListener(IPAddress.Any, 20000);
            listener.Start(30);

            while (!listener.Pending())
            {
                TcpClient client = listener.AcceptTcpClient();

                using (NetworkStream inputStream = client.GetStream())
                using (BinaryReader reader = new BinaryReader(inputStream))
                {
                    string[] enter = reader.ReadString().Split('\n');
                    //IP-адрес
                    string hostname = enter[0];
                    message_type = Convert.ToInt32(enter[1]);
                    richTextBox_log.Invoke((MethodInvoker) delegate
                        {
                            richTextBox_log.Text += "\nПрием сообщения \"" + enter[1] + "\"от " + hostname + " в " +
                                                    Convert.ToString(DateTime.Now);
                        });
                    if (message_type == 0)
                    {
                        sendBackgroundWorker.RunWorkerAsync(
                            new SendArgument()
                                {
                                    Hostname = hostname,
                                    Message = "Server"
                                });
                    }
                    if (message_type == 1)
                    {
                        DataTable datatable = new DataTable();
                        datatable =
                            DataRead(
                                "select Participants.ID, Participants.Фамилия, Participants.Имя, Participants.Отчество, Participants.[Дата рождения], DictCateg.[Категория], Passwords.[Название отделения], Participants.[Пароль]  from Participants inner join DictCateg on Participants.[Категория]=DictCateg.[id] inner join Passwords on Participants.[Отделение]=Passwords.[id] Where Participants.Фамилия = '" +
                                enter[2] + "' AND Participants.[Имя]='" + enter[3] +
                                "' AND Participants.[Отчество]='" +
                                enter[4] + "' AND Participants.[Пароль]='" + enter[5] + "'");
                        string message = "";
                        if (datatable.Rows.Count != 0)
                        {
                            for (int i = 0; i < datatable.Columns.Count; i++)
                            {
                                message += datatable.Rows[0][i].ToString() + "|";
                            }
                        }
                        else
                        {
                            message += "Нет";
                        }
                        sendBackgroundWorker.RunWorkerAsync(
                            new SendArgument()
                                {
                                    Hostname = hostname,
                                    Message = message
                                });
                    }
                    if (message_type == 2)
                    {
                        DataTable datatable = new DataTable();
                        datatable =
                            DataRead(
                                "SELECT Sections.ID, Sections.Название, Sections.Время, C1.Компетенция, Sections.[Вопросов 1], C2.Компетенция, Sections.[Вопросов 2], C3.Компетенция, Sections.[Вопросов 3], C4.Компетенция, Sections.[Вопросов 4], C5.Компетенция, Sections.[Вопросов 5], C6.Компетенция, Sections.[Вопросов 6], C7.Компетенция, Sections.[Вопросов 7], C8.Компетенция, Sections.[Вопросов 8], C9.Компетенция, Sections.[Вопросов 9], C10.Компетенция, Sections.[Вопросов 10] FROM Sections inner join Сompetence AS C1 on Sections.[Компетенция 1]=C1.ID inner join Сompetence AS C2 on Sections.[Компетенция 2]=C2.ID inner join Сompetence AS C3 on Sections.[Компетенция 3]=C3.ID inner join Сompetence AS C4 on Sections.[Компетенция 4]=C4.ID inner join Сompetence AS C5 on Sections.[Компетенция 5]=C5.ID inner join Сompetence AS C6 on Sections.[Компетенция 6]=C6.ID inner join Сompetence AS C7 on Sections.[Компетенция 7]=C7.ID inner join Сompetence AS C8 on Sections.[Компетенция 8]=C8.ID inner join Сompetence AS C9 on Sections.[Компетенция 9]=C9.ID inner join Сompetence AS C10 on Sections.[Компетенция 10]=C10.ID WHERE Sections.[Запустить тестирование]='True'");
                        string message = "";
                        for (int i = 0; i < datatable.Rows.Count; i++)
                        {
                            for (int j = 0; j < datatable.Columns.Count; j++)
                            {
                                message += datatable.Rows[i][j].ToString() + "|";
                            }
                            message += "\n";
                        }
                        sendBackgroundWorker.RunWorkerAsync(
                            new SendArgument()
                                {
                                    Hostname = hostname,
                                    Message = message
                                });
                    }
                    if (message_type == 3)
                    {
                        DataTable datatable = new DataTable();
                        datatable =
                            DataRead(
                                "SELECT * FROM Sections WHERE Sections.ID=" + Convert.ToInt32(enter[2]));
                        string message = "";

                        for (int j = 0; j < datatable.Columns.Count; j++)
                        {
                            message += datatable.Rows[0][j].ToString() + "|";
                        }
                        sendBackgroundWorker.RunWorkerAsync(
                            new SendArgument()
                            {
                                Hostname = hostname,
                                Message = message
                            });
                    }
                    if (message_type == 4)
                    {
                        DataTable datatable = new DataTable();
                        datatable =
                            DataRead(
                                "Select Attempts.[Количество попыток] From Attempts WHERE Attempts.[Название раздела]=" +
                                enter[3] + " AND Attempts.[Фамилия участника]=" + enter[2]);
                        DataTable datatable_2 = new DataTable();
                        datatable_2 =
                            DataRead("Select Sections.[Количество попыток] From Sections WHERE Sections.ID=" +
                                     enter[3]);
                        string message = "";
                        bool message_status = false;
                        if (datatable.Rows.Count == 0)
                        {
                            message_status = true;
                            DataTable datatable_3 = new DataTable();
                            datatable_3 =
                                DataRead("Insert INTO [dbo].[Attempts] Values (" + enter[2] + ", " + enter[3] +
                                         ", 1)");
                        }
                        else
                        {
                            if (Convert.ToInt32(datatable_2.Rows[0][0]) - Convert.ToInt32(datatable.Rows[0][0]) > 0)
                            {
                                message_status = true;
                                DataTable datatable_3 = new DataTable();
                                datatable_3 =
                                    DataRead(
                                        "Update Attempts set [Количество попыток] = [Количество попыток]+1 where [Фамилия участника]=" +
                                        enter[2] + " AND [Название раздела]=" + enter[3]);
                            }
                        }
                        if (message_status)
                        {
                            message += "Да";
                            DataTable datatable_3 = new DataTable();
                            datatable_3 =
                                DataRead(
                                    "Select Sections.[Компетенция 1], Sections.[Вопросов 1], Sections.[Компетенция 2], Sections.[Вопросов 2], Sections.[Компетенция 3], Sections.[Вопросов 3], Sections.[Компетенция 4], Sections.[Вопросов 4], Sections.[Компетенция 5], Sections.[Вопросов 5], Sections.[Компетенция 6], Sections.[Вопросов 6], Sections.[Компетенция 7], Sections.[Вопросов 7], Sections.[Компетенция 8], Sections.[Вопросов 8], Sections.[Компетенция 9], Sections.[Вопросов 9], Sections.[Компетенция 10], Sections.[Вопросов 10] From Sections WHERE Sections.ID=" +
                                    enter[3]);
                            for (int i = 0; i < 10; i++)
                            {
                                DataTable dataTable_4 = new DataTable();
                                dataTable_4 =
                                    DataRead("Select * From Questions WHERE Questions.Компетенция=" +
                                             Convert.ToInt32(datatable_3.Rows[0][2*i]));
                                //если количество вопросов заполнено
                                if (datatable_3.Rows[0][2*i + 1].ToString() != "")
                                {
                                    Random r = new Random();
                                    int max = Convert.ToInt32(datatable_3.Rows[0][2*i + 1]);
                                    int[] x = new int[max];
                                    for (int j = 0; j < max; j++)
                                    {
                                        message += "\n";
                                        bool contains = true;
                                        int next = 0;
                                        while (contains)
                                        {
                                            next = r.Next(dataTable_4.Rows.Count);
                                            contains = false;
                                            for (int index = 0; index < j; index++)
                                            {
                                                if (x[index] == next)
                                                {
                                                    contains = true;
                                                    break;
                                                }
                                            }
                                        }
                                        x[j] = next;
                                        for (int index = 0; index < dataTable_4.Columns.Count; index++)
                                        {
                                            message += dataTable_4.Rows[next][index];
                                            message += "|";
                                        }
                                    }
                                }
                            }

                        }
                        else
                        {
                            message += "Нет";
                        }
                        sendBackgroundWorker.RunWorkerAsync(
                            new SendArgument()
                                {
                                    Hostname = hostname,
                                    Message = message
                                });
                    }
                    if (message_type == 5)
                    {
                        string[] result = enter[22].Split(',');
                        DataTable dataTable = new DataTable();
                        dataTable =
                            DataRead("Select Results.Итог From Results WHERE Results.[Фамилия участника]=" +
                                     result[0] +
                                     " AND Results.[Название раздела]=" + result[1]);
                        if (dataTable.Rows.Count != 0)
                        {
                            if (Convert.ToInt32(result[2]) > Convert.ToInt32(dataTable.Rows[0][0]))
                            {
                                DataTable dataTable_2 = new DataTable();
                                dataTable_2 =
                                    DataRead("Update Results set Итог=" + result[2] + ", [Процент 1]=" + result[3] +
                                             ", [Процент 2]=" + result[4] + ", [Процент 3]=" + result[5] +
                                             ", [Процент 4]=" + result[6] + ", [Процент 5]=" + result[7] +
                                             ", [Процент 6]=" + result[8] + ", [Процент 7]=" + result[9] +
                                             ", [Процент 8]=" + result[10] + ", [Процент 9]=" + result[11] +
                                             ", [Процент 10]=" + result[12] + " Where [Фамилия участника]=" +
                                             result[0] +
                                             " AND [Название раздела]=" + result[1]);
                                DataTable dataTable_3 = new DataTable();
                                dataTable_3 = DataRead("delete From Answers WHERE [Название раздела]=" + result[1] +
                                                       " AND [Фамилия участника]=" + result[0]);
                                for (int i = 0; i < 20; i++)
                                {
                                    DataTable dataTable_4 = new DataTable();
                                    dataTable_4 =
                                        DataRead("Insert INTO [dbo].[Answers] Values (" + enter[2 + i] + ")");
                                }
                            }
                        }
                        else
                        {
                            DataTable dataTable_2 = new DataTable();
                            dataTable_2 = DataRead("Insert INTO [dbo].[Results] Values (" + enter[22] + ")");
                            for (int i = 0; i < 20; i++)
                            {
                                DataTable dataTable_3 = new DataTable();
                                dataTable_3 = DataRead("Insert INTO [dbo].[Answers] Values (" + enter[2 + i] + ")");
                            }
                        }
                    }
                }
                client.Close();
            }
            listener.Stop();
        }

        private void receiveBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                richTextBox_log.Invoke((MethodInvoker) delegate
                    {
                        richTextBox_log.Text += "\nСервер умер:" + e.Error.Message;
                    });
                label_status.Invoke((MethodInvoker) delegate
                    {
                        label_status.Text = "Не работает";
                    });
                receiveBackgroundWorker2.RunWorkerAsync();
            }
        }

        /// <summary>
        /// Возвращает таблицу из базы данных
        /// </summary>
        /// <param name="command">Строка содержащая команду запроса к БД</param>
        /// <returns></returns>
        public DataTable DataRead(string command)
        {
            //инициализация новых экземпляров класса
            DataTable datatable = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //открытие подключения к базе
            sqlConnection.Open();
            try
            {
                //создание команды
                SqlCommand commandPerformance = sqlConnection.CreateCommand();
                //запись запроса в команду
                commandPerformance.CommandText = command;
                //инициализация нового экземпляра класса адаптера с командой
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(commandPerformance);
                //загрузка данных из адаптера в таблицу
                sqlDataAdapter.Fill(datatable);
            }
            finally
            {
                //закрытие подключения к базе
                sqlConnection.Close();
            }
            return datatable;
        }

        //передача сообщения
        #region sendBackgroundWorker
        private void sendBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            SendArgument argumen = (SendArgument)e.Argument;
            TcpClient client = new TcpClient(argumen.Hostname, 10000);

            using (NetworkStream outputStream = client.GetStream())
            using (BinaryWriter writer = new BinaryWriter(outputStream))
            {
                writer.Write(argumen.Message);
            }
            client.Close();
        }

        private void sendBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                richTextBox_log.Invoke((MethodInvoker) delegate
                    {
                        richTextBox_log.Text += "\nОшибка при передаче " + Convert.ToString(DateTime.Now) +
                                                e.Error.Message;
                    });
                if (background_number == 1)
                {
                    receiveBackgroundWorker2.RunWorkerAsync();
                }
                else
                {
                    receiveBackgroundWorker.RunWorkerAsync();
                }
            }
            else
            {
                message_type = 6;
                richTextBox_log.Invoke((MethodInvoker) delegate
                    {
                        richTextBox_log.Text += "\nСообщение отправленно " + Convert.ToString(DateTime.Now);
                    });
            }
        }
        #endregion

        private void receiveBackgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            //label_status.Text = "Работает";
            //richTextBox_log.Text += "\nСервер ожил" + "\nЗапуск прослушивания в " + Convert.ToString(DateTime.Now);
            background_number = 2;

            TcpListener listener = new TcpListener(IPAddress.Any, 20000);
            listener.Start(30);

            while (!listener.Pending())
            {
                TcpClient client = listener.AcceptTcpClient();

                using (NetworkStream inputStream = client.GetStream())
                using (BinaryReader reader = new BinaryReader(inputStream))
                {
                    string[] enter = reader.ReadString().Split('\n');
                    //IP-адрес
                    string hostname = enter[0];
                    message_type = Convert.ToInt32(enter[1]);
                    //richTextBox_log.Text += "\nПрием сообщения \"" + enter[1] + "\"от " + hostname + " в " + Convert.ToString(DateTime.Now);
                    if (message_type == 0)
                    {
                        sendBackgroundWorker.RunWorkerAsync(
                            new SendArgument()
                            {
                                Hostname = hostname,
                                Message = "Server"
                            });
                    }
                    if (message_type == 1)
                    {
                        DataTable datatable = new DataTable();
                        datatable =
                            DataRead(
                                "select Participants.ID, Participants.Фамилия, Participants.Имя, Participants.Отчество, Participants.[Дата рождения], DictCateg.[Категория], Passwords.[Название отделения], Participants.[Пароль]  from Participants inner join DictCateg on Participants.[Категория]=DictCateg.[id] inner join Passwords on Participants.[Отделение]=Passwords.[id] Where Participants.Фамилия = '" +
                                enter[2] + "' AND Participants.[Имя]='" + enter[3] + "' AND Participants.[Отчество]='" +
                                enter[4] + "' AND Participants.[Пароль]='" + enter[5] + "'");
                        string message = "";
                        if (datatable.Rows.Count != 0)
                        {
                            for (int i = 0; i < datatable.Columns.Count; i++)
                            {
                                message += datatable.Rows[0][i].ToString() + "|";
                            }
                        }
                        else
                        {
                            message += "Нет";
                        }
                        sendBackgroundWorker.RunWorkerAsync(
                            new SendArgument()
                            {
                                Hostname = hostname,
                                Message = message
                            });
                    }
                    if (message_type == 2)
                    {
                        DataTable datatable = new DataTable();
                        datatable =
                            DataRead(
                                "SELECT Sections.ID, Sections.Название, Sections.Время, C1.Компетенция, Sections.[Вопросов 1], C2.Компетенция, Sections.[Вопросов 2], C3.Компетенция, Sections.[Вопросов 3], C4.Компетенция, Sections.[Вопросов 4], C5.Компетенция, Sections.[Вопросов 5], C6.Компетенция, Sections.[Вопросов 6], C7.Компетенция, Sections.[Вопросов 7], C8.Компетенция, Sections.[Вопросов 8], C9.Компетенция, Sections.[Вопросов 9], C10.Компетенция, Sections.[Вопросов 10] FROM Sections inner join Сompetence AS C1 on Sections.[Компетенция 1]=C1.ID inner join Сompetence AS C2 on Sections.[Компетенция 2]=C2.ID inner join Сompetence AS C3 on Sections.[Компетенция 3]=C3.ID inner join Сompetence AS C4 on Sections.[Компетенция 4]=C4.ID inner join Сompetence AS C5 on Sections.[Компетенция 5]=C5.ID inner join Сompetence AS C6 on Sections.[Компетенция 6]=C6.ID inner join Сompetence AS C7 on Sections.[Компетенция 7]=C7.ID inner join Сompetence AS C8 on Sections.[Компетенция 8]=C8.ID inner join Сompetence AS C9 on Sections.[Компетенция 9]=C9.ID inner join Сompetence AS C10 on Sections.[Компетенция 10]=C10.ID WHERE Sections.[Запустить тестирование]='True'");
                        string message = "";
                        for (int i = 0; i < datatable.Rows.Count; i++)
                        {
                            for (int j = 0; j < datatable.Columns.Count; j++)
                            {
                                message += datatable.Rows[i][j].ToString() + "|";
                            }
                            message += "\n";
                        }
                        sendBackgroundWorker.RunWorkerAsync(
                            new SendArgument()
                            {
                                Hostname = hostname,
                                Message = message
                            });
                    }
                    if (message_type == 3)
                    {
                        DataTable datatable = new DataTable();
                        datatable =
                            DataRead(
                                "SELECT * FROM Sections WHERE Sections.ID=" + enter[2]);
                        string message = "";

                        for (int j = 0; j < datatable.Columns.Count; j++)
                        {
                            message += datatable.Rows[0][j].ToString() + "|";
                        }
                        sendBackgroundWorker.RunWorkerAsync(
                            new SendArgument()
                                {
                                    Hostname = hostname,
                                    Message = message
                                });
                    }
                    if (message_type == 4)
                    {
                        DataTable datatable = new DataTable();
                        datatable =
                            DataRead(
                                "Select Attempts.[Количество попыток] From Attempts WHERE Attempts.[Название раздела]=" +
                                enter[3] + " AND Attempts.[Фамилия участника]=" + enter[2]);
                        DataTable datatable_2 = new DataTable();
                        datatable_2 =
                            DataRead("Select Sections.[Количество попыток] From Sections WHERE Sections.ID=" + enter[3]);
                        string message = "";
                        bool message_status = false;
                        if (datatable.Rows.Count == 0)
                        {
                            message_status = true;
                            DataTable datatable_3 = new DataTable();
                            datatable_3 =
                                DataRead("Insert INTO [dbo].[Attempts] Values (" + enter[2] + ", " + enter[3] + ", 1)");
                        }
                        else
                        {
                            if (Convert.ToInt32(datatable_2.Rows[0][0]) - Convert.ToInt32(datatable.Rows[0][0]) > 0)
                            {
                                message_status = true;
                                DataTable datatable_3 = new DataTable();
                                datatable_3 =
                                    DataRead(
                                        "Update Attempts set [Количество попыток] = [Количество попыток]+1 where [Фамилия участника]=" +
                                        enter[2] + " AND [Название раздела]=" + enter[3]);
                            }
                        }
                        if (message_status)
                        {
                            message += "Да";
                            DataTable datatable_3 = new DataTable();
                            datatable_3 =
                                DataRead(
                                    "Select Sections.[Компетенция 1], Sections.[Вопросов 1], Sections.[Компетенция 2], Sections.[Вопросов 2], Sections.[Компетенция 3], Sections.[Вопросов 3], Sections.[Компетенция 4], Sections.[Вопросов 4], Sections.[Компетенция 5], Sections.[Вопросов 5], Sections.[Компетенция 6], Sections.[Вопросов 6], Sections.[Компетенция 7], Sections.[Вопросов 7], Sections.[Компетенция 8], Sections.[Вопросов 8], Sections.[Компетенция 9], Sections.[Вопросов 9], Sections.[Компетенция 10], Sections.[Вопросов 10] From Sections WHERE Sections.ID=" +
                                    enter[3]);
                            for (int i = 0; i < 10; i++)
                            {
                                DataTable dataTable_4 = new DataTable();
                                dataTable_4 =
                                    DataRead("Select * From Questions WHERE Questions.Компетенция=" +
                                             Convert.ToInt32(datatable_3.Rows[0][2 * i]));
                                //если количество вопросов заполнено
                                if (datatable_3.Rows[0][2 * i + 1].ToString() != "")
                                {
                                    Random r = new Random();
                                    int max = Convert.ToInt32(datatable_3.Rows[0][2 * i + 1]);
                                    int[] x = new int[max];
                                    for (int j = 0; j < max; j++)
                                    {
                                        message += "\n";
                                        bool contains = true;
                                        int next = 0;
                                        while (contains)
                                        {
                                            next = r.Next(dataTable_4.Rows.Count);
                                            contains = false;
                                            for (int index = 0; index < j; index++)
                                            {
                                                if (x[index] == next)
                                                {
                                                    contains = true;
                                                    break;
                                                }
                                            }
                                        }
                                        x[j] = next;
                                        for (int index = 0; index < dataTable_4.Columns.Count; index++)
                                        {
                                            message += dataTable_4.Rows[next][index];
                                            message += "|";
                                        }
                                    }
                                }
                            }

                        }
                        else
                        {
                            message += "Нет";
                        }
                        sendBackgroundWorker.RunWorkerAsync(
                            new SendArgument()
                            {
                                Hostname = hostname,
                                Message = message
                            });
                    }
                    if (message_type == 5)
                    {
                        string[] result = enter[22].Split(',');
                        DataTable dataTable = new DataTable();
                        dataTable =
                            DataRead("Select Results.Итог From Results WHERE Results.[Фамилия участника]=" + result[0] +
                                     " AND Results.[Название раздела]=" + result[1]);
                        if (dataTable.Rows.Count != 0)
                        {
                            if (Convert.ToInt32(result[2]) > Convert.ToInt32(dataTable.Rows[0][0]))
                            {
                                DataTable dataTable_2 = new DataTable();
                                dataTable_2 =
                                    DataRead("Update Results set Итог=" + result[2] + ", [Процент 1]=" + result[3] +
                                             ", [Процент 2]=" + result[4] + ", [Процент 3]=" + result[5] +
                                             ", [Процент 4]=" + result[6] + ", [Процент 5]=" + result[7] +
                                             ", [Процент 6]=" + result[8] + ", [Процент 7]=" + result[9] +
                                             ", [Процент 8]=" + result[10] + ", [Процент 9]=" + result[11] +
                                             ", [Процент 10]=" + result[12] + " Where [Фамилия участника]=" + result[0] +
                                             " AND [Название раздела]=" + result[1]);
                                DataTable dataTable_3 = new DataTable();
                                dataTable_3 = DataRead("delete From Answers WHERE [Название раздела]=" + result[1] +
                                             " AND [Фамилия участника]=" + result[0]);
                                for (int i = 0; i < 20; i++)
                                {
                                    DataTable dataTable_4 = new DataTable();
                                    dataTable_4 = DataRead("Insert INTO [dbo].[Answers] Values (" + enter[2 + i] + ")");
                                }
                            }
                        }
                        else
                        {
                            DataTable dataTable_2 = new DataTable();
                            dataTable_2 = DataRead("Insert INTO [dbo].[Results] Values (" + enter[22] + ")");
                            for (int i = 0; i < 20; i++)
                            {
                                DataTable dataTable_3 = new DataTable();
                                dataTable_3 = DataRead("Insert INTO [dbo].[Answers] Values (" + enter[2 + i] + ")");
                            }
                        }
                    }
                }
                client.Close();
            }
            listener.Stop();
        }

        private void receiveBackgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                //richTextBox_log.Text += "\nСервер снова умер:" + e.Error.Message;
                //label_status.Text = "Не работает";
                receiveBackgroundWorker.RunWorkerAsync();
            }
        }
    }
}
