Imports System

Module MultiplosCinco
    Sub Main()
        Dim valor1, valor2 As Single
        Dim multiplo, contador, i As Int16
        valor1 = IngresarValores(valor1)
        valor2 = IngresarValores(valor2)
        Console.WriteLine("///////////////FOR/////////////////")
        Console.WriteLine("El primero tiene {0} multiplos de 5", usarFor(valor1, multiplo, contador))
        Console.WriteLine("El segundo tiene {0} multiplos de 5", usarFor(valor2, multiplo, contador))
        Console.WriteLine("//////////DO WHILE LOOP////////////")
        Console.WriteLine("El primero tiene {0} multiplos de 5", usarDoWhileLoop(valor1, multiplo, contador, i))
        Console.WriteLine("El segundo tiene {0} multiplos de 5", usarDoWhileLoop(valor2, multiplo, contador, i))
        Console.WriteLine("//////////DO UNTIL LOOP////////////")
        Console.WriteLine("El primero tiene {0} multiplos de 5", usarDoUntilLoop(valor1, multiplo, contador, i))
        Console.WriteLine("El segundo tiene {0} multiplos de 5", usarDoUntilLoop(valor2, multiplo, contador, i))
        Console.WriteLine("//////////DO LOOP WHILE////////////")
        Console.WriteLine("El primero tiene {0} multiplos de 5", usarDoLoopWhile(valor1, multiplo, contador, i))
        Console.WriteLine("El segundo tiene {0} multiplos de 5", usarDoLoopWhile(valor2, multiplo, contador, i))
        Console.WriteLine("//////////DO LOOP UNTIL////////////")
        Console.WriteLine("El primero tiene {0} multiplos de 5", usarDoLoopUntil(valor1, multiplo, contador, i))
        Console.WriteLine("El segundo tiene {0} multiplos de 5", usarDoLoopUntil(valor2, multiplo, contador, i))

    End Sub
    Private Function IngresarValores(valor) As Single
        Console.WriteLine("Ingrese un Numero")
        valor = Console.ReadLine()
        Return valor
    End Function
    Private Function usarFor(valor, multiplo, contador) As Single
        contador = 0
        For i As Int16 = 1 To valor
            multiplo = i
            If (multiplo Mod 5) = 0 Then
                contador += 1
            End If
        Next
        Return contador
    End Function
    Private Function usarDoWhileLoop(valor, multiplo, contador, i) As Single
        i = 0
        contador = 0
        Do While i <= valor
            i += 1
            multiplo = i
            If (multiplo Mod 5) = 0 Then
                contador += 1
            End If
        Loop
        Return contador
    End Function
    Private Function usarDoUntilLoop(valor, multiplo, contador, i) As Single
        i = 0
        contador = 0
        Do Until i > valor
            i += 1
            multiplo = i
            If (multiplo Mod 5) = 0 Then
                contador += 1
            End If
        Loop
        Return contador
    End Function
    Private Function usarDoLoopWhile(valor, multiplo, contador, i) As Single
        i = 0
        contador = 0
        Do
            i += 1
            multiplo = i
            If (multiplo Mod 5) = 0 Then
                contador += 1
            End If
        Loop While i < valor
        Return contador
    End Function
    Private Function usarDoLoopUntil(valor, multiplo, contador, i) As Single
        i = 0
        contador = 0
        Do
            i += 1
            multiplo = i
            If (multiplo Mod 5) = 0 Then
                contador += 1
            End If
        Loop Until i = valor
        Return contador
    End Function
End Module
