Module Module1

    Sub Main()
        Dim Count As Integer
        Console.Write("Enter no. of Donuts: ")
        Count = Console.ReadLine
        If Count < 10 Then
            Console.WriteLine("No. of donuts: " & Count)
        Else : Console.WriteLine(" No. of Donuts: Many")
        End If
        Console.ReadKey()
    End Sub

End Module
