#Region "#References"

Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.Design
Imports DevExpress.XtraReports.UserDesigner
' ...
#End Region ' "#References"

Namespace HideComponentTray
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

#Region "#ComponentVisibility"
Private Sub button1_Click(ByVal sender As Object, _ 
ByVal e As EventArgs) Handles button1.Click
	' Create an End-User Designer form.
	Dim designForm As New XRDesignForm()

	' Handle the DesignPanelLoaded event.
	AddHandler designForm.DesignMdiController.DesignPanelLoaded, _ 
	AddressOf DesignMdiController_DesignPanelLoaded

	' Load a report into the Designer.
	designForm.OpenReport(New XtraReport1())

	' Show the End-User Designer form, modally.
	designForm.ShowDialog()
End Sub

' List the components in the Report Explorer, instead of the Component Tray.
Private Sub DesignMdiController_DesignPanelLoaded(ByVal sender As Object, _ 
ByVal e As DesignerLoadedEventArgs)
	CType(sender, XRDesignPanel).ComponentVisibility = _ 
	ComponentVisibility.ComponentTray
End Sub
#End Region ' #ComponentVisibility

	End Class
End Namespace
