Public Class WinLossForm
    Public win As Boolean
    Public ranked As Boolean

    Private Sub NextPage()
        Dim Ratingform = New Rating()
        Dim PartyMembersForm = New PartyMembers()
        PartyMembers.SetRanked = ranked
        PartyMembers.SetWin = win
        Ratingform.Show()
        Me.Close()
    End Sub
    Private Sub BtnWin_Click(sender As Object, e As EventArgs) Handles btnWin.Click
        win = True
        NextPage()
    End Sub

    Private Sub BtnLoss_Click(sender As Object, e As EventArgs) Handles btnLoss.Click
        win = False
        NextPage()
    End Sub

    Private Sub RankedCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles rankedCheckbox.CheckedChanged
        ranked = rankedCheckbox.CheckState()
    End Sub

End Class