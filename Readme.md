<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
<!-- default file list end -->
# ASPxGridView - How to utilize CRUD operations with LinqDataSource and Anonymous Types


<p>With the LinqDataSource you can create Web pages that enable users to update, insert, and delete data.  When you bind the LinqDataSource control with the LINQ to SQL Classes, it performs editing operations via a generated DataContext. You do not need to specify SQL commands, because the LinqDataSource uses dynamically created commands for those operations. To let users modify data, you can enable update, insert, or delete operations on the LinqDataSource control. </p><p><br />
Often, ASPxGridView editors are rendered as read-only. This happens because Anonymous Types are generated, but LINQ does not allow editing anonymous types. You can read more about this in the <a href="http://msdn.microsoft.com/en-us/library/bb397696%28v=vs.90%29.aspx"><u>Anonymous Types (C# Programming Guide)</u></a> MSDN article. A possible solution is to handle the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_CellEditorInitializetopic"><u>ASPxGridView.CellEditorInitialize</u></a> event and set the e.Editor.ReadOnly property to false for those columns which appear as readonly. </p><p>Another solution is to populate the grid with a strong type collection. For example: </p>

```cs
protected void LinqDataSource2_Selecting(object sender, LinqDataSourceSelectEventArgs e) {
        DataClassesDataContext context = new DataClassesDataContext();

        var obj = from i in context.Products
                  select new MyProduct() {
                      ProductID = i.ProductID, ProductName = i.ProductName,
                      SupplierID = i.SupplierID, CategoryID = i.CategoryID,
                      QuantityPerUnit = i.QuantityPerUnit
                  };
        e.Result = obj;
    }
}

   public class MyProduct {
        public int ProductID {
            get;
            set;
        }
      ...
    } 

```

<p>LinqDataSource uses a ViewState to store previous values in it. As ASPxGridView works in callback mode, it is necessary to disable the ViewState or set the LinqDataSource.StoreOriginalValuesInViewState property to false.</p>

<br/>


