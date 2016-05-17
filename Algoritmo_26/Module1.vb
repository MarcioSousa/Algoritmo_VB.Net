'/*
'* Author  : Marcio Pereira de Sousa
'* File    : Module1.vb
'* Project : Algoritmo_26
'* 
'* Faça um algoritmo que:
'* a) Leia o nome;
'* b) Leia o sobrenome;
'* c) Concatene o nome com o sobrenome;
'* d) Apresente o nome completo. 
'*/

Module Module1

    Sub Main()
        '/*
        '* inicializa e declara as 
        '* variáveis(espaço reservado na memória que tem um nome, um tamnho, uma valor e um tipo)
        '*/ 
        Dim nome As String = ""
        Dim sobrenome As String = ""

        '// exibe no console
        Console.Write("Digite um nome : ")
        nome = Console.ReadLine()   '// lê nome 

        '// exibe no console
        Console.Write("Digite um sobrenome : ")
        sobrenome = Console.ReadLine()   '// lê sobrenome 

        '// saída ou resultado
        Console.Write("Nome completo : " & nome & " " & sobrenome)

        '//  espera entrada do teclado para encerrar o programa
        Console.ReadKey()
    End Sub

End Module
