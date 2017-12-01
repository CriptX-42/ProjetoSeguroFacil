Imports System.ComponentModel
Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class LoadRestore

    Private Sub LoadRestore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Restore
            Dim myProcess As New Process()
            myProcess.StartInfo.FileName = "cmd.exe"
            myProcess.StartInfo.UseShellExecute = False
            myProcess.StartInfo.WorkingDirectory = "C:\Program Files\MySQL\MySQL Server 5.6\bin\"
            myProcess.StartInfo.RedirectStandardInput = True
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.Start()

            Dim myStreamWriter As StreamWriter = myProcess.StandardInput
            Dim mystreamreader As StreamReader = myProcess.StandardOutput
            myStreamWriter.WriteLine("mysql -u root --password=eagle -h localhost  ""solafide_v6"" < """ + .file + """ ")
            myStreamWriter.Close()
            myProcess.WaitForExit()

            myProcess.Close()
            MsgBox("Restore feito com sucesso!", MsgBoxStyle.Information, "Restore")
            .txtRestorePath.Text = ""

        End With
        Me.Close()
    End Sub
End Class