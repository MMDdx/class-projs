namespace DirectorySend;

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
        get_directory = new System.Windows.Forms.Button();
        listBox1 = new System.Windows.Forms.ListBox();
        btn_open = new System.Windows.Forms.Button();
        textBox1 = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // get_directory
        // 
        get_directory.Location = new System.Drawing.Point(20, 24);
        get_directory.Name = "get_directory";
        get_directory.Size = new System.Drawing.Size(148, 27);
        get_directory.TabIndex = 0;
        get_directory.Text = "get dirctory";
        get_directory.UseVisualStyleBackColor = true;
        get_directory.Click += get_directory_Click;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 15;
        listBox1.Location = new System.Drawing.Point(221, 139);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(335, 124);
        listBox1.TabIndex = 1;
        listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        // 
        // btn_open
        // 
        btn_open.Location = new System.Drawing.Point(208, 25);
        btn_open.Name = "btn_open";
        btn_open.Size = new System.Drawing.Size(162, 25);
        btn_open.TabIndex = 2;
        btn_open.Text = "open";
        btn_open.UseVisualStyleBackColor = true;
        btn_open.Click += btn_open_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(224, 277);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(331, 155);
        textBox1.TabIndex = 3;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(405, 25);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(150, 24);
        button1.TabIndex = 4;
        button1.Text = "save";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(button1);
        Controls.Add(textBox1);
        Controls.Add(btn_open);
        Controls.Add(listBox1);
        Controls.Add(get_directory);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Button btn_open;

    private System.Windows.Forms.ListBox listBox1;

    private System.Windows.Forms.Button get_directory;

    #endregion
}