using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SQLCommunications;
using System.IO;
using System.Drawing;

namespace Online_Ordering_System.Front_end
{
    public partial class Admin : Form
    {
        List<AdminView> ViewList = new List<AdminView>();
        bool ShowFinishingLabel = false;
        Timer time = new Timer();
        public Admin()
        {
            InitializeComponent();
            time.Tick += FinishingLabelController;
            time.Interval = 3000;
        }

        private void FinishingLabelController(object sender, EventArgs e)
        {
            EndingLabel.Visible = false;
            time.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ItemDisc Item = new ItemDisc();
            Item.name = Name_txt.Text;
            Item.price = float.Parse(Price_txt.Text);
            Item.Quantity = int.Parse(Quantity_txt.Text);
            Item.Type = Category_txt.Text;
            Item.image = File.ReadAllBytes(label4.Text);
            Transmitter.InsertIntoTable(Item);
            Name_txt.Text = null;
            Price_txt.Text = null;
            Quantity_txt.Text = null;
            Category_txt.Text = null;
            ShowFinishingLabel = true;
            time.Start();
            EndingLabel.Visible = true;
            label4.Text = "No Path";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            EditItem_Panel.Show();
            Admin_Home.Hide();
            SuspendLayout();
            ListItems();
            ResumeLayout();
        }
        public void ListItems()
        {
            ItemDisc[] items = Receiver.GetAllProducts();
            foreach (ItemDisc i in items)
            {
                AdminView x = new AdminView(i, EditItem_Panel, this);
                ViewList.Add(x);
            }
        }
        public void CleanUp()
        {
            foreach (AdminView i in ViewList)
            {
                i.CleanUp();
            }
            AdminView.offset = 0;
            ViewList.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            Admin_Home.Show();
            EditItem_Panel.Hide();
            CleanUp();
            ResumeLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddItem_Panel.Show();
            Admin_Home.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin_Home.Show();
            AddItem_Panel.Hide();
        }

        private void AddItem_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.ShowDialog();
            label4.Text = d.FileName;
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
