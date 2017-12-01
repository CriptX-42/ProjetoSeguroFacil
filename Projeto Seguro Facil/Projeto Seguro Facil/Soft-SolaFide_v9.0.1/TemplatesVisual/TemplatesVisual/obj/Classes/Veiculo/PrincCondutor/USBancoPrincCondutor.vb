Imports MySql.Data.MySqlClient
Public Class USBancoPrincCondutor

    Public Function UsarCondtPrincipal(Condutor As PrincCondutor) As String

        'MODIFICAR



        Dim CMD As New MySqlCommand("INSERT INTO `solafide_v6`.`tb_principal_condutor` (especifique,Nome_princ_condut," & _
                                    "tb_Pessoa_Fisica_id_Pessoa_Fisica,tb_Pessoa_Juridica_id_Pessoa_Juridica, tb_Questionario_Seguro_Auto_id_questionario,Reside_Em) " & _
                                    "VALUES ('" & Condutor.especifique & "','" & Condutor.NomePrinciCondut & "'," & Condutor.IdPessoaFisica & "," & Condutor.IdPessoJuridica & ", '" & Condutor.IdQuestionario & "','" & Condutor.PrincipalReside & "');")
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
    Public Function UsarSegundCond(SegCondutor As SegundCondutor) As String
        Try
            'MODIFICAR

            Dim CMD As New MySqlCommand("INSERT INTO `solafide_v6`.`tb_Segundo_Condutor` (`nomeSegundCondut`, `dt_nascimento`, `tb_Questionario_Seguro_Auto_id_questionario`,`CNH_Seg_Condult`)" & _
                                        "VALUES ('" & SegCondutor.nome & "', '" & SegCondutor.dt_nascimento & "', '" & SegCondutor.idQuestionario & "', '" & SegCondutor.CNH_SegundoCondutor & "');")



            CMD.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            CMD.Connection.Open()
            CMD.ExecuteNonQuery()

            CMD.Connection.Close()

        Catch ex As Exception
            MsgBox("Erro ao inserir Segundo Condutor: " & ex.Message)

        End Try

    End Function
    Public Function UsarSexo(Sexo As UsandoSexoPrincCundult) As String

        'MODIFICAR

        Dim CMD As New MySqlCommand("INSERT INTO tb_sexo(sexo,tb_Segundo_Condutor_id_segundo_condutor) VALUES ('" & Sexo.Sexo & "', '" & Sexo.IdSegundoCondutor & "');")

        Try

            CMD.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            CMD.Connection.Open()
            CMD.ExecuteNonQuery()

            CMD.Connection.Close()

        Catch ex As Exception
            MsgBox("Erro ao inserir sexo do Segundo Condutor: " & ex.Message)

        End Try
        Return CMD.ToString
    End Function
End Class
