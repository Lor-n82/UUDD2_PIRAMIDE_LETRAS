Module Module1

    Sub Main()

        Dim cadena As String = "ZYXWVTSRQPONMLKJIHGFEDCBA"
        Dim contador As Integer = 0
        Dim contador2 As Integer = 0
        Dim tamaño As Integer

        tamaño = cadena.Length

        For contador = 1 To tamaño Step 1

            Console.WriteLine(cadena.Remove(0, contador2))
            contador2 = contador2 + 1
        Next

        Console.ReadLine()

    End Sub

End Module
