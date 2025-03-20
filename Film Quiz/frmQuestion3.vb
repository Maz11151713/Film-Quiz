Public Class frmQuestion3
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles btnAnswer1.CheckedChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If btnAnswer4.Checked Then
            playerScore = playerScore + 1

        End If

        frmHighScore.Show()
        frmHighScore.doScore()

        Me.Hide()
    End Sub
End Class