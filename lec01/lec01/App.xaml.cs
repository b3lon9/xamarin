using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lec01
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // 처음 시작
            Debug.WriteLine("Debug --> OnStart");
        }

        protected override void OnSleep()
        {
            // 홈 버튼 누른 경우 : 백그라운드로 간 경우
            Debug.WriteLine("Debug --> OnSleep");
        }

        protected override void OnResume()
        {
            // 다시 앱에 진입한 경우
            Debug.WriteLine("Debug ->> OnResume");
        }
    }
}
