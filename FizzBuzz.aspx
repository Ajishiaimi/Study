<%@ Page Language="VB" AutoEventWireup="false" CodeFile="FizzBuzz.aspx.vb" Inherits="FizzBuzz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
    <title>FizzBuzz</title>
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
                            <asp:Button ID="btn_fz" runat="server" Text="ポチっとな" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="btn_c" runat="server" Text="クリア" />
                        </td>
                    </tr>
                <tr>
                    <td>
                        【通常版】
                    </td>
                    <td>
                        【FizzBuzz版】
                    </td>
                </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lbl_Number" runat="server" Text="" />

                        </td>
                        <td>
                            <asp:Label ID="lbl_Result" runat="server" Text="" />
                        </td>
                    </tr>
            </table>
        </div>
    </form>
</body>
</html>
