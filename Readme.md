# How to assign multiple values to a report parameter


<p>This example demonstrates how to enable an end-user to assign multiple values to a report parameter in a Print Preview.<br>To do this, create an instance of the <strong>Parameter</strong> class and provide it with a set of lookup values. In this example, the parameter values are assigned in code. To learn how to obtain these values from a data source, see <a href="https://www.devexpress.com/Support/Center/p/T236094">How to assign multiple values to a report parameter from a connected data source</a>.<br><br>Set the parameter's <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraReportsParametersParameter_MultiValuetopic">MultiValue</a> property to true, which allows the parameter to have more than one value. After that, the parameter's values can be used in the report's <strong>FilterString</strong>. <br>When previewing the resulting report, an end-user will be prompted to specify values for the parameter using the drop-down multi-select list.</p>

<br/>


