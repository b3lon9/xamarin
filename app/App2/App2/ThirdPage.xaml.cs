using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
        }

        private async void btn01_Clicked(object sender, EventArgs e)
        {
            // sender casting
            var id = ((Button)sender).Id;

            if (id == btn01.Id)
            {
                await Navigation.PopAsync();
            }
            else if (id == btn02.Id)
            {
                await Navigation.PopToRootAsync();
            }
        }
    }
}