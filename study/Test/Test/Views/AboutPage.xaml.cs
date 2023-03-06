using System;
using Xamarin.Forms;

namespace Test.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var id = ((Button)sender).Id;

            // 색상 통일 시켜줄 경우 필요한 로직
            // var btn = id == PlanButton.Id ? PlanButton : (id == IngButton.Id? IngButton : CompleteButton);

            if (PlanButton.Id == id)
            {
                if (PlanButton.BackgroundColor == Color.LightSkyBlue)
                {
                    ((Button)sender).BackgroundColor = Color.FromHex("#ececec");
                }
                else
                {
                    PlanButton.BackgroundColor = Color.LightSkyBlue;
                }
            }
            else if (IngButton.Id == id)
            {
                if (IngButton.BackgroundColor == Color.LightSkyBlue)
                {
                    ((Button)sender).BackgroundColor = Color.FromHex("#eed569");
                }
                else
                {
                    IngButton.BackgroundColor = Color.LightSkyBlue;
                }
            }
            else if (CompleteButton.Id == id)
            {
                if (CompleteButton.BackgroundColor == Color.LightSkyBlue)
                {
                    ((Button)sender).BackgroundColor = Color.FromHex("#82d280");
                }
                else
                {
                    CompleteButton.BackgroundColor = Color.LightSkyBlue;
                }
            }
            
        }
    }
}