using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPJConstrucoesReformas
{
    public partial class frmCadServico : Form
    {
        int codServico, codEmpresa;
        string nomeServico, statusServico, fotoServico1, fotoServico2, fotoServico3, fotoServico4, descServico, nomeEmpresa;

        //FOTOS FTP
        string enderecoServidorFTP = "ftp://kgbz.ddns.net:5021/admin/servico/";
        string usuarioFTP = "mpj";
        string senhaFTP = "$mpj2022";
        string foto1, foto2, foto3, foto4;
        string caminhoFoto1, caminhoFoto2, caminhoFoto3, caminhoFoto4;
        string atFoto1, atFoto2, atFoto3, atFoto4;

        private void frmCadServico_Load(object sender, EventArgs e)
        {
            pnlCadastro.Location = new Point(this.Width / 2 - pnlCadastro.Width / 2, this.Height / 2 - pnlCadastro.Height / 2);
            CarregarEmpresa();
        }

        DateTime dataCadServico = DateTime.Now;

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if(cmbEmpresa.Text == "")
                {
                    MessageBox.Show("Selecione a empresa");
                }
                else
                {
                    variaveis.codEmpresa= Convert.ToInt32(cmbEmpresa.SelectedValue);
                    btnSalvar.Enabled = true;
                    btnSalvar.Focus();
                }
            }
        }

        OpenFileDialog odFoto = new OpenFileDialog();

        private void btnAdicionar4_Click(object sender, EventArgs e)
        {
            try
            {

                odFoto.Multiselect = false;
                odFoto.InitialDirectory = @"C:\Dados\";
                odFoto.Title = "Selcione uma foto";
                odFoto.Filter = "JPG ou PNG (*.jpg ou *.png) | *.jpg; *.png";
                odFoto.CheckFileExists = true;
                odFoto.CheckPathExists = true;
                odFoto.RestoreDirectory = true;

                DialogResult dr = odFoto.ShowDialog();
                pctFotoServico4.Image = Image.FromFile(odFoto.FileName);
                foto4 = "servico/" + Path.GetFileName(odFoto.FileName);

                if (dr == DialogResult.OK)
                {
                    try
                    {
                        atFoto4 = "S";
                        caminhoFoto4 = odFoto.FileName;
                    }
                    catch (SecurityException ex)
                    {
                        MessageBox.Show("Erro de Segurança - Fale com o Admin. \n Messagem: " + ex.Message + "\nDetalhe: \n" + ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nao autorizado a acessar a pasta: \n" + ex.Message, "Erro");
                    }
                }
                btnSalvar.Enabled = true;
            }
            catch
            {
                txtDescServico.Enabled = true;
                txtDescServico.Focus();
            }
        }

        private void btnAdicionar3_Click(object sender, EventArgs e)
        {
            try
            {

                odFoto.Multiselect = false;
                odFoto.InitialDirectory = @"C:\Dados\";
                odFoto.Title = "Selcione uma foto";
                odFoto.Filter = "JPG ou PNG (*.jpg ou *.png) | *.jpg; *.png";
                odFoto.CheckFileExists = true;
                odFoto.CheckPathExists = true;
                odFoto.RestoreDirectory = true;

                DialogResult dr = odFoto.ShowDialog();
                pctFotoServico3.Image = Image.FromFile(odFoto.FileName);
                foto3 = "servico/" + Path.GetFileName(odFoto.FileName);

                if (dr == DialogResult.OK)
                {
                    try
                    {
                        atFoto3 = "S";
                        caminhoFoto3 = odFoto.FileName;
                    }
                    catch (SecurityException ex)
                    {
                        MessageBox.Show("Erro de Segurança - Fale com o Admin. \n Messagem: " + ex.Message + "\nDetalhe: \n" + ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nao autorizado a acessar a pasta: \n" + ex.Message, "Erro");
                    }
                }
                btnSalvar.Enabled = true;
            }
            catch
            {
                txtDescServico.Enabled = true;
                txtDescServico.Focus();
            }
        }

        private void btnAdicionar2_Click(object sender, EventArgs e)
        {
            try
            {

                odFoto.Multiselect = false;
                odFoto.InitialDirectory = @"C:\Dados\";
                odFoto.Title = "Selcione uma foto";
                odFoto.Filter = "JPG ou PNG (*.jpg ou *.png) | *.jpg; *.png";
                odFoto.CheckFileExists = true;
                odFoto.CheckPathExists = true;
                odFoto.RestoreDirectory = true;

                DialogResult dr = odFoto.ShowDialog();
                pctFotoServico2.Image = Image.FromFile(odFoto.FileName);
                foto2 = "servico/" + Path.GetFileName(odFoto.FileName);

                if (dr == DialogResult.OK)
                {
                    try
                    {
                        atFoto2 = "S";
                        caminhoFoto2 = odFoto.FileName;
                    }
                    catch (SecurityException ex)
                    {
                        MessageBox.Show("Erro de Segurança - Fale com o Admin. \n Messagem: " + ex.Message + "\nDetalhe: \n" + ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nao autorizado a acessar a pasta: \n" + ex.Message, "Erro");
                    }
                }
                btnSalvar.Enabled = true;
            }
            catch
            {
                txtDescServico.Enabled = true;
                txtDescServico.Focus();
            }
        }

        private void btnAdicionar1_Click(object sender, EventArgs e)
        {
            try
            {

            odFoto.Multiselect = false;
            odFoto.InitialDirectory = @"C:\Dados\";
            odFoto.Title = "Selcione uma foto";
            odFoto.Filter = "JPG ou PNG (*.jpg ou *.png) | *.jpg; *.png";
            odFoto.CheckFileExists = true;
            odFoto.CheckPathExists = true;
            odFoto.RestoreDirectory = true;

            DialogResult dr = odFoto.ShowDialog();
            pctFotoServico1.Image = Image.FromFile(odFoto.FileName);
            foto1 = "servico/" + Path.GetFileName(odFoto.FileName);

            if(dr == DialogResult.OK)
            {
                try
                {
                    atFoto1 = "S";
                    caminhoFoto1 = odFoto.FileName;
                }
                catch(SecurityException ex)
                {
                    MessageBox.Show("Erro de Segurança - Fale com o Admin. \n Messagem: " + ex.Message + "\nDetalhe: \n" + ex.StackTrace);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Nao autorizado a acessar a pasta: \n" + ex.Message, "Erro");
                }
            }
            
            }
            catch
            {
                txtDescServico.Enabled = true;
                txtDescServico.Focus();
            }
        }
        public frmCadServico()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Atribuir();

            if(variaveis.funcao == "Cadastro")
            {
                InserirServico();
                frmMenu menu = new frmMenu();
                menu.Show();
                Close();
            }
            else if (variaveis.funcao == "Alterar")
            {
               
            }
        }

        private void Atribuir()
        {
            nomeServico = txtNome.Text;
            statusServico = cmbStatus.Text;
            descServico = txtDescServico.Text;
            variaveis.codEmpresa = Convert.ToInt32(cmbEmpresa.SelectedValue);

        }

        private void CarregarEmpresa()
        {
            try
            {
                banco.Conectar();
                var sql = "SELECT idEmpresa, nomeEmpresa FROM empresa ORDER BY nomeEmpresa";
                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbEmpresa.DataSource = dt; 
                cmbEmpresa.DisplayMember = "nomeEmpresa";
                cmbEmpresa.ValueMember = "idEmpresa";
                cmbEmpresa.Text = string.Empty;
                banco.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os Dados. Erro de Rede. Tente Novamente" + ex.Message, "Erro");
            }
        }

        private void InserirServico()
        {
            try
            {
                banco.Conectar();
                string sql = "INSERT INTO servico(idServico, nomeServico, statusServico, descServico, dataCadServico, fotoServico, fotoServico02, fotoServico03, fotoServico04, idEmpresa) " +
                    "VALUES (DEFAULT, @nome, @status, @descServico, @dataCadServico, @foto1, @foto2, @foto3, @foto4, @codEmpresa);";
                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
                cmd.Parameters.AddWithValue("@nome", nomeServico);
                cmd.Parameters.AddWithValue("@status", statusServico);
                cmd.Parameters.AddWithValue("@descServico", descServico);
                cmd.Parameters.AddWithValue("@dataCadServico", dataCadServico.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@foto1", foto1);
                cmd.Parameters.AddWithValue("@foto2", foto2);
                cmd.Parameters.AddWithValue("@foto3", foto3);
                cmd.Parameters.AddWithValue("@foto4", foto4);
                cmd.Parameters.AddWithValue("@codEmpresa", variaveis.codEmpresa);
                cmd.ExecuteNonQuery();
                banco.Desconectar();

                if (ValidarFTP())
                {
                    if (!string.IsNullOrEmpty(foto1))
                    {
                        string urlArquivoEnviar = enderecoServidorFTP + Path.GetFileName(foto1);
                        try
                        {
                            FTP.EnviarArquivoFTP(caminhoFoto1, urlArquivoEnviar, usuarioFTP, senhaFTP);
                        }
                        catch
                        {
                            MessageBox.Show("Foto 1 não foi selecionada", "FOTO 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if (ValidarFTP())
                {
                    if (!string.IsNullOrEmpty(foto2))
                    {
                        string urlArquivoEnviar = enderecoServidorFTP + Path.GetFileName(foto2);
                        try
                        {
                            FTP.EnviarArquivoFTP(caminhoFoto2, urlArquivoEnviar, usuarioFTP, senhaFTP);
                        }
                        catch
                        {
                            MessageBox.Show("Foto 2 não foi selecionada", "FOTO 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if (ValidarFTP())
                {
                    if (!string.IsNullOrEmpty(foto3))
                    {
                        string urlArquivoEnviar = enderecoServidorFTP + Path.GetFileName(foto3);
                        try
                        {
                            FTP.EnviarArquivoFTP(caminhoFoto3, urlArquivoEnviar, usuarioFTP, senhaFTP);
                        }
                        catch
                        {
                            MessageBox.Show("Foto 3 não foi selecionada", "FOTO 3", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if (ValidarFTP())
                {
                    if (!string.IsNullOrEmpty(foto4))
                    {
                        string urlArquivoEnviar = enderecoServidorFTP + Path.GetFileName(foto4);
                        try
                        {
                            FTP.EnviarArquivoFTP(caminhoFoto4, urlArquivoEnviar, usuarioFTP, senhaFTP);
                        }
                        catch
                        {
                            MessageBox.Show("Foto 4 não foi selecionada", "FOTO 4", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                MessageBox.Show("Serviço cadastrado com sucesso!", "Cadastro de Cliente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar cliente" + ex, "Erro");
            }
        }

        private bool ValidarFTP()
        {
            if(string.IsNullOrEmpty(enderecoServidorFTP) || string.IsNullOrEmpty(usuarioFTP) || string.IsNullOrEmpty(senhaFTP))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public byte[] GetImgByte(string ftpFilePath)
        {
            WebClient ftpClient = new WebClient();
            ftpClient.Credentials = new NetworkCredential(usuarioFTP, senhaFTP);
            byte[] imageByte = ftpClient.DownloadData(ftpFilePath);
            return imageByte;
        }
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
   }
}
