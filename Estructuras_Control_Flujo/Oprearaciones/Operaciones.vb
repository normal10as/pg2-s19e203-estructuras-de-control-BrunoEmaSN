Imports System

Module Operaciones
    Enum Operaciones
        suma
        resta
        multiplicacion
        division
    End Enum
    Sub Main()
        Console.WriteLine("//////2 interaciones//////")
        Console.Write("con enumeracion: suma {0} resta {1}", calcular(Operaciones.suma, 5, 8), calcular(Operaciones.resta, 5, 8))
        Console.WriteLine(" multiplicacion {0} division {1}", calcular(Operaciones.multiplicacion, 5, 8), calcular(Operaciones.division, 5, 8))
        Console.WriteLine("sin enumeracion: suma {0}", calcular2(5, 8))
        Console.WriteLine("//////3 interaciones//////")
        Console.Write("con enumeracion: suma {0} resta {1}", calcular(Operaciones.suma, 5, 8, 12), calcular(Operaciones.resta, 5, 8, 12))
        Console.WriteLine(" multiplicacion {0} division {1}", calcular(Operaciones.multiplicacion, 5, 8, 12), calcular(Operaciones.division, 5, 8, 12))
        Console.WriteLine("sin enumeracion: suma {0}", calcular2(5, 8, 12))
        Console.WriteLine("//////4 interaciones//////")
        Console.Write("con enumeracion: suma {0} resta {1}", calcular(Operaciones.suma, 5, 8, 12, 87), calcular(Operaciones.resta, 5, 8, 12, 87))
        Console.WriteLine(" multiplicacion {0} division {1}", calcular(Operaciones.multiplicacion, 5, 8, 12, 87), calcular(Operaciones.division, 5, 8, 12, 87))
        Console.WriteLine("sin enumeracion: suma {0}", calcular2(5, 8, 12, 87))
    End Sub
    Function calcular2(valor1 As Single, valor2 As Single) As Single
        Return suma(valor1, valor2)
    End Function
    Function calcular2(valor1 As Single, valor2 As Single, valor3 As Single) As Single
        Return suma(suma(valor1, valor2), valor3)
    End Function
    Function calcular2(valor1 As Single, valor2 As Single, valor3 As Single, valor4 As Single) As Single
        Return suma(suma(valor1, valor2), suma(valor3, valor4))
    End Function
    Function calcular(operacionaes As Operaciones, valor1 As Single, valor2 As Single) As Single
        Select Case operacionaes
            Case Operaciones.suma
                Return suma(valor1, valor2)
            Case Operaciones.resta
                Return resta(valor1, valor2)
            Case Operaciones.multiplicacion
                Return multiplicacion(valor1, valor2)
            Case Operaciones.division
                Return division(valor1, valor2)
            Case Else
                Return 0
        End Select
    End Function
    Function calcular(operacionaes As Operaciones, valor1 As Single, valor2 As Single, valor3 As Single) As Single
        Return calcular(operacionaes, (calcular(operacionaes, valor1, valor2)), valor3)
    End Function
    Function calcular(operacionaes As Operaciones, valor1 As Single, valor2 As Single, valor3 As Single, valor4 As Single) As Single
        Return calcular(operacionaes, calcular(operacionaes, valor1, valor2, valor3), valor4)
    End Function
    Function suma(valor1 As Single, valor2 As Single) As Single
        Return valor1 + valor2
    End Function
    Function resta(valor1 As Single, valor2 As Single) As Single
        Return valor1 - valor2
    End Function
    Function multiplicacion(valor1 As Single, valor2 As Single) As Single
        Return valor1 * valor2
    End Function
    Function division(valor1 As Single, valor2 As Single) As Single
        Return valor1 / valor2
    End Function
End Module
