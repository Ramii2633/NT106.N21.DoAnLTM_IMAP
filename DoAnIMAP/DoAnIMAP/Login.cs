using System.Net.Mail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using MailKit.Security;

namespace DoAnIMAP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string email;
        string pass;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbEmail.Text == string.Empty)
                {
                    MessageBox.Show("Điền user!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tbPass.Text == string.Empty)
                {
                    MessageBox.Show("Điền password!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if ((tbEmail.Text != string.Empty) && (tbPass.Text != string.Empty))
                {
                    email = tbEmail.Text.Trim();
                    pass = tbPass.Text.Trim();
                    var imapClient = new ImapClient();
                    imapClient.Connect("imap.gmail.com", 993, true);
                    imapClient.Authenticate(email, pass);
                    var Login = new ReadMail(email, pass);
                    Login.Show();
                }
            }
            catch (AuthenticationException ex)
            {
                MessageBox.Show("Không chứng thực được tài khoản. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu. \nLỗi: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbPass.PasswordChar = '*';
        }

        private void tbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbPass.Focus();
            }
        }

        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.Focus();
            }
        }
    }
}