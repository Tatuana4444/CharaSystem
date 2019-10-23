using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Find : Form
    {
        string[][] Pupils = new string[0][];
        public static string[][] FindPupils = new string[0][];
        public static string FindStr;
        public static int n =0, m=0;
        public Find()
        {
            InitializeComponent();
        }
        private void AddData(string MyClass, string MyPupil)
        {
            n++;
            Array.Resize(ref Pupils, n);
            Pupils[n - 1] = new string[17];
            Pupils[n - 1][0] = MyClass + " класс";
                int k1 = 0, k2 = 0;
                for (int j = 1; j < 16; j++)
                {
                    k2 = MyPupil.IndexOf('|', k1);
                    Pupils[n - 1][j] = MyPupil.Substring(k1, k2 - k1);
                    k1 = k2 + 1;
                }
                Pupils[n - 1][16] = MyPupil.Substring(k1, MyPupil.Length - k1);
        }
        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Main.Allclass.Length; i++)
                for (int j = 1; j < Main.kol[i]; j++)
                    AddData(Main.Allclass[i][0], Main.Allclass[i][j]); 
            if (comboBox1.SelectedIndex != 15)
                for (int i = 0; i < n; i++)
                {
                    if (Pupils[i][comboBox1.SelectedIndex+2].IndexOf(EditFind.Text) >= 0)
                    {
                        m++;
                        Array.Resize(ref FindPupils, n);
                        FindPupils[m - 1] = new string[17];
                        FindPupils[m - 1] = Pupils[i];                        
                    }
                }
            else
            {
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        if (Pupils[i][j].IndexOf(EditFind.Text) >= 0)
                        {
                            m++;
                            Array.Resize(ref FindPupils, n);
                            FindPupils[m - 1] = new string[17];
                            FindPupils[m - 1] = Pupils[i];
                            break;
                        }
                    }
            }
            
            if (m > 0)
            {
                FindStr = EditFind.Text;
                MessageBox.Show("Найдено " + m.ToString() + " совпадений");
                finedelem form = new finedelem();
                form.ShowDialog();
            }
            else
                MessageBox.Show("Совпадений не найдено");
            n = 0;
            m = 0;
            Close();
        }
    }
}
