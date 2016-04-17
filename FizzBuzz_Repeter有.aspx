<%@ Page Language="VB" AutoEventWireup="false" CodeFile="FizzBuzz_Repeter有.aspx.vb" Inherits="FizzBuzz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
    <title>FizzBuzz(Repeter有)</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td colspan="2">右記の数字まで表示します：<asp:TextBox ID="txtNumber" runat="server" Style="width: 50px;" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="padding-bottom: 10px;">※未入力の場合は30まで
                    </td>
                </tr>
                <tr>
                    <td colspan="2">ボタンを押してね
                    </td>
                </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="btnFizzBuzz" runat="server" Text="ポチっとな" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="btnClear" runat="server" Text="クリア" />
                        </td>
                    </tr>
                </table>
            <asp:Repeater ID="Repeter1" OnItemDataBound="Repeter1_ItemDataBound" runat="server">
             <HeaderTemplate>
                    <table>
                        <tr>
                            <td>【通常版】</td>
                            <td>【FizzBuzz版】</td>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><asp:Label ID="lblNumberOutput" runat="server" /></td>
                        <td><asp:Label ID="lblResultOutput" runat="server" /></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
