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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Btm_OR_Click(object sender, EventArgs e)
        {
            this.Hide();
            OR_Form or = new OR_Form();
            or.ShowDialog();
            this.Close();
        }
        private void Btm_AND_Click(object sender, EventArgs e)
        {
            this.Hide();
            And_Form and = new And_Form();
            and.ShowDialog();
            this.Close();
        }
        private void Btm_NOT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Not_Form not = new Not_Form();
            not.ShowDialog();
            this.Close();
        }
        private void Btm_XOR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Xor_Form xor = new Xor_Form();
            xor.ShowDialog();
            this.Close();
        }
        private void Btm_NOR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nor_Form nor = new Nor_Form();
            nor.ShowDialog();
            this.Close();
        }
        private void Btm_NAND_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nand_Form nand = new Nand_Form();
            nand.ShowDialog();
            this.Close();
        }
        private void Btm_NXOR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Xnor_Form nxor = new Xnor_Form();
            nxor.ShowDialog();
            this.Close();
        }
        private void Btn_Buffer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Buffer_Form buffer = new Buffer_Form();
            buffer.ShowDialog();
            this.Close();
        }
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
