using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class uploadfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        LabelUploaded.Visible = true;
        if (FileUpload1.HasFile)
        { 
            string OldFileName = FileUpload1.FileName;
            string Ext = System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName);
            if (Ext.ToUpper() == ".JPG")
            {
                
                string NewName = Guid.NewGuid().ToString();
                string cNewName = string.Format("{0}{1}", NewName, Ext);
                string Path = string.Format("Upload/{0}", cNewName);
                string cPath = Server.MapPath(Path);
                InserFileDB(OldFileName, Path);

            }
            else
            {
                LabelUploaded.ForeColor = System.Drawing.Color.Red;
                LabelUploaded.Text = "โปรดเลือกไฟล์ให้ถูกต้อง!";
            }
        }
        else
        {
            LabelUploaded.ForeColor = System.Drawing.Color.Red;
            LabelUploaded.Text = "อัพโหลดไฟล์ไม่สำเร็จ!";
        }
    }

    private void InserFileDB (string OldFileName, string cPath)
    {
        string StrConn = WebConfigurationManager.ConnectionStrings["UPPart2ConnectionString"].ConnectionString;
        using(SqlConnection ObjConn = new SqlConnection(StrConn))
        {
            ObjConn.Open();
            using (SqlCommand ObjCM = new SqlCommand())
            {
                ObjCM.CommandType = CommandType.StoredProcedure;
                ObjCM.CommandText = "spTreeViewInsertedFile";
                ObjCM.Parameters.AddWithValue("@Name", OldFileName);
                ObjCM.Parameters.AddWithValue("@PicturePath", cPath);
                ObjCM.ExecuteNonQuery();

            }

                ObjConn.Close();
        }
    }
}