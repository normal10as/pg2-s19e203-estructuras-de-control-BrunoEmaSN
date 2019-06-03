Imports System

Module Fibonacci
    Sub Main()
        Dim valor1, valor2, f As Int16
        valor1 = 0
        valor2 = 1
        mostrarNumeros(valor1, valor2, f)
    End Sub
    Private Sub mostrarNumeros(valor1, valor2, f)
        Console.WriteLine("numeros fibonacci")
        For i As Int16 = 1 To 20
            f = valor1 + valor2
            Console.WriteLine("{0} - {1}", i, f)
            valor2 = valor1
            valor1 = f
        Next
    End Sub
End Module
