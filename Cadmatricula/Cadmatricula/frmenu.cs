using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadmatricula
{
    public partial class Menu : Form
    {
       
        public Menu()
        {
            InitializeComponent();
        }

        private void btnsairlogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncad_Click(object sender, EventArgs e)
        {

            frmmatricula frmpp = new frmmatricula();
            frmpp.Show();
            this.Visible = false;
        }

        private void frmenu_Load(object sender, EventArgs e)
        {

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
           frmconsulta frmppp = new frmconsulta();
            frmppp.Show();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lblhora.Text = DateTime.Now.ToLongTimeString();
            
        }

        private void lblhoraa_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void btncadmat_Click(object sender, EventArgs e)
        {
            frmmatricula frmpp = new frmmatricula();
            frmpp.Show();
            this.Visible = false;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            frmconsulta frmppp = new frmconsulta();
            frmppp.Show();
        }
    }
}
