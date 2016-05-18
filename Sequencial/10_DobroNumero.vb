'/*
' * Author  : Marcio Sousa
' * File    : DobroNumero.vb
' * Project : Sequencial
' * 
' * Faça um algoritmo que leia um número e imprima seu dobro. 
' */

Module DobroNumero

    Sub Main()
        '// inicializa e declara variáveis
        Dim numero As Integer = 0
        Dim dobro As Integer = 0

        '// exibe no console
        Console.Write("Entre com um numero : ")
        numero = Integer.Parse(Console.ReadLine())   '// lê o numero

        '// processamento 
        dobro = numero * 2

        '// saida ou solução do programa 
        Console.Write("O dobro do numero " & numero & " é : " & dobro)

        Console.ReadKey()   '// espera entrada de teclado para encerrar o programa 
    End Sub

End Module

