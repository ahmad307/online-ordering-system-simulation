using System;
using System.Windows.Forms;
using SQLCommunications;

namespace Online_Ordering_System.Front_end
{
    public partial class ItemPopUp : Form
    {
        ItemDisc item;
        new Admin ParentForm;
        bool Once = true;
        public ItemPopUp(ItemDisc i , Admin p)
        {
            item = i;
            ParentForm = p;
            InitializeComponent();
        }

        private void ItemPopUp_Load(object sender, EventArgs e)
        {
            if(Once)
            {
                NameTxT.Text = item.name;
                PriceTxT.Text = item.price.ToString();
                QuantityTxT.Text = item.Quantity.ToString();
                TypeTxT.Text = item.Type;
                Once = false;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            CommBase.ExecuteNoReturn("UPDATE Product SET name = '" + NameTxT.Text + "' , price = " + PriceTxT.Text + " , quantity = " + QuantityTxT.Text + " , type = '" + TypeTxT.Text + "' WHERE id = " + item.ID + ";");
            SuspendLayout();
            ParentForm.CleanUp();
            ParentForm.ListItems();
            ResumeLayout();
            Close();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            CommBase.ExecuteNoReturn("DELETE FROM Product WHERE name = '" + item.name + "';");
            SuspendLayout();
            ParentForm.CleanUp();
            ParentForm.ListItems();
            ResumeLayout();
            Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
