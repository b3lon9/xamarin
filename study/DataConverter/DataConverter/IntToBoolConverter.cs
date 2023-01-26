using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace DataConverter
{
    public class IntToBoolConverter : IValueConverter
    {
        // Text:string의 값을 보고 Button:bool(IsEnabled)값으로 바뀌도록
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // 소스에서 들어오는 값이 value
            // 텍스트의 길이가 들어올 것이기 때문에 (int)value
            // 텍스트의 길이가 1이상이면 'true'가 반환되도록
            // return은 target이 받음
            return (int)value != 0;
        }


        // 그냥 Convert의 반대개념
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // true면 1 반환
            // false면 0 반환
            return (bool)value ? 1 : 0;
        }
    }
}
