using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

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
        private void FormMenu_Load(object sender, EventArgs e)
        {
            CentralizarPanel();
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90);
            path.AddArc(panelMenu.Width - 20, 0, 20, 20, 270, 90);
            path.AddArc(panelMenu.Width - 20, panelMenu.Height - 20, 20, 20, 0, 90);
            path.AddArc(0, panelMenu.Height - 20, 20, 20, 90, 90);
            path.CloseAllFigures();
            panelMenu.Region = new Region(path);



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

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }


        private void CentralizarPanel()
        {
            panelMenu.Left = (this.ClientSize.Width - panelMenu.Width) / 2;
            panelMenu.Top = (this.ClientSize.Height - panelMenu.Height) / 2;

            this.Invalidate();
        }

        private void FormMenu_Resize(object sender, EventArgs e)
        {
            CentralizarPanel();
            this.Invalidate();

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (LinearGradientBrush brush = new LinearGradientBrush(
               this.ClientRectangle,
               Color.LightGray,
               Color.White,
               90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int shadowSize = 10;   // tamanho da sombra
            int radius = 20;       // arredondamento do painel

            Rectangle panelRect = panelMenu.Bounds;

            // Desenha múltiplas camadas para criar fade
            for (int i = 0; i < shadowSize; i++)
            {
                int alpha = 20 - i; // vai diminuindo a transparência
                if (alpha < 0) alpha = 0;

                Rectangle shadowRect = new Rectangle(
                    panelRect.Left - i,
                    panelRect.Top - i,
                    panelRect.Width + (i * 2),
                    panelRect.Height + (i * 2)
                );

                using (GraphicsPath path = GetRoundedRectangle(shadowRect, radius))
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(alpha, 0, 0, 0)))
                {
                    g.FillPath(brush, path);
                }
            }
        }

        private void btnProdutos_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(30, 90, 170);

        }

        private void btnProdutos_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(20, 70, 140);

        }

        private void FormMenu_Paint(object sender, PaintEventArgs e)
        {
        
        }

    }
}
