Imports System.Data
Imports System.Data.OleDb
Public Class USBanco
    'AQUI É A FUNÇÃO DO BANCO
    Dim Clientes As Banco
    Public Function UsandoDados(Clientes As Banco) As String
        Try

            Dim strDriver As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & _
               "Data Source=C:\Users\Albert\Desktop\TemplatesVisual\Banco de Dados\bd_Teste_04.mdb;" & _
               "User ID=;Password=;"

            Dim CMD As OleDbCommand
            CMD = New OleDbCommand("INSERT INTO Clientes(Nome,CPF)" & _
                "values('" & Clientes.Nome & "','" & Clientes.CPF & "');")
            CMD.Connection = New OleDbConnection(strDriver)
            CMD.Connection.Open()
            CMD.ExecuteNonQuery()
            MsgBox("Cadastro efetuado com sucesso!")
            CMD.Connection.Close()

        Catch ex As Exception
            MsgBox("Erro Cadastrar Clientes no Banco" & ex.Message)
        End Try

    End Function
End Class
