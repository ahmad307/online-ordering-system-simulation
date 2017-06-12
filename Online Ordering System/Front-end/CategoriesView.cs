using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Online_Ordering_System;
using SQLCommunications;
public class CategoriesView
{
    public static int categories_offset = 0;
    Button catButton = new Button();
    Button AllButton = new Button();
    Form2 f;

    public CategoriesView(string S, Panel p , Form2 ff)
    {
        
           f = ff;
        catButton.MouseEnter += button_MouseEnter;
        catButton.MouseLeave += button_MouseLeave;
        catButton.Click += CatClick;

        AllButton.MouseEnter += button_MouseEnter;
        AllButton.MouseLeave += button_MouseLeave;
        AllButton.Click += AllClick;


        //button proprties
        AllButton.Size= new Size(200, 33);
        AllButton.Location = new Point(3, 114);
        AllButton.Text = "All";
        AllButton.TextAlign = ContentAlignment.MiddleCenter;
        AllButton.Font = new Font("Tahoma", 8);
        AllButton.Cursor = Cursors.Hand;


        catButton.Size = new Size(200, 33);
        catButton.Location = new Point(3, categories_offset + 166);
        catButton.Text = S;
        catButton.TextAlign = ContentAlignment.MiddleCenter;
        catButton.Font = new Font("Tahoma", 8);
        catButton.Cursor = Cursors.Hand;
        categories_offset += 57;

        p.Controls.Add(AllButton);
        p.Controls.Add(catButton);
    }

    private void button_MouseEnter(object sender, EventArgs e) //making orange effect when hovering over button
    {
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
    void CatClick(object sender, EventArgs e)
    {
        //see what you wanna do when someone *clicks*
        Button btn = (Button)sender;
        List<ItemDisc> catItems = new List<ItemDisc>();
        catItems = FetchData.Category(btn.Text);
        f.CleanUp();
        f.ListItems(catItems.ToArray());
    }

    void AllClick(object sender, EventArgs e)
    {
        f.CleanUp();
        f.ListItems(Receiver.GetAllProducts());

    }
}
