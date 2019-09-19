Public Class Rating
    Public teamRating() As Integer = {0, 0, 0, 0, 0}

    Private Sub GoodPlus_Click(sender As Object, e As EventArgs) Handles GoodPlus.Click
        teamRating(0) += 1
        lblGood.Text = teamRating(0).ToString()
    End Sub

    Private Sub GoodMinus_Click(sender As Object, e As EventArgs) Handles GoodMinus.Click
        teamRating(0) -= 1
        If teamRating(0) < 0 Then
            teamRating(0) = 0
        End If
        lblGood.Text = teamRating(0).ToString()
    End Sub

    Private Sub AvePlus_Click(sender As Object, e As EventArgs) Handles AvePlus.Click
        teamRating(1) += 1
        lblAve.Text = teamRating(1).ToString()
    End Sub

    Private Sub AveMinus_Click(sender As Object, e As EventArgs) Handles AveMinus.Click
        teamRating(1) -= 1
        If teamRating(1) < 0 Then
            teamRating(1) = 0
        End If
        lblAve.Text = teamRating(1).ToString()
    End Sub

    Private Sub BadPlus_Click(sender As Object, e As EventArgs) Handles BadPlus.Click
        teamRating(2) += 1
        lblBad.Text = teamRating(2).ToString()
    End Sub

    Private Sub BadMinus_Click(sender As Object, e As EventArgs) Handles BadMinus.Click
        teamRating(2) -= 1
        If teamRating(2) < 0 Then
            teamRating(2) = 0
        End If
        lblBad.Text = teamRating(2).ToString()
    End Sub

    Private Sub TrashPlus_Click(sender As Object, e As EventArgs) Handles TrashPlus.Click
        teamRating(3) += 1
        lblTrash.Text = teamRating(3).ToString()
    End Sub

    Private Sub TrashMinus_Click(sender As Object, e As EventArgs) Handles TrashMinus.Click
        teamRating(3) -= 1
        If teamRating(3) < 0 Then
            teamRating(3) = 0
        End If
        lblTrash.Text = teamRating(3).ToString()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        PartyMembers.increaseTeamates(teamRating)
        PartyMembers.Show()
        Me.Close()
    End Sub

    Private Sub ToxicPlus_Click(sender As Object, e As EventArgs) Handles ToxicPlus.Click
        teamRating(4) += 1
        lblToxic.Text = teamRating(4).ToString()
    End Sub

    Private Sub ToxicMinus_Click(sender As Object, e As EventArgs) Handles ToxicMinus.Click
        teamRating(4) -= 1
        If teamRating(4) < 0 Then
            teamRating(4) = 0
        End If
        lblToxic.Text = teamRating(4).ToString()
    End Sub
End Class