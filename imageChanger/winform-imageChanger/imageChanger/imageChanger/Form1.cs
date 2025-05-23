namespace imageChanger;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private Bitmap Loaded;

    private void button1_Click(object sender, EventArgs e)
    {
        OpenFileDialog OP = new OpenFileDialog();
        OP.Filter = "*|*.jpg";
        if (OP.ShowDialog() == DialogResult.OK)
        {
            Loaded = new Bitmap(OP.FileName);
            
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        generateImage("gray scale");
    }

    private void button3_Click(object sender, EventArgs e)
    {
        generateImage("saturation");
    }

    public void generateImage(string type)
    {
        int width = Loaded.Width;
        int height = Loaded.Height;
        Bitmap Filtered = new Bitmap(width, height);

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Color RGB = Loaded.GetPixel(i, j);

                switch (type)
                {
                    case "gray scale":Filtered.SetPixel(i,j,createGrayscale(RGB));
                        break;
                    case "saturation": Filtered.SetPixel(i,j,createSaturation(RGB));
                        break;
                }
            }
        }
        pictureBox1.Image = Filtered;
    }

    private Color createGrayscale(Color RGB)
    {
        double average = (RGB.R + RGB.G + RGB.B) / 3;

        int R, G, B;
        R = G = B = (int)(average);

        Color Grayscale = Color.FromArgb(R, G, B);

        return Grayscale;
    }
    private Color createSaturation(Color RGB)
    {
        Color Saturation = Color.FromArgb(RGB.B, RGB.R, RGB.G);

        return Saturation;
    }
}