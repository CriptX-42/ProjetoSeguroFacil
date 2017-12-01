Imports MySql.Data.MySqlClient
Public Class USClienteVeiculo
    Public Function UsandoClienteVeiculo(CliVei As ClienteVeiculo) As String

        Dim CMD As New MySqlCommand("INSERT INTO `solafide_v6`.`tb_cliente_veiculo` (nome_cliente_veiculo, tb_questionario_seguro_auto_id_questionario) " & _
                                    "values('" & CliVei.NomeCliente & "', '" & CliVei.IdSeguroAuto & "');")
        Try

            CMD.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            CMD.Connection.Open()
            CMD.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao inserir a Relacão entre Condutor e Segurado: " & ex.Message)
        Finally
            CMD.Connection.Close()

        End Try
        Return CMD.ToString
    End Function
End Class
