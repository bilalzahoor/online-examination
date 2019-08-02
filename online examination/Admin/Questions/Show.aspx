<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="online_examination.Admin.Questions.Show" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p style="font-size: xx-large; font-weight: bold; font-style: normal; color: #FFFFFF; background-color: #333333; width: 930px; height: 44px;">
        

        Welcome Admin!&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="panel" runat="server" BackColor="#333333" Font-Size="Medium" ForeColor="#CCCCCC" Height="31px" OnClick="panel_Click" Text="Admin Panel" />
    </p>
    <br />
    <table class="nav-justified">
        <tr>
            <td style="width: 513px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="SelectSubject" runat="server" Font-Size="Large" Height="29px" Text="Select Subject"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="subject" runat="server" Font-Size="Large" Height="44px" OnSelectedIndexChanged="subject_SelectedIndexChanged" Width="181px">
            <asp:ListItem Value="OS">Operating System</asp:ListItem>
                    <asp:ListItem Value="DS">Data Structure</asp:ListItem>
                    <asp:ListItem>C</asp:ListItem>
        </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:online examinationConnectionString %>" SelectCommand="SELECT Question.QuestionNo, Question.Question, Question.QuestionKey, QuestionOptions.OptionA, QuestionOptions.OptionB, QuestionOptions.OptionC, QuestionOptions.OptionD FROM Question INNER JOIN QuestionOptions ON Question.QuestionID = QuestionOptions.QuestionID WHERE (Question.QuestionType = @QuestionType)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="subject" Name="QuestionType" PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
            <td>
                <asp:Button ID="ShowB" runat="server" Font-Bold="True" Font-Size="Large" OnClick="ShowB_Click" Text="Show" />
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:BoundField DataField="QuestionNo" HeaderText="QuestionNo" SortExpression="QuestionNo" />
                        <asp:BoundField DataField="Question" HeaderText="Question" SortExpression="Question" />
                        <asp:BoundField DataField="QuestionKey" HeaderText="QuestionKey" SortExpression="QuestionKey" />
                        <asp:BoundField DataField="OptionA" HeaderText="OptionA" SortExpression="OptionA" />
                        <asp:BoundField DataField="OptionB" HeaderText="OptionB" SortExpression="OptionB" />
                        <asp:BoundField DataField="OptionC" HeaderText="OptionC" SortExpression="OptionC" />
                        <asp:BoundField DataField="OptionD" HeaderText="OptionD" SortExpression="OptionD" />
                        <asp:ButtonField CommandName="Delete" HeaderText="Delete" ShowHeader="True" Text="Button" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
