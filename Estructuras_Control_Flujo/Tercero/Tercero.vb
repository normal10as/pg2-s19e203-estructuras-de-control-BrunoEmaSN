Imports System

Module Tercero
    Enum posiciones
        primer = 1
        segundo = 2
        tercero = 3
        cuarto = 4
        quinto = 5
    End Enum
    Sub Main()
        Dim a, mayor As Int16
        Dim i As posiciones = 1
        a = valor(a)
        mayor = a
        a = valor(a)
        elMayor(a, mayor, i)
        a = valor(a)
        elMayor(a, mayor, i)
        a = valor(a)
        elMayor(a, mayor, i)
        a = valor(a)
        elMayor(a, mayor, i)
        Console.WriteLine("El {0} numero es el mayor", i.ToString)
    End Sub
    Private Function valor(a) As Int16
        Console.WriteLine("Ingrese un numero")
        a = Console.ReadLine()
        Return a
    End Function
    Private Sub elMayor(a, ByRef mayor, ByRef i)
        If a > mayor Then
            mayor = a
            i += 1
        End If
    End Sub
End Module
