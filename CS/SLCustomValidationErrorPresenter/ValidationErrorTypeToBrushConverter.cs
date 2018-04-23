using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Data;
using DevExpress.XtraEditors.DXErrorProvider;

namespace SLCustomValidationErrorPresenter {
    public class ValidationErrorTypeToBrushConverter:IValueConverter {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            ErrorType errorType = (ErrorType)value;
            switch (errorType) {
                case ErrorType.None:
                    return new SolidColorBrush(Colors.Transparent);
                case ErrorType.Default:
                    return new SolidColorBrush(Colors.Gray);
                case ErrorType.Information:
                    return new SolidColorBrush(Colors.Blue);
                case ErrorType.Warning:
                    return new SolidColorBrush(Colors.Orange);
                case ErrorType.Critical:
                    return new SolidColorBrush(Colors.Red);
                default:
                    return new SolidColorBrush(Colors.Transparent);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
