'/*
' * Author  : Marcio Sousa
' * File    : CentenaDezenaUnidade
' * Project : Sequencial
' * 
' * Ler um número inteiro (assuma até três dígitos) e imprimir a saída da seguinte forma:
' * CENTENA = x
' * DEZENA  = x
' * UNIDADE = x
' */

Module CentenaDezenaUnidade
    Sub main()
        Dim numero As Integer = 0
        Dim centena As Integer = 0
        Dim dezena As Integer = 0
        Dim unidade As Integer = 0

        '// exibe no console
        Console.Write("Entre com um número inteiro de 0 até 999:")
        numero = Double.Parse(Console.ReadLine)

        '// processamento
        '// encontrando a centena
        centena = numero \ 100

        '// o que sobrar depois que tirarmos as centenas, são as dezenas
        dezena = (numero Mod 100) \ 10

        '// o que sobrar depois que tirarmos as centenas e dezenas sao as unidades
        unidade = (numero Mod 100) Mod 10

        Console.Write("Centenas : " & centena & vbCrLf)
        Console.Write("Dezenas  : " & dezena & vbCrLf)
        Console.Write("Unidades : " & unidade & vbCrLf)

        '// espera entrada de teclado para encerrar o programa
        Console.ReadKey()
    End Sub

End Module