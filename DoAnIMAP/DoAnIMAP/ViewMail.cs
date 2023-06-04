using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;


namespace DoAnIMAP
{
    public partial class ViewMail : Form
    {
        MimeMessage _message;
        public ViewMail(MimeMessage message)
        {
            InitializeComponent();
            _message = message;
        }

        private async void ViewMail_Load(object sender, EventArgs e)
        {
            // Hiển thị nội dung email trên các điều khiển tương ứng
            tbFrom.Text = _message.From.ToString();
            tbSub.Text = _message.Subject;
            tbDate.Text = _message.Date.ToString("dd/MM/yyyy") + _message.Date.ToString(" HH:mm:ss");

            // Khởi tạo trình duyệt WebView2
            await webView21.EnsureCoreWebView2Async();
            // Hiển thị nội dung email trên WebView2 hoặc rtb
            if (_message.HtmlBody != null)
            {
                webView21.NavigateToString(_message.HtmlBody);
                rtbBody.Visible = false;
            }
            else if (_message.TextBody != null)
            {
                webView21.Visible = false;
                rtbBody.Visible = true;
                rtbBody.Text = _message.TextBody;
            }
            else
            {
                webView21.Visible = false;
                rtbBody.Visible = true;
                rtbBody.Text = "Không tìm thấy nội dung email.";
            }

        }

        private void btnReply_Click(object sender, EventArgs e)
        {

        }
    }
}
