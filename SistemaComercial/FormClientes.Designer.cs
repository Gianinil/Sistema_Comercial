namespace SistemaComercial
{
    partial class FormClientes
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
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtCpf = new TextBox();
            Telefone = new Label();
            txtTelefone = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtEndereco = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(289, 81);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(219, 23);
            txtNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 63);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 107);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 3;
            label2.Text = "CPF/CNPJ: ";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(289, 125);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(219, 23);
            txtCpf.TabIndex = 2;
            // 
            // Telefone
            // 
            Telefone.AutoSize = true;
            Telefone.Location = new Point(289, 151);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(58, 15);
            Telefone.TabIndex = 5;
            Telefone.Text = "Telefone: ";
            Telefone.Click += label3_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(289, 169);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(219, 23);
            txtTelefone.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(289, 195);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 7;
            label3.Text = "Email: ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(289, 213);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(219, 23);
            txtEmail.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(289, 239);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 9;
            label4.Text = "Endereço: ";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(289, 257);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(219, 23);
            txtEndereco.TabIndex = 8;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(348, 336);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(label4);
            Controls.Add(txtEndereco);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(Telefone);
            Controls.Add(txtTelefone);
            Controls.Add(label2);
            Controls.Add(txtCpf);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Name = "FormClientes";
            Text = "FormClientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private TextBox txtCpf;
        private Label Telefone;
        private TextBox txtTelefone;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtEndereco;
        private Button btnSalvar;
    }
}