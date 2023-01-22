using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pjt22
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StyleDynamicEx : ContentPage
    {
        bool isOriginalStyle = true;
        public StyleDynamicEx()
        {

            InitializeComponent();
            // Dictionary라고 생각하면 됨
            // 오른쪽에 있는 값을 searchBarStyle이라는 것에 할당을 해주는 것
            Resources["searchBarStyle"] = Resources["blueSearchBarStyle"];
        }

        private void onButtonClicked(object sender, EventArgs e)
        {
            var id = ((Button)sender).Id;

            if (isOriginalStyle == true)
            {
                Resources["searchBarStyle"] = Resources["greenSearchBarStyle"];
                isOriginalStyle = false;
            }
            else
            {
                Resources["searchBarStyle"] = Resources["blueSearchBarStyle"];
                isOriginalStyle = true; 
            }
        }
    }
}