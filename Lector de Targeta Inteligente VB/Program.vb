



Module Program

    Sub Main(args As String())

        Dim LectorTarjetaInteligente As New LectorTarjetaInteligenteShort
        LectorTarjetaInteligente.ESTCONTEXT_LTI()
        LectorTarjetaInteligente.CONNECT_LTI()
        LectorTarjetaInteligente.PRESENTPINCard("2W", "")
        LectorTarjetaInteligente.READCard2W(100)
        LectorTarjetaInteligente.DISCONNECT_LTI()
        LectorTarjetaInteligente.RELCONTEXT_LTI()
        Console.ReadKey()

    End Sub
End Module

