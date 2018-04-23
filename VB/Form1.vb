Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UserDesigner
' ...

Namespace HideComponentTray
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			' Create an End-User Designer form.
			Dim designForm As New XRDesignFormEx()

			' Hide the component tray.
			designForm.DesignPanel.ShowComponentTray = False

			' Load a report into it.
			designForm.OpenReport(New XtraReport1())

			' Show the End-User Designer form, modally.
			designForm.ShowDialog()
		End Sub
	End Class
End Namespace