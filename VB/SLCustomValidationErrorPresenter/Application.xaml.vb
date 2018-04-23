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
	Partial Public Class App
		Inherits Application

		Public Sub New()
			AddHandler Me.Startup, AddressOf Application_Startup
			AddHandler Me.Exit, AddressOf Application_Exit
			AddHandler Me.UnhandledException, AddressOf Application_UnhandledException

			InitializeComponent()
		End Sub

		Private Sub Application_Startup(ByVal sender As Object, ByVal e As StartupEventArgs)
			Me.RootVisual = New MainPage()
		End Sub

		Private Sub Application_Exit(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Private Sub Application_UnhandledException(ByVal sender As Object, ByVal e As ApplicationUnhandledExceptionEventArgs)
			' If the app is running outside of the debugger then report the exception using
			' the browser's exception mechanism. On IE this will display it a yellow alert 
			' icon in the status bar and Firefox will display a script error.
			If (Not System.Diagnostics.Debugger.IsAttached) Then

				' NOTE: This will allow the application to continue running after an exception has been thrown
				' but not handled. 
				' For production applications this error handling should be replaced with something that will 
				' report the error to the website and stop the application.
				e.Handled = True
				Deployment.Current.Dispatcher.BeginInvoke(Function() AnonymousMethod1(e))
			End If
		End Sub
		
		Private Function AnonymousMethod1(ByVal e As ApplicationUnhandledExceptionEventArgs) As Boolean
			ReportErrorToDOM(e)
			Return True
		End Function

		Private Sub ReportErrorToDOM(ByVal e As ApplicationUnhandledExceptionEventArgs)
			Try
				Dim errorMsg As String = e.ExceptionObject.Message + e.ExceptionObject.StackTrace
				errorMsg = errorMsg.Replace(""""c, "'"c).Replace(Constants.vbCrLf, Constants.vbLf)

				System.Windows.Browser.HtmlPage.Window.Eval("throw new Error(""Unhandled Error in Silverlight Application " & errorMsg & """);")
			Catch e1 As Exception
			End Try
		End Sub
	End Class
End Namespace
