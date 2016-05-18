'/*
' * Author  : Marcio Pereira de Sousa
' * File    : Module1.vb
' * Project : Algoritmo_19
' * 
' * Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento
' * desconte 8% de impostos. Imprima o salário inicial, o salário com o aumento e o salário final. 
' */

Module SalarioFuncionario

    Sub Main()
        '// inicializa e declara variáveis
        Dim salario As Double = 0
        Dim salarioAumento As Double = 0
        Dim salarioFinal As Double = 0

        '// exibe no console
        Console.Write("Entre com o salario do funcionario : ")
        salario = Double.Parse(Console.ReadLine()) '// lê salário inicial do aluno

        '// imprime salario inicial
        Console.Write("Salário inicial é de : " & salario & vbCrLf)

        '// processa salário com aumento 
        salarioAumento = salario + (salario * 0.15)
        Console.Write("Salário com aumento é de : " & salarioAumento & vbCrLf)  '// imprime salário com aumento

        '// processa salário final
        salarioFinal = salarioAumento - (salarioAumento * 0.08)
        Console.Write("Salário final é de : " & salarioFinal & vbCrLf)   '// imprimie salario final

        '// espera entrada do teclado para encerrar o programa.
        Console.ReadKey()

    End Sub

End Module

