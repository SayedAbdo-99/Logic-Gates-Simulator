using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic_Gates
{
    public partial class Xor_Form : Form
    {
        public Xor_Form()
        {
            InitializeComponent();
        }

        private void checkBox_OR_A_CheckedChanged(object sender, EventArgs e)
        {

            if ((checkBox_OR_A.Checked == true && checkBox_OR_B.Checked == true) || (checkBox_OR_A.Checked == false && checkBox_OR_B.Checked == false))
            {
                pictureBox_OR.Visible = false;
                pictureBox_OR1.Visible = true;
            }
            else if ((checkBox_OR_A.Checked == true && checkBox_OR_B.Checked == false) || (checkBox_OR_A.Checked == false && checkBox_OR_B.Checked == true))
            {
                pictureBox_OR.Visible = true;
                pictureBox_OR1.Visible = false;
            }
            
        }

        private void checkBox_OR_B_CheckedChanged(object sender, EventArgs e)
        {

            if ((checkBox_OR_A.Checked == true && checkBox_OR_B.Checked == true) || (checkBox_OR_A.Checked == false && checkBox_OR_B.Checked == false))
            {
                pictureBox_OR.Visible = false;
                pictureBox_OR1.Visible = true;

            }
            else if ((checkBox_OR_A.Checked == true && checkBox_OR_B.Checked == false)||(checkBox_OR_A.Checked == false && checkBox_OR_B.Checked == true))
            {
                pictureBox_OR.Visible = true;
                pictureBox_OR1.Visible = false;
            }
            
        }
        private void Btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 back = new Form1();
            back.ShowDialog();
            this.Close();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
