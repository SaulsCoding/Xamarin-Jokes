using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DadJokes
{
    public class DadJokeService
    {

        public async Task<Joke> GetDadJoke()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept","application/json"); //telling our request what is gonna happen
            var myJoke = await client.GetStringAsync("https://icanhazdadjoke.com/"); //where we are getting it from - want to get a string from the internet

            Joke joke = JsonConvert.DeserializeObject<Joke>(myJoke); //change the string into an object
            return joke;
        }
    }
}
