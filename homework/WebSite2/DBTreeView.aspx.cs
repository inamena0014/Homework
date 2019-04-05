using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class DBTreeView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            String StrConn = WebConfigurationManager.ConnectionStrings["UPPart2ConnectionString"].ConnectionString;
            using (SqlConnection Objconn = new SqlConnection(StrConn))
            {
                Objconn.Open();
                using (SqlCommand ObjCM = new SqlCommand())
                {
                    ObjCM.Connection = Objconn;
                    ObjCM.CommandText = "SELECT ID,name,parent FROM TreeView WHERE parent IS NULL;";
                    SqlDataReader ObjDR = ObjCM.ExecuteReader();
                    while (ObjDR.Read())
                    {
                        TreeNode node = new TreeNode(ObjDR["name"].ToString(), ObjDR["id"].ToString());
                        TreeView1.Nodes.Add(node);    
                    }
                    ObjDR.Close();
                }

                Objconn.Close();
            }
        }
    }
    private void Treeviewnodes(string parent, TreeNode parentNode)
    {

        String StrConn = WebConfigurationManager.ConnectionStrings["UPPart2ConnectionString"].ConnectionString;
        using (SqlConnection Objconn = new SqlConnection(StrConn))
        {
            Objconn.Open();
            using (SqlCommand ObjCM = new SqlCommand())
            {
                ObjCM.Connection = Objconn;
                ObjCM.CommandText = "SELECT ID,name,parent FROM TreeView WHERE parent "+parent;
                SqlDataReader ObjDR = ObjCM.ExecuteReader();
                while (ObjDR.Read())
                {
                    TreeNode node = new TreeNode(ObjDR["name"].ToString(), ObjDR["id"].ToString());
                    parentNode.ChildNodes.Add(node);
                    

                }
                ObjDR.Close();
            }

            Objconn.Close();
        }
    }
}