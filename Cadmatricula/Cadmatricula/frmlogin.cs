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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsairlogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnentrar_Click(object sender, EventArgs e)
        {
            try
            {
                string conexao = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\usuario\Desktop\TCC\BD\matriculas.accdb";
                OleDbConnection connection = new OleDbConnection(conexao);
                connection.Open();

                String SQL = "SELECT * FROM Usuario WHERE login = '" + txtlogin.Text + "' AND senha = '" + txtsenha.Text + "' AND area ='" + cblogin.Text + "' ";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(SQL, conexao);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {

                    Menu frmp = new Menu();
                    frmp.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmcadastarlogin frmpppppp = new frmcadastarlogin();
            frmpppppp.Show();
            this.Hide();

        }

        private void lblesqueceu_Click(object sender, EventArgs e)
        {

        }

        private void txtsenha2_OnValueChanged(object sender, EventArgs e)
        {

        }



        private void txtlogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlogin_Enter(object sender, EventArgs e)
        {
            if (txtlogin.Text == "Usuário")
            {
                txtlogin.Text = "";
                txtlogin.ForeColor = Color.White;
            }
        }

        private void txtlogin_Leave(object sender, EventArgs e)
        {
            if (txtlogin.Text == "")
            {
                txtlogin.Text = "Usuário";
                txtlogin.ForeColor = Color.Black;
            }
        }


        private void txtsenha_Enter(object sender, EventArgs e)
        {
            if (txtsenha.Text == "Senha")
            {
                txtsenha.Text = "";
                txtsenha.ForeColor = Color.Black;
            }
        }

        private void txtsenha_Leave(object sender, EventArgs e)
        {
            if (txtsenha.Text == "Senha")
            {
                txtsenha.Text = "";
                txtsenha.ForeColor = Color.Black;
              
            }
        }

        private void btnentrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string conexao = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\usuario\Desktop\TCC\BD\matriculas.accdb";
                OleDbConnection connection = new OleDbConnection(conexao);
                connection.Open();

                String SQL = "SELECT * FROM Usuario WHERE login = '" + txtlogin.Text + "' AND senha = '" + txtsenha.Text + "' AND area ='" + cblogin.Text + "' ";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(SQL, conexao);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {

                    Menu frmp = new Menu();
                    frmp.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }
    }
    }


