Imports MySql.Data.MySqlClient
Public Class PesquisarCPF_Consu
    Public Sub Consultar()
        Try
            Dim cx As New ConexaoSolafide
            Dim sql As String = ""
            cx.conectar()
            sql = "SELECT nome_completo,id_Pessoa_Fisica,estado_civil,cpf,dt_expedicao,sexo,dt_nascimento,rg,orgao_exped, " & _
                                    "profissao,cnh,tempo_habilitacao,especif_temp_hap,status,item,endereco,numero,cidade,cep,bairro,complemento, " & _
                                    "uf,bloco,apto,cel_pessoal,nextel,tel_recado,tel_residencial,email,comentarios FROM tb_pessoa_fisica pf " & _
                                    "INNER JOIN solafide_v6.tb_contato_pessoal cp ON pf.id_Pessoa_Fisica = cp.tb_Pessoa_Fisica_id_Pessoa_Fisica " & _
                                    "INNER JOIN solafide_v6.tb_endereco e On pf.id_Pessoa_Fisica = e.tb_Pessoa_Fisica_id_Pessoa_Fisica " & _
                                    "INNER JOIN solafide_v6.tb_sexo s ON pf.id_Pessoa_Fisica = s.tb_Pessoa_Fisica_id_Pessoa_Fisica " & _
                                    "INNER JOIN solafide_v6.tb_item i on pf.id_Pessoa_Fisica = i.tb_Pessoa_Fisica_id_Pessoa_Fisica " & _
                                    "INNER JOIN solafide_v6.tb_estado_civil ec ON pf.id_Pessoa_Fisica = ec.tb_Pessoa_Fisica_id_Pessoa_Fisica where pf.cpf ='" & Replace(frmCadPFisica.mskPesqCPF.Text.Replace("-", ""), ".", "") & "';"
            Dim cmd As New MySqlCommand
            cmd.CommandText = sql
            cmd.Connection = cx.cn

            Dim dr As MySqlDataReader = cmd.ExecuteReader

            If dr.Read Then
                With frmCadPFisica
                    'Inicio dos itens referentes aos Dados da Pessoa Física
                    .txtNome.Text = dr("Nome_Completo").ToString
                    .TxtId.Text = dr("id_Pessoa_Fisica").ToString
                    .cboEstCivil.Text = dr("estado_civil").ToString
                    .MskCPF.Text = dr("cpf").ToString
                    .mskDataExp.Text = dr("dt_expedicao").ToString
                    .cboSexo.Text = dr("Sexo").ToString
                    .mskNascimento.Text = dr("dt_nascimento").ToString
                    .mskRG.Text = dr("rg").ToString
                    .cboOrgExp.Text = dr("orgao_exped").ToString
                    .txtProfissao.Text = dr("profissao").ToString
                    .mskCNH.Text = dr("cnh").ToString
                    .txtTempoHab.Text = dr("tempo_habilitacao").ToString
                    .cboTempoHab.Text = dr("especif_temp_hap").ToString
                    .cboStatus.Text = dr("status").ToString
                    .txtItem.Text = dr("item").ToString
                    'Fim dos itens referentes aos Dados da Pessoa Física

                    'Inicio dos itens referentes ao Endereço da Pessoa Física
                    .txtEndereco.Text = dr("Endereco").ToString
                    .txtNumCasa.Text = dr("Numero").ToString
                    .txtCidade.Text = dr("cidade").ToString
                    .mskCEP.Text = dr("cep").ToString
                    .txtBairro.Text = dr("bairro").ToString
                    .txtComplemento.Text = dr("Complemento").ToString
                    .cboUf.Text = dr("uf").ToString
                    .txtBloco.Text = dr("bloco").ToString
                    .txtApto.Text = dr("apto").ToString
                    'Fim dos itens referentes ao Endereço da Pessoa Física

                    'Inicio dos itens referentes ao Contato da Pessoa Física
                    .mskCelular.Text = dr("cel_pessoal").ToString
                    .txtNextel.Text = dr("nextel").ToString
                    .mskTelRecado.Text = dr("tel_recado").ToString
                    .mskTelResid.Text = dr("tel_residencial").ToString
                    .txtEmail.Text = dr("email").ToString
                    'Fim dos itens referentes ao Contato da Pessoa Física

                    'Inicio dos itens referentes ao Comentário da Pessoa Física
                    .txtComentario.Text = dr("comentarios").ToString
                    'Fim dos itens referentes ao Comentário da Pessoa Física
                End With
            End If
            cmd.Connection.Close()
            cmd.Connection = Nothing
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro ao consultar o CEP da Pessoa Física", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class
