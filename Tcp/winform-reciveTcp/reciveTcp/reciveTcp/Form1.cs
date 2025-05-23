namespace reciveTcp;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Thread thread = new Thread(recive);
        thread.Start();
    }

    public void recive()
    {
        TcpListener server = new TcpListener(IPAddress.Any, 11000);
        server.Start();
        while (true)
        {
            try
            {
                TcpClient client = server.AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                label1.Invoke(new Action(()=> label1.Text = message));

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            
            
        }
        
        
        
    }
}