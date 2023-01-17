using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace relative
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RelativeEx : ContentPage
    {
        public RelativeEx()
        {
            //InitializeComponent();    // initalizeComponent가 선언되지 않으면 xaml파일이 그려지지 않음

            RelativeLayout relativeLayout = new RelativeLayout();

            Label label01 = new Label();
            label01.Text = "Wrap";
            label01.BackgroundColor = Color.FromHex("cccccc");
            relativeLayout.Children.Add(
                label01,
                Constraint.RelativeToParent((parent) => { return parent.Width * 0; }),
                Constraint.RelativeToParent((parent) => { return parent.Height * 0; }),
                Constraint.RelativeToParent((parent) => { return parent.Width * 1; }),
                Constraint.RelativeToParent((parent) => { return parent.Height * .8; })
                );

            Label label02 = new Label ();
            label02.Text = "Wrap";
            label02.BackgroundColor = Color.FromHex("ff0000");
            relativeLayout.Children.Add(
                label02,
                Constraint.RelativeToParent(parent => { return parent.Width * .2; }),
                Constraint.RelativeToParent(parent => { return parent.Height * .5; }),
                Constraint.RelativeToView(label01, (parent, child) => { return child.Width * .5; }),
                Constraint.RelativeToView(label01, (parent, child) => { return child.Height * .5; })
                );

            this.Content = relativeLayout;
        }
    }
}