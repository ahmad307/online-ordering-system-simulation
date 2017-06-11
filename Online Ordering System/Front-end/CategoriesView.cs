using System.Drawing;
using System.Windows.Forms;

    public class CategoriesView
    {
        public static int categories_offset = 0;
        Button catButton = new Button();

        public CategoriesView(string S, Panel p)
        {
            //button proprties
            catButton.Text = S;
            catButton.Cursor = Cursors.Hand;
            catButton.Font = new Font("Tahoma", 8);
            catButton.TextAlign = ContentAlignment.MiddleCenter;
            catButton.Location = new Point(3, categories_offset + 114);
            catButton.Size = new Size(200, 33);
            p.Controls.Add(catButton);
            categories_offset += 57;
        }
    }
