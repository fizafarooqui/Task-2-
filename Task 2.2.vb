Module Module1

    Sub Main()
        Dim Txt As String
        Console.Write("Enter string: ")
        Txt = Console.ReadLine
        If Len(Txt) < 2 Then
            Console.WriteLine("")
        Else : Console.WriteLine(Left(Txt, 2) & Right(Txt, 2))
        End If
        Console.ReadKey()
    End Sub

End Module
