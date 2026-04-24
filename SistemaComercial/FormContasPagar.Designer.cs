namespace SistemaComercial
{
    partial class FormContasPagar
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
            label1 = new Label();
            txtFornecedor = new TextBox();
            txtValor = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dtData = new DateTimePicker();
            cbStatus = new ComboBox();
            label4 = new Label();
            btnSalvar = new Button();
            dgvPagar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPagar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 548);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Fornecedor: ";
            // 
            // txtFornecedor
            // 
            txtFornecedor.Location = new Point(60, 566);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(214, 23);
            txtFornecedor.TabIndex = 1;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(60, 628);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(214, 23);
            txtValor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 610);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Valor: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 548);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Valor: ";
            // 
            // dtData
            // 
            dtData.Format = DateTimePickerFormat.Custom;
            dtData.Location = new Point(361, 566);
            dtData.Name = "dtData";
            dtData.Size = new Size(200, 23);
            dtData.TabIndex = 5;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(361, 628);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(121, 23);
            cbStatus.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(361, 610);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 7;
            label4.Text = "Status: ";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(658, 548);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(114, 41);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // dgvPagar
            // 
            dgvPagar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagar.Dock = DockStyle.Top;
            dgvPagar.Location = new Point(0, 0);
            dgvPagar.Name = "dgvPagar";
            dgvPagar.Size = new Size(1269, 542);
            dgvPagar.TabIndex = 9;
            // 
            // FormContasPagar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 663);
            Controls.Add(dgvPagar);
            Controls.Add(btnSalvar);
            Controls.Add(label4);
            Controls.Add(cbStatus);
            Controls.Add(dtData);
            Controls.Add(label3);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(txtFornecedor);
            Controls.Add(label1);
            Name = "FormContasPagar";
            Text = "FormContasPagar";
            Load += FormContasPagar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPagar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFornecedor;
        private TextBox txtValor;
        private Label label2;
        private Label label3;
        private DateTimePicker dtData;
        private ComboBox cbStatus;
        private Label label4;
        private Button btnSalvar;
        private DataGridView dgvPagar;
    }
}