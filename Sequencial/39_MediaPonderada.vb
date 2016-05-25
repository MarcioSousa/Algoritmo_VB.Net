'/*
' * Author  : Marcio Sousa
' * File    : MediaPonderada.vb
' * Project : Sequencial
' * 
' * Entrar com quatro números e imprimir a média ponderada, sabendo-se que os pesos são respectivamente: 1, 2, 3 e 4. 
' */
Module MediaPonderada

    Sub main()
        Dim a As Double = 0
        Dim b As Double = 0
        Dim c As Double = 0
        Dim d As Double = 0
        Dim mp As Double = 0

        'Exibi no console
        Console.Write("Entre com o primeiro número: ")
        a = Double.Parse(Console.ReadLine)

        Console.Write("Entre com o segundo número: ")
        b = Double.Parse(Console.ReadLine)

        Console.Write("Entre com o terceiro número: ")
        c = Double.Parse(Console.ReadLine)

        Console.Write("Entre com o quarto número: ")
        d = Double.Parse(Console.ReadLine)

        '//Processamento
        mp = (a * 1 + b * 2 + c * 3 + d * 4) / 10

        '//Saída
        Console.Write("Média ponderada: " & mp)

        Console.ReadKey()

    End Sub

End Module
'            // processamento
'            mp = (a * 1 + b * 2 + c * 3 + d * 4) / 10;

'            // saida
'            Console.Write("\nMedia ponderada : " + mp + "\n");
'            Console.ReadKey();
'        }
'    }
'}