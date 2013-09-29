using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel; 

namespace Medtest_DB_Editor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region Initialize

        //объявление переменных
        private DataTable datatablePerformance;
        private SqlDataAdapter dataAdapter;
        private SqlConnection connectionPerformance;

        //строка подключения
        private string connectionString;

        //номер текущей вкладки
        private int tabindex = 0;

        #endregion Initialize

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medtest_dbDataSet1.Сompetence". При необходимости она может быть перемещена или удалена.
            this.сompetenceTableAdapter.Fill(this.medtest_dbDataSet1.Сompetence);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medtest_dbDataSet1.Сompetence". При необходимости она может быть перемещена или удалена.
            this.сompetenceTableAdapter.Fill(this.medtest_dbDataSet1.Сompetence);
            
        }

        private Data data;

        private void Data_read()
        {
            connectionString = @"Data Source=" + textBox_authorization_name_server.Text + "; user=" +
                               textBox_authorization_name_user.Text + "; Password=" +
                               textBox_authorization_password.Text + "; Initial Catalog=" +
                               textBox_authorization_name_BD.Text + ";";
            questionsTableAdapter.Connection.ConnectionString = connectionString;
            resultsTableAdapter.Connection.ConnectionString = connectionString;
            attemptsTableAdapter.Connection.ConnectionString = connectionString;
            passwordsTableAdapter.Connection.ConnectionString = connectionString;
            sectionsTableAdapter.Connection.ConnectionString = connectionString;
            dictCategTableAdapter.Connection.ConnectionString = connectionString;
            participantsTableAdapter.Connection.ConnectionString = connectionString;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medtest_dbDataSet1.Questions". При необходимости она может быть перемещена или удалена.
            this.questionsTableAdapter.Fill(this.medtest_dbDataSet1.Questions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medtest_dbDataSet1.Results". При необходимости она может быть перемещена или удалена.
            this.resultsTableAdapter.Fill(this.medtest_dbDataSet1.Results);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medtest_dbDataSet1.Attempts". При необходимости она может быть перемещена или удалена.
            this.attemptsTableAdapter.Fill(this.medtest_dbDataSet1.Attempts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medtest_dbDataSet1.Passwords". При необходимости она может быть перемещена или удалена.
            this.passwordsTableAdapter.Fill(this.medtest_dbDataSet1.Passwords);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medtest_dbDataSet1.Sections". При необходимости она может быть перемещена или удалена.
            this.sectionsTableAdapter.Fill(this.medtest_dbDataSet1.Sections);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medtest_dbDataSet1.DictCateg". При необходимости она может быть перемещена или удалена.
            this.dictCategTableAdapter.Fill(this.medtest_dbDataSet1.DictCateg);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medtest_dbDataSet1.Participants". При необходимости она может быть перемещена или удалена.
            this.participantsTableAdapter.Fill(this.medtest_dbDataSet1.Participants);
            data = new Data();
            if (tabindex == 0)
            {
                toolStripButton_Save.Enabled = true;
                toolStripButton_add.Enabled = true;
                toolStripButton_Update.Enabled = true;
                toolStripButton_Delete.Enabled = true;
                toolStrip_panel.Enabled = true;
                Participants_datagrid.DataSource = data.ReadData(datatablePerformance, dataAdapter, connectionPerformance,
                                                                connectionString, "SELECT * FROM Participants");
            }
            if (tabindex == 1)
            {
                toolStripButton_Save.Enabled = true;
                toolStripButton_add.Enabled = true;
                toolStripButton_Update.Enabled = true;
                toolStripButton_Delete.Enabled = true;
                toolStrip_panel.Enabled = true;
                Sections_datagrid.DataSource = data.ReadData(datatablePerformance, dataAdapter, connectionPerformance,
                                                            connectionString, "SELECT * FROM Sections");
            }
            if (tabindex == 2)
            {
                toolStripButton_Save.Enabled = true;
                toolStripButton_add.Enabled = false;
                toolStripButton_Update.Enabled = true;
                toolStripButton_Delete.Enabled = true;
                toolStrip_panel.Enabled = true;
                Questions_datagrid.DataSource = data.ReadData(datatablePerformance, dataAdapter, connectionPerformance,
                                                            connectionString, "SELECT * FROM Questions");
            }
            if (tabindex == 3)
            {
                toolStripButton_Save.Enabled = true;
                toolStripButton_add.Enabled = true;
                toolStripButton_Update.Enabled = true;
                toolStripButton_Delete.Enabled = true;
                toolStrip_panel.Enabled = true;
                Passwords_datagrid.DataSource = data.ReadData(datatablePerformance, dataAdapter, connectionPerformance,
                                                             connectionString, "SELECT * FROM Passwords");
            }
            if (tabindex == 4)
            {
                toolStripButton_Save.Enabled = true;
                toolStripButton_add.Enabled = true;
                toolStripButton_Update.Enabled = true;
                toolStripButton_Delete.Enabled = true;
                toolStrip_panel.Enabled = true;
                Attempts_datagrid.DataSource = data.ReadData(datatablePerformance, dataAdapter, connectionPerformance,
                                                            connectionString, "SELECT * FROM Attempts");
            }
            if (tabindex == 5)
            {
                toolStripButton_Save.Enabled = true;
                toolStripButton_add.Enabled = false;
                toolStripButton_Update.Enabled = true;
                toolStripButton_Delete.Enabled = true;
                toolStrip_panel.Enabled = true;
                Resultsitog_datagrid.DataSource = data.ReadData(datatablePerformance, dataAdapter, connectionPerformance,
                                                            connectionString, "SELECT * FROM Results");
            }
        }

        #region Panel_Authorization

        private void button_authorization_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_authorization_connect_Click(object sender, EventArgs e)
        {
            if (textBox_authorization_name_BD.Text != "" & textBox_authorization_name_server.Text != "" &
                textBox_authorization_name_user.Text != "" & textBox_authorization_password.Text != "")
            {
                panel_authorization.Visible = false;
                menu_panel.Enabled = true;
                toolStrip_panel.Enabled = true;
                tabcontrol_head.Visible = true;
                try
                {
                    Data_read();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка соединения с сервером", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Заполнены не все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Panel_Authorization

        #region Tools_Strip

        private void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            data.Save();
        }

        private void toolStripButton_add_Click(object sender, EventArgs e)
        {
            data.Add();
        }

        private void toolStripButton_Delete_Click(object sender, EventArgs e)
        {
            if (tabindex == 0)
            {
                while (Participants_datagrid.SelectedRows.Count != 0)
                {
                    Participants_datagrid.Rows.RemoveAt(Participants_datagrid.SelectedCells[0].RowIndex);
                    data.Save();
                }
                Data_read();
            }
            if (tabindex == 1)
            {
                while (Sections_datagrid.SelectedRows.Count != 0)
                {
                    Sections_datagrid.Rows.RemoveAt(Sections_datagrid.SelectedCells[0].RowIndex);
                    data.Save();
                }
                Data_read();
            }
            if (tabindex == 2)
            {
                while (Questions_datagrid.SelectedRows.Count != 0)
                {
                    Questions_datagrid.Rows.RemoveAt(Questions_datagrid.SelectedCells[0].RowIndex);
                    data.Save();
                }
                Data_read();
            }
            if (tabindex == 3)
            {
                while (Passwords_datagrid.SelectedRows.Count != 0)
                {
                    Passwords_datagrid.Rows.RemoveAt(Passwords_datagrid.SelectedCells[0].RowIndex);
                    data.Save();
                }
                Data_read();
            }
            if (tabindex == 4)
            {
                while (Attempts_datagrid.SelectedRows.Count != 0)
                {
                    Attempts_datagrid.Rows.RemoveAt(Attempts_datagrid.SelectedCells[0].RowIndex);
                    data.Save();
                }
                Data_read();
            }
            if (tabindex == 5)
            {
                while (Resultsitog_datagrid.SelectedRows.Count != 0)
                {
                    Resultsitog_datagrid.Rows.RemoveAt(Resultsitog_datagrid.SelectedCells[0].RowIndex);
                    data.Save();
                }
                Data_read();
            }
        }

        private void toolStripButton_Update_Click(object sender, EventArgs e)
        {
            Data_read();
        }

        private void toolStrip_Query_Click(object sender, EventArgs e)
        {
            Query F = new Query();
            F.connectionString = connectionString;
            F.Show();
        }

        private void toolStripButton_txt_Click(object sender, EventArgs e)
        {
            SaveFormats save = new SaveFormats();

            if (tabindex == 0)
                save.SaveCsv(Participants_datagrid);
            if (tabindex == 1)
                save.SaveCsv(Sections_datagrid);
            if (tabindex == 2)
                save.SaveCsv(Questions_datagrid);
            if (tabindex == 3)
                save.SaveCsv(Passwords_datagrid);
            if (tabindex == 4)
                save.SaveCsv(Attempts_datagrid);
            if (tabindex == 5)
                save.SaveCsv(Resultsitog_datagrid);
        }

        private void toolStripButton_Excell_Click(object sender, EventArgs e)
        {
            SaveFormats save = new SaveFormats();

            if (tabindex == 0)
                save.SaveExcel(Participants_datagrid);
            if (tabindex == 1)
                save.SaveExcel(Sections_datagrid);
            if (tabindex == 2)
                save.SaveExcel(Questions_datagrid);
            if (tabindex == 3)
                save.SaveExcel(Passwords_datagrid);
            if (tabindex == 4)
                save.SaveExcel(Attempts_datagrid);
            if (tabindex == 5)
                save.SaveExcel(Resultsitog_datagrid);
        }

        #endregion Tools_Strip

        #region Tabcontrols

        private void tabcontrol_head_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabindex = tabcontrol_head.SelectedIndex;
            Data_read();
        }

        private void tab_control_results_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabindex = 5 + tab_control_results.SelectedIndex;
            if (tabindex == 6)
            {
                toolStrip_panel.Enabled = false;
                for (int i = 0; i < Resultsitog_datagrid.RowCount; i++)
                {
                    chart1.ChartAreas[0].AxisY.Maximum = 20;
                    chart1.Series[0].Points.Add(Convert.ToDouble(Resultsitog_datagrid[2, i].Value));
                }
            }
            else
            {
                chart1.Series[0].Points.Clear();
                Data_read();
            }
        }

        #endregion Tabcontrols

        #region MenuStrip
        //Выход из приложения
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Создание запроса по БД
        private void сделатьЗапросПоБазеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query F = new Query();
            F.connectionString = connectionString;
            F.Show();
        }

        //Сохранение в XML файл
        private void экспортВXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "XML (*xml)|*.xml";
            saveFile.ShowDialog();
            if (saveFile.FileName != "")
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter da = new SqlDataAdapter("select * from Participants", connection);
                SqlDataAdapter da2 = new SqlDataAdapter("select * from Sections", connection);
                SqlDataAdapter da3 = new SqlDataAdapter("select * from Questions", connection);
                SqlDataAdapter da4 = new SqlDataAdapter("select * from Passwords", connection);
                SqlDataAdapter da5 = new SqlDataAdapter("select * from Attempts", connection);
                SqlDataAdapter da6 = new SqlDataAdapter("select * from Results", connection);
                connection.Open();
                DataSet ds = new DataSet("Medtest_db");
                da.Fill(ds, "Participants");
                da2.Fill(ds, "Sections");
                da3.Fill(ds, "Questions");
                da4.Fill(ds, "Passwords");
                da5.Fill(ds, "Attempts");
                da6.Fill(ds, "Results");
                ds.WriteXml(saveFile.FileName, XmlWriteMode.WriteSchema);
                connection.Close();
            }
            saveFile.Dispose();
        }
        
        //Показать окно о программе
        private void опрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgram F = new AboutProgram();
            F.Show();
        }
        #endregion MenuStrip

        //ListBox со списком отделений (Вкладка результаты)
        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            data = new Data();
            Resultsitog_datagrid.DataSource = data.ReadData(datatablePerformance, dataAdapter, connectionPerformance,
                                                            connectionString,
                                                            "select * from Results inner join Participants on Results.[Фамилия участника] = Participants.id where Participants.Отделение = " +
                                                            listBox2.SelectedValue.ToString());
            if (tabindex == 6)
            {
                chart1.Series[0].Points.Clear();
                toolStrip_panel.Enabled = false;
                for (int i = 0; i < Resultsitog_datagrid.RowCount; i++)
                {
                    chart1.Series[0].Points.Add(Convert.ToDouble(Resultsitog_datagrid[3, i].Value));
                }
            }
        }

        //ListBox со списком разделов (Вкладка вопросы)
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            data = new Data();
            Questions_datagrid.DataSource = data.ReadData(datatablePerformance, dataAdapter, connectionPerformance,
                                                            connectionString,
                                                            "select * from Questions Where [Компетенция] = " +
                                                            listBox1.SelectedValue);
        }

        //Очистить содержимое вкладок
        private void button_question_clear_Click(object sender, EventArgs e)
        {
            richtext_add_question.Clear();
            textBox_add_var_1.Clear();
            textBox_add_var_2.Clear();
            textBox_add_var_3.Clear();
            textBox_add_var_4.Clear();
            textBox_add_var_5.Clear();
            textBox_add_string_ans.Clear(); ;
            checkBox_add_var_1.CheckState = CheckState.Unchecked;
            checkBox_add_var_2.CheckState = CheckState.Unchecked;
            checkBox_add_var_3.CheckState = CheckState.Unchecked;
            checkBox_add_var_4.CheckState = CheckState.Unchecked;
            checkBox_add_var_5.CheckState = CheckState.Unchecked;
        }

        //Тип вопроса (с несколькими вариантами ответа или с одним)
        private void checkBox_add_type_ans_CheckedChanged(object sender, EventArgs e)
        {
            textBox_add_var_1.Clear();
            textBox_add_var_2.Clear();
            textBox_add_var_3.Clear();
            textBox_add_var_4.Clear();
            textBox_add_var_5.Clear();
            textBox_add_string_ans.Clear(); ;
            checkBox_add_var_1.CheckState = CheckState.Unchecked;
            checkBox_add_var_2.CheckState = CheckState.Unchecked;
            checkBox_add_var_3.CheckState = CheckState.Unchecked;
            checkBox_add_var_4.CheckState = CheckState.Unchecked;
            checkBox_add_var_5.CheckState = CheckState.Unchecked;
            if (checkBox_add_type_ans.Checked == true)
            {
                textBox_add_string_ans.Enabled = true;
                textBox_add_var_1.Enabled = false;
                textBox_add_var_2.Enabled = false;
                textBox_add_var_3.Enabled = false;
                textBox_add_var_4.Enabled = false;
                textBox_add_var_5.Enabled = false;
                checkBox_add_var_1.Enabled = false;
                checkBox_add_var_2.Enabled = false;
                checkBox_add_var_3.Enabled = false;
                checkBox_add_var_4.Enabled = false;
                checkBox_add_var_5.Enabled = false;
            }
            else
            {
                textBox_add_string_ans.Enabled = false;
                textBox_add_var_1.Enabled = true;
                textBox_add_var_2.Enabled = true;
                textBox_add_var_3.Enabled = true;
                textBox_add_var_4.Enabled = true;
                textBox_add_var_5.Enabled = true;
                checkBox_add_var_1.Enabled = true;
                checkBox_add_var_2.Enabled = true;
                checkBox_add_var_3.Enabled = true;
                checkBox_add_var_4.Enabled = true;
                checkBox_add_var_5.Enabled = true;
            }
        }

        //Добавить вопрос
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int type = 0;
                if (checkBox_add_type_ans.Checked == true)
                {
                    type = 1;
                }
                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter da = new SqlDataAdapter("INSERT INTO [dbo].[Questions] VALUES (" + listBox1.SelectedValue + ",'" + richtext_add_question.Text + "',NULL,'" + checkBox_add_not_test.Checked.ToString() + "'," + type.ToString() + ",'" + textBox_add_var_1.Text + "','" + checkBox_add_var_1.Checked.ToString() + "','" + textBox_add_var_2.Text + "','" + checkBox_add_var_2.Checked.ToString() + "','" + textBox_add_var_3.Text + "','" + checkBox_add_var_3.Checked.ToString() + "','" + textBox_add_var_4.Text + "','" + checkBox_add_var_4.Checked.ToString() + "','" + textBox_add_var_5.Text + "','" + checkBox_add_var_5.Checked.ToString() + "','" + textBox_add_string_ans.Text + "')", connection);
                connection.Open();
                DataSet ds = new DataSet();
                da.Fill(ds);
                connection.Close();

                richtext_add_question.Clear();
                textBox_add_var_1.Clear();
                textBox_add_var_2.Clear();
                textBox_add_var_3.Clear();
                textBox_add_var_4.Clear();
                textBox_add_var_5.Clear();
                textBox_add_string_ans.Clear(); ;
                checkBox_add_var_1.CheckState = CheckState.Unchecked;
                checkBox_add_var_2.CheckState = CheckState.Unchecked;
                checkBox_add_var_3.CheckState = CheckState.Unchecked;
                checkBox_add_var_4.CheckState = CheckState.Unchecked;
                checkBox_add_var_5.CheckState = CheckState.Unchecked;
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены неверно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class Data : Main
    {
        //объявление переменных
        public DataTable table;
        private SqlDataAdapter adapter;
        private SqlConnection connection;

        public DataTable ReadData(DataTable datatable, SqlDataAdapter sqlDataAdapter, SqlConnection sqlConnection,
                                 string connectionS, string command)
        {
            //инициализация новых экземпляров класса
            datatable = new DataTable();
            sqlConnection = new SqlConnection(connectionS);
            //открытие подключения к базе
            sqlConnection.Open();
            try
            {
                //создание команды
                SqlCommand commandPerformance = sqlConnection.CreateCommand();
                //запись запроса в команду
                commandPerformance.CommandText = command;
                //инициализация нового экземпляра класса адаптера с командой
                sqlDataAdapter = new SqlDataAdapter(commandPerformance);
                //загрузка данных из адаптера в таблицу
                sqlDataAdapter.Fill(datatable);
                table = datatable;
                adapter = sqlDataAdapter;
                connection = sqlConnection;
            }
            finally
            {
                //закрытие подключения к базе
                sqlConnection.Close();
            }
            return datatable;
        }

        public void Save()
        {
            connection.Open();
            try
            {
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                adapter.InsertCommand = commandBuilder.GetInsertCommand();
                adapter.DeleteCommand = commandBuilder.GetDeleteCommand();
                adapter.Update(table);
            }
            catch (Exception)
            {
                MessageBox.Show("Операция не удалась", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public void Add()
        {
            DataRow newRow = table.NewRow();
            table.Rows.Add(newRow);
        }
    }

    public class SaveFormats: Main
    {
        public void SaveCsv(DataGridView dataGridView)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "CSV (*csv)|*.csv";
            saveFile.ShowDialog();
            StreamWriter writer = new StreamWriter(saveFile.FileName, false, System.Text.Encoding.Default);
            int row = dataGridView.Rows.Count;
            int col = dataGridView.Columns.Count;

            try
            {
                if (saveFile.FileName != "")
                {
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        writer.Write(dataGridView.Columns[i].HeaderText + ";");
                    }

                    writer.Write("\r\n");
                    for (int j = 0; j < row; j++)
                    {
                        for (int k = 0; k < col; k++)
                        {
                            writer.Write(dataGridView.Rows[j].Cells[k].Value.ToString() + ";");
                        }
                        writer.Write("\r\n");
                    }
                }
                MessageBox.Show("Файл сохранен", "Информация", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            catch
            {
                MessageBox.Show("Файл не может быть создан", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                writer.Close();
                saveFile.Dispose();
            }
        }

        public void SaveExcel(DataGridView dataGridView)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "XLS (*xls)|*.xls";
            saveFile.ShowDialog();
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            Excel.Application xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                DataGridViewCell cell = dataGridView.Columns[i].HeaderCell;
                xlWorkSheet.Cells[1, i + 1] = cell.Value;
            }
            for (int i = 0; i <= dataGridView.RowCount - 1; i++)
            {
                for (int j = 0; j <= dataGridView.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataGridView[j, i];
                    xlWorkSheet.Cells[i + 2, j + 1] = cell.Value;
                }
            }

            xlWorkBook.SaveAs(saveFile.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
            saveFile.Dispose();
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

    }
}