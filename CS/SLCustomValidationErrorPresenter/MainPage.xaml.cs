using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SLCustomValidationErrorPresenter {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            TextEdit.Focus();
        }

        private void textEdit_Validate(object sender, DevExpress.Xpf.Editors.ValidationEventArgs e) {
            if (e.Value != null) {
                decimal parameter = (e.Value is string) ? ((string)e.Value).Length : (decimal)e.Value;

                if (parameter > 3) {
                    e.IsValid = false;
                    e.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default;
                    if (parameter > 4)
                        e.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Information;
                    if (parameter > 5)
                        e.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
                    if (parameter > 6)
                        e.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
                }
            }
        }
    }
}
