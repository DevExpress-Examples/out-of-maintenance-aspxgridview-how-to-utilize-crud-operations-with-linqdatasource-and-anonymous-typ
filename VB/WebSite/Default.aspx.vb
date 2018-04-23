Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub
	Protected Sub LinqDataSource2_Selecting(ByVal sender As Object, ByVal e As LinqDataSourceSelectEventArgs)
		Dim context As New DataClassesDataContext()

		Dim obj = _
			From i In context.Products _
			Select New MyProduct() With {.ProductID = i.ProductID, .ProductName = i.ProductName, .SupplierID = i.SupplierID, .CategoryID = i.CategoryID, .QuantityPerUnit = i.QuantityPerUnit}
		e.Result = obj
	End Sub
	Protected Sub ASPxGridView1_RowUpdating(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs)
		Throw New Exception("Data modifications are not allowed in the online example. <br />If you need to test the data editing functionality, please download the example on your machine and run it locally.")
	End Sub
End Class

Public Class MyProduct

	Private privateProductID As Integer
	Public Property ProductID() As Integer
		Get
			Return privateProductID
		End Get
		Set(ByVal value As Integer)
			privateProductID = value
		End Set
	End Property

	Private privateProductName As String
	Public Property ProductName() As String
		Get
			Return privateProductName
		End Get
		Set(ByVal value As String)
			privateProductName = value
		End Set
	End Property

	Private privateSupplierID As Nullable(Of Integer)
	Public Property SupplierID() As Nullable(Of Integer)
		Get
			Return privateSupplierID
		End Get
		Set(ByVal value As Nullable(Of Integer))
			privateSupplierID = value
		End Set
	End Property

	Private privateCategoryID As Nullable(Of Integer)
	Public Property CategoryID() As Nullable(Of Integer)
		Get
			Return privateCategoryID
		End Get
		Set(ByVal value As Nullable(Of Integer))
			privateCategoryID = value
		End Set
	End Property

	Private privateQuantityPerUnit As String
	Public Property QuantityPerUnit() As String
		Get
			Return privateQuantityPerUnit
		End Get
		Set(ByVal value As String)
			privateQuantityPerUnit = value
		End Set
	End Property

End Class