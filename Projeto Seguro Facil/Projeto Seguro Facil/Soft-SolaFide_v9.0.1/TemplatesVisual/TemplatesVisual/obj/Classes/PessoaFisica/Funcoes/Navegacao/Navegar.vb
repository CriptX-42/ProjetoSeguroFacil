Imports MySql.Data.MySqlClient
Public Class Navegar
    Dim adaptador As New DataTable
    Dim posicao As Integer = 0
    Public Enum registros
        Anterior
        Primeiro
        Proximo
        Ultimo
    End Enum
    Public Sub CarregarForm()
        Dim Conectando As String = ("server=localhost; Database=solafide_v6; Uid=JJR; Pwd=2043;")
        Dim Conexao As New MySqlConnection(Conectando)
        Try
            Dim adtp As New MySqlDataAdapter("SELECT nome_completo,id_Pessoa_Fisica,estado_civil,cpf,dt_expedicao,sexo,dt_nascimento,rg,orgao_exped, " & _
                                            "profissao,cnh,tempo_habilitacao,especif_temp_hap,status,item,endereco,numero,cidade,cep,bairro,complemento, " & _
                                            "uf,bloco,apto,cel_pessoal,nextel,tel_recado,tel_residencial,email,comentarios FROM tb_pessoa_fisica pf " & _
                                            "INNER JOIN solafide_v6.tb_contato_pessoal cp ON pf.id_Pessoa_Fisica = cp.tb_Pessoa_Fisica_id_Pessoa_Fisica " & _
                                            "INNER JOIN solafide_v6.tb_endereco e On pf.id_Pessoa_Fisica = e.tb_Pessoa_Fisica_id_Pessoa_Fisica " & _
                                            "INNER JOIN solafide_v6.tb_sexo s ON pf.id_Pessoa_Fisica = s.tb_Pessoa_Fisica_id_Pessoa_Fisica " & _
                                            "INNER JOIN solafide_v6.tb_item i on pf.id_Pessoa_Fisica = i.tb_Pessoa_Fisica_id_Pessoa_Fisica " & _
                                            "INNER JOIN solafide_v6.tb_estado_civil ec ON pf.id_Pessoa_Fisica = ec.tb_Pessoa_Fisica_id_Pessoa_Fisica;", Conexao)
            adtp.Fill(adaptador)
        Catch ex As Exception
            MessageBox.Show("Erro no Select do Navegar da Pessoa Física - Erro: " & ex.Message, "Erro no Select de Pessoa Física", _
             MessageBoxButtons.OK)
        Finally
            Conexao.Close()
        End Try
    End Sub
    Public Sub DescarregarForm()
        Try
            adaptador.Clear()
        Catch ex As Exception
            MessageBox.Show("Erro ao Limpar o Adaptador do Navegar de Pessoa Física - Erro: " & ex.Message, "Erro ao Limpar o Adaptador do Navegar de Pessoa Física", _
             MessageBoxButtons.OK)
        End Try
    End Sub
    Public Sub AtualizarForm()
        Try
            With frmCadPFisica
                'Inicio dos itens referentes aos Dados da Pessoa Física
                .txtNome.Text = adaptador.Rows(posicao)("nome_completo").ToString
                .TxtId.Text = adaptador.Rows(posicao)("id_Pessoa_Fisica").ToString
                .cboEstCivil.Text = adaptador.Rows(posicao)("estado_civil").ToString
                .MskCPF.Text = adaptador.Rows(posicao)("cpf").ToString
                .mskDataExp.Text = adaptador.Rows(posicao)("dt_expedicao").ToString
                .cboSexo.Text = adaptador.Rows(posicao)("sexo").ToString
                .mskNascimento.Text = adaptador.Rows(posicao)("dt_nascimento").ToString
                .mskRG.Text = adaptador.Rows(posicao)("rg").ToString
                .cboOrgExp.Text = adaptador.Rows(posicao)("orgao_exped").ToString
                .txtProfissao.Text = adaptador.Rows(posicao)("profissao").ToString
                .mskCNH.Text = adaptador.Rows(posicao)("cnh").ToString
                .txtTempoHab.Text = adaptador.Rows(posicao)("tempo_habilitacao").ToString
                .cboTempoHab.Text = adaptador.Rows(posicao)("especif_temp_hap").ToString
                .cboStatus.Text = adaptador.Rows(posicao)("status").ToString
                .txtItem.Text = adaptador.Rows(posicao)("item").ToString
                'Fim dos itens referentes aos Dados da Pessoa Física

                'Inicio dos itens referentes ao Endereço da Pessoa Física
                .txtEndereco.Text = adaptador.Rows(posicao)("endereco").ToString
                .txtNumCasa.Text = adaptador.Rows(posicao)("numero").ToString
                .txtCidade.Text = adaptador.Rows(posicao)("cidade").ToString
                .mskCEP.Text = adaptador.Rows(posicao)("cep").ToString
                .txtBairro.Text = adaptador.Rows(posicao)("bairro").ToString
                .txtComplemento.Text = adaptador.Rows(posicao)("complemento").ToString
                .cboUf.Text = adaptador.Rows(posicao)("uf").ToString
                .txtBloco.Text = adaptador.Rows(posicao)("bloco").ToString
                .txtApto.Text = adaptador.Rows(posicao)("apto").ToString
                'Fim dos itens referentes ao Endereço da Pessoa Física

                'Inicio dos itens referentes ao Contato da Pessoa Física
                .mskCelular.Text = adaptador.Rows(posicao)("cel_pessoal").ToString
                .txtNextel.Text = adaptador.Rows(posicao)("nextel").ToString
                .mskTelRecado.Text = adaptador.Rows(posicao)("tel_recado").ToString
                .mskTelResid.Text = adaptador.Rows(posicao)("tel_residencial").ToString
                .txtEmail.Text = adaptador.Rows(posicao)("email").ToString
                'Fim dos itens referentes ao Contato da Pessoa Física

                'Inicio dos itens referentes ao Comentário da Pessoa Física
                .txtComentario.Text = adaptador.Rows(posicao)("comentarios").ToString
                'Fim dos itens referentes ao Comentário da Pessoa Física
            End With
        Catch ex As Exception
            MessageBox.Show("Você não tem clientes cadastrados", "Erro na Navegação de Pessoa Física", _
             MessageBoxButtons.OK)
        End Try
    End Sub
    Public Sub MovimentarRegistros(ByVal e As registros)
        Select Case e
            Case registros.Primeiro
                posicao = 0
                frmCadPFisica.btnPrimeiro.Enabled = False
                frmCadPFisica.btnVoltar.Enabled = False
                frmCadPFisica.btnProximo.Enabled = True
                frmCadPFisica.btnUltimo.Enabled = True
            Case registros.Anterior
                If posicao > 1 Then
                    posicao -= 1
                    frmCadPFisica.btnPrimeiro.Enabled = True
                    frmCadPFisica.btnVoltar.Enabled = True
                    frmCadPFisica.btnProximo.Enabled = True
                    frmCadPFisica.btnUltimo.Enabled = True
                Else
                    posicao = 0
                    frmCadPFisica.btnPrimeiro.Enabled = False
                    frmCadPFisica.btnVoltar.Enabled = False
                    frmCadPFisica.btnProximo.Enabled = True
                    frmCadPFisica.btnUltimo.Enabled = True
                End If

            Case registros.Proximo
                If posicao < (adaptador.Rows.Count - 2) Then
                    posicao += 1
                    frmCadPFisica.btnPrimeiro.Enabled = True
                    frmCadPFisica.btnVoltar.Enabled = True
                    frmCadPFisica.btnProximo.Enabled = True
                    frmCadPFisica.btnUltimo.Enabled = True
                Else
                    posicao = adaptador.Rows.Count - 1
                    frmCadPFisica.btnPrimeiro.Enabled = True
                    frmCadPFisica.btnVoltar.Enabled = True
                    frmCadPFisica.btnProximo.Enabled = False
                    frmCadPFisica.btnUltimo.Enabled = False
                End If


            Case registros.Ultimo
                posicao = adaptador.Rows.Count - 1
                frmCadPFisica.btnPrimeiro.Enabled = True
                frmCadPFisica.btnVoltar.Enabled = True
                frmCadPFisica.btnProximo.Enabled = False
                frmCadPFisica.btnUltimo.Enabled = False

        End Select
    End Sub

End Class
