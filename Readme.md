<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T355030)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ParameterLookUpWindowsFormsApplication/Form1.cs) (VB: [Form1.vb](./VB/ParameterLookUpWindowsFormsApplication/Form1.vb))
* [Program.cs](./CS/ParameterLookUpWindowsFormsApplication/Program.cs) (VB: [Program.vb](./VB/ParameterLookUpWindowsFormsApplication/Program.vb))
* [XtraReport1.cs](./CS/ParameterLookUpWindowsFormsApplication/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/ParameterLookUpWindowsFormsApplication/XtraReport1.vb))
<!-- default file list end -->
# How to assign multiple values to a report parameter


<p>This example demonstrates how to enable an end-user to assign multiple values to a report parameter in a Print Preview.<br>To do this, create an instance of the <strong>Parameter</strong> class and provide it with a set of lookup values. In this example, the parameter values are assigned in code. To learn how to obtain these values from a data source, see <a href="https://www.devexpress.com/Support/Center/p/T236094">How to assign multiple values to a report parameter from a connected data source</a>.<br><br>Set the parameter's <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraReportsParametersParameter_MultiValuetopic">MultiValue</a> property to true, which allows the parameter to have more than one value. After that, the parameter's values can be used in the report's <strong>FilterString</strong>. <br>When previewing the resulting report, an end-user will be prompted to specify values for the parameter using the drop-down multi-select list.</p>

<br/>


