Public Class PartyMembers
    Dim ranked As Boolean
    Dim win As Boolean
    Dim teamateScore() As Integer = {0, 0, 0, 0, 0}
    Dim teamRating() As Integer = {0, 0, 0, 0, 0}

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim linetemp As String
        Dim strfilename As String
        strfilename = "D:\Users\Downloads\Programming\DotaTeamates\Dota Teamates Stats.csv"
        Dim modifiedCSV = From line In IO.File.ReadAllLines(strfilename)
        Using sw As New IO.StreamWriter(strfilename)
            Dim row = 1
            For Each line In modifiedCSV
                'sw.WriteLine(String.Join(",", line))  ' I think this writes the file back
                If row = 2 Then
                    linetemp = line.Replace(",", " ")
                End If
                row += 1
            Next

            sw.Write("Sum Good,Sum Average,Sum Bad,Sum Trash,Sum Toxic")
            sw.WriteLine()

            Dim tempStringArray() As String = Split(linetemp)
            For i As Integer = 0 To (UBound(tempStringArray))
                teamateScore(i) = CInt(tempStringArray(i))
                teamateScore(i) += teamRating(i)
                'Console.WriteLine("score  : {0}", teamateScore(i))
                sw.Write("{0}", teamateScore(i))

                If i <> UBound(tempStringArray) Then
                    sw.Write(",")
                End If
            Next
            'sw.WriteLine("Ranked is: {0}", ranked)
            'sw.WriteLine("Win is: {0}", win)
        End Using
        teamRating = {0, 0, 0, 0, 0} ' Wipes the array to prevent multiple "saves" to add infinitely
    End Sub
    Public Sub increaseTeamates(score As Array)
        For i As Integer = 0 To UBound(score)
            teamRating(i) = score(i)
        Next
    End Sub

    Public WriteOnly Property SetRanked As Boolean
        Set(value As Boolean)
            ranked = value
        End Set
    End Property
    Public WriteOnly Property SetWin As Boolean
        Set(value As Boolean)
            win = value
        End Set
    End Property

End Class