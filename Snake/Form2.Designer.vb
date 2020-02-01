<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpSpeed = New System.Windows.Forms.GroupBox()
        Me.radFast = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radSlow = New System.Windows.Forms.RadioButton()
        Me.grpSize = New System.Windows.Forms.GroupBox()
        Me.rad100 = New System.Windows.Forms.RadioButton()
        Me.rad50 = New System.Windows.Forms.RadioButton()
        Me.rad25 = New System.Windows.Forms.RadioButton()
        Me.grpPoints = New System.Windows.Forms.GroupBox()
        Me.rad5 = New System.Windows.Forms.RadioButton()
        Me.rad3 = New System.Windows.Forms.RadioButton()
        Me.rad1 = New System.Windows.Forms.RadioButton()
        Me.grpLanguage = New System.Windows.Forms.GroupBox()
        Me.radEnglish = New System.Windows.Forms.RadioButton()
        Me.radFrench = New System.Windows.Forms.RadioButton()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpEntry = New System.Windows.Forms.GroupBox()
        Me.radFirst = New System.Windows.Forms.RadioButton()
        Me.radLast = New System.Windows.Forms.RadioButton()
        Me.radQueue = New System.Windows.Forms.RadioButton()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.chkWalls = New System.Windows.Forms.CheckBox()
        Me.chkAI = New System.Windows.Forms.CheckBox()
        Me.grpSpeed.SuspendLayout()
        Me.grpSize.SuspendLayout()
        Me.grpPoints.SuspendLayout()
        Me.grpLanguage.SuspendLayout()
        Me.grpEntry.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSpeed
        '
        Me.grpSpeed.Controls.Add(Me.radFast)
        Me.grpSpeed.Controls.Add(Me.radMedium)
        Me.grpSpeed.Controls.Add(Me.radSlow)
        Me.grpSpeed.Location = New System.Drawing.Point(165, 12)
        Me.grpSpeed.Name = "grpSpeed"
        Me.grpSpeed.Size = New System.Drawing.Size(128, 94)
        Me.grpSpeed.TabIndex = 0
        Me.grpSpeed.TabStop = False
        Me.grpSpeed.Text = "Rapidité"
        '
        'radFast
        '
        Me.radFast.AutoSize = True
        Me.radFast.Location = New System.Drawing.Point(6, 65)
        Me.radFast.Name = "radFast"
        Me.radFast.Size = New System.Drawing.Size(59, 17)
        Me.radFast.TabIndex = 2
        Me.radFast.TabStop = True
        Me.radFast.Text = "Rapide"
        Me.radFast.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Location = New System.Drawing.Point(6, 42)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(57, 17)
        Me.radMedium.TabIndex = 1
        Me.radMedium.TabStop = True
        Me.radMedium.Text = "Moyen"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radSlow
        '
        Me.radSlow.AutoSize = True
        Me.radSlow.Location = New System.Drawing.Point(6, 19)
        Me.radSlow.Name = "radSlow"
        Me.radSlow.Size = New System.Drawing.Size(46, 17)
        Me.radSlow.TabIndex = 0
        Me.radSlow.TabStop = True
        Me.radSlow.Text = "Lent"
        Me.radSlow.UseVisualStyleBackColor = True
        '
        'grpSize
        '
        Me.grpSize.Controls.Add(Me.rad100)
        Me.grpSize.Controls.Add(Me.rad50)
        Me.grpSize.Controls.Add(Me.rad25)
        Me.grpSize.Location = New System.Drawing.Point(18, 121)
        Me.grpSize.Name = "grpSize"
        Me.grpSize.Size = New System.Drawing.Size(128, 94)
        Me.grpSize.TabIndex = 1
        Me.grpSize.TabStop = False
        Me.grpSize.Text = "Largeur de la grille"
        '
        'rad100
        '
        Me.rad100.AutoSize = True
        Me.rad100.Location = New System.Drawing.Point(6, 65)
        Me.rad100.Name = "rad100"
        Me.rad100.Size = New System.Drawing.Size(66, 17)
        Me.rad100.TabIndex = 2
        Me.rad100.TabStop = True
        Me.rad100.Text = "100x100"
        Me.rad100.UseVisualStyleBackColor = True
        '
        'rad50
        '
        Me.rad50.AutoSize = True
        Me.rad50.Location = New System.Drawing.Point(6, 42)
        Me.rad50.Name = "rad50"
        Me.rad50.Size = New System.Drawing.Size(54, 17)
        Me.rad50.TabIndex = 1
        Me.rad50.TabStop = True
        Me.rad50.Text = "50x50"
        Me.rad50.UseVisualStyleBackColor = True
        '
        'rad25
        '
        Me.rad25.AutoSize = True
        Me.rad25.Location = New System.Drawing.Point(6, 19)
        Me.rad25.Name = "rad25"
        Me.rad25.Size = New System.Drawing.Size(54, 17)
        Me.rad25.TabIndex = 0
        Me.rad25.TabStop = True
        Me.rad25.Text = "25x25"
        Me.rad25.UseVisualStyleBackColor = True
        '
        'grpPoints
        '
        Me.grpPoints.Controls.Add(Me.rad5)
        Me.grpPoints.Controls.Add(Me.rad3)
        Me.grpPoints.Controls.Add(Me.rad1)
        Me.grpPoints.Location = New System.Drawing.Point(165, 121)
        Me.grpPoints.Name = "grpPoints"
        Me.grpPoints.Size = New System.Drawing.Size(128, 94)
        Me.grpPoints.TabIndex = 2
        Me.grpPoints.TabStop = False
        Me.grpPoints.Text = "Taux d'augmentation"
        '
        'rad5
        '
        Me.rad5.AutoSize = True
        Me.rad5.Location = New System.Drawing.Point(6, 65)
        Me.rad5.Name = "rad5"
        Me.rad5.Size = New System.Drawing.Size(31, 17)
        Me.rad5.TabIndex = 2
        Me.rad5.TabStop = True
        Me.rad5.Text = "5"
        Me.rad5.UseVisualStyleBackColor = True
        '
        'rad3
        '
        Me.rad3.AutoSize = True
        Me.rad3.Location = New System.Drawing.Point(6, 42)
        Me.rad3.Name = "rad3"
        Me.rad3.Size = New System.Drawing.Size(31, 17)
        Me.rad3.TabIndex = 1
        Me.rad3.TabStop = True
        Me.rad3.Text = "3"
        Me.rad3.UseVisualStyleBackColor = True
        '
        'rad1
        '
        Me.rad1.AutoSize = True
        Me.rad1.Location = New System.Drawing.Point(6, 19)
        Me.rad1.Name = "rad1"
        Me.rad1.Size = New System.Drawing.Size(31, 17)
        Me.rad1.TabIndex = 0
        Me.rad1.TabStop = True
        Me.rad1.Text = "1"
        Me.rad1.UseVisualStyleBackColor = True
        '
        'grpLanguage
        '
        Me.grpLanguage.Controls.Add(Me.radEnglish)
        Me.grpLanguage.Controls.Add(Me.radFrench)
        Me.grpLanguage.Location = New System.Drawing.Point(18, 12)
        Me.grpLanguage.Name = "grpLanguage"
        Me.grpLanguage.Size = New System.Drawing.Size(128, 94)
        Me.grpLanguage.TabIndex = 3
        Me.grpLanguage.TabStop = False
        Me.grpLanguage.Text = "Langue"
        '
        'radEnglish
        '
        Me.radEnglish.AutoSize = True
        Me.radEnglish.Location = New System.Drawing.Point(6, 19)
        Me.radEnglish.Name = "radEnglish"
        Me.radEnglish.Size = New System.Drawing.Size(59, 17)
        Me.radEnglish.TabIndex = 1
        Me.radEnglish.TabStop = True
        Me.radEnglish.Text = "English"
        Me.radEnglish.UseVisualStyleBackColor = True
        '
        'radFrench
        '
        Me.radFrench.AutoSize = True
        Me.radFrench.Location = New System.Drawing.Point(7, 42)
        Me.radFrench.Name = "radFrench"
        Me.radFrench.Size = New System.Drawing.Size(65, 17)
        Me.radFrench.TabIndex = 0
        Me.radFrench.TabStop = True
        Me.radFrench.Text = "Francais"
        Me.radFrench.UseVisualStyleBackColor = True
        '
        'btnAccept
        '
        Me.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAccept.Location = New System.Drawing.Point(180, 236)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 23)
        Me.btnAccept.TabIndex = 4
        Me.btnAccept.Text = "Appliquer"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(34, 236)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'grpEntry
        '
        Me.grpEntry.Controls.Add(Me.radFirst)
        Me.grpEntry.Controls.Add(Me.radLast)
        Me.grpEntry.Controls.Add(Me.radQueue)
        Me.grpEntry.Location = New System.Drawing.Point(309, 121)
        Me.grpEntry.Name = "grpEntry"
        Me.grpEntry.Size = New System.Drawing.Size(128, 94)
        Me.grpEntry.TabIndex = 7
        Me.grpEntry.TabStop = False
        Me.grpEntry.Text = "Méthode d'entrée"
        '
        'radFirst
        '
        Me.radFirst.AutoSize = True
        Me.radFirst.Location = New System.Drawing.Point(7, 19)
        Me.radFirst.Name = "radFirst"
        Me.radFirst.Size = New System.Drawing.Size(83, 17)
        Me.radFirst.TabIndex = 2
        Me.radFirst.TabStop = True
        Me.radFirst.Text = "Seul premier"
        Me.radFirst.UseVisualStyleBackColor = True
        '
        'radLast
        '
        Me.radLast.AutoSize = True
        Me.radLast.Location = New System.Drawing.Point(6, 42)
        Me.radLast.Name = "radLast"
        Me.radLast.Size = New System.Drawing.Size(81, 17)
        Me.radLast.TabIndex = 1
        Me.radLast.TabStop = True
        Me.radLast.Text = "Seul dernier"
        Me.radLast.UseVisualStyleBackColor = True
        '
        'radQueue
        '
        Me.radQueue.AutoSize = True
        Me.radQueue.Location = New System.Drawing.Point(7, 65)
        Me.radQueue.Name = "radQueue"
        Me.radQueue.Size = New System.Drawing.Size(51, 17)
        Me.radQueue.TabIndex = 0
        Me.radQueue.TabStop = True
        Me.radQueue.Text = "Queu"
        Me.radQueue.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(325, 222)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 37)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Réinitialise le meilleur score"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'chkWalls
        '
        Me.chkWalls.AutoSize = True
        Me.chkWalls.Location = New System.Drawing.Point(315, 31)
        Me.chkWalls.Name = "chkWalls"
        Me.chkWalls.Size = New System.Drawing.Size(125, 17)
        Me.chkWalls.TabIndex = 10
        Me.chkWalls.Text = "Peu toucher les murs"
        Me.chkWalls.UseVisualStyleBackColor = True
        '
        'chkAI
        '
        Me.chkAI.AutoSize = True
        Me.chkAI.Location = New System.Drawing.Point(315, 54)
        Me.chkAI.Name = "chkAI"
        Me.chkAI.Size = New System.Drawing.Size(111, 17)
        Me.chkAI.TabIndex = 11
        Me.chkAI.Text = "Deuxième serpent"
        Me.chkAI.UseVisualStyleBackColor = True
        '
        'frmOptions
        '
        Me.AcceptButton = Me.btnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(449, 293)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkAI)
        Me.Controls.Add(Me.chkWalls)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.grpEntry)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.grpLanguage)
        Me.Controls.Add(Me.grpPoints)
        Me.Controls.Add(Me.grpSize)
        Me.Controls.Add(Me.grpSpeed)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(465, 309)
        Me.Name = "frmOptions"
        Me.Text = "Options"
        Me.grpSpeed.ResumeLayout(False)
        Me.grpSpeed.PerformLayout()
        Me.grpSize.ResumeLayout(False)
        Me.grpSize.PerformLayout()
        Me.grpPoints.ResumeLayout(False)
        Me.grpPoints.PerformLayout()
        Me.grpLanguage.ResumeLayout(False)
        Me.grpLanguage.PerformLayout()
        Me.grpEntry.ResumeLayout(False)
        Me.grpEntry.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpSpeed As System.Windows.Forms.GroupBox
    Friend WithEvents radFast As System.Windows.Forms.RadioButton
    Friend WithEvents radMedium As System.Windows.Forms.RadioButton
    Friend WithEvents radSlow As System.Windows.Forms.RadioButton
    Friend WithEvents grpSize As System.Windows.Forms.GroupBox
    Friend WithEvents rad100 As System.Windows.Forms.RadioButton
    Friend WithEvents rad50 As System.Windows.Forms.RadioButton
    Friend WithEvents rad25 As System.Windows.Forms.RadioButton
    Friend WithEvents grpPoints As System.Windows.Forms.GroupBox
    Friend WithEvents rad5 As System.Windows.Forms.RadioButton
    Friend WithEvents rad3 As System.Windows.Forms.RadioButton
    Friend WithEvents rad1 As System.Windows.Forms.RadioButton
    Friend WithEvents grpLanguage As System.Windows.Forms.GroupBox
    Friend WithEvents radEnglish As System.Windows.Forms.RadioButton
    Friend WithEvents radFrench As System.Windows.Forms.RadioButton
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents grpEntry As System.Windows.Forms.GroupBox
    Friend WithEvents radLast As System.Windows.Forms.RadioButton
    Friend WithEvents radQueue As System.Windows.Forms.RadioButton
    Friend WithEvents radFirst As System.Windows.Forms.RadioButton
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents chkWalls As System.Windows.Forms.CheckBox
    Friend WithEvents chkAI As System.Windows.Forms.CheckBox
End Class
