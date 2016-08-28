Option Explicit On

Imports DBAcsess

Partial Class TopPage
    Inherits System.Web.UI.Page

    ''' <summary>
    ''' ページロード
    ''' </summary>
    Public Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        '初回ロード時の処理
        If Not IsPostBack Then
            'ドロップダウンリストの設定
            Me.DefaultDate()
        End If
        'ドロップダウンリストの初期値を設定

    End Sub

    ''' <summary>
    ''' ドロップダウンリストの初期値を設定する
    ''' </summary>
    Public Sub DefaultDate()
        '現在の年月日から-50年分
        Dim dtNow As DateTime = DateTime.Now
        Dim NowYear As Integer = dtNow.Year

        '年を設定する
        For YearCount As Integer = 0 To 49
            Me.BirthYear.Items.Add(NowYear - (YearCount))
        Next

        '月を設定する
        For MonthCount As Integer = 1 To 12
            Me.BirthMonth.Items.Add(MonthCount)
        Next

        '日を設定する
        For DayCount As Integer = 1 To 30
            Me.BirthDay.Items.Add(DayCount)
        Next
    End Sub

    Protected Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim SelectValue As String = JoinValue()
        Dim DBConnection As DBConnection = New DBConnection
        Dim SeizaName As String = DBConnection.DBAcsess()

        Me.Result.Text = SeizaName

    End Sub

    ''' <summary>
    ''' 検索の文字列を取得する
    ''' </summary>
    ''' <returns></returns>
    Function JoinValue() As String
        'ドロップダウンリストの値と文字数を取得する
        Dim ValueMonth As String = Me.BirthDay.Text
        Dim ValueDay As String = Me.BirthDay.Text

        ' 月日が1桁の場合0を追加する
        If Me.BirthMonth.Text.Length = 1 Then
            ValueMonth = Me.BirthMonth.Text.PadLeft(2, "0")
        End If

        If Me.BirthDay.Text.Length = 1 Then
            ValueDay = Me.BirthDay.Text.PadLeft(2, "0")
        End If

        Dim BirthValue As String = ValueMonth + ValueDay

        Return BirthValue
    End Function

End Class
