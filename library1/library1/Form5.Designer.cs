using System.ComponentModel;

namespace library1;

partial class Form5
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        button2 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
        button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        button1.Location = new System.Drawing.Point(295, 381);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(201, 57);
        button1.TabIndex = 0;
        button1.Text = "Back to menu";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // textBox1
        // 
        textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        textBox1.Location = new System.Drawing.Point(78, 48);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(504, 34);
        textBox1.TabIndex = 1;
        textBox1.KeyDown += textBox1_KeyDown;
        // 
        // textBox2
        // 
        textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        textBox2.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        textBox2.Location = new System.Drawing.Point(27, 91);
        textBox2.Multiline = true;
        textBox2.Name = "textBox2";
        textBox2.ReadOnly = true;
        textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        textBox2.Size = new System.Drawing.Size(745, 269);
        textBox2.TabIndex = 2;
        // 
        // button2
        // 
        button2.FlatAppearance.BorderSize = 0;
        button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button2.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button2.ForeColor = System.Drawing.SystemColors.ControlText;
        button2.Location = new System.Drawing.Point(588, 24);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(119, 61);
        button2.TabIndex = 3;
        button2.Text = "search";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // Form5
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Info;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(textBox1);
        Controls.Add(button2);
        Controls.Add(textBox2);
        Controls.Add(button1);
        Text = "LMS";
        FormClosing += Form5_FormClosing;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Button button1;

    #endregion
}