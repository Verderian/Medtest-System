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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        //Горячие клавиши
        private void Help_KeyDown(object sender, KeyEventArgs e)
        {
            //закрытие
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        //Отмена
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
