'/*
' * Author  : Marcio Pereira de Sousa
' * File    : Module1.vb
' * Project : Algoritmo_23
' * 
' * Faça um algoritmo para converter euro em real;
' */

Module EuroReal

    Sub Main()
        '// inicializa e declara as variáveis 
        Dim reais As Double = 0
        Dim taxa As Double = 0
        Dim euro As Double = 0

        '//exibe no console
        Console.Write("Entre com o valor em euro : ")
        euro = Double.Parse(Console.ReadLine())   '// lê o valor do euro

        '//exibe no console
        Console.Write("Entre com a taxa do euro : ")
        taxa = Double.Parse(Console.ReadLine())   '// lê o valor da taxa  

        '// processamento do valor em reais
        reais = taxa * euro

        '// saida ou solução
        Console.Write("Valor em reais : R$" & reais)

        '// espera entrada de teclado para encerrar o programa
        Console.ReadKey()
    End Sub

End Module
