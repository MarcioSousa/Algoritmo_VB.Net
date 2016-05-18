'/*
' * Author  : Marcio Sousa
' * File    : RealEuro.vb
' * Project : Sequencial
' * 
' * Faça um algoritmo para converter real em euro;
' */

Module RealEuro

    Sub Main()
        Dim euros As Double = 0
        Dim taxa As Double = 0
        Dim real As Double = 0

        '// exibe no console
        Console.Write("Entre com a quantidade de Reais: ")
        real = Double.Parse(Console.ReadLine())   '// lê real

        '// exibe no console
        Console.Write("Entre com o valor da taxa do euro: ")
        taxa = Double.Parse(Console.ReadLine())  '// lê taxa

        '// processamento de conversão de reais em euro
        euros = real / taxa

        '// saida ou solução 
        Console.Write("Valor em euros : " & euros & " euros")

        '// espera entrada de teclado para encerrar o programa
        Console.ReadKey()
    End Sub

End Module
