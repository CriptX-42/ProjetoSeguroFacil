Imports MySql.Data.MySqlClient
Public Class USBancoSeguradora
    Public Function UsarBancoSeguradora(Seguradora As BancoSeguradora) As String

        Dim CMD As New MySqlCommand("INSERT INTO tb_seguradora (nome_seguradora,site_corretor,site_principal,comentarios) " & _
                "values('" & Seguradora.NomeSeguradora & "', '" & Seguradora.SiteCorretor & "', '" & Seguradora.SitePrincipal & "','" & Seguradora.Comentarios & "');")

        Try

            CMD.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            CMD.Connection.Open()
            CMD.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox("Erro ao inserir dados em Seguradora" & ex.Message)
        Finally
            CMD.Connection.Close()
        End Try

    End Function

    Public Function UsarBancoContato(Contato As BancoContatoSeg) As String

        Dim CMD As New MySqlCommand("INSERT INTO tb_contato_profissional(tel_comercial, cel_comercial, nextel, email, tb_Seguradora_id_seguradora) " & _
                "values('" & Contato.TelComer & "', '" & Contato.CelComer & "', '" & Contato.nextel & "', '" & Contato.Email & "','" & Contato.IdSeguradora & "');")

        Try

            CMD.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            CMD.Connection.Open()
            CMD.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox("Erro ao inserir dados de Contato" & ex.Message)
        Finally
            CMD.Connection.Close()
        End Try

    End Function
End Class
