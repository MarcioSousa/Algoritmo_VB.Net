'/*
' * Author  : Marcio Sousa
' * File    : DiasVida.vb
' * Project : Sequencial
' * 
' *  Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida 
' *  ela possui. Considere sempre anos completos, e que um ano possui 365 dias. Ex: uma pessoa 
' *  com 19 anos possui 6935 dias de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 
' *  Dias
' */

Module DiasVida

    Sub Main()
        '// inicializando e declarando as variáveis
        Dim nome As String = ""
        Dim idade As Integer = 0
        Const ano As Decimal = 365.25
        Dim resultado As Integer = 0

        Console.Write("Entre com seu nome : ")
        nome = Console.ReadLine()

        Console.Write("Entre com sua idade : ")
        idade = Integer.Parse(Console.ReadLine())

        '// processamento da conversão da idade em anos para idade em dias
        resultado = idade * ano

        Console.Write(nome & " , Você ja viveu " & resultado & " dias")

        Console.ReadKey()  '// espera entrada de teclado para encerrar o programa 
    End Sub

End Module