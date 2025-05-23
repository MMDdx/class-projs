namespace DrawLinesSend;
using System.Net.Sockets;
using System.Text;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    bool isDrawing = false;
    List<Point> points = new List<Point>();


    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {
        points.Add(new Point(e.X, e.Y));
        Graphics graphics = this.CreateGraphics();
        Pen pen = new Pen(Color.Red, 4);
        if (points.Count > 1 && isDrawing) graphics.DrawLines(pen, points.ToArray());
    }

    private void Form1_MouseDown(object sender, MouseEventArgs e)
    {
        isDrawing = true;
        points.Clear();
        points.Add(new Point(e.X, e.Y));
    }

    private void Form1_MouseUp(object sender, MouseEventArgs e)
    {
        isDrawing = false;
        
        string Lines = points.Count().ToString();
        foreach (Point point in points)
            Lines += "," + point.X + "," + point.Y;
        
        UdpClient udp = new UdpClient();
        byte[] data = Encoding.UTF8.GetBytes(Lines);
        udp.Send(data, data.Length,"127.0.0.1", 11000);
        udp.Close();
    }
}