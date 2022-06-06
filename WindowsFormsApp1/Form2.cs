using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2(string dato)
        {
            InitializeComponent();
            label1.Text = dato;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
