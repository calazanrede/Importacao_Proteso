using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Importacao_Proteso.Models
{
    public class Titulo_Arquivo
    {
        public string protocolo_arquivo { get; set; } //CRIADO PARA SUPORTAR O CAMPO 'PROTOCOLO' NO ARQUIVO XML, PORÉM PARA SEGUIR O RESTANTE DAS ORIENTAÇÕES DO DESAFIO NÃO SERÁ UTILIZADO
        public string numero_titulo { get; set; }
        public string nome_devedor { get; set; }
        public string documento_devedor { get; set; }
        public string nome_apresentante { get; set; }
        public string documento_apresentante { get; set; }
        public string nome_credor { get; set; }
        public string documento_credor { get; set; }
        public decimal valor_titulo { get; set; }
        public DateTime data_emissao { get; set; }
        public string especie_titulo { get; set; }
    }
    public class Titulo : Titulo_Arquivo
    {
        public long Protocolo { get; set; }
        public DateTime data_apresentacao { get; set; }
        public decimal valor_custas { get; set; }
        public Titulo(Titulo_Arquivo tituloArquivo = null)
        {
            if (tituloArquivo != null)
            {
                this.protocolo_arquivo = tituloArquivo.protocolo_arquivo;
                this.numero_titulo = tituloArquivo.numero_titulo;
                this.nome_devedor = tituloArquivo.nome_devedor;
                this.documento_devedor = tituloArquivo.documento_devedor;
                this.nome_apresentante = tituloArquivo.nome_apresentante;
                this.documento_apresentante = tituloArquivo.documento_apresentante;
                this.nome_credor = tituloArquivo.nome_credor;
                this.documento_credor = tituloArquivo.documento_credor;
                this.valor_titulo = tituloArquivo.valor_titulo;
                this.data_emissao = tituloArquivo.data_emissao;
                this.especie_titulo = tituloArquivo.especie_titulo;
            }
        }
    }
}
