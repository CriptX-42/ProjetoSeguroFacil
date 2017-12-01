Imports MySql.Data.MySqlClient
Public Class Navegar_PJuri
    Dim adaptador As New DataTable
    Dim posicao As Integer = 0

    Public Enum registros
        Anterior
        Primeiro
        Proximo
        Ultimo
    End Enum

    Public Sub CarregarForm()
        Try

            Dim Conectando As String = ("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            Dim Conexao As New MySqlConnection(Conectando)
            Dim adtp As New MySqlDataAdapter("SELECT * FROM tb_pessoa_juridica " & _
             "INNER JOIN tb_contato_profissional ON tb_pessoa_juridica.id_pessoa_juridica = tb_contato_profissional.tb_pessoa_juridica_id_pessoa_juridica " & _
             "INNER JOIN tb_endereco On tb_pessoa_juridica.id_pessoa_juridica=tb_endereco.tb_pessoa_juridica_id_pessoa_juridica;", Conexao)
            adtp.Fill(adaptador)
            Conexao.Close()
        Catch ex As Exception
            MsgBox("Erro em carregar tabela" + ex.Message)
        End Try
    End Sub

    Public Sub DescarregarForm()
        Try
            adaptador.Clear()

        Catch ex As Exception
            MsgBox("Erro em carregar tabela" + ex.Message)
        End Try
    End Sub

    Public Sub AtualizarForm()
        Try
            With CadastrarPessoaJuridica
                .txtId.Text = adaptador.Rows(posicao)("Id_pessoa_juridica").ToString
                .txtRSocial.Text = adaptador.Rows(posicao)("razao_social").ToString
                .TxtNFantasia.Text = adaptador.Rows(posicao)("nome_fantasia").ToString
                .txtRepresent.Text = adaptador.Rows(posicao)("Representante").ToString
                .MaskTxtCnpj.Text = adaptador.Rows(posicao)("cnpj").ToString
                .txtAreaAtuacao.Text = adaptador.Rows(posicao)("area_Atuacao").ToString
                .txtSite.Text = adaptador.Rows(posicao)("site").ToString
                .TxtComentarios.Text = adaptador.Rows(posicao)("comentarios").ToString
                .cboStatus.Text = adaptador.Rows(posicao)("status").ToString

                .txtEndereco.Text = adaptador.Rows(posicao)("Endereco").ToString
                .txtNumero.Text = adaptador.Rows(posicao)("Numero").ToString
                .MaskTxtCep.Text = adaptador.Rows(posicao)("cep").ToString
                .txtBairro.Text = adaptador.Rows(posicao)("bairro").ToString
                .txtCidade.Text = adaptador.Rows(posicao)("cidade").ToString
                .cboUf.Text = adaptador.Rows(posicao)("uf").ToString
                .txtBloco.Text = adaptador.Rows(posicao)("bloco").ToString
                .txtComplemento.Text = adaptador.Rows(posicao)("Complemento").ToString

                .MaskTxtTelefone1.Text = adaptador.Rows(posicao)("tel_comercial").ToString
                .mskCelular.Text = adaptador.Rows(posicao)("cel_Comercial").ToString
                .txtEmail.Text = adaptador.Rows(posicao)("email").ToString

                .txtApto.Text = adaptador.Rows(posicao)("apto").ToString
            End With
            
        Catch ex As Exception

            'MessageBox.Show("Você não tem clientes cadastrados", "Cadastro de Pessoa Jurídica", _
            ' MessageBoxButtons.OK)
        End Try


    End Sub

    Public Sub MovimentarRegistros(ByVal e As registros)
        Select Case e
            Case registros.Primeiro
                posicao = 0
                With CadastrarPessoaJuridica
                    .btnPrimeiro.Enabled = False
                    .btnVoltar.Enabled = False
                    .btnIr.Enabled = True
                    .btnUltimo.Enabled = True
                End With
            Case registros.Anterior
                If posicao > 1 Then
                    With CadastrarPessoaJuridica
                        .btnPrimeiro.Enabled = True
                        .btnVoltar.Enabled = True
                        .btnIr.Enabled = True
                        .btnUltimo.Enabled = True
                    End With
                    posicao -= 1
                Else
                    With CadastrarPessoaJuridica
                        .btnPrimeiro.Enabled = False
                        .btnVoltar.Enabled = False
                        .btnIr.Enabled = True
                        .btnUltimo.Enabled = True
                    End With
                    posicao = 0
                End If

            Case registros.Proximo
                If posicao < (adaptador.Rows.Count - 2) Then
                    With CadastrarPessoaJuridica
                        .btnPrimeiro.Enabled = True
                        .btnVoltar.Enabled = True
                        .btnIr.Enabled = True
                        .btnUltimo.Enabled = True
                    End With
                    posicao += 1
                Else
                    With CadastrarPessoaJuridica
                        .btnPrimeiro.Enabled = True
                        .btnVoltar.Enabled = True
                        .btnIr.Enabled = False
                        .btnUltimo.Enabled = False
                    End With
                    posicao = adaptador.Rows.Count - 1
                End If


            Case registros.Ultimo
                With CadastrarPessoaJuridica
                    .btnPrimeiro.Enabled = True
                    .btnVoltar.Enabled = True
                    .btnIr.Enabled = False
                    .btnUltimo.Enabled = False
                End With
                posicao = adaptador.Rows.Count - 1

        End Select
    End Sub
End Class
