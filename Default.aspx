<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter Nick Name&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNickName" runat="server" Width="168px"></asp:TextBox>
        <br />
        <br />
        Generated Number&nbsp;
        <asp:TextBox ID="txtGeneratedNo" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <br />
        Guess a Number&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtGuessedNumber" runat="server"></asp:TextBox>
        <br />
        <br />
        Guesses Made&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtGuessesMade" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <br />
        Guesses Remaining
        <asp:TextBox ID="txtGuessesRemaining" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <br />
        Score&nbsp;
        <asp:TextBox ID="txtScore" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblOutput" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnGuessNumber" runat="server" OnClick="Button1_Click" Text="Guess Number" />
&nbsp;&nbsp;
        <asp:Button ID="btnViewScores" runat="server" OnClick="btnViewScores_Click" Text="View Scores" Width="102px" />
&nbsp;&nbsp;
        <asp:Button ID="btnRestartGame" runat="server" OnClick="Button2_Click" Text="Restart Game" />
    
        <br />
    
        <br />
        <asp:Table ID="tblViewScore" runat="server" Visible="False">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell>Nick Name</asp:TableHeaderCell>
                <asp:TableHeaderCell>Score</asp:TableHeaderCell>
            </asp:TableHeaderRow>
        </asp:Table>
    
    </div>
    </form>
</body>
</html>
