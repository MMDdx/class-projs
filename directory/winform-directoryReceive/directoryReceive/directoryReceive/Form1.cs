using System.Net;

namespace directoryReceive;
using System.Net.Sockets;
using System.Text;
using System.Threading;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Thread thread = new Thread(StartServer);
        thread.Start();
    }

    public void StartServer()
    {
        try
        {
            TcpListener server = new TcpListener(IPAddress.Any, 11000);
            server.Start();
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
            
                int bytsRead = stream.Read(buffer, 0, buffer.Length);
                string message = Encoding.UTF8.GetString(buffer, 0, bytsRead);
                MessageBox.Show(message);
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
        }
        
    }
}