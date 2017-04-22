<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <h3>Available Record(s)</h3>
        <asp:GridView ID="gridView" runat="server" GridLines="None" CssClass="table table-striped"></asp:GridView>
    </div>

</asp:Content>
