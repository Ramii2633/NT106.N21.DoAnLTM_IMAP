namespace DoAnIMAP
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            tbEmail = new TextBox();
            tbPass = new TextBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(619, 351);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(80, 369);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(80, 409);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 3;
            label3.Text = "Password: ";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(186, 367);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(360, 31);
            tbEmail.TabIndex = 4;
            tbEmail.KeyDown += tbEmail_KeyDown;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(187, 410);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(360, 31);
            tbPass.TabIndex = 5;
            tbPass.KeyDown += tbPass_KeyDown;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(450, 461);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(138, 51);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(624, 530);
            Controls.Add(btnLogin);
            Controls.Add(tbPass);
            Controls.Add(tbEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox tbEmail;
        private TextBox tbPass;
        private Button btnLogin;
    }
}