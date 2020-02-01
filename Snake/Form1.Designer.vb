<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGame))
        Me.picBoard = New System.Windows.Forms.PictureBox()
        Me.tmrTick = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.lblParameters = New System.Windows.Forms.Label()
        Me.lblHighscore = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        CType(Me.picBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBoard
        '
        Me.picBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBoard.Location = New System.Drawing.Point(12, 12)
        Me.picBoard.Name = "picBoard"
        Me.picBoard.Size = New System.Drawing.Size(625, 625)
        Me.picBoard.TabIndex = 0
        Me.picBoard.TabStop = False
        '
        'tmrTick
        '
        Me.tmrTick.Interval = 69
        '
        'lblScore
        '
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(643, 12)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(184, 38)
        Me.lblScore.TabIndex = 1
        Me.lblScore.Text = "Score: 0"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblHelp
        '
        Me.lblHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.Location = New System.Drawing.Point(643, 130)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(184, 305)
        Me.lblHelp.TabIndex = 2
        Me.lblHelp.Text = resources.GetString("lblHelp.Text")
        '
        'lblParameters
        '
        Me.lblParameters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblParameters.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParameters.Location = New System.Drawing.Point(643, 455)
        Me.lblParameters.Name = "lblParameters"
        Me.lblParameters.Size = New System.Drawing.Size(184, 182)
        Me.lblParameters.TabIndex = 3
        Me.lblParameters.Text = "Clique ici pour changer les paramétres du jeu." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Paramétres actuelle:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rapidit" & _
            "é: Moyen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Largeur: 25x25" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Point par cercle: 1"
        Me.lblParameters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHighscore
        '
        Me.lblHighscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighscore.Location = New System.Drawing.Point(646, 85)
        Me.lblHighscore.Name = "lblHighscore"
        Me.lblHighscore.Size = New System.Drawing.Size(184, 23)
        Me.lblHighscore.TabIndex = 4
        Me.lblHighscore.Text = "Meilleur Score: "
        Me.lblHighscore.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLength
        '
        Me.lblLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.Location = New System.Drawing.Point(643, 50)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(184, 23)
        Me.lblLength.TabIndex = 5
        Me.lblLength.Text = "Longeur: 1"
        Me.lblLength.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(839, 649)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblHighscore)
        Me.Controls.Add(Me.lblParameters)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.picBoard)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmGame"
        Me.Text = "Snake Game"
        CType(Me.picBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picBoard As System.Windows.Forms.PictureBox
    Friend WithEvents tmrTick As System.Windows.Forms.Timer
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblHelp As System.Windows.Forms.Label
    Friend WithEvents lblParameters As System.Windows.Forms.Label
    Friend WithEvents lblHighscore As System.Windows.Forms.Label
    Friend WithEvents lblLength As System.Windows.Forms.Label

End Class
