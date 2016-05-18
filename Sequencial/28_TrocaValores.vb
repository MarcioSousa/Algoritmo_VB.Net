'/*
' * Author  : Marcio Pereira de Sousa
' * File    : Module1.vb
' * Project : Algoritmo_28
' * 
' * Faça um algoritmo que leia dois valores para as variáveis A e B e efetue a troca
' * dos valores de forma que a variável A passe a possuir o valor da variável B e a
' * variável B passe a possuir o valor da variável A. Apresente os valores trocados.
' */

Module TrocaValores

    Sub Main()
        '// inicializa e declara variáveis 
        Dim A As Integer = 0
        Dim B As Integer = 0
        Dim Aux As Integer = 0

        '// exibe no console
        Console.Write("Entre com o valor de A : ")
        A = Integer.Parse(Console.ReadLine())   '// lê A

        '// exibe no console
        Console.Write("Entre com o valor de B : ")
        B = Integer.Parse(Console.ReadLine())  '// lê B  

        '// saída
        Console.Write("Valores de A e B antes da troca sao respectivamente " & A & " e " & B & vbCrLf)

        '// troca utilzando variável auxiliar
        Aux = A
        A = B
        B = Aux

        '// saída
        Console.Write("Valores de A e B após a troca sao respectivamente " & A & " e " & B & vbCrLf)

        '// espera entrada do teclado para encerrar o programa
        Console.ReadKey()
    End Sub

End Module
