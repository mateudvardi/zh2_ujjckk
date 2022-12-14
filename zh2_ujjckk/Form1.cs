namespace zh2_ujjckk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kilepes_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Biztosan ki akar lépni?", "Kilépés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void megnyitas_Click(object sender, EventArgs e)
        {
            Alkalmazas alkalmazas = new Alkalmazas();
            alkalmazas.Show();
        }
    }
}