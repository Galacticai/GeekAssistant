
Module MathFunctions

    ''' <summary>
    ''' Generate a random integer between <c>min</c> and <c>max</c> paremeters
    ''' </summary>
    ''' <param name="min">Minimum range for output</param>
    ''' <param name="max">Maximum range for output</param>
    ''' <returns><c>min</c> &lt; (Integer) &lt; <c>max</c></returns>
    Public Function math_RandomInt(min As Integer, max As Integer)
        Randomize()
        Return CInt(Math.Floor((max - min + 1) * Rnd())) + min
    End Function

    ''' <summary>
    ''' Force input variable into the range of min and max
    ''' </summary>
    ''' <param name="input">Value to process</param>
    ''' <param name="min">Minimum floor</param>
    ''' <param name="max">Maximum ceiling</param>
    ''' <returns><list type="bullet">
    ''' <item>Returns <c>max</c> — if input &gt; max</item>
    ''' <item>Returns <c>min</c> — if <c>input</c> &lt; <c>min</c></item>
    ''' <item>Returns <c>input</c> — if it is already in the specified range</item>
    ''' </list></returns> 
    Public Function math_ForceInRange(input As Double, min As Double, max As Double)
        If input > max Then Return max
        If input < min Then Return min
        Return input
    End Function


    ''' <summary>
    ''' Chooses a random object from input array
    ''' </summary>
    ''' <param name="arr">Input Object array</param>
    ''' <returns>Random object from input array</returns>
    Public Function math_RandomObjectFromArr(arr As Object()) As String
        Return arr(math_RandomInt(0, arr.Count - 1)) '-1 because it starts from 0
    End Function

    ' s    .- 
    ' |   /
    ' | _-
    ' 0一一一s
    ''' <summary>
    ''' <list>
    ''' <item>Puts the value on a curve function</item> 
    ''' <c> 
    ''' <item>‏‏‎s‏‏‎ ‎‏‏‎ ‎‏‏‎‏‏‎ ‎ ‏‏‎ ‎‎‏‏‎ ‎.-  </item>
    ''' <item>‏‏‎:‏‏‎ ‎‏‏‎ ‎‏‏‎‏‏‎ ‎ ‎/    </item>
    ''' <item>‏‏‎: ‎_-     </item>
    ''' <item>‏‏‎‎0 . . . . s </item>
    ''' </c>
    ''' </list>
    ''' </summary>
    ''' <param name="x">input</param>
    ''' <param name="scale">Size of the wave (Half wave)</param>
    ''' <returns>Returns <c>f(x)</c></returns> 
    Public Function math_cosSmoothStartEnd(x As Double, scale As Double)
        math_ForceInRange(x, 0, scale) 'force x between 0一一一s
        Return scale * ((-Math.Cos(x * Math.PI) / (2 * scale)) + 1 / 2)
    End Function

    ' s -.
    ' |   \
    ' |    -_
    ' 0一一一s
    ''' <summary>
    ''' <list>
    ''' <item>Puts the value on a curve function</item> 
    ''' <c> 
    ''' <item>‏‏‎‎s‏‏‎ ‎‎-.      </item>
    ''' <item>‏‏‎:‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎\    </item>
    ''' <item>‏‏‎:‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎-_</item>
    ''' <item>‏‏‎0 . . . . s </item>
    ''' </c>
    ''' </list>
    ''' </summary>
    ''' <param name="x">input</param>
    ''' <param name="scale">Size of the wave (Half wave)</param>
    ''' <returns>Returns <c>f(x)</c></returns>  
    Private Function math_sinSmoothEnd_01(x As Double, scale As Double)
        math_ForceInRange(x, 0, scale) 'force x between 0一一一s
        Return scale * ((Math.Sin((x * Math.PI) + (Math.PI / 2)) / 2) + (1 / 2))
    End Function

    ' s \
    ' |  \
    ' |   *._
    ' 0一一一s
    ''' <summary>
    ''' <list>
    ''' <item>Puts the value on a curve function</item> 
    ''' <c> 
    ''' <item>‏‏‎‎s‏‏‎ ‎\</item>
    ''' <item>‏‏‎:‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎\</item>
    ''' <item>‏‏‎:‏‏‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎*._</item>
    ''' <item>‏‏‎0 . . . . s </item>
    ''' </c>
    ''' </list>
    ''' </summary>
    ''' <param name="x">input</param>
    ''' <param name="scale">Size of the wave (Half wave)</param>
    ''' <returns>Returns <c>f(x)</c></returns>   
    Public Function math_sinSmoothEnd(x As Double, scale As Double)
        math_ForceInRange(x, 0, scale) 'force x between 0一一一s
        Return scale * (-Math.Sin(x * (Math.PI / 2) / scale) + 1)
    End Function

    ' s --.
    ' |    \
    ' |     \
    ' 0一一一s
    ''' <summary>
    ''' <list>
    ''' <item>Puts the value on a curve function</item> 
    ''' <c> 
    ''' <item>‏‏‎‎s‏‏‎‏‏‎ ‎--.</item>
    ''' <item>‏‏‎:‏‏‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎\</item>
    ''' <item>‏‏‎:‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎\</item>
    ''' <item>‏‏‎0 . . . . s </item>
    ''' </c>
    ''' </list>
    ''' </summary>
    ''' <param name="x">input</param>
    ''' <param name="scale">Size of the wave (Half wave)</param>
    ''' <returns>Returns <c>f(x)</c></returns>   
    Public Function math_sinSmoothStart(x As Double, scale As Double)
        math_ForceInRange(x, 0, scale) 'force x between 0一一一s
        Return scale * (Math.Sin((x * (Math.PI / (2 * scale))) + (Math.PI / 2)))
    End Function


End Module
