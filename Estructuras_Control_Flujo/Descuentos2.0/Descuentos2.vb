Imports System

Module Descuentos2
    Sub Main()
        Dim precioUnitario, DE, subTotal1, descuentos, total As Single
        Dim cantidad As Int16
        Do
            Console.WriteLine("Ingrese Precio Unitario")
            precioUnitario = Console.ReadLine()
            Console.WriteLine("Ingrese cantidad")
            cantidad = Console.ReadLine()
            If cantidad <> 0 Then
                subTotal1 = cantidad * precioUnitario
                Console.WriteLine("Sub-total: {0}", subTotal1)
                DE = Desc(cantidad)
                Console.Write("Descuento aplicado {0} %: ", DE)
                DE = (subTotal1 * DE) / 100
                Console.WriteLine(DE)
                Console.WriteLine("Total: {0}", subTotal1 - DE)
                descuentos += DE
                total += subTotal1 - DE
            End If
        Loop Until cantidad = 0
        Console.WriteLine("Total descontado: {0}", descuentos)
        Console.WriteLine("Total a cobrar: {0}", total)
    End Sub
    Private Function Desc(cantidad As UInt16) As Byte
        If (cantidad >= 10 And cantidad <= 50) Then
            Return 5
        ElseIf (cantidad >= 51 And cantidad <= 250) Then
            Return 10
        ElseIf (cantidad >= 251) Then
            Return 20
        Else
            Return 0
        End If
    End Function
End Module
