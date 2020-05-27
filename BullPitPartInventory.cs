using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CodysShop
{
    public partial class BullPitPartInventory : Form
    {
        public BullPitPartInventory()
        {
            InitializeComponent();
        }
        


        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.wrekerIntakeBindingSource.EndEdit();
            this.wrekerIntakeTableAdapter.Update(this.shopDataSet1);
            this.wrekerIntakeBindingSource.AddNew();
        }



        private void BullPitReview_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (ShopEntities db = new ShopEntities())
            {
                List<WrekerIntake> list = db.WrekerIntakes.ToList();
                foreach (WrekerIntake w in list)
                {
                    ListViewItem item = new ListViewItem(w.Id.ToString());
                    item.SubItems.Add(w.Year);
                    item.SubItems.Add(w.Make);
                    item.SubItems.Add(w.Model);
                    item.SubItems.Add(w.Parts);
                    item.SubItems.Add(w.Totaled);
                    listView1.Items.Add(item);
                    }
            }
        }



        private async void listView1_ItemActivate(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                using (ShopEntities db = new ShopEntities())
                {
                    string wrekerId = item.SubItems[0].Text;
                    WrekerIntake w = await db.WrekerIntakes.FindAsync(Convert.ToInt32(wrekerId));
                    if (w != null)
                    {
                        using (WreckerReview crs = new WreckerReview())
                        {
                            if (crs.ShowDialog() == DialogResult.OK)
                            {
                                //Process
                            }
                        }
                    }
                }
            }
        }
    }
}
