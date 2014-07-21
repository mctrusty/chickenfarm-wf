<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ChickenFarmWF.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView runat="server" ID="farmersGrid"
        ItemType="ChickenFarmWF.Models.Farmer" DataKeyNames="FarmerID" 
        SelectMethod="farmersGrid_getData"
        AutoGenerateColumns="false">
        <Columns>
            <asp:DynamicField DataField="FarmerID" />
            <asp:DynamicField DataField="LastName" />
            <asp:DynamicField DataField="FirstName" />
            <asp:DynamicField DataField="Year" />           
        </Columns>
    </asp:GridView>
</asp:Content>
