Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraReports.UI
Imports System
Imports System.Windows.Forms
' ...

Namespace ParameterLookUpWindowsFormsApplication
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            ' Create a report instance.
            Dim report As New XtraReport1()

            ' Create a multi-value report parameter and specify its name.
            Dim parameter1 As New Parameter()
            parameter1.MultiValue = True
            parameter1.Name = "parameterCategory"

            ' Specify other parameter properties.
            parameter1.Type = GetType(System.Int32)
            parameter1.Visible = True
            parameter1.Description = "Category Name: "

            ' Populate the parameter's lookup editor with a set of values.
            parameter1.LookUpSettings = New StaticListLookUpSettings()
            CType(parameter1.LookUpSettings, StaticListLookUpSettings).LookUpValues.AddRange(New LookUpValue() { _
                New LookUpValue(1, "Beverages"), _
                New LookUpValue(2, "Condiments"), _
                New LookUpValue(3, "Confections") _
            })
            ' Assign the default values to the parameter.
            parameter1.Value = New Integer() { 1, 2 }

            ' Add the parameter to the report.
            report.Parameters.Add(parameter1)

            ' Specify the report's filter string.
            report.FilterString = "[CategoryID] In (?parameterCategory)"

            ' Load the report's Print Preview.
            Dim pt As New ReportPrintTool(report)
            pt.ShowPreviewDialog()
        End Sub
    End Class
End Namespace
