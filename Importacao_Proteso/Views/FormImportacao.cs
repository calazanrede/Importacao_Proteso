using System;
using System.Collections.Generic;
using System.Drawing;
using Importacao_Proteso.Models;
using System.Windows.Forms;
using System.Xml;
using System.Text;
using Importacao_Proteso.Controllers;

namespace Importacao_Proteso
{
    public partial class FormImportacao : Form
    {
        public FormImportacao()
        {
            InitializeComponent();
            dtData.CustomFormat = " ";
            dtData.Format = DateTimePickerFormat.Custom;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            dtData.CustomFormat = " ";
            dtData.Format = DateTimePickerFormat.Custom;
        }
        /// <summary>
        /// Não aceitar caracteres especiais ou letras para campos onde a entrada deve ser só número
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numbers_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void edtDocDevedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //PARA OS DOCUMENTOS FOI CONSIDERADO APENAS CPF E CNPJ
                string text = edtDocDevedor.Text.Replace(".", "").Replace("-", "").Replace("/", "");
                if (text.Length > 14) 
                {
                    text = text.Substring(0, 14);
                }
                if (text.Length <= 11)
                {
                    edtDocDevedor.Text = Uteis.formatarCPF(text);
                }
                else
                {
                    edtDocDevedor.Text = Uteis.formatarCNPJ(text);
                }
                edtDocDevedor.SelectionStart = edtDocDevedor.Text.Length;
            }
            catch (Exception)
            {
                
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesquisa();
        }
        public void pesquisa()
        {
            try
            {
                string sql = "select ";
            }
            catch (Exception ee)
            {
                MessageBox.Show($"Erro ao pesquisar títulos solicitados.\n {ee.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void edtDocCredor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //PARA OS DOCUMENTOS FOI CONSIDERADO APENAS CPF E CNPJ
                string text = edtDocCredor.Text.Replace(".", "").Replace("-", "").Replace("/", "");
                if (text.Length > 14)
                {
                    text = text.Substring(0, 14);
                }
                if (text.Length <= 11)
                {
                    edtDocCredor.Text = Uteis.formatarCPF(text);
                }
                else
                {
                    edtDocCredor.Text = Uteis.formatarCNPJ(text);
                }
                edtDocCredor.SelectionStart = edtDocCredor.Text.Length;
            }
            catch (Exception)
            {

            }
        }
        private void dtData_ValueChanged(object sender, EventArgs e)
        {
            dtData.Format = DateTimePickerFormat.Short;
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use os filtros abaixo e clique em 'PESQUISAR' para buscar os títulos desejados.\nClique em 'IMPORTAR' e escolha um arquivo para importar os títulos.", "Ajuda Chegou", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BackColor = Color.LightBlue;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.Transparent;
        }
        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "XML files (*.xml)|*.xml",
                    Title = "Selecione o arquivo de importação"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = openFileDialog.FileName;
                    if (!string.IsNullOrEmpty(selectedFile))
                    {
                        List<Titulo_Arquivo> listaTitulos = new List<Titulo_Arquivo>();
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load(selectedFile);
                        XmlNodeList tituloNodes = xmlDoc.GetElementsByTagName("Titulo");
                        StringBuilder erros = new StringBuilder();
                        int i = 1;
                        foreach (XmlNode node in tituloNodes)
                        {
                            if (node.SelectSingleNode("Protocolo") == null ||
                                node.SelectSingleNode("NumeroTitulo") == null ||
                                node.SelectSingleNode("NomeDevedor") == null ||
                                node.SelectSingleNode("DocumentoDevedor") == null ||
                                node.SelectSingleNode("NomeApresentante") == null ||
                                node.SelectSingleNode("DocumentoApresentante") == null ||
                                node.SelectSingleNode("NomeCredor") == null ||
                                node.SelectSingleNode("DocumentoCredor") == null ||
                                node.SelectSingleNode("ValorTitulo") == null ||
                                node.SelectSingleNode("DataEmissao") == null ||
                                node.SelectSingleNode("EspecieTitulo") == null)
                            {
                                // Pequeno log de erro para caso algum elemento não exista no XML
                                erros.AppendLine($"Erro ao ler título de número {i} arquivo. Título não importado");
                                i++;
                                continue;
                            }
                            Titulo_Arquivo titulo = new Titulo_Arquivo
                            {
                                protocolo_arquivo = node.SelectSingleNode("Protocolo").InnerText,
                                numero_titulo = node.SelectSingleNode("NumeroTitulo").InnerText,
                                nome_devedor = node.SelectSingleNode("NomeDevedor").InnerText,
                                documento_devedor = node.SelectSingleNode("DocumentoDevedor").InnerText,
                                nome_apresentante = node.SelectSingleNode("NomeApresentante").InnerText,
                                documento_apresentante = node.SelectSingleNode("DocumentoApresentante").InnerText,
                                nome_credor = node.SelectSingleNode("NomeCredor").InnerText,
                                documento_credor = node.SelectSingleNode("DocumentoCredor").InnerText,
                                valor_titulo = decimal.Parse(node.SelectSingleNode("ValorTitulo").InnerText.Replace(".", ",")),
                                data_emissao = DateTime.Parse(node.SelectSingleNode("DataEmissao").InnerText),
                                especie_titulo = node.SelectSingleNode("EspecieTitulo").InnerText
                            };
                            listaTitulos.Add(titulo);
                            i++;
                        }
                        if (!string.IsNullOrEmpty(erros.ToString()))
                        {
                            MessageBox.Show($"Os seguintes erros aconteceram durante a importação: \n{erros}","ATENÇÃO",MessageBoxButtons.OK);
                        }
                        if (listaTitulos.Count > 0)
                        {
                            List<Titulo> listaTitulosBanco = new List<Titulo>();
                            foreach(var item in listaTitulos)
                            {
                                Titulo t = new Titulo(item);
                                listaTitulosBanco.Add(t);
                            }
                            if (listaTitulosBanco.Count > 0)
                            {
                                if (new CtrTitulo().AddTitulosEmLista(listaTitulosBanco).Count == listaTitulos.Count)
                                {
                                    MessageBox.Show($"Importação concluída!\n{listaTitulos.Count} títulos importados na base de dados.", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    pesquisa();
                                }
                            }
                        }
                        else
                            MessageBox.Show("Não foram encontrados títulos para serem importados no arquivo","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show($"Erro ao importar títulos pelo XML. Verifique se o formato do arquivo está correto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show($"Erro ao importar títulos pelo XML. Verifique se o formato do arquivo está correto.\n {ee.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
