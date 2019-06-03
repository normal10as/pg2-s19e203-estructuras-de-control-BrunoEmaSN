Imports System

Module Angulo
    Sub Main()
        Dim angulos As Int16
        Console.WriteLine("ingres un angulo")
        angulos = Console.ReadLine()
        grados(angulos)
    End Sub
    Private Sub grados(angulos)
        Select Case angulos
            Case 90
                Console.WriteLine("Angulo Recto")
            Case 1 To 89
                Console.WriteLine("Angulo Agudo")
            Case 91 To 179
                Console.WriteLine("Angulo Obtuso")
            Case 180
                Console.WriteLine("Angulo Llano")
            Case 181 To 359
                Console.WriteLine("Angulo Concavo")
            Case 0
                Console.WriteLine("Angulo Nulo")
            Case < 0, > 360
                Console.WriteLine("Error")
        End Select
    End Sub
End Module
