using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowCurrentTimeEx02 : ContentPage
    {
        public ShowCurrentTimeEx02()
        {
            InitializeComponent();

            // Timer만들기 : 1초마다 갱신함
            Device.StartTimer(TimeSpan.FromSeconds(1), timer);

            // 데이터가 변경은 되었지만, View와 함수가 서로 물고 있기 때문에
            // 불편함
        }
        
        private bool timer()
        {
            label01.Text = $"{DateTime.Now}";
            label02.Text = $"The year is {DateTime.Now.Year}";
            label03.Text = $"The month is {DateTime.Now.Month}";
            label04.Text = $"The day is {DateTime.Now.Day}";
            label05.Text = $"The time is {DateTime.Now.TimeOfDay}";

            return true;
        }
    }
}