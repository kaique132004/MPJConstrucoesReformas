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
    public partial class frmLogin : Form
    {
        string senhaUsuario;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void pctFechar_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja realmente sair? ", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - pnlLogin.Width / 2, this.Height / 2 - pnlLogin.Height / 2);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            variaveis.usuario = txtUser.Text;
            senhaUsuario = txtSenha.Text;

            if((variaveis.usuario == "admin") && (senhaUsuario == "1234"))
            {
                frmMenu menu = new frmMenu();
                menu.Show();
                Hide();
            }
            else
            {
                var result = MessageBox.Show("Senha Incorreta, Deseja tentar novamente", "Senha Incorreta", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                
                if(result == DialogResult.Yes)
                {
                    txtUser.Clear();
                    txtSenha.Clear();
                    txtUser.Focus();
                }
                else
                {
                    Application.Exit();
                }
            }

        }
    }
}
