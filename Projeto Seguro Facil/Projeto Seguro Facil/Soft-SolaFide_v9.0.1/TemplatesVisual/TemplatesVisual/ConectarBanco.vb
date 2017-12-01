Imports System.Data
Imports System.Data.OleDb
Module ConectarBanco
    Public Function PegarConeccao() As OleDbConnection

        Dim strDriver As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & _
           "Data Source=C:\Users\Albert\Desktop\TemplatesVisual\Banco de Dados\bd_Teste_04" & _
           "User ID=;Password=;"
        Return New OleDbConnection(strDriver)
    End Function
End Module
