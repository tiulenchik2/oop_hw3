namespace hw3_1_maui
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            string input = NumberEntry.Text;

            if (int.TryParse(input, out int number)) {
                string message = $"Ви ввели число {number}";
                await DisplayAlert("Результат введення", message, "OK");
            }
            else
            {
                await DisplayAlert("Помилка", "Будь ласка, введіть коректне ціле число.", "Зрозуміло");
            }
        }
    }
}
