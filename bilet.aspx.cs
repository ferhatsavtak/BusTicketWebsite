using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class bilet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string nereden = DropDownList1.SelectedItem.Text;
        string nereye = DropDownList2.SelectedItem.Text;
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("oto.accdb"));
        baglan.Open();
        string sor = " SELECT * FROM istank WHERE KalkisYeri='" + nereden + "' AND VarisYeri='" + nereye + "' ";
        OleDbDataAdapter sorgu = new OleDbDataAdapter(sor, baglan);
        DataSet DataSet1 = new DataSet();
        sorgu.Fill(DataSet1, "getir");
        GridView1.DataSource = DataSet1.Tables["getir"];
        GridView1.DataBind();

        baglan.Close();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Panel4.Visible = true;
        
        if (DropDownList1.SelectedValue == "0" & DropDownList2.SelectedValue == "1" & GridView1.SelectedIndex == 0)
        {

            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("oto.accdb"));

            OleDbCommand olustur = new OleDbCommand();



            baglan.Open();
            olustur.Connection = baglan;
            olustur.CommandText = "select * from istank where id=3";
            olustur.ExecuteNonQuery();
            OleDbDataReader okuma = olustur.ExecuteReader();
            if (okuma.Read())
            {
                Label3.Text = Calendar1.SelectedDate.ToShortDateString();
                Label4.Text = okuma["SeferNo"].ToString();
                Label5.Text = okuma["Guzergah"].ToString();
                Label6.Text = okuma["KalkisSaati"].ToString();
                Label7.Text = okuma["KalkisYeri"].ToString();
                Label11.Text = okuma["Fiyat"].ToString();
                Label8.Text = TextBox2.Text + " " + TextBox2.Text;
                Label9.Text = Label1.Text;
                Label10.Text = DropDownList3.SelectedItem.Text;
                
            }
        }

        else if (DropDownList1.SelectedValue == "0" & DropDownList2.SelectedValue == "1" & GridView1.SelectedIndex == 1)
        {

            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("oto.accdb"));

            OleDbCommand olustur = new OleDbCommand();



            baglan.Open();
            olustur.Connection = baglan;
            olustur.CommandText = "select * from istank where id=4";
            olustur.ExecuteNonQuery();
            OleDbDataReader okuma = olustur.ExecuteReader();
            if (okuma.Read())
            {
                Label3.Text = Calendar1.SelectedDate.ToShortDateString();
                Label4.Text = okuma["SeferNo"].ToString();
                Label5.Text = okuma["Guzergah"].ToString();
                Label6.Text = okuma["KalkisSaati"].ToString();
                Label7.Text = okuma["KalkisYeri"].ToString();
                Label11.Text = okuma["Fiyat"].ToString();
                Label8.Text = TextBox2.Text + " " + TextBox2.Text;
                Label9.Text = Label1.Text;
                Label10.Text = DropDownList3.SelectedItem.Text;

            }
        }

        else if (DropDownList1.SelectedValue == "0" & DropDownList2.SelectedValue == "1" & GridView1.SelectedIndex == 2)
        {

            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("oto.accdb"));

            OleDbCommand olustur = new OleDbCommand();



            baglan.Open();
            olustur.Connection = baglan;
            olustur.CommandText = "select * from istank where id=5";
            olustur.ExecuteNonQuery();
            OleDbDataReader okuma = olustur.ExecuteReader();
            if (okuma.Read())
            {
                Label3.Text = Calendar1.SelectedDate.ToShortDateString();
                Label4.Text = okuma["SeferNo"].ToString();
                Label5.Text = okuma["Guzergah"].ToString();
                Label6.Text = okuma["KalkisSaati"].ToString();
                Label7.Text = okuma["KalkisYeri"].ToString();
                Label11.Text = okuma["Fiyat"].ToString();
                Label8.Text = TextBox2.Text + " " + TextBox2.Text;
                Label9.Text = Label1.Text;
                Label10.Text = DropDownList3.SelectedItem.Text;

            }
        }

        else if (DropDownList1.SelectedValue == "0" & DropDownList2.SelectedValue == "2" & GridView1.SelectedIndex == 0)
        {

            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("oto.accdb"));

            OleDbCommand olustur = new OleDbCommand();



            baglan.Open();
            olustur.Connection = baglan;
            olustur.CommandText = "select * from istank where id=6";
            olustur.ExecuteNonQuery();
            OleDbDataReader okuma = olustur.ExecuteReader();
            if (okuma.Read())
            {
                Label3.Text = Calendar1.SelectedDate.ToShortDateString();
                Label4.Text = okuma["SeferNo"].ToString();
                Label5.Text = okuma["Guzergah"].ToString();
                Label6.Text = okuma["KalkisSaati"].ToString();
                Label7.Text = okuma["KalkisYeri"].ToString();
                Label11.Text = okuma["Fiyat"].ToString();
                Label8.Text = TextBox2.Text + " " + TextBox2.Text;
                Label9.Text = Label1.Text;
                Label10.Text = DropDownList3.SelectedItem.Text;

            }
        }

        else if (DropDownList1.SelectedValue == "0" & DropDownList2.SelectedValue == "2" & GridView1.SelectedIndex == 1)
        {

            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("oto.accdb"));

            OleDbCommand olustur = new OleDbCommand();



            baglan.Open();
            olustur.Connection = baglan;
            olustur.CommandText = "select * from istank where id=7";
            olustur.ExecuteNonQuery();
            OleDbDataReader okuma = olustur.ExecuteReader();
            if (okuma.Read())
            {
                Label3.Text = Calendar1.SelectedDate.ToShortDateString();
                Label4.Text = okuma["SeferNo"].ToString();
                Label5.Text = okuma["Guzergah"].ToString();
                Label6.Text = okuma["KalkisSaati"].ToString();
                Label7.Text = okuma["KalkisYeri"].ToString();
                Label11.Text = okuma["Fiyat"].ToString();
                Label8.Text = TextBox2.Text + " " + TextBox2.Text;
                Label9.Text = Label1.Text;
                Label10.Text = DropDownList3.SelectedItem.Text;

            }
        }

        else if (DropDownList1.SelectedValue == "0" & DropDownList2.SelectedValue == "3" & GridView1.SelectedIndex == 0)
        {

            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("oto.accdb"));

            OleDbCommand olustur = new OleDbCommand();



            baglan.Open();
            olustur.Connection = baglan;
            olustur.CommandText = "select * from istank where id=8";
            olustur.ExecuteNonQuery();
            OleDbDataReader okuma = olustur.ExecuteReader();
            if (okuma.Read())
            {
                Label3.Text = Calendar1.SelectedDate.ToShortDateString();
                Label4.Text = okuma["SeferNo"].ToString();
                Label5.Text = okuma["Guzergah"].ToString();
                Label6.Text = okuma["KalkisSaati"].ToString();
                Label7.Text = okuma["KalkisYeri"].ToString();
                Label11.Text = okuma["Fiyat"].ToString();
                Label8.Text = TextBox2.Text + " " + TextBox2.Text;
                Label9.Text = Label1.Text;
                Label10.Text = DropDownList3.SelectedItem.Text;

            }
        }

        else if (DropDownList1.SelectedValue == "0" & DropDownList2.SelectedValue == "3" & GridView1.SelectedIndex == 1)
        {

            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("oto.accdb"));

            OleDbCommand olustur = new OleDbCommand();



            baglan.Open();
            olustur.Connection = baglan;
            olustur.CommandText = "select * from istank where id=9";
            olustur.ExecuteNonQuery();
            OleDbDataReader okuma = olustur.ExecuteReader();
            if (okuma.Read())
            {
                Label3.Text = Calendar1.SelectedDate.ToShortDateString();
                Label4.Text = okuma["SeferNo"].ToString();
                Label5.Text = okuma["Guzergah"].ToString();
                Label6.Text = okuma["KalkisSaati"].ToString();
                Label7.Text = okuma["KalkisYeri"].ToString();
                Label11.Text = okuma["Fiyat"].ToString();
                Label8.Text = TextBox2.Text + " " + TextBox2.Text;
                Label9.Text = Label1.Text;
                Label10.Text = DropDownList3.SelectedItem.Text;

            }
        }

        else if (DropDownList1.SelectedValue == "0" & DropDownList2.SelectedValue == "3" & GridView1.SelectedIndex == 2)
        {

            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("oto.accdb"));

            OleDbCommand olustur = new OleDbCommand();



            baglan.Open();
            olustur.Connection = baglan;
            olustur.CommandText = "select * from istank where id=10";
            olustur.ExecuteNonQuery();
            OleDbDataReader okuma = olustur.ExecuteReader();
            if (okuma.Read())
            {
                Label3.Text = Calendar1.SelectedDate.ToShortDateString();
                Label4.Text = okuma["SeferNo"].ToString();
                Label5.Text = okuma["Guzergah"].ToString();
                Label6.Text = okuma["KalkisSaati"].ToString();
                Label7.Text = okuma["KalkisYeri"].ToString();
                Label11.Text = okuma["Fiyat"].ToString();
                Label8.Text = TextBox2.Text + " " + TextBox2.Text;
                Label9.Text = Label1.Text;
                Label10.Text = DropDownList3.SelectedItem.Text;

            }
        }

        else if (DropDownList1.SelectedValue == "0" & DropDownList2.SelectedValue == "4" & GridView1.SelectedIndex == 0)
        {

            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("oto.accdb"));

            OleDbCommand olustur = new OleDbCommand();



            baglan.Open();
            olustur.Connection = baglan;
            olustur.CommandText = "select * from istank where id=11";
            olustur.ExecuteNonQuery();
            OleDbDataReader okuma = olustur.ExecuteReader();
            if (okuma.Read())
            {
                Label3.Text = Calendar1.SelectedDate.ToShortDateString();
                Label4.Text = okuma["SeferNo"].ToString();
                Label5.Text = okuma["Guzergah"].ToString();
                Label6.Text = okuma["KalkisSaati"].ToString();
                Label7.Text = okuma["KalkisYeri"].ToString();
                Label11.Text = okuma["Fiyat"].ToString();
                Label8.Text = TextBox2.Text + " " + TextBox2.Text;
                Label9.Text = Label1.Text;
                Label10.Text = DropDownList3.SelectedItem.Text;

            }
        }

        else if (DropDownList1.SelectedValue == "0" & DropDownList2.SelectedValue == "4" & GridView1.SelectedIndex == 1)
        {

            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("oto.accdb"));

            OleDbCommand olustur = new OleDbCommand();



            baglan.Open();
            olustur.Connection = baglan;
            olustur.CommandText = "select * from istank where id=12";
            olustur.ExecuteNonQuery();
            OleDbDataReader okuma = olustur.ExecuteReader();
            if (okuma.Read())
            {
                Label3.Text = Calendar1.SelectedDate.ToShortDateString();
                Label4.Text = okuma["SeferNo"].ToString();
                Label5.Text = okuma["Guzergah"].ToString();
                Label6.Text = okuma["KalkisSaati"].ToString();
                Label7.Text = okuma["KalkisYeri"].ToString();
                Label11.Text = okuma["Fiyat"].ToString();
                Label8.Text = TextBox2.Text + " " + TextBox2.Text;
                Label9.Text = Label1.Text;
                Label10.Text = DropDownList3.SelectedItem.Text;

            }
        }

        else if (DropDownList1.SelectedValue == "0" & DropDownList2.SelectedValue == "4" & GridView1.SelectedIndex == 2)
        {

            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("oto.accdb"));

            OleDbCommand olustur = new OleDbCommand();



            baglan.Open();
            olustur.Connection = baglan;
            olustur.CommandText = "select * from istank where id=13";
            olustur.ExecuteNonQuery();
            OleDbDataReader okuma = olustur.ExecuteReader();
            if (okuma.Read())
            {
                Label3.Text = Calendar1.SelectedDate.ToShortDateString();
                Label4.Text = okuma["SeferNo"].ToString();
                Label5.Text = okuma["Guzergah"].ToString();
                Label6.Text = okuma["KalkisSaati"].ToString();
                Label7.Text = okuma["KalkisYeri"].ToString();
                Label11.Text = okuma["Fiyat"].ToString();
                Label8.Text = TextBox2.Text + " " + TextBox2.Text;
                Label9.Text = Label1.Text;
                Label10.Text = DropDownList3.SelectedItem.Text;

            }
        }

        else if (DropDownList1.SelectedValue == "1" & DropDownList2.SelectedValue == "0" & GridView1.SelectedIndex == 0)
        {

            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("oto.accdb"));

            OleDbCommand olustur = new OleDbCommand();



            baglan.Open();
            olustur.Connection = baglan;
            olustur.CommandText = "select * from istank where id=14";
            olustur.ExecuteNonQuery();
            OleDbDataReader okuma = olustur.ExecuteReader();
            if (okuma.Read())
            {
                Label3.Text = Calendar1.SelectedDate.ToShortDateString();
                Label4.Text = okuma["SeferNo"].ToString();
                Label5.Text = okuma["Guzergah"].ToString();
                Label6.Text = okuma["KalkisSaati"].ToString();
                Label7.Text = okuma["KalkisYeri"].ToString();
                Label11.Text = okuma["Fiyat"].ToString();
                Label8.Text = TextBox2.Text + " " + TextBox2.Text;
                Label9.Text = Label1.Text;
                Label10.Text = DropDownList3.SelectedItem.Text;

            }
        }

        else if (DropDownList1.SelectedValue == "1" & DropDownList2.SelectedValue == "0" & GridView1.SelectedIndex == 1)
        {

            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("oto.accdb"));

            OleDbCommand olustur = new OleDbCommand();



            baglan.Open();
            olustur.Connection = baglan;
            olustur.CommandText = "select * from istank where id=15";
            olustur.ExecuteNonQuery();
            OleDbDataReader okuma = olustur.ExecuteReader();
            if (okuma.Read())
            {
                Label3.Text = Calendar1.SelectedDate.ToShortDateString();
                Label4.Text = okuma["SeferNo"].ToString();
                Label5.Text = okuma["Guzergah"].ToString();
                Label6.Text = okuma["KalkisSaati"].ToString();
                Label7.Text = okuma["KalkisYeri"].ToString();
                Label11.Text = okuma["Fiyat"].ToString();
                Label8.Text = TextBox2.Text + " " + TextBox2.Text;
                Label9.Text = Label1.Text;
                Label10.Text = DropDownList3.SelectedItem.Text;

            }
        }
        else if (DropDownList1.SelectedValue == "1" & DropDownList2.SelectedValue == "0" & GridView1.SelectedIndex == 2)
        {

            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("oto.accdb"));

            OleDbCommand olustur = new OleDbCommand();



            baglan.Open();
            olustur.Connection = baglan;
            olustur.CommandText = "select * from istank where id=16";
            olustur.ExecuteNonQuery();
            OleDbDataReader okuma = olustur.ExecuteReader();
            if (okuma.Read())
            {
                Label3.Text = Calendar1.SelectedDate.ToShortDateString();
                Label4.Text = okuma["SeferNo"].ToString();
                Label5.Text = okuma["Guzergah"].ToString();
                Label6.Text = okuma["KalkisSaati"].ToString();
                Label7.Text = okuma["KalkisYeri"].ToString();
                Label11.Text = okuma["Fiyat"].ToString();
                Label8.Text = TextBox2.Text + " " + TextBox2.Text;
                Label9.Text = Label1.Text;
                Label10.Text = DropDownList3.SelectedItem.Text;

            }
        }

        else if (DropDownList1.SelectedValue == "2" & DropDownList2.SelectedValue == "0" & GridView1.SelectedIndex == 0)
        {

            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("oto.accdb"));

            OleDbCommand olustur = new OleDbCommand();



            baglan.Open();
            olustur.Connection = baglan;
            olustur.CommandText = "select * from istank where id=17";
            olustur.ExecuteNonQuery();
            OleDbDataReader okuma = olustur.ExecuteReader();
            if (okuma.Read())
            {
                Label3.Text = Calendar1.SelectedDate.ToShortDateString();
                Label4.Text = okuma["SeferNo"].ToString();
                Label5.Text = okuma["Guzergah"].ToString();
                Label6.Text = okuma["KalkisSaati"].ToString();
                Label7.Text = okuma["KalkisYeri"].ToString();
                Label11.Text = okuma["Fiyat"].ToString();
                Label8.Text = TextBox2.Text + " " + TextBox2.Text;
                Label9.Text = Label1.Text;
                Label10.Text = DropDownList3.SelectedItem.Text;

            }
        }

        else if (DropDownList1.SelectedValue == "2" & DropDownList2.SelectedValue == "0" & GridView1.SelectedIndex == 1)
        {

            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("oto.accdb"));

            OleDbCommand olustur = new OleDbCommand();



            baglan.Open();
            olustur.Connection = baglan;
            olustur.CommandText = "select * from istank where id=1";
            olustur.ExecuteNonQuery();
            OleDbDataReader okuma = olustur.ExecuteReader();
            if (okuma.Read())
            {
                Label3.Text = Calendar1.SelectedDate.ToShortDateString();
                Label4.Text = okuma["SeferNo"].ToString();
                Label5.Text = okuma["Guzergah"].ToString();
                Label6.Text = okuma["KalkisSaati"].ToString();
                Label7.Text = okuma["KalkisYeri"].ToString();
                Label11.Text = okuma["Fiyat"].ToString();
                Label8.Text = TextBox2.Text + " " + TextBox2.Text;
                Label9.Text = Label1.Text;
                Label10.Text = DropDownList3.SelectedItem.Text;

            }
        }

        else if (DropDownList1.SelectedValue == "2" & DropDownList2.SelectedValue == "0" & GridView1.SelectedIndex == 0)
        {

            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("oto.accdb"));

            OleDbCommand olustur = new OleDbCommand();



            baglan.Open();
            olustur.Connection = baglan;
            olustur.CommandText = "select * from istank where id=2";
            olustur.ExecuteNonQuery();
            OleDbDataReader okuma = olustur.ExecuteReader();
            if (okuma.Read())
            {
                Label3.Text = Calendar1.SelectedDate.ToShortDateString();
                Label4.Text = okuma["SeferNo"].ToString();
                Label5.Text = okuma["Guzergah"].ToString();
                Label6.Text = okuma["KalkisSaati"].ToString();
                Label7.Text = okuma["KalkisYeri"].ToString();
                Label11.Text = okuma["Fiyat"].ToString();
                Label8.Text = TextBox2.Text + " " + TextBox2.Text;
                Label9.Text = Label1.Text;
                Label10.Text = DropDownList3.SelectedItem.Text;

            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "38";
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Panel2.Visible = true;
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button16_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "1";
    }
    protected void Button30_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "2";
    }
    protected void Button44_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "3";
    }
    protected void Button15_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "4";
    }
    protected void Button29_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "5";
    }
    protected void Button43_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "6";
    }
    protected void Button14_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "7";
    }
    protected void Button28_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "8";
    }
    protected void Button42_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "9";
    }
    protected void Button13_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "10";
    }
    protected void Button27_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "11";
    }
    protected void Button41_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "12";
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "13";
    }
    protected void Button26_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "14";
    }
    protected void Button40_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "15";
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "16";
    }
    protected void Button25_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "17";
    }
    protected void Button39_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "18";
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "19";
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "20";
    }
    protected void Button23_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "21";
    }
    protected void Button37_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "22";
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "23";
    }
    protected void Button22_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "24";
    }
    protected void Button36_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "25";
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "26";
    }
    protected void Button21_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "27";
    }
    protected void Button35_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "28";
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "29";
    }
    protected void Button20_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "30";
    }
    protected void Button34_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "31";
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "32";
    }
    protected void Button19_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "33";
    }
    protected void Button33_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "34";
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "35";
    }
    protected void Button18_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "36";
    }
    protected void Button32_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "37";
    }
    protected void Button17_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "39";
    }
    protected void Button31_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Label1.Text = "40";
    }
}