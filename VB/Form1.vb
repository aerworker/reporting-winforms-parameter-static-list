Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraReports.UI
Imports System.Windows.Forms
Imports System

Namespace Reporting_Create_Report_Parameter_with_Predefined_Static_Values
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			' Create a report instance.
			Dim report As New XtraReport1()

			' Create a date-time parameter.
			Dim dateParameter As New Parameter()
			dateParameter.Name = "dateParameter"
			dateParameter.Description = "Date:"
			dateParameter.Type = GetType(Date)

			' Create a StaticListLookUpSettings instance and add predefined
			' static values to the instance's LookUpValues collection.
			Dim lookupSettings As New StaticListLookUpSettings()

			lookupSettings.LookUpValues.Add(New LookUpValue With {
				.Value = New Date(2014, 01, 01),
				.Description = "January 1, 2014"
			})

			lookupSettings.LookUpValues.Add(New LookUpValue With {
				.Value = New Date(2015, 02, 01),
				.Description = "February 1, 2015"
			})

			lookupSettings.LookUpValues.Add(New LookUpValue With {
				.Value = New Date(2016, 03, 01),
				.Description = "March 1, 2016"
			})

			' Assign the specified settings to the parameter's ValueSourceSettings property.
			dateParameter.ValueSourceSettings = lookupSettings

			' Add the parameter to the report's Parameters collection.
			report.Parameters.Add(dateParameter)

			' Use the created parameter to filter the report's data.
			report.FilterString = "GetDate([OrderDate]) >= ?dateParameter"
			report.ShowPreview()
		End Sub
	End Class
End Namespace
