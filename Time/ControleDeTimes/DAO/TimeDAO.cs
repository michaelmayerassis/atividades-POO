using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ControleDeTimes.Models;
using System.Data;

namespace ControleDeTimes.DAO
{
    public class TimeDAO
    {
        MySqlCommand command = new MySqlCommand();
        public void Cadastrartime(Time time)
        {
            MySqlConnection conn = new SqlConnection().Criar();
            command = new MySqlCommand("INSERT INTO Time (Nome, qtdTitulo) values (@nome, @qtdTitulo)", conn);
            command.Parameters.Add(new MySqlParameter("nome", time.nome));
            command.Parameters.Add(new MySqlParameter("qtdTitulo", time.qtdTitulo));
            command.Prepare();
            try
            {
                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Time> ListarTime()
        {
            List<Time> times = new List<Time>();
            MySqlConnection conn = new SqlConnection().Criar();
            command = new MySqlCommand("SELECT Id, Nome, qtdTitulo FROM Time", conn);
            try
            {
                MySqlDataReader dr = command.ExecuteReader();
                times = ConvertDataReaderToList(dr);
            }
            finally
            {
                conn.Close();
            }
            return times;
        }

        public void AlterarTime(Time time)
        {
            MySqlConnection conn = new SqlConnection().Criar();
            try
            {
                command = new MySqlCommand("update Time set nome = ?, qtdTitulo = ? where id = ?", conn);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nome", time.nome);
                command.Parameters.AddWithValue("@qtdTitulo", time.qtdTitulo);
                command.Parameters.AddWithValue("@id", time.id);

                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Erro {0}", e);
            }
        }

        public void Excluirtime(Time time)
        {
            MySqlConnection conn = new SqlConnection().Criar();
            command = new MySqlCommand("DELETE FROM Time where id = @id ", conn);
            command.Parameters.Add(new MySqlParameter("id", time.id));
            command.Prepare();
            try
            {
                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        private List<Time> ConvertDataReaderToList(MySqlDataReader dreader)
        {
            List<Time> times = new List<Time>();
            while (dreader.Read())
            {
                Time time = new Time()
                {
                    id = Convert.ToInt32(dreader["id"]),
                    nome = dreader["nome"].ToString(),
                    qtdTitulo = Convert.ToInt32(dreader["qtdTitulo"]),
                };
                times.Add(time);
            }
            return times;
        }
    }

}
