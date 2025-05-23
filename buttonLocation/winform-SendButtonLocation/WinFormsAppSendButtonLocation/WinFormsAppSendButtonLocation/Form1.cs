namespace WinFormsAppSendButtonLocation;
using System.Net;
using System.Net.Sockets;
using System.Text;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
    {
        int X = button1.Location.X;
        int Y = button1.Location.Y;
        switch (e.KeyCode)
        {
            case Keys.Up:
                button1.Location = new Point(X, Y - 10);
                break;

            case Keys.Down:
                button1.Location = new Point(X, Y + 10);
                break;

            case Keys.Left:
                button1.Location = new Point(X - 10, Y);
                break;

            case Keys.Right:
                button1.Location = new Point(X + 10, Y);
                break;

            default: break;
        }
        
        X = button1.Location.X;
        Y = button1.Location.Y;

        String objectLocation = X + "," + Y;

        UdpClient udp = new UdpClient();
        udp.Connect("", 11000);

        byte[] data = Encoding.UTF8.GetBytes(objectLocation);
        udp.Send(data, data.Length);
    }
}