<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <h3>Available Record(s)</h3>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:GridView ID="gridView" runat="server" CssClass="table table-striped" GridLines="None" OnRowDeleting="gridView_RowDeleting">
                    <Columns>
                        <asp:CommandField ButtonType="Image" EditImageUrl="~/Media/edit_icon.png" EditText="" ShowEditButton="True">
                        <ControlStyle Height="20px" Width="20px" />
                        </asp:CommandField>
                        <asp:CommandField ButtonType="Image" DeleteImageUrl="~/Media/delete_icon.png" ShowDeleteButton="True">
                        <ControlStyle Height="20px" Width="20px" />
                        </asp:CommandField>
                    </Columns>
                </asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>

</asp:Content>
