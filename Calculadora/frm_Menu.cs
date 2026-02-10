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

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Registro registro = new frm_Registro();
            registro.Show();
        }

        private void relogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_temporizadores reloj = new frm_temporizadores();
            reloj.Show();
        }
    }
}
