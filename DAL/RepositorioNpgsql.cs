using Modelos;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class RepositorioNpgsql : IRepositorio
    {
        private readonly string stringDeConexao = "server=localhost;user id=postgres;pwd=okdsmudar;database=doencas;";
        private void ExecuteNonQuery(string sql, params NpgsqlParameter[] parameters)
        {
            NpgsqlConnection con = ObterConexao();
            try
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                foreach (NpgsqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public void Inserir(Doencas doenca)
        {
            try
            {
                ExecuteNonQuery($"INSERT INTO tipos_doencas (cid, tipo, nome, sintomas) values (@Cid,@Tipo,@Nome,@Sintomas)", new NpgsqlParameter("@Cid", doenca.Cid), new NpgsqlParameter("@Tipo", doenca.Tipo), new NpgsqlParameter("@Nome", doenca.Nome), new NpgsqlParameter("@Sintomas", doenca.Sintomas));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Atualizar(Doencas doenca)
        {
            try
            {
                ExecuteNonQuery($"UPDATE tipos_doencas SET cid = @Cid, tipo = @Tipo, nome = @Nome , sintomas = @Sintomas WHERE nome = @Nome", new NpgsqlParameter("@Cid", doenca.Cid), new NpgsqlParameter("@Tipo", doenca.Tipo), new NpgsqlParameter("@Nome", doenca.Nome), new NpgsqlParameter("@Sintomas", doenca.Sintomas));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Deletar(string nome)
        {
            try
            {
                ExecuteNonQuery($"DELETE FROM tipos_doencas WHERE nome = @Nome", new NpgsqlParameter("@Nome", nome));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Doencas Consultar(string nome)
        {
            Doencas doe = null;
            NpgsqlConnection con = ObterConexao();
            NpgsqlDataReader dr = null;
            try
            {
                dr = ExecuteReader(con, $"SELECT * FROM tipos_doencas WHERE nome like @Nome", new NpgsqlParameter("@Nome", nome));
                while (dr.Read())
                {
                    doe = new Doencas(dr.GetInt32("Id"), dr.GetString("Cid"), dr.GetString("Tipo"), dr.GetString("Nome"), dr.GetString("Sintomas"));
                    break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharConexaoEDataReader(con, dr);
            }
            return doe;
        }

        public List<Doencas> Listar()
        {
            List<Doencas> doencas = null;
            NpgsqlConnection con = ObterConexao();
            NpgsqlDataReader dr = null;
            try
            {
                dr = ExecuteReader(con, $"SELECT * FROM tipos_doencas");
                if (dr.HasRows)
                {
                    doencas = new List<Doencas>();
                    while (dr.Read())
                    {
                        doencas.Add(new Doencas(dr.GetInt32("Id"), dr.GetString("Cid"), dr.GetString("Tipo"), dr.GetString("Nome"), dr.GetString("Sintomas")));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharConexaoEDataReader(con, dr);
            }
            return doencas;
        }

        private static void FecharConexaoEDataReader(NpgsqlConnection con, NpgsqlDataReader dr)
        {
            con.Close();
            if (dr != null)
            {
                dr.Close();
            }
        }
        private static NpgsqlDataReader ExecuteReader(NpgsqlConnection con, string sql, params NpgsqlParameter[] parameters)
        {
            NpgsqlDataReader dr;
            con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            foreach (NpgsqlParameter parameter in parameters)
            {
                cmd.Parameters.Add(parameter);
            }
            dr = cmd.ExecuteReader();
            return dr;
        }

        private NpgsqlConnection ObterConexao()
        {
            return new NpgsqlConnection(stringDeConexao);
        }
    }
}
