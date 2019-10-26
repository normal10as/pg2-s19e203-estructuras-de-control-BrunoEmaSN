Imports System

Module Tercero
    Enum posiciones
        primer
        segundo
        tercero
        cuarto
        quinto
    End Enum
    Sub Main()
        Dim a, b, c, d, e As Single
        Dim i As posiciones = 1
        a = valor()
        b = valor()
        c = valor()
        d = valor()
        e = valor()
        i = elMayor(a, b, c, d, e)
        Console.WriteLine("El {0} numero es el mayor", i.ToString)
    End Sub
    Private Function valor() As Single
        Dim numero As Single
        Console.WriteLine("Ingrese un numero")
        numero = Console.ReadLine()
        Return numero
    End Function
    Private Function elMayor(a As Single, b As Single, c As Single, d As Single, e As Single) As posiciones
        If a > b And a > c And a > d And a > e Then
            Return posiciones.primer
        ElseIf b > c And b > d And b > e Then
            Return posiciones.segundo
        ElseIf c > d And c > e Then
            Return posiciones.tercero
        ElseIf d > e Then
            Return posiciones.cuarto
        Else
            Return posiciones.quinto
        End If
    End Function
End Module
