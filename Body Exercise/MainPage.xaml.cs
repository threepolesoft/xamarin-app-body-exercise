using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Body_Exercise
{

    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            Title = "Welcome to Body Exercise";
        }

        private async void btn_ex_one(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new ex_one("three"));
        }

        private async void btn_ex_two(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ex_one("two"));
        }

        private async void btn_ex_three(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ex_one("one"));
        }

        private async void btn_ex_four(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ex_one("four"));
        }
    }
}
