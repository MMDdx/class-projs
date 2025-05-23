namespace DirectorySend;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Text;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void get_directory_Click(object sender, EventArgs e)
    {
        string[] Directories = Directory.GetFiles(Directory.GetCurrentDirectory());
        listBox1.Items.AddRange(Directories);
    }

    
    
    
    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }

    private void btn_open_Click(object sender, EventArgs e)
    {
        OpenFileDialog OP = new OpenFileDialog();
        OP.Filter = "README|*.txt";
        if (OP.ShowDialog() == DialogResult.OK)
        {
            StreamReader SR = File.OpenText(OP.FileName);
            textBox1.Text = SR.ReadToEnd();
            SR.Close();
        }
    }


    private void button1_Click(object sender, EventArgs e)
    {
        SaveFileDialog SF = new SaveFileDialog();
        SF.Filter = "New File|*.doc";

        if (SF.ShowDialog() == DialogResult.OK)
        {
            StreamWriter SW = File.AppendText(SF.FileName);
            SW.Write(textBox1.Text);
            SW.Close();
        }

        try
        {
            TcpClient client = new TcpClient("127.0.0.1",11000);
            NetworkStream stream = client.GetStream();
            byte[] data = Encoding.UTF8.GetBytes(textBox1.Text);
            stream.Write(data, 0, data.Length);
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message);
           
        }
        
    }
}