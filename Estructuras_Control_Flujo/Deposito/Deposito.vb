Imports System

Module Deposito
    Sub Main()
        Const interesAnual As Int16 = 36
        Dim capital, meses, interesMensual, saldo, totalInteres As Int16
        mostrarNumeros(capital, interesMensual, saldo, interesAnual, meses, totalInteres)
    End Sub
    Private Sub mostrarNumeros(capital, interesMensual, saldo, interesAnual, meses, totalInteres)
        Console.Write("Ingrese capital: ")
        capital = Console.ReadLine()
        Console.Write("Total de meses: ")
        meses = Console.ReadLine()
        Console.WriteLine("Intres Anual: {0} %", interesAnual)
        Console.WriteLine("Mes-Capital-Interes-Saldo")
        For i As Int16 = 1 To meses
            interesMensual = (((capital * interesAnual) / 100) / 12)
            saldo = capital + interesMensual
            Console.WriteLine("{0} - {1} - {2} - {3}", i, capital, interesMensual, saldo)
            capital = saldo
            totalInteres += interesMensual
        Next
        Console.WriteLine("Total Interes Ganado: {0}", totalInteres)
    End Sub
End Module
