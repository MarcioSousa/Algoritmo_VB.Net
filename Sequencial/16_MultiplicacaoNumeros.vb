'/*
' * Author  : Marcio Pereira de Sousa
' * File    : Module1.vb
' * Project : Algoritmo_16
' * 
' * Faça um algoritmo que receba três números, calcule e mostre a multiplicação desses números 
' */

Module MultiplicacaoNumeros

    Sub Main()
        '// inicializa e declara as variáveis
        Dim numero1 As Double = 0
        Dim numero2 As Double = 0
        Dim numero3 As Double = 0
        Dim produto As Double = 0

        '// exibe no console
        Console.Write("Digite o número 1 : ")
        numero1 = Double.Parse(Console.ReadLine())   '// lê número 1

        '// exibe no console
        Console.Write("Digite o número 2 : ")
        numero2 = Double.Parse(Console.ReadLine())   '// lê número 2

        '// exibe no console
        Console.Write("Digite o número 3 : ")
        numero3 = Double.Parse(Console.ReadLine())   '// lê número 3

        '// processamento 
        produto = numero1 * numero2 * numero3

        '// saida ou solução do programa
        Console.Write("A multiplicação dos três números é igual a : " & produto)

        Console.ReadKey()
    End Sub

End Module

