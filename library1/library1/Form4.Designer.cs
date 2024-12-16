namespace library1
{
    partial class Form4
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
            check_in = new System.Windows.Forms.TextBox();
            check_out = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.Location = new System.Drawing.Point(227, 119);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(310, 31);
            label1.TabIndex = 3;
            label1.Text = "Enter Book ISBN to check in:";
            // 
            // check_in
            // 
            check_in.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            check_in.Location = new System.Drawing.Point(172, 153);
            check_in.Name = "check_in";
            check_in.Size = new System.Drawing.Size(449, 38);
            check_in.TabIndex = 16;
            check_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // check_out
            // 
            check_out.BackColor = System.Drawing.SystemColors.GrayText;
            check_out.Cursor = System.Windows.Forms.Cursors.Hand;
            check_out.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            check_out.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            check_out.Location = new System.Drawing.Point(287, 197);
            check_out.Name = "check_out";
            check_out.Size = new System.Drawing.Size(181, 46);
            check_out.TabIndex = 20;
            check_out.Text = "Return";
            check_out.UseVisualStyleBackColor = false;
            check_out.Click += check_out_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.GrayText;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button1.Location = new System.Drawing.Point(287, 249);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(181, 46);
            button1.TabIndex = 21;
            button1.Text = "Back To Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Info;
            ClientSize = new System.Drawing.Size(771, 408);
            Controls.Add(button1);
            Controls.Add(check_out);
            Controls.Add(check_in);
            Controls.Add(label1);
            Text = "LMS";
            FormClosing += Form4_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox check_in;
        private System.Windows.Forms.Button check_out;
        private System.Windows.Forms.Button button1;
    }
}