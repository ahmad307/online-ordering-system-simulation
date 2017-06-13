using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Online_Ordering_System;
using SQLCommunications;

namespace Online_Ordering_System.Front_end
{
    public partial class Advanced_Filter : Form
    {
        Form2 f;
        public Advanced_Filter(Form2 z)
        {
            InitializeComponent();
            f = z;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            float priceMin;
            float priceMax;

            if (Filter_From_txt.Text == "")
                priceMin = 0;
            else
                 priceMin = float.Parse(Filter_From_txt.Text);

            if (Filter_to_txt.Text == "")
                priceMax = 1000000000;
            else
             priceMax = float.Parse(Filter_to_txt.Text);


            string word = Filter_SearchWord_txt.Text;
            bool matchCase = Filter_MatchCase_check.Checked;
            bool WholeWord = Filter_WholeWord_check.Checked;

            ItemDisc[] Items = Receiver.GetAllProducts();
            List<ItemDisc> ItemsList = new List<ItemDisc>();
            foreach(ItemDisc c in Items)
            {
                ItemsList.Add(c);
            }
          ItemsList= functions.Advanced_filter(ItemsList, word, WholeWord, matchCase, priceMin, priceMax);
            this.Hide(); 
            f.CleanUp();
            f.ListItems(ItemsList.ToArray());

        }
    }
}
