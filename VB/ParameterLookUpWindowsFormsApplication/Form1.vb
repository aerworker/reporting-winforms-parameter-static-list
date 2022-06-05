Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraReports.UI
Imports System
Imports System.Windows.Forms

' ...
Namespace ParameterLookUpWindowsFormsApplication

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Create a report instance.
            Dim report As XtraReport1 = New XtraReport1()
            ' Create a multi-value parameter and specify its name.
            Dim parameter1 As Parameter = New Parameter()
            parameter1.MultiValue = True
            parameter1.Name = "parameterCategory"
            ' Specify other parameter properties.
            parameter1.Type = GetType(Integer)
            parameter1.Visible = True
            parameter1.Description = "Category Name: "
            ' Populate the parameter's lookup editor with a set of values.
            parameter1.LookUpSettings = New StaticListLookUpSettings()
            CType(parameter1.LookUpSettings, StaticListLookUpSettings).LookUpValues.AddRange(New LookUpValue() {New LookUpValue(1, "Beverages"), New LookUpValue(2, "Confections"), New LookUpValue(3, "Grains/Cereals")})
            ' Assign the default values to the parameter.
            parameter1.Value = New Integer() {1, 2}
            ' Add the parameter to the report.
            report.Parameters.Add(parameter1)
            ' Specify the report's filter string.
            report.FilterString = "[CategoryID] In (?parameterCategory)"
            ' Load the report's Print Preview.
            Dim pt As ReportPrintTool = New ReportPrintTool(report)
            pt.ShowPreviewDialog()
        End Sub
    End Class
End Namespace
