using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using System;
using System.IO;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;

namespace Reporting_Create_Report_Parameter_with_Predefined_Static_Values {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void configureDataSource(ref XtraReport1 report) {
            var dataSource = new SqlDataSource("nwind");

            var ordersQuery = new CustomSqlQuery();
            ordersQuery.Name = "Orders";
            ordersQuery.Sql = "SELECT * FROM Orders";

            dataSource.Queries.Add(ordersQuery);

            report.DataSource = dataSource;
            report.DataMember = "Orders";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a date-time parameter.
            Parameter dateParameter = new Parameter();
            dateParameter.Name = "dateParameter";
            dateParameter.Description = "Date:";
            dateParameter.Type = typeof(System.DateTime);

            // Create a StaticListLookUpSettings instance and add predefined
            // static values to the instance's LookUpValues collection.
            StaticListLookUpSettings lookupSettings = new StaticListLookUpSettings();

            lookupSettings.LookUpValues.Add(new LookUpValue
            {
                Value = new DateTime(2014, 01, 01),
                Description = "January 1, 2014"
            }
            );

            lookupSettings.LookUpValues.Add(new LookUpValue
            {
                Value = new DateTime(2015, 02, 01),
                Description = "February 1, 2015"
            }
            );

            lookupSettings.LookUpValues.Add(new LookUpValue
            {
                Value = new DateTime(2016, 03, 01),
                Description = "March 1, 2016"
            }
            );

            // Assign the specified settings to the parameter's ValueSourceSettings property.
            dateParameter.ValueSourceSettings = lookupSettings;

            // Create a report instance and add the parameter
            // to the report's Parameters collection.
            XtraReport1 report = new XtraReport1();
            report.Parameters.Add(dateParameter);

            // Use the created parameter to filter the report's data.
            report.FilterString = "GetDate([OrderDate]) >= ?dateParameter";
            configureDataSource(ref report);
            report.ShowPreview();
        }
    }
}
