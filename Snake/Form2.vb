Public Class frmOptions

    Private Sub frmOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cocher les options selectionné
        Select Case frmGame.language
            Case 0
                radEnglish.Checked = True
            Case 1
                radFrench.Checked = True
        End Select

        Select Case frmGame.speed
            Case 0
                radSlow.Checked = True
            Case 1
                radMedium.Checked = True
            Case 2
                radFast.Checked = True
        End Select

        Select Case frmGame.grid
            Case 0
                rad25.Checked = True
            Case 1
                rad50.Checked = True
            Case 2
                rad100.Checked = True
        End Select

        Select Case frmGame.points
            Case 0
                rad1.Checked = True
            Case 1
                rad3.Checked = True
            Case 2
                rad5.Checked = True
        End Select

        Select Case frmGame.entry
            Case 0
                radFirst.Checked = True
            Case 1
                radLast.Checked = True
            Case 2
                radQueue.Checked = True
        End Select

        Select Case frmGame.walls
            Case False
                chkWalls.Checked = True
            Case True
                chkWalls.Checked = False
        End Select

        Select Case frmGame.ai
            Case False
                chkAI.Checked = False
            Case True
                chkAI.Checked = True
        End Select
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'Fermer la fenêtre
        Me.Close()
    End Sub

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        'Change les valeurs des options du jeu
        If radEnglish.Checked = True Then
            frmGame.language = 0
        ElseIf radFrench.Checked = True Then
            frmGame.language = 1
        End If

        If radSlow.Checked = True Then
            frmGame.speed = 0
        ElseIf radMedium.Checked = True Then
            frmGame.speed = 1
        ElseIf radFast.Checked = True Then
            frmGame.speed = 2
        End If

        If rad25.Checked = True Then
            frmGame.grid = 0
        ElseIf rad50.Checked = True Then
            frmGame.grid = 1
        ElseIf rad100.Checked = True Then
            frmGame.grid = 2
        End If

        If rad1.Checked = True Then
            frmGame.points = 0
        ElseIf rad3.Checked = True Then
            frmGame.points = 1
        ElseIf rad5.Checked = True Then
            frmGame.points = 2
        End If

        If radFirst.Checked = True Then
            frmGame.entry = 0
        ElseIf radLast.Checked = True Then
            frmGame.entry = 1
        ElseIf radQueue.Checked = True Then
            frmGame.entry = 2
        End If

        If chkWalls.Checked = True Then
            frmGame.walls = False
        ElseIf chkWalls.Checked = False Then
            frmGame.walls = True
        End If

        If chkAI.Checked = True Then
            frmGame.ai = True
        ElseIf chkAI.Checked = False Then
            frmGame.ai = False
        End If
        'Ferme le jeu
        Me.Close()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        'Réinitialiser le meilleur score
        frmGame.highscore = 0
        frmGame.lblHighscore.Text = "0"
    End Sub
End Class