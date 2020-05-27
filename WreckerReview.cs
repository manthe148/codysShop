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
    public partial class WreckerReview : Form
    {
        public WreckerReview()
        {
            InitializeComponent();
        }

        private void wrekerIntakeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.wrekerIntakeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataSet1);

        }

        private void WreckerReview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDataSet1.WrekerIntake' table. You can move, or remove it, as needed.
            this.wrekerIntakeTableAdapter.Fill(this.shopDataSet1.WrekerIntake);

        }
    }
}
