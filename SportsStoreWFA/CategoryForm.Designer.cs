namespace SportsStoreWFA
{
    partial class CategoryForm
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition5 = new Telerik.WinControls.UI.TableViewDefinition();
            this.CategoryAdd = new Telerik.WinControls.UI.RadButton();
            this.CategoryEdit = new Telerik.WinControls.UI.RadButton();
            this.CategoryRemove = new Telerik.WinControls.UI.RadButton();
            this.radGridViewCategories = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewCategories.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryAdd
            // 
            this.CategoryAdd.Location = new System.Drawing.Point(12, 12);
            this.CategoryAdd.Name = "CategoryAdd";
            this.CategoryAdd.Size = new System.Drawing.Size(152, 36);
            this.CategoryAdd.TabIndex = 12;
            this.CategoryAdd.Text = "Добавить";
            this.CategoryAdd.ThemeName = "Material";
            this.CategoryAdd.Click += new System.EventHandler(this.CategoryAdd_Click);
            // 
            // CategoryEdit
            // 
            this.CategoryEdit.Location = new System.Drawing.Point(12, 54);
            this.CategoryEdit.Name = "CategoryEdit";
            this.CategoryEdit.Size = new System.Drawing.Size(152, 36);
            this.CategoryEdit.TabIndex = 13;
            this.CategoryEdit.Text = "Редактировать";
            this.CategoryEdit.ThemeName = "Material";
            this.CategoryEdit.Click += new System.EventHandler(this.CategoryEdit_Click);
            // 
            // CategoryRemove
            // 
            this.CategoryRemove.Location = new System.Drawing.Point(12, 96);
            this.CategoryRemove.Name = "CategoryRemove";
            this.CategoryRemove.Size = new System.Drawing.Size(152, 36);
            this.CategoryRemove.TabIndex = 14;
            this.CategoryRemove.Text = "Удалить";
            this.CategoryRemove.ThemeName = "Material";
            this.CategoryRemove.Click += new System.EventHandler(this.CategoryRemove_Click);
            // 
            // radGridViewCategories
            // 
            this.radGridViewCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGridViewCategories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radGridViewCategories.EnableKeyMap = true;
            this.radGridViewCategories.Location = new System.Drawing.Point(186, 12);
            // 
            // 
            // 
            this.radGridViewCategories.MasterTemplate.AllowAddNewRow = false;
            this.radGridViewCategories.MasterTemplate.AllowCellContextMenu = false;
            this.radGridViewCategories.MasterTemplate.AllowColumnChooser = false;
            this.radGridViewCategories.MasterTemplate.AllowDeleteRow = false;
            this.radGridViewCategories.MasterTemplate.AllowDragToGroup = false;
            this.radGridViewCategories.MasterTemplate.AllowEditRow = false;
            this.radGridViewCategories.MasterTemplate.AllowRowResize = false;
            this.radGridViewCategories.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridViewCategories.MasterTemplate.EnableGrouping = false;
            this.radGridViewCategories.MasterTemplate.ShowGroupedColumns = true;
            this.radGridViewCategories.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridViewCategories.MasterTemplate.ViewDefinition = tableViewDefinition5;
            this.radGridViewCategories.MinimumSize = new System.Drawing.Size(300, 340);
            this.radGridViewCategories.Name = "radGridViewCategories";
            // 
            // 
            // 
            this.radGridViewCategories.RootElement.MinSize = new System.Drawing.Size(300, 340);
            this.radGridViewCategories.ShowGroupPanel = false;
            this.radGridViewCategories.Size = new System.Drawing.Size(300, 340);
            this.radGridViewCategories.TabIndex = 15;
            this.radGridViewCategories.ThemeName = "Material";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 363);
            this.Controls.Add(this.radGridViewCategories);
            this.Controls.Add(this.CategoryRemove);
            this.Controls.Add(this.CategoryEdit);
            this.Controls.Add(this.CategoryAdd);
            this.Name = "CategoryForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Категории";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewCategories.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton CategoryAdd;
        private Telerik.WinControls.UI.RadButton CategoryEdit;
        private Telerik.WinControls.UI.RadButton CategoryRemove;
        private Telerik.WinControls.UI.RadGridView radGridViewCategories;
    }
}