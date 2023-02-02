using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            InitializeComponent();
            // init();
        }

        private void init()
        {
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

        // 무슨 상황이던 터치를 하면 이벤트 발생
        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            string str = (string)e.Item;
            System.Diagnostics.Debug.WriteLine($"e.Item : {str}");
        }

        // 선택되지 않은 아이템을 클릭하면 이벤트 발생(새롭게)
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string str = (string)e.SelectedItem;
            System.Diagnostics.Debug.WriteLine($"e.Select :{str}");
        }
    }
}