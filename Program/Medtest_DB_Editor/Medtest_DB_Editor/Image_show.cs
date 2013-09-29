using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medtest_DB_Editor
{
    public partial class Image_show : Form
    {
        public Image_show()
        {
            InitializeComponent();
        }

        public string path ;

        private void Image_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(path);
        }
    }
}
