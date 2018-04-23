Namespace ParameterLookUpWindowsFormsApplication
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
            Dim tableQuery1 As New DevExpress.DataAccess.Sql.TableQuery()
            Dim tableInfo1 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo1 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo2 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo3 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo4 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox1, Me.xrLabel3, Me.xrLabel1})
            Me.Detail.HeightF = 91.66666F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "nwind"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            tableQuery1.Name = "Categories"
            tableInfo1.Name = "Categories"
            columnInfo1.Name = "CategoryID"
            columnInfo2.Name = "CategoryName"
            columnInfo3.Name = "Description"
            columnInfo4.Name = "Picture"
            tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo1, columnInfo2, columnInfo3, columnInfo4})
            tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo1})
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName")})
            Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(23.95833F, 10.75001F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(352.7083F, 23F)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.Text = "xrLabel1"
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description")})
            Me.xrLabel3.Font = New System.Drawing.Font("Tahoma", 9.75F)
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(23.95833F, 48.91666F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(352.7083F, 23F)
            Me.xrLabel3.StylePriority.UseFont = False
            Me.xrLabel3.Text = "xrLabel3"
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture")})
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(507.2917F, 10.75001F)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(119.7917F, 61.16665F)
            Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
            Me.DataMember = "Categories"
            Me.DataSource = Me.sqlDataSource1
            Me.Version = "15.2"
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    End Class
End Namespace
