using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lythuyettongquanvelaptrinhgd1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void groupPanelTabcontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupbox grb = new groupbox();
            grb.Show();
        }

        private void ptb_Click(object sender, EventArgs e)
        {
            imagelist iml = new imagelist();
            iml.Show();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menustrip menustrip = new menustrip();
            menustrip.Show();
        }
    }
}
