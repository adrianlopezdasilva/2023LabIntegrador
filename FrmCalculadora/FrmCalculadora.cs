using Entidades;
namespace FrmCalculadora

{
    public partial class FrmCalculadora : Form
{
    private Numeracion resultado;

    public FrmCalculadora()
    {
        InitializeComponent();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        txtPrimerOperador.Text = string.Empty;
        txtSegundoOperador.Text = string.Empty;
        lblResultado.Text = string.Empty;
        //resultado.Valor = null;
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
}
}