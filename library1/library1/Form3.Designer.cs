namespace library1
{
    partial class Form3
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
            check_in = new System.Windows.Forms.TextBox();
            insertBtn = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // check_in
            // 
            check_in.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            check_in.Location = new System.Drawing.Point(193, 161);
            check_in.Name = "check_in";
            check_in.Size = new System.Drawing.Size(391, 38);
            check_in.TabIndex = 15;
            check_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // insertBtn
            // 
            insertBtn.BackColor = System.Drawing.SystemColors.GrayText;
            insertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            insertBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            insertBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            insertBtn.Location = new System.Drawing.Point(305, 224);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new System.Drawing.Size(181, 46);
            insertBtn.TabIndex = 19;
            insertBtn.Text = "Borrow";
            insertBtn.UseVisualStyleBackColor = false;
            insertBtn.Click += insertBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.GrayText;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button1.Location = new System.Drawing.Point(305, 276);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(181, 46);
            button1.TabIndex = 20;
            button1.Text = "Back To Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.Location = new System.Drawing.Point(236, 127);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(310, 31);
            label1.TabIndex = 2;
            label1.Text = "Enter Book ISBN to check in:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Info;
            ClientSize = new System.Drawing.Size(771, 408);
            Controls.Add(button1);
            Controls.Add(insertBtn);
            Controls.Add(check_in);
            Controls.Add(label1);
            Location = new System.Drawing.Point(19, 19);
            FormClosing += Form3_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox check_in;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}