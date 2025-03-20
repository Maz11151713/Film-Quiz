Public Class frmQuestion1
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If btnAnswer2.Checked Then
            playerScore = playerScore + 1

        End If
        frmQuestion2.Show()
        Me.Hide()

    End Sub

    Private Sub btnAnswer2_CheckedChanged(sender As Object, e As EventArgs) Handles btnAnswer2.CheckedChanged

    End Sub
End Class