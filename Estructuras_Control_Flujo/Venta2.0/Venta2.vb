Imports System

Module Venta2
    Sub Main()
        Dim precioUnitario, descuento, subTotal As Double
        Dim cantidad As Int16

        Console.WriteLine("Ingrese Precio Unitario")
        precioUnitario = Console.ReadLine()

        Console.WriteLine("Ingrese Cantidad")
        cantidad = Console.ReadLine()

        subTotal = cantidad * precioUnitario
        descuento = desc(cantidad)

        Console.WriteLine("Sub-total: {0}", subTotal)
        Console.Write("Descuento aplicado {0} % : ", descuento)

        descuento = (subTotal * descuento) / 100

        Console.WriteLine(descuento)
        Console.WriteLine("Total: {0}", subTotal - descuento)
    End Sub
    Private Function desc(cantidad As Int16) As Double
        Select Case cantidad
            Case 10 To 50
                Return 5
            Case 51 To 250
                Return 10
            Case > 250
                Return 20
            Case Else
                Return 0
        End Select
    End Function
End Module
