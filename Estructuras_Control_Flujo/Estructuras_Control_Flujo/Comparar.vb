Imports System

Module Comparar
    Sub Main()
        Dim a As Int16
        Dim b As Int16
        Console.WriteLine("Ingrese un numero")
        a = Console.ReadLine()
        Console.WriteLine("Ingrese otro numero")
        b = Console.ReadLine()

    End Sub
    Private Sub mayorMenorIgual(a, b)
        If a = b Then
            Console.WriteLine("Son iguales")
        ElseIf a > b Then
            Console.WriteLine("No son iguales, el mayor es {0} y el menor es {1}", a, b)
        Else
            Console.WriteLine("No son iguales, el mayor es {0} y el menor es {1}", b, a)
        End If
    End Sub
End Module
