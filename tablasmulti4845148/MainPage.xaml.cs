namespace tablasmulti4845148
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MostrarTablas();
        }

        private void MostrarTablas()
        {
            for (int i = 1; i <= 10; i++)
            {
                var titulo = new Label
                {
                    Text = $"Tabla del {i}",
                    FontAttributes = FontAttributes.Bold,
                    FontSize = 20
                };

                TablasLayout.Children.Add(titulo);

                for (int j = 1; j <= 10; j++)
                {
                    var resultado = new Label
                    {
                        Text = $"{i} x {j} = {i * j}"
                    };
                    TablasLayout.Children.Add(resultado);
                }

                TablasLayout.Children.Add(new BoxView
                {
                    HeightRequest = 2,
                    Color = Colors.Gray
                });
            }
        }
    }

}
