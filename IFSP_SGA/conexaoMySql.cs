using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;

namespace IFSP_SGA
{
    public class conexaoMySql
    {

        private MySqlConnection conn;

        private string servidor = "";
        private string database = "";
        private string usuario = "";
        private string senha = "";

        private void dadosconexao()
        {
            string caminho = @"E:\IFSP Piracicaba\4º Semestre\Linguagem de Programação 1\IFSP_SGA\acesso.txt";
            string linha = "";

            if (System.IO.File.Exists(caminho))
            {
                StreamReader arquivo = new StreamReader(caminho);

                while (arquivo.EndOfStream == false)
                {
                    linha = arquivo.ReadLine().ToString();

                    if (linha.Contains("servidor="))
                    {
                        servidor = linha.Substring(9, linha.Length - 9);
                    }

                    else if (linha.Contains("database="))
                    {
                        database = linha.Substring(9, linha.Length - 9);
                    }

                    else if (linha.Contains("usuario="))
                    {
                        usuario = linha.Substring(8, linha.Length - 8);
                    }

                    else if (linha.Contains("senha="))
                    {
                        senha = linha.Substring(6, linha.Length - 6);
                    }
                }
            }
        }

        private void conectaMySql()
        {
            try
            {
                dadosconexao();
                conn = new MySqlConnection("server=" + servidor + ";uid=" + usuario + ";database=" + database + ";pwd=" + senha + ";SSL Mode=None");
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

        }

        public void desconetaMysql(MySqlConnection conn)
        {
            conn.Close();
        }

        public MySqlDataAdapter executaRetornaDados(string instrucaoSql)
        {
            conectaMySql();
            MySqlDataAdapter adapter = new MySqlDataAdapter(instrucaoSql, conn);
            return adapter;
        }

        public void executarSql(string instrucaoSQL)
        {
            conectaMySql();
            MySqlCommand command = new MySqlCommand(instrucaoSQL, conn);
            command.ExecuteNonQuery();
        }
    }
}
