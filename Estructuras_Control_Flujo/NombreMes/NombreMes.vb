Imports System

Module NombreMes
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
        Dim valor As Meses
        Console.Write("Ingrese un mes(MM):")
        valor = Console.ReadLine()
        Select Case valor
            Case Meses.enero
                Console.WriteLine("Enero")
            Case Meses.febrero
                Console.WriteLine("Febrero")
            Case Meses.marzo
                Console.WriteLine("Marzo")
            Case Meses.abril
                Console.WriteLine("Abril")
            Case Meses.mayo
                Console.WriteLine("Mayo")
            Case Meses.junio
                Console.WriteLine("Junio")
            Case Meses.julio
                Console.WriteLine("Julio")
            Case Meses.agosto
                Console.WriteLine("Agosto")
            Case Meses.septiembre
                Console.WriteLine("Septiembre")
            Case Meses.octubre
                Console.WriteLine("Octubre")
            Case Meses.noviembre
                Console.WriteLine("Noviembre")
            Case Meses.diciembre
                Console.WriteLine("Diciembre")
            Case Else
                Console.WriteLine("Ese mes es de otro planeta")
        End Select
    End Sub
End Module
