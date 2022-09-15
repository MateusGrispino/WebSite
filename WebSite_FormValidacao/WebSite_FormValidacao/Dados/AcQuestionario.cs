using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSite_FormValidacao.Models;

namespace WebSite_FormValidacao.Dados
{
    public class AcQuestionario
    {
        Conexao con = new Conexao();

        public void inserirOrcamento(QuestionarioModel cm)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbProjeto (TipoProjeto, Cep, Contato, Email, Telefone, Descricao) values (@TipoProjeto, @Cep, @Contato, @Email, @Telefone, @Descricao)", con.MyConectarBD()); // @: PARAMETRO

            cmd.Parameters.Add("@TipoProjeto", MySqlDbType.VarChar).Value = cm.TipoProjeto;
            cmd.Parameters.Add("@Cep", MySqlDbType.VarChar).Value = cm.Cep;
            cmd.Parameters.Add("@Contato", MySqlDbType.VarChar).Value = cm.Contato;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = cm.Email;
            cmd.Parameters.Add("@Telefone", MySqlDbType.VarChar).Value = cm.Telefone;
            cmd.Parameters.Add("@Descricao", MySqlDbType.VarChar).Value = cm.Descricao;

            cmd.ExecuteNonQuery();
            con.MyDesConectarBD();
        }
    }
}