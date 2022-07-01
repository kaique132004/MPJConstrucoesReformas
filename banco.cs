using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MPJConstrucoesReformas
{
    public static class banco
    {
        public static string db = "Server=kgbz.ddns.net;USER=mpj;PASSWORD=$mpj2022;DATABASE=mpj;SSL Mode=None";
        public static MySqlConnection conexao;

        public static void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(db);
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco " + ex, "Erro");
            }
        }

        public static void Desconectar()
        {
            try
            {
                conexao = new MySqlConnection(db);
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao contatar o banco " + ex, "Erro");
            }
        }
    }
}
