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
namespace Online_Ordering_System.Front_end
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ItemDisc Item = new ItemDisc();

            Item.name = Name_txt.Text;
            Item.price =float.Parse( Price_txt.Text);
            Item.Quantity = int.Parse(Price_txt.Text);
            Item.Type = Category_txt.Text;

            Transmitter.InsertIntoTable(Item);
            

            

        }
    }
}
