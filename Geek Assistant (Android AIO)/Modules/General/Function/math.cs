using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

internal static partial class math {
    public struct Random {
        /// <summary>
        /// Generate a random integer between <c>min</c> and <c>max</c> paremeters
        /// </summary>
        /// <param name="min">Minimum range for output</param>
        /// <param name="max">Maximum range for output</param>
        /// <returns><paramref name="max"/> &lt; (Integer) &lt; <paramref name="max"/></returns>
        public static int RandomInt(int min, int max)
                => new System.Random().Next(min, max);

        /// <summary>
        /// Chooses a random object from input array
        /// </summary>
        /// <param name="arr">Input Object array</param>
        /// <returns>Random object from input array</returns>
        public static object RandomObjectFromArr(object[] arr)
                => arr[RandomInt(0, arr.Length - 1)]; // -1 because it starts from 0
    }

    /// <summary>
    /// Force input variable into the range of min and max
    /// </summary>
    /// <param name="input">Value to process</param>
    /// <param name="min">Minimum floor</param>
    /// <param name="max">Maximum ceiling</param>
    /// <returns><list type="bullet">
    /// <item>Returns <paramref name="max"/> — if <paramref name="input"/> &gt; <paramref name="max"/></item>
    /// <item>Returns <paramref name="min"/> — if <paramref name="input"/> &lt; <paramref name="min"/></item>
    /// <item>Returns <paramref name="input"/> — if already in range</item>
    /// </list></returns>
    public static double ForceInRange(double input, double min, double max) {
        if (input > max) return max;
        if (input < min) return min;
        return input;
    }
    /// <summary>
    /// Force input variable into the range of min and max
    /// </summary>
    /// <param name="input">Value to process</param>
    /// <param name="min">Minimum floor</param>
    /// <param name="max">Maximum ceiling</param>
    /// <returns><list type="bullet">
    /// <item>Returns <paramref name="max"/> — if <paramref name="input"/> &gt; <paramref name="max"/></item>
    /// <item>Returns <paramref name="min"/> — if <paramref name="input"/> &lt; <paramref name="min"/></item>
    /// <item>Returns <paramref name="input"/> — if already in range</item>
    /// </list></returns>
    public static void ForceInRange(ref double input, double min, double max) {
        if (input > max) input = max;
        if (input < min) input = min;
    }


    public struct functions {
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
        public static double cosSmoothStartEnd(double x, double scale) {
            ForceInRange(x, 0, scale); // force x between 0一一一s
            return scale * (-Math.Cos(x * Math.PI) / (2 * scale) + 1 / 2);
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
        private static double sinSmoothEnd_01(double x, double scale) {
            ForceInRange(x, 0, scale); // force x between 0一一一s
            return scale * (Math.Sin(x * Math.PI + Math.PI / 2) / 2 + 1 / 2);
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
        public static double sinSmoothEnd(double x, double scale) {
            ForceInRange(x, 0, scale); // force x between 0一一一s
            return scale * (-Math.Sin(x * (Math.PI / 2) / scale) + 1);
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
        public static double sinSmoothStart(double x, double scale) {
            ForceInRange(x, 0, scale); // force x between 0一一一s
            return scale * Math.Sin(x * (Math.PI / (2 * scale)) + Math.PI / 2);
        }
    }


    /// <summary>Blends the specified colors together.</summary>
    /// <param name="foreColor">Color to blend onto the background color.</param>
    /// <param name="backColor">Color to blend the other color onto.</param>
    /// <param name="amount"> 
    ///  <list type="bullet"> <item>(0<=<1) How much of <paramref name="foreColor"/> to keep, “on top of” <paramref name="backColor"/>.</item>
    /// <item>-1 to use Alpha of <paramref name="foreColor"/> </item>
    /// </list> </param>
    /// <returns>The blended color.</returns>
    public static Color BlendColors(this Color foreColor, Color backColor, float amount = -1) {
        //if amount not set, Use  foreColor.A (bounded by 0-1)
        if (amount == -1)
            amount = foreColor.A / 255;

        byte R = (byte)((foreColor.R * amount) + backColor.R * (1 - amount)),
             G = (byte)((foreColor.G * amount) + backColor.G * (1 - amount)),
             B = (byte)((foreColor.B * amount) + backColor.B * (1 - amount));
        return Color.FromArgb(R, G, B);
    }
    /// <summary>Blends the specified colors together.</summary>
    /// <param name="foreColor">Color to blend onto the background color.</param>
    /// <param name="backColor">Color to blend the other color onto.</param>
    /// <param name="amount"> 
    ///  <list type="bullet">
    ///  <item>(0<=<255) How much of <paramref name="foreColor"/> to keep,
    /// “on top of” <paramref name="backColor"/>.</item>
    /// <item>(0-255)-1 to use Alpha of <paramref name="foreColor"/> </item>
    /// </list>
    /// </param>
    /// <returns>The blended color.</returns>
    public static Color BlendColors(this Color foreColor, Color backColor, int amount = -1)
           => BlendColors(foreColor, backColor, (float)(amount / 255));

    /// <returns>True if both images are equal (Brightness matrix hash)</returns>
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