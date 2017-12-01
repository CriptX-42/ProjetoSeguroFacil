Imports MySql.Data.MySqlClient
Public Class ConexaoBanco
    Public cn As New MySqlConnection
    Public status As String = ""

    Public Sub conectar()
        Try
            Dim stringConnection As String = ""
            stringConnection = "server=localhost; Database=consulta_cep; Uid=JJR; Pwd=2043;"
            cn.ConnectionString = stringConnection
            cn.Open()
        Catch ex As Exception
            MessageBox.Show("Erro na conexão com o banco de dados! - " + ex.Message, "Conectar em Consulta_Cep", _
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    Public Sub desconectar()
        Try
            cn.Close()
            status = "Conexão Fechada"
        Catch ex As Exception
            MessageBox.Show("Erro no fechamento de conexão com banco de dados! - ", "Desconectar em Consulta_Cep", _
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

End Class
