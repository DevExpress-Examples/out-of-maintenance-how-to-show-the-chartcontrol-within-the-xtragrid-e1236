Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Layout
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo
Imports DevExpress.XtraLayout

Namespace S131084
	Partial Public Class Form1
		Inherits Form
		Private chart As ChartControl
		Private unboundData As Dictionary(Of Integer, Bitmap) = New Dictionary(Of Integer, Bitmap)()

		Public Sub New()
			InitializeComponent()
			InitializeChart()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
			Me.productsTableAdapter.Fill(Me.nwindDataSet.Products)
			' TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
			Me.categoriesTableAdapter.Fill(Me.nwindDataSet.Categories)
		End Sub

		Private Sub InitializeChart()
			chart = New ChartControl()
			Dim series1 As New Series("series1", ViewType.Bar)
			series1.ArgumentDataMember = "ProductName"
			series1.ValueDataMembers.AddRange(New String() { "UnitPrice" })
			series1.ShowInLegend = False
			Dim series2 As New Series("series2", ViewType.Point)
			series2.ArgumentDataMember = "ProductName"
			series2.ValueDataMembers.AddRange(New String() { "UnitPrice" })
			series2.ShowInLegend = False
			series2.Label.Visible = False
			chart.Series.AddRange(New Series() { series1, series2 })
			CType(chart.Diagram, XYDiagram).AxisX.Label.Angle = 20
		End Sub

		Private Sub layoutView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As CustomColumnDataEventArgs) Handles layoutView1.CustomUnboundColumnData
			If e.Column Is colProducts Then
				If e.IsGetData Then
					Dim categoryId As Integer = CInt(Fix(nwindDataSet.Categories(e.ListSourceRowIndex)("CategoryID")))
					Dim img As Bitmap = Nothing
					If unboundData.ContainsKey(categoryId) Then
						img = unboundData(categoryId)
					Else
						Dim dataView As DataView = nwindDataSet.Products.DefaultView
						dataView.RowFilter = String.Format("CategoryID = {0}", categoryId)
						For Each s As Series In chart.Series
							s.DataSource = dataView
						Next s
						chart.RefreshData()
						Dim view As LayoutView = CType(sender, LayoutView)
						Dim viewInfo As LayoutViewInfo = CType(view.GetViewInfo(), LayoutViewInfo)
						Dim chartSize As Size = Size.Empty
						For Each field As LayoutViewField In view.TemplateCard.Items
							If field.FieldName = "colProducts" Then
								chartSize = field.Size
								Exit For
							End If
						Next field
					chart.Size = chartSize
					img = New Bitmap(chartSize.Width, chartSize.Height)
					chart.DrawToBitmap(img, New Rectangle(Point.Empty, chartSize))
					unboundData.Add(categoryId, img)
					End If
					e.Value = img
				End If
			End If
		End Sub
	End Class
End Namespace