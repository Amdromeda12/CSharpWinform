namespace Exam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Drawing.Drawing2D.GraphicsPath graphicsPath1 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath2 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath3 = new System.Drawing.Drawing2D.GraphicsPath();
            rotatedButton1 = new RotatedButton();
            rotatedButton2 = new RotatedButton();
            customShapeButton2 = new CustomButton.CustomShapeButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // rotatedButton1
            // 
            rotatedButton1.Angle = -45F;
            rotatedButton1.BackColor = Color.LightSeaGreen;
            rotatedButton1.ButtonBackColor = Color.LightCoral;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            rotatedButton1.buttonPath = graphicsPath1;
            rotatedButton1.ButtonText = "Skapa";
            rotatedButton1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            rotatedButton1.ForeColor = Color.Black;
            rotatedButton1.Location = new Point(47, 34);
            rotatedButton1.Name = "rotatedButton1";
            rotatedButton1.OutsideBackColor = Color.Transparent;
            rotatedButton1.Size = new Size(152, 155);
            rotatedButton1.TabIndex = 6;
            rotatedButton1.Text = "rotatedButton1";
            // 
            // rotatedButton2
            // 
            rotatedButton2.Angle = 45F;
            rotatedButton2.BackColor = Color.LightSeaGreen;
            rotatedButton2.ButtonBackColor = Color.LightCoral;
            graphicsPath2.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            rotatedButton2.buttonPath = graphicsPath2;
            rotatedButton2.ButtonText = "Spin";
            rotatedButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rotatedButton2.ForeColor = Color.Black;
            rotatedButton2.Location = new Point(47, 397);
            rotatedButton2.Name = "rotatedButton2";
            rotatedButton2.OutsideBackColor = Color.Transparent;
            rotatedButton2.Size = new Size(152, 163);
            rotatedButton2.TabIndex = 7;
            rotatedButton2.Text = "rotatedButton2";
            // 
            // customShapeButton2
            // 
            customShapeButton2.ButtonBackColor = Color.LightGreen;
            graphicsPath3.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            customShapeButton2.buttonPath = graphicsPath3;
            customShapeButton2.ButtonText = "Test";
            customShapeButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            customShapeButton2.Location = new Point(91, 300);
            customShapeButton2.Name = "customShapeButton2";
            customShapeButton2.OutsideBackColor = Color.Transparent;
            customShapeButton2.Size = new Size(73, 57);
            customShapeButton2.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(248, 6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(160, 627);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(420, 640);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(customShapeButton2);
            Controls.Add(rotatedButton2);
            Controls.Add(rotatedButton1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exam";
            ResumeLayout(false);
        }

        #endregion
        private RotatedButton rotatedButton1;
        public RotatedButton rotatedButton2;
        private RotatedButton customShapeButton1;
        private CustomButton.CustomShapeButton customShapeButton2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
