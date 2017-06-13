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
    PictureBox pic = new PictureBox();
    Button RemoveButton = new Button();
    public AdminView(ItemDisc i, Panel p , Admin f)
    {
        item = i;
        ParentPanel = p;
        ParentForm = f;
        pic.Size = new Size(100, 100);
        pic.Location = new Point(0, 27 + offset);
        pic.Image = i.GetImage();
        name.Text = i.name;
        name.Location = new Point(103, 27 + offset);
        Price.Text = i.price.ToString() + "$";
        Price.Location = new Point(195, 27 + offset);
        Quantity.Text = i.Quantity.ToString();
        Quantity.Location = new Point(278, 27 + offset);
        Type.Text = i.Type;
        Type.Location = new Point(367, 27 + offset);
        RemoveButton.Text = "Edit";
        RemoveButton.Location = new Point(469, 22 + offset);
        RemoveButton.Click += RemoveButton_Click;
        offset += 107;
        ParentPanel.Controls.Add(RemoveButton);
        ParentPanel.Controls.Add(Type);
        ParentPanel.Controls.Add(Quantity);
        ParentPanel.Controls.Add(Price);
        ParentPanel.Controls.Add(name);
        ParentPanel.Controls.Add(pic);
    }
    public void CleanUp()
    {
        ParentPanel.Controls.Remove(name);
        ParentPanel.Controls.Remove(Price);
        ParentPanel.Controls.Remove(Quantity);
        ParentPanel.Controls.Remove(Type);
        ParentPanel.Controls.Remove(RemoveButton);
        ParentPanel.Controls.Remove(pic);
    }
    private void RemoveButton_Click(object sender, System.EventArgs e)
    {
        ItemPopUp MiniForm = new ItemPopUp(item , ParentForm);
        MiniForm.Show();
    }
}