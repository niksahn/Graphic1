namespace Graphic1
{
    public partial class Form1 : Form
    {
        PaintableFigure figure;
       public Form1()
        {
            InitializeComponent();
            var graph = CreateGraphics();
            figure = new Tank(new Converter(400,400), new PainterWinForms(graph), new Mover2d());
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            figure.paint();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            figure.move(2,2);
            figure.paint();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             CreateGraphics().Clear(Color.White);
            figure.rotate(10);
            figure.paint();          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateGraphics().Clear(Color.White);
            figure.scale(2,2);
            figure.paint();
        }
    }
}