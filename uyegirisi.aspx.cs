using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class uyegirisi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Panel5.Visible = false;
        
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("oto.accdb"));
        baglan.Open();
        string kullanici = TextBox3.Text;
        string parola = TextBox4.Text;
        string isim = TextBox6.Text;
        string soyisim = TextBox7.Text;
        string sehir = TextBox8.Text;
        string dogum = TextBox11.Text;
        string telefon = TextBox10.Text;
        string email = TextBox13.Text;
        string adres = TextBox9.Text;
        string cinsiyet = DropDownList2.SelectedItem.Text;
        OleDbCommand yap = new OleDbCommand("INSERT INTO personel(KullaniciAdi,Parola,Isim,Soyisim,Sehir,Adres,Telefon,DogumTarihi,Cinsiyet,Email) values ('"+ kullanici +"','" + parola + "','" + isim + "','" + soyisim + "','" + sehir + "','" + adres + "','" + telefon + "','" + dogum + "','" + cinsiyet + "','" + email + "')", baglan);
        int oku = yap.ExecuteNonQuery();

        if (oku > 0)
            Label1.Text = "<font color=green>Personel Kayıt Edilmiştir.</font> ";
        else
            Label1.Text = "<font color=red>Personel Kaydedilemedi.</font> ";

        baglan.Close();
        baglan.Dispose();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Panel3.Visible = false;
        Panel5.Visible = true;
        
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("oto.accdb"));
        baglan.Open();
        string silinecek = TextBox20.Text;

        OleDbCommand sil = new OleDbCommand("DELETE FROM personel where KullaniciAdi='" + silinecek + "'", baglan);

        int kayitsil = sil.ExecuteNonQuery();

        if (kayitsil > 0)
            Label3.Text = "<font color=green>Personel Silinmiştir.</font> ";
        else
            Label3.Text = "<font color=red>Personel Silinemedi.</font> ";

        baglan.Close();
        baglan.Dispose();
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("oto.accdb"));
        baglan.Open();
        string seferno = TextBox14.Text;
        string kalkis = TextBox15.Text;
        string varis = TextBox16.Text;
        string kalkissaat = TextBox17.Text;
        string guzergah = TextBox18.Text;
        string fiyat = TextBox19.Text;

        OleDbCommand yap = new OleDbCommand("INSERT INTO istank(SeferNo,KalkisYeri,VarisYeri,KalkisSaati,Guzergah,Fiyat) values ('" + seferno + "','" + kalkis + "','" + varis + "','" + kalkissaat + "','" + guzergah + "','" + fiyat + "')", baglan);
        int oku = yap.ExecuteNonQuery();

        if (oku > 0)
            Label2.Text = "<font color=green>Sefer Eklenmiştir</font> ";
        else
            Label2.Text = "<font color=red>Sefer Eklenemedi</font> ";

        baglan.Close();
        baglan.Dispose();
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("oto.accdb"));
        baglan.Open();
        string silinecek = TextBox21.Text;

        OleDbCommand sil = new OleDbCommand("DELETE FROM istank where SeferNo='" + silinecek + "'", baglan);

        int kayitsil = sil.ExecuteNonQuery();

        if (kayitsil > 0)
            Label4.Text = "<font color=green>Sefer Silinmiştir.</font> ";
        else
            Label4.Text = "<font color=red>Sefer Silinemedi.</font> ";

        baglan.Close();
        baglan.Dispose();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       string kim = DropDownList1.SelectedItem.Value;
       if (kim =="0")
       {
           OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("oto.accdb"));
           baglan.Open();
           string kullanici = TextBox1.Text;
           string sifre = TextBox2.Text;
           OleDbCommand kontrol = new OleDbCommand("SELECT * FROM adminkullanici Where Kullaniciadi='" + kullanici + "'and Parola='" + sifre + "'", baglan);
           OleDbDataReader kontrol2 = kontrol.ExecuteReader();
           if (kontrol2.Read())
           {
               Session.Add("kullaniciadi", kullanici);
               Panel1.Visible = true;
               Panel7.Visible = false;

           }
           else
               Label5.Text = "Hatalı Kullanıcı Adı veya Parola";
           Label5.Visible = true;
           baglan.Close();
           baglan.Dispose();
       }
       else if(kim=="1"){

            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("oto.accdb"));
           baglan.Open();
           string kullanici = TextBox1.Text;
           string sifre = TextBox2.Text;
           OleDbCommand kontrol = new OleDbCommand("SELECT * FROM personel Where KullaniciAdi='" + kullanici + "'and Parola='" + sifre + "'", baglan);
           OleDbDataReader kontrol2 = kontrol.ExecuteReader();
           if (kontrol2.Read())
           {
               Session.Add("kullaniciadi", kullanici);
               Panel2.Visible = true;
               Panel7.Visible = false;

           }
           else
               Label5.Text = "Hatalı Kullanıcı Adı veya Parola";
           Label5.Visible = true;
           baglan.Close();
           baglan.Dispose();
    }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Panel4.Visible = true;
        Panel6.Visible = false;
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Panel4.Visible = false;
        Panel6.Visible = true;
    }
}