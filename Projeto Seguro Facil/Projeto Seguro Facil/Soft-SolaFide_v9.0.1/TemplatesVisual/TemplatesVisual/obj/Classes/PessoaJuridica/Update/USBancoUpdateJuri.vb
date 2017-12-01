Imports MySql.Data.MySqlClient
Public Class USBancoUpdateJuri
    Public Function USBancoPesJuridica(PessoaJuri As UpdatePessoaJuri) As String
        Try

            Dim CMD As New MySqlCommand("UPDATE tb_pessoa_juridica SET `razao_social`='" & PessoaJuri.RazaoSocial & "', `nome_fantasia`='" & PessoaJuri.NomeFantasia & "', `representante`='" & PessoaJuri.Representante & "', `cnpj`='" & PessoaJuri.CNPJ & "', `area_atuacao`='" & PessoaJuri.AreaAtuacao & "', `site`='" & PessoaJuri.Site & "', `comentarios`='" & PessoaJuri.Comentarios & "', `status` = '" & PessoaJuri.Status & "' WHERE `id_Pessoa_Juridica`='" & PessoaJuri.id & "'")
            CMD.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            CMD.Connection.Open()
            CMD.ExecuteNonQuery()
            CMD.Connection.Close()
        Catch ex As Exception
            MsgBox("Erro ao inserir dados de PessoaJuridica" & ex.Message)
        End Try
    End Function
    Public Function USBancoEndJuridico(Endereco As UpdateEnderecoJuri) As String
        Try


            Dim CMD1 As New MySqlCommand("UPDATE tb_endereco SET `endereco`='" & Endereco.Endereco & "', `numero`='" & Endereco.Numero & "', `cep`='" & Endereco.CEP & "', `bairro`='" & Endereco.Bairro & "', `cidade`='" & Endereco.Cidade & "', `uf`='" & Endereco.UF & "', `bloco` = '" & Endereco.Bloco & "', `complemento` = '" & Endereco.Complemento & "',`apto` = '" & Endereco.Apto & "' WHERE `tb_Pessoa_Juridica_id_Pessoa_Juridica`='" & Endereco.id & "';")

            CMD1.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            CMD1.Connection.Open()
            CMD1.ExecuteNonQuery()
            CMD1.Connection.Close()


        Catch ex As Exception
            MsgBox("Erro ao inserir dados de EnderecoJuridico" & ex.Message)

        End Try

    End Function

    Public Function USBancoContatoJuri(ContatoJuri As UpdateContatoJuri) As String
        Try

            Dim CMD2 As New MySqlCommand("UPDATE `tb_contato_profissional` SET `tel_comercial`='" & ContatoJuri.telComer & "', `cel_comercial`='" & ContatoJuri.celComer & "', `email` = '" & ContatoJuri.email & "' WHERE `tb_Pessoa_Juridica_id_Pessoa_Juridica`='" & ContatoJuri.id & "';")
            CMD2.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            CMD2.Connection.Open()
            CMD2.ExecuteNonQuery()
            CMD2.Connection.Close()

        Catch ex As Exception
            MsgBox("Erro ao inserir dados de Contato Juridico" & ex.Message)
        End Try
    End Function
End Class
