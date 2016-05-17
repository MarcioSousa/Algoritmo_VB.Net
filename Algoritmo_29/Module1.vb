'/*
' * Author  : Marcio Pereira de Sousa
' * File    : Module1.vb
' * Project : Algoritmo_29
' * 
' * Fazer um algoritmo para calcular o custo estimado de gasto com combustível em uma viagem de carro.
' */

Module Module1

    Sub Main()
        '// incializa e declara variáveis
        Dim kmLitro As Double = 0
        Dim distancia As Double = 0
        Dim precoLitro As Double = 0
        Dim custo As Double = 0

        '// exibe no console
        Console.Write("Quantos quilomentos por litros o seu carro faz ? ")
        kmLitro = Double.Parse(Console.ReadLine())  '// lê kilomentros por litros

        '// exibe no console
        Console.Write("Qual a distância da viagem em Km ? ")
        distancia = Double.Parse(Console.ReadLine())  '// lê a distância

        Console.Write("Qual o preço do litro do combustivel em R$ ? ")
        precoLitro = Double.Parse(Console.ReadLine())

        '// processamento
        custo = distancia / kmLitro * precoLitro

        '//saída ou solução
        Console.Write("O custo estimado da viagem sera R$ " & custo)

        ''// espera entrada do teclado para encerrar o programa
        Console.ReadKey()
    End Sub

End Module
