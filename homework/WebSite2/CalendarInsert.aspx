<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CalendarInsert.aspx.cs" Inherits="CalendarInsert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DropDownList ID="DropDownListDay" runat="server">
</asp:DropDownList>
<asp:DropDownList ID="DropDownListMonth" runat="server">
</asp:DropDownList>
<asp:DropDownList ID="DropDownListYear" runat="server">
</asp:DropDownList>
<br />
<asp:TextBox ID="TextBox1" runat="server" Height="52px" TextMode="MultiLine" Width="187px"></asp:TextBox>
<br />
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="บันทึก" Width="51px" />
    <asp:Label ID="LabelInserted" runat="server" ForeColor="#009933" Text="อัพโหลดสำเร็จ" Visible="False"></asp:Label>
    </asp:Content>

