using System.Net.Sockets;
using System.Text;
namespace sendTCP;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }


    private void button1_Click(object sender, EventArgs e)
    {
        
        sendMsg(textBox1.Text);
    }

    public void sendMsg(string msg)
    {
        try
        {
            TcpClient client = new TcpClient("127.0.0.1", 11000);
            NetworkStream stream = client.GetStream();
            byte[] data = Encoding.UTF8.GetBytes(msg);
            stream.Write(data, 0, data.Length);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        
        
    }
}