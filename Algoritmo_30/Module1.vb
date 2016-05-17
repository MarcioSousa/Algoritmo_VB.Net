'/*
' * Author  : Marcio Pereira de Sousa
' * File    : Module1.vb
' * Project : Algoritmo_30
' * 
' * Faça algoritmo que receba o salário de um funcionário e o percentual de aumento e calcule e mostre o valor do
' * aumento e o novo salário.
' */

Module Module1

    Sub Main()
        '// inicia e delcara variáveis
        Dim salario As Double = 0
        Dim aumento As Double = 0
        Dim novoSalario As Double = 0

        '// exibe no console
        Console.Write("Digite o valor do salario : ")
        salario = Double.Parse(Console.ReadLine())  '// lê salário

        '// exibe no console
        Console.Write("Digite o valor do aumento em porcentagem : ")
        aumento = Double.Parse(Console.ReadLine())  '// lê aumento em porcentagem

        '// processamento
        aumento = salario * (aumento / 100)
        novoSalario = aumento + salario

        '// saída
        Console.Write("O valor do aumento é : R$" & aumento & vbCrLf)

        Console.Write("O valor do novo salário : R$" & novoSalario & vbCrLf)

        '// espera entrada de teclado para encerrar o programa
        Console.ReadKey()
    End Sub

End Module
