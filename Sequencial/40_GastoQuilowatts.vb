'/*
' * Author  : Marcio Sousa
' * File    : GastoQuilowatts.vb
' * Project : Sequencial
' * 
' * Antes de o racionamento de energia ser decretado, quase ninguém falava em quilowatts; mas, agora, todos incorporaram essa palavra em seu vocabulário. Sabendo-se que 100 quilowatts de energia custa um sétimo do salário mínimo, fazer um algoritmo que receba o valor do salário mínimo e a quantidade de quilowatts gasta por uma residência e calcule. Imprima 
' * o valor em reais de cada quilowatt 
' * o valor em reais a ser pago 
' * o novo valor a ser pago por essa residência com um desconto de 10%. 
' */
Module GastoQuilowatts

    Sub main()
        Dim sm As Double = 0
        Dim qtdade As Double = 0
        Dim preco As Double = 0
        Dim vp As Double = 0
        Dim vd As Double = 0

        Console.Write("Entre com o salário mínimo: ")
        sm = Double.Parse(Console.ReadLine)

        Console.Write("Entre com a quantidade em quilowatt : ")
        qtdade = Double.Parse(Console.ReadLine)

        '// processamento
        '// divide por 7 para achar o preço de 100 kw e por 100 para achar de 1kw
        preco = sm / 700
        vp = preco * qtdade
        vd = vp * 0.9

        Console.Write("Preço do quilowatt: " & preco & vbCrLf)
        Console.Write("Valor a ser pago  : " & vp & vbCrLf)

        Console.ReadKey()
    End Sub

End Module