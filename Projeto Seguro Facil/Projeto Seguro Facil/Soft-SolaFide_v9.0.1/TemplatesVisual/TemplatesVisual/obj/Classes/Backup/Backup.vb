Imports System.ComponentModel
Imports System.Text
Imports MySql.Data.MySqlClient

Imports System.IO
Public Class Backup
    Dim file As String
    Private Sub Backup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            
            If txtBackPath.Text = "" Then
                MsgBox("Por favor, coloque o caminho do Backup!", MsgBoxStyle.Exclamation, "Backup")

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
                myStreamWriter.WriteLine("mysqldump -u root --password=eagle -h localhost ""solafide_v6"" > """ + file + """ ")
                myStreamWriter.Close()
                myProcess.WaitForExit()
                myProcess.Close()
                MsgBox("Backup criado com Sucesso!", MsgBoxStyle.Information, "Backup")
                txtBackPath.Text = ""
            End If

        Catch ex As Exception
            MsgBox("Falha: " + ex.Message)
        End Try

    End Sub

    Private Sub btnAlterarDest_Click(sender As Object, e As EventArgs) Handles btnAlterarDest.Click
        SFD.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
        SFD.FileName = "Backup " + DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss") + ".sql"
        If SFD.ShowDialog = DialogResult.OK Then
            file = SFD.FileName
            txtBackPath.Text = file
        End If


    End Sub
End Class