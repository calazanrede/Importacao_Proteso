using Importacao_Proteso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using System.Data.SqlClient;
using System.Windows;
using System.Data;

namespace Importacao_Proteso.Controllers
{
    public class CtrTitulo
    {
        ConexaoBanco cs = new ConexaoBanco();
        /// <summary>
        /// Adicionar um título ao banco de dados
        /// </summary>
        /// <param name="titulo"></param>
        /// <returns></returns>
        public Titulo addTitulo(Titulo titulo)
        {
            try
            {
                titulo.valor_custas = calcularValorCustas(titulo);
                titulo.data_apresentacao = DateTime.Now;

                string comandoSql = @"
                INSERT INTO Titulos
                (protocolo_arquivo, numero_titulo, nome_devedor, documento_devedor, 
                    nome_apresentante, documento_apresentante, nome_credor, documento_credor, 
                    valor_titulo, data_emissao, especie_titulo, data_apresentacao, valor_custas)
                VALUES 
                (@protocolo_arquivo, @numero_titulo, @nome_devedor, @documento_devedor, 
                    @nome_apresentante, @documento_apresentante, @nome_credor, @documento_credor, 
                    @valor_titulo, @data_emissao, @especie_titulo, @data_apresentacao, @valor_custas)";

                        SqlParameter[] parametros = new SqlParameter[]
                        {
                new SqlParameter("@protocolo_arquivo", titulo.protocolo_arquivo),
                new SqlParameter("@numero_titulo", titulo.numero_titulo),
                new SqlParameter("@nome_devedor", titulo.nome_devedor),
                new SqlParameter("@documento_devedor", Uteis.retornarNumeros(titulo.documento_devedor)),
                new SqlParameter("@nome_apresentante", titulo.nome_apresentante),
                new SqlParameter("@documento_apresentante", Uteis.retornarNumeros(titulo.documento_apresentante)),
                new SqlParameter("@nome_credor", titulo.nome_credor),
                new SqlParameter("@documento_credor", Uteis.retornarNumeros(titulo.documento_credor)),
                new SqlParameter("@valor_titulo", titulo.valor_titulo),
                new SqlParameter("@data_emissao", titulo.data_emissao),
                new SqlParameter("@especie_titulo", titulo.especie_titulo),
                new SqlParameter("@data_apresentacao", titulo.data_apresentacao),
                new SqlParameter("@valor_custas", titulo.valor_custas)
                        };

                if(cs.ExecutarSql(comandoSql, parametros))
                    return titulo;

                MessageBox.Show($"Ocorreu um erro ao tentar inserir título {titulo.numero_titulo} no banco de dados.","ATENÇÃO",MessageBoxButton.OK, MessageBoxImage.Error);
                return titulo;
            }    
            catch (Exception ee)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar inserir título {titulo.numero_titulo} no banco de dados.\n{ee.Message}", "ATENÇÃO", MessageBoxButton.OK, MessageBoxImage.Error);
                throw ee;
            }

        }

        /// <summary>
        /// Adicionar uma lista de títulos ao banco utilizando apenas um comando único
        /// </summary>
        /// <param name="titulos"></param>
        /// <returns></returns>
        public List<Titulo> AddTitulosEmLista(List<Titulo> titulos)
        {
            try
            {
                foreach (var titulo in titulos)
                {
                    titulo.valor_custas = calcularValorCustas(titulo);
                    titulo.data_apresentacao = DateTime.Now;
                }

                // Preparando os parâmetros para o comando SQL
                List<SqlParameter[]> parametrosList = new List<SqlParameter[]>();
                foreach (var titulo in titulos)
                {
                    SqlParameter[] parametros = new SqlParameter[]
                    {
                    new SqlParameter("@protocolo_arquivo", titulo.protocolo_arquivo),
                    new SqlParameter("@numero_titulo", titulo.numero_titulo),
                    new SqlParameter("@nome_devedor", titulo.nome_devedor),
                    new SqlParameter("@documento_devedor", Uteis.retornarNumeros(titulo.documento_devedor)),
                    new SqlParameter("@nome_apresentante", titulo.nome_apresentante),
                    new SqlParameter("@documento_apresentante", Uteis.retornarNumeros(titulo.documento_apresentante)),
                    new SqlParameter("@nome_credor", titulo.nome_credor),
                    new SqlParameter("@documento_credor", Uteis.retornarNumeros(titulo.documento_credor)),
                    new SqlParameter("@valor_titulo", titulo.valor_titulo),
                    new SqlParameter("@data_emissao", titulo.data_emissao),
                    new SqlParameter("@especie_titulo", Uteis.retornarNumeros(titulo.especie_titulo)),
                    new SqlParameter("@data_apresentacao", titulo.data_apresentacao),
                    new SqlParameter("@valor_custas", titulo.valor_custas)
                    };
                    parametrosList.Add(parametros);
                }

                // Comando SQL para inserção de múltiplas linhas
                string comandoSql = @"
            INSERT INTO Titulos
            (protocolo_arquivo, numero_titulo, nome_devedor, documento_devedor, 
             nome_apresentante, documento_apresentante, nome_credor, documento_credor, 
             valor_titulo, data_emissao, especie_titulo, data_apresentacao, valor_custas)
            VALUES 
            (@protocolo_arquivo, @numero_titulo, @nome_devedor, @documento_devedor, 
             @nome_apresentante, @documento_apresentante, @nome_credor, @documento_credor, 
             @valor_titulo, @data_emissao, @especie_titulo, @data_apresentacao, @valor_custas)";

                // Executando o comando SQL para cada conjunto de parâmetros
                foreach (var parametros in parametrosList)
                {
                    if (!cs.ExecutarSql(comandoSql, parametros))
                    {
                        throw new Exception($"Erro ao tentar inserir título {titulos[parametrosList.IndexOf(parametros)].numero_titulo} no banco de dados.");
                    }
                }

                return titulos;
            }
            catch (Exception ee)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar inserir títulos no banco de dados.\n{ee.Message}", "ATENÇÃO", MessageBoxButton.OK, MessageBoxImage.Error);
                throw ee;
            }
        }
        public DataTable consultarTitulos(string sql)
        {
            try
            {
                DataTable dt = new DataTable();
                return dt;
            }
            catch (Exception ee)
            {
                throw;
            }
        }
        private decimal calcularValorCustas(Titulo titulo)
        {
            try
            {
                if(titulo.valor_titulo != 0)
                {
                    decimal valorCustas = titulo.valor_titulo * (decimal)0.1;
                    return valorCustas;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
