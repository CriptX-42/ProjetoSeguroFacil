Imports MySql.Data.MySqlClient
Public Class USBancoJuridico
    Dim Conexao As New ConexaoSolafide
    Public Function USBancoPesJuridica(PessoaJuri As BancoPessoaJuri) As String
        Conexao.conectar()

        Dim Sql As String = "INSERT INTO tb_pessoa_juridica(razao_social, nome_fantasia, representante, cnpj, area_atuacao, site, comentarios, status)" & _
                                    "values('" & PessoaJuri.RazaoSocial & "','" & PessoaJuri.NomeFantasia & "', '" & PessoaJuri.Representante & "', '" & PessoaJuri.CNPJ & "', '" & PessoaJuri.AreaAtuacao & "', '" & PessoaJuri.Site & "','" & PessoaJuri.Comentarios & "', '" & PessoaJuri.Status & "');"

        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try
          CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro em cadastrar pessoa juridica -", "Cadastro de Pessoa Jurídica" + ex.Message, _
             MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CMD.Connection.Close()
        End Try
        Return CMD.ToString
    End Function
    Public Function USBancoEndJuridico(Endereco As BancoEnderecoJuri) As String
        Conexao.conectar()


        Dim Sql As String = "INSERT INTO tb_Endereco(Endereco, Numero, cep, bairro, cidade, uf, bloco, complemento,apto, tb_Pessoa_Juridica_id_Pessoa_Juridica)" & _
            "values('" & Endereco.Endereco & "','" & Endereco.Numero & "', '" & Endereco.CEP & "', '" & Endereco.Bairro & "', '" & Endereco.Cidade & "', '" & Endereco.UF & "', '" & Endereco.Bloco & "', '" & Endereco.Complemento & "','" & Endereco.Apto & "','" & Endereco.IDPessoaJuridica & "');"

        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro em cadastrar pessoa juridica -", "Cadastro de Pessoa Jurídica" + ex.Message, _
             MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CMD.Connection.Close()
        End Try
        Return CMD.ToString
    End Function

    Public Function USBancoContatoJuri(ContatoJuri As BancoContatoJuri) As String
        Conexao.conectar()

        Dim Sql As String = "INSERT INTO tb_Contato_profissional(tel_comercial,cel_comercial, email, tb_Pessoa_Juridica_id_Pessoa_Juridica)" & _
                                    "values('" & ContatoJuri.telComer & "', '" & ContatoJuri.celComer & "', '" & ContatoJuri.email & "', '" & ContatoJuri.IDPessoaJuridica & "');"
        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro em cadastrar pessoa juridica -", "Cadastro de Pessoa Jurídica" + ex.Message, _
             MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CMD.Connection.Close()
        End Try
        Return CMD.ToString
    End Function
    Public Function UsandoDadosItemJuridico(Item As BancoItemJuri) As String
        Conexao.conectar()
        Dim Sql As String = "INSERT INTO tb_item(item,tb_Pessoa_Juridica_id_Pessoa_Juridica) VALUES ('" & Item.IdPessoaJuridica & "', '" & Item.IdPessoaJuridica & "');"

       Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro em cadastrar pessoa juridica -", "Cadastro de Pessoa Jurídica" + ex.Message, _
             MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CMD.Connection.Close()
        End Try
        Return CMD.ToString
    End Function
End Class
