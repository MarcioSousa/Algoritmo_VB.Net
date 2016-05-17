'/*
' * Author  : Marcio Pereira de Sousa
' * File    : Module1.vb
' * Project : Algoritmo_27
' * 
' * Faça um algoritmo que:
' * a) Obtenha o valor para a variável HT (horas trabalhadas no mês);
' * b) Obtenha o valor para a variável VH (valor hora trabalhada):
' * c) Obtenha o valor para a variável PD (percentual de desconto);
' * d) Calcule o salário bruto => SB = HT * VH;
' * e) Calcule o total de desconto => TD = (PD/100)*SB;
' * f) Calcule o salário líquido => SL = SB – TD;
' * g) Apresente os valores de: Horas trabalhadas, Salário Bruto, Desconto, Salário
' * Liquido. Apresente o nome completo. 
' */
Module Module1

    Sub Main()
        Dim HT As Double = 0
        Dim VH As Double = 0
        Dim PD As Double = 0
        Dim SB As Double = 0
        Dim TD As Double = 0
        Dim SL As Double = 0

        Console.Write("Entre com as horas trabalhadas no mês : ")
        HT = Double.Parse(Console.ReadLine())

        Console.Write("Entre com o valor da hora Trabalhada : ")
        VH = Double.Parse(Console.ReadLine())

        Console.Write("Entre com o percentual de desconto : ")
        PD = Double.Parse(Console.ReadLine())

        '// salário bruto
        SB = HT * VH

        '// total de desconto
        TD = (PD / 100) * SB

        '// salario liquido
        SL = SB - TD

        '// saida
        Console.Write("Horas Trabalhadas : " & HT & vbCrLf)
        Console.Write("Salário Bruto     : " & SB & vbCrLf)
        Console.Write("Total de Desconto : " & TD & vbCrLf)
        Console.Write("Salário Líquido   : " & SL & vbCrLf)

        '// espera entrada do teclado para encerrar o programa
        Console.ReadKey()
    End Sub

End Module
