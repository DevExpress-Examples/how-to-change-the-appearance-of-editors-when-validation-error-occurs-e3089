<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/SLCustomValidationErrorPresenter/MainPage.xaml) (VB: [MainPage.xaml.vb](./VB/SLCustomValidationErrorPresenter/MainPage.xaml.vb))
* [MainPage.xaml.cs](./CS/SLCustomValidationErrorPresenter/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/SLCustomValidationErrorPresenter/MainPage.xaml.vb))
* [EditorsCustomTemplates.xaml](./CS/SLCustomValidationErrorPresenter/Themes/EditorsCustomTemplates.xaml) (VB: [EditorsCustomTemplates.xaml](./VB/SLCustomValidationErrorPresenter/Themes/EditorsCustomTemplates.xaml))
* [ValidationErrorTypeToBrushConverter.cs](./CS/SLCustomValidationErrorPresenter/ValidationErrorTypeToBrushConverter.cs) (VB: [ValidationErrorTypeToBrushConverter.vb](./VB/SLCustomValidationErrorPresenter/ValidationErrorTypeToBrushConverter.vb))
<!-- default file list end -->
# How to change the appearance of editors when validation error occurs


<p>This example shows a way to change the visual appearance of an editor in case of validation errors. By default, there is a small error icon, pointing out validation errors in the editor. The task is to remove this icon and show an additional border instead. This can be accomplished through the next three steps:</p><p>1. First, it is necessary to create a custom template for the editor and place a new border element there. In this example, a rectangle control named <strong>ErrorFrame</strong> used as an additional border.<br />
2. Next, bind the rectangle's Stroke property to the <strong>ValidationError.ErrorType</strong> property of the editor.<br />
3. Apply the new template to the editor.</p><p>There are three new templates in the attached solution: the first one is for TextEdit, the second - for PasswordBoxEdit, and the third - for button-based controls (ComboBoxEdit, SpinEdit, PopupCalcEdit, LookUpEdit...) Inside each of these templates a rectangle named "ErrorFrame" is placed, which represents the additional border, and its Stroke property is bound to the ValidationError.ErrorType property of the control. Note that <strong>ValidationErrorTypeToBrushConverter</strong> is used in this binding. If ErrorType is set to None, the converter returns a transparent brush and the error frame is not visible.<br />
The described templates are applied to editors through a number of implicit styles for every DXEditor type. Both styles and all templates listed above are placed in the <strong>EditorsCustomTemplates</strong> resource dictionary.</p>

<br/>


