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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = !radioButton1.Checked;
            string indicadorPais = "Tu vieja";
            if (listaPaises.SelectedItem != null)
            {
                indicadorPais = listaPaises.SelectedItem.ToString();
                label1.Text = indicadorPais;

            }


    }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.notengoenie.com/");
        }

        public void button2_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://" + textBox1.Text.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void holaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.homerswebpage.com/");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(formOneDato.Text);
            form2.Show();

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click_1(sender, e);
            }
        }
    }
}
