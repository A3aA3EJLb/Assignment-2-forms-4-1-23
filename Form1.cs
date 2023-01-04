using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public System.Windows.Forms.IButtonControl AcceptButton { get; set; }
        public Form1()
        {
            
            InitializeComponent();
          //  string var;//this is how to pass text to text box
         //   var = textBox1.Text;//


           // int i;// this is how to pass intergar from textbox
          //  i = int.Parse(textBox1.Text);//
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }
     
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ViewCount_Button(object sender, EventArgs e)     
        {
    
        }
        private void insertText_Click(object sender, EventArgs e)
        {
           
        }

        private void loadLogoPicture(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Logo.Load(openFileDialog1.FileName);
            }
           
        }


        public void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
             
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
            try
            {
                string var;
                var = textBox1.Text;
                this.label1.Text = var;
                int i;
                i = int.Parse(textBox1.Text);
                int i = var;
               
                if (i < 0)
                { 
                    throw (new Exception ex(""));
                }
                    
                
                
                
               
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(" You can only enter numebers!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void reset2(object sender, EventArgs e)
        {
            if (true)
            {

                textBox2.Text = "0";
                label2.Text = "0";
            }
        }

        private void reset11(object sender, EventArgs e)
        {
            if (true)
            {

                textBox11.Text = "";
                label11.Text = "";
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (true)
            {
                
              textBox1.Text = "0";
              label1.Text = "0";
            }

            // int i;// this is how to pass intergar from textbox
            //   i = int.Parse(textBox1.Text);
            //  i = 0;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (true)
            {

                textBox1.Text = "0";
                label3.Text = "0";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (true)
            {

                textBox1.Text = "0";
                label4.Text = "0";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (true)
            {

                textBox1.Text = "0";
                label5.Text = "0";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (true)
            {

                textBox1.Text = "0";
                label6.Text = "0";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (true)
            {

                textBox1.Text = "0";
                label7.Text = "0";
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (true)
            {

                textBox1.Text = "0";
                label8.Text = "0";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (true)
            {

                textBox1.Text = "0";
                label9.Text = "0";
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (true)
            {

                textBox1.Text = "0";
                label10.Text = "0";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string var;
            var = textBox6.Text;
            this.label2.Text = var;
        }
    }
}
