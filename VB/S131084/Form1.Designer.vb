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
            Me.personsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.layoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
            Me.colPersonID = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colPersonID = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colPersonName = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colPersonName = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colSecondName = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colSecondName = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colImage = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.layoutViewField_colImage = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colProducts = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_layoutViewColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
            Me.item1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.personsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colPersonID, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colPersonName, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colSecondName, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colImage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_layoutViewColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.item1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.personsBindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.layoutView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(863, 515)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.layoutView1})
            ' 
            ' layoutView1
            ' 
            Me.layoutView1.CardMinSize = New System.Drawing.Size(636, 393)
            Me.layoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.colPersonID, Me.colPersonName, Me.colSecondName, Me.colImage, Me.colProducts})
            Me.layoutView1.GridControl = Me.gridControl1
            Me.layoutView1.Name = "layoutView1"
            Me.layoutView1.TemplateCard = Me.layoutViewCard1
            ' 
            ' colCategoryID
            ' 
            Me.colPersonID.Caption = "PersonID"
            Me.colPersonID.FieldName = "ID"
            Me.colPersonID.LayoutViewField = Me.layoutViewField_colPersonID
            Me.colPersonID.Name = "colPersonID"
            ' 
            ' layoutViewField_colCategoryID
            ' 
            Me.layoutViewField_colPersonID.EditorPreferredWidth = 85
            Me.layoutViewField_colPersonID.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_colPersonID.Name = "layoutViewField_colPersonID"
            Me.layoutViewField_colPersonID.Size = New System.Drawing.Size(177, 27)
            Me.layoutViewField_colPersonID.TextSize = New System.Drawing.Size(76, 13)
            ' 
            ' colCategoryName
            ' 
            Me.colPersonName.Caption = "PersonName"
            Me.colPersonName.FieldName = "FirstName"
            Me.colPersonName.LayoutViewField = Me.layoutViewField_colPersonName
            Me.colPersonName.Name = "colPersonName"
            ' 
            ' layoutViewField_colCategoryName
            ' 
            Me.layoutViewField_colPersonName.EditorPreferredWidth = 85
            Me.layoutViewField_colPersonName.Location = New System.Drawing.Point(0, 27)
            Me.layoutViewField_colPersonName.Name = "layoutViewField_colPersonName"
            Me.layoutViewField_colPersonName.Size = New System.Drawing.Size(177, 27)
            Me.layoutViewField_colPersonName.TextSize = New System.Drawing.Size(76, 13)
            ' 
            ' colDescription
            ' 
            Me.colSecondName.Caption = "SecondName"
            Me.colSecondName.FieldName = "SecondName"
            Me.colSecondName.LayoutViewField = Me.layoutViewField_colSecondName
            Me.colSecondName.Name = "colSecondName"
            ' 
            ' layoutViewField_colDescription
            ' 
            Me.layoutViewField_colSecondName.EditorPreferredWidth = 85
            Me.layoutViewField_colSecondName.Location = New System.Drawing.Point(0, 54)
            Me.layoutViewField_colSecondName.Name = "layoutViewField_colSecondName"
            Me.layoutViewField_colSecondName.Size = New System.Drawing.Size(177, 27)
            Me.layoutViewField_colSecondName.TextSize = New System.Drawing.Size(76, 13)
            ' 
            ' colPicture
            ' 
            Me.colImage.Caption = "Image"
            Me.colImage.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.colImage.FieldName = "Image"
            Me.colImage.LayoutViewField = Me.layoutViewField_colImage
            Me.colImage.Name = "colImage"
            ' 
            ' repositoryItemPictureEdit1
            ' 
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            ' 
            ' layoutViewField_colPicture
            ' 
            Me.layoutViewField_colImage.EditorPreferredWidth = 166
            Me.layoutViewField_colImage.Location = New System.Drawing.Point(0, 81)
            Me.layoutViewField_colImage.Name = "layoutViewField_colImage"
            Me.layoutViewField_colImage.Size = New System.Drawing.Size(177, 103)
            Me.layoutViewField_colImage.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutViewField_colImage.TextToControlDistance = 0
            Me.layoutViewField_colImage.TextVisible = False
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
            ' layoutViewField_layoutViewColumn1
            ' 
            Me.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 442
            Me.layoutViewField_layoutViewColumn1.Location = New System.Drawing.Point(177, 0)
            Me.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1"
            Me.layoutViewField_layoutViewColumn1.Size = New System.Drawing.Size(453, 352)
            Me.layoutViewField_layoutViewColumn1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutViewField_layoutViewColumn1.TextToControlDistance = 0
            Me.layoutViewField_layoutViewColumn1.TextVisible = False
            ' 
            ' layoutViewCard1
            ' 
            Me.layoutViewCard1.CustomizationFormText = "layoutViewTemplateCard"
            Me.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
            Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colPersonID, Me.layoutViewField_colPersonName, Me.layoutViewField_colSecondName, Me.layoutViewField_colImage, Me.layoutViewField_layoutViewColumn1, Me.item1})
            Me.layoutViewCard1.Name = "layoutViewCard1"
            Me.layoutViewCard1.Text = "Root"
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
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.personsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colPersonID, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colPersonName, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colSecondName, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colImage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_layoutViewColumn1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.item1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents layoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
        Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Private personsBindingSource As System.Windows.Forms.BindingSource
        Private colPersonID As DevExpress.XtraGrid.Columns.LayoutViewColumn
        Private colPersonName As DevExpress.XtraGrid.Columns.LayoutViewColumn
        Private colSecondName As DevExpress.XtraGrid.Columns.LayoutViewColumn
        Private colImage As DevExpress.XtraGrid.Columns.LayoutViewColumn
        Private colProducts As DevExpress.XtraGrid.Columns.LayoutViewColumn
        Private productsBindingSource As System.Windows.Forms.BindingSource
        Private layoutViewField_colPersonID As DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colPersonName As DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colSecondName As DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colImage As DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_layoutViewColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
        Private item1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace

