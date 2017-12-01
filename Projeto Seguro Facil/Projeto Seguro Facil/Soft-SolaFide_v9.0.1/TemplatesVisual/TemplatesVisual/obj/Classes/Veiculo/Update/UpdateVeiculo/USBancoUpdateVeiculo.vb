Public Class USBancoUpdateVeiculo
    Public Fabricante As String
    Public Modelo As String

    Public AnoModelo As String
    Public Placa As String
    Public Renavan As String
    Public Chassi As String
    Public Financiamento As String
    Public CorVeiculo As String
    Public qtda_portas As String
    Public Combustivel As String
    Public KitGas As String
    Public IdQuestao As String
    Public IdPessoaFisica As String
    Public IdPessoaJuridica As String
    Public AntFurto As String
    Public AnoFabric As String
    Public IdQuestoes As String
    Public Sub New(Fabricante As String, Modelo As String, Placa As String, Renavan As String, Chassi As String, Financiamento As String, CorVeiculo As String, qtda_portas As String, Combustivel As String, KitGas As String, IdQuestao As String, IdPessoaFisica As String, IdPessoaJuridica As String, AntFurto As String, AnoFabric As String, IdQuestoes As String)
        Me.Fabricante = Fabricante
        Me.Modelo = Modelo
        Me.Placa = Placa
        Me.Renavan = Renavan
        Me.Chassi = Chassi
        Me.Financiamento = Financiamento
        Me.CorVeiculo = CorVeiculo
        Me.qtda_portas = qtda_portas
        Me.Combustivel = Combustivel
        Me.KitGas = KitGas
        Me.IdQuestao = IdQuestao
        Me.IdPessoaFisica = IdPessoaFisica
        Me.IdPessoaJuridica = IdPessoaJuridica
        Me.AntFurto = AntFurto
        Me.AnoFabric = AnoFabric
        Me.IdQuestoes = IdQuestoes
    End Sub
End Class
