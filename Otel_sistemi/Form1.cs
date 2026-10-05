using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_sistemi
{
    public partial class Form1 : Form
    {
        // Hər otaq üçün saniyə dəyişənləri
        int otaq1_sure = 0;
        int otaq2_sure = 0;
        int otaq3_sure = 0;
        int otaq4_sure = 0;
        int otaq5_sure = 0;
        int otaq6_sure = 0;

        public Form1()
        {
            InitializeComponent();

           
            timer1.Tick += timer1_Tick;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

       
        private void RezervEt(Button btn, ref int sure, Label lbl, string deqiqeText)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(deqiqeText))
            {
                MessageBox.Show("Zəhmət olmasa Ad və Soyad, həmçinin Müddəti daxil edin!", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(deqiqeText, out int deqiqe))
            {
                sure = deqiqe * 60;
                btn.Enabled = false;
                btn.BackColor = Color.Red;

                
                textBox1.Clear();
                textBox2.Clear();

                timer1.Interval = 1000;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa düzgün müddət daxil edin!");
            }
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            RezervEt(button4, ref otaq1_sure, label3, textBox2.Text);
        }

       
        private void button5_Click(object sender, EventArgs e)
        {
            RezervEt(button5, ref otaq2_sure, label4, textBox2.Text);
        }

        
        private void button6_Click(object sender, EventArgs e)
        {
            RezervEt(button6, ref otaq3_sure, label5, textBox2.Text);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            RezervEt(button6, ref otaq3_sure, label5, textBox2.Text);
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            RezervEt(button1, ref otaq4_sure, label8, textBox2.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RezervEt(button1, ref otaq4_sure, label8, textBox2.Text);
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            RezervEt(button2, ref otaq5_sure, label6, textBox2.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RezervEt(button2, ref otaq5_sure, label6, textBox2.Text);
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            RezervEt(button3, ref otaq6_sure, label7, textBox2.Text);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            RezervEt(button3, ref otaq6_sure, label7, textBox2.Text);
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Otaq 1
            if (otaq1_sure > 0)
            {
                otaq1_sure--;
                label3.Text = otaq1_sure.ToString();
                if (otaq1_sure == 0)
                {
                    button4.Enabled = true;
                    button4.BackColor = SystemColors.Control;
                    label3.Text = "0";
                }
            }

          
            if (otaq2_sure > 0)
            {
                otaq2_sure--;
                label4.Text = otaq2_sure.ToString();
                if (otaq2_sure == 0)
                {
                    button5.Enabled = true;
                    button5.BackColor = SystemColors.Control;
                    label4.Text = "0";
                }
            }

           
            if (otaq3_sure > 0)
            {
                otaq3_sure--;
                label5.Text = otaq3_sure.ToString();
                if (otaq3_sure == 0)
                {
                    button6.Enabled = true;
                    button6.BackColor = SystemColors.Control;
                    label5.Text = "0";
                }
            }

            
            if (otaq4_sure > 0)
            {
                otaq4_sure--;
                label8.Text = otaq4_sure.ToString();
                if (otaq4_sure == 0)
                {
                    button1.Enabled = true;
                    button1.BackColor = SystemColors.Control;
                    label8.Text = "0";
                }
            }

           
            if (otaq5_sure > 0)
            {
                otaq5_sure--;
                label6.Text = otaq5_sure.ToString();
                if (otaq5_sure == 0)
                {
                    button2.Enabled = true;
                    button2.BackColor = SystemColors.Control;
                    label6.Text = "0";
                }
            }

           
            if (otaq6_sure > 0)
            {
                otaq6_sure--;
                label7.Text = otaq6_sure.ToString();
                if (otaq6_sure == 0)
                {
                    button3.Enabled = true;
                    button3.BackColor = SystemColors.Control;
                    label7.Text = "0";
                }
            }
        }
    }
}
