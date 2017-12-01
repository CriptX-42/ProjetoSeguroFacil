Imports MySql.Data.MySqlClient
Public Class SlClienteVeiculo
    Dim btnConfirmar As Boolean = False
    Dim btnConfirmaJurid As Boolean = False
    Private Sub SlClienteVeiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarDadosP_Fisica()
        CarregarDadosP_Juridica()
    End Sub
    Private Sub CarregarDadosP_Fisica()
        Dim myConnectionString As String = ("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
        Dim conn As New MySqlConnection(myConnectionString)
        Try

            Dim sql As String = "select id_Pessoa_Fisica, nome_completo ,id_Dados_Veiculo ,fabricante,modelo" & _
            " from solafide_v6.tb_pessoa_fisica Inner Join tb_dados_veiculo on tb_dados_veiculo.tb_Pessoa_Fisica_id_Pessoa_Fisica = tb_pessoa_fisica.id_Pessoa_Fisica WHERE Nome_Completo like '%" & txtPesquisa.Text & "%'"
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

            Dim sql As String = "Select id_Pessoa_Juridica,representante,id_Dados_Veiculo,fabricante,modelo " & _
                " from tb_Pessoa_Juridica Inner Join tb_dados_veiculo on tb_dados_veiculo.tb_Pessoa_Juridica_id_Pessoa_Juridica = tb_Pessoa_Juridica.id_Pessoa_Juridica WHERE tb_Pessoa_Juridica.razao_social like '%" & txtPesquisa.Text & "%'"
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
    Public Property CodigoCarro As String
        Get
            CodigoCarro = DgvPesquisa.CurrentRow.Cells("id_Dados_Veiculo").Value.ToString
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property FabricanteCar As String
        Get
            FabricanteCar = DgvPesquisa.CurrentRow.Cells("fabricante").Value.ToString
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property ModeloCar As String
        Get
            ModeloCar = DgvPesquisa.CurrentRow.Cells("modelo").Value.ToString
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
    '---=======================================================Pessoa Juridica============================================================='
    Public Property Representante As String
        Get
            Representante = DgvPessoaJuridica.CurrentRow.Cells("representanteJuri").Value.ToString
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
    Public Property CodVecJuri As String
        Get
            CodVecJuri = DgvPessoaJuridica.CurrentRow.Cells("id_Dados_Veiculo_Juri").Value.ToString
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property FabricJuri As String
        Get
            FabricJuri = DgvPessoaJuridica.CurrentRow.Cells("fabricanteJuri").Value.ToString
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property ModelJuri As String
        Get
            ModelJuri = DgvPessoaJuridica.CurrentRow.Cells("modeloJuri").Value.ToString
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