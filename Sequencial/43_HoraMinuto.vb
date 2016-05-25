'/*
' * Author  : Marcio Sousa
' * File    : HoraMinuto.vb
' * Project : Sequencial
' * 
' * Criar um algoritmo que leia um valor de hora e informe quantos minutos se passaram desde o início do dia. 
' */
Module HoraMinuto

    Sub main()
        Dim hora As Integer = 0
        Dim tminuto As Integer = 0
        Dim minuto As Integer = 0

        Console.Write("Entre com hora atual: ")
        hora = Integer.Parse(Console.ReadLine())

        Console.Write("Entre com minutos : ")
        minuto = Integer.Parse(Console.ReadLine())

        '// processamento
        tminuto = hora * 60 + minuto

        '// saída
        Console.Write("Até agora se passaram: " & tminuto & " minutos.")

        Console.ReadKey()
    End Sub

End Module