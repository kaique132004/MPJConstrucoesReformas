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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        int linhaAtual;
        string dadosNome;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja sair do programa", "Sair", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                frmLogin login = new frmLogin();
                login.Show();
                Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void CarregarCliente()
        {
            try
            {
                var sql = "SELECT * FROM cliente";
                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);



                dgvMenu.DataSource = dt;
                dgvMenu.Columns[0].HeaderText = "CÓDIGO";
                dgvMenu.Columns[0].Width = 75;
                dgvMenu.Columns[1].HeaderText = "NOME DO CLIENTE";
                dgvMenu.Columns[1].Width = 300;
                dgvMenu.Columns[2].HeaderText = "E-MAIL";
                dgvMenu.Columns[2].Width = 220;
                dgvMenu.Columns[3].HeaderText = "SENHA";
                dgvMenu.Columns[4].HeaderText = "ENDEREÇO";
                dgvMenu.Columns[4].Width = 300;
                dgvMenu.Columns[5].HeaderText = "STATUS";
                dgvMenu.Columns[5].Width = 75;
                dgvMenu.Columns[6].HeaderText = "DATA DE CADASTRO";
                dgvMenu.Columns[6].Width = 120;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CarregarFuncionario()
        {
            try
            {
                var sql = "SELECT idFuncionario, nomeFuncionario, emailFuncionario, senhaFuncionario, dataCadFuncionario, nivelFuncionario, horarioTrabFuncionario, enderecoFuncionario, statusFuncionario, " +
                    "empresa.nomeEmpresa FROM funcionario INNER JOIN empresa ON funcionario.idEmpresa = empresa.idEmpresa ORDER BY nomeFuncionario";
                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);



                dgvMenu.DataSource = dt;
                dgvMenu.Columns[0].HeaderText = "CÓDIGO";
                dgvMenu.Columns[0].Width = 75;
                dgvMenu.Columns[1].HeaderText = "NOME DO CLIENTE";
                dgvMenu.Columns[1].Width = 250;
                dgvMenu.Columns[2].HeaderText = "E-MAIL";
                dgvMenu.Columns[2].Width = 250;
                dgvMenu.Columns[3].HeaderText = "SENHA";
                dgvMenu.Columns[4].HeaderText = "DATA DE CADASTRO";
                dgvMenu.Columns[4].Width = 170;
                dgvMenu.Columns[5].HeaderText = "NÍVEL";
                dgvMenu.Columns[5].Width = 170;
                dgvMenu.Columns[6].HeaderText = "HORARIO";
                dgvMenu.Columns[6].Width = 120;
                dgvMenu.Columns[7].HeaderText = "ENDEREÇO";
                dgvMenu.Columns[7].Width = 200;
                dgvMenu.Columns[8].HeaderText = "STATUS";
                dgvMenu.Columns[8].Width = 80;
                dgvMenu.Columns[9].HeaderText = "EMPRESA";
                dgvMenu.Columns[9].Width = 230;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CarregarServico()
        {
            try
            {
                var sql = "SELECT * FROM servico ORDER BY nomeServico";
                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);



                dgvMenu.DataSource = dt;
                dgvMenu.Columns[0].HeaderText = "CÓDIGO";
                dgvMenu.Columns[0].Width = 75;
                dgvMenu.Columns[1].HeaderText = "NOME DO SERVIÇO";
                dgvMenu.Columns[1].Width = 250;
                dgvMenu.Columns[2].HeaderText = "STATUS";
                dgvMenu.Columns[2].Width = 75;
                dgvMenu.Columns[3].HeaderText = "DESCRIÇÃO SERVIÇO";
                dgvMenu.Columns[3].Width = 250;
                dgvMenu.Columns[4].HeaderText = "DATA DE CADASTRO";
                dgvMenu.Columns[4].Width = 170;
                dgvMenu.Columns[5].HeaderText = "FOTO";
                dgvMenu.Columns[6].HeaderText = "FOTO 2";
                dgvMenu.Columns[7].HeaderText = "FOTO 3";
                dgvMenu.Columns[8].HeaderText = "FOTO 4";
                dgvMenu.Columns[8].Width = 170;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CarregarAgendamento()
        {
            try
            {
                var sql = "SELECT idAgendamento, dataAgendamento, horaAgendamento, progressoAgendamento, servico.nomeServico, cliente.nomeCliente, funcionario.nomeFuncionario " +
                    "FROM agendamento INNER JOIN servico ON agendamento.idServico = servico.idServico INNER JOIN cliente ON agendamento.idCliente = cliente.idCliente " +
                    "INNER JOIN funcionario ON agendamento.idFuncionario = funcionario.idFuncionario ORDER BY idAgendamento;";
                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);



                dgvMenu.DataSource = dt;
                dgvMenu.Columns[0].HeaderText = "CÓDIGO";
                dgvMenu.Columns[0].Width = 80;
                dgvMenu.Columns[1].HeaderText = "DATA AGENDAMENTO";
                dgvMenu.Columns[1].Width = 150;
                dgvMenu.Columns[2].HeaderText = "HORA";
                dgvMenu.Columns[2].Width = 80;
                dgvMenu.Columns[3].HeaderText = "PROGRESSO";
                dgvMenu.Columns[3].Width = 150;
                dgvMenu.Columns[4].HeaderText = "SERVICO";
                dgvMenu.Columns[4].Width = 250;
                dgvMenu.Columns[5].HeaderText = "CLIENTE";
                dgvMenu.Columns[5].Width = 350;
                dgvMenu.Columns[6].HeaderText = "FUNCIONARIO";
                dgvMenu.Columns[6].Width = 350;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AtualizarAgendamento()
        {
            if (dgvMenu.SelectedRows.Count > 0)
            {
                try
                {
                    var sql = "UPDATE agendamento SET progressoAgendamento='APROVADO' WHERE idAgendamento = '" + variaveis.codAgendamento +"'";
                    MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Agendamento Alterado com sucesso!", "Alteração de Agendamento");
                    

                    CarregarAgendamento();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

            }
        }
        private void DesativarBotoes()
        {
            btnAgendar.Visible = false;
            btnCancelar.Visible = false;
            btnAprovar.Visible = false;
        }
        private void AtivarBotoes()
        {
            btnAgendar.Visible = true;
            btnCancelar.Visible = true;
            btnAprovar.Visible = true;
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            lblNome.Text = ("Cliente");
            CarregarCliente();
            variaveis.tipo = ("Cliente");
            DesativarBotoes();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            lblNome.Text = ("Funcionario");
            CarregarFuncionario();
            variaveis.tipo = ("Funcionario");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = ("Cadastro");
            if(variaveis.tipo == "Cliente")
            {
                frmCadCliente cadCliente = new frmCadCliente();
                cadCliente.Show();
                Hide();
            }
            else if(variaveis.tipo == "Funcionario")
            {
                frmCadFuncionario cadFuncionario = new frmCadFuncionario();
                cadFuncionario.Show();
                Hide();
            }
            else if (variaveis.tipo == "Servico")
            {
                frmCadServico servico = new frmCadServico();
                servico.Show();
                Hide();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = ("Alterar");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            variaveis.funcao = ("Exluir");
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            lblNome.Text = ("Serviços");
            CarregarServico();
            variaveis.tipo = ("Servico");
            DesativarBotoes();
        }

        private void brnAgendamento_Click(object sender, EventArgs e)
        {
            lblNome.Text = ("Agendamento");
            CarregarAgendamento();
            variaveis.tipo = ("Agendamento");
            AtivarBotoes();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            dadosNome = txtBusca.Text;
            if(variaveis.tipo == "Agendamento")
            {
                AtivarBotoes();
            }
            else
            {
                DesativarBotoes();
            }
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            if(variaveis.tipo == "Agendamento")
            {
                var result = MessageBox.Show("Deseja aprovar o agendamento", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    AtualizarAgendamento();
                }
                else
                {
                    brnAgendamento.PerformClick();
                }
            }
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            if (variaveis.tipo == "Agendamento")
            {
                frmCadAgendamento agenda = new frmCadAgendamento();
                agenda.Show();
                Hide();
            }
        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
            if (linhaAtual >= 0)
            {
                if (variaveis.tipo == "Cliente")
                {
                    variaveis.codCliente = Convert.ToInt32(dgvMenu[0, linhaAtual].Value);
                }
                else if (variaveis.tipo == "Funcionario")
                {
                    variaveis.codFuncionario = Convert.ToInt32(dgvMenu[0, linhaAtual].Value);
                }
                else if (variaveis.tipo == "Servico")
                {
                    variaveis.codServico = Convert.ToInt32(dgvMenu[0, linhaAtual].Value);
                }
                else if (variaveis.tipo == "Agendamento")
                {
                    variaveis.codAgendamento = Convert.ToInt32(dgvMenu[0, linhaAtual].Value);
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count > 0)
            {
                try
                {
                    var sql = "UPDATE agendamento SET progressoAgendamento='CANCELADO' WHERE idAgendamento = '" + variaveis.codAgendamento + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Agendamento Alterado com sucesso!", "Alteração de Agendamento");


                    CarregarAgendamento();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

            }
        }
    }

}
