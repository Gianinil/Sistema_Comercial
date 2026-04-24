namespace SistemaComercial.Forms
{
    partial class FormMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            panelMenu = new Panel();
            btnContasReceber = new Button();
            btnContasPagar = new Button();
            btnClientes = new Button();
            label1 = new Label();
            btnProdutos = new Button();
            btnVendas = new Button();
            btnSair = new Button();
            btnCaixa = new Button();
            timerFade = new System.Windows.Forms.Timer(components);
            panelHeader = new Panel();
            label2 = new Label();
            lblSistema = new Label();
            panelMenu.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(250, 250, 250);
            panelMenu.Controls.Add(btnContasReceber);
            panelMenu.Controls.Add(btnContasPagar);
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Controls.Add(label1);
            panelMenu.Controls.Add(btnProdutos);
            panelMenu.Controls.Add(btnVendas);
            panelMenu.Controls.Add(btnSair);
            panelMenu.Controls.Add(btnCaixa);
            panelMenu.Location = new Point(284, 114);
            panelMenu.Name = "panelMenu";
            panelMenu.Padding = new Padding(40);
            panelMenu.Size = new Size(813, 512);
            panelMenu.TabIndex = 4;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // btnContasReceber
            // 
            btnContasReceber.BackColor = Color.FromArgb(20, 70, 140);
            btnContasReceber.Cursor = Cursors.Hand;
            btnContasReceber.FlatAppearance.BorderSize = 0;
            btnContasReceber.FlatStyle = FlatStyle.Flat;
            btnContasReceber.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnContasReceber.ForeColor = Color.White;
            btnContasReceber.Location = new Point(411, 312);
            btnContasReceber.Margin = new Padding(30);
            btnContasReceber.Name = "btnContasReceber";
            btnContasReceber.Size = new Size(160, 45);
            btnContasReceber.TabIndex = 7;
            btnContasReceber.Text = "CONTAS A RECEBER";
            btnContasReceber.UseVisualStyleBackColor = false;
            btnContasReceber.Click += btnContasReceber_Click;
            // 
            // btnContasPagar
            // 
            btnContasPagar.BackColor = Color.FromArgb(20, 70, 140);
            btnContasPagar.Cursor = Cursors.Hand;
            btnContasPagar.FlatAppearance.BorderSize = 0;
            btnContasPagar.FlatStyle = FlatStyle.Flat;
            btnContasPagar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnContasPagar.ForeColor = Color.White;
            btnContasPagar.Location = new Point(411, 369);
            btnContasPagar.Margin = new Padding(30);
            btnContasPagar.Name = "btnContasPagar";
            btnContasPagar.Size = new Size(160, 60);
            btnContasPagar.TabIndex = 6;
            btnContasPagar.Text = "CONTAS A PAGAR";
            btnContasPagar.UseVisualStyleBackColor = false;
            btnContasPagar.Click += btnContasPagar_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(20, 70, 140);
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(225, 369);
            btnClientes.Margin = new Padding(30);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(160, 60);
            btnClientes.TabIndex = 5;
            btnClientes.Text = "CADASTRO DE CLIENTES";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(20, 70, 140);
            label1.Location = new Point(276, 125);
            label1.Name = "label1";
            label1.Size = new Size(255, 37);
            label1.TabIndex = 4;
            label1.Text = "PAINEL PRINCIPAL";
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.FromArgb(20, 70, 140);
            btnProdutos.Cursor = Cursors.Hand;
            btnProdutos.FlatAppearance.BorderSize = 0;
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnProdutos.ForeColor = Color.White;
            btnProdutos.Location = new Point(225, 256);
            btnProdutos.Margin = new Padding(30);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(160, 45);
            btnProdutos.TabIndex = 0;
            btnProdutos.Text = "PRODUTOS";
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            btnProdutos.MouseEnter += btnProdutos_MouseEnter;
            btnProdutos.MouseLeave += btnProdutos_MouseLeave;
            // 
            // btnVendas
            // 
            btnVendas.BackColor = Color.FromArgb(20, 70, 140);
            btnVendas.Cursor = Cursors.Hand;
            btnVendas.FlatAppearance.BorderSize = 0;
            btnVendas.FlatStyle = FlatStyle.Flat;
            btnVendas.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnVendas.ForeColor = Color.White;
            btnVendas.Location = new Point(411, 256);
            btnVendas.Margin = new Padding(30);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(160, 45);
            btnVendas.TabIndex = 2;
            btnVendas.Text = "VENDAS";
            btnVendas.UseVisualStyleBackColor = false;
            btnVendas.Click += btnVendas_Click;
            btnVendas.MouseEnter += btnProdutos_MouseEnter;
            btnVendas.MouseLeave += btnProdutos_MouseLeave;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(20, 70, 140);
            btnSair.Cursor = Cursors.Hand;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(322, 445);
            btnSair.Margin = new Padding(30);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(160, 45);
            btnSair.TabIndex = 1;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            btnSair.MouseEnter += btnProdutos_MouseEnter;
            btnSair.MouseLeave += btnProdutos_MouseLeave;
            // 
            // btnCaixa
            // 
            btnCaixa.BackColor = Color.FromArgb(20, 70, 140);
            btnCaixa.Cursor = Cursors.Hand;
            btnCaixa.FlatAppearance.BorderSize = 0;
            btnCaixa.FlatStyle = FlatStyle.Flat;
            btnCaixa.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnCaixa.ForeColor = Color.White;
            btnCaixa.Location = new Point(225, 312);
            btnCaixa.Margin = new Padding(30);
            btnCaixa.Name = "btnCaixa";
            btnCaixa.Size = new Size(160, 45);
            btnCaixa.TabIndex = 3;
            btnCaixa.Text = "CAIXA";
            btnCaixa.UseVisualStyleBackColor = false;
            btnCaixa.Click += btnCaixa_Click_1;
            btnCaixa.MouseEnter += btnProdutos_MouseEnter;
            btnCaixa.MouseLeave += btnProdutos_MouseLeave;
            // 
            // timerFade
            // 
            timerFade.Interval = 20;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(20, 70, 140);
            panelHeader.Controls.Add(label2);
            panelHeader.Controls.Add(lblSistema);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1565, 50);
            panelHeader.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(1348, 15);
            label2.Name = "label2";
            label2.Size = new Size(205, 21);
            label2.TabIndex = 1;
            label2.Text = "PAINEL ADMINISTRATIVO";
            // 
            // lblSistema
            // 
            lblSistema.AutoSize = true;
            lblSistema.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSistema.ForeColor = SystemColors.ButtonHighlight;
            lblSistema.Location = new Point(20, 15);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(171, 21);
            lblSistema.TabIndex = 0;
            lblSistema.Text = "SISTEMA COMERCIAL";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 230, 230);
            ClientSize = new Size(1565, 872);
            Controls.Add(panelHeader);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Comercial";
            WindowState = FormWindowState.Maximized;
            Load += FormMenu_Load;
            Paint += FormMenu_Paint;
            Resize += FormMenu_Resize;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnProdutos;
        private Button btnVendas;
        private Button btnSair;
        private Button btnCaixa;
        private System.Windows.Forms.Timer timerFade;
        private Label label1;
        private Panel panelHeader;
        private Label lblSistema;
        private Label label2;
        private Button btnClientes;
        private Button btnContasReceber;
        private Button btnContasPagar;
    }
}