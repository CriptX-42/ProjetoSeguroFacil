Imports MySql.Data.MySqlClient
Public Class PesquisaPCNPJ_Consu
    Public Sub Consultar()
        Try

        Dim cx As New ConexaoSolafide
        Dim sql As String = ""

        sql = "SELECT * FROM tb_pessoa_juridica " & _
             "INNER JOIN tb_contato ON tb_pessoa_juridica.id_pessoa_juridica = tb_contato.tb_pessoa_juridica_id_pessoa_juridica " & _
             "INNER JOIN tb_endereco On tb_pessoa_juridica.id_pessoa_juridica = tb_endereco.tb_pessoa_juridica_id_pessoa_juridica;" & _
             "WHERE tb_pessoa_jurudica.CNPJ='" & CadastrarPessoaJuridica.txtPesquisa.Text & "';"
        Dim cmd As New MySqlCommand
        cmd.CommandText = sql
        cmd.Connection = cx.cn

        Dim dr As MySqlDataReader = cmd.ExecuteReader

        If dr.Read Then
            With CadastrarPessoaJuridica
                .txtId.Text = dr("Id_pessoa_juridica").ToString
                .txtRSocial.Text = dr("razao_social").ToString
                .TxtNFantasia.Text = dr("nome_fantasia").ToString
                .txtAreaAtuacao.Text = dr("area_Atuacao").ToString
                .MaskTxtCnpj.Text = dr("cnpj").ToString
                .txtSite.Text = dr("site").ToString


                .MaskTxtTelefone1.Text = dr("tel_comercial").ToString
                    .mskCelular.Text = dr("tel_recado").ToString

                .txtEndereco.Text = dr("Endereco").ToString
                .txtNumero.Text = dr("Numero").ToString
                .cboUf.Text = dr("uf").ToString
                .MaskTxtCep.Text = dr("cep").ToString
                .txtCidade.Text = dr("cidade").ToString
                .txtComplemento.Text = dr("Complemento").ToString
                .txtBairro.Text = dr("bairro").ToString
            End With
        End If
        cx.desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro ao consultar o CEP", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class
