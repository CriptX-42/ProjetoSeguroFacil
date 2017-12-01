Public Class BancoMontagem
    Public DataCalculo As String
    Public VigeIni As String
    Public VigeFim As String
    Public Premio As String
    Public franquia As String
    Public cobertura As String
    Public dnMtr As String
    Public dnCorp As String
    Public appMorte As String
    Public appInval As String
    Public dnMoral As String
    Public ass24Horas As String
    Public vidros As String
    Public CarReserv As String
    Public Comentarios As String

    'Public Apolice As String
    Public CI As String
    'Public IDPessoaFisica As String
    'Public IDPessoaJuridica As String
    'Public NroApolice As String
    Public Seguradora As String
    Public PercComissao As String
    Public Sub New(DataCalculo As String, VigeIni As String, VigeFim As String, Premio As String, franquia As String, cobertura As String, DnMtr As String, DnCorp As String,
                   appMorte As String, appinval As String, dnMoral As String, ass24Horas As String, Vidros As String, CarReserv As String, Comentarios As String, CI As String, Seguradora As String, PercComissao As String)
        Me.DataCalculo = DataCalculo
        Me.VigeIni = VigeIni
        Me.VigeFim = VigeFim
        Me.Premio = Premio
        Me.franquia = franquia
        Me.cobertura = cobertura
        Me.dnMtr = DnMtr
        Me.dnCorp = DnCorp
        Me.appMorte = appMorte
        Me.appInval = appinval
        Me.dnMoral = dnMoral
        Me.ass24Horas = ass24Horas
        Me.vidros = Vidros
        Me.CarReserv = CarReserv
        Me.Comentarios = Comentarios

        ' Me.Apolice = Apolice
        Me.CI = CI
        'Me.IDPessoaFisica = IDPessoaFisica
        ' Me.IDPessoaJuridica = IDPessoaJuridica
        Me.Seguradora = Seguradora
        Me.PercComissao = PercComissao
    End Sub

End Class
