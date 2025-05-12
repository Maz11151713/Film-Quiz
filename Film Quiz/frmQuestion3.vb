Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmQuestion3


    Public Sub init()
        progressCount = 0
        tmrQuestion3.Enabled = True
        ProgressBarQ3.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False

    End Sub


    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If btnAnswer4.Checked Then
            playerScore = playerScore + 1

        End If

        frmHighScore.Show()
        frmHighScore.doScore()

        Me.Hide()
    End Sub

    Private Sub frmQuestion3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tmr3_Tick(sender As Object, e As EventArgs) Handles tmrquestion3.Tick

        progressCount = progressCount + 1
        ProgressBarQ3.PerformStep()
        If progressCount = 10 Then
            tmrquestion3.Enabled = False
            MsgBox("too slow")
            frmHighScore.Show()
            frmHighScore.doScore()
            Me.Hide()

        End If
    End Sub
End Class