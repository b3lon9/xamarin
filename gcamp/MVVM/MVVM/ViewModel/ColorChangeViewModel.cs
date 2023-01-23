using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace MVVM.ViewModel
{
    public class ColorChangeViewModel : INotifyPropertyChanged
    {
        // 색상, 채도, 밝기, 투명도
        double hue, saturation, luminosity, alpha;

        Color currentColor;

        // PropertyChanged 로 BroadCast Event를 발생(데이터 변화시)
        public event PropertyChangedEventHandler PropertyChanged;

        public double Hue
        {
            get
            {
                return hue;
            }
            set
            {
                if (hue != value)
                {
                    hue = value;

                    // 변경된 것을 PropertyChanged 이벤트를 통해 알림
                    OnPropertyChanged("Hue");
                    SetNewColor();
                }
            }
        }

        public double Saturation
        {
            get { return saturation; }
            set 
            {
                saturation = value;
                OnPropertyChanged("saturation");
                SetNewColor();
            }
        }

        public double Luminosity
        {
            get { return luminosity; }
            set 
            {
                luminosity = value;
                OnPropertyChanged("luminosity");
                SetNewColor();
            }
        }

        public double Alpha
        {
            get { return alpha; }
            set 
            {
                alpha = value;
                OnPropertyChanged("alpha");
                SetNewColor();
            }
        }

        public Color CurrentColor
        {
            get
            {
                return currentColor;
            }

            set
            {
                // 변화가 되었을 경우 
                if (currentColor != value)
                {
                    // 같지 않다면 업데이트 할 것이다
                    currentColor = value;
                    OnPropertyChanged("CurrentColor");

                    Hue = value.Hue;
                    Saturation = value.Saturation;
                    Luminosity = value.Luminosity;
                    Alpha = value.A;
                    Debug.WriteLine("============");
                    Debug.WriteLine("Color : " +  currentColor);
                    Debug.WriteLine($"Hue : {Hue}\nSaturation : {Saturation}\n" +
                        $"Luminosity : {Luminosity}\nAlpha : {Alpha}");
                }
            }
        }

        // 이벤트를 공동으로 사용하기 때문에 함수로 사용
        protected virtual void OnPropertyChanged(string propertyName)
        {
            // Property가 바뀌는 경우 발생
            if (PropertyChanged != null)
            {
                // 매개변수로 이름 전달
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        // 색상 객체 지정
        void SetNewColor()
        {
            // currentColor를 업데이트함
            CurrentColor = Color.FromHsla(Hue, Saturation, Luminosity, Alpha);

        }
    }


}
