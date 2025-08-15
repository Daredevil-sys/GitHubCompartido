namespace cuentaregresiva3196376
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            for (int i = 10; i >= 1; i--)
            {
                ContadorLabel.Text = i.ToString();
                await Task.Delay(1000); // Espera 1 segundo
            }
            ContadorLabel.Text = "¡Listo!";
        }
    }
}
