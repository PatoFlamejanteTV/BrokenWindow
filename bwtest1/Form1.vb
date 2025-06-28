Imports bwhelp
Imports System.Diagnostics
Imports System.IO

Public Class Form1
    Private Sub AboutClick(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If FileChecker.BwverExists() Then
            Dim filePath As String = Path.Combine(Directory.GetCurrentDirectory(), "bwver")
            Try
                Process.Start(filePath)
            Catch ex As Exception
                MessageBox.Show("BWTest1, by the BrokenWindow open-source project.")
            End Try
        Else
            MessageBox.Show("BWTest1, by the BrokenWindow open-source project.")
        End If
    End Sub
End Class