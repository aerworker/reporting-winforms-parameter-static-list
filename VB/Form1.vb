#Region "usings"
Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraReports.UI
Imports System.Windows.Forms
Imports System
#End Region
Imports System.IO
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql

Namespace Reporting_Create_Report_Parameter_with_Predefined_Static_Values
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub configureDataSource(ByRef report As XtraReport1)
			Dim dataSource = New SqlDataSource("nwind")

			Dim ordersQuery = New CustomSqlQuery()
			ordersQuery.Name = "Orders"
			ordersQuery.Sql = "SELECT * FROM Orders"

			dataSource.Queries.Add(ordersQuery)

			report.DataSource = dataSource
			report.DataMember = "Orders"
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
#Region "dateParameterWithStaticValuesExample"
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

			' Create a report instance and add the parameter
			' to the report's Parameters collection.
			Dim report As New XtraReport1()
			report.Parameters.Add(dateParameter)

			' Use the created parameter to filter the report's data.
			report.FilterString = "GetDate([OrderDate]) >= ?dateParameter"
#End Region
			configureDataSource(report)
			report.ShowPreview()
		End Sub
	End Class
End Namespace
