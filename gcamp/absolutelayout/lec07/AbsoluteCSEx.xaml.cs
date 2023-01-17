using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lec07
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsoluteCSEx : ContentPage
    {
        public AbsoluteCSEx()
        {
            // InitializeComponent();
            // xaml ui를 사용하지 않겠다는 의미인 것 같다
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();

            Label label01 = new Label();

            label01.Text = "Red";
            label01.BackgroundColor = new Color(255, 0, 0);

            // bindable
            AbsoluteLayout.SetLayoutBounds(label01, new Rectangle(100, 200, 100, 100));
            AbsoluteLayout.SetLayoutFlags(label01, AbsoluteLayoutFlags.None);

            absoluteLayout.Children.Add(label01);


            Label label02 = new Label();

            // 마지막 absoluteLayout을 어디다 붙여?
            // contentPage에 붙인다
            this.Content = absoluteLayout;
        }
    }
}