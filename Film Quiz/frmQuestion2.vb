Public Class frmQuestion2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnAnswer1_CheckedChanged(sender As Object, e As EventArgs) Handles btnAnswer1.CheckedChanged

        If btnAnswer3.Checked Then
            playerScore = playerScore + 1
        End If

        frmQuestion3.Show()

        Me.Hide()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

    End Sub
End Class