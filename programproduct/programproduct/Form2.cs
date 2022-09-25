using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programproduct
{
    public partial class Form2 : Form
    {
        public string chooselanguage;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                chooselanguage = "ru";
                this.Close();
            if (radioButton2.Checked)
                chooselanguage = "en";
                this.Close();
            if (radioButton3.Checked) 
                chooselanguage= "fr";
                this.Close();
            if (!(radioButton1.Checked | radioButton2.Checked | radioButton3.Checked))
                MessageBox.Show("Выберите язык");

        }
    }
}
