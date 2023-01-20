using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        private async void btn01_Clicked(object sender, EventArgs e)
        {
            var id = ((Button)sender).Id;

            if (id == btn01.Id)
            {
                // BackButton
                await Navigation.PopAsync();
            }
            else if(id == btn02.Id)
            {
                // Stack에 올리는 행위
                 await Navigation.PushAsync(new ThirdPage());
            }
        }
    }
}