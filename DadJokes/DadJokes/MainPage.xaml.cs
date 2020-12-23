using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DadJokes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var jokeService = new DadJokeService();
            var joke = await jokeService.GetDadJoke();

            jokeLabel.Text = joke.joke;  //joke is stored in the joke property of this object
        }
    }
}
