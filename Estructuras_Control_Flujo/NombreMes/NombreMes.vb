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
        nobiembre = 11
        diciembre = 12
    End Enum
    Sub Main()
        Dim valor As Meses
        Console.WriteLine("Ingrese un mes(MM)")
        valor = Console.ReadLine()
        Select Case valor
            Case 1 To 12
                Console.WriteLine(valor.ToString)
            Case Else
                Console.WriteLine("Ese mes es de otro planeta")
        End Select
    End Sub
End Module
