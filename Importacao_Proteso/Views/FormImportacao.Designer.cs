namespace Importacao_Proteso
{
    partial class FormImportacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportacao));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edtDocCredor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.edtNomeCredor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edtDocDevedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edtNomeDevedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edtNumTit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.edtProtocolo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTitulos = new System.Windows.Forms.DataGridView();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edtNomeApresentante = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.edtDocApresentante = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.importarToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.consultarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarToolStripMenuItem.Image")));
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(104, 25);
            this.consultarToolStripMenuItem.Text = "Pesquisar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.importarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("importarToolStripMenuItem.Image")));
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.importarToolStripMenuItem.Text = "Importar";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.importarToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.edtDocApresentante);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.edtNomeApresentante);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.edtDocCredor);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.edtNomeCredor);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.edtDocDevedor);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.edtNomeDevedor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.edtNumTit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtData);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.edtProtocolo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 532);
            this.panel1.TabIndex = 1;
            // 
            // edtDocCredor
            // 
            this.edtDocCredor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.edtDocCredor.Location = new System.Drawing.Point(3, 376);
            this.edtDocCredor.Name = "edtDocCredor";
            this.edtDocCredor.Size = new System.Drawing.Size(214, 26);
            this.edtDocCredor.TabIndex = 14;
            this.edtDocCredor.TextChanged += new System.EventHandler(this.edtDocCredor_TextChanged);
            this.edtDocCredor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_keyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(0, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Documento Credor";
            // 
            // edtNomeCredor
            // 
            this.edtNomeCredor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.edtNomeCredor.Location = new System.Drawing.Point(3, 314);
            this.edtNomeCredor.Name = "edtNomeCredor";
            this.edtNomeCredor.Size = new System.Drawing.Size(214, 26);
            this.edtNomeCredor.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(0, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nome Credor";
            // 
            // edtDocDevedor
            // 
            this.edtDocDevedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.edtDocDevedor.Location = new System.Drawing.Point(3, 254);
            this.edtDocDevedor.Name = "edtDocDevedor";
            this.edtDocDevedor.Size = new System.Drawing.Size(214, 26);
            this.edtDocDevedor.TabIndex = 10;
            this.edtDocDevedor.TextChanged += new System.EventHandler(this.edtDocDevedor_TextChanged);
            this.edtDocDevedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_keyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(0, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Documento Devedor";
            // 
            // edtNomeDevedor
            // 
            this.edtNomeDevedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.edtNomeDevedor.Location = new System.Drawing.Point(3, 195);
            this.edtNomeDevedor.Name = "edtNomeDevedor";
            this.edtNomeDevedor.Size = new System.Drawing.Size(214, 26);
            this.edtNomeDevedor.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(0, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nome Devedor";
            // 
            // edtNumTit
            // 
            this.edtNumTit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.edtNumTit.Location = new System.Drawing.Point(3, 137);
            this.edtNumTit.Name = "edtNumTit";
            this.edtNumTit.Size = new System.Drawing.Size(214, 26);
            this.edtNumTit.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(0, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Número do título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(196, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "  ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // dtData
            // 
            this.dtData.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(3, 79);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(187, 26);
            this.dtData.TabIndex = 3;
            this.dtData.ValueChanged += new System.EventHandler(this.dtData_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(-3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Apresentação";
            // 
            // edtProtocolo
            // 
            this.edtProtocolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.edtProtocolo.Location = new System.Drawing.Point(3, 30);
            this.edtProtocolo.Name = "edtProtocolo";
            this.edtProtocolo.Size = new System.Drawing.Size(214, 26);
            this.edtProtocolo.TabIndex = 1;
            this.edtProtocolo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_keyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(-3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Protocolo";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvTitulos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(223, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 532);
            this.panel2.TabIndex = 2;
            // 
            // dgvTitulos
            // 
            this.dgvTitulos.AllowUserToAddRows = false;
            this.dgvTitulos.AllowUserToDeleteRows = false;
            this.dgvTitulos.AllowUserToOrderColumns = true;
            this.dgvTitulos.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvTitulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTitulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTitulos.Location = new System.Drawing.Point(0, 0);
            this.dgvTitulos.Name = "dgvTitulos";
            this.dgvTitulos.ReadOnly = true;
            this.dgvTitulos.Size = new System.Drawing.Size(761, 532);
            this.dgvTitulos.TabIndex = 0;
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ajudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajudaToolStripMenuItem.Image")));
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // edtNomeApresentante
            // 
            this.edtNomeApresentante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.edtNomeApresentante.Location = new System.Drawing.Point(3, 437);
            this.edtNomeApresentante.Name = "edtNomeApresentante";
            this.edtNomeApresentante.Size = new System.Drawing.Size(214, 26);
            this.edtNomeApresentante.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(0, 417);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nome Apresentante";
            // 
            // edtDocApresentante
            // 
            this.edtDocApresentante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.edtDocApresentante.Location = new System.Drawing.Point(3, 495);
            this.edtDocApresentante.Name = "edtDocApresentante";
            this.edtDocApresentante.Size = new System.Drawing.Size(214, 26);
            this.edtDocApresentante.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(0, 475);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Documento Apresentante";
            // 
            // FormImportacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormImportacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importação de títulos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtProtocolo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtDocCredor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox edtNomeCredor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edtDocDevedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtNomeDevedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtNumTit;
        private System.Windows.Forms.DataGridView dgvTitulos;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.TextBox edtDocApresentante;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox edtNomeApresentante;
        private System.Windows.Forms.Label label9;
    }
}

