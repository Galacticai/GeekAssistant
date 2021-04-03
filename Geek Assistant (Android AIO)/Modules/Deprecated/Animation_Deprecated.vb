'Module Animation__Deprecated_USE_Transtion_instead

'    Dim WithEvents AnimationTimer As New Timer With {
'        .Interval = 10
'    }
'    Private type As String
'    Private posElement, posEnd As Double

'    Private time, posStart, distance, dRemaining, dPassed As Double
'    Public Sub Run(_type As String, ByRef _posElement As Double, _posEnd As Double)
'        type = _type
'        posElement = _posElement
'        posEnd = _posEnd
'        'Set starting pos to be first pos of element
'        posStart = posElement
'        'Get distance needed to move
'        distance = posEnd - posStart
'        'Set time to 0 to start
'        time = 0
'        AnimationTimer.Start()
'    End Sub

'    Private Sub AnimationTimer_Tick() Handles AnimationTimer.Tick
'        If posElement = posEnd Then AnimationTimer.Stop()
'        DoAnimation()

'        'If Element = Ending Then AnimationTimer.Stop()
'    End Sub
'    Public Sub DoAnimation()
'        'While posElement <> posEnd
'        'Update passed & remaining distance
'        dRemaining = posEnd - posElement
'        dPassed = posElement - posStart
'        time += 1 'increment time
'        Select Case type
'            Case "linear"
'                Throw New NotImplementedException 'posElement = XFunction.sinSmoothStart(time, distance)
'            Case "smoothStart"
'                posElement = posStart + sinSmoothStart(time, distance)
'            Case "smoothEnd"
'                posElement = posStart + sinSmoothEnd(time, distance)
'            Case "smoothStartEnd"
'                posElement = posStart + cosSmoothStartEnd(time, distance)

'        End Select
'        'End While

'        '#DEBUG#
'        LogAppendText("#DEBUG# : " & time.ToString & " " & posElement.ToString, 1)

'        Dim lastFrameTime As Integer
'        Dim FPSTarget As Integer
'        'we need to get to a point where cpu speed doesn't matter and u get a delta time which will be added to the float u are using as a driver to the animation
'        Dim timeToWait As Integer = FPSTarget - (Environment.TickCount - lastFrameTime)
'        'getting time To wait Is because every 1000 ms we only need say 30 frames, so we divide the 1000 by equal parts by our frame rate (30) And the time To wait Is basically the interval between these parts, u have To calculate this In the Loop since everything may vary
'        If timeToWait > 0 And timeToWait <= FPSTarget Then Threading.Thread.Sleep(timeToWait)  'Here we Do the waiting .u can use a While Loop For this but delay Is better If there Is a built In one
'        Dim deltaTime As Double = (Environment.TickCount - lastFrameTime) / 1000  'getting delta time, the difference In time between the last frame And our exact current time (/1000) so it's in seconds
'        lastFrameTime = Environment.TickCount ' then setting lastframetime so that next iteration we get this value (of the old iteration when we're in the new iteration)

'    End Sub

'End Module
