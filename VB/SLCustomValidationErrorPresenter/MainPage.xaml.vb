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
