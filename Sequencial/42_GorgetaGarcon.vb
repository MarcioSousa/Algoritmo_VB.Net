'/*
' * Author  : Antônio Paulo Neto
' * File    : Program.cs
' * Project : Algoritmo_42
' * 
' * Todo restaurante, embora por lei não possa obrigar o cliente a pagar, cobra 10% para o garçom. 
' * Fazer um algoritmo que leia o valor gasto com despesas realizadas em um restaurante e imprima o valor total com a gorjeta.
' */
Module GorgetaGarcon

    Sub main()

        Dim cres As Double = 0
        Dim cgorj As Double = 0
        Dim total As Double = 0

        Console.Write("Entre com o valor da conta : ")
        cres = Double.Parse(Console.ReadLine())

        cgorj = cres * 0.1
        total = cres + cgorj

        Console.Write("O valor da conta com a comissão do garçon é de R$ " & total)
        Console.ReadKey()
    End Sub

End Module