Imports MySql.Data.MySqlClient
Public Class NavegacaoSinistr
    Dim adaptador As New DataTable
    Dim posicao As Integer = 0
    Public Enum registros
        Anterior
        Primeiro
        Proximo
        Ultimo
    End Enum

    Public Sub CarregarForm()
        Dim Conectando As String = ("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
        Dim Conexao As New MySqlConnection(Conectando)
        Try

            Dim adtp As New MySqlDataAdapter("Select * from tb_sinistro " & _
            "Inner Join tb_endereco on tb_endereco.tb_sinistro_id_sinistro = tb_sinistro.id_sinistro;", Conexao)
            adtp.Fill(adaptador)

        Catch ex As Exception
            'MsgBox("Erro ao carregar tabela Sinistro : " + ex.Message)
        Finally
            Conexao.Close()
        End Try
    End Sub

    Public Sub DescarregarForm()
        Try
            adaptador.Clear()
        Catch ex As Exception
            ' MsgBox("Erro em Descarregar tabela Sinistro : " + ex.Message)
        End Try
    End Sub
    Public Sub AtualizarForm()
        Try
            With Sinistros

                .TxtTipo.Text = adaptador.Rows(posicao)("sinistro_ocorrido").ToString
                .TxtEnvolvidos.Text = adaptador.Rows(posicao)("pessoas_envolvidas").ToString
                .MaskedTextBox1.Text = adaptador.Rows(posicao)("dt_sinistro").ToString
                .txtNumSinistro.Text = adaptador.Rows(posicao)("nro_sinistro").ToString
                .txtApolice.Text = adaptador.Rows(posicao)("apolice").ToString
                .TxtComentarios.Text = adaptador.Rows(posicao)("acompanhamento").ToString
                .txtID.Text = adaptador.Rows(posicao)("id_sinistro").ToString

                .txtNumCasa.Text = adaptador.Rows(posicao)("numero").ToString
                .MaskTxtCep.Text = adaptador.Rows(posicao)("cep").ToString
                .txtBairro.Text = adaptador.Rows(posicao)("bairro").ToString
                .txtCidade.Text = adaptador.Rows(posicao)("Cidade").ToString
                .cboUf.Text = adaptador.Rows(posicao)("UF").ToString
                .txtEndereco.Text = adaptador.Rows(posicao)("endereco").ToString
            End With


        Catch ex As Exception
            ' MsgBox("Erro em navegar Orçamento :" + ex.Message)
        End Try

    End Sub
    Public Sub MovimentarRegistros(ByVal e As registros)
        Try
            With Sinistros
                Select Case e
                    Case registros.Primeiro
                        posicao = 0
                        .btnPrimeiro.Enabled = False
                        .btnVoltar.Enabled = False
                        .btnIr.Enabled = True
                        .btnUltimo.Enabled = True
                    Case registros.Anterior
                        If posicao > 1 Then
                            posicao -= 1
                            .btnPrimeiro.Enabled = True
                            .btnVoltar.Enabled = True
                            .btnIr.Enabled = True
                            .btnUltimo.Enabled = True
                        Else
                            posicao = 0
                            .btnPrimeiro.Enabled = False
                            .btnVoltar.Enabled = False
                            .btnIr.Enabled = True
                            .btnUltimo.Enabled = True
                        End If

                    Case registros.Proximo
                        If posicao < (adaptador.Rows.Count - 2) Then
                            posicao += 1
                            .btnPrimeiro.Enabled = True
                            .btnVoltar.Enabled = True
                            .btnIr.Enabled = True
                            .btnUltimo.Enabled = True
                        Else
                            posicao = adaptador.Rows.Count - 1
                            .btnPrimeiro.Enabled = True
                            .btnVoltar.Enabled = True
                            .btnIr.Enabled = False
                            .btnUltimo.Enabled = False
                        End If


                    Case registros.Ultimo
                        posicao = adaptador.Rows.Count - 1
                        .btnPrimeiro.Enabled = True
                        .btnVoltar.Enabled = True
                        .btnIr.Enabled = False
                        .btnUltimo.Enabled = False

                End Select
            End With
        Catch ex As Exception
            MsgBox("Erro - " + ex.Message)
        End Try

    End Sub
End Class
