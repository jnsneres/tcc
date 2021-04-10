using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Data.OleDb;
using Correios;

namespace Cadmatricula
{

    public partial class frmmatricula : Form
    {




        public frmmatricula()

        {
            InitializeComponent();

        }

        public String Codigo;

        private void button1_Click(object sender, EventArgs e)
        {


        }


        private void frmmatricula_Load(object sender, EventArgs e)
        {


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void pic1_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            try
            {
                CorreiosApi correiosApi = new CorreiosApi();
                var retorno = correiosApi.consultaCEP(txtCep.Text);
                if (retorno is null)
                {
                    MessageBox.Show("CEP não encontrado", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                txtBairro.Text = retorno.bairro;
                txtCidade.Text = retorno.cidade;
                txtuf.Text = retorno.uf;
                txtRua.Text = retorno.end;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar o CEP: " + erro.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }





        private void btncep_Click(object sender, EventArgs e)
        {



        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string conexao = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\usuario\Desktop\TCC\BD\matriculas.accdb";
                OleDbConnection connection = new OleDbConnection(conexao);
                connection.Open();

                string SQL;
                SQL = "Insert into Aluno(nome,data_nasc,RG,CPF,endereco,numero,complemento,apto,bloco,cep,bairro,cidade,uf,telefone,celular1,celular2,email,curso,ano,periodo,tipo_curso,escolaridade,data_inicio,data_term) Values";
                SQL += "('" + txtnome.Text + "','" + txtnascimento.Text + "','" + txtrg.Text + "','" + txtcpf.Text + "','" + txtRua.Text + "','" + txtnumres.Text + "','" + txtcomplemento.Text + "','" + txtapto.Text + "','" + txtbloco.Text + "','" + txtCep.Text + "','" + txtBairro.Text + "','" + txtCidade.Text + "','" + txtuf.Text + "','" + txttelefone.Text + "','" + txtcelular.Text + "','" + txtcelular2.Text + "','" + txtemail.Text + "','" + txtcurso.Text + "','" + txtano.Text + "','" + txtperiodo.Text + "','" + txttipocurso.Text + "','" + txtescolaridade.Text + "','" + txtdataini.Text + "','" + txtdataterm.Text + "')";
                OleDbCommand dbCommand = new OleDbCommand(SQL, connection);

                dbCommand.ExecuteNonQuery();

                MessageBox.Show("Aluno cadastrado com sucesso!!!");

                txtnome.Clear();
                txtnascimento.Clear();
                txtrg.Clear();
                txtcpf.Clear();
                txtRua.Clear();
                txtnumres.Clear();
                txtcomplemento.Text = "";
                txtapto.Clear();
                txtbloco.Clear();
                txtCep.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                txtuf.Clear();
                txttelefone.Clear();
                txtcelular.Clear();
                txtcelular2.Clear();
                txtemail.Clear();
                txtcurso.Clear();
                txtano.Text = "";
                txtperiodo.Text = "";
                txttipocurso.Text = "";
                txtescolaridade.Clear();
                txtdataini.Clear();
                txtdataterm.Clear();

                connection.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }


        }

        private void txtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtperiodo_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void txtano_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == ' ';
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog TrocarImagem = new OpenFileDialog();
            TrocarImagem.Filter = "Bitmap|*.bpm|jpegs|*.jpg";

            if (TrocarImagem.ShowDialog() == DialogResult.OK)
            {
                pic1.ImageLocation = TrocarImagem.FileName;
            }

        }

        private void btnsairlogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtRua_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnalteracao_Click(object sender, EventArgs e)
        {


            String conexao = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\usuario\Desktop\TCC\BD\matriculas.accdb";
            OleDbConnection connection = new OleDbConnection(conexao);
            connection.Open();

            String SQL;

            SQL = "update Aluno set nome = '" + txtnome.Text + "',";
            SQL += "data_nasc ='" + txtnascimento.Text + "' ";
            SQL += "WHERE Codigo = " + Codigo;
            //SQL += "data_nasc ='" + txtnascimento.Text + "',";
            //  SQL += "data_nasc ='" + txtnascimento.Text + "',";
            //  SQL += "data_nasc ='" + txtnascimento.Text + "',";
            /// SQL += "data_nasc ='" + txtnascimento.Text + "',";
            // SQL += "data_nasc ='" + txtnascimento.Text + "',";
            //SQL += "data_nasc ='" + txtnascimento.Text + "',";
            //SQL += "data_nasc ='" + txtnascimento.Text + "',";
            //SQL += "data_nasc ='" + txtnascimento.Text + "',";

            OleDbCommand cmd = new OleDbCommand(SQL, connection);
            cmd.ExecuteNonQuery();

            connection.Close();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog TrocarImagem = new OpenFileDialog();
            TrocarImagem.Filter = "Bitmap|.bmp|*.jpegs|*jpg";

            if (TrocarImagem.ShowDialog() == DialogResult.OK)
            {
                pic1.ImageLocation = TrocarImagem.FileName;
            }
        }
    }





    
        }
    
    






    

