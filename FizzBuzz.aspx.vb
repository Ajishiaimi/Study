Option Explicit On

Imports FizzBuzzConst

Partial Class FizzBuzz
    Inherits Page

    ''' <summary>
    ''' ページロード
    ''' </summary>
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Panel1.Visible = False
    End Sub

    ''' <summary>
    ''' ポチっとなボタン押下時
    ''' </summary>
    Protected Sub btn1_Click(sender As Object, e As EventArgs) Handles btnFizzBuzz.Click
        Dim ResultOutput As String = ""
        Dim NumberOutput As String = ""
        Dim MinNumber As Integer = FizzBuzzConst.Values.初期値
        Dim MaxNumber As Integer = FizzBuzzConst.Values.最大値

        ' TODO:テキストボックスの入力チェックを実装する
        Me.Panel1.Visible = True

        If Not String.IsNullOrEmpty(Me.txtNumber.Text) Then
            MaxNumber = Integer.Parse(Me.txtNumber.Text)
        End If

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
                    ResultOutput = ResultOutput & FizzBuzzConst.Text.出力結果_Fizz
                Case 4
                    ResultOutput = ResultOutput & FizzBuzzConst.Text.出力結果_Buzz
                Case 6
                    ResultOutput = ResultOutput & FizzBuzzConst.Text.出力結果_FizzBuzz
                Case Else
                    ResultOutput = ResultOutput & Number
            End Select
            ResultOutput = ResultOutput & FizzBuzzConst.Text.改行
            NumberOutput = NumberOutput & Number & FizzBuzzConst.Text.改行
        Next

        'TODO: 改行タグ使わずに文字列を出力する
        'TODO: 改行タグを実装したら下記のコメントアウトをはずす
        'ResultOutput = System.Web.HttpUtility.HtmlEncode(ResultOutput)
        'NumberOutput = System.Web.HttpUtility.HtmlEncode(NumberOutput)
        Me.lblResultOutput.Text = ResultOutput
        Me.lblNumberOutput.Text = NumberOutput
    End Sub

    ''' <summary>
    ''' クリアボタン押下
    ''' </summary>
    Protected Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.Panel1.Visible = False
        Me.lblResultOutput.Text = ""
        Me.lblNumberOutput.Text = ""
    End Sub

End Class
