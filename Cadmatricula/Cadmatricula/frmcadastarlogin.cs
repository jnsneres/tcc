using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Cadmatricula
{
    public partial class frmcadastarlogin : Form
    {
        public frmcadastarlogin()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string conexao = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\usuario\Desktop\TCC\BD\matriculas.accdb";
                OleDbConnection connection = new OleDbConnection(conexao);
                connection.Open();

                string SQL;
                SQL = "Insert into Usuario(nome_func,area,email_func,login,senha,senha2) Values";
                SQL += "('"+txtnomelog.Text+"','"+cbarea.Text+"','"+txtemaillog.Text+"','"+txtlogin.Text+"','"+txtsenha.Text+"','"+txtsenha2.Text+"')";
                OleDbCommand command = new OleDbCommand(SQL, connection);

                command.ExecuteNonQuery();
                MessageBox.Show("Login cadastrado com sucesso!!!");

                txtnomelog.Clear();
                cbarea.Text = "";
                txtemaillog.Clear();
                txtlogin.Clear();
                txtsenha.Clear();
                txtsenha2.Clear();

                connection.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
            frmlogin frmppppp = new frmlogin();
            frmppppp.Show();
            this.Visible = false;
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            frmlogin frmlogin = new frmlogin();
            frmlogin.Show();
            this.Hide();
        }

        private void frmcadastarlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
