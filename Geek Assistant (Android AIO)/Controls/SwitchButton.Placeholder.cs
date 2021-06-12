using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using GeekAssistant.Modules.Global.SetTheme;
using GeekAssistant.Modules.Global.Companion;
using GeekAssistant.Modules.Global.Companion.Style;
using GeekAssistant.Modules.Global.Companion.GAmath;


namespace GeekAssistant.Controls.Material {
    public class SwitchButton : MaterialFlatButton, IMaterialControl {

        private readonly AnimationManager _animationManager;
        private readonly AnimationManager _hoverAnimationManager;

        #region Rounded corners
        private int _Radius;
        [DefaultValue(0)]
        public int Radius {
            get => _Radius;
            set => _Radius = (int)mathMisc.ForcedInRange(value, 0, ClientRectangle.Height / 2);
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

        public override Color BackColor {
            get => base.BackColor;
            set {
                base.BackColor = value;
                Invalidate();
            }
        }
        private Color ForeColorA64 => Color.FromArgb(64, ForeColor);
        private Color saved_ForeColor = Color.Empty;
        public override Color ForeColor {
            get => base.ForeColor;
            set { base.ForeColor = value; Invalidate(); }
        }

        private SizeF _textSize;
        public override string Text {
            get => base.Text;
            set {
                base.Text = value;
                _textSize = CreateGraphics().MeasureString(value, Font);
                if (AutoSize) Size = GetPreferredSize();
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
        [DefaultValue(false)]
        public override bool AutoSize {
            get {
                if (!__AutoSize) AutoSizeMode = AutoSizeMode.GrowOnly;
                else AutoSizeMode = AutoSizeMode.GrowAndShrink;
                return false;
            }
        }//kill this retarded thing

        private bool __AutoSize;
        [DefaultValue(false)]
        public bool _AutoSize {
            get => __AutoSize;
            set {
                __AutoSize = value;
                if (!__AutoSize) AutoSizeMode = AutoSizeMode.GrowOnly;
                else AutoSizeMode = AutoSizeMode.GrowAndShrink;
                if (__AutoSize) GetPreferredSize();
                Invalidate();
            }
        }
        private static bool SetThemeRunning => SetTheme.Running;
        //private bool Idle = true; 
        public SwitchButton() {
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
        }

        private Rectangle iconRect;
        private double animationValue(int index) => SetThemeRunning ? _animationManager.GetProgress(_animationManager.GetAnimationCount())
                                                                  : _animationManager.GetProgress(index);
        private Point animationSource(int index) => SetThemeRunning ? _animationManager.GetSource(_animationManager.GetAnimationCount())
                                                                  : _animationManager.GetSource(index);
        private double _hoverAnimationManagerProgress => SetThemeRunning ? 1 : _hoverAnimationManager.GetProgress();

        Color hoverColor; Color RippleColor;

        protected override void OnPaint(PaintEventArgs pevent) {
            if (SetThemeRunning) return;

            Graphics g = pevent.Graphics;
            if (Radius != 0
               | string.IsNullOrEmpty(Text)
               | _animationManager.IsAnimating()
               )
                g.SmoothingMode = SmoothingMode.HighQuality;
            else g.SmoothingMode = SmoothingMode.Default;


            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;


            g.Clear(Parent.BackColor);
            Rectangle FxRect = ClientRectangle; FxRect.Inflate(-1, -1);
            GraphicsPath fxPath;
            if (string.IsNullOrEmpty(Text) & Icon != null) // Circle
                fxPath = Vision.Geometry.Circle(
                                    ClientRectangle.Width / 2 - .5f,
                                    ClientRectangle.Height / 2 - .5f,
                                    ClientRectangle.Height / 2 - 2  //-1 offset left-right top-bottom 
                                    );
            else fxPath = Vision.Geometry.RoundedRect(FxRect, Radius); //Rect or RoundedRect

            #region BackColor support
            //using (Brush b = new SolidBrush(
            //            Enabled ?
            //            Color.FromArgb(Math.Abs((int)(_hoverAnimationManager.GetProgress() * realBackColor.A) - 255), realBackColor.RemoveAlpha())
            //            : Color.Transparent))
            //    if (Idle) g.FillPath(b, RoundedRect(fxRect, Radius));
            #endregion

            //Hover  
            hoverColor = Color.FromArgb((int)(_hoverAnimationManagerProgress * 64/*saved_ForeColor.A*/),
                                                   saved_ForeColor.RemoveAlpha());
            using (Brush b = new SolidBrush(hoverColor)) //SkinManager.GetFlatButtonHoverBackgroundColor();  
                g.FillPath(b, fxPath);

            //Ripple 
            if (_animationManager.IsAnimating()) {
                Color Blend_hover_back = BackColor != Color.Empty | BackColor != Color.Transparent
                                         ? hoverColor : Vision.BlendColors(hoverColor, BackColor);
                Color Blend_hover_back_UIback = Vision.BlendColors(Blend_hover_back, colors.UI.bg());

                RippleColor = Vision.BlendColors(
                                         Blend_hover_back_UIback.GetBrightness() > .5f
                                          ? colors.constColors.UI.fg : colors.constColors.UI.bg,
                                         hoverColor, .5f);

                Rectangle rippleRect; GraphicsPath fxRipple;
                Region fxIntersect = new(fxPath); // initialize ( = original hover path )
                int animationCount = _animationManager.GetAnimationCount();

                Brush b;
                for (var i = 0; i < animationCount; i++) {
                    if (SetThemeRunning) return; //recheck becuase this takes time to end 
                    int rippleSize = (int)(animationValue(i) * Width * 2);
                    rippleRect = new(animationSource(i).X - rippleSize / 2, animationSource(i).Y - rippleSize / 2, rippleSize, rippleSize);
                    fxRipple = Vision.Geometry.EllipseInRect(rippleRect);
                    fxIntersect.Intersect(fxRipple); // update ( = ripple /\ hover )
                                                     //fxIntersect.GetRegionScans(regionToPathMatrix);
                    using (b = new SolidBrush(Color.FromArgb((int)((101 - (animationValue(i) * 100)) * 2), RippleColor)))
                        g.FillRegion(b, fxIntersect);

                }
            }

            Rectangle textRect = ClientRectangle;//Text
            if (Icon != null) {
                iconRect = new( //Center horizontally and vertically
                    ((ClientRectangle.Width - Icon.Width) / 2),
                    ((ClientRectangle.Height - Icon.Height) / 2),
                  ClientRectangle.Height - 12,
                  ClientRectangle.Height - 12
                  ); // Center Icon

                if (!string.IsNullOrEmpty(Text)) // Text exists:
                    iconRect.X = iconRect.Y; // Allign right horizontally


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
                         new SolidBrush(Enabled ? ForeColor : Color.Gray), //Enabled ? (Primary ? SkinManager.ColorScheme.PrimaryBrush : SkinManager.GetPrimaryTextBrush()) : SkinManager.GetFlatButtonDisabledTextBrush(),
                         textRect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center }
                         );
        }
        private Size GetPreferredSize() => _AutoSize ? GetPreferredSize(new Size(0, 0)) : Size;
        public override Size GetPreferredSize(Size proposedSize) {
            Size result = new((int)Math.Ceiling(_textSize.Width) + 16, Height);
            if (Icon != null)
                if (string.IsNullOrEmpty(Text)) result = new(36, 36);
                else result = new((int)Math.Ceiling(_textSize.Width) + 16 + iconRect.Width + 4, base.Height);
            return result;
        }

        private bool animating = false;
        protected override void OnCreateControl() {
            base.OnCreateControl();
            if (DesignMode) return;
            MouseState = MouseState.OUT;
            MouseEnter += (sender, ev) => {
                MouseState = MouseState.HOVER;
                _hoverAnimationManager.StartNewAnimation(AnimationDirection.In);

                if (!animating) {
                    if (SetThemeRunning | saved_ForeColor == Color.Empty)
                        saved_ForeColor = ForeColor;
                    //flip to current anti-bg color on hover  
                    Animate.Run(this, nameof(ForeColor), Vision.BlendColors(ForeColorA64, colors.UI.bg()).GetBrightness() > 0.5f
                                                         ? colors.constColors.UI.fg : colors.constColors.UI.bg);
                }
                Invalidate();
            };
            MouseLeave += (sender, ev) => {
                MouseState = MouseState.OUT;

                _hoverAnimationManager.StartNewAnimation(AnimationDirection.Out);

                Scheduler s = new(); var animDuration = 500;
                animating = true;
                if (!SetThemeRunning & saved_ForeColor != Color.Empty)
                    Animate.Run(this, nameof(ForeColor), saved_ForeColor, animDuration);
                s.Execute(() => animating = false, animDuration);

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
}