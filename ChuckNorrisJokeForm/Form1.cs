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
            if(cbCategories.SelectedIndex == -1)
            {
                rTxtDisplayJoke.Text = await JokeHelper.RandomChuckJoke();
            }
            else
            {
                Joke joke = await ChuckNorrisClient.GetJokeFromCategory(cbCategories.SelectedItem.ToString());
                rTxtDisplayJoke.Text = joke.JokeText;
            }
            
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // in order for me to get this to work I had to add the explicit cast of object[]
            cbCategories.Items.AddRange((object[])await JokeHelper.JokeCategories());
        }
    }
}