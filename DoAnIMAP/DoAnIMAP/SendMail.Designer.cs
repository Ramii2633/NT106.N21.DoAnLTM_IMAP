namespace DoAnIMAP
{
    partial class SendMail
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
            btnSend = new Button();
            tbSub = new TextBox();
            TbTo = new TextBox();
            rtbBody = new RichTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbFrom = new TextBox();
            label1 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            btnAttach = new Button();
            checkHtml = new CheckBox();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(823, 843);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(144, 50);
            btnSend.TabIndex = 15;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // tbSub
            // 
            tbSub.Location = new Point(76, 70);
            tbSub.Name = "tbSub";
            tbSub.Size = new Size(887, 31);
            tbSub.TabIndex = 14;
            // 
            // TbTo
            // 
            TbTo.Location = new Point(554, 15);
            TbTo.Name = "TbTo";
            TbTo.Size = new Size(409, 31);
            TbTo.TabIndex = 13;
            // 
            // rtbBody
            // 
            rtbBody.Location = new Point(14, 152);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(949, 626);
            rtbBody.TabIndex = 12;
            rtbBody.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 124);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 11;
            label4.Text = "Body:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 73);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 10;
            label3.Text = "Subject:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(523, 18);
            label2.Name = "label2";
            label2.Size = new Size(34, 25);
            label2.TabIndex = 9;
            label2.Text = "To:";
            // 
            // tbFrom
            // 
            tbFrom.Location = new Point(76, 15);
            tbFrom.Name = "tbFrom";
            tbFrom.ReadOnly = true;
            tbFrom.Size = new Size(411, 31);
            tbFrom.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 18);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 16;
            label1.Text = "From:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 801);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 18;
            label5.Text = "Attachment:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 798);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(705, 31);
            textBox1.TabIndex = 19;
            // 
            // btnAttach
            // 
            btnAttach.Location = new Point(835, 797);
            btnAttach.Name = "btnAttach";
            btnAttach.Size = new Size(122, 34);
            btnAttach.TabIndex = 20;
            btnAttach.Text = "Browse...";
            btnAttach.UseVisualStyleBackColor = true;
            // 
            // checkHtml
            // 
            checkHtml.AutoSize = true;
            checkHtml.Location = new Point(88, 123);
            checkHtml.Name = "checkHtml";
            checkHtml.Size = new Size(84, 29);
            checkHtml.TabIndex = 21;
            checkHtml.Text = "HTML";
            checkHtml.UseVisualStyleBackColor = true;
            // 
            // SendMail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 903);
            Controls.Add(checkHtml);
            Controls.Add(btnAttach);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(tbFrom);
            Controls.Add(label1);
            Controls.Add(btnSend);
            Controls.Add(tbSub);
            Controls.Add(TbTo);
            Controls.Add(rtbBody);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "SendMail";
            Text = "SendMail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private TextBox tbSub;
        private TextBox TbTo;
        private RichTextBox rtbBody;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tbFrom;
        private Label label1;
        private Label label5;
        private TextBox textBox1;
        private Button btnAttach;
        private CheckBox checkHtml;
    }
}