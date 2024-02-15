namespace SportsStoreWFA
{
    partial class CategoryEditForm
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
            this.SaveCategory = new Telerik.WinControls.UI.RadButton();
            this.Cancel = new Telerik.WinControls.UI.RadButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NameLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(23, 50);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(73, 21);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Название";
            this.NameLabel.ThemeName = "Material";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(114, 50);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(170, 36);
            this.NameBox.TabIndex = 2;
            this.NameBox.ThemeName = "Material";
            // 
            // SaveCategory
            // 
            this.SaveCategory.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveCategory.Location = new System.Drawing.Point(23, 140);
            this.SaveCategory.Name = "SaveCategory";
            this.SaveCategory.Size = new System.Drawing.Size(120, 36);
            this.SaveCategory.TabIndex = 10;
            this.SaveCategory.Text = "Сохранить";
            this.SaveCategory.ThemeName = "Material";
            this.SaveCategory.Click += new System.EventHandler(this.SaveCategory_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(164, 140);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(120, 36);
            this.Cancel.TabIndex = 13;
            this.Cancel.Text = "Отмена";
            this.Cancel.ThemeName = "Material";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CategoryEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 203);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SaveCategory);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(345, 240);
            this.MinimumSize = new System.Drawing.Size(345, 240);
            this.Name = "CategoryEditForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(345, 240);
            this.Text = "Новая категория";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.CategoryEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NameLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel NameLabel;
        private Telerik.WinControls.UI.RadTextBox NameBox;
        private Telerik.WinControls.UI.RadButton SaveCategory;
        private Telerik.WinControls.UI.RadButton Cancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}