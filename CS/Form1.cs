using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UserDesigner;
// ...

namespace HideComponentTray {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // Create an End-User Designer form.
            XRDesignFormEx designForm = new XRDesignFormEx();

            // Hide the component tray.
            designForm.DesignPanel.ShowComponentTray = false;
                        
            // Load a report into it.
            designForm.OpenReport(new XtraReport1());

            // Show the End-User Designer form, modally.
            designForm.ShowDialog();
        }
    }
}