using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lec07
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AbsoluteCSEx();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
