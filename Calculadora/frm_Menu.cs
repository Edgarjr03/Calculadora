namespace Calculadora
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void TxtVariableA_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculadoraSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Calculadora calculadoraSimple = new frm_Calculadora();
            calculadoraSimple.Show();
        }


        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Burbuja burbuja = new frm_Burbuja();
            burbuja.Show();
        }
    }
}
