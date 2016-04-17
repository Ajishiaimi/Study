Option Explicit On

Imports FizzBuzzConst

Partial Class FizzBuzz
    Inherits Page

    ''' <summary>
    ''' ポチっとなボタン押下時
    ''' </summary>
    Protected Sub btnFizzBuzz_Click(sender As Object, e As EventArgs) Handles btnFizzBuzz.Click
        Dim ResultOutput As String = ""
        Dim NumberOutput As String = ""
        Dim MinNumber As Integer = FizzBuzzConst.Values.Initial
        Dim MaxNumber As Integer = FizzBuzzConst.Values.Max

        ' TODO:テキストボックスの入力チェックを実装する
        If Not String.IsNullOrEmpty(Me.txtNumber.Text) Then
            MaxNumber = Integer.Parse(Me.txtNumber.Text)
        End If

        Dim OutoutValues As New List(Of ResultClass)
        For Number As Integer = MinNumber To MaxNumber
            Dim Bit As Integer = 0
            If Number Mod 3 = 0 Then
                Bit += 2 ^ 1
            End If
            If Number Mod 5 = 0 Then
                Bit += 2 ^ 2
            End If
            Select Case Bit
                Case 2
                    OutoutValues.Add(New ResultClass(Number, FizzBuzzConst.Text.Fizz))
                Case 4
                    OutoutValues.Add(New ResultClass(Number, FizzBuzzConst.Text.Buzz))
                Case 6
                    OutoutValues.Add(New ResultClass(Number, FizzBuzzConst.Text.FizzBuzz))
                Case Else
                    OutoutValues.Add(New ResultClass(Number, Number))
            End Select
        Next
        Me.Repeter1.DataSource = OutoutValues
        Me.Repeter1.DataBind()
    End Sub

    Protected Sub Repeter1_ItemDataBound(sender As Object, e As RepeaterItemEventArgs)
        'TODO:   例外が発生するので修正
        'Select Case e.Item.ItemType
        '    Case ListItemType.Item, ListItemType.AlternatingItem
        '        DirectCast(e.Item.FindControl("lblNumberOutput"), Label).Text = DirectCast(e.Item.DataItem, String)
        '        DirectCast(e.Item.FindControl("lblResultOutput"), Label).Text = DirectCast(e.Item.DataItem, String)
        'End Select
    End Sub

    ''' <summary>
    ''' クリアボタン押下
    ''' </summary>
    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Repeter1.DataSource = Nothing
        Repeter1.DataBind()
    End Sub

End Class
