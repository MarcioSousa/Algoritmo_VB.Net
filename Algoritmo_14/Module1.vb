'/*
' * Author  : Marcio Pereira de Sousa
' * File    : Module1.vb
' * Project : Algoritmo_14
' * 
' * Faça um algoritmo que calcule a area de um circulo lendo o raio dele. 
' */

Module Module1

    Sub Main()
        '// declara e inicializa variável e constante
        Const PI As Double = 3.14D
        Dim raio As Double = 0
        Dim area As Double = 0

        '// exibe no console
        Console.Write("Entre com o raio do circulo : ")
        raio = Double.Parse(Console.ReadLine())   '// lê raio 

        '// processamento
        area = PI * (raio * raio)

        '// saida ou solução do program
        Console.Write("Área do Círculo : " & area)

        '// espera entrada do teclado para encerrar o programa
        Console.ReadKey()
    End Sub

End Module


