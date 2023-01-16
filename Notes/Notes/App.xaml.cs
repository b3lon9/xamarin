// using Notes.Services;
using Notes.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notes
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            // DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();  // 시각적 계층구조를 정의한다...?
        }

        protected override void OnStart()
        {
            System.Diagnostics.Debug.WriteLine("[lifeCycle check] : [OnStart]");
        }

        protected override void OnSleep()
        {
            System.Diagnostics.Debug.WriteLine("[lifeCycle check] : [OnSleep]");
        }

        protected override void OnResume()
        {
            System.Diagnostics.Debug.WriteLine("[lifeCycle check] : [OnResume]");
        }
        public static string FolderPath = "";
    }
}
