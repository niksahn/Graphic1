namespace Graphic1
{
    public partial class Form1 : Form
    {
        PaintableFigure figure;

        private List<Label> LabelsCollection = new();
        private bool settingsOpened = false;
        public Form1()
        {
            InitializeComponent();
            var graph = CreateGraphics();
            figure = new Tank(new Converter(400, 400), new PainterWinForms(graph), new Mover2d());
            this.Size = new System.Drawing.Size(1408, 683);
        }

        public void ClearPoints()
        {
            for (int i = 0; i < LabelsCollection.Count; i++)
            {
                this.Controls.Remove(LabelsCollection[0]);
                LabelsCollection.RemoveAt(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            figure.paint();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateGraphics().Clear(Color.White);
            figure.move(0, 2, 0);
            figure.paint();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateGraphics().Clear(Color.White);
            figure.rotateZ(-10);
            figure.paint();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateGraphics().Clear(Color.White);
            figure.scale(2, 2, 2);
            figure.paint();
        }

        private void RotateRight_Click(object sender, EventArgs e)
        {
            CreateGraphics().Clear(Color.White);
            figure.rotateZ(10);
            figure.paint();
        }

        private void MoveDown_Click(object sender, EventArgs e)
        {
            CreateGraphics().Clear(Color.White);
            figure.move(0, -2, 0);
            figure.paint();
        }

        private void MoveRight_Click(object sender, EventArgs e)
        {
            CreateGraphics().Clear(Color.White);
            figure.move(2, 0, 0);
            figure.paint();
        }

        private void MoveLeft_Click(object sender, EventArgs e)
        {
            CreateGraphics().Clear(Color.White);
            figure.move(-2, 0, 0);
            figure.paint();
        }

        private void SizeMinus_Click(object sender, EventArgs e)
        {
            CreateGraphics().Clear(Color.White);
            figure.scale(0.5, 0.5, 0.5);
            figure.paint();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CreateGraphics().Clear(Color.White);
            figure.rotateY(10);
            figure.paint();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CreateGraphics().Clear(Color.White);
            figure.rotateY(-10);
            figure.paint();
        }

        private void XRotateLeft_Click(object sender, EventArgs e)
        {
            CreateGraphics().Clear(Color.White);
            figure.rotateX(10);
            figure.paint();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CreateGraphics().Clear(Color.White);
            figure.rotateX(-10);
            figure.paint();
        }
    }
}