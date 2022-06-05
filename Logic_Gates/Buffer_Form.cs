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
    public partial class Buffer_Form : Form
    {
        public Buffer_Form()
        {
            InitializeComponent();
        }
        private void checkBox_OR_A_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_OR_A.Checked == false)
            {
                pictureBox_Not1.Visible = false;
                pictureBox_Not.Visible = true;
            }
            else
            {
                pictureBox_Not1.Visible = true;
                pictureBox_Not.Visible = false;
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
