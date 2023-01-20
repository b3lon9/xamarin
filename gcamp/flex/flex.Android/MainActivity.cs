using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Android.Util;

namespace flex.Droid
{
    [Activity(Label = "flex", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

            // 만약에 여기서 버튼을 눌러서 Toast메시지를 띄우고 싶다면?
            // 일단은 레이아웃을 작성하는것에 집중하자... Flex 마무리 짓고 천천히
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

      

        protected override void OnStart()
        {
            base.OnStart();
            System.Diagnostics.Debug.WriteLine("[debug] --> [OnStart]");
        }

        protected override void OnResume()
        {
            base.OnResume();
            System.Diagnostics.Debug.WriteLine("[debug] --> [OnResume]");
        }

        protected override void OnPause()
        {
            base.OnPause();
            System.Diagnostics.Debug.WriteLine("[debug] --> [OnPause]");
        }


        protected override void OnStop()
        {
            base.OnStop();
            System.Diagnostics.Debug.WriteLine("[debug] --> [OnStop]");
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            System.Diagnostics.Debug.WriteLine("[debug] --> [OnDestroy]");
        }
    }
}