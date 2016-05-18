'/*
' * Author  : Marcio Pereira de Sousa
' * File    : Module1.vb 
' * Project : Algoritmo_05
' * 
' * Um motorista deseja colocar no seu tanque X reais de gasolina. Escreva um algoritmo para ler o 
' * preço do litro da gasolina e o valor do pagamento, e exibir quantos litros ele conseguiu colocar no 
' * tanque.
' */

Module Abastecimento

    Sub Main()
        '// inicia e declara as variáveis 
        Dim abastecimento As Double = 0
        Const litro As Double = 3.74D
        Dim qtd_litros As Double = 0

        '// exibe no console
        Console.Write("Qual o valor que deseja abastacer : ")
        abastecimento = Double.Parse(Console.ReadLine())   '// lê o valor do abastecimento

        qtd_litros = abastecimento / litro '// processamento para quantidade de litros

        '// exibe resultado.
        Console.Write("Litros abastecido com o valor de RS" & abastecimento & " foi de : " & qtd_litros)

        Console.ReadKey()  '//espera a entrada do teclado para encerrar a aplicação.
    End Sub

End Module