Public Class frmGame

    '" —″— " Signifie une répétition (Le "ditto mark")
    'Ex. plustôt que répéter la notation des déclarations "If" pour plusieurs similaires conditions
    'Une déclération seul va avoir une notation, et les autres aurons " —″— "

    'Fonction à chercher un nombre aléatoire dans une gamme
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function
    'Crédit à Dan Tao
    'https://stackoverflow.com/a/2677819

    'Initialiser les options (Largement utiliser en fonction avec frmOptions)

    Public Function getIdealOrder()
        Dim cpu As snake = Me.cpu
        Dim goal As Point = Me.food

        Dim idealOrder(3) As ArrowDirection
        Dim DistanceX As Integer = goal.X - cpu.location.X
        Dim DistanceY As Integer = goal.Y - cpu.location.Y
        Dim nextPoint As Point

        Dim bestDirectionX(1) As ArrowDirection
        If Math.Abs(DistanceX - 1) > Math.Abs(DistanceX) Then
            bestDirectionX(0) = ArrowDirection.Left
            bestDirectionX(1) = ArrowDirection.Right
        Else
            bestDirectionX(0) = ArrowDirection.Right
            bestDirectionX(1) = ArrowDirection.Left
        End If
        Dim bestDirectionY(1) As ArrowDirection
        If Math.Abs(DistanceY - 1) > Math.Abs(DistanceY) Then
            bestDirectionY(0) = ArrowDirection.Up
            bestDirectionY(1) = ArrowDirection.Down
        Else
            bestDirectionY(0) = ArrowDirection.Down
            bestDirectionY(1) = ArrowDirection.Up
        End If

        If Math.Abs(DistanceX) >= Math.Abs(DistanceY) Then
            idealOrder(0) = bestDirectionX(0)
            idealOrder(1) = bestDirectionY(0)
            idealOrder(2) = bestDirectionX(1)
            idealOrder(3) = bestDirectionY(1)
        Else
            idealOrder(0) = bestDirectionY(0)
            idealOrder(1) = bestDirectionX(0)
            idealOrder(2) = bestDirectionY(1)
            idealOrder(3) = bestDirectionX(1)
        End If
        nextPoint = cpu.getNextPoint(cpu.direction)
        If Math.Abs(DistanceX) + Math.Abs(DistanceY) > Math.Abs(goal.X - nextPoint.X) + Math.Abs(goal.Y - nextPoint.Y) Then
            idealOrder = arrayTools.removeAt(idealOrder, Array.IndexOf(idealOrder, cpu.direction))
            idealOrder = arrayTools.insertAt(idealOrder, 0, cpu.direction)
        End If

        For i As Integer = idealOrder.Length - 1 To 0 Step -1
            nextPoint = cpu.getNextPoint(idealOrder(i))
            If nextPoint = user.location Or user.segments.Contains(nextPoint) Or cpu.segments.Contains(nextPoint) Or
                nextPoint.X < 0 Or nextPoint.X >= gridLength Or nextPoint.Y < 0 Or nextPoint.Y >= gridLength Then
                idealOrder = arrayTools.removeAt(idealOrder, i)
            End If
        Next
        Return idealOrder
    End Function

    Public language As Integer
    Public speed As Integer
    Public grid As Integer
    Public points As Integer
    Public walls As Boolean
    Public entry As Integer
    Public ai As Boolean
    'Initialiser autres variables globale
    Public highscore As Integer
    Public cpu As New snake
    Private score As Integer
    Private squareLength As Integer
    Private gridLength As Integer
    Private food As New Point
    Private user As New snake
    Private nextDirection() As ArrowDirection
    Private startScreen As Boolean

    Private Sub optionsUpdate()
        'Sous-Programme pour mettre à jour le texte, réinitialiser le jeux et appliquer des changement en options

        '
        'Mettre à jour le texte globalement
        '

        'Trouver le texte respectif pour la grille
        Dim strGrid As String = ""
        Select Case grid
            Case 0
                strGrid = "25x25"
            Case 1
                strGrid = "50x50"
            Case 2
                strGrid = "100x100"
        End Select
        'Trouver le texte respectif pour le taux d'augmentation (La longueur ajouter au serpent à chaque cercle consommé)
        Dim strPoints As String = ""
        Select Case points
            Case 0
                strPoints = "1"
            Case 1
                strPoints = "3"
            Case 2
                strPoints = "5"
        End Select

        If language = 0 Then
            'Si la langue est anglais

            'Trouver le texte respectif pour la rapidité du serpent
            Dim strSpeed As String = ""
            Select Case speed
                Case 0
                    strSpeed = "Slow"
                Case 1
                    strSpeed = "Medium"
                Case 2
                    strSpeed = "Fast"
            End Select
            'Mettre à jour le texte globalement
            lblHelp.Text = "Catch the circles with your snake to score, but make sure not to hit yourself or the walls." & vbCrLf & vbCrLf & "Controls:" & vbCrLf & "Arrow keys or WASD: Control the snake" & vbCrLf & vbCrLf & "Space bar: Pause the game" & vbCrLf & vbCrLf & "O: Change options"
            lblParameters.Text = "Click here to change the options of the game." & vbCrLf & vbCrLf & "Current options:" & vbCrLf & vbCrLf & "Speed: " & strSpeed & vbCrLf & "Grid size: " & strGrid & vbCrLf & "Points per circle: " & strPoints
            frmOptions.grpLanguage.Text = "Language"
            frmOptions.grpSpeed.Text = "Speed"
            frmOptions.grpSize.Text = "Grid size"
            frmOptions.grpPoints.Text = "Points per circle"
            frmOptions.grpEntry.Text = "Entry method"
            frmOptions.radSlow.Text = "Slow"
            frmOptions.radMedium.Text = "Medium"
            frmOptions.radFast.Text = "Fast"
            frmOptions.radFirst.Text = "First only"
            frmOptions.radLast.Text = "Last only"
            frmOptions.radQueue.Text = "Queue"
            frmOptions.btnAccept.Text = "Accept"
            frmOptions.btnCancel.Text = "Cancel"
            frmOptions.btnReset.Text = "Reset the highscore"
            frmOptions.chkWalls.Text = "Can touch walls"
            frmOptions.chkAI.Text = "Second snake"
        ElseIf language = 1 Then
            'Si la langue est français

            'Trouve le texte respectif pour la rapidité
            Dim strSpeed As String = ""
            Select Case speed
                Case 0
                    strSpeed = "Lent"
                Case 1
                    strSpeed = "Moyen"
                Case 2
                    strSpeed = "Rapide"
            End Select
            'Mettre à jour le texte globalement
            lblHelp.Text = "Attrape les cercles rouges pour améliorer ton score. Mais fais attention à ne pas frapper les murs, ou le serpent." & vbCrLf & vbCrLf & "Contrôles:" & vbCrLf & "Clés flèches ou WASD: Contrôle le serpent" & vbCrLf & vbCrLf & "Espace: Pauser le jeu" & vbCrLf & vbCrLf & "O: Changer les paramètres"
            lblParameters.Text = "Clique ici pour changer les paramètres du jeu." & vbCrLf & vbCrLf & "Paramètres actuels:" & vbCrLf & vbCrLf & "Rapidité: " & strSpeed & vbCrLf & "Largeur: " & strGrid & vbCrLf & "Points par cercle: " & strPoints
            frmOptions.grpLanguage.Text = "Langue"
            frmOptions.grpSpeed.Text = "Rapidité"
            frmOptions.grpSize.Text = "Largeur de la grille"
            frmOptions.grpPoints.Text = "Points par cercle"
            frmOptions.grpEntry.Text = "Méthode d'entrée"
            frmOptions.radSlow.Text = "Lent"
            frmOptions.radMedium.Text = "Moyen"
            frmOptions.radFast.Text = "Rapide"
            frmOptions.radFirst.Text = "Seul premier"
            frmOptions.radLast.Text = "Seul dernier"
            frmOptions.radQueue.Text = "Queue"
            frmOptions.btnAccept.Text = "Appliquer"
            frmOptions.btnCancel.Text = "Annuler"
            frmOptions.btnReset.Text = "Réinitialise le meilleur score"
            frmOptions.chkWalls.Text = "Peu toucher les murs"
            frmOptions.chkAI.Text = "Deuxième serpent"
        End If

        '
        'Fin de la mise à jour du texte
        '

        'Mettre à jour l'intervale du minuteur
        Select Case speed
            Case 0
                tmrTick.Interval = 130
            Case 1
                tmrTick.Interval = 100
            Case 2
                tmrTick.Interval = 65
        End Select

        'Mettre à jour les spécifique de la grille
        Select Case grid
            Case 0
                'Mettre à jour la largeur de la boîte d'image (Ex. 625 par 625 pixels)
                picBoard.Height = 625
                picBoard.Width = 625
                'Mettre à jour la largeur de chaque case (Ex. 25 par 25 pixels)
                squareLength = 25
                'Mettre à jour le nombre de case dans la grille (Ex. 25 par 25 cases)
                gridLength = 25
            Case 1
                '—″—
                picBoard.Height = 750
                picBoard.Width = 750
                squareLength = 15
                gridLength = 50
            Case 2
                '—″—
                picBoard.Height = 700
                picBoard.Width = 700
                squareLength = 7
                gridLength = 100
        End Select
        'Mettre à jour la largeur de la forme
        Me.MinimumSize = New Size(picBoard.Width + 230, picBoard.Height + 63)
        Me.MaximumSize = New Size(picBoard.Width + 230, picBoard.Height + 63)
        'Mettre à jour la position (X) de tout les controles (18 pixels à la droite de la boîte d'image)
        For Each i As Control In Me.Controls
            If Not i.Equals(picBoard) Then
                i.Location = New Point(picBoard.Width + 18, i.Location.Y)
            End If
        Next

        'Réinitialiser le serpent
        user.length = 0
        user.location = New Point(1, 1)
        user.segments = {}
        cpu.length = 0
        cpu.location = New Point(gridLength - 2, gridLength - 2)
        cpu.segments = {}
        nextDirection = {}
        'Réinitialiser les étiquette de score, meilleure score et de longueur"
        lblScore.Text = "Score: 0"
        If language = 0 Then
            'Anglais
            lblHighscore.Text = "Highscore: " & highscore
            lblLength.Text = "Length: 1"
        ElseIf language = 1 Then
            'Francais
            lblHighscore.Text = "Meilleure score: " & highscore
            lblLength.Text = "Longueur: 1"
        End If
        'Placer un nouveau cercle
        food = New Point(GetRandom(0, gridLength), GetRandom(0, gridLength))
        While food = user.location
            food = New Point(GetRandom(0, gridLength), GetRandom(0, gridLength))
        End While

        If startScreen = True Then
            user.location = New Point(-1, -1)
        End If

        'Rafraîchir la boîte d'image
        picBoard.Refresh()
    End Sub

    Private Sub frmGame_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Trouve le path du fichier de démarrage
        Dim resPath As String = System.IO.Path.GetFullPath(Application.StartupPath) & "\"
        'Suprimmer le meilleur score précédent
        System.IO.File.Delete(resPath & "Highscore.txt")
        'Créer un nouveau meilleur score et le rendre caché
        FileOpen(1, resPath & "Highscore.txt", OpenMode.Binary)
        FilePut(1, highscore.ToString)
        FileClose(1)
        System.IO.File.SetAttributes(resPath & "Highscore.txt", IO.FileAttributes.Hidden)
    End Sub

    Private Sub frmGame_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'Trouver quelle clé a été appuyé
        Select Case e.KeyCode
            Case Keys.Left, Keys.A
                'Si c'était une demmande d'aller la gauche (flèche à gauche ou A)
                If user.direction <> ArrowDirection.Right Or user.length = 0 Or (nextDirection.Length > 0 And entry = 2) Then
                    'Et la direction n'est pas opposé à celle en ce moment,
                    'Ou la longueur du serpent est 0 (Seul la tête)
                    'Ou il y a une demmande précédente et la méthode d'entrée est de faire une queue
                    If entry = 0 Then
                        'Si la méthode d'entrée est de compléter seul la première demmande
                        If nextDirection.Length = 0 Then
                            'Vérifier si il n'y a pas d'autre demmandes, et si oui ajouter la demmande à la queue
                            ReDim nextDirection(0)
                            nextDirection(0) = ArrowDirection.Left
                        End If
                    ElseIf entry = 1 Then
                        'Si non si la méthode d'entrée est de compléter seul la dernière demmande
                        'Change la queue à seulement contenir cette dernière demmande
                        ReDim nextDirection(0)
                        nextDirection(0) = ArrowDirection.Left
                    ElseIf entry = 2 Then
                        'Si non si la méthode d'entrée est de compléter une demmande après l'autre
                        If nextDirection.Length > 0 Then
                            'Si il y a une demmande précédente
                            'Vérifier si la demmande précédente est dans le sens opposé ou la même direction
                            If nextDirection(nextDirection.Length - 1) <> (ArrowDirection.Right Or ArrowDirection.Left) Then
                                'Si non ajouter la demmande à la fin de la queue
                                ReDim Preserve nextDirection(nextDirection.Length)
                                nextDirection(nextDirection.Length - 1) = ArrowDirection.Left
                            End If
                        Else
                            'Si il n'y a pas de demmande précédente
                            'Ajouter la demmande à la queue
                            ReDim Preserve nextDirection(nextDirection.Length)
                            nextDirection(nextDirection.Length - 1) = ArrowDirection.Left
                        End If
                    End If
                    e.Handled = True
                End If

            Case Keys.Right, Keys.D
                'Pour la droite
                '—″—
                If user.direction <> ArrowDirection.Left Or user.length = 0 Or (nextDirection.Length > 0 And entry = 2) Then
                    If entry = 0 Then
                        If nextDirection.Length = 0 Then
                            ReDim nextDirection(0)
                            nextDirection(0) = ArrowDirection.Right
                        End If
                    ElseIf entry = 1 Then
                        ReDim nextDirection(0)
                        nextDirection(0) = ArrowDirection.Right
                    ElseIf entry = 2 Then
                        If nextDirection.Length > 0 Then
                            If nextDirection(nextDirection.Length - 1) <> (ArrowDirection.Left Or ArrowDirection.Right) Then
                                ReDim Preserve nextDirection(nextDirection.Length)
                                nextDirection(nextDirection.Length - 1) = ArrowDirection.Right
                            End If
                        Else
                            ReDim Preserve nextDirection(nextDirection.Length)
                            nextDirection(nextDirection.Length - 1) = ArrowDirection.Right
                        End If
                    End If
                    e.Handled = True
                End If

            Case Keys.Up, Keys.W
                'Pour le haut
                '—″—
                If user.direction <> ArrowDirection.Down Or user.length = 0 Or (nextDirection.Length > 0 And entry = 2) Then
                    If entry = 0 Then
                        If nextDirection.Length = 0 Then
                            ReDim nextDirection(0)
                            nextDirection(0) = ArrowDirection.Up
                        End If
                    ElseIf entry = 1 Then
                        ReDim nextDirection(0)
                        nextDirection(0) = ArrowDirection.Up
                    ElseIf entry = 2 Then
                        If nextDirection.Length > 0 Then
                            If nextDirection(nextDirection.Length - 1) <> (ArrowDirection.Down Or ArrowDirection.Up) Then
                                ReDim Preserve nextDirection(nextDirection.Length)
                                nextDirection(nextDirection.Length - 1) = ArrowDirection.Up
                            End If
                        Else
                            ReDim Preserve nextDirection(nextDirection.Length)
                            nextDirection(nextDirection.Length - 1) = ArrowDirection.Up
                        End If
                    End If
                    e.Handled = True
                End If

            Case Keys.Down, Keys.S
                'Pour le bas
                '—″—
                If user.direction <> ArrowDirection.Up Or user.length = 0 Or (nextDirection.Length > 0 And entry = 2) Then
                    If entry = 0 Then
                        If nextDirection.Length = 0 Then
                            ReDim nextDirection(0)
                            nextDirection(0) = ArrowDirection.Down
                        End If
                    ElseIf entry = 1 Then
                        ReDim nextDirection(0)
                        nextDirection(0) = ArrowDirection.Down
                    ElseIf entry = 2 Then
                        If nextDirection.Length > 0 Then
                            If nextDirection(nextDirection.Length - 1) <> (ArrowDirection.Up Or ArrowDirection.Down) Then
                                ReDim Preserve nextDirection(nextDirection.Length)
                                nextDirection(nextDirection.Length - 1) = ArrowDirection.Down
                            End If
                        Else
                            ReDim Preserve nextDirection(nextDirection.Length)
                            nextDirection(nextDirection.Length - 1) = ArrowDirection.Down
                        End If
                    End If
                    e.Handled = True
                End If

            Case Keys.Space
                'Si la clé était l'espace
                'Arrête le minuteur jusqu'à le dialogue est fermé
                tmrTick.Stop()
                MessageBox.Show("Game paused", "")
                tmrTick.Start()

            Case Keys.O
                'Si la clé était l'O
                'Arrête le minuteur et affiche le dialogue d'option, puis mettre à jour les options
                tmrTick.Stop()
                frmOptions.ShowDialog()
                optionsUpdate()
        End Select

        'Si le minuteur n'était pas commencé
        If tmrTick.Enabled = False And e.Handled = True Then
            'D'abord commence le (Utiliser après la première demmande de la session est faite)
            tmrTick.Start()
        End If
    End Sub

    Private Sub frmGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Quand le jeu est initialisé
        'Trouve la langue de défaut
        If System.Globalization.CultureInfo.CurrentCulture.ThreeLetterISOLanguageName() = "fra" Then
            language = 1
        Else
            language = 0
        End If
        'Utilise les options de défaut
        ai = False
        cpu.length = 0
        speed = 1
        grid = 0
        points = 0
        walls = True
        entry = 2
        highscore = 0

        'Trouve le path du fichier de resources
        Dim resPath As String = System.IO.Path.GetFullPath(Application.StartupPath) & "\"
        'Si il y a un enregistrement du meilleur score
        If System.IO.File.Exists(resPath & "Highscore.txt") = True Then
            'Mettre à jour le meilleur score dans le programme
            Dim text As String = System.IO.File.ReadAllText(resPath & "Highscore.txt")
            highscore = Integer.Parse(text)
        End If

        'Mettre à jour le jeux, options, texte, etc.
        optionsUpdate()
    End Sub

    Private Sub picBoard_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picBoard.Paint
        'Dessiner la grille, le serpent et les cercles

        'Créer une grille quadrillé
        Dim tempX As Integer = 0
        Dim tempY As Integer = 0
        While tempX <= picBoard.Width
            tempY = 0
            While tempY <= picBoard.Height
                If tempX Mod (squareLength * 2) = 0 Then
                    If tempY Mod (squareLength * 2) = 0 Then
                        e.Graphics.FillRectangle(Brushes.ForestGreen, tempX, tempY, squareLength, squareLength)
                    Else
                        e.Graphics.FillRectangle(Brushes.Green, tempX, tempY, squareLength, squareLength)
                    End If
                Else
                    If tempY Mod (squareLength * 2) = 0 Then
                        e.Graphics.FillRectangle(Brushes.Green, tempX, tempY, squareLength, squareLength)
                    Else
                        e.Graphics.FillRectangle(Brushes.ForestGreen, tempX, tempY, squareLength, squareLength)
                    End If
                End If
                tempY += squareLength
            End While
            tempX += squareLength
        End While

        'Trouver la largeur des marges du serpent et des cercle
        Dim margin As Integer = 0
        'Elle est respectif à la largeur de la grille (La plus grande la grille, la plus pettite la marge)
        Select Case grid
            Case 0
                margin = 2
            Case 1
                margin = 1
            Case 2
                margin = 0
        End Select

        If startScreen = False Then
            'Dessiner la tête du serpent (Colorié en or)
            e.Graphics.FillRectangle(Brushes.Gold, user.location.X * squareLength + margin, user.location.Y * squareLength + margin, squareLength - margin * 2, squareLength - margin * 2)
            'Dessiner chaque segment du serpent (Colorié en jaune)
            For Each i As Point In user.segments
                e.Graphics.FillRectangle(Brushes.Yellow, i.X * squareLength + margin, i.Y * squareLength + margin, squareLength - margin * 2, squareLength - margin * 2)
            Next
        End If
        'Si il y a un deuxième serpent
        If ai = True Or startScreen = True Then
            'Dessiner la tête du serpent (Colorié en bleu foncé)
            e.Graphics.FillRectangle(Brushes.DarkBlue, cpu.location.X * squareLength + margin, cpu.location.Y * squareLength + margin, squareLength - margin * 2, squareLength - margin * 2)
            'Dessiner chaque segment du serpent (Colorié en bleu)
            For Each i As Point In cpu.segments
                e.Graphics.FillRectangle(Brushes.Blue, i.X * squareLength + margin, i.Y * squareLength + margin, squareLength - margin * 2, squareLength - margin * 2)
            Next
        End If
        'Dessiner le cercle (Colorié en rouge)
        e.Graphics.FillEllipse(Brushes.Red, food.X * squareLength + margin, food.Y * squareLength + margin, squareLength - margin * 2, squareLength - margin * 2)
    End Sub

    Private Sub tmrTick_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTick.Tick
        'Chaque tick dans le jeu

        If startScreen = True And tmrTick.Interval <> 100 Then
            tmrTick.Interval = 100
            optionsUpdate()
        End If

        'Initialiser une variable pour vérifier si l'utilisateur a perdu
        Dim gameover As Boolean = False

        If startScreen = False Then
            'Voir si le serpent est à la longueur désiré (Et plus long que 0)
            If user.segments.Length > 0 And user.segments.Length = user.length Then
                'Si oui enleve le dernier segment du serpent
                user.segments = arrayTools.removeAt(user.segments, 0)
            End If
            'Si le serpent est ensuite pas de la longueur désiré
            If user.segments.Length < user.length Then
                'Ajoute un segment à la position qui vien juste de quitté
                ReDim Preserve user.segments(user.segments.Length)
                user.segments(user.segments.Length - 1) = user.location
            End If
            'Si le serpent est supposé de changer de direction
            If nextDirection.Length > 0 Then
                'Change le serpent à la direction désiré et enleve la première demmande de la queue (Celle just complêté)
                user.direction = nextDirection(0)
                nextDirection = arrayTools.removeAt(nextDirection, 0)
            End If
            'Cherche le nouveau point du serpent
            user.location = user.getNextPoint(user.direction)
            'Tester si le serpent est maintenan sur un cercle
            If user.location = food Then
                'Si oui, augmenter sa longueur respectivement
                Select Case points
                    Case 0
                        user.length += 1
                    Case 1
                        user.length += 3
                    Case 2
                        user.length += 5
                End Select
                'Et donne lui un point
                score += 1
                'Puis si le score est plus grand que le meilleur score, mettre à jour le meilleur score
                If score > highscore Then
                    highscore = score
                End If
                'Mettre à jour les étiquettes de score
                lblScore.Text = "Score: " & score
                If language = 0 Then
                    'Anglais
                    lblHighscore.Text = "Highscore: " & highscore
                    lblLength.Text = "Length: " & user.length + 1
                ElseIf language = 1 Then
                    'Francais
                    lblHighscore.Text = "Meilleure score: " & highscore
                    lblLength.Text = "Longueur: " & user.length + 1
                End If
                'Puis creér une nouvelle position pour le cercle jusqu'à c'est sur un case non occupé
                While food = user.location Or user.segments.Contains(food) Or food = cpu.location Or cpu.segments.Contains(food)
                    food = New Point(GetRandom(0, gridLength), GetRandom(0, gridLength))
                End While
            End If

            'Test si le serpent c'est frappé
            For Each i As Point In user.segments
                If user.location = i Then
                    'Si oui l'utilisateur pert
                    gameover = True
                End If
            Next
            'Test si le serpent a frappé un mur
            If user.location.X < 0 Or user.location.X >= gridLength Or user.location.Y < 0 Or user.location.Y >= gridLength Then
                If walls = True Then
                    'Si les collisions avec un mur ne son pas accepté
                    'L'utilisateur pert le jeu
                    gameover = True
                ElseIf walls = False Then
                    'Si non la tête du serpent revient de l'autre coté
                    If user.location.X >= gridLength Then
                        user.location = New Point(0, user.location.Y)
                    ElseIf user.location.X < 0 Then
                        user.location = New Point(gridLength, user.location.Y)
                    ElseIf user.location.Y >= gridLength Then
                        user.location = New Point(user.location.X, 0)
                    ElseIf user.location.Y < 0 Then
                        user.location = New Point(user.location.X, gridLength)
                    End If
                End If
            End If
        End If

        If ai = True Or startScreen = True Then
            'Voir si le serpent est à la longueur désiré (Et plus long que 0)
            If cpu.segments.Length > 0 And cpu.segments.Length = cpu.length Then
                'Si oui enleve le dernier segment du serpent
                cpu.segments = arrayTools.removeAt(cpu.segments, 0)
            End If
            'Si le serpent est ensuite pas de la longueur désiré
            If cpu.segments.Length < cpu.length Then
                'Ajoute un segment à la position qui vien juste de quitté
                ReDim Preserve cpu.segments(cpu.segments.Length)
                cpu.segments(cpu.segments.Length - 1) = cpu.location
            End If
            Dim ideals() As ArrowDirection = getIdealOrder()
            If ideals.Length = 0 Then
                gameover = True
            Else
                cpu.direction = ideals(0)
                cpu.location = cpu.getNextPoint(cpu.direction)
            End If
            If cpu.location = food Then
                If startScreen = False Then
                    Select Case points
                        Case 0
                            cpu.length += 1
                        Case 1
                            cpu.length += 3
                        Case 2
                            cpu.length += 5
                    End Select
                Else
                    cpu.length += 5
                End If
                While food = user.location Or user.segments.Contains(food) Or food = cpu.location Or cpu.segments.Contains(food)
                    food = New Point(GetRandom(0, gridLength), GetRandom(0, gridLength))
                End While
            End If
        End If

        'Finallement test si l'utilisateur a perdu le jeu se tick
        If gameover = True Then
            If startScreen = True Then
                tmrTick.Interval = 1500
            Else
                'Si oui arrêter le minuteur, montre un dialogue de perte, et réinitialiser la grille
                tmrTick.Stop()
                MessageBox.Show("Game over!", "")
                optionsUpdate()
            End If
        Else
            'Si non, mettre à jour la grille
            picBoard.Refresh()
        End If
        'console.writeLine()
    End Sub

    Private Sub lblParametres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblParameters.Click
        'Arrête le minuteur et montrer le dialogue d'options, puis appliquer les options
        tmrTick.Stop()
        frmOptions.ShowDialog()
        optionsUpdate()
    End Sub

    Private Sub frmGame_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        startScreen = True
        tmrTick.Start()
        'Montrer le bienvenu
        If language = 0 Then
            MessageBox.Show("Welcome to snake!", "Welcome")
        ElseIf language = 1 Then
            MessageBox.Show("Bienvenu à snake!", "Bienvenu")
        End If
        tmrTick.Stop()
        startScreen = False
        optionsUpdate()
    End Sub
End Class

Public Class snake
    'Classe de serpent

    'Propriétés publique de la direction, longueur, position de la tête, et position de chaque segment
    Public Property direction As ArrowDirection
    Public Property length As Integer
    Public Property location As Point
    Public segments() As Point

    Public Function getNextPoint(ByVal direction As ArrowDirection)
        Dim nextpoint
        Select Case direction
            Case ArrowDirection.Left
                nextpoint = New Point(Me.location.X - 1, Me.location.Y)
            Case ArrowDirection.Right
                nextpoint = New Point(Me.location.X + 1, Me.location.Y)
            Case ArrowDirection.Up
                nextpoint = New Point(Me.location.X, Me.location.Y - 1)
            Case ArrowDirection.Down
                nextpoint = New Point(Me.location.X, Me.location.Y + 1)
            Case Else
                nextpoint = Me.location
        End Select
        Return nextpoint
    End Function

End Class

'Outils d'array
Public Class arrayTools

    'Tester si un array contient une valeur string dans n'importe quelle objet
    Public Shared Function containsAnywhere(ByVal value As String, ByVal ParamArray startarray() As String) As Boolean
        For Each i As String In startarray
            Try
                If i.Contains(value) Then
                    Return True
                End If
            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try
        Next
        Return False
    End Function

    'Trouver l'index du premier objet qui contient une valeur string dans un array
    Public Shared Function arrayIndex(ByVal value As String, ByVal ParamArray startarray() As String) As Integer
        For i As Integer = 0 To startarray.Length - 1
            Try
                If startarray(i).Contains(value) Then
                    Return i
                End If
            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try
        Next
        Return -1
    End Function

    'Retourne un array moins l'objet indexé
    Public Shared Function removeAt(Of T)(ByVal startArray As T(), ByVal index As Integer) As Array
        If startArray.Length >= 1 And index >= 0 And index < startArray.Length Then
            For i As Integer = 0 To startArray.Length - 1
                If i > index Then
                    startArray(i - 1) = startArray(i)
                End If
            Next
            ReDim Preserve startArray(startArray.Length - 2)
        End If
        Return startArray
    End Function

    'Retourne un array plus un nouvel objet spécifié à l'index
    Public Shared Function insertAt(Of T)(ByVal startArray As T(), ByVal index As Integer, ByVal item As T)
        If startArray.Length >= 1 And index >= 0 And index < startArray.Length Then
            ReDim Preserve startArray(startArray.Length)
            For i As Integer = startArray.Length - 1 To 0 Step -1
                If i > index Then
                    startArray(i) = startArray(i - 1)
                ElseIf i = index Then
                    startArray(i) = item
                End If
            Next
        End If
        Return startArray
    End Function

    'Montre la valeur de chaque objet dans un array pour déboguer
    Public Shared Sub debugPrint(ByVal array As Array)
        For Each item As Object In array
            MessageBox.Show(item.ToString)
        Next
    End Sub
End Class