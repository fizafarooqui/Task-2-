Module Module1

    Sub Main()
        Dim String1 As String
        Dim String2 As String
        Dim NewS As String = ""
        Console.Write("Enter First String: ")
        String1 = Console.ReadLine
        Console.Write("Enter Second String: ")
        String2 = Console.ReadLine
        NewS = Mid(String2, 1, 2) & Mid(String1, 3) & "" & Mid(String1, 1, 2) & Mid(String2, 3)
        Console.WriteLine(NewS)
        Console.ReadKey()

    End Sub

End Module
