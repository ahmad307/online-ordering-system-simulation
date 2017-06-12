using System.Windows.Forms;
using System.Drawing;

public class AdminItemView
{
    public static int offset = 0;
    ItemDisc item;
    Panel ParentPanel;
    Label Name = new Label();
    Label Price = new Label();
    Label Quantity = new Label();
    Button EditButton = new Button();
    Button RemoveButton = new Button();
    public AdminItemView(ItemDisc i, Panel p)
    {
        item = i;
        ParentPanel = p;
        Name.Text = i.name;
        Name.Location = new Point(29 , 15 + offset);
        Price.Text = i.price.ToString() + "$";
        Price.Location = new Point(166, 15 + offset);
        Quantity.Text = i.Quantity.ToString();
        Quantity.Location = new Point(92 , 15 + offset);
        offset += 28;
        p.Controls.Add(Name);
        p.Controls.Add(Price);
        p.Controls.Add(Quantity);
        p.Controls.Add(EditButton);
        p.Controls.Add(RemoveButton);
    }
    public void CleanUp()
    {
        ParentPanel.Controls.Remove(Name);
        ParentPanel.Controls.Remove(Price);
        ParentPanel.Controls.Remove(Quantity);
        ParentPanel.Controls.Remove(EditButton);
        ParentPanel.Controls.Remove(RemoveButton);
    }
}