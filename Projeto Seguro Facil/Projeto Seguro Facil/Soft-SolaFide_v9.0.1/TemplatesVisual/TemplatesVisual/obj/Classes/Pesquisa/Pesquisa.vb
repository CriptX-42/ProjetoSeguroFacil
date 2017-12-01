Imports MySql.Data.MySqlClient
Public Class Pesquisa
    Dim btnConfirmar As Boolean = False
    Dim btnConfirmaJurid As Boolean = False
    Private Sub Pesquisa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarDadosP_Fisica()
        CarregarDadosP_Juridica()
    End Sub
    Private Sub CarregarDadosP_Fisica()
        Dim myConnectionString As String = ("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
        Dim conn As New MySqlConnection(myConnectionString)
        Try

            Dim sql As String = "Select * From solafide_v6.tb_pessoa_fisica WHERE Nome_Completo like '%" & txtPesquisa.Text & "%'"
            Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            DgvPesquisa.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub CarregarDadosP_Juridica()
        Dim myConnectionString As String = ("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
        Dim conn As New MySqlConnection(myConnectionString)
        Try

            Dim sql As String = "Select*From solafide_v6.tb_Pessoa_Juridica WHERE razao_social like '%" & txtPesquisa.Text & "%'"
            Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            DgvPessoaJuridica.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub txtPesquisa_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisa.TextChanged
        CarregarDadosP_Fisica()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
       
        'RETIRAR O TIMER
    End Sub

    Private Sub RbPessoaFisica_CheckedChanged(sender As Object, e As EventArgs)
        ' If RbPessoaFisica.Checked = True Then
        'CarregarDadosP_Fisica()
        'ElseIf RbPessoaJuridica.Checked = True Then
        'CarregarDadosP_Juridica()
        'End If
    End Sub

    Private Sub RbPessoaJuridica_CheckedChanged(sender As Object, e As EventArgs)
        'If RbPessoaFisica.Checked = True Then
        'CarregarDadosP_Fisica()
        'ElseIf RbPessoaJuridica.Checked = True Then
        'CarregarDadosP_Juridica()
        'End If
    End Sub
    Public Property NomeComplet As String
        Get
            NomeComplet = DgvPesquisa.CurrentRow.Cells("nome_completo").Value.ToString
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property CodPfisica As String
        Get
            CodPfisica = DgvPesquisa.CurrentRow.Cells("id_Pessoa_Fisica").Value.ToString
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property Confirm As Boolean
        Get
            Confirm = btnConfirmar
        End Get
        Set(value As Boolean)
            btnConfirmar = value
        End Set
    End Property
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.btnConfirmar = True
        Me.Hide()
    End Sub
    Public Property Representante As String
        Get
            Representante = DgvPessoaJuridica.CurrentRow.Cells("representante").Value.ToString
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property CodPJuridica As String
        Get
            CodPJuridica = DgvPessoaJuridica.CurrentRow.Cells("id_Pessoa_Juridica").Value.ToString
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property Confirmarcao As Boolean
        Get
            Confirmarcao = btnConfirmaJurid
        End Get
        Set(value As Boolean)
            btnConfirmaJurid = value
        End Set
    End Property
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.btnConfirmaJurid = True
        Me.Hide()
    End Sub
End Class