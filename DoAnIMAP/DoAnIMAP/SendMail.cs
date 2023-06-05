using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace DoAnIMAP
{
    public partial class SendMail : Form
    {
        string EmailUser;
        string Password;
        OpenFileDialog dlgAttach = new OpenFileDialog();
        private List<MimePart> attachments = new List<MimePart>(); // Khai báo danh sách attachments

        public SendMail(string email, string pass)
        {
            InitializeComponent();
            EmailUser = email;
            Password = pass;
            tbFrom.Text = EmailUser;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra địa chỉ email người nhận có hợp lệ hay không (kh kiểm tra có tồn tại hay không)
                if (!MailboxAddress.TryParse(TbTo.Text.Trim(), out MailboxAddress toAddress))
                {
                    MessageBox.Show("Địa chỉ email người nhận không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var smtpClient = new SmtpClient();
                smtpClient.Connect("smtp.gmail.com", 465, true);
                smtpClient.Authenticate(EmailUser, Password);

                bool isHtml = checkHtml.Checked;

                // Thiết lập định dạng nội dung email
                BodyBuilder builder = new BodyBuilder();
                if (isHtml)
                {
                    builder.HtmlBody = rtbBody.Text;
                }
                else
                {
                    builder.TextBody = rtbBody.Text;
                }
                var mess = new MimeMessage();
                mess.From.Add(new MailboxAddress("", tbFrom.Text.Trim()));
                mess.To.Add(new MailboxAddress("", TbTo.Text.Trim()));
                mess.Subject = tbSub.Text;

                //đính kèm
                foreach (var attachment in attachments)
                {
                    builder.Attachments.Add(attachment);
                }
                mess.Body = builder.ToMessageBody();

                smtpClient.Send(mess);

                MessageBox.Show("Email đã được gửi thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gửi email không thành công! \nLỗi: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            dlgAttach.Filter = "All Files (*.*)|*.*";
            dlgAttach.Multiselect = true;
            if (dlgAttach.ShowDialog() == DialogResult.OK)
            {
                var attachment = new MimePart()
                {
                    Content = new MimeContent(File.OpenRead(dlgAttach.FileName), ContentEncoding.Default),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = Path.GetFileName(dlgAttach.FileName)
                };
                attachments.Add(attachment);
                // Lưu đường dẫn tệp tin vào TextBox
                tbAttach.Text += dlgAttach.FileName + "; ";
                MessageBox.Show("Đã đính kèm tệp tin!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}
