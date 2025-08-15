namespace Menu;

public partial class appcinco : ContentPage
{
	public appcinco()
	{
		InitializeComponent();
	}

    private void CalcularPresupuesto(object sender, EventArgs e)
    {
        if (int.TryParse(personasEntry.Text, out int cantidadPersonas) && cantidadPersonas > 0)
        {
            double costoPorPersona;

            if (cantidadPersonas <= 200)
                costoPorPersona = 95;
            else if (cantidadPersonas <= 300)
                costoPorPersona = 85;
            else
                costoPorPersona = 75;

            double total = cantidadPersonas * costoPorPersona;

            resultadoLabel.Text = $"Costo por persona: ${costoPorPersona:F2}\n" +
                                  $"Presupuesto total: ${total:F2}";
        }
        else
        {
            resultadoLabel.Text = "Por favor, ingrese un número válido de personas.";
        }
    }


}
