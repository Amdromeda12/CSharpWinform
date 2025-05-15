using CustomButton;
using System.Drawing.Drawing2D;

namespace Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rotatedButton1.MouseDown += rotatedButton1_MouseDown;
            customShapeButton2.MouseDown += customShapeButton2_Click;
        }

        private int number = 1;

        private void rotatedButton1_MouseDown(object sender, MouseEventArgs e)
        {
            var rotatedButton = sender as RotatedButton;
            if (rotatedButton != null && rotatedButton.buttonPath != null && rotatedButton.buttonPath.IsVisible(e.Location))
            {
                Button Test = new Button() {
                    Text = "Button " + number,
                    BackColor = Color.Aqua,
                    ForeColor = Color.Black,
                    Width=155, 
                };
                Test.Click +=CreatedButtonClick;

                flowLayoutPanel1.Controls.Add(Test);
                number++;
            }
        }
         
        private void CreatedButtonClick(object? sender, EventArgs e)
        {
            var smallbutton = sender as Button;
            this.Controls.Remove(smallbutton);
            smallbutton.Dispose();
        }

        private void customShapeButton2_Click(object sender, MouseEventArgs e)
        {
            var cusButton = sender as CustomShapeButton;
            if (cusButton != null && cusButton.buttonPath != null && cusButton.buttonPath.IsVisible(e.Location))
            {
                rotatedButton1.Angle += 45;
                rotatedButton2.Angle -= 45;
            }
        }
    }
}
