'/*
' * Author  : Marcio Sousa
' * File    : RestauranteQuilo.vb
' * Project : Sequencial
' * 
' * O restaurante a quilo cobra R$12,00 por cada quilo de refeição. Escreva um algoritmo
' * que leia o peso do prato montado pelo cliente (em quilos) e imprima o valor a pagar. Assuma que a 
' * balança já desconte o peso do prato.
' */

Module RestauranteQuilo

    Sub Main()
        '// declara e inicia variáveis 
        Const kg As Double = 12D
        Dim peso As Double = 0   '// variáveis numéricas inicializadas com 0
        Dim pagar As Double = 0

        '// exibe no console   
        Console.Write("Entre com o peso : ")
        peso = Double.Parse(Console.ReadLine())   '// lê o peso

        '// processa o valor a pagar
        pagar = peso * kg

        '// exibe a saida ou resultado do programa 
        Console.Write("Valor a pagar : " & pagar)

        Console.ReadKey()    '// espera entrada do teclado para finalizar aplicação  
    End Sub

End Module