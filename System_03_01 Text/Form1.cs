using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_03_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_convert_Click(object sender, EventArgs e)
        {
            lbl_separated.Text = "";
            lbl_binary.Text = "";
            lbl_ascii.Text = "";

            char[] Characters = txt_value.Text.ToCharArray();
            byte[] ASCIIs = Encoding.ASCII.GetBytes(txt_value.Text);

            for (int i = 0; i < Characters.Length; i++)
            {
                lbl_separated.Text += Characters[i] + " ";
                lbl_binary.Text += Convert.ToString(ASCIIs[i], 2) + " ";
                lbl_ascii.Text += ASCIIs[i] + " ";
            }
        }

        private void Btn_recover_Click(object sender, EventArgs e)
        {
            String[] BinaryValues = txt_binary.Text.Split(' ');

            byte[] Binaries = BinaryValues.Select(
                binary => Convert.ToByte(binary, 2)
            ).ToArray();

            String text = Encoding.UTF8.GetString(Binaries);

            lbl_text.Text = text;
        }
    }
}
