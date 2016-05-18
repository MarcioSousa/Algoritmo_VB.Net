'/*
' * Author  : Marcio Pereira de Sousa
' * File    : Module1.vb
' * Project : Algoritmo_34
' * 
' * Faça um algoritmo que leia um valor inteiro e apresente os resultados do
' * quadrado e do cubo do valor lido.  
' */

Module QuadradoCubo

    Sub Main()
        '// inicializa e declara as variáveis
        Dim valor As Integer = 0
        Dim quadrado As Integer = 0
        Dim cubo As Integer = 0

        Console.Write("Entre com um valor inteiro : ")
        valor = Integer.Parse(Console.ReadLine())

        quadrado = valor * valor
        cubo = valor * valor * valor

        Console.Write("Quadrado : " & quadrado & vbCrLf)
        Console.Write("Cubo     : " & cubo & vbCrLf)
        '//Confirmação
        Console.ReadKey()
    End Sub

End Module
