using SportsStore.Domain.Entities;
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
    public partial class CategoryEditForm : RadForm
    {
        private Category category;

        public CategoryEditForm(Category _category)
        {
            InitializeComponent();

            category = _category;
        }

        private bool isValid()
        {
            if (NameBox.Text == "")
            {
                errorProvider1.SetError(NameBox, "Название не может быть пустым!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void SaveCategory_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                DialogResult = DialogResult.OK;
                category.CatName = NameBox.Text;
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private void CategoryEditForm_Load(object sender, EventArgs e)
        {
            NameBox.Text = category.CatName;
        }
    }
}
