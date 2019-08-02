<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPanel.aspx.cs" Inherits="WebApplication1.Admin.WebForm1" %>

<asp:Content ID="Buttons" runat="server" contentplaceholderid="MainContent">
   
    
    <p style="font-size: xx-large; font-weight: bold; font-style: normal; color: #FFFFFF; background-color: #333333; width: 917px;">
        

        Welcome Admin!&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="panel" runat="server" BackColor="#333333" Font-Size="Medium" ForeColor="#CCCCCC" Height="31px" OnClick="panel_Click" Text="Admin Panel" />
    </p>
    <p style="font-size: xx-large; font-weight: bold; font-style: normal; color: #FFFFFF; background-color: #333333; width: 917px;">
        

        <asp:Label ID="Label2" runat="server" Text="Questions Editor"></asp:Label>
        <br />
    </p>
    <asp:Panel ID="Panel1" runat="server" Height="75px" Font-Bold="True" Font-Size="Larger">
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Add" runat="server" Height="34px" OnClick="Add_Click" Text="Add" Width="103px" />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Button ID="Edit" runat="server"  OnClick="Edit_Click" Text="Edit" Width="103px" Height="34px" />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="Show" runat="server" OnClick="Show_Click" Text="Show"  Width="103px" Height="34px" />
           &nbsp;

    </asp:Panel>
    
</asp:Content>

