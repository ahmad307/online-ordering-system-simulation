using System;
using System.Windows.Forms;
using System.Drawing;
using Online_Ordering_System;

public class ItemView
{
    public static int x_offset = 0;
    public static int y_offset = 0;
    public static int itemNum = 0;
    Button buybutton = new Button();
   
    Label name = new Label();
    Label price = new Label();
    public Panel ParentPanel;
    public ItemDisc Item;
    public ItemView(ItemDisc i , Panel p)
    {
        if (i.Quantity > 0)
        {
            if (itemNum % 4 == 0 && itemNum != 0)
            {
                x_offset = 0;
                y_offset += 150;
            }
            Item = i;
            ParentPanel = p;

            name.Location = new Point(38 + x_offset, 90 + y_offset);
            name.Text = i.name;
            name.Font = new Font("Britannic Bold", 12);
            name.ForeColor = Color.RoyalBlue;

            price.Location = new Point(38 + x_offset, 120 + y_offset);
            price.Text = i.price.ToString() + "$";
            price.ForeColor = Color.Green;

            buybutton.Location = new Point(38 + x_offset, 150 + y_offset);
            buybutton.Text = "Buy";
            buybutton.MouseEnter += button_MouseEnter;
            buybutton.MouseLeave += button_MouseLeave;
            buybutton.Click += BuyClick;

            x_offset += 200;
            p.Controls.Add(buybutton);
            p.Controls.Add(name);
            p.Controls.Add(price);
            itemNum++;
        }
    }
    public void Clear()
    {
        ParentPanel.Controls.Remove(buybutton);
        ParentPanel.Controls.Remove(name);
        ParentPanel.Controls.Remove(price);
    }
    void BuyClick (object sender , EventArgs e)
    {
        //see what you wanna do when someone *clicks*
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
