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
using System.Drawing;

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
            return Adicionar(titulo);
        }
       
        private Titulo Adicionar(Titulo titulo)
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

                if (cs.ExecutarSql(comandoSql, parametros))
                    return titulo;

                MessageBox.Show($"Ocorreu um erro ao tentar inserir título {titulo.numero_titulo} no banco de dados.", "ATENÇÃO", MessageBoxButton.OK, MessageBoxImage.Error);
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
            return AdicionarEmLista(titulos);
        }
        
        private List<Titulo> AdicionarEmLista(List<Titulo> titulos)
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
        /// <summary>
        /// Consulta os títulos no banco de dados utilizando caso desejado filtros com as colunas
        /// </summary>
        /// <param name="protocolo"></param>
        /// <param name="dataApresentacao"></param>
        /// <param name="numeroTitulo"></param>
        /// <param name="nomeDevedor"></param>
        /// <param name="documentoDevedor"></param>
        /// <param name="nomeCredor"></param>
        /// <param name="documentoCredor"></param>
        /// <param name="nomeApresentante"></param>
        /// <param name="documentoApresentante"></param>
        /// <returns></returns>
        public DataTable consultarTitulos(string protocolo = "", string dataApresentacao = "", string numeroTitulo = "", string nomeDevedor = "", string documentoDevedor = "", string nomeCredor = "", string documentoCredor = "", string nomeApresentante = "", string documentoApresentante = "")
        {
            return ConsultaTitulos(protocolo, dataApresentacao, numeroTitulo ,  nomeDevedor ,  documentoDevedor ,  nomeCredor ,  documentoCredor , nomeApresentante , documentoApresentante );
        }
        
        private DataTable ConsultaTitulos(string protocolo = "", string dataApresentacao = "", string numeroTitulo = "", string nomeDevedor = "", string documentoDevedor = "", string nomeCredor = "", string documentoCredor = "", string nomeApresentante = "", string documentoApresentante = "")
        {
            try
            {
                DataTable dt = new DataTable();
                StringBuilder query = new StringBuilder("SELECT Protocolo,nome_devedor as 'Devedor',documento_devedor as 'Documento', nome_credor as 'Credor',numero_titulo as 'Número Título',valor_titulo as 'Valor Título', valor_custas as 'Custas' FROM Titulos WHERE protocolo != 0");

                List<SqlParameter> parametros = new List<SqlParameter>();

                if (!string.IsNullOrEmpty(protocolo))
                {
                    int protocoloInt;
                    if (int.TryParse(protocolo, out protocoloInt))
                    {
                        query.Append(" AND Protocolo = @protocolo");
                        parametros.Add(new SqlParameter("@protocolo", protocoloInt));
                    }
                    else
                    {
                        throw new ArgumentException("O valor do protocolo não é um inteiro válido.");
                    }
                }

                if (!string.IsNullOrEmpty(dataApresentacao))
                {
                    DateTime dataApresentacaoDateTime;
                    if (DateTime.TryParse(dataApresentacao, out dataApresentacaoDateTime))
                    {
                        query.Append(" AND CONVERT(date, data_apresentacao) = @dataApresentacao");
                        parametros.Add(new SqlParameter("@dataApresentacao", dataApresentacaoDateTime.Date));
                    }
                    else
                    {
                        throw new ArgumentException("O valor da data de apresentação não é uma data válida.");
                    }
                }

                if (!string.IsNullOrEmpty(numeroTitulo))
                {
                    query.Append(" AND numero_titulo LIKE @numeroTitulo");
                    parametros.Add(new SqlParameter("@numeroTitulo", "%" + numeroTitulo + "%"));
                }

                if (!string.IsNullOrEmpty(nomeDevedor))
                {
                    query.Append(" AND nome_devedor LIKE @nomeDevedor");
                    parametros.Add(new SqlParameter("@nomeDevedor", "%" + nomeDevedor + "%"));
                }

                if (!string.IsNullOrEmpty(documentoDevedor))
                {
                    query.Append(" AND documento_devedor LIKE @documentoDevedor");
                    parametros.Add(new SqlParameter("@documentoDevedor", "%" + documentoDevedor + "%"));
                }

                if (!string.IsNullOrEmpty(nomeCredor))
                {
                    query.Append(" AND nome_credor LIKE @nomeCredor");
                    parametros.Add(new SqlParameter("@nomeCredor", "%" + nomeCredor + "%"));
                }

                if (!string.IsNullOrEmpty(documentoCredor))
                {
                    query.Append(" AND documento_credor LIKE @documentoCredor");
                    parametros.Add(new SqlParameter("@documentoCredor", "%" + documentoCredor + "%"));
                }

                if (!string.IsNullOrEmpty(nomeApresentante))
                {
                    query.Append(" AND nome_apresentante LIKE @nomeApresentante");
                    parametros.Add(new SqlParameter("@nomeApresentante", "%" + nomeApresentante + "%"));
                }

                if (!string.IsNullOrEmpty(documentoApresentante))
                {
                    query.Append(" AND documento_apresentante LIKE @documentoApresentante");
                    parametros.Add(new SqlParameter("@documentoApresentante", "%" + documentoApresentante + "%"));
                }
                string sql = query.ToString();
                dt = cs.ConsultaSql(sql, parametros.ToArray());
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Remover um título do banco passando o protocolo como parâmetro
        /// </summary>
        /// <param name="protocolo"></param>
        /// <returns></returns>
        public bool excluirTitulo(long protocolo)
        {
            return ExcluirTitulo(protocolo);
        }
        private bool ExcluirTitulo(long protocolo)
        {
            try
            {
                string comandoSql = "DELETE FROM Titulos WHERE Protocolo = @Protocolo";

                // Define os parâmetros para o comando SQL
                SqlParameter parametroProtocolo = new SqlParameter("@Protocolo", protocolo);

                // Executa o comando SQL e retorna o resultado
                return cs.ExecutarSql(comandoSql, new SqlParameter[] { parametroProtocolo });
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Atualizar dados de um título
        /// </summary>
        /// <returns></returns>
        public bool atualizarTitulo(Titulo titulo)
        {
            return AtualizaTitulo(titulo);
        }
        private bool AtualizaTitulo(Titulo titulo)
        {
            try
            {
                string comandoSql = @"
                UPDATE Titulos
                SET numero_titulo = @numero_titulo,
                    nome_credor = @nome_credor,
                    nome_apresentante = @nome_apresentante,
                    nome_devedor = @nome_devedor,
                    valor_titulo = @valor_titulo,
                    valor_custas = @valor_custas,
                    documento_apresentante = @documento_apresentante,
                    documento_credor = @documento_credor,
                    documento_devedor = @documento_devedor,
                    data_apresentacao = @data_apresentacao,
                    data_emissao = @data_emissao
                WHERE Protocolo = @Protocolo";

                List<SqlParameter> parametros = new List<SqlParameter>
                {
                    new SqlParameter("@numero_titulo", titulo.numero_titulo),
                    new SqlParameter("@nome_credor", titulo.nome_credor),
                    new SqlParameter("@nome_apresentante", titulo.nome_apresentante),
                    new SqlParameter("@nome_devedor", titulo.nome_devedor),
                    new SqlParameter("@valor_titulo", titulo.valor_titulo),
                    new SqlParameter("@valor_custas", titulo.valor_custas),
                    new SqlParameter("@documento_apresentante", titulo.documento_apresentante),
                    new SqlParameter("@documento_credor", titulo.documento_credor),
                    new SqlParameter("@documento_devedor", titulo.documento_devedor),
                    new SqlParameter("@data_apresentacao", titulo.data_apresentacao),
                    new SqlParameter("@data_emissao", titulo.data_emissao),
                    new SqlParameter("@Protocolo", titulo.Protocolo)
                };

                return cs.ExecutarSql(comandoSql, parametros.ToArray());
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        private Titulo AbreTitulo(int Protocolo)
        {
            try
            {
                string query = "SELECT Protocolo, protocolo_arquivo,numero_titulo, nome_devedor, documento_devedor, " +
                               "nome_apresentante, documento_apresentante, nome_credor, documento_credor, " +
                               "valor_titulo, data_emissao, especie_titulo, data_apresentacao, valor_custas " +
                               "FROM Titulos WHERE Protocolo = @Protocolo";

                SqlParameter[] parametros = {
            new SqlParameter("@Protocolo", SqlDbType.BigInt) { Value = Protocolo }
                };

                DataTable dt = cs.ConsultaSql(query, parametros);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    Titulo titulo = new Titulo
                    {
                        Protocolo = Convert.ToInt64(row["Protocolo"]),
                        protocolo_arquivo = Convert.ToString(row["protocolo_arquivo"]),
                        numero_titulo = Convert.ToString(row["numero_titulo"]),
                        nome_devedor = Convert.ToString(row["nome_devedor"]),
                        documento_devedor = Convert.ToString(row["documento_devedor"]),
                        nome_apresentante = Convert.ToString(row["nome_apresentante"]),
                        documento_apresentante = Convert.ToString(row["documento_apresentante"]),
                        nome_credor = Convert.ToString(row["nome_credor"]),
                        documento_credor = Convert.ToString(row["documento_credor"]),
                        valor_titulo = Convert.ToDecimal(row["valor_titulo"]),
                        data_emissao = Convert.ToDateTime(row["data_emissao"]),
                        especie_titulo = Convert.ToString(row["especie_titulo"]),
                        data_apresentacao = Convert.ToDateTime(row["data_apresentacao"]),
                        valor_custas = Convert.ToDecimal(row["valor_custas"])
                    };
                    

                    return titulo;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Abre os dados de um título baseado em um número de protocolo passado como parâmetro
        /// </summary>
        /// <param name="Protocolo"></param>
        /// <returns></returns>
        public Titulo abrirTitulo(int Protocolo)
        {
            return AbreTitulo(Protocolo);
        }
        /// <summary>
        /// Calcular custas de um título (10% de seu valor)
        /// </summary>
        /// <param name="titulo"></param>
        /// <returns></returns>
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
