// Developer Express Code Central Example:
// How to change the appearance of editors when validation error occurs
// 
// This example shows a way to change the visual appearance of an editor in case of
// validation errors. By default, there is a small error icon, pointing out
// validation errors in the editor. The task is to remove this icon and show an
// additional border instead. This can be accomplished through the next three
// steps:
// 1. First, it is necessary to create a custom template for the editor and
// place a new border element there. In this example, a rectangle control named
// ErrorFrame used as an additional border.
// 2. Next, bind the rectangle's Stroke
// property to the ValidationError.ErrorType property of the editor.
// 3. Apply the
// new template to the editor.
// There are three new templates in the attached
// solution: the first one is for TextEdit, the second - for PasswordBoxEdit, and
// the third - for button-based controls (ComboBoxEdit, SpinEdit, PopupCalcEdit,
// LookUpEdit...) Inside each of these templates a rectangle named "ErrorFrame" is
// placed, which represents the additional border, and its Stroke property is bound
// to the ValidationError.ErrorType property of the control. Note that
// ValidationErrorTypeToBrushConverter is used in this binding. If ErrorType is set
// to None, the converter returns a transparent brush and the error frame is not
// visible.
// The described templates are applied to editors through a number of
// implicit styles for every DXEditor type. Both styles and all templates listed
// above are placed in the EditorsCustomTemplates resource dictionary.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3089

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
