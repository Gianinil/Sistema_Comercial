using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SistemaComercial.Forms
{
    public partial class FormMenu : Form
    {
        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();
            return path;
        }

        int fadeAlpha = 0;
        System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();

        public FormMenu()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormProdutos tela = new FormProdutos();
            tela.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            FormVenda tela = new FormVenda();
            tela.ShowDialog();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private void btnCaixa_Click_1(object sender, EventArgs e)
        {
            FormCaixa tela = new FormCaixa();
            tela.ShowDialog();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e) { }
        private void FormMenu_Paint(object sender, PaintEventArgs e) { }
        private void btnFornecedor_Click(object sender, EventArgs e) { }

        private void btnContasPagar_Click(object sender, EventArgs e)
        {
            FormContasPagar tela = new FormContasPagar();
            tela.Show();
        }

        private void btnContasReceber_Click(object sender, EventArgs e)
        {
            FormContasReceber tela = new FormContasReceber();
            tela.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            CentralizarConteudo();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            CentralizarConteudo();
        }

        private void CentralizarConteudo()
        {
            // Área disponível = tudo à direita da sidebar e abaixo do header
            int areaX = panel1.Width;
            int areaW = this.ClientSize.Width - panel1.Width;
            int areaY = panel2.Height;
            int areaH = this.ClientSize.Height - panel2.Height;

            if (areaW <= 0 || areaH <= 0) return;

            // Desliga AutoSize para controlar largura manualmente
            label3.AutoSize = false;
            lblHora.AutoSize = false;
            lblData.AutoSize = false;

            // Ocupa toda a largura disponível e centraliza o texto dentro
            label3.Width = areaW;
            lblHora.Width = areaW;
            lblData.Width = areaW;

            label3.TextAlign = ContentAlignment.MiddleCenter;
            lblHora.TextAlign = ContentAlignment.MiddleCenter;
            lblData.TextAlign = ContentAlignment.MiddleCenter;

            // Altura suficiente para fonte grande não cortar
            label3.Height = 140;
            lblHora.Height = 140;
            lblData.Height = 100;

            // Posiciona verticalmente na área principal
            label3.Location = new Point(areaX, areaY + (int)(areaH * 0.18));
            lblHora.Location = new Point(areaX, areaY + (int)(areaH * 0.40));
            lblData.Location = new Point(areaX, areaY + (int)(areaH * 0.63));

            btnFornecedor.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnFornecedor_Click_1(object sender, EventArgs e)
        {
            FormCadastroFornecedores tela = new FormCadastroFornecedores();
            tela.ShowDialog();
        }

        private void FormMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
                e.SuppressKeyPress = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormClientes tela = new FormClientes();
            tela.Show();
        }
    }
}