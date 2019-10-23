using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;

namespace login
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        private void regbutton_Click(object send, EventArgs e)
        {
            if (EditPass.Text == EditPass2.Text)
            {
                byte[] bytes = new byte[1024];
                IPHostEntry ipHost = Dns.GetHostEntry("localhost");
                IPAddress ipAddr = ipHost.AddressList[0];
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);
                Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    sender.Connect(ipEndPoint);
                    byte[] msg = Encoding.UTF8.GetBytes("<<reg>>\n" + EditLogin.Text + "|" + GetHash(EditPass.Text));
                    sender.Send(msg);
                    string data = null;
                    int bytesRec = sender.Receive(bytes);
                    data = Encoding.UTF8.GetString(bytes, 0, bytesRec);
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                    if (data == "+\n")
                    {
                        MessageBox.Show("Учреждение образования успешно зарегистрировано");
                        Close();
                    }
                    else
                        MessageBox.Show("Ошибка! Такое учреждение образования уже зарегистрировано");
                }
                catch
                {
                    MessageBox.Show("Ошибка! Невозможно соединиться с сервером");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Ошибка! Пароли не совпадают");
            }
        }

        private void EditLogin_TextChanged(object sender, EventArgs e)
        {
            if ((EditLogin.Text.Length < 2) || (EditPass.Text.Length < 5) || (EditPass2.Text.Length < 5))
                regbutton.Enabled = false;
            else
                regbutton.Enabled = true;
        }
    }
}
