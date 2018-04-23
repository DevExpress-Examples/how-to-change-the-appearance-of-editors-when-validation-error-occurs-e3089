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
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes

Namespace SLCustomValidationErrorPresenter
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			TextEdit.Focus()
		End Sub

		Private Sub textEdit_Validate(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.ValidationEventArgs)
			If e.Value IsNot Nothing Then
				Dim parameter As Decimal = If((TypeOf e.Value Is String), (CStr(e.Value)).Length, CDec(e.Value))

				If parameter > 3 Then
					e.IsValid = False
					e.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default
					If parameter > 4 Then
						e.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Information
					End If
					If parameter > 5 Then
						e.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
					End If
					If parameter > 6 Then
						e.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical
					End If
				End If
			End If
		End Sub
	End Class
End Namespace
