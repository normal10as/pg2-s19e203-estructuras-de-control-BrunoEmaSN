Imports System

Module Menor
    Sub Main()
        Dim a, b, c As Single
        a = ingreseNumero()
        b = ingreseNumero()
        c = ingreseNumero()
        Console.WriteLine("El menor es: {0}", elMenor(a, b, c))
    End Sub
    Private Function ingreseNumero() As Single
        Dim numero As Single
        Console.WriteLine("Ingrese un numero")
        numero = Console.ReadLine()
        Return numero
    End Function
    Private Function elMenor(a As Single, b As Single, c As Single) As Single
        If a < b Then
            Return a
        ElseIf b < c Then
            Return b
        Else
            Return c
        End If
    End Function
End Module
