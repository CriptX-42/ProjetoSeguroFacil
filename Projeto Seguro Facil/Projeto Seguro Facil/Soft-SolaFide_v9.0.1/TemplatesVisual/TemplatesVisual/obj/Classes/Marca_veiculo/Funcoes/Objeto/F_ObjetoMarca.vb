Public Class F_ObjetoMarca
    Public Sub NovaMarca()
        With Marca

            .CboMarcas.Visible = True

            .lbMarca.Visible = True
            .txtMarca.Enabled = True
            .txtMarca.Visible = True
            .lbNovaMarca.Enabled = True

            .txtVeiculo.Visible = True
            .lbNovoVeiculo.Visible = True
            .lbNovaMarca.Visible = True

            .RbMarca.Enabled = False
            .RbVeiculo.Enabled = False

            .btnAlterar.Enabled = True
            .btnExcluir.Enabled = True
            .BtnCadastrar.Visible = True
            .btnCancelar.Visible = True
            .Label1.Visible = False
            .Label2.Visible = False
        End With
    End Sub
    Public Sub NovoVeiculo()
        With Marca
            .Label1.Visible = False
            .Label2.Visible = False
            .txtVeiculo.Visible = True
            .txtVeiculo.Enabled = True

            .CboMarcas.Visible = True
            .CboMarcas.Enabled = True



            .RbMarca.Enabled = False
            .RbVeiculo.Enabled = False

            .BtnCadastrar.Enabled = True
            .btnAlterar.Enabled = True
            .btnExcluir.Enabled = True
            .BtnCadastrar.Visible = True
            .btnCancelar.Visible = True
        End With

    End Sub
    Public Sub Loadfrm()
        With Marca
            .CboMarcas.Visible = True
            .CboMarcas.Enabled = False
            .txtVeiculo.Visible = True
            .txtVeiculo.Enabled = False

            .txtMarca.Visible = True
            .txtMarca.Enabled = False
            .lbMarca.Visible = True
            .lbNovaMarca.Visible = True

            .lbMarca.Visible = True
            .lbNovoVeiculo.Visible = True

            .RbMarca.Enabled = True
            .RbVeiculo.Enabled = True

            .Label1.Visible = False
            .Label2.Visible = False

            .BtnCadastrar.Enabled = False
            .btnAlterar.Enabled = False
            .btnExcluir.Enabled = False
            .BtnCadastrar.Visible = True
            .btnCancelar.Visible = False
            .txtMarca.Text = ""
            .txtVeiculo.Text = ""
        End With
    End Sub
End Class
