'/*
' * Author  : Marcio Sousa
' * File    : QuadradoSoma.vb
' * Project : Sequencial
' * 
' * Faça um algoritmo que leia dois valores inteiros (A e B) e apresente o resultado
' * do quadrado da soma dos valores lidos. 
' */

Module QuadradoSoma

    Sub Main()
        '// inicializa e declara variáveis
        Dim A As Integer = 0
        Dim B As Integer = 0
        Dim QA As Integer = 0
        Dim QB As Integer = 0
        Dim soma As Integer = 0

        '// exibe no console
        Console.Write("Entre com o valor de A : ")
        A = Integer.Parse(Console.ReadLine())   '// lê A

        '// exibe no console
        Console.Write("Entre com o valor de B : ")
        B = Integer.Parse(Console.ReadLine())   '// lê B

        QA = A * A
        QB = B * B

        '// processamento
        soma = QA + QB

        '// saída ou solução
        Console.Write("A soma do quadrado de A e B é : " + soma + vbCrLf)

        '// espera entrada de teclado para encerrar o programa
        Console.ReadKey()
    End Sub

End Module
