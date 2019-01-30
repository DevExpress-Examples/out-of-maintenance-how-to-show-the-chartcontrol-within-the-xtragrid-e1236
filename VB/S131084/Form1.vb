Imports DevExpress.XtraCharts
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Layout
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Namespace S131084
    Partial Public Class Form1
        Inherits Form

        Private chart As ChartControl
        Private dataSet As DataSet
        Private unboundData As New Dictionary(Of Integer, Bitmap)()

        Public Sub New()
            InitializeComponent()
            InitializeChart()
            InitializeSource()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            productsBindingSource.DataSource = dataSet.Tables("Products")
            personsBindingSource.DataSource = dataSet.Tables("Persons")
        End Sub

        Private Function GetProductsDataTable() As DataTable
            Dim table As New DataTable()
            table.TableName = "Products"
            table.Columns.Add(New DataColumn("ProductName", GetType(String)))
            table.Columns.Add(New DataColumn("UnitPrice", GetType(Double)))
            table.Columns.Add(New DataColumn("ID", GetType(Integer)))
            For i As Integer = 0 To 999
                table.Rows.Add("Product " & i, 3000 + i * 298.55D, i Mod 200)
            Next i
            Return table
        End Function
        Private Function GetPersonDataTable() As DataTable
            Dim table As New DataTable()
            table.TableName = "Persons"
            table.Columns.Add(New DataColumn("FirstName", GetType(String)))
            table.Columns.Add(New DataColumn("SecondName", GetType(String)))
            table.Columns.Add(New DataColumn("Image", GetType(Image)))
            table.Columns.Add(New DataColumn("ID", GetType(Integer)))
            For i As Integer = 0 To 199
                table.Rows.Add("FirstName " & i, "SecondName " & i, My.Resources.picture_post_card, i)
            Next i
            Return table
        End Function

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
        Private Sub InitializeSource()
            dataSet = New DataSet()
            dataSet.Tables.Add(GetProductsDataTable())
            dataSet.Tables.Add(GetPersonDataTable())
            Dim keyColumn As DataColumn = dataSet.Tables("Persons").Columns("ID")
            Dim foreignKeyColumn As DataColumn = dataSet.Tables("Products").Columns("ID")
            dataSet.Relations.Add("PersonsProducts", keyColumn, foreignKeyColumn)
        End Sub

        Private Sub layoutView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As CustomColumnDataEventArgs) Handles layoutView1.CustomUnboundColumnData
            If e.Column Is colProducts Then
                If e.IsGetData Then
                    Dim personId As Integer = CInt((dataSet.Tables("Persons").Rows(e.ListSourceRowIndex)("ID")))
                    Dim img As Bitmap = Nothing
                    If unboundData.ContainsKey(personId) Then
                        img = unboundData(personId)
                    Else
                        Dim dataView As DataView = dataSet.Tables("Products").DefaultView
                        dataView.RowFilter = String.Format("ID = {0}", personId)
                        For Each s As Series In chart.Series
                            s.DataSource = dataView
                        Next s
                        chart.RefreshData()
                        Dim view As LayoutView = DirectCast(sender, LayoutView)
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
                        unboundData.Add(personId, img)
                    End If
                    e.Value = img
                End If
            End If
        End Sub
    End Class
End Namespace