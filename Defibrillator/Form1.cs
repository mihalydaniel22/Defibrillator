using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Defibrillator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            tbX.Clear();
            tbY.Clear();
            lbKiiras.Items.Clear();
        }

        private void btnLekeres_Click(object sender, EventArgs e)
        {

        }
    }
}
