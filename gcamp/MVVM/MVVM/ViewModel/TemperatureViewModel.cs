using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM.ViewModel
{
    public class TemperatureViewModel : INotifyPropertyChanged
    {
        double dev01Temp, dev02Temp;
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand IncreaseCommandForDev01Temp { get; private set; }
        public ICommand DecreaseCommandForDev01Temp { get; private set; }
        public ICommand IncreaseCommandForDev02Temp { get; private set; }
        public ICommand DecreaseCommandForDev02Temp { get; private set; }

        // 객체생성시 ICommand객체 초기화
        public TemperatureViewModel()
        {
            // Device #1
            IncreaseCommandForDev01Temp = new Command(
                // 람다함수 앞에 명시를 해주어도 됨 execute해도 되고, 안해도되고
                execute:() =>
                {
                    // 실행
                    Dev01Temp += 1;
                },
                () =>
                {
                    // 더이상 온도를 못올리게 하는 비활성화 하는 함수
                    if (Dev01Temp >= 45)
                    {
                        return false;
                    } 
                    else
                    {
                        return true;
                    }
                }
                );

            DecreaseCommandForDev01Temp = new Command(
                execute: () =>
                {
                    // 실행
                    Dev01Temp -= 1;
                },
                () =>
                {
                    if (Dev01Temp <= 25)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                );

            // Device #2 
            IncreaseCommandForDev02Temp = new Command(
                // 람다함수 앞에 명시를 해주어도 됨 execute해도 되고, 안해도되고
                execute: () =>
                {
                    // 실행
                    Dev02Temp += 1;
                },
                () =>
                {
                    // 더이상 온도를 못올리게 하는 비활성화 하는 함수
                    if (Dev02Temp >= 45)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                );

            DecreaseCommandForDev02Temp = new Command(
                execute: () =>
                {
                    // 실행
                    Dev02Temp -= 1;
                },
                () =>
                {
                    if (Dev02Temp <= 25)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                );

            Dev01Temp = 30;
            Dev02Temp = 30;
        }

        // property setting
        public double Dev01Temp
        {
            get
            {
                return dev01Temp;
            }

            set
            {
                if (dev01Temp != value)
                {
                    dev01Temp = value;
                    OnPropertyChanged("Dev01Temp");

                    // 버튼 활성화/비활성화
                    ((Command)IncreaseCommandForDev01Temp).ChangeCanExecute();
                    ((Command)DecreaseCommandForDev01Temp).ChangeCanExecute();
                }
            }
        }

        public double Dev02Temp
        {
            get
            {
                return dev02Temp;
            }

            set
            {
                if (dev02Temp != value)
                {
                    dev02Temp = value;
                    OnPropertyChanged("Dev02Temp");

                    ((Command)IncreaseCommandForDev02Temp).ChangeCanExecute();
                    ((Command)DecreaseCommandForDev02Temp).ChangeCanExecute();
                }
            }
        }

        private void OnPropertyChanged(string propertyName) 
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
