Imports MySql.Data.MySqlClient
Public Class USBancoPeriodoEstudosUpdate

    Public Function UsarBancoPeriodoEstudos(Estudo As BancoPeriodoEstudosUpdate) As String

        'MODIFICAR

        Dim CMD As New MySqlCommand("UPDATE `tb_periodo_estudo` SET `matutino`='" & Estudo.Matutino & "', `vespertino`='" & Estudo.Vespertino & "', `noturno`='" & Estudo.Noturno & "' WHERE `id_periodo_estudo`='" & Estudo.IDQuestoes & "';")

        Try
            CMD.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=JJR; Pwd=2043;")
            CMD.Connection.Open()
            CMD.ExecuteNonQuery()

            CMD.Connection.Close()

        Catch ex As Exception
            MsgBox("Erro ao inserir a Relacão entre Condutor e Segurado: " & ex.Message)

        End Try
        Return CMD.ToString
    End Function

End Class
