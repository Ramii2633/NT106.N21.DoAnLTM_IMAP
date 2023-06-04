namespace DoAnIMAP
{
    partial class ViewMail
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbFrom = new TextBox();
            tbDate = new TextBox();
            tbSub = new TextBox();
            rtbBody = new RichTextBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            btnReply = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 16);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 0;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(567, 15);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 1;
            label2.Text = "Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 77);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 2;
            label3.Text = "Subject:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 129);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 3;
            label4.Text = "Content:";
            // 
            // tbFrom
            // 
            tbFrom.Location = new Point(69, 12);
            tbFrom.Name = "tbFrom";
            tbFrom.ReadOnly = true;
            tbFrom.Size = new Size(441, 31);
            tbFrom.TabIndex = 4;
            // 
            // tbDate
            // 
            tbDate.Location = new Point(626, 12);
            tbDate.Name = "tbDate";
            tbDate.ReadOnly = true;
            tbDate.Size = new Size(282, 31);
            tbDate.TabIndex = 5;
            // 
            // tbSub
            // 
            tbSub.Location = new Point(85, 74);
            tbSub.Name = "tbSub";
            tbSub.ReadOnly = true;
            tbSub.Size = new Size(823, 31);
            tbSub.TabIndex = 6;
            // 
            // rtbBody
            // 
            rtbBody.Location = new Point(17, 129);
            rtbBody.Name = "rtbBody";
            rtbBody.ReadOnly = true;
            rtbBody.Size = new Size(891, 603);
            rtbBody.TabIndex = 7;
            rtbBody.Text = "";
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(13, 129);
            webView21.Name = "webView21";
            webView21.Size = new Size(891, 612);
            webView21.TabIndex = 8;
            webView21.ZoomFactor = 1D;
            // 
            // btnReply
            // 
            btnReply.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnReply.Location = new Point(767, 747);
            btnReply.Name = "btnReply";
            btnReply.Size = new Size(137, 45);
            btnReply.TabIndex = 9;
            btnReply.Text = "REPLY";
            btnReply.UseVisualStyleBackColor = true;
            btnReply.Click += btnReply_Click;
            // 
            // ViewMail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 800);
            Controls.Add(btnReply);
            Controls.Add(webView21);
            Controls.Add(rtbBody);
            Controls.Add(tbSub);
            Controls.Add(tbDate);
            Controls.Add(tbFrom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ViewMail";
            Text = "ViewMail";
            Load += ViewMail_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbFrom;
        private TextBox tbDate;
        private TextBox tbSub;
        private RichTextBox rtbBody;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button btnReply;
    }
}