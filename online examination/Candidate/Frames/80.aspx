<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="80.aspx.cs" Inherits="online_examination.Candidate.Frames._80" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 169px;
        }
        .auto-style3 {
            height: 25px;
        }
        .auto-style5 {
            width: 405px;
        }
        .newStyle1 {
            float: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label1" runat="server" Text="Q. No:"></asp:Label>
                    <asp:Label ID="qno" runat="server"></asp:Label>
                </td>
                <td rowspan="11">
                    <asp:Panel ID="Panel1" runat="server">
                    </asp:Panel>
                    <asp:Panel ID="Panel2" runat="server" Height="262px" Width="240px" CssClass="newStyle1">
                        <asp:Label ID="Select" runat="server" Text="SELECT QUESTION :"></asp:Label>
                        <br />
                        <br />
                        <asp:Button ID="Q1" runat="server" Text="1" Width="30px" />
                        <asp:Button ID="Q2" runat="server" Text="2" Width="30px" />
                        <asp:Button ID="Q3" runat="server" Text="3" Width="30px" />
                        <asp:Button ID="Q4" runat="server" Text="4" Width="30px" />
                        <asp:Button ID="Q5" runat="server" Text="5" Width="30px" />
                        <asp:Button ID="Q6" runat="server" Text="6" Width="30px" />
                        <asp:Button ID="Q7" runat="server" Text="7" Width="30px" />
                        <asp:Button ID="Q8" runat="server" Text="8" Width="30px" />
                        <asp:Button ID="Q9" runat="server" Text="9" Width="30px" />
                        <asp:Button ID="Q10" runat="server" Text="10" Width="30px" />
                        <asp:Button ID="Q11" runat="server" Text="11" Width="30px" />
                        <asp:Button ID="Q12" runat="server" Text="12" Width="30px" />
                        <asp:Button ID="Q13" runat="server" Text="13" Width="30px" />
                        <asp:Button ID="Q14" runat="server" Text="14" Width="30px" />
                        <asp:Button ID="Q15" runat="server" Text="15" Width="30px" />
                        <asp:Button ID="Q16" runat="server" Text="16" Width="30px" />
                        <asp:Button ID="Q17" runat="server" Text="17" Width="30px" />
                        <asp:Button ID="Q18" runat="server" Text="18" Width="30px" />
                        <asp:Button ID="Q19" runat="server" Text="19" Width="30px" />
                        <asp:Button ID="Q20" runat="server" Text="20" Width="30px" />
                        <asp:Button ID="Q21" runat="server" Text="21" Width="30px" />
                        <asp:Button ID="Q22" runat="server" Text="22" Width="30px" />
                        <asp:Button ID="Q23" runat="server" Text="23" Width="30px" />
                        <asp:Button ID="Q24" runat="server" Text="24" Width="30px" />
                        <asp:Button ID="Q25" runat="server" Text="25" Width="30px" />
                        <asp:Button ID="Q26" runat="server" Text="26" Width="30px" />
                        <asp:Button ID="Q27" runat="server" Text="27" Width="30px" />
                        <asp:Button ID="Q28" runat="server" OnClick="Button31_Click" Text="28" Width="30px" />
                        <asp:Button ID="Q29" runat="server" OnClick="Button32_Click" Text="29" Width="30px" />
                        <asp:Button ID="Q30" runat="server" Text="30" Width="30px" />
                    </asp:Panel>
                    </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Question" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label2" runat="server" Text="Select Option:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:RadioButton ID="A" GroupName="Options" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="2" class="auto-style3">
                    <asp:RadioButton ID="B"  GroupName="Options" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="2" class="auto-style3">
                    <asp:RadioButton ID="C" GroupName="Options" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:RadioButton ID="D" GroupName="Options" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                    <asp:Button ID="Save" runat="server" Text="Save" Width="73px" />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="Button2" runat="server" Text="Next" OnClick="Button2_Click" Width="73px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>
