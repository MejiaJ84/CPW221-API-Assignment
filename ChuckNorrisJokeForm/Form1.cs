using ChuckNorrisAPI;
namespace ChuckNorrisJokeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetJoke_Click(object sender, EventArgs e)
        {

            rTxtDisplayJoke.Text = await RandomChuckJoke();
        }
        private async Task<string> RandomChuckJoke()
        {
            Joke joke = await ChuckNorrisClient.GetRandomJoke();
            return joke.JokeText;
        }
    }
}