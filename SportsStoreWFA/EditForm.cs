using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStoreWFA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace SportsStoreWFA
{
    public partial class EditForm : RadForm
    {
        private ProductViewModel product;
     

        public EditForm(ProductViewModel _product)
        {
            InitializeComponent();

            product = _product;

        }

       

        public Image ConvertToImage(byte[] array)
        {
            using (var ms = new MemoryStream(array))
            {
                return Image.FromStream(ms);
            }
        }

        private byte[] ConvertToByte(Image img)
        {
            using (var ms = new MemoryStream())
            {
                Bitmap bmp = new Bitmap(img);
                bmp.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            RadOpenFileDialog ofd = new RadOpenFileDialog();
            ofd.Filter = "Изображения|*.jpg;*.png;*.bmp";
            ofd.OpenFileDialogForm.ThemeName = "Material";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ImageBox.Image = ConvertToImage(File.ReadAllBytes(ofd.FileName));
            }
        }

        private bool isValid()
        {
            bool result = true;

            if (NameBox.Text == "")
            {
                errorProvider1.SetError(NameBox, "Название не может быть пустым!");
                result = false;
            }


            if (DescriptionBox.Text == "")
            {
                errorProvider1.SetError(DescriptionBox, "Описание не может быть пустым!");
                result = false;
            }

            if (DropDownBoxCategory.SelectedIndex < 0)
            {
                errorProvider1.SetError(DropDownBoxCategory, "Выберите категорию!");
                result = false;
            }

            if (PriceBox.Value == 0)
            {
                errorProvider1.SetError(PriceBox, "Укажите цену!");
                result = false;
            }

            return result;
        }

        private void SaveProduct_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                DialogResult = DialogResult.OK;
                product.Name = NameBox.Text;
                product.Description = DescriptionBox.Text;
                product.Price = PriceBox.Value;
                product.CatID = (int)DropDownBoxCategory.SelectedValue;

                if (ImageBox.Image != null)
                {
                    product.ImageData = ConvertToByte(ImageBox.Image);
                }
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

    

        private void EditForm_Load(object sender, EventArgs e)
        {
            NameBox.Text = product.Name;
            DescriptionBox.Text = product.Description;
            PriceBox.Value = product.Price;
            DropDownBoxCategory.SelectedValue = product.CatID;
            ImageBox.Image = ConvertToImage(product.ImageData);
        }
    }
}
