'/*
' * Author  : Marcio Sousa
' * File    : QuadradoNumero.vb
' * Project : Sequencial
' * 
' * Faça um algoritmo que leia um número e imprima seu quadrado. 
' */

Module QuadradoNumero

    Sub Main()
        '// inicializa e declara variáveis 
        Dim numero As Double = 0
        Dim quadrado As Double = 0

        '// exibe no console  
        Console.Write("Entre com um número : ")
        numero = Double.Parse(Console.ReadLine())

        '// processamento
        quadrado = numero * numero

        '// saída ou solucção do programa
        Console.Write("O quadrado do numero " & numero & " é : " & quadrado)

        '// espera uma entrada do teclado para fechar o programa
        Console.ReadKey()
    End Sub

End Module