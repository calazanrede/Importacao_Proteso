using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Importacao_Proteso
{
    internal static class Uteis
    {
        /// <summary>
        /// Método para formatar uma string no formato de CPF
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public static string formatarCPF(string doc)
        {
            try
            {
                if (doc.Length <= 3)
                {
                    return doc;
                }
                else if (doc.Length <= 6)
                {
                    return doc.Insert(3, ".");
                }
                else if (doc.Length <= 9)
                {
                    return doc.Insert(3, ".").Insert(7, ".");
                }
                else
                {
                    return doc.Insert(3, ".").Insert(7, ".").Insert(11, "-");
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        /// <summary>
        /// Método para formatar uma string no formato de CNPJ
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public static string formatarCNPJ(string doc)
        {
            try
            {
                if (doc.Length <= 2)
                {
                    return doc;
                }
                else if (doc.Length <= 5)
                {
                    return doc.Insert(2, "."); // 00.
                }
                else if (doc.Length <= 8)
                {
                    return doc.Insert(2, ".").Insert(6, ".");
                }
                else if (doc.Length <= 12)
                {
                    return doc.Insert(2, ".").Insert(6, ".").Insert(10, "/");
                }
                else
                {
                    return doc.Insert(2, ".").Insert(6, ".").Insert(10, "/").Insert(15, "-");
                }
            }
            catch (Exception)
            {

                throw;
            }  
        }

        /// <summary>
        /// Retorna apenas números de uma string qualquer passada como parâmetro
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static string retornarNumeros(string texto)
        {
            try
            {
                Regex regex = new Regex(@"\d+");
                MatchCollection matches = regex.Matches(texto);

                string numeros = "";
                foreach (Match match in matches)
                {
                    numeros += match.Value;
                }

                return numeros;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
