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

            rTxtDisplayJoke.Text = await JokeHelper.RandomChuckJoke();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // in order for me to get this to work I had to add the explicit cast of object[]
            cbCategories.Items.AddRange((object[])await JokeHelper.JokeCategories());
        }
    }
}