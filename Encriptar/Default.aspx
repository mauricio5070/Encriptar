<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Encriptar._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    

        <div class="col-md-4">
            <h2>Encriptar</h2>
            <asp:TextBox ID="txtOriginal" runat="server" class="form-control"></asp:TextBox>
            <asp:TextBox ID="txtencriptado" runat="server" class="form-control"></asp:TextBox>
            <asp:Button ID="btnEncriptar" runat="server" Text="Encriptar"  class="btn btn-success" OnClick="btnEncriptar_Click" />
            <asp:Button ID="btnDecriptar" runat="server" Text="Decriptar"  class="btn btn-info" />
        </div>


    </asp:Content>
