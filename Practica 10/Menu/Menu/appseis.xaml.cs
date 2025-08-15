namespace Menu;

public partial class appseis : ContentPage
{
	public appseis()
	{
		InitializeComponent();
	}

    private void CalcularDolares(object sender, EventArgs e)
    {
        if (double.TryParse(pesosEntry.Text, out double pesos) &&
            double.TryParse(tipoCambioEntry.Text, out double tipoCambio) &&
            tipoCambio > 0)
        {
            double dolares = pesos / tipoCambio;
            resultadoLabel.Text = $"Con ${pesos:F2} MXN puedes adquirir ${dolares:F2} USD";
        }
        else
        {
            resultadoLabel.Text = "Por favor, ingrese valores v�lidos.";
        }
    }
}