namespace SportsStoreWFA
{
    partial class Report
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
            this.SelectedCategory = new Telerik.WinControls.UI.RadLabel();
            this.SelectedCategoryBox = new Telerik.WinControls.UI.RadDropDownList();
            this.MinPrice = new Telerik.WinControls.UI.RadLabel();
            this.MaxPrice = new Telerik.WinControls.UI.RadLabel();
            this.min = new System.Windows.Forms.NumericUpDown();
            this.max = new System.Windows.Forms.NumericUpDown();
            this.CreateReport = new Telerik.WinControls.UI.RadButton();
            this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCategoryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedCategory
            // 
            this.SelectedCategory.Location = new System.Drawing.Point(13, 22);
            this.SelectedCategory.Name = "SelectedCategory";
            this.SelectedCategory.Size = new System.Drawing.Size(78, 21);
            this.SelectedCategory.TabIndex = 0;
            this.SelectedCategory.Text = "Категория";
            this.SelectedCategory.ThemeName = "Material";
            // 
            // SelectedCategoryBox
            // 
            this.SelectedCategoryBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.SelectedCategoryBox.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.SelectedCategoryBox.FormattingEnabled = false;
            this.SelectedCategoryBox.Location = new System.Drawing.Point(109, 12);
            this.SelectedCategoryBox.Name = "SelectedCategoryBox";
            this.SelectedCategoryBox.Size = new System.Drawing.Size(187, 36);
            this.SelectedCategoryBox.TabIndex = 1;
            this.SelectedCategoryBox.Text = "Не выбрано";
            this.SelectedCategoryBox.ThemeName = "Material";
            // 
            // MinPrice
            // 
            this.MinPrice.Location = new System.Drawing.Point(13, 78);
            this.MinPrice.Name = "MinPrice";
            this.MinPrice.Size = new System.Drawing.Size(61, 21);
            this.MinPrice.TabIndex = 2;
            this.MinPrice.Text = "Цена от";
            this.MinPrice.ThemeName = "Material";
            // 
            // MaxPrice
            // 
            this.MaxPrice.Location = new System.Drawing.Point(195, 78);
            this.MaxPrice.Name = "MaxPrice";
            this.MaxPrice.Size = new System.Drawing.Size(24, 21);
            this.MaxPrice.TabIndex = 3;
            this.MaxPrice.Text = "до";
            this.MaxPrice.ThemeName = "Material";
            // 
            // min
            // 
            this.min.DecimalPlaces = 2;
            this.min.Location = new System.Drawing.Point(80, 78);
            this.min.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(100, 20);
            this.min.TabIndex = 4;
            this.min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // max
            // 
            this.max.DecimalPlaces = 2;
            this.max.Location = new System.Drawing.Point(225, 78);
            this.max.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(100, 20);
            this.max.TabIndex = 5;
            this.max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.max.Value = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            // 
            // CreateReport
            // 
            this.CreateReport.Location = new System.Drawing.Point(618, 12);
            this.CreateReport.Name = "CreateReport";
            this.CreateReport.Size = new System.Drawing.Size(174, 36);
            this.CreateReport.TabIndex = 6;
            this.CreateReport.Text = "Сформировать";
            this.CreateReport.ThemeName = "Material";
            this.CreateReport.Click += new System.EventHandler(this.CreateReport_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.AccessibilityKeyMap = null;
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Location = new System.Drawing.Point(13, 115);
            this.reportViewer1.MinimumSize = new System.Drawing.Size(0, 630);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(830, 630);
            this.reportViewer1.TabIndex = 8;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 763);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.CreateReport);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.MaxPrice);
            this.Controls.Add(this.MinPrice);
            this.Controls.Add(this.SelectedCategoryBox);
            this.Controls.Add(this.SelectedCategory);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(860, 800);
            this.MinimumSize = new System.Drawing.Size(860, 800);
            this.Name = "Report";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(860, 800);
            this.Text = "Отчет";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCategoryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadLabel SelectedCategory;
        private Telerik.WinControls.UI.RadDropDownList SelectedCategoryBox;
        private Telerik.WinControls.UI.RadLabel MinPrice;
        private Telerik.WinControls.UI.RadLabel MaxPrice;
        private System.Windows.Forms.NumericUpDown min;
        private System.Windows.Forms.NumericUpDown max;
        private Telerik.WinControls.UI.RadButton CreateReport;
        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer1;
    }
}