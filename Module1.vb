Module Module1

    Sub Main()
        Console.WriteLine("*******************************")
        Console.WriteLine("* 1) Input heros              *")
        Console.WriteLine("* 2) Input costume details    *")
        Console.WriteLine("* 3) Input super power details*")
        Console.WriteLine("* 4) Display superhero        *")
        Console.WriteLine("* 5) Display a specific hero  *")
        Console.WriteLine("* 6) End                      *")
        Console.WriteLine("*******************************")

        Console.Write("what option do you want?  ")
        vars.choice = Console.ReadLine

        Select Case vars.choice
            Case 1
                Call inputHeros()
            Case 2
                Call inputCostumes()
            Case 3
                Call inputpower()
            Case 4
                Call displayHeros()
            Case 5
                Call heroSearch()
            Case 6
                End
            Case Else
                MsgBox("option not reconized. Only enter 1-6", MsgBoxStyle.Critical, "option not reconized")
                'vars.choice = Nothing
                Console.Clear()

                Call Main()

        End Select

    End Sub

    Sub inputHeros()
        For looper As Integer = 1 To 5 Step 1
            Console.Clear()
            Console.Write("what is the name of hero " & looper)
            vars.heros(looper) = Console.ReadLine
            'Debug.Print(vars.heros(looper))
        Next
    End Sub

    Sub inputCostumes()
        For looper As Integer = 1 To 5 Step 1
            Console.Clear()
            Console.Write("what is the colour of hero " & vars.heros(looper))
            vars.costumes(looper) = Console.ReadLine
            ' Debug.Print(vars.costumes(looper))
        Next
    End Sub

    Sub inputPower()
        For looper As Integer = 1 To 5 Step 1
            Console.Clear()
            Console.Write("what is the power of hero " & vars.heros(looper))
            vars.powers(looper) = Console.ReadLine
            'Debug.Print(vars.costumes(looper))
        Next
    End Sub

    Sub displayHeros()
        Console.Clear()
        For looper As Integer = 1 To 5 Step 1
            Console.WriteLine(vars.heros(looper) & " has a " & vars.costumes(looper) & " colour costume and has the power " & vars.powers(looper))
        Next
    End Sub

    Sub heroSearch()
        Console.Write("what is the name of the hero you want to search for:  ")

        vars.heroSearchNotModified = Console.ReadLine
        vars.heroSearchUCase = UCase(vars.heroSearchNotModified)

        For looper As Integer = 1 To 5 Step 1

            If vars.heros(looper) = vars.heroSearchUCase Then

                Console.WriteLine(vars.heros(looper) & " has a " & vars.costumes(looper) & " colour costume and has the power " & vars.powers(looper))
            Else
                Console.Write("hero not found")

            End If
        Next
    End Sub
End Module