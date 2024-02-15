using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace SportsStoreWFA
{
    public partial class StoreMenu : RadForm
    {
        public StoreMenu()
        {
            InitializeComponent();
            LayoutMdi(MdiLayout.Cascade);
        }

        private void CategoriesItem_Click(object sender, EventArgs e)
        {
            CategoryForm categories = new CategoryForm();
            categories.MdiParent = this;
            categories.Show();
        }

        private void ProductsItem_Click(object sender, EventArgs e)
        {
            SportsStore products = new SportsStore();
            products.MdiParent = this;
            products.Show();
        }
    }
}
