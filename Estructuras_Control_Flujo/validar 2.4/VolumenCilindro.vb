Imports System.Math

Module VolumenCilindro
    Sub Main()
        Dim r As Double
        Dim h As Double
        Console.WriteLine("Ingrese radio")
        r = ingrese_un_numero_positivo()
        Console.WriteLine("Ingrese altura")
        h = ingrese_un_numero_positivo()
        Console.WriteLine("Volumen del Cilindro: " & volumen_cilindro(r, h))

    End Sub
    Function ingrese_un_numero_positivo() As Single
        Dim numero1 As Single
        Dim bandera As Boolean = False
        Do
            numero1 = Console.ReadLine()
            If numero1 <= 0 Then
                Console.WriteLine("Preste Atencion Ingrese otro valor")
                Console.WriteLine("Que sea positivo, Gracias")
            Else
                bandera = True
            End If
        Loop Until (bandera = True)
        Return numero1
    End Function
    Private Function volumen_cilindro(r, h) As Double
        Return (PI * r ^ 2 * h)
    End Function
End Module