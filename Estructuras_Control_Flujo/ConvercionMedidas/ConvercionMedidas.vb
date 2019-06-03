Imports System

Module ConvercionMedidas
    Sub Main()
        Const centimetro As Int16 = 100
        Const pulgadas As Single = 2.54
        Const pies As Int16 = 12
        Const yardas As Int16 = 3
        Dim valor1, valor2 As Int16
        Console.WriteLine("///////////////MENU DE CONVERCION DE MEDIDAS///////////////")
        Console.WriteLine("ingrese 1(metros) 2(centimetro) 3(pulgadas) 4(pie) 5(yarda)")
        Console.Write("Elija una Opcion: ")
        valor1 = Console.ReadLine()
        Console.Write("Ingrese contidad: ")
        valor2 = Console.ReadLine()
        ConvercionDeMedidas(valor1, valor2, centimetro, pulgadas, pies, yardas)
    End Sub
    Private Sub ConvercionDeMedidas(valor1, valor2, centimetro, pulgadas, pies, yardas)
        Select Case valor1
            Case 1
                Console.WriteLine("Metros: {0}", valor2)
                Console.WriteLine("Centimetros: {0}", valor2 * centimetro)
                Console.WriteLine("Pulgadas: {0}", (valor2 * centimetro) / pulgadas)
                Console.WriteLine("Pies: {0}", ((valor2 * centimetro) / pulgadas) / pies)
                Console.WriteLine("Yardas: {0}", (((valor2 * centimetro) / pulgadas) / pies) / yardas)
            Case 2
                Console.WriteLine("Centimetros: {0}", valor2)
                Console.WriteLine("Metros: {0}", valor2 / centimetro)
                Console.WriteLine("Pulgadas: {0}", valor2 / pulgadas)
                Console.WriteLine("Pies: {0}", (valor2 / pulgadas) / pies)
                Console.WriteLine("Yardas: {0}", ((valor2 / pulgadas) / pies) / yardas)
            Case 3
                Console.WriteLine("Pulgadas: {0}", valor2)
                Console.WriteLine("Pies: {0}", valor2 / pies)
                Console.WriteLine("Yardas: {0}", (valor2 / pies) / yardas)
                Console.WriteLine("Centimetros: {0}", valor2 * pulgadas)
                Console.WriteLine("Metros: {0}", (valor2 * pulgadas) / centimetro)
            Case 4
                Console.WriteLine("Pies: {0}", valor2)
                Console.WriteLine("Yardas: {0}", valor2 / yardas)
                Console.WriteLine("Pulgadas: {0}", valor2 * pies)
                Console.WriteLine("Centimetros: {0}", (valor2 * pies) * pulgadas)
                Console.WriteLine("Metros: {0}", ((valor2 * pies) * pulgadas) / centimetro)
            Case 5
                Console.WriteLine("Yardas: {0}", valor2)
                Console.WriteLine("Pies: {0}", valor2 * yardas)
                Console.WriteLine("Pulgadas: {0}", (valor2 * yardas) * pies)
                Console.WriteLine("Centimetros: {0}", ((valor2 * yardas) * pies) * pulgadas)
                Console.WriteLine("Metros: {0}", (((valor2 * yardas) * pies) * pulgadas) / centimetro)
        End Select
    End Sub
End Module
