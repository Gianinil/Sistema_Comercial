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
            SuspendLayout();
            // 
            // cmbProduto
            // 
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Location = new Point(281, 107);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(232, 23);
            cmbProduto.TabIndex = 0;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(281, 163);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(232, 23);
            txtQuantidade.TabIndex = 1;
            // 
            // btnVender
            // 
            btnVender.BackColor = Color.FromArgb(20, 70, 140);
            btnVender.Cursor = Cursors.Hand;
            btnVender.FlatAppearance.BorderSize = 0;
            btnVender.FlatStyle = FlatStyle.Flat;
            btnVender.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnVender.ForeColor = SystemColors.ControlLightLight;
            btnVender.Location = new Point(281, 288);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(113, 34);
            btnVender.TabIndex = 2;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = false;
            btnVender.Click += btnVender_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(20, 70, 140);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(400, 288);
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
            Produto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Produto.Location = new Point(281, 87);
            Produto.Name = "Produto";
            Produto.Size = new Size(58, 17);
            Produto.TabIndex = 4;
            Produto.Text = "Produto";
            // 
            // Quantidade
            // 
            Quantidade.AutoSize = true;
            Quantidade.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Quantidade.Location = new Point(281, 143);
            Quantidade.Name = "Quantidade";
            Quantidade.Size = new Size(79, 17);
            Quantidade.TabIndex = 5;
            Quantidade.Text = "Quantidade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 205);
            label1.Name = "label1";
            label1.Size = new Size(149, 17);
            label1.TabIndex = 6;
            label1.Text = "Método de Pagamento";
            // 
            // cbMetodoPagamento
            // 
            cbMetodoPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMetodoPagamento.FormattingEnabled = true;
            cbMetodoPagamento.Location = new Point(281, 225);
            cbMetodoPagamento.Name = "cbMetodoPagamento";
            cbMetodoPagamento.Size = new Size(232, 23);
            cbMetodoPagamento.TabIndex = 7;
            // 
            // FormVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(824, 487);
            Controls.Add(cbMetodoPagamento);
            Controls.Add(label1);
            Controls.Add(Quantidade);
            Controls.Add(Produto);
            Controls.Add(btnCancelar);
            Controls.Add(btnVender);
            Controls.Add(txtQuantidade);
            Controls.Add(cmbProduto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Comercial";
            Load += FormVenda_Load;
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
    }
}