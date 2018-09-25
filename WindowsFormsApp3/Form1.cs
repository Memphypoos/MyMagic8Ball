using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb1 = new PictureBox();
            pb1.ImageLocation = "";
            pb1.SizeMode = PictureBoxSizeMode.AutoSize;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == (textBox1.Text = "Enter your Question Here"))
                MessageBox.Show("Please enter a question.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else textBox1.Text = (" ");

            MessageBox.Show("Please enter a question.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else textBox2.Text = _8ball.response();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Closing Application...");
            this.Close();
        }
    }
}
