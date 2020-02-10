using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Random rand = new Random();
        static String[] arr_words = { "COMPUTER", "ALGORITHM", "PROGRAMMING", "KOBE", "BAABABBABABABA"};
        int pick;
        static String word;
        int mistakes = 5;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                pick = rand.Next(1, 4);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + pick);
            }
            random();
        }

        public void random()
        {
            word = arr_words[pick];
            StringBuilder wordChanger = new StringBuilder(word.ToString());

            for (int index = 1; index < wordChanger.Length -1; index++)
            {
                wordChanger[index] = '?';
            }
            Lbl_WordToShown.Text = wordChanger.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(word.Equals(textBox1.Text))
            {
                MessageBox.Show("Correct!");
                Lbl_WordToShown.Text = word;
                MessageBox.Show("Play another round");
                pick = rand.Next(1, 4);

                random();
                richTextBox1.Text = "";
                textBox1.Text = "";
                mistakes++;

                if (mistakes < 5)
                {
                    if (pictureBox2.Visible == false && mistakes == 1)
                    {
                        pictureBox2.Visible = true;
                    }
                    else if (pictureBox3.Visible == false && mistakes == 2)
                    {
                        pictureBox3.Visible = true;
                    }
                    else if (pictureBox4.Visible == false && mistakes == 3)
                    {
                        pictureBox4.Visible = true;
                    }
                    else if (pictureBox5.Visible == false && mistakes == 4)
                    {
                        pictureBox5.Visible = true;
                    }
                }
                else
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Wrong guess!");
                richTextBox1.Text = textBox1.Text + "\n" + richTextBox1.Text;
                mistakes--;
                if (mistakes == 4)
                {
                    pictureBox5.Visible = false;
                }
                else if (mistakes == 3)
                {
                    pictureBox4.Visible = false;
                }
                else if (mistakes == 2)
                {
                    pictureBox3.Visible = false;
                }
                else if (mistakes == 1)
                {
                    pictureBox2.Visible = false;
                }
                else if (mistakes == 0)
                {
                    pictureBox1.Visible = false;
                    MessageBox.Show("Game Over!");
                    Convert.To
                }  
            }
            textBox1.Text = "";
        }
    }
}
