namespace library1
{
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
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            checkIn = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            label6 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(355, 57);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Agency FB", 19.800001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label3.Location = new System.Drawing.Point(310, 110);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(136, 41);
            label3.TabIndex = 2;
            label3.Text = "Main Menu";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.GrayText;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button1.Location = new System.Drawing.Point(279, 167);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(198, 46);
            button1.TabIndex = 11;
            button1.Text = "Add Book";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.GrayText;
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button2.Location = new System.Drawing.Point(279, 366);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(198, 46);
            button2.TabIndex = 12;
            button2.Text = "List Books";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // checkIn
            // 
            checkIn.BackColor = System.Drawing.SystemColors.GrayText;
            checkIn.Cursor = System.Windows.Forms.Cursors.Hand;
            checkIn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            checkIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            checkIn.Location = new System.Drawing.Point(279, 240);
            checkIn.Name = "checkIn";
            checkIn.Size = new System.Drawing.Size(198, 46);
            checkIn.TabIndex = 13;
            checkIn.Text = "Borrow";
            checkIn.UseVisualStyleBackColor = false;
            checkIn.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.SystemColors.GrayText;
            button5.Cursor = System.Windows.Forms.Cursors.Hand;
            button5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button5.Location = new System.Drawing.Point(279, 448);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(198, 46);
            button5.TabIndex = 15;
            button5.Text = "Exit";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = System.Drawing.SystemColors.GrayText;
            button6.Cursor = System.Windows.Forms.Cursors.Hand;
            button6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button6.Location = new System.Drawing.Point(279, 292);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(198, 46);
            button6.TabIndex = 16;
            button6.Text = "Retrun";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(341, 62);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(0, 20);
            label6.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Discourse Middle Light Fill", 19.800001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label2.Location = new System.Drawing.Point(44, 22);
            label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(722, 55);
            label2.TabIndex = 1;
            label2.Text = "Library Management System";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.WindowFrame;
            ClientSize = new System.Drawing.Size(782, 526);
            Controls.Add(label6);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(checkIn);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Text = "LMS";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label6;

        private System.Drawing.Printing.PrintDocument printDocument1;

        #endregion

        private Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button checkIn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}
