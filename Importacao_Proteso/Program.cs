using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Importacao_Proteso
{
    internal static class Program
    {
        public static string ConnectionString { get; private set; }
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConnectionString = "Server=localhost\\MSSQLSERVER01;Database=desafio_tec21;Trusted_Connection=True;";
            Application.Run(new FormImportacao());
        }
    }
}
