namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSobre_Click(object sender, EventArgs e)
        {
            var SobreEuro = new SobreEuro();
            SobreEuro.Show();
            this.Visible = false;
        }
    }
}