using SportsStore.Domain.Abstract;
using SportsStore.Domain.Concrete;
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
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace SportsStoreWFA
{
    public partial class CategoryForm : RadForm
    {
        private IProductRepository repository;

        public CategoryForm()
        {
            repository = new EFProductRepository();
            InitializeComponent();
        }

        private void Read_Categories()
        {
            List<Category> result = repository.Categories.ToList();

            radGridViewCategories.DataSource = result;
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            //-----------------------------GRID VIEW-----------------------------------------------

            Read_Categories();
            //radGridViewCategories.TableElement.RowHeight = 100;
            radGridViewCategories.Columns["CatID"].IsVisible = false;
            radGridViewCategories.Columns["CatName"].HeaderText = "Название";
            radGridViewCategories.Columns["CatName"].MinWidth = 130;
        }

        //-----------------------------------C R U D----------------------------------------------------

        private void ShowEditForm(Category category)
        {
            CategoryEditForm edit = new CategoryEditForm(category);

            if (edit.ShowDialog() == DialogResult.OK)
            {
                Category dbCategory = new Category();
                dbCategory.CatID = category.CatID;
                dbCategory.CatName = category.CatName;
                Category first = repository.Categories.FirstOrDefault(p => p.CatName == dbCategory.CatName);

                if (dbCategory.CatID == 0 && first != null)
                {
                    RadMessageBox.ThemeName = "Material";
                    RadMessageBox.Show("Такой продукт уже существует!");
                }
                else
                {
                    repository.SaveCategory(dbCategory);

                    if (category.CatID == 0)
                    {
                        Read_Categories();
                    }
                }
            }
        }

        private void CategoryAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CatID = 0;
            ShowEditForm(category);
            radGridViewCategories.Focus();
        }

        private void CategoryEdit_Click(object sender, EventArgs e)
        {
            Category category = radGridViewCategories.SelectedRows[0].DataBoundItem as Category;
            ShowEditForm(category);
            radGridViewCategories.Focus();
        }

        private void CategoryRemove_Click(object sender, EventArgs e)
        {
            GridViewRowInfo row = radGridViewCategories.SelectedRows[0];
            RadMessageBox.ThemeName = "Material";
            DialogResult result = RadMessageBox.Show("Вы уверены, что хотите удалить " + (string)row.Cells["CatName"].Value + "?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int CatID = (int)row.Cells["CatID"].Value;
                repository.DeleteCategory(CatID);
                row.Delete();
                row.IsVisible = false;
            }
        }
    }
}
