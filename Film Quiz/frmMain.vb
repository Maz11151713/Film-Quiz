Public Class frmMain


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        playerScore = 0
        playerName = txtPlayerName.Text
        frmQuestion1.Show()
        frmQuestion1.init()

        Me.Hide()

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click

        Application.Exit()

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub
End Class