Imports System

Module Venta
    Sub Main()
        Dim precioUnitario, DE As Double
        Dim cantidad, subTotal As Int16
        Console.WriteLine("Ingrese Precio Unitario")
        precioUnitario = Console.ReadLine()
        Console.WriteLine("Ingrese cantidad")
        cantidad = Console.ReadLine()
        subTotal = cantidad * precioUnitario
        Console.WriteLine("Sub-total: {0}", subTotal)
        DE = Desc(cantidad, DE)
        Console.Write("Descuento aplicado {0} %: ", DE)
        DE = (subTotal * DE) / 100
        Console.WriteLine(DE)
        Console.WriteLine("Total: {0}", subTotal - DE)
    End Sub
    Private Function Desc(cantidad, DE) As Int16
        DE = 0
        If (cantidad >= 10 And cantidad <= 50) Then
            DE = 5
        ElseIf (cantidad >= 51 And cantidad <= 250) Then
            DE = 10
        ElseIf (cantidad >= 251) Then
            DE = 20
        End If
        Return DE
    End Function
End Module
