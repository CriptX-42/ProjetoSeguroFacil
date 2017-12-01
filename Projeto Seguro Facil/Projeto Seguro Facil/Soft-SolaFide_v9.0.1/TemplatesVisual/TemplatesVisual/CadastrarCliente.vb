Imports System.Data
Imports System.Data.OleDb
Public Class CadastrarCliente

    Private Sub Cadastrar()
        'USANDO APRIMEIRA CLASSE
        Dim Pbanco As Banco
        Pbanco = New Banco(TextBoxNome.Text, MaskedTextBoxCPF.Text)

        'USANDO A SEGUNDA CLASSE
        Dim UsandoBanco As USBanco
        UsandoBanco = New USBanco()
        UsandoBanco.UsandoDados(Pbanco)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cadastrar()
    End Sub

    Private Sub CadastrarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ConfDiversas As New cDiversas
        ToolStripStatusLabelRecHora.Text = ConfDiversas.Hora
        ToolStripStatusLabelRecData.Text = ConfDiversas.Data
        ToolStripStatusLabelRecCumprimentos.Text = ConfDiversas.cumprimentos
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim ConfDiversas As New cDiversas
        ToolStripStatusLabelRecHora.Text = ConfDiversas.Hora
        ToolStripStatusLabelRecData.Text = ConfDiversas.Data
        ToolStripStatusLabelRecCumprimentos.Text = ConfDiversas.cumprimentos
    End Sub
End Class