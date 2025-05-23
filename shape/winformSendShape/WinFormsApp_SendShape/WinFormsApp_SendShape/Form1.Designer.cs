namespace WinFormsApp_SendShape;

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
        textBox1 = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        rect = new System.Windows.Forms.Button();
        ellipse = new System.Windows.Forms.Button();
        color = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(778, 455);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(10, 23);
        textBox1.TabIndex = 0;
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(12, 12);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(100, 32);
        button1.TabIndex = 1;
        button1.Text = "line";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // rect
        // 
        rect.Location = new System.Drawing.Point(12, 65);
        rect.Name = "rect";
        rect.Size = new System.Drawing.Size(99, 30);
        rect.TabIndex = 2;
        rect.Text = "rect";
        rect.UseVisualStyleBackColor = true;
        rect.Click += rect_Click;
        // 
        // ellipse
        // 
        ellipse.Location = new System.Drawing.Point(14, 114);
        ellipse.Name = "ellipse";
        ellipse.Size = new System.Drawing.Size(97, 24);
        ellipse.TabIndex = 3;
        ellipse.Text = "ellipse";
        ellipse.UseVisualStyleBackColor = true;
        ellipse.Click += ellipse_Click;
        // 
        // color
        // 
        color.Location = new System.Drawing.Point(15, 160);
        color.Name = "color";
        color.Size = new System.Drawing.Size(95, 27);
        color.TabIndex = 4;
        color.Text = "color";
        color.UseVisualStyleBackColor = true;
        color.Click += color_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 490);
        Controls.Add(color);
        Controls.Add(ellipse);
        Controls.Add(rect);
        Controls.Add(button1);
        Controls.Add(textBox1);
        Text = "Form1";
        MouseDown += Form1_MouseDown;
        MouseUp += Form1_MouseUp;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button rect;
    private System.Windows.Forms.Button ellipse;
    private System.Windows.Forms.Button color;

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;

    #endregion
}