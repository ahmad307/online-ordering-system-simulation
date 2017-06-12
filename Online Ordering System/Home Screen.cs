using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SQLCommunications;

namespace Online_Ordering_System

{
    public partial class Form2 : Form
    {
        public static bool isLogedin = false;
        private bool usercheck = false;
        private bool pass1check = false;
        private bool pass2check = false;
        ItemDisc[] items;
        List<ItemView> ViewedItems;
        List<ItemDisc> ItemsViewed;
        List<CategoriesView> ViewedCategories;

        Panel LastPanel;
        public Form2()
        {
            InitializeComponent();
            ListItems(Receiver.ReadFromProduct("SELECT * FROM Product;"));
            List<string> CL = FetchData.AllCategories();
            ViewedCategories = new List<CategoriesView>();
            foreach(string s in CL)
            {
                CategoriesView C = new CategoriesView(s,Categories , this);
                ViewedCategories.Add(C);
            }
        }
        public void ListItems(ItemDisc[] Items)
        {
            items = Items;
            ViewedItems = new List<ItemView>();
            ItemsViewed = new List<ItemDisc>();

            foreach (ItemDisc i in items)
            {
                if (i.Quantity > 0)
                {
                    ItemView x = new ItemView(i, Home_Panel);
                    ViewedItems.Add(x);
                    ItemsViewed.Add(i);
                }
            }
        }
        
        public void CleanUp()
        {
            foreach (ItemView i in ViewedItems)
            {
                i.Clear();
            }

            ItemView.x_offset = 0;
            ItemView.y_offset = 0;
            ItemView.itemNum = 0;
            ViewedItems.Clear();
            ItemsViewed.Clear();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button4_MouseHover(object sender, EventArgs e) //making orange effect when hovering over button
        {
            Color clr = Color.FromArgb(0, 255, 188, 72);
            Button btn = (Button)sender;
            btn.BackColor = clr;
            btn.ForeColor = Color.White;

        }

        private void button4_MouseLeave(object sender, EventArgs e)//making orange effect when hovering over button
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.Black;
            btn.BackColor = Categories.BackColor;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void show_login()  // showing login panel
        {
            if (LastPanel == Login)
                return;
            Login.Visible = true;
            LastPanel.Visible = false;
            LastPanel = Login;
        }
        public void show_signup()  // shwoing signup panel
        {
            if (LastPanel == Sign_Up)
                return;
            Sign_Up.Visible = true;
            LastPanel.Visible = false;
            LastPanel = Sign_Up;
        }
        public void show_home() //showing home panel
        {
            if (LastPanel == Home_Panel)
                return;
            Home_Panel.Visible = true;
            LastPanel.Visible = false;
            LastPanel = Home_Panel;

        }

        private void label3_Click_1(object sender, EventArgs e) 
        {
            show_login();

        }

        private void label4_Click(object sender, EventArgs e) 
        {
            show_signup();
        }
        

        private void Home_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LastPanel = Home_Panel;
        }

        private void button1_Click(object sender, EventArgs e) //shwoing home panel
        {
            show_home();
        }

        private void pictureBox2_Click(object sender, EventArgs e) //showing home panel
        {
            show_home();
        }

        private void button11_Click(object sender, EventArgs e) //loging in
        {


            if (FetchData.CheckPass(Login_user_txt.Text, Login_pass_txt.Text)) // checking user and pass match from data base
            {
                Login_Label.ForeColor = Color.Green;
                Login_Label.Text = "Welcome";
            }
            else
            {
                Login_Label.ForeColor = Color.Red;
                Login_Label.Text = "Invalid Username or Password";

            }

        }

        private void SignUp_User_change(object sender, EventArgs e) //signing up
        {
            User user = new User();
            user.Username = SignUp_User_txt.Text;

            if (Transmitter.CheckUser(user))//check if username  is Available
            {
                SignUp_User_Label.ForeColor = Color.Green;
                SignUp_User_Label.Text = "OK ✓";
                usercheck = true;

            }
            else
            {

                SignUp_User_Label.ForeColor = Color.Red;
                SignUp_User_Label.Text = "Username used before";
                usercheck = false;
            }
        }

        private void SignUp_Pass1_txt_TextChanged(object sender, EventArgs e)
        {
            if (SignUp_Pass1_txt.TextLength < 8) //checking if pass length is at least 8 or not
            {
                SignUp_Pass1_Label.ForeColor = Color.Red;
                SignUp_Pass1_Label.Text = "Password must be at least 8 characters";
                pass1check = false;
            }
            else
            {
                SignUp_Pass1_Label.ForeColor = Color.Green;
                SignUp_Pass1_Label.Text = "OK ✓";
                pass1check = true;
            }

        }

        private void SignUp_Pass2_txt_TextChanged(object sender, EventArgs e)
        {
            if (SignUp_Pass2_txt.Text != SignUp_Pass1_txt.Text) //check that the 2 passwords are identical or not
            {
                SignUp_Pass2_Label.ForeColor = Color.Red;
                SignUp_Pass2_Label.Text = "The Passwords don't match";
                pass2check = false;
            }
            else
            {
                SignUp_Pass2_Label.ForeColor = Color.Green;
                SignUp_Pass2_Label.Text = "OK ✓";
                pass2check = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (usercheck && pass1check && pass2check) //check that input is free of errors
            {
                User user = new User();

                user.Username = SignUp_User_txt.Text;
                user.Password = SignUp_Pass2_txt.Text;
                user.address = SignUp_Adress_txt.Text;

                Transmitter.RegisterUser(user); //sign up function 
            }
            else
            {
                SignUp_Label.ForeColor = Color.Red;
                SignUp_Label.Text = "Pleas Fix Above Errors!";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CleanUp();
            List<ItemDisc> temp = new List<ItemDisc>(items);
            temp.RemoveAt(2);
            ListItems(temp.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if( ! isLogedin)
            show_login();
            else
            {
                //show user orders 
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(SortType.Text=="Name")
            {
                CleanUp();
                List<ItemDisc> ItemsViewed2 = new List<ItemDisc>(items);
                functions.sort_name(ItemsViewed2);
                if (SortOrder.Text=="Descending")
                    ItemsViewed2.Reverse();

                ListItems(ItemsViewed2.ToArray());
            }
            else if(SortType.Text=="Price")
            {
                CleanUp();
                List<ItemDisc> ItemsViewed2 = new List<ItemDisc>(items);
                functions.Sort_Prize(ItemsViewed2);
                if (SortOrder.Text == "Descending")
                    ItemsViewed2.Reverse();

                ListItems(ItemsViewed2.ToArray());
            }
        }
    }
}
