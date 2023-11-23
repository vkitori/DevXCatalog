namespace DevXCatalog
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.gridSplitContainer1Grid = new DevExpress.XtraGrid.GridControl();
            this.product_with_specificationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new DevXCatalog.DatabaseDataSet();
            this.gridSplitContainer1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colproduct_spec_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproduct_id1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colspecification_value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colspecification_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcategory_name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.product_detailsGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colproduct_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproduct_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcategory_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.product_detailsTableAdapter = new DevXCatalog.DatabaseDataSetTableAdapters.product_detailsTableAdapter();
            this.tableAdapterManager = new DevXCatalog.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.product_with_specificationsTableAdapter = new DevXCatalog.DatabaseDataSetTableAdapters.product_with_specificationsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).BeginInit();
            this.gridSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_with_specificationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_detailsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gridSplitContainer1);
            this.dataLayoutControl1.Controls.Add(this.product_detailsGridControl);
            this.dataLayoutControl1.Location = new System.Drawing.Point(12, 5);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 399, 812, 500);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1286, 784);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Grid = this.gridSplitContainer1Grid;
            this.gridSplitContainer1.Location = new System.Drawing.Point(12, 406);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            // 
            // gridSplitContainer1.Panel1
            // 
            this.gridSplitContainer1.Panel1.Controls.Add(this.gridSplitContainer1Grid);
            this.gridSplitContainer1.Panel1.Text = "Panel1";
            // 
            // gridSplitContainer1.Panel2
            // 
            this.gridSplitContainer1.Panel2.Text = "Panel2";
            this.gridSplitContainer1.Size = new System.Drawing.Size(1262, 366);
            this.gridSplitContainer1.TabIndex = 5;
            // 
            // gridSplitContainer1Grid
            // 
            this.gridSplitContainer1Grid.DataSource = this.product_with_specificationsBindingSource;
            this.gridSplitContainer1Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1Grid.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1Grid.MainView = this.gridSplitContainer1View;
            this.gridSplitContainer1Grid.Name = "gridSplitContainer1Grid";
            this.gridSplitContainer1Grid.Size = new System.Drawing.Size(1262, 366);
            this.gridSplitContainer1Grid.TabIndex = 0;
            this.gridSplitContainer1Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSplitContainer1View});
            // 
            // product_with_specificationsBindingSource
            // 
            this.product_with_specificationsBindingSource.DataMember = "FK_product_details_product_with_specifications";
            this.product_with_specificationsBindingSource.DataSource = this.product_detailsBindingSource;
            // 
            // product_detailsBindingSource
            // 
            this.product_detailsBindingSource.DataMember = "product_details";
            this.product_detailsBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridSplitContainer1View
            // 
            this.gridSplitContainer1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colproduct_spec_id,
            this.colproduct_id1,
            this.colspecification_value,
            this.colspecification_name,
            this.colcategory_name1});
            this.gridSplitContainer1View.GridControl = this.gridSplitContainer1Grid;
            this.gridSplitContainer1View.Name = "gridSplitContainer1View";
            // 
            // colproduct_spec_id
            // 
            this.colproduct_spec_id.FieldName = "product_spec_id";
            this.colproduct_spec_id.MinWidth = 25;
            this.colproduct_spec_id.Name = "colproduct_spec_id";
            this.colproduct_spec_id.Visible = true;
            this.colproduct_spec_id.VisibleIndex = 0;
            this.colproduct_spec_id.Width = 94;
            // 
            // colproduct_id1
            // 
            this.colproduct_id1.FieldName = "product_id";
            this.colproduct_id1.MinWidth = 25;
            this.colproduct_id1.Name = "colproduct_id1";
            this.colproduct_id1.Visible = true;
            this.colproduct_id1.VisibleIndex = 1;
            this.colproduct_id1.Width = 94;
            // 
            // colspecification_value
            // 
            this.colspecification_value.FieldName = "specification_value";
            this.colspecification_value.MinWidth = 25;
            this.colspecification_value.Name = "colspecification_value";
            this.colspecification_value.Visible = true;
            this.colspecification_value.VisibleIndex = 2;
            this.colspecification_value.Width = 94;
            // 
            // colspecification_name
            // 
            this.colspecification_name.FieldName = "specification_name";
            this.colspecification_name.MinWidth = 25;
            this.colspecification_name.Name = "colspecification_name";
            this.colspecification_name.Visible = true;
            this.colspecification_name.VisibleIndex = 3;
            this.colspecification_name.Width = 94;
            // 
            // colcategory_name1
            // 
            this.colcategory_name1.FieldName = "category_name";
            this.colcategory_name1.MinWidth = 25;
            this.colcategory_name1.Name = "colcategory_name1";
            this.colcategory_name1.Visible = true;
            this.colcategory_name1.VisibleIndex = 4;
            this.colcategory_name1.Width = 94;
            // 
            // product_detailsGridControl
            // 
            this.product_detailsGridControl.DataSource = this.product_detailsBindingSource;
            gridLevelNode1.RelationName = "Level1";
            this.product_detailsGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.product_detailsGridControl.Location = new System.Drawing.Point(12, 12);
            this.product_detailsGridControl.MainView = this.gridView1;
            this.product_detailsGridControl.Name = "product_detailsGridControl";
            this.product_detailsGridControl.Size = new System.Drawing.Size(1262, 390);
            this.product_detailsGridControl.TabIndex = 4;
            this.product_detailsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.product_detailsGridControl.Click += new System.EventHandler(this.product_detailsGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colproduct_id,
            this.colproduct_name,
            this.coldescription,
            this.colprice,
            this.colcountry,
            this.colproducer,
            this.colcategory_name});
            this.gridView1.GridControl = this.product_detailsGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridView1.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colproduct_id, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colproduct_id
            // 
            this.colproduct_id.FieldName = "product_id";
            this.colproduct_id.MinWidth = 25;
            this.colproduct_id.Name = "colproduct_id";
            this.colproduct_id.Visible = true;
            this.colproduct_id.VisibleIndex = 0;
            this.colproduct_id.Width = 94;
            // 
            // colproduct_name
            // 
            this.colproduct_name.FieldName = "product_name";
            this.colproduct_name.MinWidth = 25;
            this.colproduct_name.Name = "colproduct_name";
            this.colproduct_name.Visible = true;
            this.colproduct_name.VisibleIndex = 1;
            this.colproduct_name.Width = 94;
            // 
            // coldescription
            // 
            this.coldescription.FieldName = "description";
            this.coldescription.MinWidth = 25;
            this.coldescription.Name = "coldescription";
            this.coldescription.Visible = true;
            this.coldescription.VisibleIndex = 2;
            this.coldescription.Width = 94;
            // 
            // colprice
            // 
            this.colprice.FieldName = "price";
            this.colprice.MinWidth = 25;
            this.colprice.Name = "colprice";
            this.colprice.Visible = true;
            this.colprice.VisibleIndex = 3;
            this.colprice.Width = 94;
            // 
            // colcountry
            // 
            this.colcountry.FieldName = "country";
            this.colcountry.MinWidth = 25;
            this.colcountry.Name = "colcountry";
            this.colcountry.OptionsFilter.AllowAutoFilter = false;
            this.colcountry.Visible = true;
            this.colcountry.VisibleIndex = 4;
            this.colcountry.Width = 94;
            // 
            // colproducer
            // 
            this.colproducer.FieldName = "producer";
            this.colproducer.MinWidth = 25;
            this.colproducer.Name = "colproducer";
            this.colproducer.Visible = true;
            this.colproducer.VisibleIndex = 6;
            this.colproducer.Width = 94;
            // 
            // colcategory_name
            // 
            this.colcategory_name.FieldName = "category_name";
            this.colcategory_name.MinWidth = 25;
            this.colcategory_name.Name = "colcategory_name";
            this.colcategory_name.Visible = true;
            this.colcategory_name.VisibleIndex = 5;
            this.colcategory_name.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1286, 784);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.product_detailsGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1266, 394);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridSplitContainer1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 394);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1266, 370);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // product_detailsTableAdapter
            // 
            this.product_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = DevXCatalog.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // product_with_specificationsTableAdapter
            // 
            this.product_with_specificationsTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 789);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).EndInit();
            this.gridSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_with_specificationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_detailsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource product_detailsBindingSource;
        private DatabaseDataSetTableAdapters.product_detailsTableAdapter product_detailsTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl product_detailsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colproduct_id;
        private DevExpress.XtraGrid.Columns.GridColumn colproduct_name;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription;
        private DevExpress.XtraGrid.Columns.GridColumn colprice;
        private DevExpress.XtraGrid.Columns.GridColumn colcountry;
        private DevExpress.XtraGrid.Columns.GridColumn colproducer;
        private DevExpress.XtraGrid.Columns.GridColumn colcategory_name;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.GridControl gridSplitContainer1Grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSplitContainer1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource product_with_specificationsBindingSource;
        private DatabaseDataSetTableAdapters.product_with_specificationsTableAdapter product_with_specificationsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colproduct_spec_id;
        private DevExpress.XtraGrid.Columns.GridColumn colproduct_id1;
        private DevExpress.XtraGrid.Columns.GridColumn colspecification_value;
        private DevExpress.XtraGrid.Columns.GridColumn colspecification_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcategory_name1;
    }
}