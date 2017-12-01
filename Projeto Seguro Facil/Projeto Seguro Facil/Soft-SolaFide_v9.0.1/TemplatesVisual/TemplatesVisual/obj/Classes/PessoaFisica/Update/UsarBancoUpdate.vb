Imports MySql.Data.MySqlClient
Public Class UsarBancoUpdate
    'AQUI É A FUNÇÃO DO BANCO
    ' Public idPessoaFisica As String
    Dim Conexao As New ConexaoSolafide
    Public Function UpdateCliente(UPClientes As UpdateCliente) As String
        Conexao.conectar()
        Dim Sql As String = "UPDATE tb_Pessoa_Fisica SET `Nome_Completo`='" & UPClientes.Nome & "', `Cpf`='" & UPClientes.CPF & "', `rg`='" & UPClientes.RG & "', `dt_expedicao`='" & _
            UPClientes.Data_Expedicao & "', `orgao_exped`='" & UPClientes.Orgao_Expeditor & "', `cnh`='" & UPClientes.CNH & "',`tempo_habilitacao`='" & UPClientes.Tempo_Habilitacao & _
            "', `dt_nascimento`='" & UPClientes.Data_Nasc & "', `profissao`='" & UPClientes.Profissao & "', `comentarios`='" & UPClientes.comentarios & "', `status`='" & _
            UPClientes.Status & "' WHERE `id_Pessoa_Fisica` ='" & UPClientes.ID & "';"
        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)

        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro ao Alterar os Dados de Pessoa Física na tabela tb_Pessoa_Fisica - Erro: " & ex.Message, "Erro ao Alterar Pessoa Física", MessageBoxButtons.OK)
        Finally
            CMD.Connection.Close()
        End Try
        Return Sql.ToString
    End Function
    Public Function UpdateEndereco(UP_Endereco As UpdateEndereco) As String
        Conexao.conectar()
        Dim Sql As String = "UPDATE tb_endereco SET `Endereco`='" & UP_Endereco.Rua_Av & "', `Numero`='" & UP_Endereco.numero & "', `cep`='" & UP_Endereco.CEP & "', `bairro`='" & _
            UP_Endereco.Bairro & "', `cidade`='" & UP_Endereco.Cidade & "', `uf`='" & UP_Endereco.UF & "', `bloco`='" & UP_Endereco.Bloco & "', `Complemento`='" & _
            UP_Endereco.complemento & "' WHERE `tb_Pessoa_Fisica_id_Pessoa_Fisica`='" & UP_Endereco.IdPessoaFisica & "';"
        Dim CMD1 As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)

        Try
            CMD1.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro ao Alterar os Dados da Pessoa Física na tabela Endereco - Erro: " & ex.Message, "Erro ao Alterar Pessoa Física", MessageBoxButtons.OK)
        Finally
            CMD1.Connection.Close()
        End Try
        Return Sql.ToString
    End Function
    Public Function UpdateSexo(Sexo As UpdateSexo) As String
        Conexao.conectar()
        Dim Sql As String = " UPDATE tb_sexo SET `Sexo`='" & Sexo.Descricao & "' WHERE `tb_Pessoa_Fisica_id_Pessoa_Fisica`='" & Sexo.IdPessoaFisica & "';"
        Dim CMD2 As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try
            CMD2.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro ao Alterar os Dados da Pessoa Física na tabela Sexo - Erro: " & ex.Message, "Erro ao Alterar Pessoa Física", MessageBoxButtons.OK)
        Finally
            CMD2.Connection.Close()
        End Try
        Return Sql.ToString
    End Function
    Public Function UpdateEstadoCivil(Up_EstadoCivil As Update_EstadoCivil) As String
        Conexao.conectar()
        Dim Sql As String = " UPDATE tb_estado_civil SET `Estado_Civil`='" & Up_EstadoCivil.EstadoCivil & "' WHERE `tb_Pessoa_Fisica_id_Pessoa_Fisica`='" & Up_EstadoCivil.IdPessoaFisica & "';"
        Dim CMD3 As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)

        Try
            CMD3.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro ao Alterar os Dados da Pessoa Física na tabela EstadoCivil - Erro: " & ex.Message, "Erro ao Alterar Pessoa Física", MessageBoxButtons.OK)
        Finally
            CMD3.Connection.Close()
        End Try
        Return Sql.ToString
    End Function
    Public Function UpdateContato(Up_Contato As UpdateContato) As String
        Conexao.conectar()
        Dim Sql As String = " UPDATE tb_contato_pessoal SET `tel_residencial`='" & Up_Contato.TelResidencial & "',`tel_Recado`='" & Up_Contato.TelComercial & _
            "',`cel_pessoal`='" & Up_Contato.Celular & "',`nextel`='" & Up_Contato.Nextel & "',`email`='" & Up_Contato.Email & "' WHERE `tb_Pessoa_Fisica_id_Pessoa_Fisica`='" & _
            Up_Contato.IdPessoaFisica & "';"
        Dim CMD4 As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)

        Try
            CMD4.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro ao Alterar os Dados da Pessoa Física na tabela Contato - Erro: " & ex.Message, "Erro ao Alterar Pessoa Física", MessageBoxButtons.OK)
        Finally
            CMD4.Connection.Close()
        End Try
        Return Sql.ToString
    End Function
    Public Function UpdateItem(UpItem As UpdateItem) As String
        Conexao.conectar()
        Dim Sql As String = "UPDATE tb_item SET `item` = '" & UpItem.ItemPessoa & "' WHERE `tb_Pessoa_Fisica_id_Pessoa_Fisica` = '" & UpItem.IdPessoaFisica & "';"
        Dim CMD4 As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)

        Try
            CMD4.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro ao Alterar os Dados da Pessoa Física na tabela Item - Erro: " & ex.Message, "Erro ao Alterar Pessoa Física", MessageBoxButtons.OK)
        Finally
            CMD4.Connection.Close()
        End Try
        Return Sql.ToString
    End Function
End Class
