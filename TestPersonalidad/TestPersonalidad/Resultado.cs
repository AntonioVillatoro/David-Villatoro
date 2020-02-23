using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F2
{
    public partial class Form2 : Form
    {
        public Form2(string r1, string r2, string r3, string r4)
        {
            InitializeComponent();
            txtr1.Text = r1;
            txtr2.Text = r2;
            txtr3.Text = r3;
            txtr4.Text = r4;

            string descripcion="";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void txtr1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
