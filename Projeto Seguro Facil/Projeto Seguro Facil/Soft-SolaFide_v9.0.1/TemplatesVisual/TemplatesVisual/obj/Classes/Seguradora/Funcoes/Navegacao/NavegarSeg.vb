Imports MySql.Data.MySqlClient
Public Class NavegarSeg
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

            Dim adtp As New MySqlDataAdapter("SELECT * FROM tb_seguradora " & _
                    "Inner Join tb_contato_profissional on tb_contato_profissional.tb_Seguradora_id_seguradora= tb_seguradora.id_seguradora;", Conexao)
            adtp.Fill(adaptador)

        Catch ex As Exception
            ' MsgBox("Erro em carregar tabela" + ex.Message)
        Finally
            Conexao.Close()
        End Try
    End Sub

    Public Sub AtualizarForm()
        Try
            With CadastrarSeguradora
                .txtId.Text = adaptador.Rows(posicao)("id_seguradora").ToString
                .txtNome.Text = adaptador.Rows(posicao)("nome_seguradora").ToString
                .txtSiteAreaCorretor.Text = adaptador.Rows(posicao)("site_corretor").ToString
                .txtSite.Text = adaptador.Rows(posicao)("site_principal").ToString
                .txtComentarios.Text = adaptador.Rows(posicao)("comentarios").ToString

                .MaskTxtTelefone1.Text = adaptador.Rows(posicao)("tel_comercial").ToString
                .MaskTxtTelefone2.Text = adaptador.Rows(posicao)("cel_comercial").ToString
                .txtNextel.Text = adaptador.Rows(posicao)("nextel").ToString
                .txtEmail.Text = adaptador.Rows(posicao)("email").ToString


            End With
        Catch ex As Exception
            ' MessageBox.Show("Você não tem Seguradoras Cadastradas", "Cadastro de Seguradora", _
            '    MessageBoxButtons.OK)
        End Try
    End Sub

    Public Sub DescarregarForm()
        Try
            adaptador.Clear()

        Catch ex As Exception
            ' MsgBox("Erro em carregar tabela" + ex.Message)
        End Try
    End Sub

    Public Sub MovimentarRegistros(ByVal e As registros)
        Select Case e
            Case registros.Primeiro
                posicao = 0
                With CadastrarSeguradora
                    .btnPrimeiro.Enabled = False
                    .btnVoltar.Enabled = False
                    .btnIr.Enabled = True
                    .btnUltimo.Enabled = True
                End With
                
            Case registros.Anterior
                If posicao > 1 Then
                    posicao -= 1
                    With CadastrarSeguradora
                        .btnPrimeiro.Enabled = True
                        .btnVoltar.Enabled = True
                        .btnIr.Enabled = True
                        .btnUltimo.Enabled = True
                    End With
                    
                Else
                    posicao = 0
                    With CadastrarSeguradora
                        .btnPrimeiro.Enabled = False
                        .btnVoltar.Enabled = False
                        .btnIr.Enabled = True
                        .btnUltimo.Enabled = True
                    End With
                End If

            Case registros.Proximo
                If posicao < (adaptador.Rows.Count - 2) Then
                    posicao += 1
                    With CadastrarSeguradora
                        .btnPrimeiro.Enabled = True
                        .btnVoltar.Enabled = True
                        .btnIr.Enabled = True
                        .btnUltimo.Enabled = True
                    End With
                Else
                    posicao = adaptador.Rows.Count - 1
                    With CadastrarSeguradora
                        .btnPrimeiro.Enabled = True
                        .btnVoltar.Enabled = True
                        .btnIr.Enabled = False
                        .btnUltimo.Enabled = False
                    End With
                End If


            Case registros.Ultimo
                posicao = adaptador.Rows.Count - 1
                With CadastrarSeguradora
                    .btnPrimeiro.Enabled = True
                    .btnVoltar.Enabled = True
                    .btnIr.Enabled = False
                    .btnUltimo.Enabled = False
                End With

        End Select
    End Sub
End Class
