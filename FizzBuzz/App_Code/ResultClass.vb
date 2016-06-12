Imports Microsoft.VisualBasic

Public Class ResultClass

    Private myNumberOutput As Integer
    Private myResultOutput As String

    Public Sub New(newNumberOutput As Integer, newResultOutput As String)
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

    Public Shared Widening Operator CType(ByVal val As ResultClass) As String
        Return New String(val.myResultOutput.ToString)
    End Operator

End Class
