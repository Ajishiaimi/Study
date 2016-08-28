Imports System.Data.SqlClient

Namespace DBAcsess

    Public Class DBConnection
        Function DBAcsess() As String
            ' TODO;Githubにコミットする前に接続文字列を変更する。
            Dim St As String
            Dim Cn As New System.Data.SqlClient.SqlConnection
            Dim SQL As System.Data.SqlClient.SqlCommand
            Dim ServerName As String = "Server" 'サーバー名
            Dim UserID As String = "user" 'ユーザーID
            Dim Password As String = "PassWord" 'パスワード
            Dim DBName As String = "DBName" 'データベース

            St = "Server=" & ServerName & ";"
            St &= "User ID=" & UserID & ";"
            St &= "Password=" & Password & ";"
            St &= "Initial Catalog=" & DBName

            Cn.ConnectionString = St

            SQL = Cn.CreateCommand

            SQL.CommandText = "select 星座名 from I_seiza where birthFrom = @SelectValue"

            'SqlCommand
            Dim sqlCom As New SqlCommand(SQL.CommandText, Cn)

            'パラメーターの追加
            Dim sqlparam1 As New SqlParameter("@SelectValue", 0321)
            sqlCom.Parameters.Add(sqlparam1)

            Cn.Open()

            'SqlCommandの実行
            sqlCom.ExecuteNonQuery()

            Dim dtReader As SqlDataReader = sqlCom.ExecuteReader
            dtReader.Read()
            Dim SeizaName As String = String.Empty
            SeizaName = dtReader("星座名").ToString

            Cn.Close()
            SQL.Dispose()
            Cn.Dispose()
            Return SeizaName
        End Function
    End Class
End Namespace
