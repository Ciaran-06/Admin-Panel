Imports System.Data.SqlClient

Public Class addUser
    Private Sub SUBMIT_Click(sender As Object, e As EventArgs) Handles submit.Click
        Dim username As String = username
        Dim password As String = password
        Dim fName As String = fName

        Try
            If Not isEmpty(username) Then
                If Not isEmpty(password) Then
                    If Not isEmpty(fName) Then

                    End If
                End If
            End If

        Catch ex As Exception
            Error (ex.ToString())
        End Try

    End Sub

    Private Function isEmpty(ByVal str)
        If str = "" Then
            Return True
        End If

    End Function

    Private Sub conn()

    End Sub
End Class