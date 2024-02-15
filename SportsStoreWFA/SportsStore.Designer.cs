namespace SportsStoreWFA
{
    partial class SportsStore
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGridViewProducts = new Telerik.WinControls.UI.RadGridView();
            this.radTreeViewCategories = new Telerik.WinControls.UI.RadTreeView();
            this.Remove = new Telerik.WinControls.UI.RadButton();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.Print = new Telerik.WinControls.UI.RadButton();
            this.Excel = new Telerik.WinControls.UI.RadButton();
            this.ToXML = new Telerik.WinControls.UI.RadButton();
            this.FromXML = new Telerik.WinControls.UI.RadButton();
            this.PDF = new Telerik.WinControls.UI.RadButton();
            this.Report = new Telerik.WinControls.UI.RadButton();
            this.radButtonAdd = new Telerik.WinControls.UI.RadButton();
            this.radButtonEdit = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewProducts.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeViewCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Remove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Print)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Excel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToXML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromXML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridViewProducts
            // 
            this.radGridViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGridViewProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radGridViewProducts.EnableKeyMap = true;
            this.radGridViewProducts.Location = new System.Drawing.Point(210, 12);
            // 
            // 
            // 
            this.radGridViewProducts.MasterTemplate.AllowAddNewRow = false;
            this.radGridViewProducts.MasterTemplate.AllowCellContextMenu = false;
            this.radGridViewProducts.MasterTemplate.AllowColumnChooser = false;
            this.radGridViewProducts.MasterTemplate.AllowDeleteRow = false;
            this.radGridViewProducts.MasterTemplate.AllowDragToGroup = false;
            this.radGridViewProducts.MasterTemplate.AllowEditRow = false;
            this.radGridViewProducts.MasterTemplate.AllowRowResize = false;
            this.radGridViewProducts.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridViewProducts.MasterTemplate.EnableGrouping = false;
            this.radGridViewProducts.MasterTemplate.ShowGroupedColumns = true;
            this.radGridViewProducts.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridViewProducts.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridViewProducts.Name = "radGridViewProducts";
            this.radGridViewProducts.ReadOnly = true;
            this.radGridViewProducts.ShowGroupPanel = false;
            this.radGridViewProducts.Size = new System.Drawing.Size(805, 595);
            this.radGridViewProducts.TabIndex = 0;
            this.radGridViewProducts.ThemeName = "Material";
            this.radGridViewProducts.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridViewProducts_CellDoubleClick);
            // 
            // radTreeViewCategories
            // 
            this.radTreeViewCategories.ItemHeight = 36;
            this.radTreeViewCategories.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.radTreeViewCategories.LineStyle = Telerik.WinControls.UI.TreeLineStyle.Solid;
            this.radTreeViewCategories.Location = new System.Drawing.Point(2, 13);
            this.radTreeViewCategories.Name = "radTreeViewCategories";
            this.radTreeViewCategories.Size = new System.Drawing.Size(202, 162);
            this.radTreeViewCategories.SpacingBetweenNodes = -1;
            this.radTreeViewCategories.TabIndex = 1;
            this.radTreeViewCategories.ThemeName = "Material";
            this.radTreeViewCategories.SelectedNodeChanged += new Telerik.WinControls.UI.RadTreeView.RadTreeViewEventHandler(this.radTreeView1_SelectedNodeChanged);
            this.radTreeViewCategories.NodeMouseClick += new Telerik.WinControls.UI.RadTreeView.TreeViewEventHandler(this.radTreeView1_NodeMouseClick);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(31, 277);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(152, 36);
            this.Remove.TabIndex = 4;
            this.Remove.Text = "Удалить";
            this.Remove.ThemeName = "Material";
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(31, 365);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(152, 36);
            this.Print.TabIndex = 5;
            this.Print.Text = "Печать";
            this.Print.ThemeName = "Material";
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // Excel
            // 
            this.Excel.Location = new System.Drawing.Point(31, 407);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(152, 36);
            this.Excel.TabIndex = 6;
            this.Excel.Text = "Экспорт в Excel";
            this.Excel.ThemeName = "Material";
            this.Excel.Click += new System.EventHandler(this.Excel_Click);
            // 
            // ToXML
            // 
            this.ToXML.Location = new System.Drawing.Point(31, 449);
            this.ToXML.Name = "ToXML";
            this.ToXML.Size = new System.Drawing.Size(152, 36);
            this.ToXML.TabIndex = 7;
            this.ToXML.Text = "Экспорт в XML";
            this.ToXML.ThemeName = "Material";
            this.ToXML.Click += new System.EventHandler(this.ToXML_Click);
            // 
            // FromXML
            // 
            this.FromXML.Location = new System.Drawing.Point(31, 532);
            this.FromXML.Name = "FromXML";
            this.FromXML.Size = new System.Drawing.Size(152, 36);
            this.FromXML.TabIndex = 8;
            this.FromXML.Text = "Иморт из XML";
            this.FromXML.ThemeName = "Material";
            this.FromXML.Click += new System.EventHandler(this.FromXML_Click);
            // 
            // PDF
            // 
            this.PDF.Location = new System.Drawing.Point(31, 491);
            this.PDF.Name = "PDF";
            this.PDF.Size = new System.Drawing.Size(152, 36);
            this.PDF.TabIndex = 9;
            this.PDF.Text = "Экспорт в PDF";
            this.PDF.ThemeName = "Material";
            this.PDF.Click += new System.EventHandler(this.PDF_Click);
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(31, 574);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(152, 36);
            this.Report.TabIndex = 10;
            this.Report.Text = "Отчет";
            this.Report.ThemeName = "Material";
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // radButtonAdd
            // 
            this.radButtonAdd.Location = new System.Drawing.Point(31, 193);
            this.radButtonAdd.Name = "radButtonAdd";
            this.radButtonAdd.Size = new System.Drawing.Size(152, 36);
            this.radButtonAdd.TabIndex = 11;
            this.radButtonAdd.Text = "Добавить";
            this.radButtonAdd.ThemeName = "Material";
            this.radButtonAdd.Click += new System.EventHandler(this.radButtonAdd_Click);
            // 
            // radButtonEdit
            // 
            this.radButtonEdit.Location = new System.Drawing.Point(31, 235);
            this.radButtonEdit.Name = "radButtonEdit";
            this.radButtonEdit.Size = new System.Drawing.Size(152, 36);
            this.radButtonEdit.TabIndex = 12;
            this.radButtonEdit.Text = "Редактировать";
            this.radButtonEdit.ThemeName = "Material";
            this.radButtonEdit.Click += new System.EventHandler(this.radButtonEdit_Click);
            // 
            // SportsStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 653);
            this.Controls.Add(this.radButtonEdit);
            this.Controls.Add(this.radButtonAdd);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.PDF);
            this.Controls.Add(this.FromXML);
            this.Controls.Add(this.ToXML);
            this.Controls.Add(this.Excel);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.radTreeViewCategories);
            this.Controls.Add(this.radGridViewProducts);
            this.MinimumSize = new System.Drawing.Size(1025, 660);
            this.Name = "SportsStore";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(0, 0);
            this.Text = "Продукты";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.SportsStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewProducts.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeViewCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Remove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Print)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Excel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToXML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromXML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridViewProducts;
        private Telerik.WinControls.UI.RadTreeView radTreeViewCategories;
        private Telerik.WinControls.UI.RadButton Remove;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadButton Print;
        private Telerik.WinControls.UI.RadButton Excel;
        private Telerik.WinControls.UI.RadButton ToXML;
        private Telerik.WinControls.UI.RadButton FromXML;
        private Telerik.WinControls.UI.RadButton PDF;
        private Telerik.WinControls.UI.RadButton Report;
        private Telerik.WinControls.UI.RadButton radButtonAdd;
        private Telerik.WinControls.UI.RadButton radButtonEdit;
    }
}

