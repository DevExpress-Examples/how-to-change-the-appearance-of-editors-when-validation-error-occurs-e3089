Imports Microsoft.VisualBasic
Imports System
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports System.Windows.Data
Imports DevExpress.XtraEditors.DXErrorProvider

Namespace SLCustomValidationErrorPresenter
	Public Class ValidationErrorTypeToBrushConverter
		Implements IValueConverter

		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			Dim errorType As ErrorType = CType(value, ErrorType)
			Select Case errorType
				Case ErrorType.None
					Return New SolidColorBrush(Colors.Transparent)
				Case ErrorType.Default
					Return New SolidColorBrush(Colors.Gray)
				Case ErrorType.Information
					Return New SolidColorBrush(Colors.Blue)
				Case ErrorType.Warning
					Return New SolidColorBrush(Colors.Orange)
				Case ErrorType.Critical
					Return New SolidColorBrush(Colors.Red)
				Case Else
					Return New SolidColorBrush(Colors.Transparent)
			End Select
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function
	End Class
End Namespace
