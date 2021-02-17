using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOilHomework
{
    public partial class Form1 : Form
    {
        string[] oils = { "АИ-80", "АИ-92", "АИ-95", "АИ-98", "ДТ" };
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(oils);
            comboBox1.SelectedItem = comboBox1.Items[0];
            textBox2.Enabled = true;
            radioButton1.Checked = true;
            radioButton1.CheckedChanged += textBox2_TextChanged;
            radioButton2.CheckedChanged += textBox3_TextChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == comboBox1.Items[0])
            {
                textBox1.Text = "22,30";
            }
            else if (comboBox1.SelectedItem == comboBox1.Items[1])
            {
                textBox1.Text = "24,90";
            }
            else if (comboBox1.SelectedItem == comboBox1.Items[2])
            {
                textBox1.Text = "26,20";
            }
            else if (comboBox1.SelectedItem == comboBox1.Items[3])
            {
                textBox1.Text = "28,56";
            }
            else 
            {
                textBox1.Text = "26,50";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double price = 0;
            double count = 0;
            double res;
            if (textBox2.Text != "")
            {
                try 
                {
                    price = Convert.ToDouble(textBox1.Text);
                    count = Convert.ToDouble(textBox2.Text); 
                }
                catch { MessageBox.Show("Неверный формат","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); }
                res = Math.Round(count * price,2);
                label4.Text = res.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox2.Enabled = true;
                textBox3.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.Enabled = false;
                textBox3.Enabled = true;
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label4.Text = textBox3.Text;
        }
    }
}
