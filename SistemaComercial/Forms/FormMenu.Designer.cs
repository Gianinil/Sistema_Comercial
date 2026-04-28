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
            btnContasReceber = new Button();
            btnContasPagar = new Button();
            btnClientes = new Button();
            label1 = new Label();
            btnProdutos = new Button();
            btnVendas = new Button();
            btnSair = new Button();
            btnCaixa = new Button();
            timerFade = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panel3 = new Panel();
            lblSistema = new Label();
            label2 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel2 = new Panel();
            lblHora = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblData = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnContasReceber
            // 
            btnContasReceber.BackColor = Color.FromArgb(5, 1, 71);
            btnContasReceber.Cursor = Cursors.Hand;
            btnContasReceber.FlatAppearance.BorderSize = 0;
            btnContasReceber.FlatStyle = FlatStyle.Flat;
            btnContasReceber.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnContasReceber.ForeColor = Color.White;
            btnContasReceber.Image = (Image)resources.GetObject("btnContasReceber.Image");
            btnContasReceber.ImageAlign = ContentAlignment.MiddleLeft;
            btnContasReceber.Location = new Point(0, 286);
            btnContasReceber.Margin = new Padding(30);
            btnContasReceber.Name = "btnContasReceber";
            btnContasReceber.Padding = new Padding(10, 8, 10, 8);
            btnContasReceber.Size = new Size(313, 65);
            btnContasReceber.TabIndex = 7;
            btnContasReceber.Text = "CONTAS A RECEBER";
            btnContasReceber.UseVisualStyleBackColor = false;
            btnContasReceber.Click += btnContasReceber_Click;
            // 
            // btnContasPagar
            // 
            btnContasPagar.BackColor = Color.FromArgb(5, 1, 71);
            btnContasPagar.Cursor = Cursors.Hand;
            btnContasPagar.FlatAppearance.BorderSize = 0;
            btnContasPagar.FlatStyle = FlatStyle.Flat;
            btnContasPagar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnContasPagar.ForeColor = Color.White;
            btnContasPagar.Image = (Image)resources.GetObject("btnContasPagar.Image");
            btnContasPagar.ImageAlign = ContentAlignment.MiddleLeft;
            btnContasPagar.Location = new Point(0, 416);
            btnContasPagar.Margin = new Padding(30);
            btnContasPagar.Name = "btnContasPagar";
            btnContasPagar.Padding = new Padding(10, 8, 10, 8);
            btnContasPagar.Size = new Size(313, 65);
            btnContasPagar.TabIndex = 6;
            btnContasPagar.Text = "CONTAS A PAGAR";
            btnContasPagar.UseVisualStyleBackColor = false;
            btnContasPagar.Click += btnContasPagar_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(5, 1, 71);
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnClientes.ForeColor = Color.White;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 481);
            btnClientes.Margin = new Padding(30);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(16, 8, 16, 8);
            btnClientes.Size = new Size(313, 65);
            btnClientes.TabIndex = 5;
            btnClientes.Text = "     CADASTRO DE CLIENTES";
            btnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(255, 37);
            label1.TabIndex = 4;
            label1.Text = "PAINEL PRINCIPAL";
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.FromArgb(5, 1, 71);
            btnProdutos.Cursor = Cursors.Hand;
            btnProdutos.FlatAppearance.BorderSize = 0;
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnProdutos.ForeColor = Color.White;
            btnProdutos.Image = (Image)resources.GetObject("btnProdutos.Image");
            btnProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdutos.Location = new Point(0, 156);
            btnProdutos.Margin = new Padding(30);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Padding = new Padding(10, 8, 10, 8);
            btnProdutos.Size = new Size(313, 65);
            btnProdutos.TabIndex = 0;
            btnProdutos.Text = "PRODUTOS";
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnVendas
            // 
            btnVendas.BackColor = Color.FromArgb(5, 1, 71);
            btnVendas.Cursor = Cursors.Hand;
            btnVendas.FlatAppearance.BorderSize = 0;
            btnVendas.FlatStyle = FlatStyle.Flat;
            btnVendas.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnVendas.ForeColor = Color.White;
            btnVendas.Image = (Image)resources.GetObject("btnVendas.Image");
            btnVendas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVendas.Location = new Point(0, 221);
            btnVendas.Margin = new Padding(30);
            btnVendas.Name = "btnVendas";
            btnVendas.Padding = new Padding(16, 8, 16, 8);
            btnVendas.Size = new Size(313, 65);
            btnVendas.TabIndex = 2;
            btnVendas.Text = "VENDAS";
            btnVendas.UseVisualStyleBackColor = false;
            btnVendas.Click += btnVendas_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(5, 1, 71);
            btnSair.Cursor = Cursors.Hand;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnSair.ForeColor = Color.White;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(0, 898);
            btnSair.Margin = new Padding(30);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(313, 65);
            btnSair.TabIndex = 1;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnCaixa
            // 
            btnCaixa.BackColor = Color.FromArgb(5, 1, 71);
            btnCaixa.Cursor = Cursors.Hand;
            btnCaixa.FlatAppearance.BorderSize = 0;
            btnCaixa.FlatStyle = FlatStyle.Flat;
            btnCaixa.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnCaixa.ForeColor = Color.White;
            btnCaixa.Image = (Image)resources.GetObject("btnCaixa.Image");
            btnCaixa.ImageAlign = ContentAlignment.MiddleLeft;
            btnCaixa.Location = new Point(0, 351);
            btnCaixa.Margin = new Padding(30);
            btnCaixa.Name = "btnCaixa";
            btnCaixa.Padding = new Padding(16, 8, 16, 8);
            btnCaixa.Size = new Size(313, 65);
            btnCaixa.TabIndex = 3;
            btnCaixa.Text = "CAIXA";
            btnCaixa.UseVisualStyleBackColor = false;
            btnCaixa.Click += btnCaixa_Click_1;
            // 
            // timerFade
            // 
            timerFade.Interval = 20;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 43);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 1003);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(9, 3, 90);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(313, 100);
            panel3.TabIndex = 0;
            // 
            // lblSistema
            // 
            lblSistema.AutoSize = true;
            lblSistema.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSistema.ForeColor = SystemColors.ButtonHighlight;
            lblSistema.Location = new Point(18, 40);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(171, 21);
            lblSistema.TabIndex = 0;
            lblSistema.Text = "SISTEMA COMERCIAL";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(1249, 40);
            label2.Name = "label2";
            label2.Size = new Size(205, 21);
            label2.TabIndex = 1;
            label2.Text = "PAINEL ADMINISTRATIVO";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(9, 3, 90);
            panel2.Controls.Add(lblSistema);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(313, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1466, 100);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = SystemColors.ControlDarkDark;
            lblHora.Location = new Point(856, 458);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(436, 128);
            lblHora.TabIndex = 10;
            lblHora.Text = "00:00:00";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblData.ForeColor = SystemColors.ControlDarkDark;
            lblData.Location = new Point(882, 676);
            lblData.Name = "lblData";
            lblData.Size = new Size(389, 86);
            lblData.TabIndex = 11;
            lblData.Text = "00/00/0000";
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(787, 240);
            label3.Name = "label3";
            label3.Size = new Size(568, 128);
            label3.TabIndex = 12;
            label3.Text = "Bem vindo!";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1779, 1003);
            Controls.Add(label3);
            Controls.Add(lblData);
            Controls.Add(lblHora);
            Controls.Add(panel2);
            Controls.Add(btnContasReceber);
            Controls.Add(btnContasPagar);
            Controls.Add(btnClientes);
            Controls.Add(btnCaixa);
            Controls.Add(btnProdutos);
            Controls.Add(btnSair);
            Controls.Add(btnVendas);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Comercial";
            WindowState = FormWindowState.Maximized;
            Load += FormMenu_Load;
            Paint += FormMenu_Paint;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnProdutos;
        private Button btnVendas;
        private Button btnSair;
        private Button btnCaixa;
        private System.Windows.Forms.Timer timerFade;
        private Label label1;
        private Button btnClientes;
        private Button btnContasReceber;
        private Button btnContasPagar;
        private Panel panel1;
        private Panel panel2;
        private Label lblSistema;
        private Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Panel panel3;
        private Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private Label lblData;
        private System.Windows.Forms.Timer timer2;
        private Label label3;
    }
}