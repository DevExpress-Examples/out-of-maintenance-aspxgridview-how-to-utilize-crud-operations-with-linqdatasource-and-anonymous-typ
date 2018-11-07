'INSTANT VB NOTE: This code snippet uses implicit typing. You will need to set 'Option Infer On' in the VB file or set 'Option Infer' at the project level:

<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource2"
			KeyFieldName="ProductID" onrowupdating="ASPxGridView1_RowUpdating">
			<Columns>
                <dx:GridViewCommandColumn VisibleIndex="0" ShowEditButton="True"/>
				<dx:GridViewDataTextColumn FieldName="ProductID" VisibleIndex="0">
				</dx:GridViewDataTextColumn>
				<dx:GridViewDataTextColumn FieldName="ProductName" VisibleIndex="1">
				</dx:GridViewDataTextColumn>
				<dx:GridViewDataTextColumn FieldName="SupplierID" VisibleIndex="2">
				</dx:GridViewDataTextColumn>
				<dx:GridViewDataComboBoxColumn FieldName="CategoryID" VisibleIndex="3">
					<PropertiesComboBox ValueType="System.Int32" DataSourceID="LinqDataSource1" TextField="CategoryName"
						ValueField="CategoryID">
					</PropertiesComboBox>
				</dx:GridViewDataComboBoxColumn>
				<dx:GridViewDataTextColumn FieldName="QuantityPerUnit" VisibleIndex="4">
				</dx:GridViewDataTextColumn>
			</Columns>
		</dx:ASPxGridView>
		<asp:LinqDataSource ID="LinqDataSource2" runat="server" ContextTypeName="DataClassesDataContext"
			EnableUpdate="true" TableName="Products" 
			OnSelecting="LinqDataSource2_Selecting" StoreOriginalValuesInViewState="False">
		</asp:LinqDataSource>
		<asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="DataClassesDataContext"
			Select="new (CategoryID, CategoryName)" TableName="Categories">
		</asp:LinqDataSource>
	</div>
	</form>
</body>
</html>