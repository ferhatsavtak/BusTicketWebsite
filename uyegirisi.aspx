<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="uyegirisi.aspx.cs" Inherits="uyegirisi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style8
    {
        color: #0000FF;
        font-size: x-large;
    }
    .style9
    {
        color: #0066FF;
        font-size: xx-large;
    }
    .style10
    {
        color: #0066FF;
        font-size: x-large;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel7" runat="server">
        <p>
            &nbsp;</p>
        <p>
            Kullanı Adı :
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            Parola :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="142px"></asp:TextBox>
        </p>
        <p>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="0">Admin</asp:ListItem>
                <asp:ListItem Value="1">Personel</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Giriş Yap" 
            onclick="Button1_Click" />
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" ForeColor="Red"></asp:Label>
        </p>
    </asp:Panel>
    <p>
        <br />
    </p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Panel ID="Panel1" runat="server" style="text-align: center" 
        Visible="False">
        <span class="style10"><strong>Admin Menüsü</strong></span><br />
        <br />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="Personel Ekle" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Personel Sil" 
            onclick="Button3_Click" />
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel2" runat="server" style="text-align: center" 
    Visible="False">
        <strong><span class="style10">Personel Menüsü</span><br class="style10" />
        </strong><br />
        <asp:Button ID="Button4" runat="server" Text="Sefer Ekle" 
            onclick="Button4_Click" />
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" Text="Sefer Sil" 
            onclick="Button5_Click" />
        <br />
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel3" runat="server" style="text-align: center" 
    Visible="False">
        <strong><span class="style8">Personel Kaydetme</span><br class="style8" />
        </strong><br />
        Kullanıcı Adı :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        Parola :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        Parola Tekrar :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        İsim :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <br />
        Soyisim :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        <br />
        Şehir :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        <br />
        <br />
        Adres :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        <br />
        <br />
        Telefon :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        <br />
        <br />
        Doğum Tarihi :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
        <br />
        <br />
        Cinsiyet :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" style="margin-left: 0px" 
            Width="94px">
            <asp:ListItem>BAY</asp:ListItem>
            <asp:ListItem>BAYAN</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        E-Mail :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button6" runat="server" onclick="Button6_Click" 
            Text="Personeli Kaydet" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel4" runat="server" style="text-align: center" 
    Visible="False">
        <span class="style9"><strong>Sefer Ekleme</strong></span><br />
        <br />
        <br />
        Sefer No :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
        <br />
        <br />
        Kalkış Yeri :&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
        <br />
        <br />
        Varış Yeri :&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
        <br />
        <br />
        Kalkış Saati :&nbsp;&nbsp;
        <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
        <br />
        <br />
        Güzergah :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
        <br />
        <br />
        Fiyat :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button7" runat="server" Text="Seferi Kaydet" 
            onclick="Button7_Click" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel5" runat="server" style="text-align: center" 
    Visible="False">
        <strong><span class="style10">Personel Silme</span><br class="style10" />
        </strong><br />
        Silmek İstediğiniz Personelin Kullanıcı Adını Giriniz<br />
        <br />
        <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button8" runat="server" onclick="Button8_Click" 
            Text="Personeli Sil" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
        <br />
    </asp:Panel>
    <br />
    <br />
    <asp:Panel ID="Panel6" runat="server" style="text-align: center" 
    Visible="False">
        <span class="style10"><strong>Sefer Silme</strong></span><br />
        <br />
        Silmek İstediğiniz Seferin Numarasını Giriniz<br />
        <br />
        <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button9" runat="server" onclick="Button9_Click" 
            Text="Seferi Sil" />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server"></asp:Label>
    </asp:Panel>
</asp:Content>

