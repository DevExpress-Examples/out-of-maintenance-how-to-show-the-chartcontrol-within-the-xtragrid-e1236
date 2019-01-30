using DevExpress.XtraCharts;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid.Views.Layout.ViewInfo;
using S131084.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace S131084
{
    public partial class Form1 : Form
    {
        private ChartControl chart;
        DataSet dataSet;
        private Dictionary<int, Bitmap> unboundData = new Dictionary<int, Bitmap>();

        public Form1()
        {
            InitializeComponent();
            InitializeChart();
            InitializeSource();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productsBindingSource.DataSource = dataSet.Tables["Products"];
            personsBindingSource.DataSource = dataSet.Tables["Persons"];
        }

        DataTable GetProductsDataTable()
        {
            DataTable table = new DataTable();
            table.TableName = "Products";
            table.Columns.Add(new DataColumn("ProductName", typeof(string)));
            table.Columns.Add(new DataColumn("UnitPrice", typeof(double)));
            table.Columns.Add(new DataColumn("ID", typeof(int)));
            for (int i = 0; i < 1000; i++)
                table.Rows.Add("Product " + i, 3000 + i * 298.55M, i % 200);
            return table;
        }
        DataTable GetPersonDataTable()
        {
            DataTable table = new DataTable();
            table.TableName = "Persons";
            table.Columns.Add(new DataColumn("FirstName", typeof(string)));
            table.Columns.Add(new DataColumn("SecondName", typeof(string)));
            table.Columns.Add(new DataColumn("Image", typeof(Image)));
            table.Columns.Add(new DataColumn("ID", typeof(int)));
            for (int i = 0; i < 200; i++)
                table.Rows.Add("FirstName " + i, "SecondName " + i, Resources.picture_post_card, i);
            return table;
        }

        private void InitializeChart()
        {
            chart = new ChartControl();
            Series series1 = new Series("series1", ViewType.Bar);
            series1.ArgumentDataMember = "ProductName";
            series1.ValueDataMembers.AddRange(new string[] { "UnitPrice" });
            series1.ShowInLegend = false;
            Series series2 = new Series("series2", ViewType.Point);
            series2.ArgumentDataMember = "ProductName";
            series2.ValueDataMembers.AddRange(new string[] { "UnitPrice" });
            series2.ShowInLegend = false;
            series2.Label.Visible = false;
            chart.Series.AddRange(new Series[] { series1, series2 });
            ((XYDiagram)chart.Diagram).AxisX.Label.Angle = 20;
        }
        private void InitializeSource()
        {
            dataSet = new DataSet();
            dataSet.Tables.Add(GetProductsDataTable());
            dataSet.Tables.Add(GetPersonDataTable());
            DataColumn keyColumn = dataSet.Tables["Persons"].Columns["ID"];
            DataColumn foreignKeyColumn = dataSet.Tables["Products"].Columns["ID"];
            dataSet.Relations.Add("PersonsProducts", keyColumn, foreignKeyColumn);
        }

        private void layoutView1_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (e.Column == colProducts)
            {
                if (e.IsGetData)
                {
                    int personId = (int)dataSet.Tables["Persons"].Rows[e.ListSourceRowIndex]["ID"];
                    Bitmap img = null;
                    if (unboundData.ContainsKey(personId))
                        img = unboundData[personId];
                    else
                    {
                        DataView dataView = dataSet.Tables["Products"].DefaultView;
                        dataView.RowFilter = string.Format("ID = {0}", personId);
                        foreach (Series s in chart.Series)
                            s.DataSource = dataView;
                        chart.RefreshData();
                        LayoutView view = (LayoutView)sender;
                        LayoutViewInfo viewInfo = (LayoutViewInfo)view.GetViewInfo();
                        Size chartSize = Size.Empty;
                        foreach (LayoutViewField field in view.TemplateCard.Items)
                            if (field.FieldName == "colProducts")
                            {
                                chartSize = field.Size;
                                break;
                            }
                        chart.Size = chartSize;
                        img = new Bitmap(chartSize.Width, chartSize.Height);
                        chart.DrawToBitmap(img, new Rectangle(Point.Empty, chartSize));
                        unboundData.Add(personId, img);
                    }
                    e.Value = img;
                }
            }
        }
    }
}