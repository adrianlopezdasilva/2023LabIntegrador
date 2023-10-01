using Entidades;
namespace FrmCalculadora

{
    public partial class FrmCalculadora : Form
    {
        private Numeracion resultado;
        private Operacion calculadora;
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private ESistema sistema;

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrimerOperador.Text = string.Empty;
            txtSegundoOperador.Text = string.Empty;
            lblResultado.Text = string.Empty;
            resultado = null;
        }

        private void setResultado()
        {
            if (resultado != null)
            {

                lblResultado.Text = resultado.ToString();

            }
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            // Operacion.Operar(cmbOperacion.Text.)
            {

            }
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperacion.Items.Add("+");
            cmbOperacion.Items.Add("-");
            cmbOperacion.Items.Add("*");
            cmbOperacion.Items.Add("/");
        }

        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {
            //primerOperando.Valor = txtPrimerOperador.Text;
        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            sistema = ESistema.Decimal;
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            sistema = ESistema.Binario;
        }
    }
}