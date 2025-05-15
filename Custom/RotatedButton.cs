using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace Exam
{
    public class RotatedButton : Control
    {
        public GraphicsPath buttonPath { get; set; }
        private Size targetSize = new Size(180, 30);
        private float angle = -45f;

        [Category("Appearance")]
        public float Angle
        {
            get => angle;
            set
            {
                angle = value;
                ResizeToFitRotation();
                Invalidate();
            }
        }

        [Category("Appearance")]
        public string ButtonText { get; set; } = "Rotated";

        [Category("Appearance")]
        public Color ButtonBackColor { get; set; } = Color.LightGreen;

        [Category("Appearance")]
        public Color OutsideBackColor { get; set; } = Color.Transparent;

        public RotatedButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);

            BackColor = Color.LightGreen;
            ForeColor = Color.Black;
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ResizeToFitRotation();
        }

        private void ResizeToFitRotation()
        {
            var radians = angle * Math.PI / 180;
            var w = targetSize.Width;
            var h = targetSize.Height;

            int newWidth = (int)(Math.Abs(w * Math.Cos(radians)) + Math.Abs(h * Math.Sin(radians)));
            int newHeight = (int)(Math.Abs(w * Math.Sin(radians)) + Math.Abs(h * Math.Cos(radians)));

            Size = new Size(newWidth + 1, newHeight + 1);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (SolidBrush bg = new SolidBrush(OutsideBackColor))
                e.Graphics.FillRectangle(bg, ClientRectangle);

            Matrix transformMatrix = new Matrix();
            transformMatrix.Translate(Width / 2f, Height / 2f);
            transformMatrix.Rotate(angle);
            transformMatrix.Translate(-targetSize.Width / 2f, -targetSize.Height / 2f);

            e.Graphics.Transform = transformMatrix;

            Rectangle rect = new Rectangle(0, 0, targetSize.Width, targetSize.Height);

            using (SolidBrush brush = new SolidBrush(ButtonBackColor))
                e.Graphics.FillRectangle(brush, rect);

            using (Pen pen = new Pen(Color.Black, 1.8f))
                e.Graphics.DrawRectangle(pen, rect);

            using (StringFormat sf = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            })
            using (SolidBrush textBrush = new SolidBrush(ForeColor))
                e.Graphics.DrawString(ButtonText, Font, textBrush, rect, sf);

            buttonPath = new GraphicsPath();
            buttonPath.AddRectangle(rect);
            buttonPath.Transform(transformMatrix);
        }
    }
}
