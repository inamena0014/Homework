using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class gDataTable : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataSource = GetData();
        GridView1.DataBind();

    }
    private DataTable GetData()
    {
        DataTable Table = new DataTable();
        Table.Columns.Add("Name", typeof(string));
        Table.Columns.Add("Address", typeof(string));
        Table.Columns.Add("From", typeof(string));
        Table.Columns.Add("PhoneNumber", typeof(string));


        Table.Rows.Add("Nakarin", "30/3","Tak","0979963101");



        return Table;

    }

}