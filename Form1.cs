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
using System.Reflection.Emit;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TurnOff.BringToFront();// ensures that off button will always be on top of all elements
            label18.Text = "View Count";

            fillChart();

            Random rnd = new Random();
            int NewComments = rnd.Next(0, 867);  // creates a number between for new comments
            int Followers = rnd.Next(1, 137);   // creates a number between 1 and 6
            int Unfollowed = rnd.Next(42);     // creates a number between 0 and 51
            int UniqueViewers = rnd.Next(0, 867);
            float Earnings = rnd.Next(0, 9999);
            float TopGrossEarnings = rnd.Next(10000, 90867);
            this.label55.Text = "+ " + Followers.ToString();
            this.label60.Text = "- " + Unfollowed.ToString();
            this.label56.Text = "+ " + NewComments.ToString();
            this.label54.Text = "+ " + UniqueViewers.ToString();
            this.label52.Text = "+ £" + Earnings.ToString();
            this.label53.Text = "+ £" + TopGrossEarnings.ToString();
            
        }

      

        // ////////////////////////////////////////////////////////////////////////////
        // Menu buttons

        private void loadLogoPicture(object sender, EventArgs e)// loads logo of chosen company 
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Logo.Load(openFileDialog1.FileName);
            }

        }
        private void ViewCount_Click(object sender, EventArgs e)
        {
        
                MessageBox.Show("Hi, im button, have no purpuse yet ");
                MessageBox.Show("Eventually i will show more detail information about Views and break it down ");

            // Do something  

        }

        private void SocialMediaReach(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, im button, have no purpuse yet ");
            MessageBox.Show("Eventually i will show more detail information about media reach and break it down ");

        }

        private void PostClick(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, im button, have no purpuse yet ");
            MessageBox.Show("Eventually i will show more detail information about posts and break it down ");

        }

        private void FollowersClick(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, im button, have no purpuse yet ");
            MessageBox.Show("Eventually i will show more detail information about followers and break it down ");

        }

        private void InteractionClick(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, im button, have no purpuse yet ");
            MessageBox.Show("Eventually i will show more detail information about interactions and break it down ");

        }

        private void LikesClick(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, im button, have no purpuse yet ");
            MessageBox.Show("Eventually i will show more detail information about likes and break it down ");

        }

        private void DislikesClick(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, im button, have no purpuse yet ");
            MessageBox.Show("Eventually i will show more detail information about dislikes and break it down ");

        }
        private void AverageLikes(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, im button, have no purpuse yet ");
            MessageBox.Show("Eventually i will show more detail information about likes and break it down ");
        }

        private void AverageDislikes(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, im button, have no purpuse yet ");
            MessageBox.Show("Eventually i will show more detail information about dislikes and break it down ");
        }
        private void AverageInteractionsClick(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, im button, have no purpuse yet ");
            MessageBox.Show("Eventually i will show more detail information about interactions and break it down ");
        }

        private void AverageIncomeClick(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, im button, have no purpuse yet ");
            MessageBox.Show("Eventually i will show more detail information about income and break it down ");
        }

        /// 
        /// //////////////////////////////////////////////////////
        /// 
       

      
        public static DialogResult textbox1(string title, string promptText, ref string value)
        {
            Form form = new Form();
            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
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

        }// Code that is used to change social media name with pop up box


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

        private void FaceBookButton(object sender, EventArgs e)
        {
            /////Dashboard Random Generator Segment
            Random rnd = new Random();
            int NewComments = rnd.Next(0, 8670);  // creates a number between for new comments
            int Followers = rnd.Next(1, 1370);   // creates a number for  new followers
            int Unfollowed = rnd.Next(420);     // creates a number for unfollowed
            int UniqueViewers = rnd.Next(0, 8670); // creates a number Unique viewers
            float Earnings = rnd.Next(0, 99990); // creates a number for Earnings
            float TopGrossEarnings = rnd.Next(100000, 908670); // creates a number for Top gross post earnings
            this.label55.Text = "+ " + Followers.ToString();
            this.label60.Text = "- " + Unfollowed.ToString();
            this.label56.Text = "+ " + NewComments.ToString();
            this.label54.Text = "+ " + UniqueViewers.ToString();
            this.label52.Text = "+ £" + Earnings.ToString();
            this.label53.Text = "+ £" + TopGrossEarnings.ToString();

           

            //
            //Setting

            label1.BackColor = Color.FromArgb(46, 55, 77);
            //
            ////Bottom Segment
            ///
            int RandomViews = rnd.Next(0,9999990);
            label1.Text= RandomViews.ToString() + " People have seen this post";
            int RandomReach = rnd.Next(0, 999999);
            label2.Text = RandomReach.ToString() + " Times was been displayed ";
            int RandomPost = rnd.Next(0, 999999);
            label3.Text = RandomPost.ToString() + " Were made";
            int RandomFollowers = rnd.Next(0, 999999);
            label4.Text = RandomFollowers.ToString() + " Are following currently";
            int RandomInteractions = rnd.Next(0, 99999);
            label5.Text = RandomInteractions.ToString() + " Total interactions";
            int RandomLikes = rnd.Next(0, 999999);
            label6.Text = RandomLikes.ToString() + " Total Likes";
            int RandomDislikes = rnd.Next(0, 999999);
            label7.Text = RandomDislikes.ToString() + " Total Disdikes";
            int RandomAveragaLikes = rnd.Next(0, 9999);
            label8.Text = RandomAveragaLikes.ToString() + " Average Likes per post";
            int RandomAveragaDislikes = rnd.Next(0, 9999);
            label9.Text = RandomAveragaDislikes.ToString() + " Average Dislikes per post";
            int RandomAveragaInteractions = rnd.Next(0, 99999);
            label10.Text = RandomAveragaInteractions.ToString() + " Average Viewer interactions";
            int RandomAveragaIncome = rnd.Next(0, 99);
            label11.Text = "The average income from post is £" + RandomAveragaIncome.ToString() ;

            //// Dashboard segment
            DashboardViews.Text = RandomViews.ToString();
            double averageFollower;
            averageFollower = (RandomFollowers / 9.45);
            DashboardFollowerInteraction.Text = Math.Round(averageFollower, mode: MidpointRounding.AwayFromZero).ToString();// calculates average follower interactions
            DashboardFollowers.Text = RandomFollowers.ToString();
            DashboardLikes.Text = RandomLikes.ToString();
            DashboardDislikes.Text = RandomDislikes.ToString();
        }// pre-generated social media entities
    

        private void youtubeButton(object sender, EventArgs e)
        {
            /////Dashboard Random Generator Segment
            Random rnd = new Random();
            int NewComments = rnd.Next(0, 8670);  // creates a number between for new comments
            int Followers = rnd.Next(1, 1370);   // creates a number for  new followers
            int Unfollowed = rnd.Next(420);     // creates a number for unfollowed
            int UniqueViewers = rnd.Next(0, 8670); // creates a number Unique viewers
            float Earnings = rnd.Next(0, 99990); // creates a number for Earnings
            float TopGrossEarnings = rnd.Next(100000, 908670); // creates a number for Top gross post earnings
            this.label55.Text = "+ " + Followers.ToString();
            this.label60.Text = "- " + Unfollowed.ToString();
            this.label56.Text = "+ " + NewComments.ToString();
            this.label54.Text = "+ " + UniqueViewers.ToString();
            this.label52.Text = "+ £" + Earnings.ToString();
            this.label53.Text = "+ £" + TopGrossEarnings.ToString();



            //
            //Setting

            label1.BackColor = Color.FromArgb(46, 55, 77);
            //
            ////Bottom Segment
            ///
            int RandomViews = rnd.Next(0, 9999990);
            label1.Text = RandomViews.ToString() + " People have seen this post";
            int RandomReach = rnd.Next(0, 999999);
            label2.Text = RandomReach.ToString() + " Times was been displayed ";
            int RandomPost = rnd.Next(0, 999999);
            label3.Text = RandomPost.ToString() + " Were made";
            int RandomFollowers = rnd.Next(0, 999999);
            label4.Text = RandomFollowers.ToString() + " Are following currently";
            int RandomInteractions = rnd.Next(0, 99999);
            label5.Text = RandomInteractions.ToString() + " Total interactions";
            int RandomLikes = rnd.Next(0, 999999);
            label6.Text = RandomLikes.ToString() + " Total Likes";
            int RandomDislikes = rnd.Next(0, 999999);
            label7.Text = RandomDislikes.ToString() + " Total Disdikes";
            int RandomAveragaLikes = rnd.Next(0, 9999);
            label8.Text = RandomAveragaLikes.ToString() + " Average Likes per post";
            int RandomAveragaDislikes = rnd.Next(0, 9999);
            label9.Text = RandomAveragaDislikes.ToString() + " Average Dislikes per post";
            int RandomAveragaInteractions = rnd.Next(0, 99999);
            label10.Text = RandomAveragaInteractions.ToString() + " Average Viewer interactions";
            int RandomAveragaIncome = rnd.Next(0, 99);
            label11.Text = "The average income from post is £" + RandomAveragaIncome.ToString();

            //// Dashboard segment
            DashboardViews.Text = RandomViews.ToString();
            double averageFollower;
            averageFollower = (RandomFollowers / 9.45);
            DashboardFollowerInteraction.Text = Math.Round(averageFollower, mode: MidpointRounding.AwayFromZero).ToString();// calculates average follower interactions
            DashboardFollowers.Text = RandomFollowers.ToString();
            DashboardLikes.Text = RandomLikes.ToString();
            DashboardDislikes.Text = RandomDislikes.ToString();
        }// pre-generated social media entities

        private void instagramButton(object sender, EventArgs e)
        {
            /////Dashboard Random Generator Segment
            Random rnd = new Random();
            int NewComments = rnd.Next(0, 8670);  // creates a number between for new comments
            int Followers = rnd.Next(1, 1370);   // creates a number for  new followers
            int Unfollowed = rnd.Next(420);     // creates a number for unfollowed
            int UniqueViewers = rnd.Next(0, 8670); // creates a number Unique viewers
            float Earnings = rnd.Next(0, 99990); // creates a number for Earnings
            float TopGrossEarnings = rnd.Next(100000, 908670); // creates a number for Top gross post earnings
            this.label55.Text = "+ " + Followers.ToString();
            this.label60.Text = "- " + Unfollowed.ToString();
            this.label56.Text = "+ " + NewComments.ToString();
            this.label54.Text = "+ " + UniqueViewers.ToString();
            this.label52.Text = "+ £" + Earnings.ToString();
            this.label53.Text = "+ £" + TopGrossEarnings.ToString();



            //
            //Setting

            label1.BackColor = Color.FromArgb(46, 55, 77);
            //
            ////Bottom Segment
            ///
            int RandomViews = rnd.Next(0, 9999990);
            label1.Text = RandomViews.ToString() + " People have seen this post";
            int RandomReach = rnd.Next(0, 999999);
            label2.Text = RandomReach.ToString() + " Times was been displayed ";
            int RandomPost = rnd.Next(0, 999999);
            label3.Text = RandomPost.ToString() + " Were made";
            int RandomFollowers = rnd.Next(0, 999999);
            label4.Text = RandomFollowers.ToString() + " Are following currently";
            int RandomInteractions = rnd.Next(0, 99999);
            label5.Text = RandomInteractions.ToString() + " Total interactions";
            int RandomLikes = rnd.Next(0, 999999);
            label6.Text = RandomLikes.ToString() + " Total Likes";
            int RandomDislikes = rnd.Next(0, 999999);
            label7.Text = RandomDislikes.ToString() + " Total Disdikes";
            int RandomAveragaLikes = rnd.Next(0, 9999);
            label8.Text = RandomAveragaLikes.ToString() + " Average Likes per post";
            int RandomAveragaDislikes = rnd.Next(0, 9999);
            label9.Text = RandomAveragaDislikes.ToString() + " Average Dislikes per post";
            int RandomAveragaInteractions = rnd.Next(0, 99999);
            label10.Text = RandomAveragaInteractions.ToString() + " Average Viewer interactions";
            int RandomAveragaIncome = rnd.Next(0, 99);
            label11.Text = "The average income from post is £" + RandomAveragaIncome.ToString();

            //// Dashboard segment
            DashboardViews.Text = RandomViews.ToString();
            double averageFollower;
            averageFollower = (RandomFollowers / 9.45);
            DashboardFollowerInteraction.Text = Math.Round(averageFollower, mode: MidpointRounding.AwayFromZero).ToString();// calculates average follower interactions
            DashboardFollowers.Text = RandomFollowers.ToString();
            DashboardLikes.Text = RandomLikes.ToString();
            DashboardDislikes.Text = RandomDislikes.ToString();
        }// pre-generated social media entities

        private void RedditButton(object sender, EventArgs e)
        {
            /////Dashboard Random Generator Segment
            Random rnd = new Random();
            int NewComments = rnd.Next(0, 8670);  // creates a number between for new comments
            int Followers = rnd.Next(1, 1370);   // creates a number for  new followers
            int Unfollowed = rnd.Next(420);     // creates a number for unfollowed
            int UniqueViewers = rnd.Next(0, 8670); // creates a number Unique viewers
            float Earnings = rnd.Next(0, 99990); // creates a number for Earnings
            float TopGrossEarnings = rnd.Next(100000, 908670); // creates a number for Top gross post earnings
            this.label55.Text = "+ " + Followers.ToString();
            this.label60.Text = "- " + Unfollowed.ToString();
            this.label56.Text = "+ " + NewComments.ToString();
            this.label54.Text = "+ " + UniqueViewers.ToString();
            this.label52.Text = "+ £" + Earnings.ToString();
            this.label53.Text = "+ £" + TopGrossEarnings.ToString();



            //
            //Setting

            label1.BackColor = Color.FromArgb(46, 55, 77);
            //
            ////Bottom Segment
            ///
            int RandomViews = rnd.Next(0, 9999990);
            label1.Text = RandomViews.ToString() + " People have seen this post";
            int RandomReach = rnd.Next(0, 999999);
            label2.Text = RandomReach.ToString() + " Times was been displayed ";
            int RandomPost = rnd.Next(0, 999999);
            label3.Text = RandomPost.ToString() + " Were made";
            int RandomFollowers = rnd.Next(0, 999999);
            label4.Text = RandomFollowers.ToString() + " Are following currently";
            int RandomInteractions = rnd.Next(0, 99999);
            label5.Text = RandomInteractions.ToString() + " Total interactions";
            int RandomLikes = rnd.Next(0, 999999);
            label6.Text = RandomLikes.ToString() + " Total Likes";
            int RandomDislikes = rnd.Next(0, 999999);
            label7.Text = RandomDislikes.ToString() + " Total Disdikes";
            int RandomAveragaLikes = rnd.Next(0, 9999);
            label8.Text = RandomAveragaLikes.ToString() + " Average Likes per post";
            int RandomAveragaDislikes = rnd.Next(0, 9999);
            label9.Text = RandomAveragaDislikes.ToString() + " Average Dislikes per post";
            int RandomAveragaInteractions = rnd.Next(0, 99999);
            label10.Text = RandomAveragaInteractions.ToString() + " Average Viewer interactions";
            int RandomAveragaIncome = rnd.Next(0, 99);
            label11.Text = "The average income from post is £" + RandomAveragaIncome.ToString();

            //// Dashboard segment
            DashboardViews.Text = RandomViews.ToString();
            double averageFollower;
            averageFollower = (RandomFollowers / 9.45);
            DashboardFollowerInteraction.Text = Math.Round(averageFollower, mode: MidpointRounding.AwayFromZero).ToString();// calculates average follower interactions
            DashboardFollowers.Text = RandomFollowers.ToString();
            DashboardLikes.Text = RandomLikes.ToString();
            DashboardDislikes.Text = RandomDislikes.ToString();
        }// pre-generated social media entities

        private void SettingButton(object sender, EventArgs e)// settings button with possible setting options 
        {
            MessageBox.Show("I dont do anthing yet! Eventually i will show more setting options and much more ");

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)// main layout panel for creating dashboard
        {

        }
        private void BottomLayerSocialMediaName(object sender, EventArgs e)
        {

        }// might be neccesary for future development but atm blank

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Reset segment for all reset buttons


        private void ResetViewCount(object sender, EventArgs e)
        {

            if (true)
            {

                ViewCountInput.Text = "0";
                label1.Text = "0";
            }


        }
        private void ResetReach(object sender, EventArgs e)
        {
            if (true)
            {

                ReachInput.Text = "0";
                label2.Text = "0";
            }
        }

        private void ResetPost(object sender, EventArgs e)
        {
            if (true)
            {

                PostInput.Text = "0";
                label3.Text = "0";
            }
        }

        private void ResetFollowers(object sender, EventArgs e)
        {
            if (true)
            {

                textBox4.Text = "0";
                label4.Text = "0";
            }
        }

        private void ResetInteractions(object sender, EventArgs e)
        {
            if (true)
            {

                textBox5.Text = "0";
                label5.Text = "0";
            }
        }

        private void ResetLikes(object sender, EventArgs e)
        {
            if (true)
            {

                ReachInput.Text = "0";
                label6.Text = "0";
            }
        }

        private void ResetDislikes(object sender, EventArgs e)
        {
            if (true)
            {

                PostInput.Text = "0";
                label7.Text = "0";
            }
        }

        private void ResetAverageLikes(object sender, EventArgs e)
        {
            if (true)
            {

                InteractionInput.Text = "0";
                label8.Text = "0";
            }
        }

        private void ResetAverageDislikes(object sender, EventArgs e)
        {
            if (true)
            {

                LikesInput.Text = "0";
                label9.Text = "0";
            }
        }

        private void ResetAverageInteractions(object sender, EventArgs e)
        {
            if (true)
            {

                AverageUserInteractionInput.Text = "0";
                label10.Text = "0";
            }
        }
        private void ResetAverageIncome(object sender, EventArgs e)
        {
            if (true)
            {

                AverageIncomeInpute.Text = "0";
                label11.Text = "0";
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Input segment for all data being process

        private void ViewCountInputBox(object sender, EventArgs e)
        {

            try
            {
                string var;
                var = ViewCountInput.Text;
                this.label1.Text = var + " People have seen this post";
                label1.BackColor = Color.FromArgb(46, 55, 77);
                int viewCount;
                viewCount = int.Parse(ViewCountInput.Text);
                DashboardViews.Text = ViewCountInput.Text;


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
                    throw new Exception();// an exception in case of user entering invalid input aka strings
                    
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

        private void InputBoxPost(object sender, EventArgs e)
        {
            try
            {
                string var;
                var = PostInput.Text;
                this.label3.Text = var + " Posts were made";
                int Post;
                Post = int.Parse(PostInput.Text);



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

        private void InputBoxFollowers(object sender, EventArgs e)
        {
            try
            {
                string var;
                var = FollowersInput.Text;
                this.label4.Text = var + " Are following currently";
                int Followers;
                Followers = int.Parse(FollowersInput.Text);
                DashboardFollowers.Text = var;

                double averageFollower;
                averageFollower = (Followers / 9.45);
                DashboardFollowerInteraction.Text = Math.Round(averageFollower, mode: MidpointRounding.AwayFromZero).ToString();// calculates average follower interactions



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

        private void InputBoxInteractions(object sender, EventArgs e)
        {
            try
            {
                string var;
                var = InteractionInput.Text;
                this.label5.Text = var + " Total interactions";
                int Interactions;
                Interactions = int.Parse(InteractionInput.Text);



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

        private void InputBoxLikes(object sender, EventArgs e)
        {
            try
            {
                string var;
                var = LikesInput.Text;
                this.label6.Text = var + " Total Likes";
                int likes;
                likes = int.Parse(LikesInput.Text);
                this.DashboardLikes.Text = var;// dashboard likes



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
                var = DislikesInpute.Text;
                this.label7.Text = var + " Total Dislikes";
                int Dislikes;
                Dislikes = int.Parse(DislikesInpute.Text);
                this.DashboardDislikes.Text = var;


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

        private void InputBoxAverageLikes(object sender, EventArgs e)
        {
            try
            {
                string var;
                var = AverageLikesInpute.Text;
                this.label8.Text = var + " Average Likes per post";
                int Averagelikes;
                Averagelikes = int.Parse(AverageLikesInpute.Text);

                string var1;
                var1 = LikesInput.Text;
                this.label6.Text = var1 + " Total Likes ";
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

        private void InputBoxAverageDislikes(object sender, EventArgs e)
        {
            try
            {
                string var;
                var = AverageDislikesInput.Text;
                this.label9.Text = var + " Average Dislikes per post";
                int AverageDislikes;
                AverageDislikes = int.Parse(AverageDislikesInput.Text);

                string var1;
                var1 = DislikesInpute.Text;
                this.label7.Text = var1 + " Total Dislikes";
                int likes;
                likes = int.Parse(LikesInput.Text);


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

        private void InputBoxAverageUserInteraction(object sender, EventArgs e)
        {
            try
            {
                string var;
                var = AverageUserInteractionInput.Text;
                this.label10.Text = var + " Average Viewer interactions";
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

        private void InputBoxAverageIncomeFromPost(object sender, EventArgs e)
        {

            try
            {
                string var;
                var = AverageIncomeInpute.Text;
                this.label11.Text = "The average income from post is £" + var;
                int income;
                income = int.Parse(AverageIncomeInpute.Text);

                if (income < 0)
                {
                    MessageBox.Show(" You can only enter numbers!");
                }
                else if (income > 99999999)
                {
                    MessageBox.Show(" You have reached character limit!");
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(" You can only enter numbers!");
            }
        }
        ///
        ///////////////////////////////////////////////////////////////////////////////////////////
        ///
        //fillChart method  
        private void fillChart()
        {
            //AddXY value in chart1 in series named as Viewer Demographics
            Random rnd = new Random();
            int age10 = rnd.Next(10, 10000);
            int age20 = rnd.Next(20, 20000);
            int age30 = rnd.Next(30, 15888);
            int age40 = rnd.Next(40, 22222);
            int age50 = rnd.Next(0, 12230);
            chart1.Series["Age group"].Points.AddXY("10", age10);
            chart1.Series["Age group"].Points.AddXY("20-30", age20);
            chart1.Series["Age group"].Points.AddXY("31-40", age30);
            chart1.Series["Age group"].Points.AddXY("41-50", age40);
            chart1.Series["Age group"].Points.AddXY("51+", age50);

            //chart title  
            chart1.Titles.Add("Viewer Demographics");
        }

        // //////

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



        }//// form shutdown button

    }
}   
