Imports System.ComponentModel
Imports System.Text


Partial Public Class PaginaPrincipal
    Inherits DevExpress.XtraEditors.XtraForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = "Hoje: " & Date.Now.ToString
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CDiv As New VencData
        CDiv.Aniversario()
        CDiv.VencimentoApolice()
        Label4.Text = "Hoje: " & Date.Now.ToString
    End Sub


    Private Sub OrçamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrçamentosToolStripMenuItem.Click
        frmCadastrarOrcamento.ShowDialog()
    End Sub

    Private Sub MenuOpcoes_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuOpcoes.ItemClicked

    End Sub

    Private Sub PessoaFísicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PessoaFísicaToolStripMenuItem.Click
        frmCadPFisica.ShowDialog()
    End Sub

    Private Sub PessoaJurídicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PessoaJurídicaToolStripMenuItem.Click
        CadastrarPessoaJuridica.ShowDialog()
    End Sub

    Private Sub SeguradoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeguradoraToolStripMenuItem.Click
        CadastrarSeguradora.ShowDialog()
    End Sub

    Private Sub CadastrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarToolStripMenuItem.Click

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        SaidaClientes.ShowDialog()

    End Sub

    Private Sub ComissõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComissõesToolStripMenuItem.Click
        Comissoes.ShowDialog()
    End Sub

    Private Sub SinistrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SinistrosToolStripMenuItem.Click
        Sinistros.ShowDialog()
    End Sub

    Private Sub btnGoCadCli_Click(sender As Object, e As EventArgs) Handles btnGoCadCli.Click
        frmCadPFisica.ShowDialog()
    End Sub

    Private Sub btnGoCadEmp_Click(sender As Object, e As EventArgs) Handles btnGoCadEmp.Click
        CadastrarPessoaJuridica.ShowDialog()
    End Sub

    Private Sub FazerBackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FazerBackupToolStripMenuItem.Click
        Backup.ShowDialog()
    End Sub

    Private Sub RestaurarDadosExcluidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestaurarDadosExcluidosToolStripMenuItem.Click
        Restore.ShowDialog()
    End Sub

    Private Sub btnGoCadVei_Click(sender As Object, e As EventArgs) Handles btnGoCadVei.Click
        frmDadosVeiculo.ShowDialog()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub MarcaVeiculoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Marca.ShowDialog()
    End Sub

    Private Sub MarcaVeiculoToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Marca.ShowDialog()
    End Sub

    Private Sub MarcaVeiculoToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles MarcaVeiculoToolStripMenuItem1.Click
        Marca.ShowDialog()
    End Sub

    Private Sub QuestionarioVeiculoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuestionarioVeiculoToolStripMenuItem.Click
        frmDadosVeiculo.ShowDialog()
    End Sub
End Class
