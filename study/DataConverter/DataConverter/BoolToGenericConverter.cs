using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace DataConverter
{
    // object
    public class BoolToGenericConverter<T> : IValueConverter
    {
        // T뭔지 몰라
        // 사용자가 무엇을 원하는지 모르지만 Generic : T로 넘겨주어 확인
        public T TrueObject { get;  set; }
        public T FalseObject { get;  set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool) value ? TrueObject : FalseObject;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((T)value).Equals(TrueObject);
        }
    }
}
