namespace sueldosemanal
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalcularClicked(object sender, EventArgs e)
        {
            // Validar entrada
            if (double.TryParse(txtHoras.Text, out double horas) &&
                double.TryParse(txtPagoHora.Text, out double pagoHora))
            {
                // Calcular sueldo semanal
                double sueldo = horas * pagoHora;
                lblResultado.Text = $"Sueldo semanal: ${sueldo:F2}";
            }
            else
            {
                lblResultado.Text = "⚠️ Ingresa valores válidos.";
            }
        }
    }
}
