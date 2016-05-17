'/*
' * Author  : Marcio Pereira de Sousa
' * File    : Module1.vb
' * Project : Algoritmo_15
' * 
' * . Calcule o volume de uma caixa d'água cilíndrica. 
' */

Module Module1

    Sub Main()
        '// inicializa variáveis e constante
        Const PI As Double = 3.14D
        Dim raio As Double = 0
        Dim altura As Double = 0
        Dim area As Double = 0

        '// exibe no console
        Console.Write("Entre com o raio da caixa d' agua cilindrica : ")
        raio = Double.Parse(Console.ReadLine())   '// lê raio  

        '// exibe no console
        Console.Write("Entre com a altura da caixa d'agua cilindrica : ")
        altura = Double.Parse(Console.ReadLine()) '// lê altura

        '// processamento
        area = (PI * (raio * raio)) * altura

        '// saída ou solução
        Console.Write("Area da caixa d'agua cilindrica é " & area)

        '// espera entrada do teclado para encerrar o programa
        Console.ReadKey()

    End Sub

End Module

