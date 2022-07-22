using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;

namespace IFSP_SGA
{
    public class csDisciplina
    {
        private int idDisc;
        private string nomeDisc;
        private string siglaDisc;
        private int cargaHorariaDisc;
        private int semestreDisc;
        private bool teoricaDisc;
        private bool praticaDisc;
        private bool obrigatoriaDisc;
        private string descricaoDisc;
        private string preRequisitoDisc;

        private conexaoMySql conexao = new conexaoMySql();

        public void setDiscId(int valor)
        {
            idDisc = valor;
        }

        public int getDiscId()
        {
            return idDisc;
        }

        public void SetDiscNome(string valor)
        {
            nomeDisc = valor;
        }

        public string getDiscNome()
        {
            return nomeDisc;
        }

        public void setDiscSigla(string valor)
        {
            siglaDisc = valor;
        }

        public string getDiscSigla()
        {
            return siglaDisc;
        }

        public void setDiscCargaHoraria(int valor)
        {
            cargaHorariaDisc = valor;
        }

        public int getDiscCargaHoraria()
        {
            return cargaHorariaDisc;
        }

        public void setDiscSemestre(int valor)
        {
            semestreDisc = valor;
        }

        public int getDiscSemestre()
        {
            return semestreDisc;
        }

        public void setDiscTeorica(bool valor)
        {
            teoricaDisc = valor;
        }

        public bool getDiscTeorica()
        {
            return teoricaDisc;
        }

        public void setDiscPratica(bool valor)
        {
            praticaDisc = valor;
        }

        public bool getDiscDiscpratica()
        {
            return praticaDisc;
        }

        public void setDiscObrigatoria(bool valor)
        {
            obrigatoriaDisc = valor;
        }

        public bool getDiscObrigatoria()
        {
            return obrigatoriaDisc;
        }

        public void setDiscDescricao(string valor)
        {
            descricaoDisc = valor;
        }

        public string getDiscDescricao()
        {
            return descricaoDisc;
        }

        public void setDiscPreRequisito(string valor)
        {
            preRequisitoDisc = valor;
        }

        public string getDiscPreRequisito()
        {
            return preRequisitoDisc;
        }

        public void inserir()
        {
            string sql = "INSERT INTO disciplina(disciplinasigla, disciplinanome, disciplinadescricao, disciplinacargahoraria,";
            sql += "disciplinateorica, disciplinapratica, disciplinaobrigatoria, disciplinarequisitos, disciplinasemestre) VALUES (";
            sql += "'" + siglaDisc + "', ";
            sql += "'" + nomeDisc + "', ";
            sql += "'" + descricaoDisc + "', ";
            sql += cargaHorariaDisc + ", ";
            sql += teoricaDisc + ", ";
            sql += praticaDisc + ", ";
            sql += obrigatoriaDisc + ", ";
            sql += "'" + preRequisitoDisc + "', ";
            sql += semestreDisc;
            sql += ")";
            conexao.executarSql(sql);
        }

        public void update()
        {
            string sql = "";
            sql += "UPDATE disciplina SET";
            sql += "disciplinasigla = '" + siglaDisc + "', ";
            sql += "disciplinanome = '" + nomeDisc + "', ";
            sql += "disciplinadescricao = '" + descricaoDisc + "', ";
            sql += "disciplinacargahoraria = " + cargaHorariaDisc + ", ";
            sql += "disciplinateorica = " + teoricaDisc + ", ";
            sql += "disciplinapratica = " + praticaDisc + ", ";
            sql += "disciplinaobrigatoria = " + obrigatoriaDisc + ", ";
            sql += "disciplinarequisitos = '" + preRequisitoDisc + "', ";
            sql += "disciplinasemestre = '" + semestreDisc + "', ";
            sql += "WHERE disciplinaid = " + idDisc + "; ";
            conexao.executarSql(sql);
        }

        public void delete()
        {
            string sql = "Delete from disciplina WHERE disciplinaid = " + idDisc.ToString() + ";";
            conexao.executarSql(sql);
        }

        public DataTable select()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            string sql = "Select disciplinaid, disciplinasigla, disciplinanome from disciplina;";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(tabela);
            return tabela;
        }

        public void selecDisciplina()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet dataset = new DataSet();
            string sql = "SELECT disciplinasigla, disciplinanome, disciplinadescricao, disciplinacargahoraria, ";
            sql += "disciplinateorica, disciplinapratica, disciplinaobrigatoria, disciplinarequisitos, ";
            sql += "disciplinasemestre FROM disciplina WHERE disciplinaid = " + idDisc.ToString() + ";";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(dataset);

            siglaDisc = dataset.Tables[0].Rows[0][0].ToString();
            nomeDisc = dataset.Tables[0].Rows[0][1].ToString();
            descricaoDisc = dataset.Tables[0].Rows[0][2].ToString();
            cargaHorariaDisc = Convert.ToInt32(dataset.Tables[0].Rows[0][3].ToString());
            teoricaDisc = Convert.ToBoolean(dataset.Tables[0].Rows[0][4].ToString());
            praticaDisc = Convert.ToBoolean(dataset.Tables[0].Rows[0][5].ToString());
            obrigatoriaDisc = Convert.ToBoolean(dataset.Tables[0].Rows[0][6].ToString());
            preRequisitoDisc = dataset.Tables[0].Rows[0][7].ToString();
            semestreDisc = Convert.ToInt32(dataset.Tables[0].Rows[0][8].ToString());
        }
    }
}
