using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Class1 ObjC = new Class1();
        ObjC.name = "ผลบวก ";
        int N1 = Convert.ToInt32(TextBox1.Text);
        int N2 = Convert.ToInt32(TextBox2.Text);
        LabelResult.Text = ObjC.SUM(N1, N2).ToString();
        ObjC.SUM()
    }
}