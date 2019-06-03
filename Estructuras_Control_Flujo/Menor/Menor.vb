Imports System

Module Menor
    Sub Main()
        Dim a, menor As Int16
        a = ingreseNumero(a)
        menor = a
        a = ingreseNumero(a)
        menor = elMenor(a, menor)
        a = ingreseNumero(a)
        menor = elMenor(a, menor)
        Console.WriteLine("El menor es: {0}", menor)
    End Sub
    Private Function ingreseNumero(a) As Int16
        Console.WriteLine("Ingrese un numero")
        a = Console.ReadLine()
        Return a
    End Function
    Private Function elMenor(a, menor) As Int16
        If a < menor Then
            menor = a
        End If
        Return menor
    End Function
End Module
