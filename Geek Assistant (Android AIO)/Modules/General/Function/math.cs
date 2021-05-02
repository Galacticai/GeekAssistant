using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Microsoft.VisualBasic; // Install-Package Microsoft.VisualBasic
using Microsoft.VisualBasic.CompilerServices; // Install-Package Microsoft.VisualBasic

internal static partial class math {

    /// <summary>
    /// Generate a random integer between <c>min</c> and <c>max</c> paremeters
    /// </summary>
    /// <param name="min">Minimum range for output</param>
    /// <param name="max">Maximum range for output</param>
    /// <returns><c>min</c> &lt; (Integer) &lt; <c>max</c></returns>
    public static object RandomInt(int min, int max) {
        VBMath.Randomize();
        return (int)Math.Round(Math.Floor((max - min + 1) * VBMath.Rnd())) + min;
    }

    /// <summary>
    /// Force input variable into the range of min and max
    /// </summary>
    /// <param name="input">Value to process</param>
    /// <param name="min">Minimum floor</param>
    /// <param name="max">Maximum ceiling</param>
    /// <returns><list type="bullet">
    /// <item>Returns <c>max</c> — if input &gt; max</item>
    /// <item>Returns <c>min</c> — if <c>input</c> &lt; <c>min</c></item>
    /// <item>Returns <c>input</c> — if it is already in the specified range</item>
    /// </list></returns>
    public static object ForceInRange(double input, double min, double max) {
        if (input > max)
            return max;
        if (input < min)
            return min;
        return input;
    }


    /// <summary>
    /// Chooses a random object from input array
    /// </summary>
    /// <param name="arr">Input Object array</param>
    /// <returns>Random object from input array</returns>
    public static string RandomObjectFromArr(object[] arr) {
        return Conversions.ToString(arr[Conversions.ToInteger(RandomInt(0, arr.Count() - 1))]); // -1 because it starts from 0
    }

    // s    .- 
    // |   /
    // | _-
    // 0一一一s
    /// <summary>
    /// <list>
    /// <item>Puts the value on a curve function</item>
    /// <c>
    /// <item>‏‏‎s‏‏‎ ‎‏‏‎ ‎‏‏‎‏‏‎ ‎ ‏‏‎ ‎‎‏‏‎ ‎.-  </item>
    /// <item>‏‏‎:‏‏‎ ‎‏‏‎ ‎‏‏‎‏‏‎ ‎ ‎/    </item>
    /// <item>‏‏‎: ‎_-     </item>
    /// <item>‏‏‎‎0 . . . . s </item>
    /// </c>
    /// </list>
    /// </summary>
    /// <param name="x">input</param>
    /// <param name="scale">Size of the wave (Half wave)</param>
    /// <returns>Returns <c>f(x)</c></returns>
    public static object cosSmoothStartEnd(double x, double scale) {
        ForceInRange(x, 0d, scale); // force x between 0一一一s
        return scale * (-Math.Cos(x * Math.PI) / (2d * scale) + 1d / 2d);
    }

    // s -.
    // |   \
    // |    -_
    // 0一一一s
    /// <summary>
    /// <list>
    /// <item>Puts the value on a curve function</item>
    /// <c>
    /// <item>‏‏‎‎s‏‏‎ ‎‎-.      </item>
    /// <item>‏‏‎:‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎\    </item>
    /// <item>‏‏‎:‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎-_</item>
    /// <item>‏‏‎0 . . . . s </item>
    /// </c>
    /// </list>
    /// </summary>
    /// <param name="x">input</param>
    /// <param name="scale">Size of the wave (Half wave)</param>
    /// <returns>Returns <c>f(x)</c></returns>
    private static object sinSmoothEnd_01(double x, double scale) {
        ForceInRange(x, 0d, scale); // force x between 0一一一s
        return scale * (Math.Sin(x * Math.PI + Math.PI / 2d) / 2d + 1d / 2d);
    }

    // s \
    // |  \
    // |   *._
    // 0一一一s
    /// <summary>
    /// <list>
    /// <item>Puts the value on a curve function</item>
    /// <c>
    /// <item>‏‏‎‎s‏‏‎ ‎\</item>
    /// <item>‏‏‎:‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎\</item>
    /// <item>‏‏‎:‏‏‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎*._</item>
    /// <item>‏‏‎0 . . . . s </item>
    /// </c>
    /// </list>
    /// </summary>
    /// <param name="x">input</param>
    /// <param name="scale">Size of the wave (Half wave)</param>
    /// <returns>Returns <c>f(x)</c></returns>
    public static object sinSmoothEnd(double x, double scale) {
        ForceInRange(x, 0d, scale); // force x between 0一一一s
        return scale * (-Math.Sin(x * (Math.PI / 2d) / scale) + 1d);
    }

    // s --.
    // |    \
    // |     \
    // 0一一一s
    /// <summary>
    /// <list>
    /// <item>Puts the value on a curve function</item>
    /// <c>
    /// <item>‏‏‎‎s‏‏‎‏‏‎ ‎--.</item>
    /// <item>‏‏‎:‏‏‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎\</item>
    /// <item>‏‏‎:‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎\</item>
    /// <item>‏‏‎0 . . . . s </item>
    /// </c>
    /// </list>
    /// </summary>
    /// <param name="x">input</param>
    /// <param name="scale">Size of the wave (Half wave)</param>
    /// <returns>Returns <c>f(x)</c></returns>
    public static object sinSmoothStart(double x, double scale) {
        ForceInRange(x, 0d, scale); // force x between 0一一一s
        return scale * Math.Sin(x * (Math.PI / (2d * scale)) + Math.PI / 2d);
    }


    /// <returns>True if both inputs are equal (Brightness matrix hash)</returns>
    public static bool CompareImagesBritghtnessMatrix(Image input1, Image input2)
            => GetImageHash(input1) == GetImageHash(input2) ? true : false;
    private static List<bool> GetImageHash(Image input) {
        List<bool> lResult = new();
        //create new image with 16x16 pixel
        Bitmap bmpMin = new(input, new Size(16, 16));
        for (int j = 0; j < bmpMin.Height; j++) {
            for (int i = 0; i < bmpMin.Width; i++) {
                //reduce colors to true / false                
                lResult.Add(bmpMin.GetPixel(i, j).GetBrightness() < 0.5f);
            }
        }
        return lResult;
    }
}