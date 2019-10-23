using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using Plug;


namespace login
{
    
    public partial class Main : Form
    {
        public static string ConnectUser, Class, FullName, Birthdays, StPass, User,
            StHome, StHomeInfo, StHealth,Stbehvior, StShool, StPolice, StMName, StFName, StBr_Sist, StFamNote, StMWork, StFWork;
        public static int n = 0, Nnow = -1;
        public static int[] kol= new int[0];
        public static bool FlagEdit = false, IsWork = true, IsChange = false, Changed  = false;
        public static string[][] Allclass = new string[0][];
        public static string Path = Application.ExecutablePath.Substring(0, Application.ExecutablePath.Length-15);
        public byte[] aeskey;
        public byte[] aesiv;


        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find form = new Find();
            form.ShowDialog();
        }

        private void UpDataToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Class = "";
                Class = listClass.SelectedItems[0].Text.Substring(0, listClass.SelectedItems[0].Text.Length - 6);
                FlagEdit = true;
                classchoose CreatClass = new classchoose();
                CreatClass.ShowDialog();
                FlagEdit = false;
                int i = 0, q = 0; ;
                while ((i < n) && (Allclass[i][0] != Class))
                {
                    i++;
                }
                if (i == n)
                {
                    Allclass[q][0] = Class + " класс";
                    listClass.SelectedItems[0].Text = Class + " класс";
                }
                else
                    if (listClass.SelectedItems[0].Text.Substring(0, listClass.SelectedItems[0].Text.Length - 6) != Class)
                    MessageBox.Show("Ошибка. Такой класс уже существует");
            }
            catch
            {
                MessageBox.Show("Класс не выбран!");
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Class = "";
                Class = listClass.SelectedItems[0].Text.Substring(0, listClass.SelectedItems[0].Text.Length - 6);

                int i = 0, j;
                while (Allclass[i++][0] != Class) ; i--;
                for (j = i; j < n - 1; j++)
                {
                    Allclass[j] = Allclass[j + 1];
                    kol[j] = kol[j + 1];
                }
                Array.Resize(ref Allclass, --n);
                Array.Resize(ref kol, n);
                if (n > 0)
                {
                    Nnow = 0;
                    ChangeClass();
                }
                else
                {
                    Nnow = -1;
                    PipulsInfo.Items.Clear();
                }
                foreach (ListViewItem item in listClass.SelectedItems)
                {
                    listClass.Items.Remove(item);
                    break;
                }
            }
            catch
            {
                MessageBox.Show("Класс не выбран!");
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Nnow >= 0)
            {
                AddPerson CreatPupil = new AddPerson();
                CreatPupil.ShowDialog();

                kol[Nnow]++;
                ListViewItem lvi = new ListViewItem(new string[] { (kol[Nnow] - 1).ToString(), FullName, Birthdays, StPass, StHome, StHomeInfo, StHealth, Stbehvior, StShool, StPolice, StMName, StFName, StBr_Sist, StFamNote, StMWork, StFWork });
                PipulsInfo.Items.Add(lvi);
                Array.Resize(ref Allclass[Nnow], kol[Nnow]);
                Allclass[Nnow][kol[Nnow] - 1] = (kol[Nnow] - 1).ToString() + "|" + FullName + "|" + Birthdays + "|" + StPass +
                    "|" + StHome + "|" + StHomeInfo + "|" + StHealth + "|" + Stbehvior
                    + "|" + StShool + "|" + StPolice + "|" + StMName + "|" + StFName + "|" + StBr_Sist + "|"
                    + StFamNote + "|" + StMWork + "|" + StFWork;
            }
            else
                MessageBox.Show("Класс не выбран");
        }

        private void UpdataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PipulsInfo.SelectedItems.Count > 0)
            {
                FullName = PipulsInfo.SelectedItems[0].SubItems[1].Text;
                Birthdays = PipulsInfo.SelectedItems[0].SubItems[2].Text;
                StPass = PipulsInfo.SelectedItems[0].SubItems[3].Text;
                StHome = PipulsInfo.SelectedItems[0].SubItems[4].Text;
                StHomeInfo = PipulsInfo.SelectedItems[0].SubItems[5].Text;
                StHealth = PipulsInfo.SelectedItems[0].SubItems[6].Text;
                Stbehvior = PipulsInfo.SelectedItems[0].SubItems[7].Text;
                StShool = PipulsInfo.SelectedItems[0].SubItems[8].Text;
                StPolice = PipulsInfo.SelectedItems[0].SubItems[9].Text;
                StMName = PipulsInfo.SelectedItems[0].SubItems[10].Text;
                StFName = PipulsInfo.SelectedItems[0].SubItems[11].Text;
                StBr_Sist = PipulsInfo.SelectedItems[0].SubItems[12].Text;
                StFamNote = PipulsInfo.SelectedItems[0].SubItems[13].Text;
                StMWork = PipulsInfo.SelectedItems[0].SubItems[14].Text;
                StFWork = PipulsInfo.SelectedItems[0].SubItems[15].Text;
                IsChange = true;
                AddPerson CreatPupil = new AddPerson();
                CreatPupil.ShowDialog();
                IsChange = false;
                if (Changed)
                {
                    Changed = false;
                    string data = PipulsInfo.SelectedItems[0].SubItems[0].Text;
                    int i = 1;
                    while (Allclass[Nnow][i++].IndexOf(data + "|") != 0) ;
                    i--;
                    Allclass[Nnow][i] = PipulsInfo.SelectedItems[0].SubItems[0].Text + "|" + FullName + "|" + Birthdays + "|" + StPass +
                    "|" + StHome + "|" + StHomeInfo + "|" + StHealth + "|" + Stbehvior
                    + "|" + StShool + "|" + StPolice + "|" + StMName + "|" + StFName + "|" + StBr_Sist + "|"
                    + StFamNote + "|" + StMWork + "|" + StFWork;
                    ChangeClass();
                }
            }
            else
                MessageBox.Show("Выберите ученика");

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PipulsInfo.SelectedItems.Count > 0)
            {
                string data = PipulsInfo.SelectedItems[0].SubItems[0].Text;
                int i = 1;
                while (Allclass[Nnow][i++].IndexOf(data + "|") != 0) ;
                i--;
                for (int j = i; j < kol[Nnow] - 1; j++)
                    Allclass[Nnow][j] = Allclass[Nnow][j + 1];
                kol[Nnow]--;
                ChangeClass();
            }
            else
                MessageBox.Show("Выберите ученика");
        }

        private void SortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Nnow >= 0)
            {
                for (int i = 1; i < kol[Nnow]; i++)
                    Allclass[Nnow][i] = Allclass[Nnow][i].Substring(Allclass[Nnow][i].IndexOf('|'));
                for (int j = 1; j < kol[Nnow] - 1; j++)
                    for (int i = 1; i < kol[Nnow] - 1; i++)
                        if (String.Compare(Allclass[Nnow][i], Allclass[Nnow][i + 1]) > 0)
                        {
                            string Str = Allclass[Nnow][i];
                            Allclass[Nnow][i] = Allclass[Nnow][i + 1];
                            Allclass[Nnow][i + 1] = Str;

                        }
                for (int i = 1; i < kol[Nnow]; i++)
                    Allclass[Nnow][i] = i.ToString() + Allclass[Nnow][i];
                ChangeClass();
            }
            else
                MessageBox.Show("Выберите класс");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Crypto crypto = new Crypto();
                crypto.AesKey = aeskey;
                crypto.AesIV = aesiv;
                n = 0;
                Nnow = -1;
                kol = new int[0];
                Allclass = new string[0][];
                PipulsInfo.Items.Clear();
                listClass.Items.Clear();
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = openFileDialog1.FileName;
                string data = File.ReadAllText(filename);
                int k1 = data.IndexOf('\n') + 1;
                int count = int.Parse(data.Substring(0, k1 - 1));
                if (count > 0)
                {
                    int k2 = data.IndexOf('\n', k1);//первый найденный класс
                    Nnow = n;
                    string text = data.Substring(k1, k2 - k1 - 1);
                    text = crypto.Decrypt(Convert.FromBase64String(text));
                    listClass.Items.Add(processingData(text) + " класс", 0);

                    Array.Resize(ref Allclass, ++n);
                    Array.Resize(ref kol, n);
                    kol[n - 1] = 1;
                    Allclass[n - 1] = new string[1];
                    text = data.Substring(k1, k2 - k1 - 1);
                    text = crypto.Decrypt(Convert.FromBase64String(text));
                    Allclass[n - 1][0] = processingData(text);

                    while (count > 0)
                    {
                        if ((k2 + 1) == data.IndexOf("<<", k1))
                        {
                            count--;
                            if (count > 0)
                            {                               
                                k1 = k2 + 1;
                                k2 = data.IndexOf('\n', k1);
                                k1 = k2 + 1;
                                k2 = data.IndexOf('\n', k1);
                                Nnow = n;
                                text = data.Substring(k1, k2 - k1 - 1);
                                text = crypto.Decrypt(Convert.FromBase64String(text));
                                listClass.Items.Add(processingData(text) + " класс", 0);
                                Array.Resize(ref Allclass, ++n);
                                Array.Resize(ref kol, n);
                                kol[n - 1] = 1;
                                Allclass[n - 1] = new string[1];
                                text = data.Substring(k1, k2 - k1 - 1);
                                text = crypto.Decrypt(Convert.FromBase64String(text));
                                Allclass[n - 1][0] = processingData(text);
                            }
                        }
                        else
                        {                            
                            k1 = k2 + 1;
                            k2 = data.IndexOf('\n', k1);
                            kol[Nnow]++;

                            Array.Resize(ref Allclass[Nnow], kol[Nnow]);
                            text = data.Substring(k1, k2 - k1);
                            text = crypto.Decrypt(Convert.FromBase64String(text));
                            Allclass[Nnow][kol[Nnow] - 1] = processingData(text);
                        }
                    }
                    ChangeClass();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при чтении файла");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crypto crypto = new Crypto();
            crypto.AesKey = aeskey;
            crypto.AesIV = aesiv;
            FileStream file1 = new FileStream(Path + User + ".txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file1);
            writer.WriteLine((kol.Length).ToString());

            for (int i = 0; i < kol.Length; i++)
            {
                for (int j = 0; j < kol[i]; j++)
                {
                    writer.WriteLine(Convert.ToBase64String(crypto.Encrypt(Allclass[i][j] + "|")));
                }
                writer.WriteLine("<<");
            }
            writer.Close();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsWork = false;
        }

        public Main()
        {
            InitializeComponent();

            using (FileStream fstream = File.OpenRead(Path + "key.bin"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                aeskey = new byte[32];
                aesiv = new byte[16];
                int i, j;
                for (i = 0; i < 32; i++)
                    aeskey[i] = array[i];
                for (j = 0; j < 16; i++, j++)
                    aesiv[j] = array[i];
            }
            if (User == "admin")
            {
                параметрыToolStripMenuItem.Visible = false;
                параметрыКлассовToolStripMenuItem.Visible = false;
                отправитьToolStripMenuItem.Visible = false;
                Thread tRec = new Thread(new ThreadStart(Receiver));
                tRec.Start();
            }
        }

        public void Receiver()
        {
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);
            Socket sListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                sListener.Bind(ipEndPoint);
                sListener.Listen(10);
                while (IsWork)
                {
                    if (sListener.Poll(1000, SelectMode.SelectRead))
                    {                        
                        Socket handler = sListener.Accept();
                        string data = null;
                        byte[] bytes = new byte[1024];
                        int bytesRec = handler.Receive(bytes);

                        data = Encoding.UTF8.GetString(bytes, 0, bytesRec);//первая посылка                   

                        int k = data.IndexOf('\n');
                        ConnectUser = data.Substring(0, k);
                        if ((ConnectUser == "<<connect>>")||((ConnectUser == "<<reg>>")))
                        {
                            if (ConnectUser == "<<connect>>")//пришли данные об авторизации
                            {
                                handler.Send(Encoding.UTF8.GetBytes(DataCon(data)));
                                handler.Shutdown(SocketShutdown.Both);
                                handler.Close();
                            }
                            else//пришли данные о регистрации
                            {
                                handler.Send(Encoding.UTF8.GetBytes(DataReg(data)));
                                handler.Shutdown(SocketShutdown.Both);
                                handler.Close();
                            }
                        }
                        else//пришли характеристики учащихся
                        {                            
                            data = data.Remove(0, ConnectUser.Length + 1); 
                            k = data.IndexOf('\n');
                            int count = int.Parse(data.Substring(0, k));
                            string Str= data;
                            k = 0;
                            while (Str.IndexOf("<<\n", k) > -1)
                            {
                                k = Str.IndexOf("<<\n", k) + 3;
                                count--;
                            }
                            while (count > 0)
                            {                             
                                bytesRec = handler.Receive(bytes);
                                Str = Encoding.UTF8.GetString(bytes, 0, bytesRec);
                                data += Str; 
                                k = 0;
                                while (Str.IndexOf("<<\n", k) > -1)
                                {
                                    k = Str.IndexOf("<<\n", k) + 3;
                                    count--;
                                }                                
                            }
                        
                            handler.Shutdown(SocketShutdown.Both);
                            handler.Close();
                            AddData(data);//обработка данных
                        }
                    }
                }
            }

            catch(Exception e)
            {
                MessageBox.Show("Ошибка: " + e);
            }
        }
        private string DataCon(string data)//обработка пароля
        {
            data = data.Remove(0, 12);
            string datafile = File.ReadAllText(Path+"pass.txt");
            if (datafile.IndexOf("<<"+ data)>=0)
                return "+\n";            
            return "-\n";
        }
        private string DataReg(string data)//регистрация УО
        {
            data = data.Remove(0, 8);
            string login =data.Substring(0, data.IndexOf('|'));
            string datafile = File.ReadAllText(Path+"pass.txt");
            if (datafile.IndexOf("<<" + login) < 0)
            {
                File.AppendAllText(Path+"pass.txt", "<<" + data);
                return "+\n";
            }
            return "-\n";
        }
        private void ChangeClass()
        {
            PipulsInfo.Items.Clear(); 
            for (int i = 1; i < kol[Nnow]; i++)//подгружаем выбранный класс
            {
                int k1 = 0, k2 = 0;
                string s= Allclass[Nnow][i];
                string[] arr = new string[16];
                for (int j = 0; j < 15; j++)
                {
                    k2 = s.IndexOf('|', k1);
                    arr[j] = s.Substring(k1, k2 - k1);
                    k1 = k2 + 1;
                }
                arr[15] = s.Substring(k1, s.Length - k1);
                ListViewItem lvi = new ListViewItem(new string[] { arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7], arr[8], arr[9], arr[10], arr[11], arr[12], arr[13], arr[14], arr[15] });
                PipulsInfo.Items.Add(lvi);
            }
            

        }
        private void listClass_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listClass.SelectedItems.Count > 0)
            {
                Nnow = listClass.Items.IndexOf(listClass.SelectedItems[0]);
                ChangeClass();
            }                
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void AddData(string data)
        {           
            FileStream file1 = new FileStream(Path + ConnectUser + ".txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file1);
            int k1 = 0, k2;
            while((k2 = data.IndexOf('\n', k1)) > -1)
            {
                writer.WriteLine(data.Substring(k1, k2 - k1));
                k1 = k2 + 1;
            }            
            writer.Close();
        }

        private void SendToolStripMenuItem_Click(object sende, EventArgs e)
        {
            Crypto crypto = new Crypto();
            crypto.AesKey = aeskey;
            crypto.AesIV = aesiv;
            byte[] bytes = new byte[1024];
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);
            Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            sender.Connect(ipEndPoint);
            byte[] msg = Encoding.UTF8.GetBytes(User + "\n" + (kol.Length).ToString()+ "\n");
            sender.Send(msg);
            for (int i = 0; i < kol.Length; i++)
            {
                for (int j = 0; j < kol[i]; j++)
                {
                    string text = Allclass[i][j];
                    msg = Encoding.UTF8.GetBytes(Convert.ToBase64String(crypto.Encrypt(text +"|")) + "\n");
                    sender.Send(msg);
                }
                msg = Encoding.UTF8.GetBytes("<<\n");
                sender.Send(msg);
            }
            sender.Shutdown(SocketShutdown.Both);
             sender.Close();
        }

        private string processingData(string Data)
        {
            
            int i = Data.Length - 1; 
            while (Data[i--] != '|') ;
            Data = Data.Substring(0, i+1);
            return Data;
        }



        private void AddClass_Click(object sender, EventArgs e)
        {
            classchoose CreatClass = new classchoose();
            CreatClass.ShowDialog();            
            int i = 0;   
            while ((i < n) && (Allclass[i][0] != Class))
            {
                i++;
            }
            if (i == n)
            {
                listClass.Items.Add(Class + " класс", 0);
                Array.Resize(ref Allclass, ++n);
                Array.Resize(ref kol, n);
                kol[n - 1] = 1;
                Allclass[n - 1] = new string[1];
                Allclass[n - 1][0] = Class;
            }
            else
                MessageBox.Show("Ошибка. Такой класс уже существует");
        }
    }

}
