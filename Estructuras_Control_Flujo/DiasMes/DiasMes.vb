Imports System

Module DiasMes
    Sub Main()
        Dim aaaa, mm As Int16
        Console.Write("Ingrese un Año(AAAA): ")
        aaaa = Console.ReadLine()
        Console.Write("Ingrese un Mes(MM): ")
        mm = Console.ReadLine()
        Select Case mm
            Case 1, 3 To 7
                If (mm Mod 2 = 0) Then
                    Console.WriteLine("El mes tiene 30 dias")
                Else
                    Console.WriteLine("El mes tiene 31 dias")
                End If
            Case 8 To 12
                If (mm Mod 2 = 0) Then
                    Console.WriteLine("El mes tiene 31 dias")
                Else
                    Console.WriteLine("El mes tiene 30 dias")
                End If
            Case 2
                If (aaaa Mod 4 = 0 And aaaa Mod 100 <> 0 Or aaaa Mod 400 = 0) Then
                    Console.WriteLine("El mes tiene 29 dias")
                Else
                    Console.WriteLine("El mes tiene 28 dias")
                End If
        End Select
    End Sub
End Module
