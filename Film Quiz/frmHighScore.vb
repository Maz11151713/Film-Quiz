Public Class frmHighScore
    Private Sub lstHighScore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHighScore.SelectedIndexChanged

    End Sub

    Public Sub doScore()
        If playerScore < 1 Then
            lblMessage.Text = "Sorry Your Score Was Not Good Enough"
        Else
            lblMessage.Text = "Congratulations Your Score Will Be Added To The Hall of Fame"

            lstHighScore.Items.Add(playerName & vbTab & playerScore)
        End If
    End Sub

    Private Sub btnAgain_Click(sender As Object, e As EventArgs) Handles btnAgain.Click

        frmMain.Show()
        Me.Hide()

    End Sub
End Class