namespace DoAnIMAP
{
    partial class ReadMail
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
            tbEmail = new TextBox();
            lbRecent = new Label();
            lbTotal = new Label();
            label1 = new Label();
            btnSend = new Button();
            btnF5 = new Button();
            btnLogOut = new Button();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            tbPortS = new TextBox();
            tbPortI = new TextBox();
            tbSMTP = new TextBox();
            tbIMAP = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lvEmail = new ListView();
            Num = new ColumnHeader();
            Subject = new ColumnHeader();
            From = new ColumnHeader();
            time = new ColumnHeader();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(58, 31);
            tbEmail.Name = "tbEmail";
            tbEmail.ReadOnly = true;
            tbEmail.Size = new Size(385, 31);
            tbEmail.TabIndex = 16;
            // 
            // lbRecent
            // 
            lbRecent.AutoSize = true;
            lbRecent.Location = new Point(382, 173);
            lbRecent.Name = "lbRecent";
            lbRecent.Size = new Size(68, 25);
            lbRecent.TabIndex = 13;
            lbRecent.Text = "Recent:";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(15, 173);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(53, 25);
            lbTotal.TabIndex = 12;
            lbTotal.Text = "Total:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 34);
            label1.Name = "label1";
            label1.Size = new Size(51, 25);
            label1.TabIndex = 10;
            label1.Text = "User:";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(22, 85);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(112, 34);
            btnSend.TabIndex = 17;
            btnSend.Text = "Send Mail";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnF5
            // 
            btnF5.Location = new Point(170, 85);
            btnF5.Name = "btnF5";
            btnF5.Size = new Size(112, 34);
            btnF5.TabIndex = 18;
            btnF5.Text = "Refresh";
            btnF5.UseVisualStyleBackColor = true;
            btnF5.Click += btnF5_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(320, 85);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(112, 34);
            btnLogOut.TabIndex = 19;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(btnSend);
            panel1.Controls.Add(btnF5);
            panel1.Location = new Point(12, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 135);
            panel1.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, -7);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 22;
            label2.Text = "Account";
            // 
            // panel2
            // 
            panel2.Controls.Add(tbPortS);
            panel2.Controls.Add(tbPortI);
            panel2.Controls.Add(tbSMTP);
            panel2.Controls.Add(tbIMAP);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(484, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(580, 134);
            panel2.TabIndex = 22;
            // 
            // tbPortS
            // 
            tbPortS.Location = new Point(470, 88);
            tbPortS.Name = "tbPortS";
            tbPortS.ReadOnly = true;
            tbPortS.Size = new Size(98, 31);
            tbPortS.TabIndex = 30;
            // 
            // tbPortI
            // 
            tbPortI.Location = new Point(470, 27);
            tbPortI.Name = "tbPortI";
            tbPortI.ReadOnly = true;
            tbPortI.Size = new Size(95, 31);
            tbPortI.TabIndex = 29;
            // 
            // tbSMTP
            // 
            tbSMTP.Location = new Point(69, 88);
            tbSMTP.Name = "tbSMTP";
            tbSMTP.ReadOnly = true;
            tbSMTP.Size = new Size(337, 31);
            tbSMTP.TabIndex = 28;
            // 
            // tbIMAP
            // 
            tbIMAP.Location = new Point(69, 30);
            tbIMAP.Name = "tbIMAP";
            tbIMAP.ReadOnly = true;
            tbIMAP.Size = new Size(337, 31);
            tbIMAP.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(423, 91);
            label7.Name = "label7";
            label7.Size = new Size(48, 25);
            label7.TabIndex = 26;
            label7.Text = "Port:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(423, 34);
            label6.Name = "label6";
            label6.Size = new Size(48, 25);
            label6.TabIndex = 25;
            label6.Text = "Port:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 89);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 24;
            label5.Text = "SMTP:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 33);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 23;
            label4.Text = "IMAP:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, -7);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 23;
            label3.Text = "Setting";
            // 
            // lvEmail
            // 
            lvEmail.Columns.AddRange(new ColumnHeader[] { Num, Subject, From, time });
            lvEmail.Location = new Point(12, 201);
            lvEmail.Name = "lvEmail";
            lvEmail.Size = new Size(1052, 651);
            lvEmail.TabIndex = 23;
            lvEmail.UseCompatibleStateImageBehavior = false;
            lvEmail.View = View.Details;
            lvEmail.SelectedIndexChanged += lvEmail_SelectedIndexChanged_1;
            // 
            // Num
            // 
            Num.Text = "#";
            Num.Width = 42;
            // 
            // Subject
            // 
            Subject.Text = "Email";
            Subject.Width = 490;
            // 
            // From
            // 
            From.Text = "From";
            From.Width = 280;
            // 
            // time
            // 
            time.Text = "Date-Time";
            time.Width = 240;
            // 
            // ReadMail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1076, 864);
            Controls.Add(lvEmail);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lbRecent);
            Controls.Add(lbTotal);
            Name = "ReadMail";
            Text = "ReadMail";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbEmail;
        private Label lbRecent;
        private Label lbTotal;
        private Label label1;
        private Button btnSend;
        private Button btnF5;
        private Button btnLogOut;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private TextBox tbPortS;
        private TextBox tbPortI;
        private TextBox tbSMTP;
        private TextBox tbIMAP;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ListView lvEmail;
        private ColumnHeader Num;
        private ColumnHeader Subject;
        private ColumnHeader From;
        private ColumnHeader time;
    }
}