Imports MySql.Data.MySqlClient
Public Class USUpClienteVeiculo
    Public Function UsandoClienteVeiculo(CliVei As UpClienteVeiculo) As String

        Dim CMD As New MySqlCommand("update tb_cliente_veiculo set `nome_cliente_veiculo` = '" & CliVei.NomeCliente & "', `tb_questionario_seguro_auto_id_questionario` = '" & _
                                    CliVei.IdSeguroAuto & "';")
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
