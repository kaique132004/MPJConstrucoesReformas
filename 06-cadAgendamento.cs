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
    public partial class frmCadAgendamento : Form
    {
        string progresso, servico, cliente, funcionario;
        DateTime dataCadAgendamento = DateTime.Now;
        DateTime dataAgendamento, horaAgenda;
        
        public frmCadAgendamento()
        {
            InitializeComponent();
        }

        private void frmCadAgendamento_Load(object sender, EventArgs e)
        {
            CarregarServico();
            CarregarCliente();
            CarregarFuncionario();
        }

        private void mktDataCadAgendamento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mktData.Text = DateTime.Now.ToShortDateString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Atribuir();
            
                InserirAgendamento();
            
        }

        private void Atribuir()
        {
            horaAgenda = Convert.ToDateTime("00:00:00");

            progresso = cmbProgresso.Text;
            servico = cmbServico.SelectedValue.ToString(); 
            cliente = cmbCliente.SelectedValue.ToString(); 
            funcionario = cmbFuncionario.SelectedValue.ToString();
            dataAgendamento = Convert.ToDateTime(mktData.Text);
            horaAgenda = Convert.ToDateTime(mktHora.Text);

        }

        private void CarregarServico()
        {
            try
            {
                string sql = "SELECT * FROM servico;";
                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                cmbServico.Items.Clear();
                cmbServico.DataSource = dt;
                cmbServico.DisplayMember = "nomeServico";
                cmbServico.ValueMember = "idServico";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar cliente" + ex, "Erro");
            }
        }

        private void CarregarCliente()
        {
            try
            {
                string sql = "SELECT * FROM cliente;";
                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                cmbCliente.Items.Clear();
                cmbCliente.DataSource = dt;
                cmbCliente.DisplayMember = "nomeCliente";
                cmbCliente.ValueMember = "idCliente";
                //cmbServico.SelectedValue.ToString()
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar cliente" + ex, "Erro");
            }
        }

        private void CarregarFuncionario()
        {
            try
            {
                string sql = "SELECT * FROM funcionario;";
                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                cmbFuncionario.Items.Clear();
                cmbFuncionario.DataSource = dt;
                cmbFuncionario.DisplayMember = "nomeFuncionario";
                cmbFuncionario.ValueMember = "idFuncionario";
                //cmbServico.SelectedValue.ToString()
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar cliente" + ex, "Erro");
            }
        }

        private void InserirAgendamento()
        {
            try
            {
                string sql = "INSERT INTO agendamento(idAgendamento, dataAgendamento, horaAgendamento, progressoAgendamento, dataCadAgendamento, idServico, idCliente, idFuncionario) " +
                    "VALUES (DEFAULT, @dataAgenda, @horaAgenda, @progressoAgenda, @dataCadAgenda, @servico, @cliente, @funcionario);";
                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
                cmd.Parameters.AddWithValue("@dataAgenda", dataAgendamento.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@horaAgenda", horaAgenda.ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("@progressoAgenda", progresso);
                cmd.Parameters.AddWithValue("@dataCadAgenda", dataCadAgendamento.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@servico", servico);
                cmd.Parameters.AddWithValue("@cliente", cliente);
                cmd.Parameters.AddWithValue("@funcionario", funcionario);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente  cadastrado com sucesso!", "Cadastro de Cliente");
                MessageBox.Show("valor" + cmbServico.SelectedValue.ToString() +
                                          "\n" + cmbFuncionario.SelectedValue.ToString() +
                                          "\n" + cmbCliente.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar cliente" + ex, "Erro");
            }
        }

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
    }
}
