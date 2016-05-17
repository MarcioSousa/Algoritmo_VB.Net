'/*
' * Author  : Marcio Pereira de Sousa
' * File    : Module1.vb
' * Project : Algoritmo_31
' * 
' * Faça um algoritmo que receba o salário-base de um funcionário, calcule e mostre seu salário a receber, Sabendo
' * se que esse funcionário tem gratificação de R$ 50,00 e paga imposto de 10% sobre o salário-base.
' */

Module Module1

    Sub Main()
        '// declaro e inicializa variáveis
        Dim salario As Double = 0
        Dim imposto As Double = 0
        Dim novoSalario As Double = 0

        '//exibe no console
        Console.Write("Digite o salário-base do funcionário : ")
        salario = Double.Parse(Console.ReadLine())   '// lê salario base

        '// processamento
        imposto = salario * 0.1
        novoSalario = (salario - imposto) + 50

        '// saída e solução
        Console.Write("O salario que o funcionario tem a receber é : R$ " & novoSalario)

        '// espera entrada de teclado para encerrar o programa
        Console.ReadKey()
    End Sub

End Module
