using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasKagitMakas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // pictureBox1.Image = TasKagitMakas.Properties.Resources.tas;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }
        Random randomize = new Random();
        int count;
        int i = 1;
        int oyuncu_hamle;
        int[] skor = new int[2];
        private async void vur_button_Click(object sender, EventArgs e)
        {   
            //timer1.Start();

            vur_button.Enabled = false;
            count = randomize.Next(0, 3);
            while (i<4)
            {
                labeldeneme.Text = (4-i).ToString() + " !";
                if (i == 1)
                {
                    pictureBox1.Image = TasKagitMakas.Properties.Resources.tas2;
                    pictureBox2.Image = TasKagitMakas.Properties.Resources.tas;
                }
                else if (i == 2)
                {
                    pictureBox1.Image = TasKagitMakas.Properties.Resources.kagit2;
                    pictureBox2.Image = TasKagitMakas.Properties.Resources.kagit;
                }
                else if (i == 3)
                {
                    pictureBox1.Image = TasKagitMakas.Properties.Resources.makas2;
                    pictureBox2.Image = TasKagitMakas.Properties.Resources.makas;
                }
                i++;
                await Task.Delay(200);
            }
            i = 1;
            
            
            if (radioButton1.Checked == true)
            {
                pictureBox1.Image = TasKagitMakas.Properties.Resources.tas2;
                oyuncu_hamle = 0;
            }
            else if (radioButton2.Checked == true)
            {
                pictureBox1.Image = TasKagitMakas.Properties.Resources.kagit2;
                oyuncu_hamle = 1;
            }
            else if (radioButton3.Checked == true)
            {
                pictureBox1.Image = TasKagitMakas.Properties.Resources.makas2;
                oyuncu_hamle = 2;
            }

            if (count == 0)
            {
                pictureBox2.Image = TasKagitMakas.Properties.Resources.tas;
            }
            else if (count == 1)
            {
                pictureBox2.Image = TasKagitMakas.Properties.Resources.kagit;
            }
            else if (count == 2)
            {
                pictureBox2.Image = TasKagitMakas.Properties.Resources.makas;
            }

            if ((oyuncu_hamle+1) % 3 == count)
            {
                skor[1] += 1;
                labeldeneme.Text = "Kaybettin";
            }
            else if (oyuncu_hamle == count)
            {
                labeldeneme.Text = "Berabere";
            } 
            else 
            {
                skor[0] += 1;
                labeldeneme.Text = "Kazandın"; 
            }

            label1.Text = skor[0].ToString() + "-" + skor[1].ToString();

            if (skor[0] == 10)
            {
                MessageBox.Show("Kazandın Oleyyyyyy!");
                skor[0] = 0;
                skor[1] = 0;   
                panel1.Visible = true;
                panel3.Visible = true;
            }
            else if (skor[1] == 10)
            {
                MessageBox.Show("Kaybettin Haayıııırr!");
                skor[0] = 0;
                skor[1] = 0;
                panel1.Visible = true;
                panel3.Visible = true;
            }
            vur_button.Enabled = true;
        }

        private void baslat_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        int i_coklu = 0;
        int ikinci_oyuncu_hamle;
        private async void button3_Click(object sender, EventArgs e)
        {
            i_coklu++;

            //button3.Enabled = false;

            while (i_coklu < 4)
            {
                if (i_coklu == 1)
                {
                    if (radioButton6.Checked == true)
                    {
                        oyuncu_hamle = 0;
                    }
                    else if (radioButton5.Checked == true)
                    {
                        oyuncu_hamle = 1;
                    }
                    else if (radioButton4.Checked == true)
                    {
                        oyuncu_hamle = 2;
                    }

                    radioButton4.Visible = false;
                    radioButton5.Visible = false;
                    radioButton6.Visible = false;
                    radioButton7.Visible = true;
                    radioButton8.Visible = true;
                    radioButton9.Visible = true;
                }
                else if (i_coklu == 2)
                {
                    if (radioButton7.Checked == true)
                    {
                        ikinci_oyuncu_hamle = 0;
                    }
                    else if (radioButton8.Checked == true)
                    {
                        ikinci_oyuncu_hamle = 1;
                    }
                    else if (radioButton9.Checked == true)
                    {
                        ikinci_oyuncu_hamle = 2;
                    }
                    radioButton7.Visible = false;
                    radioButton8.Visible = false;
                    radioButton9.Visible = false;
                }
                else
                {
                    i_coklu = 0;
                    while (i < 4)
                    {
                        label2.Text = (4 - i).ToString() + " !";
                        if (i == 1)
                        {
                            pictureBox4.Image = TasKagitMakas.Properties.Resources.tas2;
                            pictureBox5.Image = TasKagitMakas.Properties.Resources.tas;
                        }
                        else if (i == 2)
                        {
                            pictureBox4.Image = TasKagitMakas.Properties.Resources.kagit2;
                            pictureBox5.Image = TasKagitMakas.Properties.Resources.kagit;
                        }
                        else if (i == 3)
                        {
                            pictureBox4.Image = TasKagitMakas.Properties.Resources.makas2;
                            pictureBox5.Image = TasKagitMakas.Properties.Resources.makas;
                        }
                        i++;
                        await Task.Delay(200);
                    }
                    i = 1;

                    if (oyuncu_hamle == 0)
                    {
                        pictureBox4.Image = TasKagitMakas.Properties.Resources.tas2;
                    }
                    else if (oyuncu_hamle == 1)
                    {
                        pictureBox4.Image = TasKagitMakas.Properties.Resources.kagit2;
                    }
                    else if (oyuncu_hamle == 2)
                    {
                        pictureBox4.Image = TasKagitMakas.Properties.Resources.makas2;
                    }

                    if (ikinci_oyuncu_hamle == 0)
                    {
                        pictureBox5.Image = TasKagitMakas.Properties.Resources.tas2;
                    }
                    else if (ikinci_oyuncu_hamle == 1)
                    {
                        pictureBox5.Image = TasKagitMakas.Properties.Resources.kagit2;
                    }
                    else if (ikinci_oyuncu_hamle == 2)
                    {
                        pictureBox5.Image = TasKagitMakas.Properties.Resources.makas2;
                    }

                    if ((oyuncu_hamle + 1) % 3 == ikinci_oyuncu_hamle)
                    {
                        skor[1] += 1;
                        label2.Text = "2.Oyuncu";
                    }
                    else if (oyuncu_hamle == ikinci_oyuncu_hamle)
                    {
                        label2.Text = "Berabere";
                    }
                    else
                    {
                        skor[0] += 1;
                        label2.Text = "1.Oyuncu";
                    }

                    label3.Text = skor[0].ToString() + "-" + skor[1].ToString();

                    if (skor[0] == 10)
                    {
                        MessageBox.Show("1. Oyuncu Kazandın Oleyyyyyy!");
                        skor[0] = 0;
                        skor[1] = 0;
                        panel1.Visible = true;
                        panel2.Visible = true;
                    }
                    else if (skor[1] == 10)
                    {
                        MessageBox.Show("2. Oyuncu Kazandın Oleyyyyyy!");
                        skor[0] = 0;
                        skor[1] = 0;
                        panel1.Visible = true;
                        panel2.Visible = true;
                    }
                    radioButton4.Visible = true;
                    radioButton5.Visible = true;
                    radioButton6.Visible = true;
                }
                break;
            }
        }
    }
}
