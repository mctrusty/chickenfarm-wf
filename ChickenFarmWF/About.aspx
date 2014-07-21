<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ChickenFarmWF.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h3>
    <asp:GridView runat="server" ID="studentsGrid"
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
    </h3>
    
</asp:Content>
