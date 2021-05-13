using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class MaterialTextBox : MaterialSingleLineTextField, IMaterialControl {
    //Properties for managing the material design properties


    private readonly BaseTextBox _baseTextBox;
    private readonly AnimationManager _animationManager;

    public override string Text { get => _baseTextBox.Text; set => _baseTextBox.Text = value; }
    public new object Tag { get => _baseTextBox.Tag; set => _baseTextBox.Tag = value; }
    public new int MaxLength { get => _baseTextBox.MaxLength; set => _baseTextBox.MaxLength = value; }
    public override Font Font { get => base.Font; set { base.Font = value; Invalidate(); } }

    public MaterialTextBox() {
        SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.DoubleBuffer, true);

        _animationManager = new AnimationManager {
            Increment = 0.06,
            AnimationType = AnimationType.EaseInOut,
            InterruptAnimation = false
        };
        _animationManager.OnAnimationProgress += sender => Invalidate();

        var TextPadding = 4;
        _baseTextBox = new BaseTextBox {
            BorderStyle = BorderStyle.None,
            Font = base.Font,//SkinManager.ROBOTO_REGULAR_11,
            ForeColor = SkinManager.GetPrimaryTextColor(),
            Location = new Point(TextPadding, 0),//(0, 0),
            Width = Width - TextPadding,
            Height = Height - 5
        };

        if (!Controls.Contains(_baseTextBox) && !DesignMode) {
            Controls.Add(_baseTextBox);
        }

        _baseTextBox.GotFocus += (sender, args) => _animationManager.StartNewAnimation(AnimationDirection.In);
        _baseTextBox.LostFocus += (sender, args) => _animationManager.StartNewAnimation(AnimationDirection.Out);
        BackColorChanged += (sender, args) => {
            _baseTextBox.BackColor = BackColor;
            _baseTextBox.ForeColor = SkinManager.GetPrimaryTextColor();
        };

        //Fix for tabstop
        _baseTextBox.TabStop = true;
        TabStop = false;
    }

    protected override void OnPaint(PaintEventArgs pevent) {
        var g = pevent.Graphics;
        g.Clear(Parent.BackColor);

        var lineY = _baseTextBox.Bottom + 3;

        if (!_animationManager.IsAnimating()) {
            //No animation
            g.FillRectangle(_baseTextBox.Focused ? SkinManager.ColorScheme.PrimaryBrush : SkinManager.GetDividersBrush(), _baseTextBox.Location.X, lineY, _baseTextBox.Width, _baseTextBox.Focused ? 2 : 1);
        } else {
            //Animate
            int animationWidth = (int)(_baseTextBox.Width * _animationManager.GetProgress());
            int halfAnimationWidth = animationWidth / 2;
            int animationStart = _baseTextBox.Location.X + _baseTextBox.Width / 2;

            //Unfocused background
            g.FillRectangle(SkinManager.GetDividersBrush(), _baseTextBox.Location.X, lineY, _baseTextBox.Width, 1);

            //Animated focus transition
            g.FillRectangle(SkinManager.ColorScheme.PrimaryBrush, animationStart - halfAnimationWidth, lineY, animationWidth, 2);
        }
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        _baseTextBox.Location = new Point(0, 0);
        _baseTextBox.Width = Width;

        Height = _baseTextBox.Height + 5;
    }

    protected override void OnCreateControl() {
        base.OnCreateControl();

        _baseTextBox.BackColor = Parent.BackColor;
        _baseTextBox.ForeColor = SkinManager.GetPrimaryTextColor();
    }

    private class BaseTextBox : TextBox {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

        private const int EM_SETCUEBANNER = 0x1501;
        private const char EmptyChar = (char)0;
        private const char VisualStylePasswordChar = '\u25CF';
        private const char NonVisualStylePasswordChar = '\u002A';

        private string hint = string.Empty;
        public string Hint {
            get { return hint; }
            set {
                hint = value;
                SendMessage(Handle, EM_SETCUEBANNER, (int)IntPtr.Zero, Hint);
            }
        }

        private char _passwordChar = EmptyChar;
        public new char PasswordChar {
            get { return _passwordChar; }
            set {
                _passwordChar = value;
                SetBasePasswordChar();
            }
        }

        public new void SelectAll() {
            BeginInvoke((MethodInvoker)delegate () {
                base.Focus();
                base.SelectAll();
            });
        }

        public new void Focus() {
            BeginInvoke((MethodInvoker)delegate () {
                base.Focus();
            });
        }

        private char _useSystemPasswordChar = EmptyChar;
        public new bool UseSystemPasswordChar {
            get { return _useSystemPasswordChar != EmptyChar; }
            set {
                if (value) {
                    _useSystemPasswordChar = Application.RenderWithVisualStyles ? VisualStylePasswordChar : NonVisualStylePasswordChar;
                } else {
                    _useSystemPasswordChar = EmptyChar;
                }

                SetBasePasswordChar();
            }
        }

        private void SetBasePasswordChar() {
            base.PasswordChar = UseSystemPasswordChar ? _useSystemPasswordChar : _passwordChar;
        }

        public BaseTextBox() {
            MaterialContextMenuStrip cms = new TextBoxContextMenuStrip();
            cms.Opening += ContextMenuStripOnOpening;
            cms.OnItemClickStart += ContextMenuStripOnItemClickStart;

            ContextMenuStrip = cms;
        }

        private void ContextMenuStripOnItemClickStart(object sender, ToolStripItemClickedEventArgs toolStripItemClickedEventArgs) {
            switch (toolStripItemClickedEventArgs.ClickedItem.Text) {
                case "Undo":
                    Undo();
                    break;
                case "Cut":
                    Cut();
                    break;
                case "Copy":
                    Copy();
                    break;
                case "Paste":
                    Paste();
                    break;
                case "Delete":
                    SelectedText = string.Empty;
                    break;
                case "Select All":
                    SelectAll();
                    break;
            }
        }

        private void ContextMenuStripOnOpening(object sender, CancelEventArgs cancelEventArgs) {
            var strip = sender as TextBoxContextMenuStrip;
            if (strip != null) {
                strip.Undo.Enabled = CanUndo;
                strip.Cut.Enabled = !string.IsNullOrEmpty(SelectedText);
                strip.Copy.Enabled = !string.IsNullOrEmpty(SelectedText);
                strip.Paste.Enabled = Clipboard.ContainsText();
                strip.Delete.Enabled = !string.IsNullOrEmpty(SelectedText);
                strip.SelectAll.Enabled = !string.IsNullOrEmpty(Text);
            }
        }
    }

    private class TextBoxContextMenuStrip : MaterialContextMenuStrip {
        public readonly ToolStripItem Undo = new MaterialToolStripMenuItem { Text = "Undo" };
        public readonly ToolStripItem Seperator1 = new ToolStripSeparator();
        public readonly ToolStripItem Cut = new MaterialToolStripMenuItem { Text = "Cut" };
        public readonly ToolStripItem Copy = new MaterialToolStripMenuItem { Text = "Copy" };
        public readonly ToolStripItem Paste = new MaterialToolStripMenuItem { Text = "Paste" };
        public readonly ToolStripItem Delete = new MaterialToolStripMenuItem { Text = "Delete" };
        public readonly ToolStripItem Seperator2 = new ToolStripSeparator();
        public readonly ToolStripItem SelectAll = new MaterialToolStripMenuItem { Text = "Select All" };

        public TextBoxContextMenuStrip() {
            Items.AddRange(new[]
            {
                    Undo,
                    Seperator1,
                    Cut,
                    Copy,
                    Paste,
                    Delete,
                    Seperator2,
                    SelectAll
                });
        }
    }
}