'/*
' * Author  : Marcio Sousa
' * File    : Program.cs
' * Project : Algoritmo_36
' * 
' * Faça um algoritmo que receba um valor que foi depositado e exiba o
' * valor com rendimento após um mês. Considere fixo o juro da
' * poupança em 0,70% a. m.
' */
Module RendimentoDepodito

    Sub main()
        Const juros As Double = 0.7
        Dim deposito As Double = 0
        Dim rendimento As Double = 0
        Dim total As Double = 0

        Console.Write("Digite o valor depositado: ")
        deposito = Double.Parse(Console.ReadLine)

        '//Processamento
        rendimento = juros * deposito
        total = deposito + rendimento

        Console.Write("O rendimento do depósito após um mês é de um total de: " & total)
        Console.ReadKey()
    End Sub

End Module