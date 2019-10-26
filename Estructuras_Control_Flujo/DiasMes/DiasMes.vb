Imports System

Module DiasMes
    Enum Meses
        enero = 1
        febrero = 2
        marzo = 3
        abril = 4
        mayo = 5
        junio = 6
        julio = 7
        agosto = 8
        septiembre = 9
        octubre = 10
        noviembre = 11
        diciembre = 12
    End Enum
    Sub Main()
        Dim aaaa As Int16
        Dim mm As Meses
        Console.Write("Ingrese un Mes(MM): ")
        mm = Console.ReadLine()
        Select Case mm
            Case Meses.enero
                Console.WriteLine("El mes tiene 31 dias")
            Case Meses.febrero
                Console.Write("Ingrese un Año(AAAA): ")
                aaaa = Console.ReadLine()
                If (aaaa Mod 4 = 0 And aaaa Mod 100 <> 0 Or aaaa Mod 400 = 0) Then
                    Console.WriteLine("El mes tiene 29 dias")
                Else
                    Console.WriteLine("El mes tiene 28 dias")
                End If
            Case Meses.marzo
                Console.WriteLine("El mes tiene 31 dias")
            Case Meses.abril
                Console.WriteLine("El mes tiene 30 dias")
            Case Meses.mayo
                Console.WriteLine("El mes tiene 31 dias")
            Case Meses.junio
                Console.WriteLine("El mes tiene 30 dias")
            Case Meses.julio
                Console.WriteLine("El mes tiene 31 dias")
            Case Meses.agosto
                Console.WriteLine("El mes tiene 31 dias")
            Case Meses.septiembre
                Console.WriteLine("El mes tiene 30 dias")
            Case Meses.octubre
                Console.WriteLine("El mes tiene 31 dias")
            Case Meses.noviembre
                Console.WriteLine("El mes tiene 30 dias")
            Case Meses.diciembre
                Console.WriteLine("El mes tiene 31 dias")
            Case Else
                Console.WriteLine("Error")
        End Select
    End Sub
End Module
