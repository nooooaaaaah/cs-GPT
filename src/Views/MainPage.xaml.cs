using Microsoft.Maui.Controls;
// using Clippy.Interfaces;
namespace Clippy.Views
{
    public partial class MainPage : ContentPage
    {
        private int count = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            CounterLabel.Text = $"Current count: {count}";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }
        private void OnChatViewClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChatPage());
        }
    }
}
