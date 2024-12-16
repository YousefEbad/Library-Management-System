namespace library1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ISPN = new System.Windows.Forms.TextBox();
            Title = new System.Windows.Forms.TextBox();
            Author = new System.Windows.Forms.TextBox();
            Year = new System.Windows.Forms.TextBox();
            insertBtn = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.Location = new System.Drawing.Point(51, 56);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(132, 31);
            label1.TabIndex = 1;
            label1.Text = "Enter ISBN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label2.Location = new System.Drawing.Point(58, 120);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(125, 31);
            label2.TabIndex = 2;
            label2.Text = "Enter Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label3.Location = new System.Drawing.Point(58, 188);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(153, 31);
            label3.TabIndex = 3;
            label3.Text = "Enter Author:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label4.Location = new System.Drawing.Point(58, 258);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(235, 31);
            label4.TabIndex = 13;
            label4.Text = "Enter Year of Release:";
            // 
            // ISPN
            // 
            ISPN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            ISPN.Location = new System.Drawing.Point(321, 53);
            ISPN.Name = "ISPN";
            ISPN.Size = new System.Drawing.Size(345, 38);
            ISPN.TabIndex = 14;
            ISPN.KeyDown += ISPN_KeyDown;
            // 
            // Title
            // 
            Title.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            Title.Location = new System.Drawing.Point(321, 113);
            Title.Name = "Title";
            Title.Size = new System.Drawing.Size(345, 38);
            Title.TabIndex = 15;
            Title.KeyDown += Title_KeyDown;
            // 
            // Author
            // 
            Author.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            Author.Location = new System.Drawing.Point(321, 181);
            Author.Name = "Author";
            Author.Size = new System.Drawing.Size(345, 38);
            Author.TabIndex = 16;
            Author.KeyDown += Author_KeyDown;
            // 
            // Year
            // 
            Year.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            Year.Location = new System.Drawing.Point(321, 251);
            Year.Name = "Year";
            Year.Size = new System.Drawing.Size(345, 38);
            Year.TabIndex = 17;
            Year.KeyDown += Year_KeyDown;
            // 
            // insertBtn
            // 
            insertBtn.BackColor = System.Drawing.SystemColors.GrayText;
            insertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            insertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            insertBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            insertBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            insertBtn.Location = new System.Drawing.Point(168, 325);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new System.Drawing.Size(181, 46);
            insertBtn.TabIndex = 18;
            insertBtn.Text = "Insert";
            insertBtn.UseVisualStyleBackColor = false;
            insertBtn.Click += insertBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.GrayText;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button1.Location = new System.Drawing.Point(416, 325);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(207, 46);
            button1.TabIndex = 19;
            button1.Text = "Back to Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Info;
            ClientSize = new System.Drawing.Size(840, 450);
            Controls.Add(button1);
            Controls.Add(insertBtn);
            Controls.Add(Year);
            Controls.Add(Author);
            Controls.Add(Title);
            Controls.Add(ISPN);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Text = "LMS";
            FormClosing += Form2_FormClosing_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.TextBox ISPN;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button button1;
    }
}