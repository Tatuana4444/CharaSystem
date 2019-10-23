using System;
using System.Windows.Forms;

namespace login
{
    public partial class classchoose : Form
    {
        public classchoose()
        {
            InitializeComponent();
        }

        private void ButtonContinue_Click(object sender, EventArgs e)
        {
        
            Main.Class = EditClass.Text;
            EditClass.Text = "";
            Close();
        }

        private void classchoose_Load(object sender, EventArgs e)
        {
            if (Main.FlagEdit)
            {
                EditClass.Text = Main.Class;
                ButtonContinue.Enabled = true;
            }
            else
                ButtonContinue.Enabled = false;
        }

        private void EditClass_TextChanged(object sender, EventArgs e)
        {
            
            if (EditClass.Text == "")
                ButtonContinue.Enabled = false;
            else
                ButtonContinue.Enabled = true;
        }
    }
}
