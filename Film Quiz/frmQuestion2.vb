Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmQuestion2

    Public Sub Init()
        progressCount = 0
        tmrQuestion2.Enabled = True
        ProgressBarQ2.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If btnAnswer3.Checked Then
            playerScore = playerScore + 1
        End If

        frmQuestion3.Show()

        Me.Hide()
    End Sub

    Private Sub frmQuestion2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tmrQuestion2_Tick(sender As Object, e As EventArgs) Handles tmrQuestion2.Tick

        progressCount = progressCount + 1
        ProgressBarQ2.PerformStep()
        If progressCount = 10 Then
            tmrQuestion2.Enabled = False
            MsgBox("too slow")
            frmQuestion3.Show()
            frmQuestion3.init()
            Me.Hide()

        End If


    End Sub
End Class