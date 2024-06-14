using Importacao_Proteso.Controllers;
using Importacao_Proteso.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Importacao_Proteso.Views
{
    public partial class FormTitulo : Form
    {
        Titulo titulo;
        public FormTitulo()
        {
            InitializeComponent();
            desabilitarEdicaoTextBoxes(this.Controls);

        }
        private void numbers_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Desabilitar Edição das caixas de texto
        /// </summary>
        public void desabilitarEdicaoTextBoxes(Control.ControlCollection controls)
        {
            try
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox || control is MaskedTextBox)
                    {
                        control.Enabled = false;
                        control.BackColor = Color.WhiteSmoke;
                        control.ForeColor = Color.Black;
                    }
                    if (control.HasChildren)
                    {
                        desabilitarEdicaoTextBoxes(control.Controls);
                    }
                }
                if (!string.IsNullOrEmpty(edtValor.Text))
                {
                    AtualizarValorCustas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao desabilitar campos para edição: {ex.Message}", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public FormTitulo(Titulo titulo) : this() 
        {
            this.titulo = titulo;
            preencherDados();
        }
        public void preencherDados()
        {
            try
            {
                if(this.titulo != null)
                {
                    edtNumTit.Text = titulo.numero_titulo;
                    edtProtocolo.Text = titulo.Protocolo.ToString();
                    edtNomeCredor.Text = titulo.nome_credor;
                    edtNomeApresentante.Text = titulo.nome_apresentante;
                    edtNomeDevedor.Text = titulo.nome_devedor;

                    edtValor.Text = titulo.valor_titulo.ToString().Replace(".",",");
                    edtCustas.Text = titulo.valor_custas.ToString().Replace(".", ",");

                    if (titulo.documento_apresentante.Length > 12)
                        edtDocApresentante.Text = Uteis.formatarCNPJ(titulo.documento_apresentante);
                    else
                        edtDocApresentante.Text = Uteis.formatarCPF(titulo.documento_apresentante);

                    if (titulo.documento_credor.Length > 12)
                        edtDocumentoCredor.Text = Uteis.formatarCNPJ(titulo.documento_credor);
                    else
                        edtDocumentoCredor.Text = Uteis.formatarCPF(titulo.documento_credor);

                    if (titulo.documento_devedor.Length > 12)
                        edtDocumentoDevedor.Text = Uteis.formatarCNPJ(titulo.documento_devedor);
                    else
                        edtDocumentoDevedor.Text = Uteis.formatarCPF(titulo.documento_devedor);

                    edtDataApresentacao.Text = titulo.data_apresentacao.ToString("dd/MM/yyyy");
                    edtDataEmissao.Text = titulo.data_emissao.ToString("dd/MM/yyyy");

                }
            }
            catch (Exception)
            {

            }
        }
        /// <summary>
        /// Liberar controle onde detectar algum evento de duplo clique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void salvarAlteraçõeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                setDados();
                if(new CtrTitulo().atualizarTitulo(this.titulo))
                {
                    MessageBox.Show("`Dados do títulos alterados com sucesso", "ALTERADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                desabilitarEdicaoTextBoxes(this.Controls);
            }
            catch (Exception ee)
            {

            }
        }
        private void setDados()
        {
            try
            {
                titulo.numero_titulo = edtNumTit.Text;
                titulo.Protocolo = Convert.ToInt64(edtProtocolo.Text);
                titulo.nome_credor = edtNomeCredor.Text;
                titulo.nome_apresentante = edtNomeApresentante.Text;
                titulo.nome_devedor = edtNomeDevedor.Text;

                titulo.valor_titulo = Convert.ToDecimal(edtValor.Text);
                AtualizarValorCustas();
                titulo.valor_custas = Convert.ToDecimal(edtCustas.Text);

                titulo.documento_apresentante = LimparFormatacao(edtDocApresentante.Text);
                titulo.documento_credor = LimparFormatacao(edtDocumentoCredor.Text);
                titulo.documento_devedor = LimparFormatacao(edtDocumentoDevedor.Text);

                titulo.data_apresentacao = DateTime.ParseExact(edtDataApresentacao.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                titulo.data_emissao = DateTime.ParseExact(edtDataEmissao.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Erro ao atribuir dados ao título", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string LimparFormatacao(string documento)
        {
            return documento.Replace(".", "").Replace("-", "").Replace("/", "").Trim();
        }
        private void AtualizarValorCustas() {
            try
            {
                decimal.TryParse(edtValor.Text, out decimal valor);
                valor = valor* (decimal)0.1;
                edtCustas.Text = valor.ToString().Replace(".", ",");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Erro ao calcular custas com novo valor de título","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void edtValor_Leave(object sender, EventArgs e)
        {
            AtualizarValorCustas();
        }

        private void label6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("As custas são calculadas com base no valor do título. Não sendo possível alteração", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            desabilitarEdicaoTextBoxes(this.Controls);
            edtProtocolo.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            desabilitarEdicaoTextBoxes(this.Controls);
            edtDataApresentacao.Enabled = true;
        }

        private void label3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            desabilitarEdicaoTextBoxes(this.Controls);
            edtNumTit.Enabled = true;
        }

        private void label4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            desabilitarEdicaoTextBoxes(this.Controls);
            edtDataEmissao.Enabled = true;
        }

        private void label5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            desabilitarEdicaoTextBoxes(this.Controls);
            edtValor.Enabled = true;
        }

        private void label7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            desabilitarEdicaoTextBoxes(this.Controls);
            edtNomeApresentante.Enabled = true;
        }

        private void label8_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            desabilitarEdicaoTextBoxes(this.Controls);
            edtDocApresentante.Enabled = true;
        }

        private void label10_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            desabilitarEdicaoTextBoxes(this.Controls);
            edtNomeDevedor.Enabled = true;
        }

        private void label9_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            desabilitarEdicaoTextBoxes(this.Controls);
            edtDocumentoDevedor.Enabled = true;
        }

        private void label11_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            desabilitarEdicaoTextBoxes(this.Controls);
            edtNomeCredor.Enabled = true;
        }

        private void label12_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            desabilitarEdicaoTextBoxes(this.Controls);
            edtDocumentoCredor.Enabled = true;
        }

        private void edtDocApresentante_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //PARA OS DOCUMENTOS FOI CONSIDERADO APENAS CPF E CNPJ
                string text = edtDocApresentante.Text.Replace(".", "").Replace("-", "").Replace("/", "");
                if (text.Length > 14)
                {
                    text = text.Substring(0, 14);
                }
                if (text.Length <= 11)
                {
                    edtDocApresentante.Text = Uteis.formatarCPF(text);
                }
                else
                {
                    edtDocApresentante.Text = Uteis.formatarCNPJ(text);
                }
                edtDocApresentante.SelectionStart = edtDocApresentante.Text.Length;
            }
            catch (Exception)
            {

            }
        }

        private void edtDocumentoDevedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //PARA OS DOCUMENTOS FOI CONSIDERADO APENAS CPF E CNPJ
                string text = edtDocumentoDevedor.Text.Replace(".", "").Replace("-", "").Replace("/", "");
                if (text.Length > 14)
                {
                    text = text.Substring(0, 14);
                }
                if (text.Length <= 11)
                {
                    edtDocumentoDevedor.Text = Uteis.formatarCPF(text);
                }
                else
                {
                    edtDocumentoDevedor.Text = Uteis.formatarCNPJ(text);
                }
                edtDocumentoDevedor.SelectionStart = edtDocumentoDevedor.Text.Length;
            }
            catch (Exception)
            {

            }
        }

        private void edtDocumentoCredor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //PARA OS DOCUMENTOS FOI CONSIDERADO APENAS CPF E CNPJ
                string text = edtDocumentoCredor.Text.Replace(".", "").Replace("-", "").Replace("/", "");
                if (text.Length > 14)
                {
                    text = text.Substring(0, 14);
                }
                if (text.Length <= 11)
                {
                    edtDocumentoCredor.Text = Uteis.formatarCPF(text);
                }
                else
                {
                    edtDocumentoCredor.Text = Uteis.formatarCNPJ(text);
                }
                edtDocumentoCredor.SelectionStart = edtDocumentoCredor.Text.Length;
            }
            catch (Exception)
            {

            }
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Tem certeza que deseja excluir este título?", "EXCLUSÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(new CtrTitulo().excluirTitulo(titulo.Protocolo))
                    {
                        MessageBox.Show($"Título removido do banco de dados com sucesso", "REMOVIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Ocorreu algum erro. O título não foi removido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            catch (Exception ee)
            {
                MessageBox.Show($"Erro ao excluír título\n{ee.Message}", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
