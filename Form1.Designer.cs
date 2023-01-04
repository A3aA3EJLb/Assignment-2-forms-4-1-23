using System;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ViewCount = new System.Windows.Forms.Button();
            this.pictureOpener = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button28 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button18 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button29 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewCount
            // 
            this.ViewCount.AutoSize = true;
            this.ViewCount.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ViewCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.ViewCount.Location = new System.Drawing.Point(3, 32);
            this.ViewCount.Name = "ViewCount";
            this.ViewCount.Size = new System.Drawing.Size(157, 23);
            this.ViewCount.TabIndex = 0;
            this.ViewCount.Text = "View Count";
            this.ViewCount.UseVisualStyleBackColor = true;
            // 
            // pictureOpener
            // 
            this.pictureOpener.AutoSize = true;
            this.pictureOpener.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.pictureOpener.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureOpener.Location = new System.Drawing.Point(3, 3);
            this.pictureOpener.Name = "pictureOpener";
            this.pictureOpener.Size = new System.Drawing.Size(157, 23);
            this.pictureOpener.TabIndex = 1;
            this.pictureOpener.Text = "Load Logo";
            this.pictureOpener.UseVisualStyleBackColor = true;
            this.pictureOpener.Click += new System.EventHandler(this.loadLogoPicture);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.IndianRed;
            this.flowLayoutPanel1.Controls.Add(this.pictureOpener);
            this.flowLayoutPanel1.Controls.Add(this.ViewCount);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.button9);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Controls.Add(this.button10);
            this.flowLayoutPanel1.Controls.Add(this.button11);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button12);
            this.flowLayoutPanel1.Controls.Add(this.button13);
            this.flowLayoutPanel1.Controls.Add(this.button15);
            this.flowLayoutPanel1.Controls.Add(this.button16);
            this.flowLayoutPanel1.Controls.Add(this.button17);
            this.flowLayoutPanel1.Controls.Add(this.button14);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(181, 550);
            this.flowLayoutPanel1.TabIndex = 9;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.Location = new System.Drawing.Point(3, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Social media reach";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button5.Dock = System.Windows.Forms.DockStyle.Left;
            this.button5.Location = new System.Drawing.Point(3, 90);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Posts";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button6.Dock = System.Windows.Forms.DockStyle.Left;
            this.button6.Location = new System.Drawing.Point(3, 119);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(157, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Followers";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button9.Dock = System.Windows.Forms.DockStyle.Left;
            this.button9.Location = new System.Drawing.Point(3, 148);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(157, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "Post Interactions";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(3, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Likes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.Location = new System.Drawing.Point(3, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Dislikes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button7.Dock = System.Windows.Forms.DockStyle.Left;
            this.button7.Location = new System.Drawing.Point(3, 235);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(157, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Average Likes";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button8.Dock = System.Windows.Forms.DockStyle.Left;
            this.button8.Location = new System.Drawing.Point(3, 264);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(157, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "Average Dislikes";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button10.Dock = System.Windows.Forms.DockStyle.Left;
            this.button10.Location = new System.Drawing.Point(3, 293);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(157, 23);
            this.button10.TabIndex = 10;
            this.button10.Text = "Average Follower Interactions";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button11.AutoSize = true;
            this.button11.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button11.Location = new System.Drawing.Point(3, 322);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(157, 23);
            this.button11.TabIndex = 11;
            this.button11.Text = "Average Posts Income  ";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Location = new System.Drawing.Point(3, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Social Media Name";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button12
            // 
            this.button12.AutoSize = true;
            this.button12.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button12.Dock = System.Windows.Forms.DockStyle.Left;
            this.button12.Location = new System.Drawing.Point(3, 380);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(157, 23);
            this.button12.TabIndex = 13;
            this.button12.Text = "Clear Form";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.AutoSize = true;
            this.button13.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button13.Dock = System.Windows.Forms.DockStyle.Left;
            this.button13.Location = new System.Drawing.Point(3, 409);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(157, 23);
            this.button13.TabIndex = 14;
            this.button13.Text = "FACEBOOK";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button15
            // 
            this.button15.AutoSize = true;
            this.button15.Dock = System.Windows.Forms.DockStyle.Left;
            this.button15.Location = new System.Drawing.Point(3, 438);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(157, 23);
            this.button15.TabIndex = 16;
            this.button15.Text = "YOUTUBE";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.AutoSize = true;
            this.button16.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button16.Dock = System.Windows.Forms.DockStyle.Left;
            this.button16.Location = new System.Drawing.Point(3, 467);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(157, 23);
            this.button16.TabIndex = 17;
            this.button16.Text = "INSTAGRAM";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.AutoSize = true;
            this.button17.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button17.Dock = System.Windows.Forms.DockStyle.Left;
            this.button17.Location = new System.Drawing.Point(3, 496);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(157, 23);
            this.button17.TabIndex = 18;
            this.button17.Text = "REDDIT";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button14
            // 
            this.button14.AutoSize = true;
            this.button14.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button14.Dock = System.Windows.Forms.DockStyle.Left;
            this.button14.Location = new System.Drawing.Point(3, 525);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(157, 23);
            this.button14.TabIndex = 19;
            this.button14.Text = "Average Posts Income  ";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Select picture";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Logo.Location = new System.Drawing.Point(0, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(181, 34);
            this.Logo.TabIndex = 10;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button20
            // 
            this.button20.AccessibleName = "reset";
            this.button20.Location = new System.Drawing.Point(655, 53);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(72, 27);
            this.button20.TabIndex = 5;
            this.button20.Text = "Reset";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(655, 113);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(72, 19);
            this.button19.TabIndex = 4;
            this.button19.Text = "Reset";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(273, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(655, 352);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(72, 20);
            this.button28.TabIndex = 13;
            this.button28.Text = "Reset";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.reset11);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(655, 321);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(72, 21);
            this.button27.TabIndex = 12;
            this.button27.Text = "Reset";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(655, 292);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(72, 21);
            this.button26.TabIndex = 11;
            this.button26.Text = "Reset";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(655, 263);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(72, 21);
            this.button25.TabIndex = 10;
            this.button25.Text = "Reset";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(655, 236);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(72, 21);
            this.button24.TabIndex = 9;
            this.button24.Text = "Reset";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(655, 206);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(72, 21);
            this.button23.TabIndex = 8;
            this.button23.Text = "Reset";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(655, 173);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(72, 21);
            this.button22.TabIndex = 7;
            this.button22.Text = "Reset";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(655, 138);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(72, 21);
            this.button21.TabIndex = 6;
            this.button21.Text = "Reset";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // textBox2
            // 
            this.textBox2.AccessibleName = "textbox1";
            this.textBox2.Location = new System.Drawing.Point(43, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(93, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(655, 86);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(74, 21);
            this.button18.TabIndex = 2;
            this.button18.Text = "Reset";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.reset2);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "textbox1";
            this.textBox1.Location = new System.Drawing.Point(43, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.tableLayoutPanel1.ColumnCount = 12;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 362F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.button18, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.button21, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.button22, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.button23, 7, 7);
            this.tableLayoutPanel1.Controls.Add(this.button24, 7, 8);
            this.tableLayoutPanel1.Controls.Add(this.button25, 7, 9);
            this.tableLayoutPanel1.Controls.Add(this.button26, 7, 10);
            this.tableLayoutPanel1.Controls.Add(this.button27, 7, 11);
            this.tableLayoutPanel1.Controls.Add(this.button28, 7, 12);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.button20, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.button19, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox7, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox8, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox9, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBox10, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.textBox11, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.textBox12, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.textBox13, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.textBox14, 2, 12);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 5, 8);
            this.tableLayoutPanel1.Controls.Add(this.label9, 5, 10);
            this.tableLayoutPanel1.Controls.Add(this.label10, 5, 11);
            this.tableLayoutPanel1.Controls.Add(this.label11, 5, 12);
            this.tableLayoutPanel1.Controls.Add(this.label1, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label13, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label14, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label15, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.label16, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 9, 13);
            this.tableLayoutPanel1.Controls.Add(this.progressBar2, 4, 10);
            this.tableLayoutPanel1.Controls.Add(this.label8, 5, 9);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 4, 9);
            this.tableLayoutPanel1.Controls.Add(this.button29, 10, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(178, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.11765F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1116, 812);
            this.tableLayoutPanel1.TabIndex = 11;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // textBox5
            // 
            this.textBox5.AccessibleName = "textbox1";
            this.textBox5.Location = new System.Drawing.Point(3, 794);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(14, 20);
            this.textBox5.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.AccessibleName = "textbox1";
            this.textBox4.Location = new System.Drawing.Point(23, 794);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(14, 20);
            this.textBox4.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.AccessibleName = "textbox1";
            this.textBox3.Location = new System.Drawing.Point(43, 794);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(93, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.AccessibleName = "textbox1";
            this.textBox7.Location = new System.Drawing.Point(43, 113);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(93, 20);
            this.textBox7.TabIndex = 17;
            // 
            // textBox8
            // 
            this.textBox8.AccessibleName = "textbox1";
            this.textBox8.Location = new System.Drawing.Point(43, 173);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(93, 20);
            this.textBox8.TabIndex = 18;
            // 
            // textBox9
            // 
            this.textBox9.AccessibleName = "textbox1";
            this.textBox9.Location = new System.Drawing.Point(43, 206);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(93, 20);
            this.textBox9.TabIndex = 19;
            // 
            // textBox10
            // 
            this.textBox10.AccessibleName = "textbox1";
            this.textBox10.Location = new System.Drawing.Point(43, 236);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(93, 20);
            this.textBox10.TabIndex = 20;
            // 
            // textBox11
            // 
            this.textBox11.AccessibleName = "textbox1";
            this.textBox11.Location = new System.Drawing.Point(43, 263);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(93, 20);
            this.textBox11.TabIndex = 21;
            // 
            // textBox12
            // 
            this.textBox12.AccessibleName = "textbox1";
            this.textBox12.Location = new System.Drawing.Point(43, 292);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(93, 20);
            this.textBox12.TabIndex = 22;
            // 
            // textBox13
            // 
            this.textBox13.AccessibleName = "textbox1";
            this.textBox13.Location = new System.Drawing.Point(43, 321);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(93, 20);
            this.textBox13.TabIndex = 23;
            // 
            // textBox14
            // 
            this.textBox14.AccessibleName = "textbox1";
            this.textBox14.Location = new System.Drawing.Point(43, 352);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(93, 20);
            this.textBox14.TabIndex = 24;
            // 
            // textBox6
            // 
            this.textBox6.AccessibleName = "textbox2";
            this.textBox6.Location = new System.Drawing.Point(43, 86);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(93, 20);
            this.textBox6.TabIndex = 12;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "label7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(273, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(273, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "label11";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Values";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(155, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Icons";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(410, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Displays Values";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(657, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Reset Button";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(403, 11);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label16.Size = new System.Drawing.Size(96, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Social media name";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(755, 378);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 84);
            this.listView1.TabIndex = 40;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(208, 292);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(59, 23);
            this.progressBar2.TabIndex = 42;
            this.progressBar2.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "label8";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(208, 263);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(59, 20);
            this.progressBar1.TabIndex = 41;
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(888, 3);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(75, 23);
            this.button29.TabIndex = 43;
            this.button29.Text = "button29";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.ViewCount;
            this.ClientSize = new System.Drawing.Size(1199, 667);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ViewCount;
        private System.Windows.Forms.Button pictureOpener;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button button29;
    }
}

