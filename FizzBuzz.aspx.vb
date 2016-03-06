Imports FizzBuzz_D

Partial Class FizzBuzz
    Inherits System.Web.UI.Page

    ''' <summary>
    ''' ポチっとなボタン押下時
    ''' </summary>
    Protected Sub btn1_Click(sender As Object, e As EventArgs) Handles btn_fz.Click
        Dim Result As String = ""
        Dim Default_Number As String = ""
        Dim MaxNumber As Integer = FB_Const.初期値

        '一定の確率で別の文字が表示される
        If くじ判定() Then
            Me.lbl_Result.Text = "おめでとう"
            Me.lbl_Number.Text = "あたりだよ"
            Return
        End If

        If Not String.IsNullOrEmpty(Me.txtNumber.Text) Then
            MaxNumber = Me.txtNumber.Text
        End If

        For Count As Integer = 1 To MaxNumber
            Dim j As Integer = 0
            If Count Mod 3 = 0 Then
                j = j + 2
            End If
            If Count Mod 5 = 0 Then
                j = j + 4
            End If
            Select Case j
                Case 2
                    Result = Result & "Fizz" & "<br />"
                    Default_Number = Default_Number & Count & "<br />"
                Case 4
                    Result = Result & "Buzz" & "<br />"
                    Default_Number = Default_Number & Count & "<br />"
                Case 6
                    Result = Result & "FizzBuzz" & "<br />"
                    Default_Number = Default_Number & Count & "<br />"
                Case Else
                    Result = Result & Count & "<br />"
                    Default_Number = Default_Number & Count & "<br />"
            End Select
        Next
        Me.lbl_Result.Text = Result
        Me.lbl_Number.Text = Default_Number
    End Sub

    ''' <summary>
    ''' クリアボタン押下
    ''' </summary>
    Protected Sub btn_c_Click(sender As Object, e As EventArgs) Handles btn_c.Click
        Me.lbl_Result.Text = ""
        Me.lbl_Number.Text = ""
    End Sub

    Private Function くじ判定() As Boolean
        Dim MyRamdom As New Random
        Dim lot As Integer = 0

        lot = MyRamdom.Next(1, 6)
        If lot = 1 Then
            Return True
        End If
        Return False
    End Function

End Class
