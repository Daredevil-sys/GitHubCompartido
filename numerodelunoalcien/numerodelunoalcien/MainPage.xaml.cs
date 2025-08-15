namespace numerodelunoalcien
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
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
}