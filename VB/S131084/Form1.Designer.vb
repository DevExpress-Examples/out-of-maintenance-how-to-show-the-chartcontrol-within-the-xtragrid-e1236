Imports Microsoft.VisualBasic
Imports System
Namespace S131084
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.categoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New S131084.nwindDataSet()
			Me.layoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
			Me.colCategoryID = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colCategoryName = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colDescription = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colPicture = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.colProducts = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.categoriesTableAdapter = New S131084.nwindDataSetTableAdapters.CategoriesTableAdapter()
			Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.productsTableAdapter = New S131084.nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
			Me.layoutViewField_colCategoryID = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colCategoryName = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colDescription = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colPicture = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_layoutViewColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.item1 = New DevExpress.XtraLayout.EmptySpaceItem()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colCategoryID, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colCategoryName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colDescription, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colPicture, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_layoutViewColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.item1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.categoriesBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.layoutView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(863, 515)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.layoutView1})
			' 
			' categoriesBindingSource
			' 
			Me.categoriesBindingSource.DataMember = "Categories"
			Me.categoriesBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' layoutView1
			' 
			Me.layoutView1.CardMinSize = New System.Drawing.Size(636, 393)
			Me.layoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.colCategoryID, Me.colCategoryName, Me.colDescription, Me.colPicture, Me.colProducts})
			Me.layoutView1.GridControl = Me.gridControl1
			Me.layoutView1.Name = "layoutView1"
			Me.layoutView1.TemplateCard = Me.layoutViewCard1
'			Me.layoutView1.CustomUnboundColumnData += New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(Me.layoutView1_CustomUnboundColumnData);
			' 
			' colCategoryID
			' 
			Me.colCategoryID.Caption = "CategoryID"
			Me.colCategoryID.FieldName = "CategoryID"
			Me.colCategoryID.LayoutViewField = Me.layoutViewField_colCategoryID
			Me.colCategoryID.Name = "colCategoryID"
			' 
			' colCategoryName
			' 
			Me.colCategoryName.Caption = "CategoryName"
			Me.colCategoryName.FieldName = "CategoryName"
			Me.colCategoryName.LayoutViewField = Me.layoutViewField_colCategoryName
			Me.colCategoryName.Name = "colCategoryName"
			' 
			' colDescription
			' 
			Me.colDescription.Caption = "Description"
			Me.colDescription.FieldName = "Description"
			Me.colDescription.LayoutViewField = Me.layoutViewField_colDescription
			Me.colDescription.Name = "colDescription"
			' 
			' colPicture
			' 
			Me.colPicture.Caption = "Picture"
			Me.colPicture.ColumnEdit = Me.repositoryItemPictureEdit1
			Me.colPicture.FieldName = "Picture"
			Me.colPicture.LayoutViewField = Me.layoutViewField_colPicture
			Me.colPicture.Name = "colPicture"
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			' 
			' colProducts
			' 
			Me.colProducts.Caption = "layoutViewColumn1"
			Me.colProducts.ColumnEdit = Me.repositoryItemPictureEdit1
			Me.colProducts.FieldName = "colProducts"
			Me.colProducts.LayoutViewField = Me.layoutViewField_layoutViewColumn1
			Me.colProducts.Name = "colProducts"
			Me.colProducts.UnboundType = DevExpress.Data.UnboundColumnType.Object
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' productsBindingSource
			' 
			Me.productsBindingSource.DataMember = "Products"
			Me.productsBindingSource.DataSource = Me.nwindDataSet
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' layoutViewCard1
			' 
			Me.layoutViewCard1.CustomizationFormText = "layoutViewTemplateCard"
			Me.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
			Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colCategoryID, Me.layoutViewField_colCategoryName, Me.layoutViewField_colDescription, Me.layoutViewField_colPicture, Me.layoutViewField_layoutViewColumn1, Me.item1})
			Me.layoutViewCard1.Name = "layoutViewCard1"
			Me.layoutViewCard1.Text = "Root"
			' 
			' layoutViewField_colCategoryID
			' 
			Me.layoutViewField_colCategoryID.EditorPreferredWidth = 85
			Me.layoutViewField_colCategoryID.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_colCategoryID.Name = "layoutViewField_colCategoryID"
			Me.layoutViewField_colCategoryID.Size = New System.Drawing.Size(177, 27)
			Me.layoutViewField_colCategoryID.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutViewField_colCategoryID.TextSize = New System.Drawing.Size(76, 20)
			' 
			' layoutViewField_colCategoryName
			' 
			Me.layoutViewField_colCategoryName.EditorPreferredWidth = 85
			Me.layoutViewField_colCategoryName.Location = New System.Drawing.Point(0, 27)
			Me.layoutViewField_colCategoryName.Name = "layoutViewField_colCategoryName"
			Me.layoutViewField_colCategoryName.Size = New System.Drawing.Size(177, 27)
			Me.layoutViewField_colCategoryName.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutViewField_colCategoryName.TextSize = New System.Drawing.Size(76, 20)
			' 
			' layoutViewField_colDescription
			' 
			Me.layoutViewField_colDescription.EditorPreferredWidth = 85
			Me.layoutViewField_colDescription.Location = New System.Drawing.Point(0, 54)
			Me.layoutViewField_colDescription.Name = "layoutViewField_colDescription"
			Me.layoutViewField_colDescription.Size = New System.Drawing.Size(177, 27)
			Me.layoutViewField_colDescription.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutViewField_colDescription.TextSize = New System.Drawing.Size(76, 20)
			' 
			' layoutViewField_colPicture
			' 
			Me.layoutViewField_colPicture.EditorPreferredWidth = 166
			Me.layoutViewField_colPicture.Location = New System.Drawing.Point(0, 81)
			Me.layoutViewField_colPicture.Name = "layoutViewField_colPicture"
			Me.layoutViewField_colPicture.Size = New System.Drawing.Size(177, 103)
			Me.layoutViewField_colPicture.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutViewField_colPicture.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutViewField_colPicture.TextToControlDistance = 0
			Me.layoutViewField_colPicture.TextVisible = False
			' 
			' layoutViewField_layoutViewColumn1
			' 
			Me.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 442
			Me.layoutViewField_layoutViewColumn1.Location = New System.Drawing.Point(177, 0)
			Me.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1"
			Me.layoutViewField_layoutViewColumn1.Size = New System.Drawing.Size(453, 352)
			Me.layoutViewField_layoutViewColumn1.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutViewField_layoutViewColumn1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutViewField_layoutViewColumn1.TextToControlDistance = 0
			Me.layoutViewField_layoutViewColumn1.TextVisible = False
			' 
			' item1
			' 
			Me.item1.CustomizationFormText = "item1"
			Me.item1.Location = New System.Drawing.Point(0, 184)
			Me.item1.Name = "item1"
			Me.item1.Size = New System.Drawing.Size(177, 168)
			Me.item1.Text = "item1"
			Me.item1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(863, 515)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colCategoryID, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colCategoryName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colDescription, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colPicture, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_layoutViewColumn1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.item1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents layoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private nwindDataSet As nwindDataSet
		Private categoriesBindingSource As System.Windows.Forms.BindingSource
		Private categoriesTableAdapter As S131084.nwindDataSetTableAdapters.CategoriesTableAdapter
		Private colCategoryID As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colCategoryName As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colDescription As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colPicture As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colProducts As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private productsBindingSource As System.Windows.Forms.BindingSource
		Private productsTableAdapter As S131084.nwindDataSetTableAdapters.ProductsTableAdapter
		Private layoutViewField_colCategoryID As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colCategoryName As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colDescription As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colPicture As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_layoutViewColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
		Private item1 As DevExpress.XtraLayout.EmptySpaceItem
	End Class
End Namespace

