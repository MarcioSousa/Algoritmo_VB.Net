'/*
' * Author  : Marcio Sousa
' * File    : AreaQuadrado.vb
' * Project : Sequencial
' * 
' * Faça um algoritmo que calcule a area de um quadrado lendo o lado. 
' */

Module AreaQuadrado

    Sub Main()
        '// inicializa e declara as variáveis
        Dim lado As Double = 0
        Dim area As Double = 0

        '// exibe no console
        Console.Write("Entre com o valor do lado do quadrado : ")
        lado = Double.Parse(Console.ReadLine())    '// lê o lado

        '// processamento
        area = lado * lado

        '// saida ou resultado do programa
        Console.Write("Área do quadrado é : " & area & " metros quadrados")

        '// espera entrada do teclado para encerrar o programa
        Console.ReadKey()
    End Sub

End Module