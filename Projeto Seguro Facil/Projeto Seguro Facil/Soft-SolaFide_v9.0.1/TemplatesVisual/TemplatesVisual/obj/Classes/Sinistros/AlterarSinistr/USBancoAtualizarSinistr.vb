Imports MySql.Data.MySqlClient
Public Class USBancoAtualizarSinistr
    Public Function AtualizandoDadosSinistro(AtualizarSinistro As BancoAutalizarSinistr) As String

        Dim CMD As New MySqlCommand("UPDATE `solafide_v6`.`tb_sinistro` SET `nro_sinistro`='" & AtualizarSinistro.NumSinitro & "', `apolice`='" & AtualizarSinistro.Apolice & "', `sinistro_ocorrido`='" & AtualizarSinistro.TipoSinistro & "', `pessoas_envolvidas`='" & AtualizarSinistro.PessoasEnvolvidas & "', `dt_sinistro`='" & AtualizarSinistro.DataSinistro & "', `acompanhamento`='" & AtualizarSinistro.Comentarios & "' WHERE `id_sinistro`='" & AtualizarSinistro.IdOrcamento & "';")


        Try

            CMD.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            CMD.Connection.Open()
            CMD.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao inserir dados de Pessoas fisicas - " & ex.Message)
        Finally
            CMD.Connection.Close()
        End Try

    End Function
End Class
