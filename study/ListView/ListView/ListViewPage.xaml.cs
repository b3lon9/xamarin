using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            // InitializeComponent();
            this.Padding = 15;

            StackLayout stackLayout = new StackLayout();

            string[] strs = new string[]
            {
                // 바로 초기화
                "c",
                "c++",
                "java",
                "android",
                "xamarin",
                "take",
                "spring",
                "python",
                "djangoframwork",
                "apache","c",
                "c++",
                "java",
                "android",
                "xamarin",
                "take",
                "spring",
                "python",
                "djangoframwork",
                "apache","c",
                "c++",
                "java",
                "android",
                "xamarin",
                "take",
                "spring",
                "python",
                "djangoframwork",
                "apache",
            };

            Xamarin.Forms.ListView listView = new Xamarin.Forms.ListView();
            listView.ItemsSource = strs;    //Property
            
            stackLayout.Children.Add(listView);
            this.Content = stackLayout;
        }
    }
}