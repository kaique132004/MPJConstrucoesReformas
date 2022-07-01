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
    public partial class frmCadCliente : Form
    {
        string nomeCliente, emailCliente, senhaCliente, statusCliente, enderecoCliente;
        DateTime dataCadCliente = DateTime.Now;
        public frmCadCliente()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if(result == DialogResult.No)
            {
                frmMenu menu = new frmMenu();
                menu.Show();
                Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Atribuir();
            if (variaveis.funcao == "Cadastro")
            {
                
                InserirCliente();
                txtCodigo.Text = variaveis.codCliente.ToString();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mktDataCadCliente.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            pnlCadastro.Location = new Point(this.Width / 2 - pnlCadastro.Width / 2, this.Height / 2 - pnlCadastro.Height / 2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Atribuir()
        {
            nomeCliente = txtNome.Text;
            emailCliente = txtEmail.Text;
            senhaCliente = txtSenha.Text;
            statusCliente = cmbStatus.Text;
            enderecoCliente = txtEndereco.Text;
        }

        private void InserirCliente()
        {
            try
            {
                string sql = "INSERT INTO cliente(idCliente, nomeCliente, emailCliente, senhaCliente, enderecoCliente, statusCliente, dataCadCliente) " +
                    "VALUES (DEFAULT, @nome, @email, @senha, @endereco, @status, @dataCadCliente);";
                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
                cmd.Parameters.AddWithValue("@nome", nomeCliente);
                cmd.Parameters.AddWithValue("@email", emailCliente);
                cmd.Parameters.AddWithValue("@senha", senhaCliente);
                cmd.Parameters.AddWithValue("@endereco", enderecoCliente);
                cmd.Parameters.AddWithValue("@status", statusCliente);
                cmd.Parameters.AddWithValue("@dataCadCliente", dataCadCliente.ToString("yyyy-MM-dd"));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente  cadastrado com sucesso!", "Cadastro de Cliente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar cliente" + ex, "Erro");
            }
        }
    }
}
