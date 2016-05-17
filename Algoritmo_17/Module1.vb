'/*
' * Author  : Marcio Pereira de Sousa
' * File    : Module1.vb
' * Project : Algoritmo_17
' * 
' * Faça um algoritmo que calcule e mostre a área de um losango. Sabe-se que: A = 
' * (diagonal_maior * diagonal_menor)/2;  
' */

Module Module1

    Sub Main()
        '// inicializa e declara variáveis
        Dim area As Double = 0
        Dim diagonalMaior As Double = 0
        Dim diagonalMenor As Double = 0

        '// exibe no console
        Console.Write("Entre com a diagonal Maior do losango : ")
        diagonalMaior = Double.Parse(Console.ReadLine())   '// lê diagonal maior 

        '// exibe no console
        Console.Write("Entre com a diagonal Menor do losango : ")
        diagonalMenor = Double.Parse(Console.ReadLine())   '// lê diagonal menor

        '// processamento
        area = (diagonalMaior * diagonalMenor) / 2

        '// saida ou solução do programa
        Console.Write("Área do losango : " & area)

        '// espera entrada do teclado para encerrar o programa
        Console.ReadKey()
    End Sub

End Module