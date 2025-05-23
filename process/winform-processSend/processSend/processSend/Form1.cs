using System.Diagnostics;

namespace processSend;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }


    private void button1_Click(object sender, EventArgs e)
    {
        Process.Start("calc.exe");
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Process[] Processes = Process.GetProcesses();
            
        var query = from process in Processes
            select new { process.Id, process.ProcessName, process.BasePriority };

        dataGridView1.DataSource = query.ToList();
        
    }


    private void dataGridView1_SelectionChanged(object sender, EventArgs e)
    {
        
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        DataGridViewRow  row = dataGridView1.Rows[e.RowIndex];
        MessageBox.Show(row.Cells[0].Value+","+row.Cells[1].Value);
    }
}