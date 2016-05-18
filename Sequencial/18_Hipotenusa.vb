'/*
' * Author  : Marcio Sousa
' * File    : Hipotenusa.vb
' * Project : Sequencial
' * 
' * Faça um algoritmo que leia os catetos de um triangulo e exiba o valor da hipotenusa
' */
Module Hipotenusa

    Sub Main()
        '// incicializa e declara variáveis
        Dim a As Double = 0
        Dim b As Double = 0
        Dim hipotenusa As Double = 0

        '// exibe no console
        Console.Write("Entre com o valor do primeiro cateto : ")
        a = Double.Parse(Console.ReadLine())    '// lê o primeiro cateto

        '// exibe no console
        Console.Write("Entre com o valor do segundo cateto : ")
        b = Double.Parse(Console.ReadLine())    '// lê o segundo cateto    

        '// processamento utilizando a biblioteca Math para usar a raiz quadrada
        hipotenusa = Math.Sqrt((a * a) + (b * b))

        '// saída ou resultado do programa
        Console.Write("Hipotenusa : " & hipotenusa)

        '// espera entrada do teclado para fechar o programa
        Console.ReadKey()
    End Sub

End Module

