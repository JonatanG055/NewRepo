namespace CalcularIC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
            private void btnCalcular_Click(object sender, EventArgs e)
            {
                // Obtener el monto inicial y el porcentaje % en los texbox 
                double montoInicial = double.Parse(txtMontoInicial.Text);
                double porcentaje = double.Parse(txtPorcentaje.Text);

                // Calcular el inter�s compuesto
                double interesCompuesto = montoInicial + (montoInicial * (porcentaje / 100));

                // Mostrar el resultado en el Label
                lblResultado.Text = $"Inter�s compuesto: {interesCompuesto:C}";
            }

    }
}