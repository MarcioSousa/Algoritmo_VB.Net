'/*
' * Author  : Marcio Pereira de Sousa
' * File    : Module1.vb
' * Project : Algoritmo_25
' * 
' * Faça um calculo de Juros Simples, digitando o valor inicial,
' * a quantidade de meses que será pago esse valor e a porcentagem de 
' * juros mensais. Ex: Um empréstimo no valor de 2.000,00, com juros 
' * mensais de 8% e a quantidade de 6 meses de pagamento, totalizando
' * o valor de 2.960,00 */

Module Module1

    Sub Main()
        Dim total As Double = 0
        Dim valor As Double = 0
        Dim qtdmeses As Integer = 0
        Dim juros As Double = 0

        Console.Write("Entre com o valor do emprestimo : ")
        valor = Double.Parse(Console.ReadLine())

        Console.Write("Entre com a quantidade de meses ou parcelas do emprestimo : ")
        qtdmeses = Integer.Parse(Console.ReadLine())

        Console.Write("Entre com a taxa de juros : ")
        juros = Double.Parse(Console.ReadLine())

        '// processamento do valor pago ao final da quantidade de meses do emprestimo
        total = valor + ((qtdmeses * (juros / 100)) * valor)

        '// saída ou solução 
        Console.Write("Valor pago ao final da quantidade de " & qtdmeses & " meses do emprestimo : " & total)

        '// espera entrada de teclado para encerrar o programa
        Console.ReadKey()
    End Sub

End Module
