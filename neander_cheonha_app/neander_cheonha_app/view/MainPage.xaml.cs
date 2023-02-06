using neander_cheonha_app.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace neander_cheonha_app
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ChangePage()
        {
            System.Diagnostics.Debug.WriteLine($"[debug:{this}] ChangePage()");
            Application.Current.MainPage = new LoginPage();
        }

        private void BtnLoginPage_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"[debug:{this}] BtnLoginPage_Clicked()");
            Application.Current.MainPage = new LoginPage();
        }
    }
}
