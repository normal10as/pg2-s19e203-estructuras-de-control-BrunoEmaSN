Imports System.Math

Module Hipotenusa
    Sub Main()
        Dim c1, c2 As Double
        c1 = ingresar_validar()
        c2 = ingresar_validar()
        Console.WriteLine("Hiputenusa = " & piteagoras(c1, c2))
    End Sub
    Function ingresar_validar() As Double
        Dim numero1 As Single
        Dim numero2, bandera As Int16
        bandera = 0
        Do
            Console.Write("Ingrese un valor entero positivo: ")
            numero1 = Console.ReadLine()
            numero2 = numero1
            If numero1 = numero2 And numero1 > 0 Then
                bandera = 1
            Else
                Console.WriteLine("Preste Atencion Ingrese otro valor")
                Console.WriteLine("Que sea entero positivo, Gracias")
            End If
        Loop Until (bandera = 1)
        Return numero1
    End Function
    Function piteagoras(c1, c2) As Double
        Return Sqrt(c1 ^ 2 + c2 ^ 2)
    End Function
End Module