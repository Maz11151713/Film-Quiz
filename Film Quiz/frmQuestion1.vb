Public Class frmQuestion1


    Public Sub init()
        progressCount = 0
        tmrQuetion1.Enabled = True
        ProgressBarQ1.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If btnAnswer2.Checked Then
            playerScore = playerScore + 1

        End If
        frmQuestion2.Show()
        Me.Hide()

    End Sub

    Private Sub frmQuestion1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tmrQuetion1_Tick(sender As Object, e As EventArgs) Handles tmrQuetion1.Tick

        progressCount = progressCount + 1
        ProgressBarQ1.PerformStep()
        If progressCount = 10 Then
            tmrQuetion1.Enabled = False
            MsgBox("too slow")
            frmQuestion2.Show()
            frmQuestion2.init()
            Me.Hide()
        End If

    End Sub
End Class