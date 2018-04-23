using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
    }
    protected void LinqDataSource2_Selecting(object sender, LinqDataSourceSelectEventArgs e) {
        DataClassesDataContext context = new DataClassesDataContext();

        var obj = from i in context.Products
                  select new MyProduct() {
                      ProductID = i.ProductID,
                      ProductName = i.ProductName,
                      SupplierID = i.SupplierID,
                      CategoryID = i.CategoryID,
                      QuantityPerUnit = i.QuantityPerUnit
                  };
        e.Result = obj;
    }
    protected void ASPxGridView1_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e) {
        throw new Exception("Data modifications are not allowed in the online example. <br />If you need to test the data editing functionality, please download the example on your machine and run it locally.");
    }
}

public class MyProduct {

    public int ProductID {
        get;
        set;
    }

    public string ProductName {
        get;
        set;
    }

    public int? SupplierID {
        get;
        set;
    }

    public int? CategoryID {
        get;
        set;
    }

    public string QuantityPerUnit {
        get;
        set;
    }

}