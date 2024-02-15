namespace SportsStoreWFA
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;
    using Telerik.Reporting.Data;

    /// <summary>
    /// Summary description for ReportBlank.
    /// </summary>
    public partial class ReportBlank : Telerik.Reporting.Report
    {
        public ReportBlank()
        {
            //
            // Required for telerik Reporting designer support
            //
            
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            //Filter CategoryFilter = new Filter();
            //Filter PriceFilter = new Filter();
            //CategoryFilter.Expression = "=Fields.CatName";
            //CategoryFilter.Operator = FilterOperator.Equal;
            //CategoryFilter.Value = "=Шахматы";
            //Table.Filters.Add(CategoryFilter);

            //Group group = new Group();
            //Grouping groupExpression = new Grouping("Category.CatName");
            //group.Groupings.Add(groupExpression);
            //group.GroupHeader = new GroupHeaderSection();
            //group.GroupHeader.Height = new Unit(1.5, UnitType.Cm);
            //Telerik.Reporting.TextBox tbCategory = new Telerik.Reporting.TextBox();
            //tbCategory.Value = "=Category.CatName";
            //group.GroupHeader.Items.Add(tbCategory);
            //group.GroupFooter = new GroupFooterSection();
            //group.GroupFooter.Height = new Unit(1.5, UnitType.Cm);
            //Telerik.Reporting.TextBox tbTotals = new Telerik.Reporting.TextBox();
            //tbTotals.Value = "=\"Total for \" + Fields.Category.CatName + \" $\" + CStr(Sum(Fields.Total))";
            //tbTotals.Docking = DockingStyle.Fill;
            //tbTotals.Style.TextAlign = HorizontalAlign.Right;
            //tbTotals.Format = "{0:C2}";
            //tbTotals.Style.Font.Bold = true;
            //group.GroupFooter.Items.Add(tbTotals);
            //this.Groups.Add(group);
        }
    }
}