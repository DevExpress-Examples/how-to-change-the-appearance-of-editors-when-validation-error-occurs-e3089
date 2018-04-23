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

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("SLCustomValidationErrorPresenter")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Microsoft")]
[assembly: AssemblyProduct("SLCustomValidationErrorPresenter")]
[assembly: AssemblyCopyright("Copyright © Microsoft 2011")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("ef01288f-490b-4d92-92fb-48984bcf9ea0")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
