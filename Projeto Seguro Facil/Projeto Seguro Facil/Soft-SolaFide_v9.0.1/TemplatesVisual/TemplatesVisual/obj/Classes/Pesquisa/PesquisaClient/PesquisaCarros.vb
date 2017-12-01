Imports MySql.Data.MySqlClient
Public Class PesquisaCarros
    Dim Cliente As New SlClienteVeiculo
    Dim Codcliente As String

    Private Sub CarregarCarros()

        If Cliente.Confirm = True Then
            Codcliente = Cliente.CodPfisica

            Dim myConnectionString As String = ("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            Dim conn As New MySqlConnection(myConnectionString)
            Try

                Dim sql As String = "Select * From tb_dados_veiculo WHERE tb_Pessoa_Fisica_id_Pessoa_Fisica = '" & Codcliente & "'"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                DataGridView1.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub

    Private Sub PesquisaCarros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarCarros()
    End Sub
End Class