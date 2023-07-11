using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Body_Exercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ex_one : ContentPage
    {
        public string ex_num;
        public ex_one(string e)
        {
            this.ex_num = e;
           
            InitializeComponent();
            ex_ani.Source = ex_num + ".gif";

        }


        private void btn_ex_start(object o, EventArgs e)
        {
            ex_ani.IsAnimationPlaying = true;
        }


        private void btn_ex_stop(object o, EventArgs e)
        {
            ex_ani.IsAnimationPlaying = false;
        }
    }


}