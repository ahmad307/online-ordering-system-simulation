using System.Windows.Forms;
using System.Drawing;
using Online_Ordering_System.Front_end;

public class AdminView
{
    public static int offset = 0;
    ItemDisc item;
    Admin ParentForm;
    Panel ParentPanel;
    Label name = new Label();
    Label Price = new Label();
    Label Quantity = new Label();
    Label Type = new Label();
    Button RemoveButton = new Button();
    public AdminView(ItemDisc i, Panel p , Admin f)
    {
        item = i;
        ParentPanel = p;
        ParentForm = f;
        name.Text = i.name;
        name.Location = new Point(13, 117 + offset);
        Price.Text = i.price.ToString() + "$";
        Price.Location = new Point(74, 117 + offset);
        Quantity.Text = i.Quantity.ToString();
        Quantity.Location = new Point(115, 117 + offset);
        Type.Text = i.Type;
        Type.Location = new Point(160, 117 + offset);
        RemoveButton.Text = "Edit";
        RemoveButton.Location = new Point(224, 113 + offset);
        RemoveButton.Click += RemoveButton_Click;
        offset += 27;
        ParentPanel.Controls.Add(RemoveButton);
        ParentPanel.Controls.Add(Type);
        ParentPanel.Controls.Add(Quantity);
        ParentPanel.Controls.Add(Price);
        ParentPanel.Controls.Add(name);
    }
    public void CleanUp()
    {
        ParentPanel.Controls.Remove(name);
        ParentPanel.Controls.Remove(Price);
        ParentPanel.Controls.Remove(Quantity);
        ParentPanel.Controls.Remove(Type);
        ParentPanel.Controls.Remove(RemoveButton);
    }
    private void RemoveButton_Click(object sender, System.EventArgs e)
    {
        ItemPopUp MiniForm = new ItemPopUp(item , ParentForm);
        MiniForm.Show();
    }
}