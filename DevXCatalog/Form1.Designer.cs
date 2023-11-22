namespace DevXCatalog
{
    partial class Main
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
            DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splitContainerControl1.Panel1)).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(splitContainerControl1.Panel2)).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            splitContainerControl1.AlwaysScrollActiveControlIntoView = false;
            resources.ApplyResources(splitContainerControl1, "splitContainerControl1");
            splitContainerControl1.CausesValidation = false;
            splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            resources.ApplyResources(splitContainerControl1.Panel1, "splitContainerControl1.Panel1");
            splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainerControl1.Panel2
            // 
            splitContainerControl1.Panel2.Controls.Add(this.svgImageBox1);
            resources.ApplyResources(splitContainerControl1.Panel2, "splitContainerControl1.Panel2");
            splitContainerControl1.SplitterPosition = 600;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl1.Appearance.Font")));
            this.labelControl1.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // svgImageBox1
            // 
            resources.ApplyResources(this.svgImageBox1, "svgImageBox1");
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(splitContainerControl1);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 424, 812, 500);
            this.layoutControl1.Root = this.Root;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1278, 698);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = splitContainerControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1258, 678);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockWindowTabFont = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.OptionsStubGlyphs.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barManager1.OptionsStubGlyphs.UseFont = true;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            resources.ApplyResources(this.bar2, "bar2");
            // 
            // barButtonItem1
            // 
            resources.ApplyResources(this.barButtonItem1, "barButtonItem1");
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ItemAppearance.Hovered.BackColor = System.Drawing.Color.Silver;
            this.barButtonItem1.ItemAppearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("barButtonItem1.ItemAppearance.Hovered.Font")));
            this.barButtonItem1.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.barButtonItem1.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem1.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("barButtonItem1.ItemAppearance.Normal.Font")));
            this.barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.ItemAppearance.Pressed.BackColor = System.Drawing.Color.Silver;
            this.barButtonItem1.ItemAppearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("barButtonItem1.ItemAppearance.Pressed.Font")));
            this.barButtonItem1.ItemAppearance.Pressed.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("barButtonItem1.ItemAppearance.Pressed.FontStyleDelta")));
            this.barButtonItem1.ItemAppearance.Pressed.Options.UseBackColor = true;
            this.barButtonItem1.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            resources.ApplyResources(this.barButtonItem2, "barButtonItem2");
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ItemAppearance.Hovered.BackColor = System.Drawing.Color.Silver;
            this.barButtonItem2.ItemAppearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("barButtonItem2.ItemAppearance.Hovered.Font")));
            this.barButtonItem2.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.barButtonItem2.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("barButtonItem2.ItemAppearance.Normal.Font")));
            this.barButtonItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Pressed.BackColor = System.Drawing.Color.Silver;
            this.barButtonItem2.ItemAppearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("barButtonItem2.ItemAppearance.Pressed.Font")));
            this.barButtonItem2.ItemAppearance.Pressed.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("barButtonItem2.ItemAppearance.Pressed.FontStyleDelta")));
            this.barButtonItem2.ItemAppearance.Pressed.Options.UseBackColor = true;
            this.barButtonItem2.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            resources.ApplyResources(this.barButtonItem3, "barButtonItem3");
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ItemAppearance.Hovered.BackColor = System.Drawing.Color.Silver;
            this.barButtonItem3.ItemAppearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("barButtonItem3.ItemAppearance.Hovered.Font")));
            this.barButtonItem3.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.barButtonItem3.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem3.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("barButtonItem3.ItemAppearance.Normal.Font")));
            this.barButtonItem3.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem3.ItemAppearance.Pressed.BackColor = System.Drawing.Color.Silver;
            this.barButtonItem3.ItemAppearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("barButtonItem3.ItemAppearance.Pressed.Font")));
            this.barButtonItem3.ItemAppearance.Pressed.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("barButtonItem3.ItemAppearance.Pressed.FontStyleDelta")));
            this.barButtonItem3.ItemAppearance.Pressed.Options.UseBackColor = true;
            this.barButtonItem3.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            resources.ApplyResources(this.barButtonItem4, "barButtonItem4");
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ItemAppearance.Hovered.BackColor = System.Drawing.Color.Silver;
            this.barButtonItem4.ItemAppearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("barButtonItem4.ItemAppearance.Hovered.Font")));
            this.barButtonItem4.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.barButtonItem4.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem4.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("barButtonItem4.ItemAppearance.Normal.Font")));
            this.barButtonItem4.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem4.ItemAppearance.Pressed.BackColor = System.Drawing.Color.Silver;
            this.barButtonItem4.ItemAppearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("barButtonItem4.ItemAppearance.Pressed.Font")));
            this.barButtonItem4.ItemAppearance.Pressed.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("barButtonItem4.ItemAppearance.Pressed.FontStyleDelta")));
            this.barButtonItem4.ItemAppearance.Pressed.Options.UseBackColor = true;
            this.barButtonItem4.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            resources.ApplyResources(this.barButtonItem5, "barButtonItem5");
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.ItemAppearance.Hovered.BackColor = System.Drawing.Color.Silver;
            this.barButtonItem5.ItemAppearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("barButtonItem5.ItemAppearance.Hovered.Font")));
            this.barButtonItem5.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.barButtonItem5.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem5.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("barButtonItem5.ItemAppearance.Normal.Font")));
            this.barButtonItem5.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem5.ItemAppearance.Pressed.BackColor = System.Drawing.Color.Silver;
            this.barButtonItem5.ItemAppearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("barButtonItem5.ItemAppearance.Pressed.Font")));
            this.barButtonItem5.ItemAppearance.Pressed.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("barButtonItem5.ItemAppearance.Pressed.FontStyleDelta")));
            this.barButtonItem5.ItemAppearance.Pressed.Options.UseBackColor = true;
            this.barButtonItem5.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            resources.ApplyResources(this.bar3, "bar3");
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
            this.barDockControlTop.Manager = this.barManager1;
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
            this.barDockControlBottom.Manager = this.barManager1;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
            this.barDockControlLeft.Manager = this.barManager1;
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
            this.barDockControlRight.Manager = this.barManager1;
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // Main
            // 
            this.Appearance.Options.UseFont = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Main.IconOptions.SvgImage")));
            this.Name = "Main";
            this.Load += new System.EventHandler(this.CatalogApp_Load);
            ((System.ComponentModel.ISupportInitialize)(splitContainerControl1.Panel1)).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(splitContainerControl1.Panel2)).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainerControl1)).EndInit();
            splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
    }
}

