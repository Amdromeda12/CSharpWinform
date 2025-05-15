using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomButton
{
    public class CustomShapeButton : Control
    {
        public GraphicsPath buttonPath { get; set; }
        public string ButtonText { get; set; } = "Custom Button";
        public Color ButtonBackColor { get; set; } = Color.LightGreen;
        public Color OutsideBackColor { get; set; } = Color.Transparent;

        public CustomShapeButton()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                          ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);

            this.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.Size = new Size(164, 44);
        }

        private void CreateButtonShape()
        {
            buttonPath = new GraphicsPath();

            buttonPath.AddPolygon(new PointF[]
            {
                new PointF(2.09703f, 28.1346f),
                new PointF(-2.00182f, 22.5618f),
                new PointF(-2.92209f, -3.93744f),
                new PointF(26.6901f, 0.498051f),
                new PointF(44.9593f, 3.22758f),
                new PointF(60.2337f, 18.5243f),
                new PointF(53.2908f, 24.5521f),
                new PointF(39.9905f, 44f),
                new PointF(24.6826f, 26.7698f),
                new PointF(17.154f, 44f),
                new PointF(2.09703f, 28.1346f)
            });
        }

        private void AdjustSizeToFitShape()
        {
            RectangleF bounds = buttonPath.GetBounds();

            float padding = 10f;
            this.Size = new Size((int)(bounds.Width + padding), (int)(bounds.Height + padding));
        }

        private RectangleF GetShapeBounds()
        {
            return buttonPath.GetBounds();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            CreateButtonShape();

            AdjustSizeToFitShape();

            e.Graphics.TranslateTransform((Width - buttonPath.GetBounds().Width) / 2f,
                                          (Height - buttonPath.GetBounds().Height) / 2f);

            using (SolidBrush bgBrush = new SolidBrush(ButtonBackColor))
                e.Graphics.FillPath(bgBrush, buttonPath);

            using (Pen borderPen = new Pen(Color.Black, 1.8f))
                e.Graphics.DrawPath(borderPen, buttonPath);

            RectangleF textRect = GetShapeBounds();
            using (StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            })
            using (SolidBrush textBrush = new SolidBrush(ForeColor))
                e.Graphics.DrawString(ButtonText, Font, textBrush, textRect, stringFormat);
        }
    }
}