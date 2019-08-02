<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="10.aspx.cs" Inherits="online_examination.Candidate.paperframes._10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 598px;
        }
        .auto-style4 {
            height: 13px;
            width: 598px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3" style="background-color: #666666; color: #FFFFFF" rowspan="2">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Larger" Text="Username: "></asp:Label>
                    <asp:Label ID="Username" runat="server" Font-Bold="True" Font-Size="Larger"></asp:Label>
                </td>
                <td class="auto-style4" style="background-color: #666666; color: #FFFFFF">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Larger" Text="Subject:"></asp:Label>
                    <asp:Label ID="Subject" Font-Bold="True" Font-Size="Larger" runat="server"></asp:Label>
                </td>
                <td class="auto-style2" style="background-color: #666666; color: #FFFFFF" rowspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="background-color: #666666; color: #FFFFFF" class="auto-style3">
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Larger" Text="Max. Marks : 30"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
