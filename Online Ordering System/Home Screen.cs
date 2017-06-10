using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLCommunications;

namespace Online_Ordering_System
{
    public partial class Form2 : Form
    {
        private bool usercheck = false;
        private bool pass1check = false;
        private bool pass2check = false;
        Panel LastPanel;
        public Form2()
        {
            InitializeComponent();
            
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            Color clr = Color.FromArgb(0, 255, 188, 72);
            Button btn = (Button)sender;
            btn.BackColor = clr;
            btn.ForeColor = Color.White;

        }

        private void button4_MouseLeave(object sender, EventArgs e)
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

        private void label3_Click_1(object sender, EventArgs e)
        {
            Login.Visible = true;
            LastPanel.Visible = false;
            LastPanel = Login;    
        
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Sign_Up.Visible = true;
            LastPanel.Visible = false;
            LastPanel = Sign_Up;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Home_Panel.Visible = true;
            LastPanel.Visible = false;
            LastPanel = Home_Panel;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home_Panel.Visible = true;
            LastPanel.Visible = false;
            LastPanel = Home_Panel;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            
            if ( FetchData.checkPass ( Login_user_txt.ToString() , Login_pass_txt.ToString() ) )
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

        private void SignUp_User_change(object sender, EventArgs e)
        {
            if( /*user mwgod abl kda*/     true/*el true de ay klam*/)
            {
                SignUp_User_Label.ForeColor = Color.Red;
                SignUp_User_Label.Text = "Username used before";
                usercheck = false;
            }
            else
            {
                SignUp_User_Label.ForeColor = Color.Green;
                SignUp_User_Label.Text = "OK ✓";
                usercheck = true;
            }
        }

        private void SignUp_Pass1_txt_TextChanged(object sender, EventArgs e)
        {
            if( SignUp_Pass1_txt.TextLength <8)
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
            if( SignUp_Pass2_txt.Text != SignUp_Pass1_txt.Text)
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
            if(usercheck && pass1check && pass2check)
            {
                //signUp function
            }
            else
            {
                SignUp_Label.ForeColor = Color.Red;
                SignUp_Label.Text = "Pleas Fix Above Errors!";
            }
        }
    }
}
