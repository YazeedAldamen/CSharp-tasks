<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Calculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
    <style type="text/css">
        .auto-style1 {
            width: 22%;
        }
        .auto-style2 {
            width: 75px;
        }
        .auto-style3 {
            font-size: large;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style7 {
            width: 75px;
            height: 26px;
        }
        .auto-style8 {
            text-align: center;
        }
        .auto-style9 {
            width: 75px;
            text-align: center;
        }
        .auto-style10 {
            width: 72px;
        }
        .auto-style11 {
            width: 72px;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style8" colspan="5">
                        <asp:TextBox ID="TextBox1" runat="server" TextMode="Number" Width="259px"></asp:TextBox>
                        <asp:TextBox ID="TextBox2" runat="server" Width="259px"></asp:TextBox>
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="Number" Width="259px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="1" Width="80px" height="29px" />
                    </td>
                    <td class="auto-style2" colspan="2">
                        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="2" Width="80px" />
                    </td>
                    <td class="auto-style10">
                        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="3" Width="80px" height="29px" />
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" CssClass="auto-style3" OnClick="Button1_Click" Text="+" Width="62px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Button ID="Button8" runat="server" ForeColor="#000004" OnClick="Button8_Click" Text="4" Width="80px" height="29px" />
                    </td>
                    <td class="auto-style7" colspan="2">
                        <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="5" Width="80px" height="29px" />
                    </td>
                    <td class="auto-style11">
                        <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="6" Width="80px" height="29px" />
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="Button2" runat="server" CssClass="auto-style3" OnClick="Button2_Click" Text="-" Width="62px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="7" Width="80px" />
                    </td>
                    <td class="auto-style7" colspan="2">
                        <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="8" Width="80px" height="29px" />
                    </td>
                    <td class="auto-style11">
                        <asp:Button ID="Button13" runat="server" OnClick="Button13_Click" Text="9" Width="80px" height="29px" />
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="Button3" runat="server" CssClass="auto-style3" OnClick="Button3_Click" Text="*" Width="62px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8" colspan="2">
                        <asp:Button ID="Button14" runat="server" Height="46px" OnClick="Button14_Click1" Text="0" Width="100px" />
                    </td>
                    
                    <td>
                        <asp:Button ID="Button4" runat="server" CssClass="auto-style3" OnClick="Button4_Click" Text="/" Width="62px" />
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
