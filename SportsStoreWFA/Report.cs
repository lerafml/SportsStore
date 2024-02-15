using SportsStore.Domain.Abstract;
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
using Telerik.ReportViewer.WinForms;
using Telerik.WinControls.UI;

namespace SportsStoreWFA
{

    public partial class Report : RadForm
    {
        private IProductRepository repository;
        private List<string> categories;

        public Report(IProductRepository repository)
        {
            this.repository = repository;
            categories = new List<string>();
            categories.Add("Все категории");
            foreach (Category category in repository.Categories)
            {
                categories.Add(category.CatName);
            }
            InitializeComponent();
            SelectedCategoryBox.DataSource = categories;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
        }

        private void CreateReport_Click(object sender, EventArgs e)
        {
            ReportBlank report = new ReportBlank();

            var selectedCategory = SelectedCategoryBox.Text;
            report.ReportParameters["selectedCategory"].Value = selectedCategory;

            if (selectedCategory != "Все категории")
            {
                report.Table.DataSource = repository.Products.Where(x => (x.Category.CatName == selectedCategory) && (x.Price <= max.Value) && (x.Price >= min.Value)).ToList();
            }
            else
            {
                report.Table.DataSource = repository.Products.Where(x => (x.Price <= max.Value) && (x.Price >= min.Value)).ToList();
            }

            Telerik.Reporting.InstanceReportSource typeReportSource = new Telerik.Reporting.InstanceReportSource();
            typeReportSource.ReportDocument = report;
            reportViewer1.ReportSource = typeReportSource;
            reportViewer1.ViewMode = ViewMode.PrintPreview;
            reportViewer1.RefreshReport();
        }
    }
}
