Module Module1

    Sub Main()
        Dim S As String
        Dim A As Integer
        Dim B As Integer
        Console.Write("Enter String: ")
        S = Console.ReadLine
        For I = 1 To Len(S) - 2
            If Mid(S, I, 3) = "No" Then
                A = I
            ElseIf Mid(S, I, 3) = "Bad" Then
                B = I
            End If
        Next
        If B > A And A > 0 Then
            S = Mid(S, 1, A - 1) & "Good" & Mid(S, B + 3)
        End If
        Console.WriteLine()
        Console.ReadKey()
    End Sub

End Module
