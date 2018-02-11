Module Module1

    Sub Main()
        Dim A As String
        Dim AFront As String
        Dim ABack As String
        Dim B As String
        Dim BFront As String
        Dim BBack As String
        Console.Write("Enter First String: ")
        A = Console.ReadLine
        Console.Write("Enter Second String: ")
        B = Console.ReadLine
        If Len(A) Mod 2 = 0 Then
            AFront = Mid(A, 1, Len(A) / 2)
            ABack = Mid(A, Len(A) / 2 + 1)
        Else
            AFront = Mid(A, 1, (Len(A) + 1) / 2)
            ABack = Mid(A, (Len(A) + 3) / 2)
        End If
        If Len(B) Mod 2 = 0 Then
            BFront = Mid(B, 1, Len(B) / 2)
            BBack = Mid(B, Len(B) / 2 + 1)
        Else
            BFront = Mid(B, 1, (Len(B) + 1) / 2)
            BBack = Mid(B, (Len(B) + 3) / 2)
        End If
        Console.WriteLine(AFront & BFront & ABack & BBack)
        Console.ReadKey()
    End Sub

End Module
