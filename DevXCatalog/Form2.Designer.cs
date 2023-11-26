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
            DevExpress.XtraGrid.GridControl product_detailsGridControl;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.product_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new DevXCatalog.DatabaseDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colproduct_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproduct_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcategory_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.gridSplitContainer1Grid = new DevExpress.XtraGrid.GridControl();
            this.product_with_specificationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridSplitContainer1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colproduct_spec_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproduct_id1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colspecification_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colspecification_value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcategory_name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.product_detailsTableAdapter = new DevXCatalog.DatabaseDataSetTableAdapters.product_detailsTableAdapter();
            this.tableAdapterManager = new DevXCatalog.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.product_with_specificationsTableAdapter = new DevXCatalog.DatabaseDataSetTableAdapters.product_with_specificationsTableAdapter();
            product_detailsGridControl = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(product_detailsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).BeginInit();
            this.gridSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_with_specificationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // product_detailsGridControl
            // 
            product_detailsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            product_detailsGridControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            product_detailsGridControl.Cursor = System.Windows.Forms.Cursors.Hand;
            product_detailsGridControl.DataMember = null;
            product_detailsGridControl.DataSource = this.product_detailsBindingSource;
            product_detailsGridControl.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            product_detailsGridControl.EmbeddedNavigator.Appearance.Options.UseFont = true;
            product_detailsGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            product_detailsGridControl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            product_detailsGridControl.Location = new System.Drawing.Point(12, 12);
            product_detailsGridControl.MainView = this.gridView1;
            product_detailsGridControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            product_detailsGridControl.Name = "product_detailsGridControl";
            product_detailsGridControl.ShowOnlyPredefinedDetails = true;
            product_detailsGridControl.Size = new System.Drawing.Size(1251, 365);
            product_detailsGridControl.TabIndex = 4;
            product_detailsGridControl.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.False;
            product_detailsGridControl.UseEmbeddedNavigator = true;
            product_detailsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            product_detailsGridControl.Click += new System.EventHandler(this.product_detailsGridControl_Click);
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
            // gridView1
            // 
            this.gridView1.ActiveFilterEnabled = false;
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colproduct_id,
            this.colproduct_name,
            this.coldescription,
            this.colprice,
            this.colcountry,
            this.colproducer,
            this.colcategory_name});
            this.gridView1.DetailHeight = 591;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = product_detailsGridControl;
            this.gridView1.GroupPanelText = "Zoznam produkov";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1600;
            this.gridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridView1.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridView1.OptionsNavigation.AutoMoveRowFocus = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView1.RowHeight = 10;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colproduct_id, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colproduct_id
            // 
            this.colproduct_id.FieldName = "product_id";
            this.colproduct_id.MinWidth = 50;
            this.colproduct_id.Name = "colproduct_id";
            this.colproduct_id.Width = 188;
            // 
            // colproduct_name
            // 
            this.colproduct_name.Caption = "Produkt";
            this.colproduct_name.FieldName = "product_name";
            this.colproduct_name.MinWidth = 50;
            this.colproduct_name.Name = "colproduct_name";
            this.colproduct_name.OptionsColumn.AllowEdit = false;
            this.colproduct_name.OptionsColumn.ShowInCustomizationForm = false;
            this.colproduct_name.OptionsColumn.ShowInExpressionEditor = false;
            this.colproduct_name.Visible = true;
            this.colproduct_name.VisibleIndex = 0;
            this.colproduct_name.Width = 188;
            // 
            // coldescription
            // 
            this.coldescription.Caption = "Popis";
            this.coldescription.FieldName = "description";
            this.coldescription.MinWidth = 50;
            this.coldescription.Name = "coldescription";
            this.coldescription.Visible = true;
            this.coldescription.VisibleIndex = 1;
            this.coldescription.Width = 188;
            // 
            // colprice
            // 
            this.colprice.Caption = "Cena";
            this.colprice.FieldName = "price";
            this.colprice.MinWidth = 50;
            this.colprice.Name = "colprice";
            this.colprice.Visible = true;
            this.colprice.VisibleIndex = 2;
            this.colprice.Width = 188;
            // 
            // colcountry
            // 
            this.colcountry.Caption = "Krajina";
            this.colcountry.FieldName = "country";
            this.colcountry.MinWidth = 50;
            this.colcountry.Name = "colcountry";
            this.colcountry.OptionsFilter.AllowAutoFilter = false;
            this.colcountry.Visible = true;
            this.colcountry.VisibleIndex = 3;
            this.colcountry.Width = 188;
            // 
            // colproducer
            // 
            this.colproducer.Caption = "Výrobca";
            this.colproducer.FieldName = "producer";
            this.colproducer.MinWidth = 50;
            this.colproducer.Name = "colproducer";
            this.colproducer.Visible = true;
            this.colproducer.VisibleIndex = 5;
            this.colproducer.Width = 188;
            // 
            // colcategory_name
            // 
            this.colcategory_name.Caption = "Kategória";
            this.colcategory_name.FieldName = "category_name";
            this.colcategory_name.MinWidth = 50;
            this.colcategory_name.Name = "colcategory_name";
            this.colcategory_name.Visible = true;
            this.colcategory_name.VisibleIndex = 4;
            this.colcategory_name.Width = 188;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gridSplitContainer1);
            this.dataLayoutControl1.Controls.Add(product_detailsGridControl);
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, -9);
            this.dataLayoutControl1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(301, 419, 812, 500);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1275, 767);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Grid = this.gridSplitContainer1Grid;
            this.gridSplitContainer1.Location = new System.Drawing.Point(12, 381);
            this.gridSplitContainer1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
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
            this.gridSplitContainer1.Size = new System.Drawing.Size(1251, 374);
            this.gridSplitContainer1.TabIndex = 5;
            // 
            // gridSplitContainer1Grid
            // 
            this.gridSplitContainer1Grid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gridSplitContainer1Grid.DataSource = this.product_with_specificationsBindingSource;
            this.gridSplitContainer1Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1Grid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.gridSplitContainer1Grid.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridSplitContainer1Grid.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1Grid.MainView = this.gridSplitContainer1View;
            this.gridSplitContainer1Grid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.gridSplitContainer1Grid.Name = "gridSplitContainer1Grid";
            this.gridSplitContainer1Grid.Size = new System.Drawing.Size(1251, 374);
            this.gridSplitContainer1Grid.TabIndex = 0;
            this.gridSplitContainer1Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSplitContainer1View});
            this.gridSplitContainer1Grid.Click += new System.EventHandler(this.gridSplitContainer1Grid_Click);
            // 
            // product_with_specificationsBindingSource
            // 
            this.product_with_specificationsBindingSource.DataMember = "FK_product_details_product_with_specifications";
            this.product_with_specificationsBindingSource.DataSource = this.product_detailsBindingSource;
            // 
            // gridSplitContainer1View
            // 
            this.gridSplitContainer1View.Appearance.GroupPanel.BackColor = System.Drawing.Color.Gray;
            this.gridSplitContainer1View.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridSplitContainer1View.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridSplitContainer1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colproduct_spec_id,
            this.colproduct_id1,
            this.colspecification_name,
            this.colspecification_value,
            this.colcategory_name1});
            this.gridSplitContainer1View.DetailHeight = 591;
            this.gridSplitContainer1View.GridControl = this.gridSplitContainer1Grid;
            this.gridSplitContainer1View.GroupPanelText = "Detail produktu";
            this.gridSplitContainer1View.Name = "gridSplitContainer1View";
            this.gridSplitContainer1View.OptionsEditForm.PopupEditFormWidth = 1600;
            // 
            // colproduct_spec_id
            // 
            this.colproduct_spec_id.FieldName = "product_spec_id";
            this.colproduct_spec_id.MinWidth = 50;
            this.colproduct_spec_id.Name = "colproduct_spec_id";
            this.colproduct_spec_id.Width = 188;
            // 
            // colproduct_id1
            // 
            this.colproduct_id1.FieldName = "product_id";
            this.colproduct_id1.MinWidth = 50;
            this.colproduct_id1.Name = "colproduct_id1";
            this.colproduct_id1.Width = 188;
            // 
            // colspecification_name
            // 
            this.colspecification_name.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colspecification_name.AppearanceCell.Options.UseFont = true;
            this.colspecification_name.FieldName = "specification_name";
            this.colspecification_name.MinWidth = 50;
            this.colspecification_name.Name = "colspecification_name";
            this.colspecification_name.Visible = true;
            this.colspecification_name.VisibleIndex = 0;
            this.colspecification_name.Width = 188;
            // 
            // colspecification_value
            // 
            this.colspecification_value.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colspecification_value.AppearanceCell.Options.UseFont = true;
            this.colspecification_value.FieldName = "specification_value";
            this.colspecification_value.MinWidth = 50;
            this.colspecification_value.Name = "colspecification_value";
            this.colspecification_value.Visible = true;
            this.colspecification_value.VisibleIndex = 1;
            this.colspecification_value.Width = 188;
            // 
            // colcategory_name1
            // 
            this.colcategory_name1.FieldName = "category_name";
            this.colcategory_name1.MinWidth = 50;
            this.colcategory_name1.Name = "colcategory_name1";
            this.colcategory_name1.Width = 188;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1275, 767);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = product_detailsGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1255, 369);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridSplitContainer1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 369);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1255, 378);
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
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 760);
            this.Controls.Add(this.dataLayoutControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Form2.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form2";
            this.Text = "Catalog";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(product_detailsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).EndInit();
            this.gridSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_with_specificationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1View)).EndInit();
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
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colproduct_id;
        private DevExpress.XtraGrid.Columns.GridColumn colproduct_name;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription;
        private DevExpress.XtraGrid.Columns.GridColumn colprice;
        private DevExpress.XtraGrid.Columns.GridColumn colcountry;
        private DevExpress.XtraGrid.Columns.GridColumn colproducer;
        private DevExpress.XtraGrid.Columns.GridColumn colcategory_name;
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
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}