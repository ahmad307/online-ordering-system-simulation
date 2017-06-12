using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Online_Ordering_System;

public class CategoriesView
{
    public static int categories_offset = 0;
    Button catButton = new Button();
    Form2 f;

    public CategoriesView(string S, Panel p , Form2 ff)
    {
        f = ff;
        catButton.MouseEnter += button_MouseEnter;
        catButton.MouseLeave += button_MouseLeave;
        catButton.Click += CatClick;
        //button proprties
        catButton.Size = new Size(200, 33);
        catButton.Location = new Point(3, categories_offset + 114);
        catButton.Text = S;
        catButton.TextAlign = ContentAlignment.MiddleCenter;
        catButton.Font = new Font("Tahoma", 8);
        catButton.Cursor = Cursors.Hand;
        categories_offset += 57;
        p.Controls.Add(catButton);
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
    void CatClick(object sender, EventArgs e)
    {
        //see what you wanna do when someone *clicks*
        Button btn = (Button)sender;
        List<ItemDisc> catItems = new List<ItemDisc>();
        catItems = FetchData.Category(btn.Text);
        f.CleanUp();
        f.ListItems(catItems.ToArray());
    }
}
