using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

internal static class math {
    /// <summary> Manipulate numbers </summary>
    public struct Arithmatics {
        /// <summary> Random manipulation </summary>
        public struct Random {
            /// <summary> Generate a random integer between <c>min</c> and <c>max</c> paremeters </summary>
            /// <param name="min">Minimum range for output</param>
            /// <param name="max">Maximum range for output</param>
            /// <returns><paramref name="max"/> &lt; (Integer) &lt; <paramref name="max"/></returns>
            public static int RandomInt(int min, int max)
                    => new System.Random().Next(min, max);

            /// <summary> Chooses a random object from input array </summary>
            /// <param name="arr">Input Object array</param>
            /// <returns>Random object from input array</returns>
            public static object RandomObjectFromArr(object[] arr)
                    => arr[RandomInt(0, arr.Length - 1)]; // -1 because it starts from 0
        }
        /// <summary> Force input variable into the range of min and max </summary>
        /// <param name="input">Value to process</param>
        /// <param name="min">Minimum floor</param>
        /// <param name="max">Maximum ceiling</param>
        /// <returns><list type="bullet">
        /// <item>Returns <paramref name="max"/> — if <paramref name="input"/> &gt; <paramref name="max"/></item>
        /// <item>Returns <paramref name="min"/> — if <paramref name="input"/> &lt; <paramref name="min"/></item>
        /// <item>Returns <paramref name="input"/> — if already in range</item>
        /// </list></returns>
        public static double ForcedInRange(double input, double min, double max) {
            if (input > max) return max;
            if (input < min) return min;
            return input;
        }

        /// <summary> Check if <paramref name="input"/> is in range </summary>
        /// <param name="input">Value to process</param>
        /// <param name="min">Minimum floor</param>
        /// <param name="max">Maximum ceiling</param>
        /// <returns>true if input is in [<paramref name="min"/>, <paramref name="max"/>] range. Else false</returns>
        public static bool IsInRange(double input, double min, double max)
            => input <= max & input >= min;
    }

    /// <summary> Predefined functions </summary>
    public struct Fx {

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
            Arithmatics.ForcedInRange(x, 0, scale); // force x between 0一一一s
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
        public static double sinSmoothEnd_01(double x, double scale) {
            Arithmatics.ForcedInRange(x, 0, scale); // force x between 0一一一s
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
            Arithmatics.ForcedInRange(x, 0, scale); // force x between 0一一一s
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
            Arithmatics.ForcedInRange(x, 0, scale); // force x between 0一一一s
            return scale * Math.Sin(x * (Math.PI / (2 * scale)) + Math.PI / 2);
        }
    }

    public struct Vision {
        /// <summary>  Blends the specified colors together. </summary>
        /// <param name="foreColor">Color to blend onto the background color.</param>
        /// <param name="backColor">Color to blend the other color onto.</param>
        /// <param name="amount"> 
        ///  <list type="bullet"> <item>(0<=<1) How much of <paramref name="foreColor"/> to keep, “on top of” <paramref name="backColor"/>.</item>
        /// <item>-1 to use Alpha of <paramref name="foreColor"/> </item>
        /// </list> </param>
        /// <returns>The blended color.</returns>
        public static Color BlendColors(Color foreColor, Color backColor, float amount = -1) {
            //if amount not set, Use  foreColor.A  [ 0 >=> 1 ]
            if (amount == -1)
                amount = foreColor.A / 255; // convert alpha 0<=<255 to 0<=<1

            byte R = (byte)((foreColor.R * amount) + backColor.R * (1 - amount)),
                 G = (byte)((foreColor.G * amount) + backColor.G * (1 - amount)),
                 B = (byte)((foreColor.B * amount) + backColor.B * (1 - amount));
            return Color.FromArgb(R, G, B);
        }

        /// <returns>true if brightness matrix hashes are of the images are equal</returns>
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

    public struct Geometry {
        /// <param name="boundsRect">Original rectangle to convert</param>
        /// <param name="radius">Radius of rounded corners</param>
        /// <returns>Rounded rectangle as <see cref="GraphicsPath"/></returns>
        public static GraphicsPath RoundedRect(Rectangle boundsRect, int radius) {
            // Bound radius by half the height and width of boundsRect  
            radius = (int)math.Arithmatics.ForcedInRange(radius, 0, boundsRect.Height / 2);
            radius = (int)math.Arithmatics.ForcedInRange(radius, 0, boundsRect.Width / 2);

            int diameter = radius * 2;
            Rectangle arc = new(boundsRect.Location, new Size(diameter, diameter));
            GraphicsPath path = new();
            path.StartFigure();
            if (radius == 0) {
                path.AddRectangle(boundsRect);
                return path;
            }
            // top left arc  
            path.AddArc(arc, 180, 90);
            // top right arc  
            arc.X = boundsRect.Right - diameter;
            path.AddArc(arc, 270, 90);
            // bottom right arc  
            arc.Y = boundsRect.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            // bottom left arc 
            arc.X = boundsRect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        /// <summary>
        /// Draws a circle (outline) using <see cref="Graphics"/> <paramref name="g"/> and <see cref="Brush"/> <paramref name="brush"/>
        /// </summary>
        /// <param name="g"></param>
        /// <param name="brush"></param>
        /// <param name="centerX">X of center point</param>
        /// <param name="centerY">Y of center point</param>
        /// <param name="radius">radius of the circle</param>
        public static void DrawCircle(Graphics g, Pen pen, float centerX, float centerY, float radius) {
            g.DrawEllipse(pen, centerX - radius, centerY - radius,
                          radius + radius, radius + radius);
        }
        /// <summary>
        /// Draws a filled circle using <see cref="Graphics"/> <paramref name="g"/> and <see cref="Brush"/> <paramref name="brush"/>
        /// </summary>
        /// <param name="g"></param>
        /// <param name="brush"></param>
        /// <param name="centerX">X of center point</param>
        /// <param name="centerY">Y of center point</param>
        /// <param name="radius">radius of the circle</param>
        public static void FillCircle(Graphics g, Brush brush, float centerX, float centerY, float radius) {
            g.FillEllipse(brush, centerX - radius, centerY - radius,
                          radius + radius, radius + radius);
        }
        /// <param name="centerX">X of center point</param>
        /// <param name="centerY">Y of center point</param>
        /// <param name="radius">radius of the circle</param>
        /// <returns>Circle path as <see cref="GraphicsPath"/></returns>
        public static GraphicsPath Circle(float centerX, float centerY, float radius) {
            GraphicsPath result = new();
            result.AddEllipse(centerX - radius,
                              centerY - radius,
                              radius + radius,
                              radius + radius);
            return result;
        }

        /// <param name="boundsRect">Parent rectangle</param>
        /// <returns>Circle path as <see cref="GraphicsPath"/> bounded by <paramref name="boundsRect"/></returns>
        public static GraphicsPath EllipseInRect(Rectangle boundsRect) {
            GraphicsPath result = new();
            result.AddEllipse(boundsRect);
            return result;
        }
    }
}