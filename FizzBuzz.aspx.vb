Imports FizzBuzz_Const

Partial Class FizzBuzz
    Inherits Page

    ''' <summary>
    ''' ポチっとなボタン押下時
    ''' </summary>
    Protected Sub btn1_Click(sender As Object, e As EventArgs) Handles btn_fz.Click
        Dim Result As String = ""
        Dim Default_Number As String = ""
        Dim MinNumber As Integer = FB_Const.初期値
        Dim MaxNumber As Integer = FB_Const.最大値

        'テキストボックスの入力チェックは未実装

        If Not String.IsNullOrEmpty(Me.txtNumber.Text) Then
            MaxNumber = Me.txtNumber.Text
        End If

        For Number As Integer = MinNumber To MaxNumber
            Dim bit As Integer = 0
            If Number Mod 3 = 0 Then
                bit = bit + 2 ^ 1
            End If
            If Number Mod 5 = 0 Then
                bit = bit + 2 ^ 2
            End If
            Select Case bit
                Case 2
                    Result = Result & FB_Const.出力結果_Fizz & FB_Const.改行
                    Default_Number = Default_Number & Number & FB_Const.改行
                Case 4
                    Result = Result & FB_Const.出力結果_Buzz & FB_Const.改行
                    Default_Number = Default_Number & Number & FB_Const.改行
                Case 6
                    Result = Result & FB_Const.出力結果_FizzBuzz & FB_Const.改行
                    Default_Number = Default_Number & Number & FB_Const.改行
                Case Else
                    Result = Result & Number & FB_Const.改行
                    Default_Number = Default_Number & Number & FB_Const.改行
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

End Class
