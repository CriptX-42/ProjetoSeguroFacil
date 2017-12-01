Imports MySql.Data.MySqlClient
Public Class VencData
    Public Sub Aniversario()
        Try
            Dim cConfDiversas As New cDiversas
            Dim Mes As String = cConfDiversas.MesAno
            Dim Dia As String = cConfDiversas.DiaAno

            Dim Conectando As String = ("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            Dim conn As New MySqlConnection(Conectando)
            Dim OledbConnection As New MySqlConnection(Conectando)
            Dim adaptadorTabela As New DataTable
            Dim Adaptador2 As New MySqlDataAdapter("select solafide_v6.tb_pessoa_fisica.Nome_Completo,solafide_v6.tb_pessoa_fisica.dt_nascimento from solafide_v6.tb_pessoa_fisica where day(solafide_v6.tb_pessoa_fisica.dt_nascimento) >= '" & Dia.ToString & "' and month(solafide_v6.tb_pessoa_fisica.dt_nascimento)  ='" & Mes.ToString & "';", conn)

            Adaptador2.Fill(adaptadorTabela)
            PaginaPrincipal.DataGridView1.DataSource = adaptadorTabela



        Catch ex As Exception

        End Try
    End Sub
    Public Sub VencimentoApolice()
        Try
            Dim cConfDiversas As New cDiversas
            Dim Mes As String = cConfDiversas.MesAno
            Dim Dia As String = cConfDiversas.DiaAno

            Dim Conectando As String = ("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            Dim conn As New MySqlConnection(Conectando)
            Dim OledbConnection As New MySqlConnection(Conectando)
            Dim adaptadorTabela As New DataTable
            Dim Adaptador2 As New MySqlDataAdapter("select tb_orcamento.dt_Fim, tb_orcamento.id_Orcamento from tb_orcamento where day(solafide_v6.tb_orcamento.dt_Fim) >= '" & Dia.ToString & "' and month(solafide_v6.tb_orcamento.dt_Fim)  ='" & Mes.ToString & "';", conn)

            Adaptador2.Fill(adaptadorTabela)
            PaginaPrincipal.DataGridView2.DataSource = adaptadorTabela



        Catch ex As Exception

        End Try
    End Sub
End Class
