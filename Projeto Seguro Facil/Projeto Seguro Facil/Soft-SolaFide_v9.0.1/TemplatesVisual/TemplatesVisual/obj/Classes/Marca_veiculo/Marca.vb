Imports MySql.Data.MySqlClient
Public Class Marca
    Dim Objeto As New F_ObjetoMarca
    Dim Conexao As New ConexaoSolafide

    Dim IdMarca As String
    Dim go As Boolean = False
    Dim go2 As Boolean = False



    Private Sub BtLimpar_Click(sender As Object, e As EventArgs) Handles BtLimpar.Click
        BtnCadastrar.Enabled = True
        BtLimpar.Enabled = False
        If RbMarca.Checked = True Then
            Objeto.NovaMarca()

        ElseIf RbVeiculo.Checked = True Then
            Objeto.NovoVeiculo()
        End If
    End Sub

    Private Sub Marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Objeto.Loadfrm()
        ConsultarMarca()
        ConsultarVeiculo()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Objeto.Loadfrm()
        BtLimpar.Enabled = True
    End Sub

    Private Sub BtnCadastrar_Click(sender As Object, e As EventArgs) Handles BtnCadastrar.Click
        If RbMarca.Checked = True Then
            CadastrarMarca()
        ElseIf RbVeiculo.Checked = True Then
            CadastrarVeiculo()
        End If
        btnCancelar.Enabled = True
        BtnCadastrar.Enabled = False
        ConsultarMarca()
        ConsultarVeiculo()
        txtMarca.Text = ""
        txtVeiculo.Text = ""
        CboMarcas.Enabled = False
        txtVeiculo.Text = ""
        txtVeiculo.Enabled = False
        txtMarca.Enabled = False
        BtLimpar.Enabled = True
    End Sub
    Private Sub CadastrarVeiculo()
        If txtVeiculo.Text = "" Then
            MsgBox("Digite um veiculo")
        Else

            Try

                Dim SQL As String = ("SELECT id_lista_veiculo FROM tb_lista_marca_veiculo where Marca like '" & CboMarcas.Text & "';")
                Conexao.conectar()
                Dim command As New MySqlCommand(SQL, Conexao.cn)

                IdMarca = command.ExecuteScalar.ToString

                Conexao.cn.Close()

                command = Nothing
            Catch ex As Exception
                MsgBox("Erro no select Max Lista de veiculos" & ex.Message)
            End Try


            Dim UsandoVeiculo As USBancoMarca = New USBancoMarca
            Dim PBancoVeiculo As BancoVeiculo_Marca

            PBancoVeiculo = New BancoVeiculo_Marca(txtVeiculo.Text, IdMarca)

            UsandoVeiculo.UsandoDadosVeiculo_Marca(PBancoVeiculo)
            MsgBox("Cadastrado")

            BtnCadastrar.Enabled = False
            BtLimpar.Enabled = True
        End If
    End Sub
    Private Sub ConsultarMarca()

        Conexao.conectar()

        Try
            Dim I As Integer = 0
            Dim sql As String = ("SELECT * FROM tb_lista_marca_veiculo")
            Dim cmd As MySqlCommand = New MySqlCommand(sql, Conexao.cn)
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            CboMarcas.DisplayMember = "Marca"
            DgvMarca.DataSource = dt
            CboMarcas.DataSource = dt

        Catch ex As Exception
        Finally
            Conexao.cn.Close()
        End Try

        RbMarca.Enabled = True
        RbVeiculo.Enabled = True
    End Sub

    Private Sub ConsultarVeiculo()

        Conexao.conectar()

        Try
            Dim sql As String = ("SELECT id_lista_Nome_veiculo, Nome_veiculo FROM tb_lista_nome_veiculo")
            Dim cmd As MySqlCommand = New MySqlCommand(sql, Conexao.cn)
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            dgvVeiculos.DataSource = dt
        Catch ex As Exception
        Finally
            Conexao.cn.Close()
        End Try

        RbMarca.Enabled = True
        RbVeiculo.Enabled = True
    End Sub

    Private Sub CadastrarMarca()
        Dim UsandoMarca As USBancoMarca = New USBancoMarca
        Dim PBancoMarca As BancoMarca
        If txtMarca.Text = "" Then
            MsgBox("Digite uma marca")
        Else
            PBancoMarca = New BancoMarca(txtMarca.Text)

            UsandoMarca.UsandoDadosMarca(PBancoMarca)
            MsgBox("Marca Cadastrada com Sucesso!")
        End If
        
    End Sub

    Private Sub AlterarMarca()

        Conexao.conectar()

        Try

            Dim sql As String = ("UPDATE tb_lista_marca_veiculo SET `Marca` = '" & txtMarca.Text & "' WHERE `id_lista_veiculo` = @cod ;")

            Dim cmd As MySqlCommand = New MySqlCommand(sql, Conexao.cn)

            cmd.Parameters.AddWithValue("@cod", Label1.Text.ToString)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Falha na alteração: " & ex.ToString, MsgBoxStyle.OkOnly)
        Finally
            Conexao.cn.Close()
        End Try

        ConsultarMarca()
        ConsultarMarca()

    End Sub

    Private Sub AlterarVeiculo()

        Conexao.conectar()

        Try

            Dim sql As String = ("UPDATE tb_lista_nome_veiculo SET `Nome_veiculo` = '" & txtVeiculo.Text & "' WHERE `id_lista_Nome_veiculo` = @cod2 ;")

            Dim cmd As MySqlCommand = New MySqlCommand(sql, Conexao.cn)

            cmd.Parameters.AddWithValue("@cod2", Label2.Text.ToString)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Falha na alteração: " & ex.ToString, MsgBoxStyle.OkOnly)
        Finally
            Conexao.cn.Close()
        End Try

        ConsultarMarca()
        ConsultarVeiculo()

    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        BtLimpar.Enabled = False


        Try
            If dgvVeiculos.SelectedRows.Count > 0 Then
                If go2 = False Then
                    txtVeiculo.Enabled = True
                    txtVeiculo.Text = dgvVeiculos.CurrentRow.Cells(1).Value.ToString
                    Label2.Text = dgvVeiculos.CurrentRow.Cells(0).Value.ToString
                    txtMarca.Enabled = False
                    go2 = True
                Else
                    AlterarVeiculo()
                    txtVeiculo.Text = ""
                    txtVeiculo.Enabled = False
                    go2 = False
                End If
            Else

            End If
            If go = False Then
                txtMarca.Enabled = True
                txtMarca.Text = DgvMarca.CurrentRow.Cells(1).Value.ToString
                Label1.Text = DgvMarca.CurrentRow.Cells(0).Value.ToString
                go = True
            Else
                AlterarMarca()
                txtMarca.Text = ""
                txtMarca.Enabled = False
                go = False
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim result As Integer = MessageBox.Show("Quer Realmente excluir? ", "SolaFide", MessageBoxButtons.YesNo)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Deletar()
        End If
    End Sub

    Private Sub Deletar()

        Try

            Conexao.cn.Open()

            Dim sql As String = ("DELETE FROM tb_lista_marca_veiculo WHERE `id_lista_veiculo` = @cod;")

            Dim cmd As MySqlCommand = New MySqlCommand(sql, Conexao.cn)

            cmd.Parameters.AddWithValue("@cod", Label1.Text.ToString)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Falha na exclusão: " & ex.ToString, MsgBoxStyle.OkOnly)
        Finally
            Conexao.cn.Close()
        End Try

        ConsultarMarca()
    End Sub

    Private Sub DgvMarca_SelectionChanged(sender As Object, e As EventArgs) Handles DgvMarca.SelectionChanged
        btnAlterar.Enabled = True
        btnExcluir.Enabled = True
        Label1.Text = DgvMarca.CurrentRow.Cells(0).Value.ToString
        DgvMarca.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvVeiculos.ClearSelection()
        go = False
    End Sub

    Private Sub dgvVeiculos_SelectionChanged1(sender As Object, e As EventArgs) Handles dgvVeiculos.SelectionChanged
        Label2.Text = dgvVeiculos.CurrentRow.Cells(0).Value.ToString
        btnAlterar.Enabled = True
        dgvVeiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvMarca.ClearSelection()
    End Sub

End Class