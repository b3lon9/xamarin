using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lec01
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyContentsView : ContentView
	{
		public MyContentsView ()
		{
			InitializeComponent ();		// xaml 파일에 컴포넌트(뷰)들을 메모리에 생성 및 탑재함

			// 생성이 끝나면 접근이 가능하다

			pName.Text = "";
			pMajor.Text = "";
			pNation.Text = "";
			pGender.Text = "";
			pAge.Text = "";
		}

		public string Name
		{
			get { return pName.Text; }	
			set { pName.Text = value; }	
		}

		public string Major
		{
			get { return pMajor.Text; } 
			set=> pMajor.Text = value;
		}

		public string Nation
		{
			get { return pNation.Text;}
			set
			{
				pNation.Text = value;	
			}
		}
		
		public string Gender
		{
			get { return pGender.Text; }	
			set { pGender.Text = value; }
		}

		public string Age
		{
			get { return pAge.Text; }
			set { pAge.Text = value; }
		}
	}
}