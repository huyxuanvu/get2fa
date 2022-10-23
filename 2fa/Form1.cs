using OtpNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2fa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Copy2fa_Click(object sender, EventArgs e)
        {
            var key2FA = txt2fa.Text;
                
            if (key2FA == "")
            {

                MessageBox.Show("vui lòng nhập mã 2FA 😉","xin chào");
            }
            else
            {
                var otpKeyBytes = Base32Encoding.ToBytes(key2FA);
                var totp = new Totp(otpKeyBytes);
                var twoFactorCode = totp.ComputeTotp();
                printcode.Text = twoFactorCode.ToString();
                Clipboard.SetText(twoFactorCode);

            }
           
        }

        private void reset_Click(object sender, EventArgs e)
        {
            txt2fa.Text = "";
            printcode.Text = "";
        }
    }
}
