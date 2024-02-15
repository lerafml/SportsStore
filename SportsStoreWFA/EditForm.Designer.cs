namespace SportsStoreWFA
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NameLabel = new Telerik.WinControls.UI.RadLabel();
            this.NameBox = new Telerik.WinControls.UI.RadTextBox();
            this.DescriptionLabel = new Telerik.WinControls.UI.RadLabel();
            this.DescriptionBox = new Telerik.WinControls.UI.RadTextBox();
            this.CategoryLabel = new Telerik.WinControls.UI.RadLabel();
            this.DropDownBoxCategory = new Telerik.WinControls.UI.RadDropDownList();
            this.PriceLabel = new Telerik.WinControls.UI.RadLabel();
            this.PriceBox = new System.Windows.Forms.NumericUpDown();
            this.ImageLabel = new Telerik.WinControls.UI.RadLabel();
            this.SaveProduct = new Telerik.WinControls.UI.RadButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Upload = new Telerik.WinControls.UI.RadButton();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.Cancel = new Telerik.WinControls.UI.RadButton();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NameLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DropDownBoxCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Upload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(22, 46);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(73, 21);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Название";
            this.NameLabel.ThemeName = "Material";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(119, 46);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(185, 36);
            this.NameBox.TabIndex = 1;
            this.NameBox.ThemeName = "Material";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Location = new System.Drawing.Point(22, 114);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(73, 21);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "Описание";
            this.DescriptionLabel.ThemeName = "Material";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(119, 114);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(185, 36);
            this.DescriptionBox.TabIndex = 3;
            this.DescriptionBox.ThemeName = "Material";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Location = new System.Drawing.Point(22, 191);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(78, 21);
            this.CategoryLabel.TabIndex = 4;
            this.CategoryLabel.Text = "Категория";
            this.CategoryLabel.ThemeName = "Material";
            // 
            // DropDownBoxCategory
            // 
            this.DropDownBoxCategory.DisplayMember = "CatName";
            this.DropDownBoxCategory.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.DropDownBoxCategory.FormattingEnabled = false;
            this.DropDownBoxCategory.Location = new System.Drawing.Point(119, 191);
            this.DropDownBoxCategory.Name = "DropDownBoxCategory";
            this.DropDownBoxCategory.Size = new System.Drawing.Size(185, 36);
            this.DropDownBoxCategory.TabIndex = 5;
            this.DropDownBoxCategory.ThemeName = "Material";
            this.DropDownBoxCategory.ValueMember = "CatID";
            // 
            // PriceLabel
            // 
            this.PriceLabel.Location = new System.Drawing.Point(22, 260);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(42, 21);
            this.PriceLabel.TabIndex = 6;
            this.PriceLabel.Text = "Цена";
            this.PriceLabel.ThemeName = "Material";
            // 
            // PriceBox
            // 
            this.PriceBox.AutoSize = true;
            this.PriceBox.DecimalPlaces = 2;
            this.PriceBox.Location = new System.Drawing.Point(140, 260);
            this.PriceBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(115, 20);
            this.PriceBox.TabIndex = 7;
            this.PriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ImageLabel
            // 
            this.ImageLabel.Location = new System.Drawing.Point(22, 314);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(101, 21);
            this.ImageLabel.TabIndex = 8;
            this.ImageLabel.Text = "Изображение";
            this.ImageLabel.ThemeName = "Material";
            // 
            // SaveProduct
            // 
            this.SaveProduct.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveProduct.Location = new System.Drawing.Point(34, 454);
            this.SaveProduct.Name = "SaveProduct";
            this.SaveProduct.Size = new System.Drawing.Size(120, 36);
            this.SaveProduct.TabIndex = 9;
            this.SaveProduct.Text = "Сохранить";
            this.SaveProduct.ThemeName = "Material";
            this.SaveProduct.Click += new System.EventHandler(this.SaveProduct_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(140, 314);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(112, 36);
            this.Upload.TabIndex = 10;
            this.Upload.Text = "Выбрать...";
            this.Upload.ThemeName = "Material";
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // ImageBox
            // 
            this.ImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImageBox.Location = new System.Drawing.Point(140, 356);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(112, 79);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 11;
            this.ImageBox.TabStop = false;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(160, 454);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(120, 36);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "Отмена";
            this.Cancel.ThemeName = "Material";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 509);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.SaveProduct);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.DropDownBoxCategory);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameLabel);
            this.MaximizeBox = false;
            this.Name = "EditForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Новый продукт";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NameLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DropDownBoxCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Upload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel NameLabel;
        private Telerik.WinControls.UI.RadTextBox NameBox;
        private Telerik.WinControls.UI.RadLabel DescriptionLabel;
        private Telerik.WinControls.UI.RadTextBox DescriptionBox;
        private Telerik.WinControls.UI.RadLabel CategoryLabel;
        public Telerik.WinControls.UI.RadDropDownList DropDownBoxCategory;
        private Telerik.WinControls.UI.RadLabel PriceLabel;
        private System.Windows.Forms.NumericUpDown PriceBox;
        private Telerik.WinControls.UI.RadLabel ImageLabel;
        private Telerik.WinControls.UI.RadButton SaveProduct;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Telerik.WinControls.UI.RadButton Upload;
        private System.Windows.Forms.PictureBox ImageBox;
        private Telerik.WinControls.UI.RadButton Cancel;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}