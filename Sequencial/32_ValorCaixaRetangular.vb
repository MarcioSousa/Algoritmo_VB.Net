'/*
' * Author  : Marcio Sousa
' * File    : ValorCaixaRetangular.vb
' * Project : Sequencial
' * 
' * Faça um algoritmo que leia os valores de COMPRIMENTO, LARGURA e
' * ALTURA e apresente o valor do volume de uma caixa retangular. Utilize para o
' * cálculo a fórmula VOLUME =  COMPRIMENTO * LARGURA * ALTURA
' */


Module ValorCaixaRetangular

    Sub Main()
        '// incializa e declara variáveis 

        Dim volume As Double = 0
        Dim comprimento As Double = 0
        Dim largura As Double = 0
        Dim altura As Double = 0

        '// exibe no console
        Console.Write("Entre com o comprimento : ")
        comprimento = Double.Parse(Console.ReadLine())  '// lê comprimento

        '// exibe no console
        Console.Write("Entre com a largura : ")
        largura = Double.Parse(Console.ReadLine())  '// lê largura

        '// exibe no console
        Console.Write("Entre com a altura : ")
        altura = Double.Parse(Console.ReadLine())  '// lê altura

        '// processamento
        volume = comprimento * largura * altura

        '// saída ou solução
        Console.Write("Volume da caixa retangular é : " & volume & " metros cubicos." & vbCrLf)

        '// espera entrada de teclado para encerrar o programa
        Console.ReadKey()
    End Sub

End Module
