using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment01
{
    public partial class fullname : Form
    {
        public fullname()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "Sofia Ruth E. Villanuava";
            MessageBox.Show(name, "Name:");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
