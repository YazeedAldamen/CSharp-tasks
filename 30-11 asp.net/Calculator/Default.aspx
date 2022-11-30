<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Calculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
    <style type="text/css">
        .auto-style1 {
            width: 320px;
            height: 246px;
        }
        .auto-style9 {
            width: 63px;
            text-align: center;
            height: 41px;
        }
        .auto-style12 {
            font-size: medium;
        }
        .auto-style19 {
            text-align: center;
            height: 75px;
        }
        .auto-style23 {
            width: 97px;
            height: 41px;
        }
        .auto-style24 {
            width: 64px;
            height: 41px;
        }
        .auto-style25 {
            width: 63px;
            height: 42px;
        }
        .auto-style26 {
            width: 97px;
            height: 42px;
        }
        .auto-style27 {
            width: 64px;
            height: 42px;
        }
        .auto-style28 {
            text-align: center;
            height: 42px;
        }
        .auto-style29 {
            text-align: center;
            height: 42px;
            width: 100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style19" colspan="4">
                        <asp:TextBox ID="TextBox1" runat="server" TextMode="Number" Width="259px"></asp:TextBox>
                        <asp:TextBox ID="TextBox2" runat="server" Width="259px"></asp:TextBox>
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="Number" Width="259px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="1" Width="100px" height="50px" CssClass="auto-style12" />
                    </td>
                    <td class="auto-style23">
                        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="2" Width="100px" CssClass="auto-style12" Height="50px" />
                    </td>
                    <td class="auto-style24">
                        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="3" Width="100px" height="50px" CssClass="auto-style12" />
                    </td>
                    <td class="auto-style24">
                        <asp:Button ID="Button1" runat="server" CssClass="auto-style12" OnClick="Button1_Click" Text="+" Width="100px" Height="50px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style25">
                        <asp:Button ID="Button8" runat="server" ForeColor="#000004" OnClick="Button8_Click" Text="4" Width="100px" height="50px" CssClass="auto-style12" />
                    </td>
                    <td class="auto-style26">
                        <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="5" Width="100px" height="50px" CssClass="auto-style12" />
                    </td>
                    <td class="auto-style27">
                        <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="6" Width="100px" height="50px" CssClass="auto-style12" />
                    </td>
                    <td class="auto-style27">
                        <asp:Button ID="Button2" runat="server" CssClass="auto-style12" OnClick="Button2_Click" Text="-" Width="100px" Height="50px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style25">
                        <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="7" Width="100px" CssClass="auto-style12" Height="50px" />
                    </td>
                    <td class="auto-style26">
                        <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="8" Width="100px" height="50px" CssClass="auto-style12" />
                    </td>
                    <td class="auto-style27">
                        <asp:Button ID="Button13" runat="server" OnClick="Button13_Click" Text="9" Width="100px" height="50px" CssClass="auto-style12" />
                    </td>
                    <td class="auto-style27">
                        <asp:Button ID="Button3" runat="server" CssClass="auto-style12" OnClick="Button3_Click" Text="*" Width="100px" Height="50px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style25">
                        <asp:Button ID="Button14" runat="server" Height="50px" OnClick="Button14_Click1" Text="0" Width="100px" CssClass="auto-style12" />
                    </td>
                    <td class="auto-style26">
                        <asp:Button ID="Button15" runat="server" Height="50px" Text="=" Width="100px" CssClass="auto-style12" OnClick="Button15_Click" />
                    </td>
                    <td class="auto-style27">
                        <asp:Button ID="Button16" runat="server" Height="50px" OnClick="Button16_Click" Text="Clear" Width="100px" />
                    </td>
                    <td class="auto-style27">
                        <asp:Button ID="Button4" runat="server" CssClass="auto-style12" OnClick="Button4_Click" Text="/" Width="100px" Height="50px" />
                    </td>
                </tr>
                </table>
            <br class="auto-style12" />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
