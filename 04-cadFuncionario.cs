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

namespace MPJConstrucoesReformas
{
    public partial class frmCadFuncionario : Form
    {
        string nomeFuncionario, emailFuncionario, senhaFuncionario, statusFuncionario, enderecoFuncionario, nivelFuncionario, empresaFuncionario, horarioFuncionario;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                frmMenu menu = new frmMenu();
                menu.Show();
                Close();
            }
        }

        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
            pnlCadastro.Location = new Point(this.Width / 2 - pnlCadastro.Width / 2, this.Height / 2 - pnlCadastro.Height / 2);
            CarregarEmpresa();
        }

        private void mktDataCadCliente_Click(object sender, EventArgs e)
        {
            mktDataCadCliente.Text = dataCadFuncionario.ToString();
        }

        private void mktDataCadCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        DateTime dataCadFuncionario = DateTime.Now;

        public frmCadFuncionario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Atribuir();
            if(variaveis.funcao == "Cadastro")
            {
                InserirFuncionario();
            }
        }
        private void Atribuir()
        {
            nomeFuncionario = txtNome.Text;
            emailFuncionario = txtEmail.Text;
            senhaFuncionario = txtSenha.Text;
            statusFuncionario = cmbStatus.Text;
            enderecoFuncionario = txtEndereco.Text;
            nivelFuncionario = cmbNivel.Text;
            empresaFuncionario = cmbEmpresa.SelectedValue.ToString();
            horarioFuncionario = cmbHorario.Text;
        }

        private void InserirFuncionario()
        {
            try
            {
                string sql = "INSERT INTO funcionario(idFuncionario, nomeFuncionario, emailFuncionario, senhaFuncionario, dataCadFuncionario, nivelFuncionario, " +
                    "horarioTrabFuncionario, enderecoFuncionario, statusFuncionario, idEmpresa) " +
                    "VALUES (DEFAULT, @nome, @email, @senha, @dataCadFuncionario, @nivel, @horario, @endereco, @status, @empresa);";
                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
                cmd.Parameters.AddWithValue("@nome", nomeFuncionario);
                cmd.Parameters.AddWithValue("@email", emailFuncionario);
                cmd.Parameters.AddWithValue("@senha", senhaFuncionario);
                cmd.Parameters.AddWithValue("@dataCadFuncionario", dataCadFuncionario.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@nivel", nivelFuncionario);
                cmd.Parameters.AddWithValue("@horario", horarioFuncionario);
                cmd.Parameters.AddWithValue("@endereco", enderecoFuncionario);
                cmd.Parameters.AddWithValue("@status", statusFuncionario);
                cmd.Parameters.AddWithValue("@empresa", empresaFuncionario);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario Inserido com sucesso", "Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }

        private void CarregarEmpresa()
        {
            try
            {
                string sql = "SELECT * FROM empresa;";
                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                cmbEmpresa.Items.Clear();
                cmbEmpresa.DataSource = dt;
                cmbEmpresa.DisplayMember = "nomeEmpresa";
                cmbEmpresa.ValueMember = "idEmpresa";
                //cmbServico.SelectedValue.ToString()

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar cliente" + ex, "Erro");
            }
        }
    }
}
