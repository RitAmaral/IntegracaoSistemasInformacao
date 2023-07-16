namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSobre_Click(object sender, EventArgs e) //ir para página Sobre Euro
        {
            var SobreEuro = new SobreEuro();
            SobreEuro.Show();
            this.Visible = false; //nao ficar pagina visivel quando vamos para sobreEuro
        }

        private void buttonSair_Click(object sender, EventArgs e) //fechar aplicação
        {
            Application.Exit();
        }

        private void buttonPaises_Click(object sender, EventArgs e)
        {
            var Paises = new Paises();
            Paises.Show();
            this.Visible = false;
        }
    }
}