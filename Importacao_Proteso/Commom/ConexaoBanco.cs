using Importacao_Proteso;
using Importacao_Proteso.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;

public class ConexaoBanco
{
    private string connectionString;

    public ConexaoBanco()
    {
        this.connectionString = Program.ConnectionString;
    }
    public bool ExecutarSql(string comandoSql, SqlParameter[] parametros = null)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(comandoSql, conn);

                if (parametros != null)
                {
                    cmd.Parameters.AddRange(parametros);
                }

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }
        catch (Exception ee)
        {
            return false;
        }

    }

    public DataTable ConsultaSql(string querySql, SqlParameter[] parametros = null)
    {
        try
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(querySql, conn);

                // Adicionar parâmetros, se houver
                if (parametros != null)
                {
                    cmd.Parameters.AddRange(parametros);
                }

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }

            return dataTable;
        }
        catch (Exception)
        {
            throw;
        }
        
    }
}