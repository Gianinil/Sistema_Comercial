using SistemaComercial.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;


namespace SistemaComercial
{

    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtSenha.Text == "123")
            {
                FormMenu menu = new FormMenu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");
            }

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            panelLogin.Region = Region.FromHrgn(CreateRoundRectRgn(
                0, 0, panelLogin.Width, panelLogin.Height, 30, 30));
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

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

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(0, 0, 43),
                Color.FromArgb(0, 0, 23),
                90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

    }
}
