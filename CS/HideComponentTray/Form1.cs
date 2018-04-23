#region #References
using System;
using System.Windows.Forms;
using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.UserDesigner;
// ...
#endregion #References

namespace HideComponentTray {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

#region #ComponentVisibility
private void button1_Click(object sender, EventArgs e) {
    // Create an End-User Designer form.
    XRDesignForm designForm = new XRDesignForm();

    // Handle the DesignPanelLoaded event.
    designForm.DesignMdiController.DesignPanelLoaded +=
        new DesignerLoadedEventHandler(DesignMdiController_DesignPanelLoaded);

    // Load a report into the Designer.
    designForm.OpenReport(new XtraReport1());

    // Show the End-User Designer form, modally.
    designForm.ShowDialog();
}

// List the components in the Report Explorer, instead of the Component Tray.
void DesignMdiController_DesignPanelLoaded(object sender, DesignerLoadedEventArgs e) {
    ((XRDesignPanel)sender).ComponentVisibility = ComponentVisibility.ComponentTray;
}
#endregion #ComponentVisibility

    }
}
