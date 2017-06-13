using System;
using System.Windows.Forms;
using System.Drawing;
using Online_Ordering_System;

public class ItemView
{
    public static int x_offset = 0;
    public static int y_offset = 0;
    public static int itemNum = 0;
    public static bool IsOrder = false;
    private bool IsCancelButton;
    Button buybutton = new Button();
    PictureBox pic = new PictureBox();
    Label name = new Label();
    Label price = new Label();
    Label State = new Label();
    public Panel ParentPanel;
    public ItemDisc Item;
    Form2 form;
    Panel productsPanel;
    public ItemView(ItemDisc i, Panel p, Panel p2, Form2 f)
    {
        IsCancelButton = IsOrder;
        form = f;
        if (i.Quantity > 0)
        {
            if ((itemNum % 4 == 0 && itemNum != 0))
            {
                x_offset = 0;  // item will be first in the new row 
                y_offset += 180; //vertical distance between each row
            }
            Item = i;
            ParentPanel = p;
            productsPanel = p2;

            //Product picture proprties
            if (!IsOrder)
            {
                pic.BackgroundImage = i.GetImage();
                pic.Location = new Point(38 + x_offset, 70 + y_offset);
                pic.Size = new Size(100, 100);

            }

            //product name label proprties
            if (IsOrder)
                name.Location = new Point(38, 58 + y_offset);
            else
                name.Location = new Point(38 + x_offset, 158 + y_offset);
            name.Text = i.name;
            name.Font = new Font("Britannic Bold", 12);
            name.ForeColor = Color.RoyalBlue;
            name.BackColor = Color.Transparent;
            //product price label proprties
            if (IsOrder)
            {
                price.Location = new Point(150, 58 + y_offset);
                price.Text = i.Quantity.ToString() + " Items each cost " + i.price.ToString() + "$";
                price.Size = new Size(200, 20);
            }
            else
            {
                price.Location = new Point(38 + x_offset, 180 + y_offset);
                price.Text = i.price.ToString() + "$";
            }
            price.ForeColor = Color.Green;

            //product buy button proprties
            if (IsOrder)
            {
                buybutton.Location = new Point(350, 58 + y_offset);
                buybutton.Text = "Cancel";
            }
            else
            {
                buybutton.Location = new Point(38 + x_offset, 200 + y_offset);
                buybutton.Text = "Buy";
            }
            buybutton.MouseEnter += button_MouseEnter;
            buybutton.MouseLeave += button_MouseLeave;
            buybutton.Click += BuyClick;
            if (IsOrder)
            {
                State.Location = new Point(450, 58 + y_offset);
                State.Font = new Font("Britannic Bold", 12);
                if (Item.state == DeliveryState.Pending) { State.Text = "Pending"; State.ForeColor = Color.Red; }
                if (Item.state == DeliveryState.InProgress) { State.Text = "InProgress"; State.ForeColor = Color.Orange; }
                if (Item.state == DeliveryState.Delieverd) { State.Text = "Delieverd"; State.ForeColor = Color.Green; buybutton.Text = "Delete"; }
            }

            x_offset += 200;//horizontal distance between products

            //adding products to home panel
            if (IsOrder) p.Controls.Add(State);
            p.Controls.Add(buybutton);
            p.Controls.Add(name);
            p.Controls.Add(price);
            if (!IsOrder)
            {
                p.Controls.Add(pic);
                itemNum++;
            }
            else
            {
                y_offset += 27;
            }
        }
    }
    public void Clear()
    {
        ParentPanel.Controls.Remove(buybutton);
        ParentPanel.Controls.Remove(name);
        ParentPanel.Controls.Remove(price);
        ParentPanel.Controls.Remove(pic);
        ParentPanel.Controls.Remove(State);
    }
    void BuyClick(object sender, EventArgs e)
    {
        if (!User.IsLoggedIn)
        {
            MessageBox.Show("Please Login First", "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (IsCancelButton)
        {
            SQLCommunications.CommBase.ExecuteNoReturn("DELETE FROM Orders WHERE id = " + Item.ID.ToString());
            form.ShowOrders();
            return;
        }
        form.show_Product(Item);
    }
    private void button_MouseEnter(object sender, EventArgs e) //making orange effect when hovering over button
    {
        Color clr = Color.FromArgb(0, 255, 188, 72);
        Button btn = (Button)sender;
        btn.BackColor = Color.Orange;
        btn.ForeColor = Color.White;

    }
    private void button_MouseLeave(object sender, EventArgs e)//making orange effect when hovering over button
    {
        Button btn = (Button)sender;
        btn.ForeColor = Color.Black;
        btn.BackColor = Color.LightGray;
    }
}
