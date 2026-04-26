namespace SistemaComercial
{
    partial class FormVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenda));
            cmbProduto = new ComboBox();
            txtQuantidade = new TextBox();
            btnVender = new Button();
            btnCancelar = new Button();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            Produto = new Label();
            Quantidade = new Label();
            label1 = new Label();
            cbMetodoPagamento = new ComboBox();
            cmbCliente = new ComboBox();
            label2 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // cmbProduto
            // 
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Location = new Point(281, 150);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(232, 23);
            cmbProduto.TabIndex = 0;
            cmbProduto.SelectedIndexChanged += cmbProduto_SelectedIndexChanged;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(281, 206);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(232, 23);
            txtQuantidade.TabIndex = 1;
            // 
            // btnVender
            // 
            btnVender.BackColor = Color.FromArgb(5, 1, 71);
            btnVender.Cursor = Cursors.Hand;
            btnVender.FlatAppearance.BorderSize = 0;
            btnVender.FlatStyle = FlatStyle.Flat;
            btnVender.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnVender.ForeColor = SystemColors.ControlLightLight;
            btnVender.Location = new Point(281, 331);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(113, 34);
            btnVender.TabIndex = 2;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = false;
            btnVender.Click += btnVender_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(5, 1, 71);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(400, 331);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 34);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // Produto
            // 
            Produto.AutoSize = true;
            Produto.BackColor = SystemColors.Control;
            Produto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Produto.Location = new Point(281, 130);
            Produto.Name = "Produto";
            Produto.Size = new Size(58, 17);
            Produto.TabIndex = 4;
            Produto.Text = "Produto";
            // 
            // Quantidade
            // 
            Quantidade.AutoSize = true;
            Quantidade.BackColor = SystemColors.Control;
            Quantidade.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Quantidade.Location = new Point(281, 186);
            Quantidade.Name = "Quantidade";
            Quantidade.Size = new Size(79, 17);
            Quantidade.TabIndex = 5;
            Quantidade.Text = "Quantidade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 248);
            label1.Name = "label1";
            label1.Size = new Size(149, 17);
            label1.TabIndex = 6;
            label1.Text = "Método de Pagamento";
            // 
            // cbMetodoPagamento
            // 
            cbMetodoPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMetodoPagamento.FormattingEnabled = true;
            cbMetodoPagamento.Location = new Point(281, 268);
            cbMetodoPagamento.Name = "cbMetodoPagamento";
            cbMetodoPagamento.Size = new Size(232, 23);
            cbMetodoPagamento.TabIndex = 7;
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(281, 104);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(232, 23);
            cmbCliente.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(281, 84);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 8;
            label2.Text = "Cliente";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Location = new Point(240, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 344);
            panel1.TabIndex = 10;
            // 
            // FormVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(824, 487);
            Controls.Add(cmbCliente);
            Controls.Add(label2);
            Controls.Add(cbMetodoPagamento);
            Controls.Add(label1);
            Controls.Add(Quantidade);
            Controls.Add(Produto);
            Controls.Add(btnCancelar);
            Controls.Add(btnVender);
            Controls.Add(txtQuantidade);
            Controls.Add(cmbProduto);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Comercial";
            Load += FormVenda_Load;
            Paint += FormVenda_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProduto;
        private TextBox txtQuantidade;
        private Button btnVender;
        private Button btnCancelar;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Label Produto;
        private Label Quantidade;
        private Label label1;
        private ComboBox cbMetodoPagamento;
        private ComboBox cmbCliente;
        private Label label2;
        private Panel panel1;
    }
}