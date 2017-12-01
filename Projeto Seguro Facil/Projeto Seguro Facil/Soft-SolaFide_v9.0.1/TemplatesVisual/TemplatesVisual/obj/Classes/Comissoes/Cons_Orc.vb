Imports MySql.Data.MySqlClient
Public Class Cons_Orc
    Dim btnConfirmar As Boolean = False
    Private Sub Cons_Orc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarDadosConsOrc()
    End Sub
    Private Sub CarregarDadosConsOrc()
        Dim myConnectionString As String = ("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
        Dim conn As New MySqlConnection(myConnectionString)
        Try
            Dim strSQL As String = "select ma.dt_calculo,cm.nome_cliente,ma.Seguradora_Orc, " & _
            "ma.premio_seguradora, p.parcelas, ma.perc_comissao " & _
            "from solafide_v6.tb_montagemapolice ma inner join " & _
            "solafide_v6.tb_pagamento p on p.tb_MontagemApolice_id_MontagemApolice = ma.id_MontagemApolice inner join " & _
            "solafide_v6.tb_client_montapolice cm on ma.id_MontagemApolice = cm.tb_MontagemApolice_id_MontagemApolice;"
            Dim cmd As MySqlCommand = New MySqlCommand(strSQL, conn)
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            dgvConsOrc.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Public Property nome_completoCons As String
        Get
            nome_completoCons = dgvConsOrc.CurrentRow.Cells("Nome_Cliente").Value.ToString
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property SeguradoraCons As String
        Get
            SeguradoraCons = dgvConsOrc.CurrentRow.Cells("Seguradora").Value.ToString
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property PremioCons As String
        Get
            PremioCons = dgvConsOrc.CurrentRow.Cells("Premio").Value.ToString
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property ParcelasCons As String
        Get
            ParcelasCons = dgvConsOrc.CurrentRow.Cells("parcelas").Value.ToString
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property PercComiCons As String
        Get
            PercComiCons = dgvConsOrc.CurrentRow.Cells("Perc_Comissao").Value.ToString
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property dtCalculoCons As String
        Get
            dtCalculoCons = dgvConsOrc.CurrentRow.Cells("dt_Calculo").Value.ToString
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
End Class