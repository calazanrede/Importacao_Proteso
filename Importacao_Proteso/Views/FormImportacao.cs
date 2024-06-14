using System;
using System.Collections.Generic;
using System.Drawing;
using Importacao_Proteso.Models;
using System.Windows.Forms;
using System.Xml;
using System.Text;
using Importacao_Proteso.Controllers;
using System.ComponentModel;
using System.Data;
using Importacao_Proteso.Views;

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
                BackgroundWorker bg = new BackgroundWorker(); 
                DataTable dt = new DataTable();
                string protocolo = edtProtocolo.Text;
                string dataApresentacao = "";
                if (!string.IsNullOrEmpty(dtData.Text.Trim())) // Não definir data na pesquisa caso esteja vazia
                    dataApresentacao = dtData.Value.ToString("yyyy-MM-dd");
                string numeroTitulo = edtNumTit.Text;
                string nomeDevedor = edtNomeDevedor.Text;
                string docDevedor = Uteis.retornarNumeros(edtDocDevedor.Text);
                string nomeCredor = edtNomeCredor.Text;
                string docCredor = Uteis.retornarNumeros(edtDocCredor.Text);
                string nomeApresentante = edtNomeApresentante.Text;
                string docApresentante = Uteis.retornarNumeros(edtDocApresentante.Text);
                bg.DoWork += new DoWorkEventHandler((object sender, DoWorkEventArgs e) => // Colocado em Background considerando que o teste pode ser feito com uma quantidade amis roubsta de dados
                {
                    dt = new CtrTitulo().consultarTitulos(protocolo,dataApresentacao,numeroTitulo,nomeDevedor,docDevedor,nomeCredor,docCredor,nomeApresentante,docApresentante);
                });
                bg.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler((object sender, RunWorkerCompletedEventArgs e) =>
                {
                    if(dt.Rows.Count > 0)
                    {
                        dgvTitulos.DataSource = dt;
                        addBotaoAbrir(ref dgvTitulos);
                    }
                    else
                    {
                        dgvTitulos.DataSource = null;
                        if (dgvTitulos.Columns["Abrir"] != null)
                        {
                            dgvTitulos.Columns.Remove("Abrir");
                        }
                        MessageBox.Show("Nenhum título encontrado na pesquisa.","ATENÇÃO",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                });
                bg.RunWorkerAsync();
            }
            catch (Exception ee)
            {
                MessageBox.Show($"Erro ao pesquisar títulos solicitados.\n {ee.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Adicionar botão de abrir ao DataGridView para abrir informações sobre o título desejado
        /// </summary>
        /// <param name="dgvTitulos"></param>
        public void addBotaoAbrir(ref DataGridView dgvTitulos)
        {
            try
            {
                bool entro = false;
                if (dgvTitulos.Rows.Count > 0)
                {
                    if (dgvTitulos.Columns.Count > 0)
                    {
                        foreach (DataGridViewColumn item in dgvTitulos.Columns)
                        {
                            if (item.Name == "Abrir")
                            {
                                dgvTitulos.Columns.Remove(item);
                                entro = true;
                                break;
                            }
                        }
                    }
                    DataGridViewButtonColumn Abrir = new System.Windows.Forms.DataGridViewButtonColumn();
                    Abrir.HeaderText = "Abrir";
                    Abrir.Name = "Abrir";
                    Abrir.Text = "Abrir título";
                    Abrir.UseColumnTextForButtonValue = true;
                    dgvTitulos.Columns.Add(Abrir);
                    dgvTitulos.Columns["Abrir"].DisplayIndex = 0;
                    if (entro == false)
                        dgvTitulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvTitulos_CellClick);
                }
            }
            catch (Exception)
            {

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

        private void dgvTitulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex != -1 && e.RowIndex != -1)
                {
                    if (dgvTitulos.Columns[e.ColumnIndex].Name.ToUpper() == "ABRIR")
                    {
                        CtrTitulo ctr = new CtrTitulo();
                        int.TryParse(dgvTitulos.Rows[e.RowIndex].Cells["Protocolo"].Value.ToString(), out int protocolo);
                        Titulo t = ctr.abrirTitulo(protocolo);
                        if(t != null) 
                        { 
                            FormTitulo frm = new FormTitulo(t);
                            frm.Show();
                        }
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show($"Ocooreu um erro ao tentar abrir o título.\n {ee.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Fazer pesquisa sempre que o usuário teclar ENTER em algum dos campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buscarComEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisa();
            }
            
        }
    }
}
