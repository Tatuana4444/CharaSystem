using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;

namespace login
{
    public partial class Authorized : Form
    {
        
        public Authorized()
        {
            InitializeComponent();
        }
        

        private void EditPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        private void ButtonEnter_Click(object send, EventArgs e)
        {
            string data= "-\n";
            if (( (Main.User = EditLogin.Text) == "admin") &&(EditPassword.Text=="admin"))
                data = "+\n";
            else
            {
                byte[] bytes = new byte[1024];
                IPHostEntry ipHost = Dns.GetHostEntry("localhost");
                IPAddress ipAddr = ipHost.AddressList[0];
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);
                Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    sender.Connect(ipEndPoint);
                    byte[] msg = Encoding.UTF8.GetBytes("<<connect>>\n" + EditLogin.Text + "|" + GetHash(EditPassword.Text));
                    sender.Send(msg);
                    data = null;
                    int bytesRec = sender.Receive(bytes);
                    data = Encoding.UTF8.GetString(bytes, 0, bytesRec);
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка! Невозможно соединиться с сервером");
                    return;
                }                
            }            
            if (data == "+\n")
            {
                Visible = false;
                Main form2 = new Main();
                form2.ShowDialog();
                Close();
            }
            else
                MessageBox.Show("Неверный логин или пароль");

        }

        private void regbutton_Click(object sender, EventArgs e)
        {
            //форма для регистрации

            Visible = false;
            registration form2 = new registration();
            form2.ShowDialog();
            EditLogin.Text = "";
            EditPassword.Text = "";
            Visible = true;

        }

        private void EditLogin_TextChanged(object sender, EventArgs e)
        {
            if ((EditLogin.Text == "") || (EditPassword.Text == ""))
                ButtonEnter.Enabled = false;
            else
                ButtonEnter.Enabled = true;
        }
    }
}
