Imports System

Module ConvercionMedidas
    Private Const centimetro As Byte = 100
    Private Const pulgadas As Single = 2.54
    Private Const pies As Byte = 12
    Private Const yardas As Byte = 3
    Sub Main()
        Dim opcion As Byte
        Dim cantidad As Int16
        Console.WriteLine("///////////////MENU DE CONVERCION DE MEDIDAS///////////////")
        Console.WriteLine("ingrese 1(metros) 2(centimetro) 3(pulgadas) 4(pie) 5(yarda)")
        Console.Write("Elija una Opcion: ")
        opcion = Console.ReadLine()
        Console.Write("Ingrese cantidad: ")
        cantidad = Console.ReadLine()
        ConvercionDeMedidas(opcion, cantidad)
    End Sub
    Private Sub ConvercionDeMedidas(opcion As Byte, cantidad As Int16)
        Dim auxiliar As Single = cantidad
        Select Case opcion
            Case 1
                Console.WriteLine("Metros: {0}", cantidad)
                auxiliar *= centimetro
                Console.WriteLine("Centimetros: {0}", auxiliar)
                auxiliar /= pulgadas
                Console.WriteLine("Pulgadas: {0}", auxiliar)
                auxiliar /= pies
                Console.WriteLine("Pies: {0}", auxiliar)
                auxiliar /= yardas
                Console.WriteLine("Yardas: {0}", auxiliar)
            Case 2
                Console.WriteLine("Centimetros: {0}", cantidad)
                auxiliar /= centimetro
                Console.WriteLine("Metros: {0}", auxiliar)
                auxiliar /= pulgadas
                Console.WriteLine("Pulgadas: {0}", auxiliar)
                auxiliar /= pies
                Console.WriteLine("Pies: {0}", auxiliar)
                auxiliar /= yardas
                Console.WriteLine("Yardas: {0}", auxiliar)
            Case 3
                Console.WriteLine("Pulgadas: {0}", cantidad)
                auxiliar /= pies
                Console.WriteLine("Pies: {0}", auxiliar)
                auxiliar /= yardas
                Console.WriteLine("Yardas: {0}", auxiliar)
                auxiliar = cantidad * pulgadas
                Console.WriteLine("Centimetros: {0}", auxiliar)
                auxiliar /= centimetro
                Console.WriteLine("Metros: {0}", auxiliar)
            Case 4
                Console.WriteLine("Pies: {0}", cantidad)
                auxiliar /= yardas
                Console.WriteLine("Yardas: {0}", auxiliar)
                auxiliar = cantidad * pies
                Console.WriteLine("Pulgadas: {0}", cantidad * pies)
                auxiliar *= pulgadas
                Console.WriteLine("Centimetros: {0}", auxiliar)
                auxiliar /= centimetro
                Console.WriteLine("Metros: {0}", auxiliar)
            Case 5
                Console.WriteLine("Yardas: {0}", cantidad)
                auxiliar *= yardas
                Console.WriteLine("Pies: {0}", auxiliar)
                auxiliar *= pies
                Console.WriteLine("Pulgadas: {0}", auxiliar)
                auxiliar *= pulgadas
                Console.WriteLine("Centimetros: {0}", auxiliar)
                auxiliar /= centimetro
                Console.WriteLine("Metros: {0}", auxiliar)
        End Select
    End Sub
End Module
