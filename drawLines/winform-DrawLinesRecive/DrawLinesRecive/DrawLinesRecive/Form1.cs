namespace DrawLinesRecive;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    public void reciver()
    {
        IPEndPoint ip = new IPEndPoint(IPAddress.Any, 0);
        UdpClient udp = new UdpClient(11000);

        while (true)
        {
            List<Point> points = new List<Point>();
            byte[] recived = udp.Receive(ref ip);
            
            string[] lines = Encoding.UTF8.GetString(recived).Split(",");

            for (int index = 1; index < lines.Length - 1; index += 2)
            {
                points.Add(
                    new Point(
                        Convert.ToInt32(lines[index]),
                        Convert.ToInt32(lines[index + 1])
                    )
                );
            }
            
            Graphics graphics = this.CreateGraphics();
            Pen pen = new Pen(Color.Red, 4);
            graphics.DrawLines(pen, points.ToArray());
            
        }

    }


    private void button1_Click(object sender, EventArgs e)
    {
        Thread thread = new Thread(reciver);
        thread.Start();
    }
}