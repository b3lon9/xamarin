using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace MVVM
{
    // Property에 변화가 생기면 알려주는 INotifyPropertyChanged
    public class CurrentTimeViewModel : INotifyPropertyChanged
    {
        DateTime dateTime;
        public event PropertyChangedEventHandler PropertyChanged;

        public CurrentTimeViewModel()
        {
            this.DateTime = DateTime.Now;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                // 1초마다 새로운 날짜 갱신
                this.DateTime = DateTime.Now;
                return true;
            });
        }

        public DateTime DateTime 
        { 
            get 
            { 
                return dateTime; 
            }
            set 
            {
                if (dateTime != value)
                {
                    dateTime = value;

                    if (PropertyChanged != null)
                    {
                        // 갱신되었다고 알려주는 부분
                        PropertyChanged(this, new PropertyChangedEventArgs("DateTime"));

                        // Notify를 듣는 것은 xaml에서 설정해주어야 함
                    }
                }
            } 
        }

    }
}
