using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioAvaliacao
{
    public partial class ContasPagar : Form
    {
        public ContasPagar()
        {
            InitializeComponent();

            mostrar();
            btnDeletar.Visible = false;
            btnAlterar.Visible = false;
        }

        string continua = "yes";


        private void btnInserir_Click(object sender, EventArgs e)
        {
            verificaVazio();
            pegaData();


            if (continua == "yes")
            {
                try
                {
                    using (MySqlConnection cnn = new MySqlConnection())
                    {
                        cnn.ConnectionString = Globals.conexao;
                        cnn.Open();
                        MessageBox.Show("Inserido com sucesso!");
                        string sql = "insert into contas (nome, descricao, valor, dataVencimento, tipo) values ('" + txtNome.Text + "','" + txtDescricao.Text + "','" + txtValor.Text + "','" + Globals.DataNova +  "', 0)";
                        MySqlCommand cmd = new MySqlCommand(sql, cnn);
                        cmd.ExecuteNonQuery();



                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }


            mostrar();
            limpar();

        }


        //DELETAR
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja realmente excluir", "Confirmação", MessageBoxButtons.YesNo))
            {

                try
                {
                    using (MySqlConnection cnn = new MySqlConnection())
                    {
                        cnn.ConnectionString = Globals.conexao;
                        cnn.Open();
                        string sql = "Delete from contas where idContasPagar = '" + txtIdContasPagar.Text + "'";
                        MySqlCommand cmd = new MySqlCommand(sql, cnn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(" Deletado com sucesso! ");

                    }
                    limpar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }
            mostrar();

        }



        //ALTERAR

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            pegaData();

            try
            {
                using (MySqlConnection cnn = new MySqlConnection())
                {
                    cnn.ConnectionString = Globals.conexao;
                    //cnn.ConnectionString = "server=localhost;database=controle;uid=root;pwd=;port=3306;Convert Zero DateTime = true";
                    cnn.Open();
                    string sql = "Update contas set nome='" + txtNome.Text + "', descricao='" + txtDescricao.Text + "', valor='" + txtValor.Text + "', dataVencimento='" + Globals.DataNova + "' where idContasPagar=" + txtIdContasPagar.Text + "";
                    MySqlCommand cmd = new MySqlCommand(sql, cnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Atualizado com sucesso!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            mostrar();

        }


        // funções
        void mostrar()
        {

            try
            {
                using (MySqlConnection cnn = new MySqlConnection())
                {
                    cnn.ConnectionString = Globals.conexao;
                    cnn.Open();
                    string sql = "Select * from contas";
                    DataTable table = new DataTable();
                    MySqlDataAdapter adpter = new MySqlDataAdapter(sql, cnn);
                    adpter.Fill(table);
                    dgwContasPagar.DataSource = table;

                    dgwContasPagar.AutoGenerateColumns = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        void pegaData()
        {
            Globals.Data = dtpDataVencimento.Value;
            string dataCurta = Globals.Data.ToShortDateString();
            string[] vetData = dataCurta.Split('/');
            Globals.DataNova = vetData[2] + "-" + vetData[1] + "-" + vetData[0];

        }

        void verificaVazio()
        {
            if (txtNome.Text == "" || txtDescricao.Text == "" || txtValor.Text == "")
            {
                continua = "no";
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                continua = "yes";
            }

        }

        void limpar()
        {
            txtIdContasPagar.Clear();
            txtNome.Clear();
            txtDescricao.Clear(); 
            txtValor.Clear();
            
            btnDeletar.Visible = false;
            btnAlterar.Visible = false;



        }

        private void dgwContasPagar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwContasPagar.CurrentRow.Index != -1)
            {
                txtIdContasPagar.Text = dgwContasPagar.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = dgwContasPagar.CurrentRow.Cells[1].Value.ToString();
                txtDescricao.Text = dgwContasPagar.CurrentRow.Cells[2].Value.ToString();
                txtValor.Text = dgwContasPagar.CurrentRow.Cells[3].Value.ToString();

                dtpDataVencimento.Value = Convert.ToDateTime(dgwContasPagar.CurrentRow.Cells[4].Value.ToString());

                



                btnDeletar.Visible = true;
                btnAlterar.Visible = true;
                btnInserir.Text = "Novo";


            }
        }
    }
}

