namespace WinFormsAppReciveShape;
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

    public void ReciveData()
    {
        IPEndPoint IP = new IPEndPoint(IPAddress.Any, 0);
        UdpClient udp = new UdpClient(11000);

        while (true)
        {
            byte[] data = udp.Receive(ref IP);
            string message = Encoding.UTF8.GetString(data);

            string[] shape = message.Split(',');
            string shapeName = shape[0];
            int x1 = int.Parse(shape[1]);
            int y1 = int.Parse(shape[2]);
            int x2 = int.Parse(shape[3]);
            int y2 = int.Parse(shape[4]);
            Color color = ColorTranslator.FromHtml(shape[5]);
            
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(color);
            Brush b = new SolidBrush(color);
            
            switch (shapeName)
            {
                case "line":g.DrawLine(p, x1, y1, x2, y2) ;
                    break;
                case "rect":g.FillRectangle(b, x1, y1, Math.Abs(x2-x1), Math.Abs(y2-y1)) ;
                    break;
                case "ellipse":
                    g.FillEllipse(b, x1, y1, Math.Abs(x2-x1), Math.Abs(y2-y1)) ;
                    break;
            } 
            
            // Invoke(
            //     new Action(() => list_message.Items.Add(message + " from " + IP.Address.ToString()))
            // );
        }
        
    }


    private void button1_Click(object sender, EventArgs e)
    {
        Thread thread = new Thread(ReciveData);
        thread.Start();
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        Environment.Exit(0);
    }
}