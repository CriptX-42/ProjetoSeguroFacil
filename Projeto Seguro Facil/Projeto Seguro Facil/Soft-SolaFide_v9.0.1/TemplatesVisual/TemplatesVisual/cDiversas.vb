Public Class cDiversas
    Dim intHora, intMinuto, intSegundos As Integer
    Dim strHora, strMinuto, strSegundo, strHorario As String
    Function Hora() As String

        'horario

        intHora = Hour(Now)
        intMinuto = Minute(Now)
        intSegundos = Second(Now)

        'Converter a cadeia de interios em string e adiciona 00

        strHora = Microsoft.VisualBasic.Right("00" + Trim(Str(intHora)), 2)
        strMinuto = Microsoft.VisualBasic.Right("00" + Trim(Str(intMinuto)), 2)
        strSegundo = Microsoft.VisualBasic.Right("00" + Trim(Str(intSegundos)), 2)

        'Montamos a String Completa HH:MM:SS

        strHorario = String.Format("{0} : {1} : {2}", strSegundo, strMinuto, strHora)
        Hora = strHorario
    End Function
    Function Data() As String
        Dim dt As DateTime = Now
        Dim cdt As String = FormatDateTime(dt, DateFormat.ShortDate)
        Data = cdt
    End Function
    Function cumprimentos() As String
        Dim Mensagem As Integer = Hour(Now)
        Dim HoraMensagem As String
        'Mensagem Usuário
        Select Case (Mensagem)
            Case 6 To 12
                HoraMensagem = "! Bom Dia"

            Case 13 To 18

                HoraMensagem = "! Boa Tarde"

            Case 19 To 24

                HoraMensagem = "! Boa Noite"

            Case Else

                HoraMensagem = "! Bom Madrugada"
        End Select
        cumprimentos = HoraMensagem
    End Function

End Class
