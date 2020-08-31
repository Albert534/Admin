using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainGUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Height = button2.Height;
            panel2.Top = button2.Top;
            letter1.Show();
            menu1.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Height = button1.Height;
            panel2.Top = button1.Top;
            menu1.Show();
            letter1.Hide();
            pictureBox2.Hide();
                
            
        }
            private void panel4_Paint(object sender, PaintEventArgs e)
            {

            }

        private void menu1_Load(object sender, EventArgs e)
        {

        }

        private void menu2_Load(object sender, EventArgs e)
        {

        }

        private void menu2_Load_1(object sender, EventArgs e)
        {

        }

       
        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Height = button3.Height;
            panel2.Top = button3.Top;
            pictureBox2.Show();
            panel2.Show();
            
            menu1.Hide();

        }

        private void menu1_Load_1(object sender, EventArgs e)
        {

        }

        private void letter1_Load(object sender, EventArgs e)
        {

        }
    }

    } 