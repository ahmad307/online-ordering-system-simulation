using System;
using System.Windows.Forms;
using System.Drawing;

public class ItemView
{
    public static int offset = 0;
    Button buybutton = new Button();
    Label name = new Label();
    Label price = new Label();
    public Panel ParentPanel;
    public ItemDisc Item;
    public ItemView(ItemDisc i , Panel p)
    {
        Item = i;
        ParentPanel = p;
        buybutton.Location = new Point(593, 114 + offset);
        buybutton.Text = "Buy";
        buybutton.Click += BuyClick;
        price.Location = new Point(385, 114 + offset);
        price.Text = i.price.ToString() + "$";
        name.Location = new Point(203, 114 + offset);
        name.Text = i.name;
        offset += 100;
        p.Controls.Add(buybutton);
        p.Controls.Add(name);
        p.Controls.Add(price);
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
}
