using System.Windows;
using System.Windows.Data;
using System.Globalization;

namespace SerialPortAssistant.Convert
{
    public class SerialPortSwitchBtnStyleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString() == "打开串口")
            { 
                return Application.Current.Resources["ButtonPrimary"] as Style;
            }
            return Application.Current.Resources["ButtonDanger"] as Style;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
