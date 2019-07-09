Imports System

Module sumatoria_de_cuadrados
    Sub Main()
        Dim numero As Single
        numero = validar_numero()
        mostrar_en_pantalla(numero)
    End Sub
    Function validar_numero() As Integer
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
    Sub mostrar_en_pantalla(numero)
        Dim inicio, fin, numero_nuevo, numero_anterior As Int16
        fin = numero
        numero_anterior = 0
        numero_nuevo = 0
        For inicio = 1 To fin
            sumatoria_via_referencia(inicio, numero_nuevo, numero_anterior)
            Console.Write("{0} ", numero_nuevo)
        Next
        Console.WriteLine("")
    End Sub
    Sub sumatoria_via_referencia(inicio, ByRef numero_nuevo, ByRef numero_anterior)
        numero_nuevo = inicio ^ 2 + numero_anterior
        numero_anterior = numero_nuevo
    End Sub
End Module
