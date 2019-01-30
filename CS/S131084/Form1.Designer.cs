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
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colPersonID = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colPersonID = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colPersonName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colPersonName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colSecondName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colSecondName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colImage = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.layoutViewField_colImage = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colProducts = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.item1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPersonID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPersonName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSecondName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.personsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            // layoutView1
            // 
            this.layoutView1.CardMinSize = new System.Drawing.Size(636, 393);
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colPersonID,
            this.colPersonName,
            this.colSecondName,
            this.colImage,
            this.colProducts});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            this.layoutView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.layoutView1_CustomUnboundColumnData);
            // 
            // colCategoryID
            // 
            this.colPersonID.Caption = "PersonID";
            this.colPersonID.FieldName = "ID";
            this.colPersonID.LayoutViewField = this.layoutViewField_colPersonID;
            this.colPersonID.Name = "colPersonID";
            // 
            // layoutViewField_colCategoryID
            // 
            this.layoutViewField_colPersonID.EditorPreferredWidth = 85;
            this.layoutViewField_colPersonID.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colPersonID.Name = "layoutViewField_colPersonID";
            this.layoutViewField_colPersonID.Size = new System.Drawing.Size(177, 27);
            this.layoutViewField_colPersonID.TextSize = new System.Drawing.Size(76, 13);
            // 
            // colCategoryName
            // 
            this.colPersonName.Caption = "PersonName";
            this.colPersonName.FieldName = "FirstName";
            this.colPersonName.LayoutViewField = this.layoutViewField_colPersonName;
            this.colPersonName.Name = "colPersonName";
            // 
            // layoutViewField_colCategoryName
            // 
            this.layoutViewField_colPersonName.EditorPreferredWidth = 85;
            this.layoutViewField_colPersonName.Location = new System.Drawing.Point(0, 27);
            this.layoutViewField_colPersonName.Name = "layoutViewField_colPersonName";
            this.layoutViewField_colPersonName.Size = new System.Drawing.Size(177, 27);
            this.layoutViewField_colPersonName.TextSize = new System.Drawing.Size(76, 13);
            // 
            // colDescription
            // 
            this.colSecondName.Caption = "SecondName";
            this.colSecondName.FieldName = "SecondName";
            this.colSecondName.LayoutViewField = this.layoutViewField_colSecondName;
            this.colSecondName.Name = "colSecondName";
            // 
            // layoutViewField_colDescription
            // 
            this.layoutViewField_colSecondName.EditorPreferredWidth = 85;
            this.layoutViewField_colSecondName.Location = new System.Drawing.Point(0, 54);
            this.layoutViewField_colSecondName.Name = "layoutViewField_colSecondName";
            this.layoutViewField_colSecondName.Size = new System.Drawing.Size(177, 27);
            this.layoutViewField_colSecondName.TextSize = new System.Drawing.Size(76, 13);
            // 
            // colPicture
            // 
            this.colImage.Caption = "Image";
            this.colImage.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colImage.FieldName = "Image";
            this.colImage.LayoutViewField = this.layoutViewField_colImage;
            this.colImage.Name = "colImage";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // layoutViewField_colPicture
            // 
            this.layoutViewField_colImage.EditorPreferredWidth = 166;
            this.layoutViewField_colImage.Location = new System.Drawing.Point(0, 81);
            this.layoutViewField_colImage.Name = "layoutViewField_colImage";
            this.layoutViewField_colImage.Size = new System.Drawing.Size(177, 103);
            this.layoutViewField_colImage.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colImage.TextToControlDistance = 0;
            this.layoutViewField_colImage.TextVisible = false;
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
            // layoutViewField_layoutViewColumn1
            // 
            this.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 442;
            this.layoutViewField_layoutViewColumn1.Location = new System.Drawing.Point(177, 0);
            this.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            this.layoutViewField_layoutViewColumn1.Size = new System.Drawing.Size(453, 352);
            this.layoutViewField_layoutViewColumn1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_layoutViewColumn1.TextToControlDistance = 0;
            this.layoutViewField_layoutViewColumn1.TextVisible = false;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "layoutViewTemplateCard";
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colPersonID,
            this.layoutViewField_colPersonName,
            this.layoutViewField_colSecondName,
            this.layoutViewField_colImage,
            this.layoutViewField_layoutViewColumn1,
            this.item1});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.Text = "Root";
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
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPersonID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPersonName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSecondName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colPersonID;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colPersonName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colSecondName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colImage;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colProducts;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPersonID;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPersonName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colSecondName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colImage;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraLayout.EmptySpaceItem item1;
    }
}

