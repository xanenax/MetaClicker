using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DesktopGradientPanel = Siticone.Desktop.UI.WinForms.SiticoneGradientPanel;
using LegacyGradientPanel = Siticone.UI.WinForms.SiticoneGradientPanel;
using LegacyTrackBar = Siticone.UI.WinForms.SiticoneTrackBar;

namespace MetaClicker
{
    internal static class Branding
    {
        internal static readonly Color Background = Color.FromArgb(5, 4, 10);
        internal static readonly Color Surface = Color.FromArgb(11, 8, 18);
        internal static readonly Color RaisedSurface = Color.FromArgb(17, 11, 29);
        internal static readonly Color Graphite = Color.FromArgb(42, 32, 56);
        internal static readonly Color Accent = Color.FromArgb(146, 53, 255);
        internal static readonly Color AccentLight = Color.FromArgb(199, 113, 255);
        internal static readonly Color Muted = Color.FromArgb(157, 146, 177);

        internal static void ApplyRoundedCorners(Form form, int radius)
        {
            ApplyRoundedRegion(form, radius);
            form.HandleCreated += (sender, args) => ApplyRoundedRegion(form, radius);
            form.SizeChanged += (sender, args) => ApplyRoundedRegion(form, radius);
        }

        internal static void StyleRoundedSurface(
            LegacyGradientPanel panel,
            int radius,
            Color fillColor)
        {
            panel.UseTransparentBackground = false;
            panel.BackColor = fillColor;
            panel.FillColor = fillColor;
            panel.FillColor2 = fillColor;
            panel.BorderRadius = 0;
            panel.BorderThickness = 0;

            ApplyRoundedRegion(panel, radius);
            panel.SizeChanged += (sender, args) => ApplyRoundedRegion(panel, radius);
            panel.Paint += (sender, args) => PaintRoundedBorder(
                args.Graphics,
                panel.ClientSize,
                radius);
        }

        internal static void StyleRoundedSurface(
            DesktopGradientPanel panel,
            int radius,
            Color fillColor)
        {
            panel.UseTransparentBackground = false;
            panel.BackColor = fillColor;
            panel.FillColor = fillColor;
            panel.FillColor2 = fillColor;
            panel.BorderRadius = 0;
            panel.BorderThickness = 0;

            ApplyRoundedRegion(panel, radius);
            panel.SizeChanged += (sender, args) => ApplyRoundedRegion(panel, radius);
            panel.Paint += (sender, args) => PaintRoundedBorder(
                args.Graphics,
                panel.ClientSize,
                radius);
        }

        internal static void StyleSlider(
            LegacyTrackBar slider,
            Color backgroundColor)
        {
            slider.BackColor = backgroundColor;
            slider.Paint += (sender, args) => PaintSlider(slider, args.Graphics);
            slider.Invalidate();
        }

        internal static Control CreateSlashDecoration(Control parent, Rectangle bounds)
        {
            return CreateDecoration(parent, bounds, DecorationKind.Slashes);
        }

        internal static Control CreateDotDecoration(Control parent, Rectangle bounds)
        {
            return CreateDecoration(parent, bounds, DecorationKind.Dots);
        }

        internal static Label CreateLabel(
            Control parent,
            string text,
            Rectangle bounds,
            float fontSize,
            FontStyle style,
            Color color,
            ContentAlignment alignment)
        {
            Label label = new Label
            {
                BackColor = Color.Transparent,
                Bounds = bounds,
                Font = new Font("Segoe UI", fontSize, style),
                ForeColor = color,
                Text = text,
                TextAlign = alignment
            };

            parent.Controls.Add(label);
            label.BringToFront();
            return label;
        }

        internal static Control CreateMetallicMark(Control parent, Rectangle bounds)
        {
            MetallicMark mark = new MetallicMark
            {
                Bounds = bounds
            };

            parent.Controls.Add(mark);
            mark.BringToFront();
            return mark;
        }

        internal static Button CreateWindowButton(
            Control parent,
            string text,
            Rectangle bounds,
            bool closeButton,
            System.EventHandler onClick)
        {
            Button button = new Button
            {
                BackColor = Color.Transparent,
                Bounds = bounds,
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", closeButton ? 11f : 10f, FontStyle.Bold),
                ForeColor = closeButton ? AccentLight : Muted,
                TabStop = false,
                Text = text,
                UseVisualStyleBackColor = false
            };

            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 22, 48);
            button.FlatAppearance.MouseOverBackColor = closeButton
                ? Color.FromArgb(76, 29, 74)
                : Color.FromArgb(28, 20, 40);
            button.Click += onClick;
            parent.Controls.Add(button);
            button.BringToFront();
            return button;
        }

        private static Control CreateDecoration(
            Control parent,
            Rectangle bounds,
            DecorationKind kind)
        {
            DecorativeAccent decoration = new DecorativeAccent(kind)
            {
                BackColor = Background,
                Bounds = bounds,
                Enabled = false,
                TabStop = false
            };

            parent.Controls.Add(decoration);
            decoration.BringToFront();
            return decoration;
        }

        private static void ApplyRoundedRegion(Control control, int radius)
        {
            if (control.ClientSize.Width <= 0 || control.ClientSize.Height <= 0)
            {
                return;
            }

            RectangleF bounds = new RectangleF(
                0,
                0,
                control.ClientSize.Width,
                control.ClientSize.Height);

            using (GraphicsPath roundedPath = CreateRoundedPath(bounds, radius))
            {
                Region previousRegion = control.Region;
                control.Region = new Region(roundedPath);
                previousRegion?.Dispose();
            }
        }

        private static void PaintRoundedBorder(
            Graphics graphics,
            Size clientSize,
            int radius)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF borderBounds = new RectangleF(
                1f,
                1f,
                Math.Max(1f, clientSize.Width - 2f),
                Math.Max(1f, clientSize.Height - 2f));

            using (GraphicsPath borderPath = CreateRoundedPath(
                borderBounds,
                Math.Max(1, radius - 1)))
            using (Pen borderPen = new Pen(Graphite, 1f))
            {
                graphics.DrawPath(borderPen, borderPath);
            }
        }

        private static void PaintSlider(
            LegacyTrackBar slider,
            Graphics graphics)
        {
            graphics.Clear(slider.BackColor);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            float trackHeight = Math.Max(4f, Math.Min(5f, slider.ClientSize.Height - 4f));
            RectangleF trackBounds = new RectangleF(
                1f,
                (slider.ClientSize.Height - trackHeight) / 2f,
                Math.Max(1f, slider.ClientSize.Width - 2f),
                trackHeight);

            double range = slider.Maximum - slider.Minimum;
            float ratio = range <= 0
                ? 0f
                : (float)((slider.Value - slider.Minimum) / range);
            ratio = Math.Max(0f, Math.Min(1f, ratio));

            float thumbDiameter = Math.Max(
                6f,
                Math.Min(8f, slider.ClientSize.Height - 2f));
            float thumbRadius = thumbDiameter / 2f;
            float thumbCenter = trackBounds.Left + thumbRadius +
                ratio * Math.Max(0f, trackBounds.Width - thumbDiameter);
            float activeWidth = Math.Max(trackHeight, thumbCenter - trackBounds.Left);

            using (GraphicsPath trackPath = CreateRoundedPath(
                trackBounds,
                trackHeight / 2f))
            using (SolidBrush trackBrush = new SolidBrush(slider.FillColor))
            {
                graphics.FillPath(trackBrush, trackPath);
            }

            RectangleF activeBounds = new RectangleF(
                trackBounds.Left,
                trackBounds.Top,
                Math.Min(trackBounds.Width, activeWidth),
                trackBounds.Height);

            using (GraphicsPath activePath = CreateRoundedPath(
                activeBounds,
                trackHeight / 2f))
            using (SolidBrush activeBrush = new SolidBrush(slider.ThumbColor))
            {
                graphics.FillPath(activeBrush, activePath);
            }

            RectangleF thumbBounds = new RectangleF(
                thumbCenter - thumbRadius,
                (slider.ClientSize.Height - thumbDiameter) / 2f,
                thumbDiameter,
                thumbDiameter);

            using (SolidBrush thumbBrush = new SolidBrush(slider.ThumbColor))
            using (Pen thumbEdge = new Pen(Color.FromArgb(140, slider.ThumbColor), 1f))
            {
                graphics.FillEllipse(thumbBrush, thumbBounds);
                graphics.DrawEllipse(thumbEdge, thumbBounds);
            }
        }

        private static GraphicsPath CreateRoundedPath(RectangleF bounds, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float safeRadius = Math.Max(
                1f,
                Math.Min(radius, Math.Min(bounds.Width, bounds.Height) / 2f));
            float diameter = safeRadius * 2f;

            path.AddArc(bounds.Left, bounds.Top, diameter, diameter, 180f, 90f);
            path.AddArc(bounds.Right - diameter, bounds.Top, diameter, diameter, 270f, 90f);
            path.AddArc(
                bounds.Right - diameter,
                bounds.Bottom - diameter,
                diameter,
                diameter,
                0f,
                90f);
            path.AddArc(bounds.Left, bounds.Bottom - diameter, diameter, diameter, 90f, 90f);
            path.CloseFigure();
            return path;
        }

        private enum DecorationKind
        {
            Slashes,
            Dots
        }

        private sealed class DecorativeAccent : Control
        {
            private readonly DecorationKind kind;

            internal DecorativeAccent(DecorationKind kind)
            {
                this.kind = kind;
                SetStyle(
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.UserPaint,
                    true);
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                if (kind == DecorationKind.Dots)
                {
                    PaintDots(e.Graphics);
                    return;
                }

                PaintSlashes(e.Graphics);
            }

            private void PaintSlashes(Graphics graphics)
            {
                using (Pen soft = new Pen(Color.FromArgb(72, Accent), 1.4f))
                using (Pen bright = new Pen(Color.FromArgb(128, AccentLight), 1.7f))
                {
                    soft.StartCap = LineCap.Round;
                    soft.EndCap = LineCap.Round;
                    bright.StartCap = LineCap.Round;
                    bright.EndCap = LineCap.Round;

                    graphics.DrawLine(
                        soft,
                        Width * 0.08f,
                        Height * 0.78f,
                        Width * 0.39f,
                        Height * 0.22f);
                    graphics.DrawLine(
                        bright,
                        Width * 0.29f,
                        Height * 0.88f,
                        Width * 0.72f,
                        Height * 0.12f);
                    graphics.DrawLine(
                        soft,
                        Width * 0.65f,
                        Height * 0.73f,
                        Width * 0.9f,
                        Height * 0.31f);
                }
            }

            private void PaintDots(Graphics graphics)
            {
                const int columns = 4;
                const int rows = 3;
                float dotSize = Math.Max(2f, Math.Min(3f, Height / 8f));
                float xGap = (Width - dotSize * columns) / (columns + 1f);
                float yGap = (Height - dotSize * rows) / (rows + 1f);

                for (int row = 0; row < rows; row++)
                {
                    for (int column = 0; column < columns; column++)
                    {
                        int alpha = 118 - (column + row) * 11;
                        using (SolidBrush dot = new SolidBrush(Color.FromArgb(alpha, AccentLight)))
                        {
                            float x = xGap + column * (dotSize + xGap);
                            float y = yGap + row * (dotSize + yGap);
                            graphics.FillEllipse(dot, x, y, dotSize, dotSize);
                        }
                    }
                }
            }
        }

        private sealed class MetallicMark : Control
        {
            internal MetallicMark()
            {
                SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                DoubleBuffered = true;
                BackColor = Color.Transparent;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

                Rectangle textBounds = new Rectangle(0, -1, Width, Height + 1);
                using (Font font = new Font("Segoe UI Black", Height * 0.55f, FontStyle.Bold, GraphicsUnit.Pixel))
                using (StringFormat format = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                })
                using (SolidBrush shadow = new SolidBrush(Color.FromArgb(185, 0, 0, 0)))
                {
                    Rectangle shadowBounds = textBounds;
                    shadowBounds.Offset(1, 2);
                    e.Graphics.DrawString("M", font, shadow, shadowBounds, format);

                    using (LinearGradientBrush metal = new LinearGradientBrush(
                        textBounds,
                        Color.White,
                        Accent,
                        LinearGradientMode.Vertical))
                    {
                        ColorBlend blend = new ColorBlend
                        {
                            Colors = new[]
                            {
                                Color.FromArgb(250, 250, 255),
                                Color.FromArgb(159, 151, 171),
                                AccentLight,
                                Accent
                            },
                            Positions = new[] { 0f, 0.34f, 0.58f, 1f }
                        };
                        metal.InterpolationColors = blend;
                        e.Graphics.DrawString("M", font, metal, textBounds, format);
                    }
                }
            }
        }
    }
}
