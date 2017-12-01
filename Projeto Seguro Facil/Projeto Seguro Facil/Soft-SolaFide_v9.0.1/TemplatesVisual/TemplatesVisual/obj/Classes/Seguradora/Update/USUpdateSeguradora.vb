Imports MySql.Data.MySqlClient
Public Class USUpdateSeguradora
    Public Function UsarUpdateSeguradora(Seguradora As UpdateSeguradora) As String

        Dim CMD As New MySqlCommand("UPDATE tb_seguradora SET `nome_seguradora` = '" & Seguradora.NomeSeguradora & "', `site_corretor` = '" & Seguradora.SiteCorretor & "', `site_principal` = '" & _
                                    Seguradora.SitePrincipal & "', `comentarios` = '" & Seguradora.Comentarios & "' where tb_seguradora.id_seguradora = '" & CadastrarSeguradora.txtId.Text & "';")

        Try

            CMD.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            CMD.Connection.Open()
            CMD.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao inserir dados de Seguradora" & ex.Message)
        Finally
            CMD.Connection.Close()
        End Try

    End Function

    Public Function UsarUpdateContato(Contato As UpdateContatoSeg) As String

        Dim CMD As New MySqlCommand("UPDATE tb_contato_profissional SET `tel_comercial` = '" & Contato.TelComer & "', `cel_comercial` = '" & Contato.CelComer & "', `nextel` = '" & _
                                    Contato.nextel & "', `email` = '" & Contato.Email & "' where tb_contato_profissional.tb_Seguradora_id_seguradora = '" & CadastrarSeguradora.txtId.Text & "';")

        Try

            CMD.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            CMD.Connection.Open()
            CMD.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao inserir dados de Contato de Seguradora" & ex.Message)
        Finally
            CMD.Connection.Close()
        End Try

    End Function
End Class
