<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style8
        {
            height: 278px;
            width: 630px;
        }
        .style12
        {
            width: 236px;
            height: 177px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ImageButton ID="ImageButton1" runat="server" 
    ImageUrl="~/Resimler/BiletAl.png" PostBackUrl="~/bilet.aspx" 
    onclick="ImageButton1_Click" />
    <br />
    <br />
    <img alt="" class="style12" src="Resimler/istanbul-servis.jpg" /><br />
    <br />
    <br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p>
    <img alt="" class="style8" src="Resimler/IMG_1343.jpg" /></p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>

