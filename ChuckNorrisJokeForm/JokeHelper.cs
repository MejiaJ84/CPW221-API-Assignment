using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuckNorrisJokeForm
{
    public static class JokeHelper
    {
        public static async Task<string> RandomChuckJoke()
        {
            Joke joke = await ChuckNorrisClient.GetRandomJoke();
            return joke.JokeText;
        }

        public static async Task<IEnumerable<string>> JokeCategories()
        {
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();
            return categories;
        }
    }
}
