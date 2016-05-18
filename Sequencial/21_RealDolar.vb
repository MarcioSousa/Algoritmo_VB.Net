'/*
' * Author  : Marcio Pereira de Sousa
' * File    : Module1.vb
' * Project : Algoritmo_21
' * 
' * Faça um algoritmo para ler um preço de um produto em reais  e informar o preço do produto em dólares.
' */

Module RealDolar

    Sub Main()
        '// inicializa e declara variáveis 
        Dim precoReal As Double = 0
        Dim taxa As Double = 3.74D
        Dim conversao As Double = 0

        '// exibe no console
        Console.Write("Entre com preço em Real : ")
        precoReal = Double.Parse(Console.ReadLine())   '// lê o preço em real 

        '// processamento para conversão em dólar
        conversao = precoReal / taxa

        '// saída ou solução 
        Console.Write("Preço convertido em dolar : $" & conversao & " dolares")

        '// espera entrada do teclado para encerrar o programa
        Console.ReadKey()
    End Sub

End Module
