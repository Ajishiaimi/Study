<%@ Page Language="VB" AutoEventWireup="false" CodeFile="TopPage.aspx.vb" Inherits="TopPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <%--<script type="text/javascript" src="JavaScript.js"></script>--%>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>星座アプリ</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="main">
            <div style="text-align: center; padding-bottom: 40px; font-size: 20px">星座アプリ</div>

            <table style="text-align: center; width: 300px;margin: auto;">
                <tr>
                    <td colspan="3" style="padding-bottom: 10px;">あなたの生年月日を入力してください</td>
                </tr>
                <tr style="background-color: wheat;">
                    <td>年</td>
                    <td>月</td>
                    <td>日</td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="BirthYear" runat="server" onChange="ChangeYear()" Style="width: 60px" /></td>
                    <td>
                        <asp:DropDownList ID="BirthMonth" runat="server" onChange="ChangeMonth()" Style="width: 60px" /></td>
                    <td>
                        <asp:DropDownList ID="BirthDay" runat="server" Style="width: 60px" /></td>
                </tr>
                <tr>
                    <td colspan="3" style="padding-top: 15px; padding-bottom: 15px;">
                        <asp:Button ID="BtnSearch" runat="server" Text="検索" Style="width: 100px; height: 50px; font-size: 20px;" /></td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Label ID="Result" runat="server" Style="font-size: 15px; text-align: center;" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
