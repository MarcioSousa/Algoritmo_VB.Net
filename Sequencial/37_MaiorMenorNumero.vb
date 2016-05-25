'/*
' * Author  : Antônio Paulo Neto
' * File    : Program.cs
' * Project : Algoritmo_36
' * 
' * Ler um número inteiro e imprimir seu sucessor e seu antecessor. 
' */
Module MaiorMenorNumero
    Sub main()
        Dim numero As Integer = 0
        Dim ant As Integer = 0
        Dim suc As Integer = 0

        Console.Write("Entre com um número: ")
        numero = Integer.Parse(Console.ReadLine)

        '//Processamento
        ant = numero - 1
        suc = numero + 1

        Console.Write("Antecessor = " & ant & " do número " & numero & " e o sucessor = " & suc)
        Console.ReadKey()
    End Sub


End Module