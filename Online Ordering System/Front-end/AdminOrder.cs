using System.Drawing;
using System.Windows.Forms;
using SQLCommunications;

public class OrderView
{
    public static int offset = 0;
    public Button Promote = new Button();
    public Label OrderID = new Label();
    public Label Name = new Label();
    public Label Quantity = new Label();
    public Label OrderState = new Label();
    public ItemDisc item;
    public Panel ParentPanel;
    public OrderView(ItemDisc i, Panel p)
    {
        item = i;
        ParentPanel = p;
        OrderID.Text = i.ID.ToString();
        OrderID.Location = new Point(58, 45 + offset);
        Name.Text = i.name;
        Name.Location = new Point(165, 45 + offset);
        Quantity.Text = i.Quantity.ToString();
        Quantity.Location = new Point(258, 45 + offset);
        if (i.state == DeliveryState.Pending)
        {
            OrderState.Text = "Pending";
        }
        else if (i.state == DeliveryState.InProgress)
        {
            OrderState.Text = "In-Progress";
        }
        else
        {
            OrderState.Text = "Delieverd";
        }
        OrderState.Location = new Point(364, 45 + offset);
        Promote.Text = "Promote";
        Promote.Location = new Point(437, 40 + offset);
        Promote.Click += Promote_Click;
        ParentPanel.Controls.Add(Promote);
        ParentPanel.Controls.Add(OrderState);
        ParentPanel.Controls.Add(Quantity);
        ParentPanel.Controls.Add(Name);
        ParentPanel.Controls.Add(OrderID);
        offset += 27;
    }

    private void Promote_Click(object sender, System.EventArgs e)
    {
        if (item.state == DeliveryState.Pending)
        {
            Transmitter.UpdateOrders(item.ID, DeliveryState.InProgress);
            OrderState.Text = "In-Progress";
        }
        else if (item.state == DeliveryState.InProgress)
        {
            Transmitter.UpdateOrders(item.ID, DeliveryState.Delieverd);
            OrderState.Text = "Delieverd";
        }
    }

    public void CleanUp()
    {
        ParentPanel.Controls.Remove(Promote);
        ParentPanel.Controls.Remove(OrderState);
        ParentPanel.Controls.Remove(Quantity);
        ParentPanel.Controls.Remove(Name);
        ParentPanel.Controls.Remove(OrderID);
    }
}