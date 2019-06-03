Imports System

Module ParesImpares
    Sub Main()
        Dim valor, par, impar, contador As UInt16
        es_Par_Impar(valor, contador, par, impar)
    End Sub
    Private Sub es_Par_Impar(valor, contador, par, impar)
        Do
            Console.WriteLine("Ingrese un Numero")
            valor = Console.ReadLine()
            If (valor <> 0) Then
                contador += 1
                If (valor Mod 2 = 0) Then
                    par += 1
                Else
                    impar += 1
                End If
            End If
        Loop Until valor = 0
        If par = contador Then
            Console.WriteLine("Todos son pares")
        ElseIf impar = contador Then
            Console.WriteLine("Todos son impares")
        Else
            Console.WriteLine("Son pares: {0}", par)
            Console.WriteLine("Son impares: {0}", impar)
        End If
    End Sub
End Module
