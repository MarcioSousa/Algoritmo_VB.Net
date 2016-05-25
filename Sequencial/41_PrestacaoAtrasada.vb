'/*
' * Author  : Marcio Sousa
' * File    : PrestacaoAtrasada.vb
' * Project : Sequencial
' * 
' * Efetuar o cálculo do valor de uma prestação em atraso, utilizando a fórmula:
' * prestação =valor+ (valor*(taxa/100)*tempo).  
' */
Module PrestacaoAtrasada

    Sub main()
        Dim prest As Double = 0
        Dim valor As Double = 0
        Dim taxa As Double = 0
        Dim tempo As Integer = 0

        Console.Write("Digite o valor da prestação : ")
        valor = Double.Parse(Console.ReadLine())

        Console.Write("Digite o a taxa : ")
        taxa = Double.Parse(Console.ReadLine())

        Console.Write("Digite o tempo(número de meses) : ")
        tempo = Integer.Parse(Console.ReadLine())

        '// processamento 
        prest = valor + (valor * (taxa / 100) * tempo)

        '// saída
        Console.Write("Valor da prestação em atraso é = " & prest)

        Console.ReadKey()
    End Sub

End Module

