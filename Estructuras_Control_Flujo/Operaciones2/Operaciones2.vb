Imports System

Module Operaciones2
    Enum Operaciones
        suma
        resta
        multiplicacion
        division
    End Enum
    Sub Main()
        resultado(5, 8)
        resultado(5, 8, 12)
        resultado(5, 8, 12, 87)
    End Sub
    Sub resultado(valor1, valor2)
        Console.WriteLine("//////2 interaciones//////")
        Console.Write("con enumeracion: suma {0} resta {1}", calcular(Operaciones.suma, valor1, valor2), calcular(Operaciones.resta, valor1, valor2))
        Console.WriteLine(" multiplicacion {0} division {1}", calcular(Operaciones.multiplicacion, valor1, valor2), calcular(Operaciones.division, valor1, valor2))
        Console.WriteLine("sin enumeracion: suma {0}", calcular2(valor1, valor2))
    End Sub
    Sub resultado(valor1, valor2, valor3)
        Console.WriteLine("//////3 interaciones//////")
        Console.Write("con enumeracion: suma {0}", calcular(Operaciones.suma, valor1, valor2, valor3))
        Console.Write("resta {0}", calcular(Operaciones.resta, valor1, valor2, valor3))
        Console.WriteLine(" multiplicacion {0}", calcular(Operaciones.multiplicacion, valor1, valor2, valor3))
        Console.WriteLine("division {0}", calcular(Operaciones.division, valor1, valor2, valor3))
        Console.WriteLine("sin enumeracion: suma {0}", calcular2(valor1, valor2, valor3))
    End Sub
    Sub resultado(valor1, valor2, valor3, valor4)
        Console.WriteLine("//////4 interaciones//////")
        Console.Write("con enumeracion: suma {0} ", calcular(Operaciones.suma, 5, 8, 12, 87))
        Console.Write("resta {1}", calcular(Operaciones.resta, 5, 8, 12, 87))
        Console.Write(" multiplicacion {0} ", calcular(Operaciones.multiplicacion, 5, 8, 12, 87))
        Console.WriteLine("division {1}", calcular(Operaciones.division, 5, 8, 12, 87))
        Console.WriteLine("sin enumeracion: suma {0}", calcular2(5, 8, 12, 87))
    End Sub
    Function calcular2(valor1, valor2) As Int16
        Return suma(valor1, valor2)
    End Function
    Function calcular2(valor1, valor2, valor3) As Int16
        Return suma(suma(valor1, valor2), valor3)
    End Function
    Function calcular2(valor1, valor2, valor3, valor4) As Int16
        Return suma(suma(valor1, valor2), suma(valor3, valor4))
    End Function
    Function calcular(operacionaes, valor1, valor2) As Double
        Select Case operacionaes
            Case operacionaes.suma
                Return suma(valor1, valor2)
            Case operacionaes.resta
                Return resta(valor1, valor2)
            Case operacionaes.multiplicacion
                Return multiplicacion(valor1, valor2)
            Case operacionaes.division
                Return division(valor1, valor2)
        End Select
    End Function
    Function calcular(operacionaes, valor1, valor2, valor3) As Double
        Select Case operacionaes
            Case operacionaes.suma
                Return suma(suma(valor1, valor2), valor3)
            Case operacionaes.resta
                Return resta(resta(valor1, valor2), valor3)
            Case operacionaes.multiplicacion
                Return multiplicacion(multiplicacion(valor1, valor2), valor3)
            Case operacionaes.division
                Return division(division(valor1, valor2), valor3)
        End Select
    End Function
    Function calcular(operacionaes, valor1, valor2, valor3, valor4) As Double
        Select Case operacionaes
            Case operacionaes.suma
                Return suma(suma(valor1, valor2), suma(valor3, valor4))
            Case operacionaes.resta
                Return resta(resta(valor1, valor2), resta(valor3, valor4))
            Case operacionaes.multiplicacion
                Return multiplicacion(multiplicacion(valor1, valor2), multiplicacion(valor3, valor4))
            Case operacionaes.division
                Return division(division(valor1, valor2), division(valor3, valor4))
        End Select
    End Function
    Function suma(valor1 As Int32, valor2 As Int32) As Int32
        Return valor1 + valor2
    End Function
    Function resta(valor1 As Int32, valor2 As Int32) As Int32
        Return valor1 - valor2
    End Function
    Function multiplicacion(valor1 As Int32, valor2 As Int32) As Int32
        Return valor1 * valor2
    End Function
    Function division(valor1 As Int32, valor2 As Int32) As Double
        Return valor1 / valor2
    End Function
End Module
