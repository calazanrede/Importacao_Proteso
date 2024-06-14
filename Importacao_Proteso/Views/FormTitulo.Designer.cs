namespace Importacao_Proteso.Views
{
    partial class FormTitulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTitulo));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvarAlteraçõeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.edtDocumentoDevedor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.edtNomeDevedor = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.edtDocumentoCredor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.edtNomeCredor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edtDataEmissao = new System.Windows.Forms.MaskedTextBox();
            this.edtDataApresentacao = new System.Windows.Forms.MaskedTextBox();
            this.edtDocApresentante = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.edtNomeApresentante = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edtCustas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edtValor = new System.Windows.Forms.TextBox();
            this.edtNumTit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtProtocolo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarAlteraçõeToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(507, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salvarAlteraçõeToolStripMenuItem
            // 
            this.salvarAlteraçõeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.salvarAlteraçõeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salvarAlteraçõeToolStripMenuItem.Image")));
            this.salvarAlteraçõeToolStripMenuItem.Name = "salvarAlteraçõeToolStripMenuItem";
            this.salvarAlteraçõeToolStripMenuItem.Size = new System.Drawing.Size(157, 25);
            this.salvarAlteraçõeToolStripMenuItem.Text = "Salvar Alterações";
            this.salvarAlteraçõeToolStripMenuItem.Click += new System.EventHandler(this.salvarAlteraçõeToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.excluirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("excluirToolStripMenuItem.Image")));
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.edtDocumentoDevedor);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.edtNomeDevedor);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox2.Location = new System.Drawing.Point(0, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 135);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Devedor";
            // 
            // edtDocumentoDevedor
            // 
            this.edtDocumentoDevedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.edtDocumentoDevedor.Location = new System.Drawing.Point(10, 102);
            this.edtDocumentoDevedor.Multiline = true;
            this.edtDocumentoDevedor.Name = "edtDocumentoDevedor";
            this.edtDocumentoDevedor.Size = new System.Drawing.Size(491, 24);
            this.edtDocumentoDevedor.TabIndex = 21;
            this.edtDocumentoDevedor.TextChanged += new System.EventHandler(this.edtDocumentoDevedor_TextChanged);
            this.edtDocumentoDevedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_keyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 22);
            this.label10.TabIndex = 18;
            this.label10.Text = "Nome:";
            this.label10.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label10_MouseDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(6, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 22);
            this.label9.TabIndex = 20;
            this.label9.Text = "Documento:";
            this.label9.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label9_MouseDoubleClick);
            // 
            // edtNomeDevedor
            // 
            this.edtNomeDevedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.edtNomeDevedor.Location = new System.Drawing.Point(10, 50);
            this.edtNomeDevedor.Multiline = true;
            this.edtNomeDevedor.Name = "edtNomeDevedor";
            this.edtNomeDevedor.Size = new System.Drawing.Size(491, 24);
            this.edtNomeDevedor.TabIndex = 19;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.edtDocumentoCredor);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.edtNomeCredor);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox3.Location = new System.Drawing.Point(0, 405);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 135);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Credor";
            // 
            // edtDocumentoCredor
            // 
            this.edtDocumentoCredor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.edtDocumentoCredor.Location = new System.Drawing.Point(10, 102);
            this.edtDocumentoCredor.Multiline = true;
            this.edtDocumentoCredor.Name = "edtDocumentoCredor";
            this.edtDocumentoCredor.Size = new System.Drawing.Size(491, 24);
            this.edtDocumentoCredor.TabIndex = 21;
            this.edtDocumentoCredor.TextChanged += new System.EventHandler(this.edtDocumentoCredor_TextChanged);
            this.edtDocumentoCredor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_keyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(6, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 22);
            this.label11.TabIndex = 18;
            this.label11.Text = "Nome:";
            this.label11.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label11_MouseDoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(6, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 22);
            this.label12.TabIndex = 20;
            this.label12.Text = "Documento:";
            this.label12.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label12_MouseDoubleClick);
            // 
            // edtNomeCredor
            // 
            this.edtNomeCredor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.edtNomeCredor.Location = new System.Drawing.Point(10, 50);
            this.edtNomeCredor.Multiline = true;
            this.edtNomeCredor.Name = "edtNomeCredor";
            this.edtNomeCredor.Size = new System.Drawing.Size(491, 24);
            this.edtNomeCredor.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Firebrick;
            this.label13.Location = new System.Drawing.Point(6, 543);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(444, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Para alterar algum campo, de um duplo clique no título";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edtDataEmissao);
            this.groupBox1.Controls.Add(this.edtDataApresentacao);
            this.groupBox1.Controls.Add(this.edtDocApresentante);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.edtNomeApresentante);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.edtCustas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.edtValor);
            this.groupBox1.Controls.Add(this.edtNumTit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.edtProtocolo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.Location = new System.Drawing.Point(0, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 246);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Título";
            // 
            // edtDataEmissao
            // 
            this.edtDataEmissao.Location = new System.Drawing.Point(305, 57);
            this.edtDataEmissao.Mask = "00/00/0000";
            this.edtDataEmissao.Name = "edtDataEmissao";
            this.edtDataEmissao.Size = new System.Drawing.Size(196, 29);
            this.edtDataEmissao.TabIndex = 17;
            this.edtDataEmissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_keyPress);
            // 
            // edtDataApresentacao
            // 
            this.edtDataApresentacao.Location = new System.Drawing.Point(305, 22);
            this.edtDataApresentacao.Mask = "00/00/0000";
            this.edtDataApresentacao.Name = "edtDataApresentacao";
            this.edtDataApresentacao.Size = new System.Drawing.Size(196, 29);
            this.edtDataApresentacao.TabIndex = 16;
            this.edtDataApresentacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_keyPress);
            // 
            // edtDocApresentante
            // 
            this.edtDocApresentante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.edtDocApresentante.Location = new System.Drawing.Point(10, 206);
            this.edtDocApresentante.Multiline = true;
            this.edtDocApresentante.Name = "edtDocApresentante";
            this.edtDocApresentante.Size = new System.Drawing.Size(491, 24);
            this.edtDocApresentante.TabIndex = 15;
            this.edtDocApresentante.TextChanged += new System.EventHandler(this.edtDocApresentante_TextChanged);
            this.edtDocApresentante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_keyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Documento Apresentante:";
            this.label8.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label8_MouseDoubleClick);
            // 
            // edtNomeApresentante
            // 
            this.edtNomeApresentante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.edtNomeApresentante.Location = new System.Drawing.Point(10, 154);
            this.edtNomeApresentante.Multiline = true;
            this.edtNomeApresentante.Name = "edtNomeApresentante";
            this.edtNomeApresentante.Size = new System.Drawing.Size(491, 24);
            this.edtNomeApresentante.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Apresentante:";
            this.label7.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label7_MouseDoubleClick);
            // 
            // edtCustas
            // 
            this.edtCustas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.edtCustas.Location = new System.Drawing.Point(305, 91);
            this.edtCustas.Name = "edtCustas";
            this.edtCustas.Size = new System.Drawing.Size(196, 26);
            this.edtCustas.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(237, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Custas:";
            this.label6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label6_MouseDoubleClick);
            // 
            // edtValor
            // 
            this.edtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.edtValor.Location = new System.Drawing.Point(62, 91);
            this.edtValor.Name = "edtValor";
            this.edtValor.Size = new System.Drawing.Size(171, 26);
            this.edtValor.TabIndex = 9;
            this.edtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_keyPress);
            this.edtValor.Leave += new System.EventHandler(this.edtValor_Leave);
            // 
            // edtNumTit
            // 
            this.edtNumTit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.edtNumTit.Location = new System.Drawing.Point(80, 58);
            this.edtNumTit.Name = "edtNumTit";
            this.edtNumTit.Size = new System.Drawing.Size(153, 26);
            this.edtNumTit.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Valor:";
            this.label5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label5_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Emissão:";
            this.label4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Número:";
            this.label3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // edtProtocolo
            // 
            this.edtProtocolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.edtProtocolo.Location = new System.Drawing.Point(80, 25);
            this.edtProtocolo.Name = "edtProtocolo";
            this.edtProtocolo.Size = new System.Drawing.Size(153, 26);
            this.edtProtocolo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Protocolo:";
            this.label1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDoubleClick);
            // 
            // FormTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(507, 565);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTitulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Título";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvarAlteraçõeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox edtDocumentoDevedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox edtNomeDevedor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox edtDocumentoCredor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox edtNomeCredor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox edtDataEmissao;
        private System.Windows.Forms.MaskedTextBox edtDataApresentacao;
        private System.Windows.Forms.TextBox edtDocApresentante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox edtNomeApresentante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edtCustas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtValor;
        private System.Windows.Forms.TextBox edtNumTit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtProtocolo;
        private System.Windows.Forms.Label label1;
    }
}