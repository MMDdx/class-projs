namespace WinFormsAppReciveButtonLocation;
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

    private void button1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
    {
        
        
    }

    public void reciver()
    {
        IPEndPoint ip = new IPEndPoint(IPAddress.Any, 0);
        UdpClient udp = new UdpClient(11000);

        while (true)
        {
            byte[] data = udp.Receive(ref ip);
            string[] text = Encoding.UTF8.GetString(data).Split(",");
            int X = int.Parse(text[0]);
            int Y = int.Parse(text[1]);

            button1.Location = new Point(X, Y);

        }
    }


    private void button1_Click(object sender, EventArgs e)
    {
        Thread thread = new Thread(reciver);
        thread.Start();
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        Environment.Exit(0);
    }
}