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
    public partial class AddPerson : Form
    {
        string Dig = "1234567890";
        public AddPerson()
        {
            InitializeComponent();
            if (Main.IsChange)
            {
                Surname.Text = Main.FullName;
                EditBirthday.Text = Main.Birthdays;
                NumbPass.Text = Main.StPass;
                EditAdress.Text = Main.StHome;
                EditLiv.Text = Main.StHomeInfo;

                EditHealth.Text = Main.StHealth;
                EditBehavior.Text = Main.Stbehvior;

                EditShool.Text = Main.StShool;
                EditPolice.Text = Main.StPolice;
                EditMotherName.Text = Main.StMName;
                EditFatherName.Text = Main.StFName;
                EditCountBroth_Sister.Text = Main.StBr_Sist;
                EditFamilyInfo.Text = Main.StFamNote;
                EditMotherWork.Text = Main.StMWork;
                EditMotherWork.Text = Main.StFWork;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {            
            Main.FullName = Surname.Text;
            Main.Birthdays = EditBirthday.Text;
            Main.StPass = NumbPass.Text;
            Main.StHome = EditAdress.Text;
            Main.StHomeInfo = EditLiv.Text;

            Main.StHealth = EditHealth.Text;
            Main.Stbehvior = EditBehavior.Text;

            Main.StShool = EditShool.Text;
            Main.StPolice = EditPolice.Text;
            Main.StMName = EditMotherName.Text;
            Main.StFName = EditFatherName.Text;
            Main.StBr_Sist = EditCountBroth_Sister.Text;
            Main.StFamNote = EditFamilyInfo.Text;
            Main.StMWork = EditMotherWork.Text;
            Main.StFWork = EditMotherWork.Text;


            Surname.Text = "";
            EditBirthday.Text = "";
            NumbPass.Text = "";
            EditAdress.Text = "";
            EditLiv.Text = "";
            EditHealth.Text = "";
            EditBehavior.Text = "";
            EditShool.Text = "";
            EditPolice.Text = "";
            EditMotherName.Text = "";
            EditFatherName.Text = "";
            EditCountBroth_Sister.Text = "";
            EditFamilyInfo.Text = "";
            EditMotherWork.Text = "";
            EditMotherWork.Text = "";
            if (Main.IsChange)
                Main.Changed = true;
            Close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EditCountBroth_Sister_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((Dig.IndexOf(e.KeyChar) > 0) || (e.KeyChar == (char)Keys.Back))
                e.Handled = false;
            else
                e.Handled = true;



        }

        private void Surname_TextChanged(object sender, EventArgs e)
        {
            if ((Surname.Text == "") || (EditBirthday.Text == "") || (NumbPass.Text == "") || (EditAdress.Text == "")
                || (EditLiv.Text == "") || (EditHealth.Text == "") || (EditBehavior.Text == "") || (EditShool.Text == "")
                || (EditPolice.Text == "") || (EditMotherName.Text == "") || (EditFatherName.Text == "") || (EditCountBroth_Sister.Text == "")
                || (EditFamilyInfo.Text == "") || (EditMotherWork.Text == "") || (EditMotherWork.Text == "") 
                || ( (EditPolice.Text[0] != '+')&& (EditPolice.Text[0] != '-') ) || ((EditShool.Text[0] != '+') && (EditShool.Text[0] != '-') ) )
                ButtonEnter.Enabled = false;
            else
                ButtonEnter.Enabled = true;
        }

        private void EditShool_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( ( (EditShool.Text.Length == 0) && ( (e.KeyChar == '+') || (e.KeyChar == '-') ) )|| (EditShool.Text.Length > 0) )
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void EditPolice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((EditPolice.Text.Length == 0) && ((e.KeyChar == '+') || (e.KeyChar == '-'))) || (EditPolice.Text.Length > 0))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
