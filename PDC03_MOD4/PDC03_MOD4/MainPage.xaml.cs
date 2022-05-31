using PDC03_MOD04;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC03_MOD4
{

    public partial class MainPage : ContentPage
    {

 
        public MainPage()
        {

            InitializeComponent();
        }

        private async void Activity01(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new activity1());

        }

        private async void Activity02(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new activityy02());

        }

        private async void Activity03(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new activity3());

        }

    }

}