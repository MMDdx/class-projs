namespace processSend;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        listView1 = new System.Windows.Forms.ListView();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(26, 23);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(128, 37);
        button1.TabIndex = 0;
        button1.Text = "start process";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(182, 27);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(191, 32);
        button2.TabIndex = 1;
        button2.Text = "all tasks";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // listView1
        // 
        listView1.Location = new System.Drawing.Point(788, 3);
        listView1.Name = "listView1";
        listView1.Size = new System.Drawing.Size(10, 17);
        listView1.TabIndex = 2;
        listView1.UseCompatibleStateImageBehavior = false;
        // 
        // dataGridView1
        // 
        dataGridView1.Location = new System.Drawing.Point(236, 124);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new System.Drawing.Size(309, 170);
        dataGridView1.TabIndex = 3;
        dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(dataGridView1);
        Controls.Add(listView1);
        Controls.Add(button2);
        Controls.Add(button1);
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.ListView listView1;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;

    #endregion
}