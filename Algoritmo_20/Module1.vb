'/*
' * Author  : Marcio Pereira de Sousa
' * File    : Module1.vb
' * Project : Algoritmo_20
' * 
' * Faça um algoritmo para ler uma temperatura dada na escala Fahrenheit e exibir o equivalente em Celsius.
' * C = 5/9(F-32)
' */

Module Module1

    Sub Main()
        '// inicializa e declara as variáveis
        Dim f As Double = 0
        Dim c As Double = 0

        '// exibe no console
        Console.Write("Entre com a temperatura na escala Fahrenheit : ")
        f = Double.Parse(Console.ReadLine())  '// le a temperatura fahrenheit

        '// processamento
        c = 5 / 9 * (f - 32)

        '// saida ou solução
        Console.Write("A temperatura em Celsius é igual a : " & c)

        '// espera entrada do teclado para encerrar a aplicação
        Console.ReadKey()

    End Sub

End Module

