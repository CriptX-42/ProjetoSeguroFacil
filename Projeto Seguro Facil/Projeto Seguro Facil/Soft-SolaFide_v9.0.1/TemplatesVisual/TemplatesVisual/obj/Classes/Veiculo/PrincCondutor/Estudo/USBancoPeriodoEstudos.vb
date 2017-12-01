Imports MySql.Data.MySqlClient
Public Class USBancoPeriodoEstudos
    Public Function UsarPeridoEstud(Estudo As BancoPeriodoEstudo) As String

        'MODIFICAR

        Dim CMD As New MySqlCommand("INSERT INTO `solafide_v6`.`tb_periodo_estudo` (`matutino`, `vespertino`, `noturno`, `tb_Questionario_id_questionario`)" & _
                                    "VALUES ('" & Estudo.Matutino & "', '" & Estudo.Vespertino & "', '" & Estudo.Noturno & "', '" & Estudo.IDQuestoes & "');")

        Try
            CMD.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            CMD.Connection.Open()
            CMD.ExecuteNonQuery()

            CMD.Connection.Close()

        Catch ex As Exception
            MsgBox("Erro ao inserir a Relacão entre Condutor e Segurado: " & ex.Message)

        End Try
        Return CMD.ToString
    End Function
End Class
