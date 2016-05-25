'/*
' * Author  : Marcio Sousa
' * File    : PesparaMetros.vb
' * Project : Sequencial
' * 
' * Algoritmo que converta Pés em metros. 
' */
Module PesparaMetros
    Sub main()
        Const pes As Double = 0.3048
        Dim metros As Double = 0
        Dim converter As Double = 0

        Console.Write("Entre com o valor em metros : ")
        metros = Double.Parse(Console.ReadLine())

        converter = metros * pes

        Console.Write(metros + " metros convertidos em pés = " & converter & " pés")

        Console.ReadKey()
    End Sub

End Module

