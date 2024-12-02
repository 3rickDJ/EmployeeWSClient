using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppBorrarhehe
{
    public partial class Form1 : Form
    {
        EmployeeWS.WebService1SoapClient cte = new EmployeeWS.WebService1SoapClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                DateTime timeStamp;
                if(DateTime.TryParse(textBox3.Text, out timeStamp))
                {
                    int Id = int.Parse(textBox1.Text);
                    string status = cte.PunchCard2(Id, timeStamp);
                    textBox2.Text = status;
                } else
                {
                    textBox2.Text = "Fecha y hora en formato incorrecto";
                }
            } else
            {

                int Id = int.Parse(textBox1.Text);
                string status = cte.PunchCard(Id);
                textBox2.Text = status;
                textBox1.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Visible = checkBox1.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
