Imports MySql.Data.MySqlClient
Public Class ConsultaPsJuridicaCEP
    Public Sub Consultar()
        Try
            Dim CEPLimpo As String = CadastrarPessoaJuridica.MaskTxtCep.Text
            CEPLimpo = CEPLimpo.Replace("-", "")

            Dim cx As New ConexaoBanco
            Dim sql As String = ""
            cx.conectar()
            sql = "Select * From plan1 where cep='" & CEPLimpo.ToString & "';"
            Dim cmd As New MySqlCommand
            cmd.CommandText = sql
            cmd.Connection = cx.cn

            Dim dr As MySqlDataReader = cmd.ExecuteReader

            If dr.Read Then
                With CadastrarPessoaJuridica

                    .txtEndereco.Text = dr("descricao").ToString
                    .txtBairro.Text = dr("bairro").ToString
                    .txtCidade.Text = dr("Cidade").ToString
                    .cboUf.Text = dr("Uf").ToString
                End With
            End If
            cx.desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro ao consultar o CEP", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class
