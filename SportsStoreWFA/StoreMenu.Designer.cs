namespace SportsStoreWFA
{
    partial class StoreMenu
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
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.radMenu = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.CategoriesItem = new Telerik.WinControls.UI.RadMenuItem();
            this.ProductsItem = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenu
            // 
            this.radMenu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1});
            this.radMenu.Location = new System.Drawing.Point(0, 0);
            this.radMenu.Name = "radMenu";
            this.radMenu.Size = new System.Drawing.Size(804, 37);
            this.radMenu.TabIndex = 0;
            this.radMenu.ThemeName = "Material";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.CategoriesItem,
            this.ProductsItem});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Меню";
            // 
            // CategoriesItem
            // 
            this.CategoriesItem.Name = "CategoriesItem";
            this.CategoriesItem.Text = "Категории";
            this.CategoriesItem.Click += new System.EventHandler(this.CategoriesItem_Click);
            // 
            // ProductsItem
            // 
            this.ProductsItem.Name = "ProductsItem";
            this.ProductsItem.Text = "Продукты";
            this.ProductsItem.Click += new System.EventHandler(this.ProductsItem_Click);
            // 
            // StoreMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 563);
            this.Controls.Add(this.radMenu);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "StoreMenu";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Sports Store";
            this.ThemeName = "Material";
            ((System.ComponentModel.ISupportInitialize)(this.radMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadMenu radMenu;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem CategoriesItem;
        private Telerik.WinControls.UI.RadMenuItem ProductsItem;
    }
}