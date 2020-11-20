namespace Trabalho.LTP.UI
{
    partial class Principal
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtAtualizar = new System.Windows.Forms.Button();
            this.BtRemover = new System.Windows.Forms.Button();
            this.BtAdicionar = new System.Windows.Forms.Button();
            this.TxtPreco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GridItems = new System.Windows.Forms.DataGridView();
            this.ColumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumQuatidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TxtId);
            this.panel4.Controls.Add(this.BtAtualizar);
            this.panel4.Controls.Add(this.BtRemover);
            this.panel4.Controls.Add(this.BtAdicionar);
            this.panel4.Controls.Add(this.TxtPreco);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.TxtDescricao);
            this.panel4.Controls.Add(this.TxtQuantidade);
            this.panel4.Controls.Add(this.TxtName);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(803, 344);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(120, 116);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 14;
            // 
            // BtAtualizar
            // 
            this.BtAtualizar.BackColor = System.Drawing.SystemColors.Control;
            this.BtAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAtualizar.Location = new System.Drawing.Point(362, 212);
            this.BtAtualizar.Name = "BtAtualizar";
            this.BtAtualizar.Size = new System.Drawing.Size(93, 23);
            this.BtAtualizar.TabIndex = 13;
            this.BtAtualizar.Text = "Atualizar";
            this.BtAtualizar.UseVisualStyleBackColor = false;
            this.BtAtualizar.Click += new System.EventHandler(this.BtAtualizar_Click_1);
            // 
            // BtRemover
            // 
            this.BtRemover.BackColor = System.Drawing.SystemColors.Control;
            this.BtRemover.Location = new System.Drawing.Point(362, 182);
            this.BtRemover.Name = "BtRemover";
            this.BtRemover.Size = new System.Drawing.Size(93, 24);
            this.BtRemover.TabIndex = 12;
            this.BtRemover.Text = "Remover";
            this.BtRemover.UseVisualStyleBackColor = false;
            this.BtRemover.Click += new System.EventHandler(this.BtRemover_Click);
            // 
            // BtAdicionar
            // 
            this.BtAdicionar.BackColor = System.Drawing.SystemColors.Control;
            this.BtAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAdicionar.Location = new System.Drawing.Point(362, 152);
            this.BtAdicionar.Name = "BtAdicionar";
            this.BtAdicionar.Size = new System.Drawing.Size(93, 24);
            this.BtAdicionar.TabIndex = 11;
            this.BtAdicionar.Text = "Adicionar";
            this.BtAdicionar.UseVisualStyleBackColor = false;
            this.BtAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtPreco
            // 
            this.TxtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPreco.Location = new System.Drawing.Point(264, 247);
            this.TxtPreco.Name = "TxtPreco";
            this.TxtPreco.Size = new System.Drawing.Size(63, 29);
            this.TxtPreco.TabIndex = 10;
            this.TxtPreco.TextChanged += new System.EventHandler(this.TxtPreco_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(198, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Preço";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescricao.Location = new System.Drawing.Point(120, 182);
            this.TxtDescricao.Multiline = true;
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(207, 59);
            this.TxtDescricao.TabIndex = 6;
            this.TxtDescricao.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuantidade.Location = new System.Drawing.Point(120, 247);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(63, 29);
            this.TxtQuantidade.TabIndex = 5;
            this.TxtQuantidade.TextChanged += new System.EventHandler(this.TxtQuantidade_TextChanged);
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(120, 147);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(207, 29);
            this.TxtName.TabIndex = 4;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descrição";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantidade";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.GridItems);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(803, 136);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint_1);
            // 
            // GridItems
            // 
            this.GridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumID,
            this.ColumNome,
            this.ColumQuatidade,
            this.ColumnPreco,
            this.ColumDescricao});
            this.GridItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridItems.Location = new System.Drawing.Point(0, 0);
            this.GridItems.MultiSelect = false;
            this.GridItems.Name = "GridItems";
            this.GridItems.RowHeadersWidth = 123;
            this.GridItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridItems.Size = new System.Drawing.Size(803, 136);
            this.GridItems.TabIndex = 0;
            this.GridItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.GridItems.DoubleClick += new System.EventHandler(this.GridItems_DoubleClick);
            // 
            // ColumID
            // 
            this.ColumID.DataPropertyName = "ID";
            this.ColumID.HeaderText = "Id";
            this.ColumID.Name = "ColumID";
            this.ColumID.Width = 40;
            // 
            // ColumNome
            // 
            this.ColumNome.DataPropertyName = "Nome";
            this.ColumNome.FillWeight = 80F;
            this.ColumNome.HeaderText = "Nome";
            this.ColumNome.Name = "ColumNome";
            // 
            // ColumQuatidade
            // 
            this.ColumQuatidade.DataPropertyName = "Quantidade";
            this.ColumQuatidade.FillWeight = 20F;
            this.ColumQuatidade.HeaderText = "Quantidade";
            this.ColumQuatidade.Name = "ColumQuatidade";
            // 
            // ColumnPreco
            // 
            this.ColumnPreco.DataPropertyName = "Preco";
            this.ColumnPreco.FillWeight = 20F;
            this.ColumnPreco.HeaderText = "Preço";
            this.ColumnPreco.Name = "ColumnPreco";
            // 
            // ColumDescricao
            // 
            this.ColumDescricao.DataPropertyName = "Descricao";
            this.ColumDescricao.HeaderText = "Descrição";
            this.ColumDescricao.Name = "ColumDescricao";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1936, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(87, 8);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(803, 480);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtAtualizar;
        private System.Windows.Forms.Button BtRemover;
        private System.Windows.Forms.Button BtAdicionar;
        private System.Windows.Forms.TextBox TxtPreco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView GridItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumQuatidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumDescricao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtId;
    }
}

