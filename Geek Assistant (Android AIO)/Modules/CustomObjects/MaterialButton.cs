using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

public class MaterialButton : MaterialFlatButton, IMaterialControl {

    private readonly AnimationManager _animationManager;
    private readonly AnimationManager _hoverAnimationManager;

    #region Rounded corners
    private int _Radius;
    [DefaultValue(0)]
    public int Radius {
        get => _Radius;
        set => _Radius = (int)math.Arithmatics.ForcedInRange(value, 0, ClientRectangle.Height / 2);
    }


    #endregion

    private StringAlignment _TextAlignment;
    [DefaultValue(StringAlignment.Center)]
    public StringAlignment TextAlignment {
        get => _TextAlignment;
        set {
            _TextAlignment = value;
            Invalidate();
        }
    }
    private Color _BackColor;
    public override Color BackColor {
        get => _BackColor;
        set {
            _BackColor = value;
            Invalidate();
        }
    }
    private Color ForeColorA60 => Color.FromArgb(50, ForeColor);
    private Color saved_ForeColor = Color.Empty;
    private Color _ForeColor;
    public override Color ForeColor {
        get => _ForeColor;
        set {
            _ForeColor = value;
            Invalidate();
        }
    }
    private bool _ThemeChanged;
    private bool ThemeChanged {
        get {
            if (c.S.DarkTheme != _ThemeChanged) {
                _ThemeChanged = true;
            } else {
                _ThemeChanged = false;
            }

            return _ThemeChanged;
        }
    }

    private SizeF _textSize;
    public override string Text {
        get => base.Text;
        set {
            base.Text = value;
            _textSize = CreateGraphics().MeasureString(value, Font);
            if (AutoSize) {
                Size = GetPreferredSize();
            }

            Invalidate();
        }
    }
    public override Font Font {
        get => base.Font;
        set {
            base.Font = value;
            Invalidate();
        }
    }
    //private bool Idle = true; 
    public MaterialButton() {
        Primary = false;

        _animationManager = new AnimationManager(false) {
            Increment = 0.03,
            AnimationType = AnimationType.EaseOut
        };
        _hoverAnimationManager = new AnimationManager {
            Increment = 0.07,
            AnimationType = AnimationType.Linear
        };

        _hoverAnimationManager.OnAnimationProgress += sender => Invalidate();
        _animationManager.OnAnimationProgress += sender => Invalidate();

        base.ForeColor = ForeColor;
        base.BackColor = BackColor;
    }

    private Rectangle iconRect;
    protected override void OnPaint(PaintEventArgs pevent) {
        var g = pevent.Graphics;
        if (Radius != 0
           | string.IsNullOrEmpty(Text)
           | _animationManager.IsAnimating()
           ) {
            g.SmoothingMode = SmoothingMode.HighQuality;
        } else {
            g.SmoothingMode = SmoothingMode.Default;
        }

        g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;


        g.Clear(Parent.BackColor);
        Rectangle fxRect = new(ClientRectangle.X + 1, ClientRectangle.Y + 1, ClientRectangle.Width - 1, ClientRectangle.Height - 1);
        GraphicsPath fxRoundedRect = math.Geometry.RoundedRect(fxRect, Radius);
        //using (Brush b = new SolidBrush(
        //            Enabled ?
        //            Color.FromArgb(Math.Abs((int)(_hoverAnimationManager.GetProgress() * realBackColor.A) - 255), realBackColor.RemoveAlpha())
        //            : Color.Transparent))
        //    if (Idle) g.FillPath(b, RoundedRect(fxRect, Radius));

        //Hover 
        //SkinManager.GetFlatButtonHoverBackgroundColor(); 
        using (Brush b = new SolidBrush(
                                Color.FromArgb((int)(_hoverAnimationManager.GetProgress() * 60 /*saved_ForeColor.A*/), saved_ForeColor.RemoveAlpha()))) {
            if (string.IsNullOrEmpty(Text) & Icon != null) {
                GraphicsPath hoverCirclePath =
                    math.Geometry.Circle(ClientRectangle.Width / 2 - .5f, ClientRectangle.Height / 2 - .5f, ClientRectangle.Width / 2 - 1);
                math.Geometry.FillCircle(g, b,
                            ClientRectangle.Width / 2 - .5f, ClientRectangle.Height / 2 - .5f, ClientRectangle.Width / 2 - 1);//-1 offset left-right top-bottom
            } else {
                g.FillPath(b, fxRoundedRect);
            }
        }

        //Ripple 
        if (_animationManager.IsAnimating()) {
            Color RippleColor = Color.FromArgb(60, saved_ForeColor);
            Rectangle rippleRect; //GraphicsPath rippleRoundedRect;
            for (var i = 0; i < _animationManager.GetAnimationCount(); i++) {
                double animationValue = _animationManager.GetProgress(i);
                Point animationSource = _animationManager.GetSource(i);

                using (Brush rippleBrush = new SolidBrush(Color.FromArgb((int)((101 - (animationValue * 100)) * 2), RippleColor))) {
                    int rippleSize = (int)(animationValue * Width * 2);
                    rippleRect = new(animationSource.X - rippleSize / 2, animationSource.Y - rippleSize / 2, rippleSize, rippleSize);

                    if (string.IsNullOrEmpty(Text) & Icon != null) {
                        math.Geometry.FillCircle(g, rippleBrush, animationSource.X, animationSource.Y, rippleSize);
                        continue;
                    }
                    if (Radius == 0) {
                        g.FillEllipse(rippleBrush, rippleRect); //fill using an ellipse if no radius
                    } else {

                        if (rippleRect.Width > ClientRectangle.Width * 0.8) {
                            g.FillEllipse(rippleBrush, rippleRect); //fill ellipse before reaching 80%
                        } else {
                            g.FillPath(rippleBrush, math.Geometry.RoundedRect(rippleRect, Radius)); //fill according to path after 80%
                        }
                    }
                }
            }
        }

        Rectangle textRect = ClientRectangle;//Text
        if (Icon != null) {
            iconRect = new( //Center horizontally and vertically
              ClientRectangle.X + ((ClientRectangle.Width - Icon.Width) / 2),
              ClientRectangle.Y + ((ClientRectangle.Height - Icon.Height) / 2),
              ClientRectangle.Height - 12,
              ClientRectangle.Height - 12
              ); // Center Icon

            if (!string.IsNullOrEmpty(Text)) // Text exists:
{
                iconRect.X = iconRect.Y; // Allign right horizontally
            }

            g.DrawImage(Icon, iconRect);

            //! Resize and move Text container
            //
            // First iconRect.X: left padding
            // iconRect.Width: icon width
            // Second 4: space between Icon and Text
            // Third 8: right padding
            textRect.Width -= iconRect.X + iconRect.Width + 4 + 8;
            //
            // First iconRect.X: left padding
            // iconRect.Width: icon width
            // Second 4: space between Icon and Text
            textRect.X += iconRect.X + iconRect.Width + 4;
        }
        //override the default bad (blurry) text hinting
        g.DrawString(Text, Font, //SkinManager.ROBOTO_MEDIUM_10,
                     Enabled ? new SolidBrush(ForeColor) : new SolidBrush(Color.Gray), //Enabled ? (Primary ? SkinManager.ColorScheme.PrimaryBrush : SkinManager.GetPrimaryTextBrush()) : SkinManager.GetFlatButtonDisabledTextBrush(),
                     textRect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center }
                     );
    }

    public override bool AutoSize {
        get => base.AutoSize;
        set {
            base.AutoSize = value;
            GetPreferredSize();
            Invalidate();
        }
    }
    private Size GetPreferredSize() => AutoSize ? GetPreferredSize(new Size(0, 0)) : Size;
    public override Size GetPreferredSize(Size proposedSize) {
        Size result = new((int)Math.Ceiling(_textSize.Width) + 16, base.Height);
        if (Icon != null) {
            if (string.IsNullOrEmpty(Text)) {
                result = new(36, 36);
            } else {
                result = new((int)Math.Ceiling(_textSize.Width) + 16 + iconRect.Width + 4, base.Height);
            }
        }

        return result;
    }
    private bool animating = false;
    private Timer animTimer = new() { Interval = 501 };
    protected override void OnCreateControl() {
        base.OnCreateControl();
        if (DesignMode) {
            return;
        }

        MouseState = MouseState.OUT;
        MouseEnter += (sender, ev) => {
            MouseState = MouseState.HOVER;
            _hoverAnimationManager.StartNewAnimation(AnimationDirection.In);

            if (!animating) {
                if (ThemeChanged | saved_ForeColor == Color.Empty) {
                    saved_ForeColor = ForeColor;
                }

                Animate.Run(this, nameof(ForeColor), math.Vision.BlendColors(ForeColorA60, colors.bg).GetBrightness() > 0.5f
                                                     ? colors.constColors.fg : colors.constColors.bg); //flip to current anti-bg color on hover  
            }
            Invalidate();
        };
        MouseLeave += (sender, ev) => {
            MouseState = MouseState.OUT;

            _hoverAnimationManager.StartNewAnimation(AnimationDirection.Out);

            //if (animating) ForeColor = saved_ForeColor;
            //else {
            animTimer.Start();
            animating = true;
            Animate.Run(this, nameof(ForeColor), saved_ForeColor);
            animTimer.Tick += (sender, ev) => {
                animating = false;
                animTimer.Stop();
            };
            //}
            Invalidate();
        };
        MouseDown += (sender, ev) => {
            if (ev.Button == MouseButtons.Left) {
                MouseState = MouseState.DOWN;

                _animationManager.StartNewAnimation(AnimationDirection.In, ev.Location);
                Invalidate();
            }
        };
        MouseUp += (sender, ev) => {
            MouseState = MouseState.HOVER;

            Invalidate();
        };
    }
}
//class MaterialTheme : MaterialButton {
//    public Color fg { get; set; }
//    public Color bg { get; set; }
//    public Color fx { get; set; }
//    private enum bgStatus { Disabled, Enabled }
//    public static MaterialTheme style(Color f, Color b, Color x)
//         => new MaterialTheme { fg = f, bg = b, fx = x };
//    /// <summary> Green</summary>
//    public MaterialTheme Default { get => style(colors.fg, Color.Transparent, Color.FromArgb(60, colors.Misc.Green)); }
//    public MaterialTheme Default_Colored { get => style(colors.fg, Color.FromArgb(128, colors.Misc.Green), Color.FromArgb(60, colors.Misc.Green)); }

//}
#region Dependancies

namespace MaterialSkin.Animations {
    enum AnimationType {
        Linear,
        EaseInOut,
        EaseOut,
        CustomQuadratic
    }

    static class AnimationLinear {
        public static double CalculateProgress(double progress) {
            return progress;
        }
    }

    static class AnimationEaseInOut {
        public static double PI = Math.PI;
        public static double PI_HALF = Math.PI / 2;

        public static double CalculateProgress(double progress) {
            return EaseInOut(progress);
        }

        private static double EaseInOut(double s) {
            return s - Math.Sin(s * 2 * PI) / (2 * PI);
        }
    }

    public static class AnimationEaseOut {
        public static double CalculateProgress(double progress) {
            return -1 * progress * (progress - 2);
        }
    }

    public static class AnimationCustomQuadratic {
        public static double CalculateProgress(double progress) {
            var kickoff = 0.6;
            return 1 - Math.Cos((Math.Max(progress, kickoff) - kickoff) * Math.PI / (2 - (2 * kickoff)));
        }
    }
}


namespace MaterialSkin.Animations {
    class AnimationManager {
        public bool InterruptAnimation { get; set; }
        public double Increment { get; set; }
        public double SecondaryIncrement { get; set; }
        public AnimationType AnimationType { get; set; }
        public bool Singular { get; set; }

        public delegate void AnimationFinished(object sender);
        public event AnimationFinished OnAnimationFinished;

        public delegate void AnimationProgress(object sender);
        public event AnimationProgress OnAnimationProgress;

        private readonly List<double> _animationProgresses;
        private readonly List<Point> _animationSources;
        private readonly List<AnimationDirection> _animationDirections;
        private readonly List<object[]> _animationDatas;

        private const double MIN_VALUE = 0.00;
        private const double MAX_VALUE = 1.00;

        private readonly Timer _animationTimer = new Timer { Interval = 5, Enabled = false };

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="singular">If true, only one animation is supported. The current animation will be replaced with the new one. If false, a new animation is added to the list.</param>
        public AnimationManager(bool singular = true) {
            _animationProgresses = new List<double>();
            _animationSources = new List<Point>();
            _animationDirections = new List<AnimationDirection>();
            _animationDatas = new List<object[]>();

            Increment = 0.03;
            SecondaryIncrement = 0.03;
            AnimationType = AnimationType.Linear;
            InterruptAnimation = true;
            Singular = singular;

            if (Singular) {
                _animationProgresses.Add(0);
                _animationSources.Add(new Point(0, 0));
                _animationDirections.Add(AnimationDirection.In);
            }

            _animationTimer.Tick += AnimationTimerOnTick;
        }

        private void AnimationTimerOnTick(object sender, EventArgs eventArgs) {
            for (var i = 0; i < _animationProgresses.Count; i++) {
                UpdateProgress(i);

                if (!Singular) {
                    if ((_animationDirections[i] == AnimationDirection.InOutIn && _animationProgresses[i] == MAX_VALUE)) {
                        _animationDirections[i] = AnimationDirection.InOutOut;
                    } else if ((_animationDirections[i] == AnimationDirection.InOutRepeatingIn && _animationProgresses[i] == MIN_VALUE)) {
                        _animationDirections[i] = AnimationDirection.InOutRepeatingOut;
                    } else if ((_animationDirections[i] == AnimationDirection.InOutRepeatingOut && _animationProgresses[i] == MIN_VALUE)) {
                        _animationDirections[i] = AnimationDirection.InOutRepeatingIn;
                    } else if (
                          (_animationDirections[i] == AnimationDirection.In && _animationProgresses[i] == MAX_VALUE) ||
                          (_animationDirections[i] == AnimationDirection.Out && _animationProgresses[i] == MIN_VALUE) ||
                          (_animationDirections[i] == AnimationDirection.InOutOut && _animationProgresses[i] == MIN_VALUE)) {
                        _animationProgresses.RemoveAt(i);
                        _animationSources.RemoveAt(i);
                        _animationDirections.RemoveAt(i);
                        _animationDatas.RemoveAt(i);
                    }
                } else {
                    if ((_animationDirections[i] == AnimationDirection.InOutIn && _animationProgresses[i] == MAX_VALUE)) {
                        _animationDirections[i] = AnimationDirection.InOutOut;
                    } else if ((_animationDirections[i] == AnimationDirection.InOutRepeatingIn && _animationProgresses[i] == MAX_VALUE)) {
                        _animationDirections[i] = AnimationDirection.InOutRepeatingOut;
                    } else if ((_animationDirections[i] == AnimationDirection.InOutRepeatingOut && _animationProgresses[i] == MIN_VALUE)) {
                        _animationDirections[i] = AnimationDirection.InOutRepeatingIn;
                    }
                }
            }

            OnAnimationProgress?.Invoke(this);
        }

        public bool IsAnimating() => _animationTimer.Enabled;

        public void StartNewAnimation(AnimationDirection animationDirection, object[] data = null) {
            StartNewAnimation(animationDirection, new Point(0, 0), data);
        }

        public void StartNewAnimation(AnimationDirection animationDirection, Point animationSource, object[] data = null) {
            if (!IsAnimating() || InterruptAnimation) {
                if (Singular && _animationDirections.Count > 0) {
                    _animationDirections[0] = animationDirection;
                } else {
                    _animationDirections.Add(animationDirection);
                }

                if (Singular && _animationSources.Count > 0) {
                    _animationSources[0] = animationSource;
                } else {
                    _animationSources.Add(animationSource);
                }

                if (!(Singular && _animationProgresses.Count > 0)) {
                    switch (_animationDirections[_animationDirections.Count - 1]) {
                        case AnimationDirection.InOutRepeatingIn:
                        case AnimationDirection.InOutIn:
                        case AnimationDirection.In:
                            _animationProgresses.Add(MIN_VALUE);
                            break;
                        case AnimationDirection.InOutRepeatingOut:
                        case AnimationDirection.InOutOut:
                        case AnimationDirection.Out:
                            _animationProgresses.Add(MAX_VALUE);
                            break;
                        default:
                            throw new Exception("Invalid AnimationDirection");
                    }
                }

                if (Singular && _animationDatas.Count > 0) {
                    _animationDatas[0] = data ?? new object[] { };
                } else {
                    _animationDatas.Add(data ?? new object[] { });
                }

            }

            _animationTimer.Start();
        }

        public void UpdateProgress(int index) {
            switch (_animationDirections[index]) {
                case AnimationDirection.InOutRepeatingIn:
                case AnimationDirection.InOutIn:
                case AnimationDirection.In:
                    IncrementProgress(index);
                    break;
                case AnimationDirection.InOutRepeatingOut:
                case AnimationDirection.InOutOut:
                case AnimationDirection.Out:
                    DecrementProgress(index);
                    break;
                default:
                    throw new Exception("No AnimationDirection has been set");
            }
        }

        private void IncrementProgress(int index) {
            _animationProgresses[index] += Increment;
            if (_animationProgresses[index] > MAX_VALUE) {
                _animationProgresses[index] = MAX_VALUE;

                for (int i = 0; i < GetAnimationCount(); i++) {
                    if (_animationDirections[i] == AnimationDirection.InOutIn) {
                        return;
                    }

                    if (_animationDirections[i] == AnimationDirection.InOutRepeatingIn) {
                        return;
                    }

                    if (_animationDirections[i] == AnimationDirection.InOutRepeatingOut) {
                        return;
                    }

                    if (_animationDirections[i] == AnimationDirection.InOutOut && _animationProgresses[i] != MAX_VALUE) {
                        return;
                    }

                    if (_animationDirections[i] == AnimationDirection.In && _animationProgresses[i] != MAX_VALUE) {
                        return;
                    }
                }

                _animationTimer.Stop();
                OnAnimationFinished?.Invoke(this);
            }
        }

        private void DecrementProgress(int index) {
            _animationProgresses[index] -= (_animationDirections[index] == AnimationDirection.InOutOut || _animationDirections[index] == AnimationDirection.InOutRepeatingOut) ? SecondaryIncrement : Increment;
            if (_animationProgresses[index] < MIN_VALUE) {
                _animationProgresses[index] = MIN_VALUE;

                for (var i = 0; i < GetAnimationCount(); i++) {
                    if (_animationDirections[i] == AnimationDirection.InOutIn) {
                        return;
                    }

                    if (_animationDirections[i] == AnimationDirection.InOutRepeatingIn) {
                        return;
                    }

                    if (_animationDirections[i] == AnimationDirection.InOutRepeatingOut) {
                        return;
                    }

                    if (_animationDirections[i] == AnimationDirection.InOutOut && _animationProgresses[i] != MIN_VALUE) {
                        return;
                    }

                    if (_animationDirections[i] == AnimationDirection.Out && _animationProgresses[i] != MIN_VALUE) {
                        return;
                    }
                }

                _animationTimer.Stop();
                OnAnimationFinished?.Invoke(this);
            }
        }

        public double GetProgress() {
            if (!Singular) {
                throw new Exception("Animation is not set to Singular.");
            }

            if (_animationProgresses.Count == 0) {
                throw new Exception("Invalid animation");
            }

            return GetProgress(0);
        }

        public double GetProgress(int index) {
            if (!(index < GetAnimationCount())) {
                throw new IndexOutOfRangeException("Invalid animation index");
            }

            return AnimationType switch {
                AnimationType.Linear =>
                    AnimationLinear.CalculateProgress(_animationProgresses[index]),
                AnimationType.EaseInOut =>
                    AnimationEaseInOut.CalculateProgress(_animationProgresses[index]),
                AnimationType.EaseOut =>
                    AnimationEaseOut.CalculateProgress(_animationProgresses[index]),
                AnimationType.CustomQuadratic =>
                    AnimationCustomQuadratic.CalculateProgress(_animationProgresses[index]),
                _ => throw new NotImplementedException("The given AnimationType is not implemented")
            };

        }

        public Point GetSource(int index) {
            if (!(index < GetAnimationCount())) {
                throw new IndexOutOfRangeException("Invalid animation index");
            }

            return _animationSources[index];
        }

        public Point GetSource() {
            if (!Singular) {
                throw new Exception("Animation is not set to Singular.");
            }

            if (_animationSources.Count == 0) {
                throw new Exception("Invalid animation");
            }

            return _animationSources[0];
        }

        public AnimationDirection GetDirection() {
            if (!Singular) {
                throw new Exception("Animation is not set to Singular.");
            }

            if (_animationDirections.Count == 0) {
                throw new Exception("Invalid animation");
            }

            return _animationDirections[0];
        }

        public AnimationDirection GetDirection(int index) {
            if (!(index < _animationDirections.Count)) {
                throw new IndexOutOfRangeException("Invalid animation index");
            }

            return _animationDirections[index];
        }

        public object[] GetData() {
            if (!Singular) {
                throw new Exception("Animation is not set to Singular.");
            }

            if (_animationDatas.Count == 0) {
                throw new Exception("Invalid animation");
            }

            return _animationDatas[0];
        }

        public object[] GetData(int index) {
            if (!(index < _animationDatas.Count)) {
                throw new IndexOutOfRangeException("Invalid animation index");
            }

            return _animationDatas[index];
        }

        public int GetAnimationCount() {
            return _animationProgresses.Count;
        }

        public void SetProgress(double progress) {
            if (!Singular) {
                throw new Exception("Animation is not set to Singular.");
            }

            if (_animationProgresses.Count == 0) {
                throw new Exception("Invalid animation");
            }

            _animationProgresses[0] = progress;
        }

        public void SetDirection(AnimationDirection direction) {
            if (!Singular) {
                throw new Exception("Animation is not set to Singular.");
            }

            if (_animationProgresses.Count == 0) {
                throw new Exception("Invalid animation");
            }

            _animationDirections[0] = direction;
        }

        public void SetData(object[] data) {
            if (!Singular) {
                throw new Exception("Animation is not set to Singular.");
            }

            if (_animationDatas.Count == 0) {
                throw new Exception("Invalid animation");
            }

            _animationDatas[0] = data;
        }
    }
}


namespace MaterialSkin.Animations {
    enum AnimationDirection {
        In, //In. Stops if finished.
        Out, //Out. Stops if finished.
        InOutIn, //Same as In, but changes to InOutOut if finished.
        InOutOut, //Same as Out.
        InOutRepeatingIn, // Same as In, but changes to InOutRepeatingOut if finished.
        InOutRepeatingOut // Same as Out, but changes to InOutRepeatingIn if finished.
    }
}

#endregion