Namespace Reporting_Create_Report_Parameter_with_Predefined_Static_Values
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim sqLiteConnectionParameters1 As New DevExpress.DataAccess.ConnectionParameters.SQLiteConnectionParameters()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table1 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column4 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column5 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column6 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column7 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column8 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression8 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column9 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression9 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column10 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression10 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column11 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression11 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column12 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression12 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column13 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression13 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column14 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression14 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' TopMargin
			' 
			Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.TopMargin.Name = "TopMargin"
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2, Me.xrLabel1})
			Me.Detail.HeightF = 28.125F
			Me.Detail.Name = "Detail"
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "nwind"
			sqLiteConnectionParameters1.FileName = "C:\Docs\CodeExamples\2021.1\Examples\XtraReports\Win\Reporting_Create-Report-Para" & "meter-with-Predefined-Static-Values\nwind.db"
			Me.sqlDataSource1.ConnectionParameters = sqLiteConnectionParameters1
			Me.sqlDataSource1.Name = "sqlDataSource1"
			columnExpression1.ColumnName = "OrderID"
			table1.Name = "Orders"
			columnExpression1.Table = table1
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "CustomerID"
			columnExpression2.Table = table1
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "EmployeeID"
			columnExpression3.Table = table1
			column3.Expression = columnExpression3
			columnExpression4.ColumnName = "OrderDate"
			columnExpression4.Table = table1
			column4.Expression = columnExpression4
			columnExpression5.ColumnName = "RequiredDate"
			columnExpression5.Table = table1
			column5.Expression = columnExpression5
			columnExpression6.ColumnName = "ShippedDate"
			columnExpression6.Table = table1
			column6.Expression = columnExpression6
			columnExpression7.ColumnName = "ShipVia"
			columnExpression7.Table = table1
			column7.Expression = columnExpression7
			columnExpression8.ColumnName = "Freight"
			columnExpression8.Table = table1
			column8.Expression = columnExpression8
			columnExpression9.ColumnName = "ShipName"
			columnExpression9.Table = table1
			column9.Expression = columnExpression9
			columnExpression10.ColumnName = "ShipAddress"
			columnExpression10.Table = table1
			column10.Expression = columnExpression10
			columnExpression11.ColumnName = "ShipCity"
			columnExpression11.Table = table1
			column11.Expression = columnExpression11
			columnExpression12.ColumnName = "ShipRegion"
			columnExpression12.Table = table1
			column12.Expression = columnExpression12
			columnExpression13.ColumnName = "ShipPostalCode"
			columnExpression13.Table = table1
			column13.Expression = columnExpression13
			columnExpression14.ColumnName = "ShipCountry"
			columnExpression14.Table = table1
			column14.Expression = columnExpression14
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Columns.Add(column4)
			selectQuery1.Columns.Add(column5)
			selectQuery1.Columns.Add(column6)
			selectQuery1.Columns.Add(column7)
			selectQuery1.Columns.Add(column8)
			selectQuery1.Columns.Add(column9)
			selectQuery1.Columns.Add(column10)
			selectQuery1.Columns.Add(column11)
			selectQuery1.Columns.Add(column12)
			selectQuery1.Columns.Add(column13)
			selectQuery1.Columns.Add(column14)
			selectQuery1.Name = "Orders"
			selectQuery1.Tables.Add(table1)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' xrLabel1
			' 
			Me.xrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CustomerID]")})
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel1.Multiline = True
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(325F, 28.125F)
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' xrTable1
			' 
			Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 75F)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.SizeF = New System.Drawing.SizeF(650F, 25F)
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Weight = 11.5R
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.Multiline = True
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.Text = "Customer ID"
			Me.xrTableCell1.Weight = 0.22222222222222221R
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.Multiline = True
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.Text = "Order Date"
			Me.xrTableCell2.Weight = 0.22222222222222221R
			' 
			' xrLabel2
			' 
			Me.xrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderDate]")})
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(325F, 0F)
			Me.xrLabel2.Multiline = True
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(325F, 28.125F)
			Me.xrLabel2.Text = "xrLabel2"
			Me.xrLabel2.TextFormatString = "{0:d}"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.TopMargin, Me.BottomMargin, Me.Detail})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.DataMember = "Orders"
			Me.DataSource = Me.sqlDataSource1
			Me.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.Version = "21.1"
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
