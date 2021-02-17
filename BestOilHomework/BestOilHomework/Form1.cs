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
            comboBox1.SelectedIndexChanged += textBox2_TextChanged;
            comboBox1.SelectedIndexChanged += textBox3_TextChanged;
            radioButton1.CheckedChanged += comboBox1_SelectedIndexChanged;
            radioButton2.CheckedChanged += comboBox1_SelectedIndexChanged;
            radioButton1.CheckedChanged += textBox2_TextChanged;
            radioButton2.CheckedChanged += textBox3_TextChanged;
            textBox2.TextChanged += comboBox1_SelectedIndexChanged;
            textBox3.TextChanged += comboBox1_SelectedIndexChanged;
            textBox4.Text = "21,50";
            textBox7.Text = "32,80";
            textBox6.Text = "25,00";
            textBox5.Text = "16,00";
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
            if (textBox3.Text.Length > 2)
            {
                double sum = 0;
                double price = 0;
                double res;
                try
                {
                    sum = Convert.ToDouble(textBox3.Text);
                    price = Convert.ToDouble(textBox1.Text);

                }
                catch { MessageBox.Show("Неверный формат", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                if (sum > price)
                {
                    res = Math.Round(sum / price, 2);
                    textBox2.Text = res.ToString();
                }
                else
                {
                    MessageBox.Show("Слишком маленькая сумма", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                label4.Text = textBox3.Text;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            double price = 0;
            double count = 0;
            double res;

            if (checkBox1.Checked)
            {
                if (textBox8.Text != "")
                {
                    try
                    {
                        price = Convert.ToDouble(textBox1.Text);
                        count = Convert.ToDouble(textBox2.Text);
                    }
                    catch { MessageBox.Show("Неверный формат", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    res = Math.Round(count * price, 2);
                    label5.Text = res.ToString();
                }
            }
        }
    }
}
