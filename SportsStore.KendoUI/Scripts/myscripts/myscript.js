$(document).ready(function () {
   
    var grid = $("#products");
    grid.find(".k-grid-toolbar").on("click", ".k-pager-refresh", function (e) {
        e.preventDefault();
        grid.data("kendoGrid").dataSource.read();
    });

});

/*function AddToCart(e) {
    e.preventDefault():
    var dataItem = grid.dataItem($(e.currentTarget).closest("tr"));
}
*/
function onSelect(e) {
    var grid = $("#products").data("kendoGrid");
    var treeview = $("#categories").data("kendoTreeView");
    var value = treeview.dataItem(e.node).CatId;
    if (value) {
        grid.dataSource.filter({ field: "Category.CatId", operator: "eq", value: parseInt(value) });
    }
    else
    {
        grid.dataSource.filter({});
    }
}
