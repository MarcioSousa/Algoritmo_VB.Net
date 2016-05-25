'/*
' * Author  : Marcio Sousa
' * File    : KmhparaMph.vb
' * Project : Sequencial
' * 
' * Algoritmo que converta km/h para mph. 
' */
Module KmhparaMph
    Sub main()
        Const mph As Double = 1.6093
        Dim kmh As Double = 0
        Dim converter As Double = 0

        Console.Write("Entre a velocidade em km/h : ")
        kmh = Double.Parse(Console.ReadLine())

        converter = kmh * mph

        Console.Write(kmh & " Km/h convertido em Mhp = " & converter & " mph")

        Console.ReadKey()
    End Sub

End Module