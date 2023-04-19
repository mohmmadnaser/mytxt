using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void selaectFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            rtx.SelectionFont = fontDialog1.Font;

        }

        private void selactColerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            rtx.SelectionColor = colorDialog1.Color;
        }

        private void selToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtx.SelectAll();

        }

        private void copeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtx.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtx.Cut();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtx.Paste();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons  buttons = MessageBoxButtons.YesNo;
            
           DialogResult = MessageBox.Show ("you Exit this programing!" ,"warning"  ,buttons);

           if (DialogResult == DialogResult.Yes)
            {

                Application.Exit();
            }
                
                
          
                
           




        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
