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
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public System.Windows.Forms.IButtonControl AcceptButton { get; set; }
        public Form1()
        {

            InitializeComponent();
   
            //this.Closing += ShellWindow_Closing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TurnOff.BringToFront();// ensures that off button will always be on top of all elements
            label18.Text = "View Count";
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void loadLogoPicture(object sender, EventArgs e)// loads logo of chosen company 
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Logo.Load(openFileDialog1.FileName);
            }

        }


        public void openFileDialog1_FileOk(object sender, CancelEventArgs e)// triger for open file dialog command
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)/// place to display loaded logo
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

      
      
        public static DialogResult textbox1(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
            System.Windows.Forms.Button buttonOk = new System.Windows.Forms.Button();
            System.Windows.Forms.Button buttonCancel = new System.Windows.Forms.Button();
            form.Text = title;
            label.Text = promptText;
            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
            label.SetBounds(36, 36, 372, 13);
            textBox.SetBounds(36, 86, 700, 20);
            buttonOk.SetBounds(228, 160, 160, 60);
            buttonCancel.SetBounds(400, 160, 160, 60);
            label.AutoSize = true;
            form.ClientSize = new Size(796, 307);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;

        }
        private void SocialMeadiaNameChangeButton(object sender, EventArgs e)//Changes Social media name at the top of the page
        {
            string value = "";
            if (textbox1("Dialog Box", "What is the name of Social Media?", ref value) == DialogResult.OK)
            {
                SocialMediaName.Visible = true;
                SocialMediaName.Text = "" + value;

            }

        }

        private void ClearFormButton(object sender, EventArgs e)//clear form button, sets everything to zero
        {
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label9.Text = "0";
            label10.Text = "0";
            label11.Text = "0";
            ViewCountInput.Text= "0";
            ReachInput.Text = "0";
            PostInput.Text = "0";
            FollowersInput.Text = "0";
            InteractionInput.Text = "0";
            LikesInput.Text = "0";
            DislikesInpute.Text = "0";
            AverageLikesInpute.Text = "0";
            AverageDislikesInput.Text= "0";
            AverageUserInteractionInput.Text = "0";
            AverageIncomeInpute.Text = "0";
            


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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)// main layout panel for creating dashboard
        {

        }

        private void ViewCountInputBox(object sender, EventArgs e)
        {

            try
            {
                string var;
                var = ViewCountInput.Text;
                this.label1.Text = var + " People have seen this post" ;
                label1.BackColor = Color.FromArgb(46, 55, 77);   
                int viewCount;
                viewCount = int.Parse(ViewCountInput.Text);



                if (viewCount < 0)
                {
                    MessageBox.Show(" You can only enter numbers!");
                }
                else if (viewCount > 99999999)
                {
                    MessageBox.Show(" You have reached character limit!");
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(" You can only enter numbers!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ResetReach(object sender, EventArgs e)
        {
            if (true)
            {

                FollowersInput.Text = "0";
                label2.Text = "0";
            }
        }

        private void reset11(object sender, EventArgs e)
        {
            if (true)
            {

                AverageIncomeInpute.Text = "0";
                label11.Text = "0";
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

        private void ResetViewCount(object sender, EventArgs e)
        {

            if (true)
            {

                ViewCountInput.Text = "0";
                label1.Text = "0";
            }


        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (true)
            {

                textBox3.Text = "0";
                label3.Text = "0";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (true)
            {

                textBox4.Text = "0";
                label4.Text = "0";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (true)
            {

                textBox5.Text = "0";
                label5.Text = "0";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (true)
            {

                ReachInput.Text = "0";
                label6.Text = "0";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (true)
            {

                PostInput.Text = "0";
                label7.Text = "0";
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (true)
            {

                InteractionInput.Text = "0";
                label8.Text = "0";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (true)
            {

                LikesInput.Text = "0";
                label9.Text = "0";
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (true)
            {

                AverageUserInteractionInput.Text = "0";
                label10.Text = "0";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InputBoxReach(object sender, EventArgs e)
        {


            try
            {
                string var;
                var = ReachInput.Text;
                this.label2.Text = var + " Times was been displayed ";
                int SocialMediaReach;
                SocialMediaReach = int.Parse(ReachInput.Text);



                if (SocialMediaReach < 0)
                {
                    MessageBox.Show(" You can only enter numbers!");
                }
                else if (SocialMediaReach > 99999999)
                {
                    MessageBox.Show(" You have reached character limit!");
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(" You can only enter numbers!");
            }
        }

        private void TurnOff_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this Program?";
            string title = "Close Program";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();// shuts down application
            }
            else
            {
                // Do something  
            }



        }

        private void InputBoxAverageIncomeFromPost(object sender, EventArgs e)
        {

            try
            {
                string var;
                var = AverageLikesInpute.Text;
                this.label11.Text = var;
                int userInteractions;
                userInteractions = int.Parse(AverageIncomeInpute.Text);

                if (userInteractions < 0)
                {
                    MessageBox.Show(" You can only enter numbers!");
                }
                else if (userInteractions > 99999999)
                {
                    MessageBox.Show(" You have reached character limit!");
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(" You can only enter numbers!");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void ShellWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // if (MessageBox.Show("Any running migration task will be aborted.\nAre you sure you want to exit the application ?", "Exit Proventeq Migration Acclerator", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }


        private void ViewCount_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this Program?";
            string title = "Close Program";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            ViewCount.Text += MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                string var;
                var = "View Count";
                ViewCount.Text = var;
                string message1 = "Do you want eneter values manualy?";
                string title1 = "View Count";
                MessageBox.Show(message1, title1, buttons);

            }
            else
            {
                // Do something  
            }
        }

        private void InputBoxPost(object sender, EventArgs e)
        {
            try
            {
                string var;
                var = PostInput.Text;
                this.label3.Text = var + " Was posted";
                int Post;
                Post = int.Parse(ViewCountInput.Text);



                if (Post < 0)
                {
                    MessageBox.Show(" You can only enter numbers!");
                }
                else if (Post > 99999999)
                {
                    MessageBox.Show(" You have reached character limit!");
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(" You can only enter numbers!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void InputBoxFollowers(object sender, EventArgs e)
        {
            try
            {
                string var;
                var = FollowersInput.Text;
                this.label4.Text = var + " Are following currently";
                int Followers;
                Followers = int.Parse(FollowersInput.Text);



                if (Followers < 0)
                {
                    MessageBox.Show(" You can only enter numbers!");
                }
                else if (Followers > 99999999)
                {
                    MessageBox.Show(" You have reached character limit!");
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(" You can only enter numbers!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void InputBoxInteractions(object sender, EventArgs e)
        {
            try
            {
                string var;
                var = InteractionInput.Text;
                this.label5.Text = var + " Total interactions";
                int Interactions;
                Interactions = int.Parse(ViewCountInput.Text);



                if (Interactions < 0)
                {
                    MessageBox.Show(" You can only enter numbers!");
                }
                else if (Interactions > 99999999)
                {
                    MessageBox.Show(" You have reached character limit!");
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(" You can only enter numbers!");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void InputBoxLikes(object sender, EventArgs e)
        {
            try
            {
                string var;
                var = LikesInput.Text;
                this.label6.Text = var + " Total likes";
                int likes;
                likes = int.Parse(LikesInput.Text);



                if (likes < 0)
                {
                    MessageBox.Show(" You can only enter numbers!");
                }
                else if (likes > 99999999)
                {
                    MessageBox.Show(" You have reached character limit!");
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(" You can only enter numbers!");
            }
        }


        private void InputBoxDislikes(object sender, EventArgs e)
        {
            try
            {
                string var;
                var = PostInput.Text;
                this.label7.Text = var + " Total Dislikes";
                int Dislikes;
                Dislikes = int.Parse(DislikesInpute.Text);



                if (Dislikes < 0)
                {
                    MessageBox.Show(" You can only enter numbers!");
                }
                else if (Dislikes > 99999999)
                {
                    MessageBox.Show(" You have reached character limit!");
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(" You can only enter numbers!");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void InputBoxAverageLikes(object sender, EventArgs e)
        {
            try
            {
                string var;
                var = AverageLikesInpute.Text;
                this.label8.Text = var + " Average likes per post";
                int Averagelikes;
                Averagelikes = int.Parse(AverageLikesInpute.Text);

                string var1;
                var1 = LikesInput.Text;
                this.label6.Text = var1;
                int likes;
                likes = int.Parse(LikesInput.Text);


                if (Averagelikes < 0)
                {
                    MessageBox.Show(" You can only enter numbers!");
                }
                else if (Averagelikes > 99999999)
                {
                    MessageBox.Show(" You have reached character limit!");
                }

                if (likes < Averagelikes)
                    MessageBox.Show(" You cant have more average likes than likes!");


            }
            catch (System.Exception ex)
            {
                MessageBox.Show(" You can only enter numbers!");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void InputBoxAverageDislikes(object sender, EventArgs e)
        {
            try
            {
                string var;
                var = AverageDislikesInput.Text;
                this.label9.Text = var;
                int AverageDislikes;
                AverageDislikes = int.Parse(AverageDislikesInput.Text);

                string var1;
                var1 = ReachInput.Text;
                this.label6.Text = var1;
                int likes;
                likes = int.Parse(AverageLikesInpute.Text);


                if (AverageDislikes < 0)
                {
                    MessageBox.Show(" You can only enter numbers!");
                }
                else if (AverageDislikes > 99999999)
                {
                    MessageBox.Show(" You have reached character limit!");
                }

                if (likes < AverageDislikes)
                    MessageBox.Show(" You cant have more average Dislikes than likes!");

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(" You can only enter numbers!");
            }


        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void InputBoxAverageUserInteraction(object sender, EventArgs e)
        {
            try
            {
                string var;
                var = AverageUserInteractionInput.Text;
                this.label10.Text = var;
                int userInteractions;
                userInteractions = int.Parse(AverageUserInteractionInput.Text);

                if (userInteractions < 0)
                {
                    MessageBox.Show(" You can only enter numbers!");
                }
                else if (userInteractions > 99999999)
                {
                    MessageBox.Show(" You have reached character limit!");
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(" You can only enter numbers!");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ViewIcone(object sender, EventArgs e)
        {

        }

        private void ReachIcon(object sender, EventArgs e)
        {

        }

        private void PostIcon(object sender, EventArgs e)
        {

        }

        private void FollowerIcon(object sender, EventArgs e)
        {

        }

        private void InteractionIcon(object sender, EventArgs e)
        {

        }

        private void LikesIcon(object sender, EventArgs e)
        {

        }

        private void DislikeIcon(object sender, EventArgs e)
        {

        }

        private void AverageLikesIcon(object sender, EventArgs e)
        {

        }

        private void AverageDislikesIcon(object sender, EventArgs e)
        {

        }

        private void AverageInteractionIcon(object sender, EventArgs e)
        {

        }

        private void AverageIncomeIcon(object sender, EventArgs e)
        {

        }

        private void SocialMediaRename(object sender, EventArgs e)
        {
            
        }
    }
}   
