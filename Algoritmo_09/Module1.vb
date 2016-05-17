'/*
' * Author  : Marcio Pereira de Sousa
' * File    : Module1.vb
' * Project : Algoritmo_09
' * 
' * Faça um algoritmo para ler dois numeros e fazer as operaçoes aritméticas básicas com eles. 
' */

Module Module1

    Sub Main()
        '// inicializa e declara variáveis
        Dim numero1, numero2, soma, subtracao, multiplicacao, divisao As Integer
        numero1 = 0
        numero2 = 0
        soma = 0
        subtracao = 0
        multiplicacao = 0
        divisao = 0

        '// exibe no console
        Console.Write("Digite o numero 1 : ")
        numero1 = Integer.Parse(Console.ReadLine())   '// lê numero1 

        '// exibe no console
        Console.Write("Digite o numero 2 : ")
        numero2 = Integer.Parse(Console.ReadLine())   '// lê numero2

        soma = numero1 + numero2            '// processamento da operação soma  
        subtracao = numero1 - numero2       '// processamento da operação subtração 
        multiplicacao = numero1 * numero2   '// processamento da operação multiplicação
        divisao = numero1 / numero2         '// processamento da operação divisão

        '// exibe a saida do programa ou a solução do problema 
        Console.Write("Soma : " & soma)
        Console.Write(" Subtração : " & subtracao)
        Console.Write(" Multiplicação : " & multiplicacao)
        Console.Write(" Divisão : " & divisao)

        Console.ReadKey()
    End Sub

End Module

