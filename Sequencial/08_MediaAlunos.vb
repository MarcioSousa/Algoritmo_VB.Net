'/*
' * Author  : Marcio Pereira de Sousa
' * File    : Module1.vb
' * Project : Algoritmo_08
' * 
' * Faça um algoritmo para ler três notas de um aluno em uma disciplina e imprimir a sua média 
' * ponderada (as notas tem pesos respectivos de 1, 2 e 3). 
' */

Module MediaAlunos

    Sub Main()
        '// inicializa e declara as variáveis do programa
        Dim nota1, nota2, nota3, media As Double
        nota1 = 0
        nota2 = 0
        nota3 = 0
        media = 0

        '// exibe no console
        Console.Write("Entre com a nota 1 : ")
        nota1 = Double.Parse(Console.ReadLine())   '// lê a variável nota1

        Console.Write("Entre com a nota 2 : ")
        nota2 = Double.Parse(Console.ReadLine())

        Console.Write("Entre com a nota 3 : ")
        nota3 = Double.Parse(Console.ReadLine())

        media = (nota1 + nota2 + nota3) / 3

        '// exibe a saida ou resultado do programa
        Console.Write("A média ponderada é : " & media)

        Console.ReadKey()   '// espera entrada do teclado para finalizar o programa
    End Sub

End Module