namespace Graphic1
{
    public partial class Form1 : Form
    {
        PaintableFigure figure;
       public Form1()
        {
            InitializeComponent();
            var graph = CreateGraphics();
            figure = new Tank(new Converter(300,300), new PainterWinForms(graph), new Mover2d());
            figure.paint();
           // figure.move(100,100);
         //   graph.Clear(Color.White);
        }
    }
}