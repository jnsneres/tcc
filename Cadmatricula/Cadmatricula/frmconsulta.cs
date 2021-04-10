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
    public partial class frmconsulta : Form
    {
        public frmconsulta()
        {
            InitializeComponent();
        }

        

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            try
            {
                string conexao = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Vitor Dias\Documents\aa\TCC\BD\matriculas.accdb";
                OleDbConnection connection = new OleDbConnection(conexao);
                connection.Open();

                String SQL = "Select * from Aluno";

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, connection);

                DataSet DS = new DataSet();

                adapter.Fill(DS, "Aluno");

                dgresultado.DataSource = DS.Tables["Aluno"];
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void frmconsulta_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {


        }

        private void dgresultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmatricula frm = new frmmatricula();

            frm.Codigo = dgresultado.SelectedCells[0].Value.ToString();
            frm.txtnome.Text = dgresultado.SelectedCells[1].Value.ToString();
            frm.txtnascimento.Text = dgresultado.SelectedCells[2].Value.ToString();
            frm.txtrg.Text = dgresultado.SelectedCells[3].Value.ToString();
            frm.txtcpf.Text = dgresultado.SelectedCells[4].Value.ToString();
            frm.txtRua.Text = dgresultado.SelectedCells[5].Value.ToString();
            frm.txtnumres.Text = dgresultado.SelectedCells[6].Value.ToString();
            frm.txtcomplemento.Text = dgresultado.SelectedCells[7].Value.ToString();
            frm.txtapto.Text = dgresultado.SelectedCells[8].Value.ToString();
            frm.txtbloco.Text = dgresultado.SelectedCells[9].Value.ToString();
            frm.txtCep.Text = dgresultado.SelectedCells[10].Value.ToString();
            frm.txtBairro.Text = dgresultado.SelectedCells[11].Value.ToString();
            frm.txtCidade.Text = dgresultado.SelectedCells[12].Value.ToString();
            frm.txtuf.Text = dgresultado.SelectedCells[13].Value.ToString();
            frm.txttelefone.Text = dgresultado.SelectedCells[14].Value.ToString();
            frm.txtcelular.Text = dgresultado.SelectedCells[15].Value.ToString();
            frm.txtcelular2.Text = dgresultado.SelectedCells[16].Value.ToString();
            frm.txtemail.Text = dgresultado.SelectedCells[17].Value.ToString();
            frm.txtcurso.Text = dgresultado.SelectedCells[18].Value.ToString();
            frm.txtano.Text = dgresultado.SelectedCells[19].Value.ToString();
            frm.txtperiodo.Text = dgresultado.SelectedCells[20].Value.ToString();
            frm.txttipocurso.Text = dgresultado.SelectedCells[21].Value.ToString();
            frm.txtescolaridade.Text = dgresultado.SelectedCells[22].Value.ToString();
            frm.txtdataini.Text = dgresultado.SelectedCells[23].Value.ToString();
            frm.txtdataterm.Text = dgresultado.SelectedCells[24].Value.ToString();
            frm.btnsalvar.Visible = false;
            frm.btnalteracao.Visible = true;
            frm.ShowDialog();

        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string conexao = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\usuario\Desktop\TCC\BD\matriculas.accdb";
                OleDbConnection connection = new OleDbConnection(conexao);
                connection.Open();

                
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }

        private void btncadmat_Click(object sender, EventArgs e)
        {
            try
            {
                string conexao = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\usuario\Desktop\TCC\BD\matriculas.accdb";
                OleDbConnection connection = new OleDbConnection(conexao);
                connection.Open();

                String SQL = "Select * from Aluno where nome";

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, connection);

                DataSet DS = new DataSet();

                adapter.Fill(DS, "Aluno");

                dgresultado.DataSource = DS.Tables["Aluno"];
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string conexao = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\usuario\Desktop\TCC\BD\matriculas.accdb";
            OleDbConnection connection = new OleDbConnection(conexao);
           

            string comando = "select * from Aluno where nome =@nome";
            OleDbCommand connetion  = new OleDbCommand(comando, connection);
            connetion.Connection = connection;
             connection.Open();
            OleDbDataReader leitor = connetion.ExecuteReader();
            while (leitor.Read())
            {
                txtnome.text +=
                    
                    leitor.GetString(1) + " " +
                    Environment.NewLine;
            }
            connection.Close();
                   
            }




        }
           }
        
           
            



        
    

