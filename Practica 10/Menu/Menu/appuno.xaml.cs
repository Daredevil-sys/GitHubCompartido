namespace Menu;

public partial class appuno : ContentPage
{
	public appuno()
	{
		InitializeComponent();
	}


    private void OnMostrarParesClicked(object sender, EventArgs e)
    {
        var numerosPares = Enumerable.Range(0, 101)
                                     .Where(n => n % 2 == 0)
                                     .ToList();

        ResultadoLabel.Text = string.Join(", ", numerosPares);
    }
}