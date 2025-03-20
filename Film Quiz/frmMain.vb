Public Class frmMain
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblMoviQuiz.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        playerScore = 0
        playerName = txtPlayerName.Text
        frmQuestion1.Show()

        Me.Hide()

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblPlayerName.Click

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click

        Application.Exit()

    End Sub

    Private Sub txtPlayerName_TextChanged(sender As Object, e As EventArgs) Handles txtPlayerName.TextChanged

    End Sub
End Class