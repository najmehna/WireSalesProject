Module Module1
    Public Sub makeItFarsi()

        Dim j As Integer
        Dim lang As InputLanguage
        j = -1

        For Each lang In InputLanguage.InstalledInputLanguages
            j += 1
            If lang.Culture.EnglishName.Contains("Persian") Then

                InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages.Item(j)
                Exit Sub
            End If
        Next lang

        InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages.Item(1)

    End Sub

    Public Function isValidDate(ByVal mystr As String) As Boolean
        Dim day As Integer
        Dim month As Integer
        Dim year As Integer
        Dim len As Integer
        Dim strparts As String

        len = mystr.IndexOf("/")
        day = mystr.Substring(0, len)
        If day > 31 Then
            MsgBox("  روز را اشتباه وارد کرده اید")
            Return False
        End If
        strparts = mystr.Substring(len + 1)
        len = strparts.IndexOf("/")
        month = strparts.Substring(0, len)
        If month > 12 Then
            MsgBox("  ماه را اشتباه وارد کرده اید ")
            Return False
        End If
        mystr = strparts.Substring(len + 1)
        If mystr.Length = 2 Or mystr.Length = 4 Then
            If mystr.Length = 2 Then
                mystr = "13" & mystr
            End If
            year = mystr
        Else
            MsgBox("  سال را اشتباه وارد کرده اید ")
            Return False
        End If
        If year > 2000 Or year < 1300 Then
            MsgBox(" سال  را اشتباه وارد کرده اید ")
            Return False
        End If
        Return True
    End Function

   

    Public Function ReverseTheDate(ByVal mystr As String) As String
        Dim day As Integer
        Dim dayOne As Boolean = False
        Dim month As Integer
        Dim monthOne As Boolean = False
        Dim year As Integer
        Dim len As Integer
        Dim strparts As String
        'the validation of the date is not checked here any more
        'If isValidDate(mystr) Then
        len = mystr.IndexOf("/")
        day = mystr.Substring(0, len)
        If day < 10 Then
            dayOne = True
        End If

        strparts = mystr.Substring(len + 1)
        len = strparts.IndexOf("/")
        month = strparts.Substring(0, len)
        If month < 10 Then
            monthOne = True
        End If

        mystr = strparts.Substring(len + 1)
        If mystr.Length = 2 Then
            mystr = "13" & mystr
        End If
        year = mystr
        If dayOne And monthOne Then
            mystr = year & "/0" & month & "/0" & day
        ElseIf dayOne Then
            mystr = year & "/" & month & "/0" & day
        ElseIf monthOne Then
            mystr = year & "/0" & month & "/" & day
        Else
            mystr = year & "/" & month & "/" & day
        End If
        Return mystr
        'Else : Return "not valid"
        'End If
    End Function

    
End Module
