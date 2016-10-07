<%@ Page Language="VB" AutoEventWireup="false" CodeFile="OrderForm.aspx.vb" Inherits="OrderForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="ddlCategories" runat="server" AutoPostBack="True" DataSourceID="odsCategories"
            DataTextField="Name" DataValueField="CatID" Style="z-index: 100; left: 15px;
            position: absolute; top: 105px" Width="108px">
        </asp:DropDownList>
        <asp:GridView ID="dgvProducts" runat="server" Style="z-index: 101; left: 148px; position: absolute;
            top: 91px" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataSourceID="odsProducts" ForeColor="Black" GridLines="None" AutoGenerateColumns="False">
            <FooterStyle BackColor="Tan" />
            <Columns>
                <asp:CommandField ButtonType="Link" SelectText="Add To Order" ShowSelectButton="True" />
                <asp:BoundField DataField="ProductID" HeaderText="Product ID" />
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Descript" HeaderText="Description" />
                <asp:BoundField DataField="UnitCost" HeaderText="Unit Cost" />
            </Columns>
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
        </asp:GridView>
        <asp:ObjectDataSource ID="odsCategories" runat="server" SelectMethod="GetCategories"
            TypeName="ProductCatalog"></asp:ObjectDataSource>
    
    </div>
        <asp:ObjectDataSource ID="odsProducts" runat="server" SelectMethod="GetProducts"
            TypeName="ProductCatalog">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlCategories" Name="CatID" PropertyName="SelectedValue"
                    Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:Button ID="btnPlaceOrder" runat="server" Style="z-index: 102;
            left: 55px; position: absolute; top: 261px" Text="Place Order" Enabled="False" />
        <asp:GridView ID="dgvOrderItems" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow"
            BorderColor="DarkOrange" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None"
            Style="z-index: 103; left: 170px; position: absolute; top: 301px">
            <FooterStyle BackColor="Tan" />
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="Product ID" />
                <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                <asp:CommandField SelectText="Remove" ShowSelectButton="True" />
            </Columns>
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <HeaderStyle BackColor="DarkOrange" Font-Bold="True" />
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
        </asp:GridView>
        <asp:Label ID="lblMessage" runat="server" Style="z-index: 105; left: 184px; position: absolute;
            top: 264px" Width="311px"></asp:Label>
    </form>
</body>
</html>
