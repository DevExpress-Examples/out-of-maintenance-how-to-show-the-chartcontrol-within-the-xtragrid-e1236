namespace S131084 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new S131084.nwindDataSet();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colCategoryName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colPicture = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colProducts = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.categoriesTableAdapter = new S131084.nwindDataSetTableAdapters.CategoriesTableAdapter();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new S131084.nwindDataSetTableAdapters.ProductsTableAdapter();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.layoutViewField_colCategoryID = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colCategoryName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colDescription = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colPicture = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_layoutViewColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.item1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCategoryID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCategoryName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.categoriesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControl1.Size = new System.Drawing.Size(863, 515);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutView1
            // 
            this.layoutView1.CardMinSize = new System.Drawing.Size(636, 393);
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colCategoryID,
            this.colCategoryName,
            this.colDescription,
            this.colPicture,
            this.colProducts});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            this.layoutView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.layoutView1_CustomUnboundColumnData);
            // 
            // colCategoryID
            // 
            this.colCategoryID.Caption = "CategoryID";
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.LayoutViewField = this.layoutViewField_colCategoryID;
            this.colCategoryID.Name = "colCategoryID";
            // 
            // colCategoryName
            // 
            this.colCategoryName.Caption = "CategoryName";
            this.colCategoryName.FieldName = "CategoryName";
            this.colCategoryName.LayoutViewField = this.layoutViewField_colCategoryName;
            this.colCategoryName.Name = "colCategoryName";
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.LayoutViewField = this.layoutViewField_colDescription;
            this.colDescription.Name = "colDescription";
            // 
            // colPicture
            // 
            this.colPicture.Caption = "Picture";
            this.colPicture.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colPicture.FieldName = "Picture";
            this.colPicture.LayoutViewField = this.layoutViewField_colPicture;
            this.colPicture.Name = "colPicture";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // colProducts
            // 
            this.colProducts.Caption = "layoutViewColumn1";
            this.colProducts.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colProducts.FieldName = "colProducts";
            this.colProducts.LayoutViewField = this.layoutViewField_layoutViewColumn1;
            this.colProducts.Name = "colProducts";
            this.colProducts.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.nwindDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "layoutViewTemplateCard";
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colCategoryID,
            this.layoutViewField_colCategoryName,
            this.layoutViewField_colDescription,
            this.layoutViewField_colPicture,
            this.layoutViewField_layoutViewColumn1,
            this.item1});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.Text = "Root";
            // 
            // layoutViewField_colCategoryID
            // 
            this.layoutViewField_colCategoryID.EditorPreferredWidth = 85;
            this.layoutViewField_colCategoryID.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colCategoryID.Name = "layoutViewField_colCategoryID";
            this.layoutViewField_colCategoryID.Size = new System.Drawing.Size(177, 27);
            this.layoutViewField_colCategoryID.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colCategoryID.TextSize = new System.Drawing.Size(76, 20);
            // 
            // layoutViewField_colCategoryName
            // 
            this.layoutViewField_colCategoryName.EditorPreferredWidth = 85;
            this.layoutViewField_colCategoryName.Location = new System.Drawing.Point(0, 27);
            this.layoutViewField_colCategoryName.Name = "layoutViewField_colCategoryName";
            this.layoutViewField_colCategoryName.Size = new System.Drawing.Size(177, 27);
            this.layoutViewField_colCategoryName.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colCategoryName.TextSize = new System.Drawing.Size(76, 20);
            // 
            // layoutViewField_colDescription
            // 
            this.layoutViewField_colDescription.EditorPreferredWidth = 85;
            this.layoutViewField_colDescription.Location = new System.Drawing.Point(0, 54);
            this.layoutViewField_colDescription.Name = "layoutViewField_colDescription";
            this.layoutViewField_colDescription.Size = new System.Drawing.Size(177, 27);
            this.layoutViewField_colDescription.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colDescription.TextSize = new System.Drawing.Size(76, 20);
            // 
            // layoutViewField_colPicture
            // 
            this.layoutViewField_colPicture.EditorPreferredWidth = 166;
            this.layoutViewField_colPicture.Location = new System.Drawing.Point(0, 81);
            this.layoutViewField_colPicture.Name = "layoutViewField_colPicture";
            this.layoutViewField_colPicture.Size = new System.Drawing.Size(177, 103);
            this.layoutViewField_colPicture.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colPicture.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colPicture.TextToControlDistance = 0;
            this.layoutViewField_colPicture.TextVisible = false;
            // 
            // layoutViewField_layoutViewColumn1
            // 
            this.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 442;
            this.layoutViewField_layoutViewColumn1.Location = new System.Drawing.Point(177, 0);
            this.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            this.layoutViewField_layoutViewColumn1.Size = new System.Drawing.Size(453, 352);
            this.layoutViewField_layoutViewColumn1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_layoutViewColumn1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_layoutViewColumn1.TextToControlDistance = 0;
            this.layoutViewField_layoutViewColumn1.TextVisible = false;
            // 
            // item1
            // 
            this.item1.CustomizationFormText = "item1";
            this.item1.Location = new System.Drawing.Point(0, 184);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(177, 168);
            this.item1.Text = "item1";
            this.item1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 515);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCategoryID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCategoryName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private S131084.nwindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCategoryID;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCategoryName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colDescription;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colPicture;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colProducts;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private S131084.nwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCategoryID;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCategoryName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colDescription;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPicture;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraLayout.EmptySpaceItem item1;
    }
}

