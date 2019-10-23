Module Module1

    Sub Main()
        Dim resp As String
        ordenaStrings()
        cambiaNumXTxt("cuando 1 era poco y 2 ") As String
        Console.WriteLine("Hay {0} letras de eso en la palabra", resp)
        Console.ReadLine()


    End Sub

    Function cuentaLetra(ByVal pal As String, ByVal letra As Char) As Integer

        Dim resp As Integer = 0
        Console.WriteLine("Introduce palabra:")
        pal = Console.ReadLine()
        Console.WriteLine("Introduce letra:")
        letra = Console.ReadLine()
        For i As Integer = 0 To pal.Length - 1
            If pal(i) = letra Then
                resp += 1
            End If
        Next
        Return resp
    End Function

    Function cuentaDigitos(ByVal num As String) As Integer

        Dim resp As Integer = 0
        'Console.WriteLine("Introduce palabra:")
        'num = Console.ReadLine()

        For i As Integer = 0 To num.Length - 1

            resp += 1

        Next
        Return resp
    End Function

    Function cuentaPalabras(ByVal pal As String) As Integer

        Dim pals() As String
        Dim resp As Integer = 0
        Console.WriteLine("Introduce palabra:")
        pal = Console.ReadLine()

        pals = pal.Split(" ")
        For i As Integer = 0 To pals.Length - 1

            resp += 1

        Next
        Return resp
    End Function

    Function ordenaStrings() As String()
        Dim pals() As String
        Dim i As Integer = -1
        Do
            i += 1
            ReDim Preserve pals(i)
            Console.WriteLine("Introduce palabra:")
            pals(i) = Console.ReadLine()

        Loop While pals(i).ToUpper.CompareTo("FIN")
        For i = 0 To pals.Length - 1
            For j As Integer = i To pals.Length - 1
                If pals(i).CompareTo(pals(j)) > 0 Then
                    Dim aux As String
                    aux = pals(i)
                    pals(i) = pals(j)
                    pals(j) = aux
                End If
            Next
        Next
        Return pals
    End Function

    Function cuentaLetraConPos(ByVal texto As String, ByVal letra As Char, Optional ByVal pos As Integer = 0) As Integer
        Dim resp As Integer = 0
        Console.WriteLine("Introduce palabra:")
        texto = Console.ReadLine()
        Console.WriteLine("Introduce letra:")
        letra = Console.ReadLine()
        For i As Integer = 0 To texto.Length - 1
            If texto(i) = letra Then
                resp += 1
            End If
        Next
        Return resp
    End Function


    Function cambiaNumXTxt(ByVal conNumeros As String) As String
        Dim Numeros() As String = {"cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve"}
        Dim num As Integer
        For num = 0 To 9
            If conNumeros.Contains(num) Then
                For i As Integer = 0 To conNumeros.Length - 1
                    If conNumeros(i) = num.ToString Then
                        conNumeros.Remove(i)
                        conNumeros.Insert(i, Numeros(i))
                    End If
                Next
            End If
        Next
        Return conNumeros

    End Function

End Module
