Imports System

Module Primos
    Sub Main()
        Dim contador As Int16
        Console.WriteLine("Numeros Primos")
        mostrarPrimos(contador)
    End Sub
    Private Sub mostrarPrimos(contador)
        For x As Int16 = 1 To 1000
            contador = 0
            For y As Int16 = 1 To 1000
                If (x Mod y = 0) Then
                    contador += 1
                End If
            Next
            If (contador = 2) Then
                Console.Write("{0} ", x)
            End If
        Next
    End Sub
End Module
