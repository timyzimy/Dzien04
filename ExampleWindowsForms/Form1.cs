using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleWindowsForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResult.Text = String.Empty;
                tbName.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btName_Click(object sender, EventArgs e)
        {
            // obsluga zdarzenia na nacisniecie przycisku
            lblResult.Text = tbName.Text;
        }

        private void clickButtonEvent(object sender, EventArgs e)
        {
            lblResult.Text = String.Format("Witaj, {0}", tbName.Text);
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
