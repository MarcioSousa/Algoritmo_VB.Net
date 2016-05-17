'/*
' * Author  : Marcio Pereira de Sousa
' * File    : Module1.vb
' * Project : Algoritmo_22
' * 
' * Faça um algoritmo para converter dólar em reais
' */

Module Module1

    Sub Main()
        '// inicializar e declarar variáveis 
        Dim reais As Double = 0
        Dim taxa As Double = 3.74D
        Dim dolar As Double = 0

        '// exibi no console
        Console.Write("Entre com o valor em dólar : ")
        dolar = Double.Parse(Console.ReadLine()) '// lê o dolar

        '// processamento do valor em reais
        reais = taxa * dolar

        '// saída ou solução
        Console.Write("Valor em Reais : $R " & reais)

        '// espera entrada do teclado para encerrar programa
        Console.ReadKey()
    End Sub

End Module
