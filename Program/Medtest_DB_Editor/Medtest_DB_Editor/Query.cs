using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medtest_DB_Editor
{
    public partial class Query : Form
    {
        #region Initialize
        //объявление переменных
        private DataTable datatablePerformance;
        private SqlDataAdapter dataAdapter;
        private SqlConnection connectionPerformance;

        //строка подключения
        public string connectionString;
        #endregion Initialize

        public Query()
        {
            InitializeComponent();
        }

        private void Query_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Data data = new Data();
                dataGridView1.DataSource = data.ReadData(datatablePerformance, dataAdapter, connectionPerformance,
                                                        connectionString, richTextBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Запрос введен неверно!");
            }
        }
    }
}
