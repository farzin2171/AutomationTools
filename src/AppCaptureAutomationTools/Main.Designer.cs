namespace AppCaptureAutomationTools
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAppCaptureAddress = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtApplicationPrefix = new TextBox();
            label3 = new Label();
            txtChunk = new TextBox();
            label4 = new Label();
            txtChunck1 = new TextBox();
            txtChunk2 = new TextBox();
            label5 = new Label();
            txtChunck3 = new TextBox();
            label6 = new Label();
            btnStart = new Button();
            richTextBox1 = new RichTextBox();
            label7 = new Label();
            txtTenant = new TextBox();
            SuspendLayout();
            // 
            // txtAppCaptureAddress
            // 
            txtAppCaptureAddress.Location = new Point(167, 9);
            txtAppCaptureAddress.Name = "txtAppCaptureAddress";
            txtAppCaptureAddress.Size = new Size(617, 27);
            txtAppCaptureAddress.TabIndex = 0;
            txtAppCaptureAddress.Text = "https://nss.app.clientrelease.equisoft.com/appcapture/AppCapture/New";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 1;
            label1.Text = "AppCapture Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 111);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 2;
            label2.Text = "ApplicationPrefix";
            // 
            // txtApplicationPrefix
            // 
            txtApplicationPrefix.Location = new Point(170, 108);
            txtApplicationPrefix.Name = "txtApplicationPrefix";
            txtApplicationPrefix.Size = new Size(118, 27);
            txtApplicationPrefix.TabIndex = 3;
            txtApplicationPrefix.Text = "AutoTest";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 165);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 4;
            label3.Text = "SessionChunk";
            // 
            // txtChunk
            // 
            txtChunk.Location = new Point(170, 158);
            txtChunk.Name = "txtChunk";
            txtChunk.Size = new Size(118, 27);
            txtChunk.TabIndex = 5;
            txtChunk.Text = "chunks-3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 209);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 6;
            label4.Text = "SessionChunk1";
            // 
            // txtChunck1
            // 
            txtChunck1.Location = new Point(167, 206);
            txtChunck1.Multiline = true;
            txtChunck1.Name = "txtChunck1";
            txtChunck1.Size = new Size(1271, 74);
            txtChunck1.TabIndex = 7;
            // 
            // txtChunk2
            // 
            txtChunk2.Location = new Point(167, 313);
            txtChunk2.Multiline = true;
            txtChunk2.Name = "txtChunk2";
            txtChunk2.Size = new Size(1271, 74);
            txtChunk2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 316);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 8;
            label5.Text = "SessionChunk2";
            // 
            // txtChunck3
            // 
            txtChunck3.Location = new Point(167, 420);
            txtChunck3.Multiline = true;
            txtChunck3.Name = "txtChunck3";
            txtChunck3.Size = new Size(1271, 74);
            txtChunck3.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 423);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 10;
            label6.Text = "SessionChunk3";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(167, 557);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(1271, 29);
            btnStart.TabIndex = 12;
            btnStart.Text = "Start Requests";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(15, 640);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1423, 120);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 67);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 14;
            label7.Text = "Tenant";
            // 
            // txtTenant
            // 
            txtTenant.Location = new Point(167, 64);
            txtTenant.Name = "txtTenant";
            txtTenant.Size = new Size(118, 27);
            txtTenant.TabIndex = 15;
            txtTenant.Text = "NSS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1458, 883);
            Controls.Add(txtTenant);
            Controls.Add(label7);
            Controls.Add(richTextBox1);
            Controls.Add(btnStart);
            Controls.Add(txtChunck3);
            Controls.Add(label6);
            Controls.Add(txtChunk2);
            Controls.Add(label5);
            Controls.Add(txtChunck1);
            Controls.Add(label4);
            Controls.Add(txtChunk);
            Controls.Add(label3);
            Controls.Add(txtApplicationPrefix);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAppCaptureAddress);
            Name = "Form1";
            Text = "Main Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAppCaptureAddress;
        private Label label1;
        private Label label2;
        private TextBox txtApplicationPrefix;
        private Label label3;
        private TextBox txtChunk;
        private Label label4;
        private TextBox txtChunck1;
        private TextBox txtChunk2;
        private Label label5;
        private TextBox txtChunck3;
        private Label label6;
        private Button btnStart;
        private RichTextBox richTextBox1;
        private Label label7;
        private TextBox txtTenant;
    }
}
