'/*
' * Author  : Marcio Sousa
' * File    : CDUparaUDC.vb
' * Project : Sequencial
' * 
' * Entrar com um número no formato CDU e imprimir invertido: UDC. (Exemplo: 123, sairá 321.) 
' * O número deverá ser armazenado em outra variável antes de ser impresso. 
' */
Module CDUparaUDC

    Sub main()
        Dim num As Integer = 0
        Dim c As Integer = 0
        Dim d As Integer = 0
        Dim u As Integer = 0
        Dim num1 As Integer = 0

        Console.Write("Entre com um número: ")
        num = Integer.Parse(Console.ReadLine)

        '//Processamento
        c = (num Mod 1000) \ 100
        d = (num Mod 100) \ 10
        u = (num Mod 10) \ 1
        num1 = u * 100 + d * 10 & c

        Console.Write("Número    :" & num & vbCrLf)
        Console.Write("Invertido :" & num1)

        Console.ReadKey()
    End Sub

End Module