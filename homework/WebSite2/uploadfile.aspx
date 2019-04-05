<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="uploadfile.aspx.cs" Inherits="uploadfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:FileUpload ID="FileUpload1" runat="server" />
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload" />
<asp:Label ID="LabelUploaded" runat="server" ForeColor="Lime" Text="เพิ่มข้อมูลสำเร็จ" Visible="False"></asp:Label>
<br />
</asp:Content>

