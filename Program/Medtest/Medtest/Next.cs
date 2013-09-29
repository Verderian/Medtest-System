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
    public partial class Next : Form
    {
        public Next()
        {
            InitializeComponent();
        }

        private void Next_Load(object sender, EventArgs e)
        {
            panel_thanks.Location = new Point(Form.ActiveForm.Width / 2 - panel_thanks.Width / 2, Form.ActiveForm.Height / 2 - panel_thanks.Height / 2);
        }

        //Горячие клавиши
        private void Next_KeyDown(object sender, KeyEventArgs e)
        {
            //клавиша, показывавающая информацию о продукте
            if (e.KeyCode == Keys.F1)
            {
                AboutBox1 F = new AboutBox1();
                F.Show();
            }
        }

        //Кнопка далее
        private void button_next_Click(object sender, EventArgs e)
        {
            Main F = new Main();
            F.Visible = true;
            this.Close();
        }
    }
}
