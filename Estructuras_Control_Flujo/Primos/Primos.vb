Imports System

Module Primos
    Sub Main()
        Dim contador, x, y As Int16
        Console.WriteLine("Numeros Primos")
        For x = 1 To 1000
            contador = 0
            For y = 1 To 1000
                If (x Mod y = 0) Then
                    contador += 1
                End If
            Next
            If (contador = 2) Then
                Console.Write("{0} ", x)
            End If
        Next
        Console.WriteLine()
    End Sub
End Module
