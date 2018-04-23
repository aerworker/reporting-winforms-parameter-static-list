using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;
// ...

namespace ParameterLookUpWindowsFormsApplication {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // Create a report instance.
            XtraReport1 report = new XtraReport1();

            // Create a multi-value parameter and specify its name.
            Parameter parameter1 = new Parameter();
            parameter1.MultiValue = true;
            parameter1.Name = "parameterCategory";

            // Specify other parameter properties.
            parameter1.Type = typeof(System.Int32);
            parameter1.Visible = true;
            parameter1.Description = "Category Name: ";
            
            // Populate the parameter's lookup editor with a set of values.
            parameter1.LookUpSettings = new StaticListLookUpSettings();
            ((StaticListLookUpSettings)parameter1.LookUpSettings).LookUpValues.AddRange(new LookUpValue[] {
new LookUpValue(1, "Beverages"), 
new LookUpValue(2, "Confections"), 
new LookUpValue(3, "Grains/Cereals")
});
            // Assign the default values to the parameter.
            parameter1.Value = new int[] { 1, 2 };

            // Add the parameter to the report.
            report.Parameters.Add(parameter1);

            // Specify the report's filter string.
            report.FilterString = "[CategoryID] In (?parameterCategory)";

            // Load the report's Print Preview.
            ReportPrintTool pt = new ReportPrintTool(report);
            pt.ShowPreviewDialog();
        }
    }
}
