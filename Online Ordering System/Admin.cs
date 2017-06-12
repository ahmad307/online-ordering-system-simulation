using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Ordering_System
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Categories_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Size = new Size (255, 144);
            Addmenu.Visible = false;
            Editmenu.Visible = false;
            Addmenu.Location = new Point(0, 65);
            Editmenu.Location = new Point(0, 75);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addmenu.Visible = true;
            buttonadd.Visible = false;
            buttonedit.Visible = false;
            buttonback.Visible = false;
            Size = new Size(255, 302);
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            Editmenu.Visible = true;
            buttonadd.Visible = false;
            buttonedit.Visible = false;
            buttonback.Visible = false;
            Size = new Size(440, 362);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Addmenu.Visible = false;
            buttonadd.Visible = true;
            buttonedit.Visible = true;
            buttonback.Visible = true;
            Size = new Size(255, 144);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
