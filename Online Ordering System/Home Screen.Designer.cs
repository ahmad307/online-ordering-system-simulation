namespace Online_Ordering_System
{

    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Home_Button = new System.Windows.Forms.Button();
            this.Orders_Button = new System.Windows.Forms.Button();
            this.ContactUs_Button = new System.Windows.Forms.Button();
            this.Categories = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Home_Panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SortOrder = new System.Windows.Forms.ComboBox();
            this.SortType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Sign_Up = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.SignUp_Adress_txt = new System.Windows.Forms.TextBox();
            this.SignUp_Label = new System.Windows.Forms.Label();
            this.SignUp_Pass2_Label = new System.Windows.Forms.Label();
            this.SignUp_Pass1_Label = new System.Windows.Forms.Label();
            this.SignUp_User_Label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SignUp_Pass2_txt = new System.Windows.Forms.TextBox();
            this.SignUp_Pass1_txt = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.SignUp_User_txt = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Panel();
            this.Login_Label = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.Login_pass_txt = new System.Windows.Forms.TextBox();
            this.Login_user_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Categories.SuspendLayout();
            this.Home_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Sign_Up.SuspendLayout();
            this.Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Home_Button
            // 
            this.Home_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(173)))), ((int)(((byte)(52)))));
            this.Home_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Home_Button.ForeColor = System.Drawing.Color.White;
            this.Home_Button.Location = new System.Drawing.Point(238, 21);
            this.Home_Button.Name = "Home_Button";
            this.Home_Button.Size = new System.Drawing.Size(84, 32);
            this.Home_Button.TabIndex = 1;
            this.Home_Button.Text = "Home";
            this.Home_Button.UseVisualStyleBackColor = false;
            this.Home_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Orders_Button
            // 
            this.Orders_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(173)))), ((int)(((byte)(52)))));
            this.Orders_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Orders_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orders_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Bold);
            this.Orders_Button.ForeColor = System.Drawing.Color.White;
            this.Orders_Button.Location = new System.Drawing.Point(330, 21);
            this.Orders_Button.Name = "Orders_Button";
            this.Orders_Button.Size = new System.Drawing.Size(84, 32);
            this.Orders_Button.TabIndex = 2;
            this.Orders_Button.Text = "Your Ordes";
            this.Orders_Button.UseVisualStyleBackColor = false;
            this.Orders_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // ContactUs_Button
            // 
            this.ContactUs_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(173)))), ((int)(((byte)(52)))));
            this.ContactUs_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContactUs_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactUs_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.ContactUs_Button.ForeColor = System.Drawing.Color.White;
            this.ContactUs_Button.Location = new System.Drawing.Point(422, 21);
            this.ContactUs_Button.Name = "ContactUs_Button";
            this.ContactUs_Button.Size = new System.Drawing.Size(88, 32);
            this.ContactUs_Button.TabIndex = 3;
            this.ContactUs_Button.Text = "Contact Us";
            this.ContactUs_Button.UseVisualStyleBackColor = false;
            // 
            // Categories
            // 
            this.Categories.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Categories.BackgroundImage = global::Online_Ordering_System.Properties.Resources.pattern_s;
            this.Categories.Controls.Add(this.pictureBox1);
            this.Categories.Controls.Add(this.label1);
            this.Categories.Location = new System.Drawing.Point(2, 70);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(221, 464);
            this.Categories.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 20F);
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Categories";
            // 
            // Home_Panel
            // 
            this.Home_Panel.AutoScroll = true;
            this.Home_Panel.BackColor = System.Drawing.Color.LightGray;
            this.Home_Panel.Controls.Add(this.button1);
            this.Home_Panel.Controls.Add(this.SortOrder);
            this.Home_Panel.Controls.Add(this.SortType);
            this.Home_Panel.Controls.Add(this.label2);
            this.Home_Panel.Location = new System.Drawing.Point(208, 70);
            this.Home_Panel.Name = "Home_Panel";
            this.Home_Panel.Size = new System.Drawing.Size(788, 464);
            this.Home_Panel.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SortOrder
            // 
            this.SortOrder.AllowDrop = true;
            this.SortOrder.FormattingEnabled = true;
            this.SortOrder.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.SortOrder.Location = new System.Drawing.Point(570, 18);
            this.SortOrder.Name = "SortOrder";
            this.SortOrder.Size = new System.Drawing.Size(126, 21);
            this.SortOrder.TabIndex = 3;
            this.SortOrder.Text = "Ascending";
            // 
            // SortType
            // 
            this.SortType.AllowDrop = true;
            this.SortType.FormattingEnabled = true;
            this.SortType.Items.AddRange(new object[] {
            "Name",
            "Price"});
            this.SortType.Location = new System.Drawing.Point(434, 18);
            this.SortType.Name = "SortType";
            this.SortType.Size = new System.Drawing.Size(126, 21);
            this.SortType.TabIndex = 2;
            this.SortType.Text = "Name";
            this.SortType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sort By:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Online_Ordering_System.Properties.Resources.lgo__0١;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(-7, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(239, 69);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 12.25F);
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(797, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Log in";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 12.25F);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(891, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sign up";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(861, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "OR";
            // 
            // Sign_Up
            // 
            this.Sign_Up.BackColor = System.Drawing.Color.LightGray;
            this.Sign_Up.Controls.Add(this.label11);
            this.Sign_Up.Controls.Add(this.SignUp_Adress_txt);
            this.Sign_Up.Controls.Add(this.SignUp_Label);
            this.Sign_Up.Controls.Add(this.SignUp_Pass2_Label);
            this.Sign_Up.Controls.Add(this.SignUp_Pass1_Label);
            this.Sign_Up.Controls.Add(this.SignUp_User_Label);
            this.Sign_Up.Controls.Add(this.label10);
            this.Sign_Up.Controls.Add(this.label9);
            this.Sign_Up.Controls.Add(this.label8);
            this.Sign_Up.Controls.Add(this.SignUp_Pass2_txt);
            this.Sign_Up.Controls.Add(this.SignUp_Pass1_txt);
            this.Sign_Up.Controls.Add(this.button10);
            this.Sign_Up.Controls.Add(this.SignUp_User_txt);
            this.Sign_Up.Location = new System.Drawing.Point(208, 70);
            this.Sign_Up.Name = "Sign_Up";
            this.Sign_Up.Size = new System.Drawing.Size(800, 464);
            this.Sign_Up.TabIndex = 8;
            this.Sign_Up.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(173, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Enter Your Adress";
            // 
            // SignUp_Adress_txt
            // 
            this.SignUp_Adress_txt.Location = new System.Drawing.Point(274, 292);
            this.SignUp_Adress_txt.Name = "SignUp_Adress_txt";
            this.SignUp_Adress_txt.Size = new System.Drawing.Size(176, 20);
            this.SignUp_Adress_txt.TabIndex = 26;
            this.SignUp_Adress_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SignUp_Label
            // 
            this.SignUp_Label.AutoSize = true;
            this.SignUp_Label.Location = new System.Drawing.Point(329, 365);
            this.SignUp_Label.Name = "SignUp_Label";
            this.SignUp_Label.Size = new System.Drawing.Size(0, 13);
            this.SignUp_Label.TabIndex = 25;
            // 
            // SignUp_Pass2_Label
            // 
            this.SignUp_Pass2_Label.AutoSize = true;
            this.SignUp_Pass2_Label.Location = new System.Drawing.Point(471, 245);
            this.SignUp_Pass2_Label.Name = "SignUp_Pass2_Label";
            this.SignUp_Pass2_Label.Size = new System.Drawing.Size(0, 13);
            this.SignUp_Pass2_Label.TabIndex = 24;
            // 
            // SignUp_Pass1_Label
            // 
            this.SignUp_Pass1_Label.AutoSize = true;
            this.SignUp_Pass1_Label.Location = new System.Drawing.Point(471, 157);
            this.SignUp_Pass1_Label.Name = "SignUp_Pass1_Label";
            this.SignUp_Pass1_Label.Size = new System.Drawing.Size(0, 13);
            this.SignUp_Pass1_Label.TabIndex = 23;
            // 
            // SignUp_User_Label
            // 
            this.SignUp_User_Label.AutoSize = true;
            this.SignUp_User_Label.Location = new System.Drawing.Point(471, 70);
            this.SignUp_User_Label.Name = "SignUp_User_Label";
            this.SignUp_User_Label.Size = new System.Drawing.Size(0, 13);
            this.SignUp_User_Label.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(169, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Enter Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Re-Enter Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Enter Username";
            // 
            // SignUp_Pass2_txt
            // 
            this.SignUp_Pass2_txt.Location = new System.Drawing.Point(274, 217);
            this.SignUp_Pass2_txt.Name = "SignUp_Pass2_txt";
            this.SignUp_Pass2_txt.Size = new System.Drawing.Size(176, 20);
            this.SignUp_Pass2_txt.TabIndex = 18;
            this.SignUp_Pass2_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SignUp_Pass2_txt.UseSystemPasswordChar = true;
            this.SignUp_Pass2_txt.TextChanged += new System.EventHandler(this.SignUp_Pass2_txt_TextChanged);
            // 
            // SignUp_Pass1_txt
            // 
            this.SignUp_Pass1_txt.Location = new System.Drawing.Point(274, 142);
            this.SignUp_Pass1_txt.Name = "SignUp_Pass1_txt";
            this.SignUp_Pass1_txt.Size = new System.Drawing.Size(176, 20);
            this.SignUp_Pass1_txt.TabIndex = 17;
            this.SignUp_Pass1_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SignUp_Pass1_txt.UseSystemPasswordChar = true;
            this.SignUp_Pass1_txt.TextChanged += new System.EventHandler(this.SignUp_Pass1_txt_TextChanged);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(173)))), ((int)(((byte)(52)))));
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(320, 367);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(84, 32);
            this.button10.TabIndex = 12;
            this.button10.Text = "Sign Up";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // SignUp_User_txt
            // 
            this.SignUp_User_txt.Location = new System.Drawing.Point(274, 67);
            this.SignUp_User_txt.Name = "SignUp_User_txt";
            this.SignUp_User_txt.Size = new System.Drawing.Size(176, 20);
            this.SignUp_User_txt.TabIndex = 2;
            this.SignUp_User_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SignUp_User_txt.TextChanged += new System.EventHandler(this.SignUp_User_change);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.LightGray;
            this.Login.Controls.Add(this.Login_Label);
            this.Login.Controls.Add(this.button11);
            this.Login.Controls.Add(this.Login_pass_txt);
            this.Login.Controls.Add(this.Login_user_txt);
            this.Login.Controls.Add(this.label6);
            this.Login.Controls.Add(this.label7);
            this.Login.Location = new System.Drawing.Point(208, 70);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(800, 464);
            this.Login.TabIndex = 19;
            this.Login.Visible = false;
            this.Login.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_Paint);
            // 
            // Login_Label
            // 
            this.Login_Label.AutoSize = true;
            this.Login_Label.Location = new System.Drawing.Point(382, 291);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(0, 13);
            this.Login_Label.TabIndex = 13;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(173)))), ((int)(((byte)(52)))));
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(338, 238);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(84, 32);
            this.button11.TabIndex = 12;
            this.button11.Text = "Log in";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Login_pass_txt
            // 
            this.Login_pass_txt.Location = new System.Drawing.Point(295, 190);
            this.Login_pass_txt.Name = "Login_pass_txt";
            this.Login_pass_txt.PasswordChar = '•';
            this.Login_pass_txt.Size = new System.Drawing.Size(176, 20);
            this.Login_pass_txt.TabIndex = 3;
            this.Login_pass_txt.UseSystemPasswordChar = true;
            // 
            // Login_user_txt
            // 
            this.Login_user_txt.Location = new System.Drawing.Point(295, 155);
            this.Login_user_txt.Name = "Login_user_txt";
            this.Login_user_txt.Size = new System.Drawing.Size(176, 20);
            this.Login_user_txt.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Username";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(528, 27);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(225, 20);
            this.SearchBox.TabIndex = 20;
            this.SearchBox.Text = "Search..";
            this.SearchBox.Click += new System.EventHandler(this.SearchBox_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 6F);
            this.button2.Location = new System.Drawing.Point(759, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Online_Ordering_System.Properties.Resources.iconsss;
            this.pictureBox1.Location = new System.Drawing.Point(23, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Online_Ordering_System.Properties.Resources.pattern1;
            this.ClientSize = new System.Drawing.Size(999, 535);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.ContactUs_Button);
            this.Controls.Add(this.Orders_Button);
            this.Controls.Add(this.Home_Button);
            this.Controls.Add(this.Sign_Up);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Home_Panel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Categories.ResumeLayout(false);
            this.Categories.PerformLayout();
            this.Home_Panel.ResumeLayout(false);
            this.Home_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Sign_Up.ResumeLayout(false);
            this.Sign_Up.PerformLayout();
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Home_Button;
        private System.Windows.Forms.Button Orders_Button;
        private System.Windows.Forms.Button ContactUs_Button;
        private System.Windows.Forms.Panel Categories;
        private System.Windows.Forms.Panel Home_Panel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SortOrder;
        private System.Windows.Forms.ComboBox SortType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Sign_Up;
        private System.Windows.Forms.TextBox SignUp_Pass2_txt;
        private System.Windows.Forms.TextBox SignUp_Pass1_txt;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox SignUp_User_txt;
        private System.Windows.Forms.Panel Login;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox Login_pass_txt;
        private System.Windows.Forms.TextBox Login_user_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label SignUp_Pass2_Label;
        private System.Windows.Forms.Label SignUp_Pass1_Label;
        private System.Windows.Forms.Label SignUp_User_Label;
        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.Label SignUp_Label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SignUp_Adress_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

