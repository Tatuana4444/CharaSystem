using System;
using System.Windows.Forms;
using System.IO;

namespace login
{
    public partial class finedelem : Form
    {
        public finedelem()
        {
            InitializeComponent();
            for (int i = 0; i < Find.m; i++)
            {
                ListViewItem lvi = new ListViewItem(new string[] { Find.FindPupils[i][0], Find.FindPupils[i][1], Find.FindPupils[i][2],
                 Find.FindPupils[i][3], Find.FindPupils[i][4], Find.FindPupils[i][5], Find.FindPupils[i][6], Find.FindPupils[i][7],
                 Find.FindPupils[i][8], Find.FindPupils[i][9], Find.FindPupils[i][10], Find.FindPupils[i][11], Find.FindPupils[i][12],
                 Find.FindPupils[i][13], Find.FindPupils[i][14], Find.FindPupils[i][15], Find.FindPupils[i][16] });
                PipulsInfo.Items.Add(lvi);
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream file1 = new FileStream(Main.Path + Main.User + "Find_" + Find.FindStr + ".txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file1);
            for (int i = 0; i < Find.m; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    writer.Write(Find.FindPupils[i][j] + " ");
                }
                writer.WriteLine();
            }
            writer.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
