'/*
' * Author  : Marcio Pereira de Sousa
' * File    : Module1.vb
' * Project : Algoritmo_13
' * 
' * Faça um algoritmo que calcule a area de um triangulo lendo a base e a altura. 
' */

Module AreaTriangulo

    Sub Main()
        '// inicializa e declara as variáveis
        Dim baseTriangulo As Double = 0
        Dim altura As Double = 0
        Dim area As Double = 0

        '// exibe no console
        Console.Write("Entre com a base do triângulo : ")
        baseTriangulo = Double.Parse(Console.ReadLine())    '// lê a base do triângulo

        '// exibe no console
        Console.Write("Entre com a altura do triângulo : ")
        altura = Double.Parse(Console.ReadLine())           '// lê altura do triângulo 

        '// processamento
        area = (baseTriangulo * altura) / 2

        '// saída ou solução do program
        Console.Write("A Área do Triângulo é : " & area)

        '// espera entrada do teclado para encerrar o programa
        Console.ReadKey()

    End Sub

End Module


