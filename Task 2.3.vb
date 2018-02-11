Module Module1

    Sub Main()
        Dim S As String
        Dim First As Char
        Dim Symbol As Char = "*"
        Dim NewS As String
        Console.Write("Enter string: ")
        S = Console.ReadLine
        First = S(0)
        NewS = First
        For I = 1 To Len(S) - 1
            If S(I) <> First Then
                NewS = NewS & S(I)
            Else : NewS = NewS & Symbol
            End If
        Next
        Console.WriteLine(NewS)
        Console.ReadKey()
    End Sub

End Module
