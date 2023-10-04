namespace Front
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void butEntFinanciera_Click(object sender, EventArgs e)
        {
            MenuEntidad form = new MenuEntidad();
            form.Show();
            this.Hide();
        }

        private void butCliente_Click(object sender, EventArgs e)
        {
            MenuCliente form = new MenuCliente();
            form.Show();
            this.Hide();
        }
    }
}