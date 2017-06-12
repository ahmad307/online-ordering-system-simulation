using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SQLCommunications;

namespace Online_Ordering_System.Front_end
{
    public partial class Admin : Form
    {
        List<AdminView> ViewList = new List<AdminView>();
        public Admin()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ItemDisc Item = new ItemDisc();
            Item.name = Name_txt.Text;
            Item.price = float.Parse(Price_txt.Text);
            Item.Quantity = int.Parse(Quantity_txt.Text);
            Item.Type = Category_txt.Text;
            Transmitter.InsertIntoTable(Item);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            EditItem_Panel.Show();
            Admin_Home.Hide();
            ListItems();
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
            Admin_Home.Show();
            EditItem_Panel.Hide();
            CleanUp();
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
    }
}
