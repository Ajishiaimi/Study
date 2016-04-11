Imports Microsoft.VisualBasic

Public Class Holder

    Private myNumberOutput As Integer
    Private myResultOutput As String

    Public Sub New(newNumberOutput As String, newResultOutput As String)
        Me.myNumberOutput = newNumberOutput
        Me.myResultOutput = newResultOutput
    End Sub

    Public ReadOnly Property NumberOutput() As Integer
        Get
            Return myNumberOutput
        End Get
    End Property

    Public ReadOnly Property ResultOutput() As String
        Get
            Return myResultOutput
        End Get
    End Property

End Class
