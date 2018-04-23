' Developer Express Code Central Example:
' How to change the appearance of editors when validation error occurs
' 
' This example shows a way to change the visual appearance of an editor in case of
' validation errors. By default, there is a small error icon, pointing out
' validation errors in the editor. The task is to remove this icon and show an
' additional border instead. This can be accomplished through the next three
' steps:
' 1. First, it is necessary to create a custom template for the editor and
' place a new border element there. In this example, a rectangle control named
' ErrorFrame used as an additional border.
' 2. Next, bind the rectangle's Stroke
' property to the ValidationError.ErrorType property of the editor.
' 3. Apply the
' new template to the editor.
' There are three new templates in the attached
' solution: the first one is for TextEdit, the second - for PasswordBoxEdit, and
' the third - for button-based controls (ComboBoxEdit, SpinEdit, PopupCalcEdit,
' LookUpEdit...) Inside each of these templates a rectangle named "ErrorFrame" is
' placed, which represents the additional border, and its Stroke property is bound
' to the ValidationError.ErrorType property of the control. Note that
' ValidationErrorTypeToBrushConverter is used in this binding. If ErrorType is set
' to None, the converter returns a transparent brush and the error frame is not
' visible.
' The described templates are applied to editors through a number of
' implicit styles for every DXEditor type. Both styles and all templates listed
' above are placed in the EditorsCustomTemplates resource dictionary.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3089


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
