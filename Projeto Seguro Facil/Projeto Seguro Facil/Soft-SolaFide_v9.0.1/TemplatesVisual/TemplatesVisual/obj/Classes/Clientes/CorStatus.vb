Public Class CorStatus
    Public Sub CorStatusCli()
        With SaidaClientes
            For Each row As DataGridViewRow In .DgvCli.Rows

                If Not row.IsNewRow Then

                    For Each cell As DataGridViewCell In row.Cells

                        If cell.Value.ToString.Contains("Frio") Then
                            With .DgvCli.Rows(row.Index).DefaultCellStyle
                                .BackColor = Color.Blue
                                .ForeColor = Color.White

                            End With
                        ElseIf cell.Value.ToString.Contains("Morno") Then
                            With .DgvCli.Rows(row.Index).DefaultCellStyle
                                .BackColor = Color.Aqua

                            End With
                        ElseIf cell.Value.ToString.Contains("Quente") Then
                            With .DgvCli.Rows(row.Index).DefaultCellStyle
                                .BackColor = Color.Red
                                .ForeColor = Color.White
                            End With
                        ElseIf cell.Value.ToString.Contains("Ativo") Then
                            With .DgvCli.Rows(row.Index).DefaultCellStyle
                                .BackColor = Color.Green
                                .ForeColor = Color.White
                            End With
                        ElseIf cell.Value.ToString.Contains("Aguardando confirmação") Then
                            With .DgvCli.Rows(row.Index).DefaultCellStyle
                                .BackColor = Color.Yellow

                            End With
                            Exit For

                        End If

                    Next

                End If

            Next
        End With
    End Sub
    Public Sub CorStatusCliJurid()
        With SaidaClientes
            For Each row As DataGridViewRow In .DgvPessoaJuridica.Rows

                If Not row.IsNewRow Then

                    For Each cell As DataGridViewCell In row.Cells

                        If cell.Value.ToString.Contains("Frio") Then
                            With .DgvCli.Rows(row.Index).DefaultCellStyle
                                .BackColor = Color.Blue
                                .ForeColor = Color.White

                            End With
                        ElseIf cell.Value.ToString.Contains("Morno") Then
                            With .DgvCli.Rows(row.Index).DefaultCellStyle
                                .BackColor = Color.Aqua
                                .ForeColor = Color.White
                            End With
                        ElseIf cell.Value.ToString.Contains("Quente") Then
                            With .DgvCli.Rows(row.Index).DefaultCellStyle
                                .BackColor = Color.Red
                                .ForeColor = Color.White
                            End With
                        ElseIf cell.Value.ToString.Contains("Ativo") Then
                            With .DgvCli.Rows(row.Index).DefaultCellStyle
                                .BackColor = Color.Green
                                .ForeColor = Color.White
                            End With
                        ElseIf cell.Value.ToString.Contains("Aguardando confirmação") Then
                            With .DgvCli.Rows(row.Index).DefaultCellStyle
                                .BackColor = Color.Yellow
                                .ForeColor = Color.White
                            End With
                            Exit For

                        End If

                    Next

                End If

            Next
        End With
    End Sub

End Class
