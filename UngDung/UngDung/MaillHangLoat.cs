using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDung
{
    public partial class MaillHangLoat :MetroFramework.Forms.MetroForm
    {
        Attachment actach = null;
        public MaillHangLoat()
        {
            InitializeComponent();
        }
        void GuiMail(string from, string to, string tieude, string noidung, Attachment file = null)
        {
            MailMessage message = new MailMessage(from, to, tieude, noidung);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;

            if (actach != null)
            {
                message.Attachments.Add(actach);
            }
            try
            {
                client.Credentials = new NetworkCredential(txtTk.Text, txtMk.Text);
                client.Send(message);
                MessageBox.Show("Đã Gửi Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(txtFile.Text);
                actach = new Attachment(txtFile.Text);
            }
            catch
            {


            }
            StreamReader sr = new StreamReader(txtTo.Text);
            string email;
            while ((email = sr.ReadLine()) != null)
            {
                GuiMail(txtTk.Text, email, txtTieuDe.Text, txtNoiDung.Text, actach);
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFile.Text = file.FileName;
            }
        }

        private void btnListMail_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtTo.Text = file.FileName;
            }
        }
    }
}
