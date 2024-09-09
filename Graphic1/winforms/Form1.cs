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
            radioButton1.Checked = true;
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
            figure.move(0, 2);
            figure.paint();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateGraphics().Clear(Color.White);
            figure.rotate(-10);
            figure.paint();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateGraphics().Clear(Color.White);
            figure.scale(2, 2);
            figure.paint();
        }

        private void RotateRight_Click(object sender, EventArgs e)
        {
            CreateGraphics().Clear(Color.White);
            figure.rotate(10);
            figure.paint();
        }

        private void MoveDown_Click(object sender, EventArgs e)
        {
            CreateGraphics().Clear(Color.White);
            figure.move(0, -2);
            figure.paint();
        }

        private void MoveRight_Click(object sender, EventArgs e)
        {
            CreateGraphics().Clear(Color.White);
            figure.move(2, 0);
            figure.paint();
        }

        private void MoveLeft_Click(object sender, EventArgs e)
        {
            CreateGraphics().Clear(Color.White);
            figure.move(-2, 0);
            figure.paint();
        }

        private void SizeMinus_Click(object sender, EventArgs e)
        {
            CreateGraphics().Clear(Color.White);
            figure.scale(0.5, 0.5);
            figure.paint();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (settingsOpened) this.Size = new Size(1408, 683);
            else this.Size = new Size(1595, 683);
            settingsOpened = !settingsOpened;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}