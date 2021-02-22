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
        double sumOfCafe = 0;
        double countH = 0;
        double countG = 0;
        double countP = 0;
        double countC = 0;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(oils);
            comboBox1.SelectedItem = comboBox1.Items[0];
            textBox2.Enabled = true;
            radioButton1.Checked = true;
            comboBox1.SelectedIndexChanged += textBox2_TextChanged;
            comboBox1.SelectedIndexChanged += textBox3_TextChanged;
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
                textBox2.Clear();
                textBox3.Enabled = false;
                textBox3.Clear();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.Enabled = false;
                textBox2.Clear();
                textBox3.Enabled = true;
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.TextLength >= 2)
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
            if (checkBox3.Checked)
            {
                textBox10.Enabled = true;
                textBox10.Focus();
            }
            else
            {
                sumOfCafe -= (Convert.ToDouble(textBox6.Text) * countP);
                countP = 0;
                textBox10.Enabled = false;
                label5.Text = Math.Round(sumOfCafe, 2).ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox8.Enabled = true;
                textBox8.Focus();
            }
            else
            {
                sumOfCafe -= (Convert.ToDouble(textBox4.Text) * countH);
                countH = 0;
                textBox8.Enabled = false;
                label5.Text = Math.Round(sumOfCafe, 2).ToString();
            }
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox8.Text != "")
                {
                    if (Convert.ToDouble(textBox8.Text) != countH)
                    {
                        sumOfCafe -= (Convert.ToDouble(textBox4.Text) * countH);
                        countH = Convert.ToDouble(textBox8.Text);
                        sumOfCafe += (Convert.ToDouble(textBox4.Text) * countH);
                        label5.Text = Math.Round(sumOfCafe, 2).ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox9.Text != "")
                {
                    if (Convert.ToDouble(textBox9.Text) != countG)
                    {
                        sumOfCafe -= (Convert.ToDouble(textBox7.Text) * countG);
                        countG = Convert.ToDouble(textBox9.Text);
                        sumOfCafe += (Convert.ToDouble(textBox7.Text) * countG);
                        label5.Text = Math.Round(sumOfCafe, 2).ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            { 
                textBox9.Enabled = true;
                textBox9.Focus();
            }
            else
            {
                sumOfCafe -= (Convert.ToDouble(textBox7.Text) * countG);
                countG = 0;
                textBox9.Enabled = false;
                label5.Text = Math.Round(sumOfCafe, 2).ToString();
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox10.Text != "")
                {
                    if (Convert.ToDouble(textBox10.Text) != countP)
                    {
                        sumOfCafe -= (Convert.ToDouble(textBox6.Text) * countP);
                        countP = Convert.ToDouble(textBox10.Text);
                        sumOfCafe += (Convert.ToDouble(textBox6.Text) * countP);
                        label5.Text = Math.Round(sumOfCafe, 2).ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox11.Enabled = true;
                textBox11.Focus();
            }
            else
            {
                sumOfCafe -= (Convert.ToDouble(textBox5.Text) * countC);
                countC = 0;
                textBox11.Enabled = false;
                label5.Text = Math.Round(sumOfCafe, 2).ToString();
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox11.Text != "")
                {
                    if (Convert.ToDouble(textBox11.Text) != countC)
                    {
                        sumOfCafe -= (Convert.ToDouble(textBox5.Text) * countC);
                        countC = Convert.ToDouble(textBox11.Text);
                        sumOfCafe += (Convert.ToDouble(textBox5.Text) * countC);
                        label5.Text = Math.Round(sumOfCafe, 2).ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = (Convert.ToDouble(label4.Text) + Convert.ToDouble(label5.Text)).ToString();
        }
    }
}
