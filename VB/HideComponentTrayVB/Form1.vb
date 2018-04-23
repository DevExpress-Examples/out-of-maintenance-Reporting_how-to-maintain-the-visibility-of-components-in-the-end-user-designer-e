Imports System
Imports System.Windows.Forms
Imports System.Drawing.Design
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner
' ...

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Create an End-User Designer form.
        Dim designForm As New XRDesignForm()

        ' Handle the DesignPanelLoaded event.
        AddHandler designForm.DesignMdiController.DesignPanelLoaded, AddressOf DesignMdiController_DesignPanelLoaded

        ' Load a report into the Designer.
        designForm.OpenReport(New XtraReport1())

        ' Show the End-User Designer form, modally.
        designForm.ShowDialog()
    End Sub

    Private Sub DesignMdiController_DesignPanelLoaded(ByVal sender As Object, ByVal e As DesignerLoadedEventArgs)
        ' Hide the Component Tray from the Design Panel.
        CType(sender, XRDesignPanel).ShowComponentTray = False
    End Sub
End Class
