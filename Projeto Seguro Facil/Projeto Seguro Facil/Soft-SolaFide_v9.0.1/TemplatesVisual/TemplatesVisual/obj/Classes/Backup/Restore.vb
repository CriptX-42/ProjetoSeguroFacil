Imports System.ComponentModel
Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Restore
    Public file As String
    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        If txtRestorePath.Text = "" Then
            MsgBox("Por Favor, selecione algum backup!", MsgBoxStyle.Exclamation, "Restore")

        Else


            Dim myProcess As New Process()
            myProcess.StartInfo.FileName = "cmd.exe"
            myProcess.StartInfo.UseShellExecute = False
            myProcess.StartInfo.WorkingDirectory = "C:\Program Files\MySQL\MySQL Server 5.6\bin\"
            myProcess.StartInfo.RedirectStandardInput = True
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.Start()

            Dim myStreamWriter As StreamWriter = myProcess.StandardInput
            Dim mystreamreader As StreamReader = myProcess.StandardOutput
            myStreamWriter.WriteLine("mysql -u root --password=eagle -h localhost  ""solafide_v6"" < """ + file + """ ")
            myStreamWriter.Close()
            myProcess.WaitForExit()

            myProcess.Close()
            LoadRest.Close()
            MsgBox("Restore feito com sucesso!", MsgBoxStyle.Information, "Restore")
            txtRestorePath.Text = ""




        End If

    End Sub

    Private Sub Restore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        opd.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
        If opd.ShowDialog = DialogResult.OK Then
            file = opd.FileName
            txtRestorePath.Text = file
        End If
    End Sub
End Class