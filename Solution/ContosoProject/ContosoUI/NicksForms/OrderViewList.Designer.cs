namespace ContosoUI.NicksForms
{
    partial class OrderViewList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderViewList));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPageOrderView = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageFileGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.orderViewLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.SaveAndNewBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.SaveBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.ClearBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.orderNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlOrderNumberTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.StatusComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlStatusComboBox = new DevExpress.XtraLayout.LayoutControlItem();
            this.orderDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlDateEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.OrderGridControl = new DevExpress.XtraGrid.GridControl();
            this.orderGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabbedControlOrderAndCommentGroup = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlDataGrid = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlOrderGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.commentsListBox = new DevExpress.XtraEditors.ListBoxControl();
            this.layoutControlCommentsList = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlCommentListBox = new DevExpress.XtraLayout.LayoutControlItem();
            this.newCommentTextBox = new System.Windows.Forms.TextBox();
            this.layoutControlNewCommentTextBox = new DevExpress.XtraLayout.LayoutControlItem();
            this.addCommentButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlAddNewCommentButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitter = new DevExpress.XtraLayout.SplitterItem();
            this.ClientLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlClientLookUp = new DevExpress.XtraLayout.LayoutControlItem();
            this.ribbonPageOrderGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderViewLayoutControl)).BeginInit();
            this.orderViewLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderNumberTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlStatusComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlOrderAndCommentGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCommentsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCommentListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlNewCommentTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAddNewCommentButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlClientLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.SaveAndNewBarButton,
            this.SaveBarButton,
            this.ClearBarButton,
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageOrderView});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(1014, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // ribbonPageOrderView
            // 
            this.ribbonPageOrderView.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageFileGroup,
            this.ribbonPageOrderGroup});
            this.ribbonPageOrderView.Name = "ribbonPageOrderView";
            this.ribbonPageOrderView.Text = "Order view";
            // 
            // ribbonPageFileGroup
            // 
            this.ribbonPageFileGroup.ItemLinks.Add(this.SaveAndNewBarButton);
            this.ribbonPageFileGroup.ItemLinks.Add(this.SaveBarButton);
            this.ribbonPageFileGroup.ItemLinks.Add(this.ClearBarButton);
            this.ribbonPageFileGroup.Name = "ribbonPageFileGroup";
            this.ribbonPageFileGroup.Text = "File";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 736);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1014, 31);
            // 
            // orderViewLayoutControl
            // 
            this.orderViewLayoutControl.Controls.Add(this.ClientLookUpEdit);
            this.orderViewLayoutControl.Controls.Add(this.addCommentButton);
            this.orderViewLayoutControl.Controls.Add(this.newCommentTextBox);
            this.orderViewLayoutControl.Controls.Add(this.commentsListBox);
            this.orderViewLayoutControl.Controls.Add(this.OrderGridControl);
            this.orderViewLayoutControl.Controls.Add(this.orderDateEdit);
            this.orderViewLayoutControl.Controls.Add(this.StatusComboBoxEdit);
            this.orderViewLayoutControl.Controls.Add(this.orderNumberTextEdit);
            this.orderViewLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderViewLayoutControl.Location = new System.Drawing.Point(0, 143);
            this.orderViewLayoutControl.Name = "orderViewLayoutControl";
            this.orderViewLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(606, 162, 405, 343);
            this.orderViewLayoutControl.Root = this.layoutControlGroup;
            this.orderViewLayoutControl.Size = new System.Drawing.Size(1014, 593);
            this.orderViewLayoutControl.TabIndex = 2;
            this.orderViewLayoutControl.Text = "layoutControl1";
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlOrderNumberTextEdit,
            this.layoutControlStatusComboBox,
            this.layoutControlDateEdit,
            this.tabbedControlOrderAndCommentGroup,
            this.splitter,
            this.layoutControlClientLookUp});
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "layoutControlGroup";
            this.layoutControlGroup.Size = new System.Drawing.Size(1014, 593);
            this.layoutControlGroup.TextVisible = false;
            // 
            // SaveAndNewBarButton
            // 
            this.SaveAndNewBarButton.Caption = "Save and New";
            this.SaveAndNewBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("SaveAndNewBarButton.Glyph")));
            this.SaveAndNewBarButton.Id = 1;
            this.SaveAndNewBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("SaveAndNewBarButton.LargeGlyph")));
            this.SaveAndNewBarButton.Name = "SaveAndNewBarButton";
            // 
            // SaveBarButton
            // 
            this.SaveBarButton.Caption = "Save";
            this.SaveBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("SaveBarButton.Glyph")));
            this.SaveBarButton.Id = 2;
            this.SaveBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("SaveBarButton.LargeGlyph")));
            this.SaveBarButton.Name = "SaveBarButton";
            // 
            // ClearBarButton
            // 
            this.ClearBarButton.Caption = "Clear";
            this.ClearBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("ClearBarButton.Glyph")));
            this.ClearBarButton.Id = 3;
            this.ClearBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ClearBarButton.LargeGlyph")));
            this.ClearBarButton.Name = "ClearBarButton";
            // 
            // orderNumberTextEdit
            // 
            this.orderNumberTextEdit.Location = new System.Drawing.Point(15, 31);
            this.orderNumberTextEdit.MenuManager = this.ribbon;
            this.orderNumberTextEdit.Name = "orderNumberTextEdit";
            this.orderNumberTextEdit.Size = new System.Drawing.Size(326, 20);
            this.orderNumberTextEdit.StyleController = this.orderViewLayoutControl;
            this.orderNumberTextEdit.TabIndex = 4;
            // 
            // layoutControlOrderNumberTextEdit
            // 
            this.layoutControlOrderNumberTextEdit.Control = this.orderNumberTextEdit;
            this.layoutControlOrderNumberTextEdit.Location = new System.Drawing.Point(0, 0);
            this.layoutControlOrderNumberTextEdit.Name = "layoutControlOrderNumberTextEdit";
            this.layoutControlOrderNumberTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlOrderNumberTextEdit.Size = new System.Drawing.Size(336, 46);
            this.layoutControlOrderNumberTextEdit.Text = "Order number";
            this.layoutControlOrderNumberTextEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlOrderNumberTextEdit.TextSize = new System.Drawing.Size(67, 13);
            // 
            // StatusComboBoxEdit
            // 
            this.StatusComboBoxEdit.Location = new System.Drawing.Point(15, 77);
            this.StatusComboBoxEdit.MenuManager = this.ribbon;
            this.StatusComboBoxEdit.Name = "StatusComboBoxEdit";
            this.StatusComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StatusComboBoxEdit.Size = new System.Drawing.Size(326, 20);
            this.StatusComboBoxEdit.StyleController = this.orderViewLayoutControl;
            this.StatusComboBoxEdit.TabIndex = 5;
            // 
            // layoutControlStatusComboBox
            // 
            this.layoutControlStatusComboBox.Control = this.StatusComboBoxEdit;
            this.layoutControlStatusComboBox.Location = new System.Drawing.Point(0, 46);
            this.layoutControlStatusComboBox.Name = "layoutControlStatusComboBox";
            this.layoutControlStatusComboBox.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlStatusComboBox.Size = new System.Drawing.Size(336, 46);
            this.layoutControlStatusComboBox.Text = "Status";
            this.layoutControlStatusComboBox.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlStatusComboBox.TextSize = new System.Drawing.Size(67, 13);
            // 
            // orderDateEdit
            // 
            this.orderDateEdit.EditValue = null;
            this.orderDateEdit.Location = new System.Drawing.Point(15, 123);
            this.orderDateEdit.MenuManager = this.ribbon;
            this.orderDateEdit.Name = "orderDateEdit";
            this.orderDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.orderDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.orderDateEdit.Size = new System.Drawing.Size(326, 20);
            this.orderDateEdit.StyleController = this.orderViewLayoutControl;
            this.orderDateEdit.TabIndex = 6;
            // 
            // layoutControlDateEdit
            // 
            this.layoutControlDateEdit.Control = this.orderDateEdit;
            this.layoutControlDateEdit.Location = new System.Drawing.Point(0, 92);
            this.layoutControlDateEdit.Name = "layoutControlDateEdit";
            this.layoutControlDateEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlDateEdit.Size = new System.Drawing.Size(336, 46);
            this.layoutControlDateEdit.Text = "Date";
            this.layoutControlDateEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlDateEdit.TextSize = new System.Drawing.Size(67, 13);
            // 
            // OrderGridControl
            // 
            this.OrderGridControl.Location = new System.Drawing.Point(365, 46);
            this.OrderGridControl.MainView = this.orderGridView;
            this.OrderGridControl.MenuManager = this.ribbon;
            this.OrderGridControl.Name = "OrderGridControl";
            this.OrderGridControl.Size = new System.Drawing.Size(625, 523);
            this.OrderGridControl.TabIndex = 8;
            this.OrderGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.orderGridView});
            // 
            // orderGridView
            // 
            this.orderGridView.GridControl = this.OrderGridControl;
            this.orderGridView.Name = "orderGridView";
            // 
            // tabbedControlOrderAndCommentGroup
            // 
            this.tabbedControlOrderAndCommentGroup.Location = new System.Drawing.Point(341, 0);
            this.tabbedControlOrderAndCommentGroup.Name = "tabbedControlOrderAndCommentGroup";
            this.tabbedControlOrderAndCommentGroup.SelectedTabPage = this.layoutControlDataGrid;
            this.tabbedControlOrderAndCommentGroup.SelectedTabPageIndex = 0;
            this.tabbedControlOrderAndCommentGroup.Size = new System.Drawing.Size(653, 573);
            this.tabbedControlOrderAndCommentGroup.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlDataGrid,
            this.layoutControlCommentsList});
            // 
            // layoutControlDataGrid
            // 
            this.layoutControlDataGrid.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlOrderGrid});
            this.layoutControlDataGrid.Location = new System.Drawing.Point(0, 0);
            this.layoutControlDataGrid.Name = "layoutControlDataGrid";
            this.layoutControlDataGrid.Size = new System.Drawing.Size(629, 527);
            this.layoutControlDataGrid.Text = "Order";
            // 
            // layoutControlOrderGrid
            // 
            this.layoutControlOrderGrid.Control = this.OrderGridControl;
            this.layoutControlOrderGrid.Location = new System.Drawing.Point(0, 0);
            this.layoutControlOrderGrid.Name = "layoutControlOrderGrid";
            this.layoutControlOrderGrid.Size = new System.Drawing.Size(629, 527);
            this.layoutControlOrderGrid.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlOrderGrid.TextVisible = false;
            // 
            // commentsListBox
            // 
            this.commentsListBox.Location = new System.Drawing.Point(365, 46);
            this.commentsListBox.Name = "commentsListBox";
            this.commentsListBox.Size = new System.Drawing.Size(625, 414);
            this.commentsListBox.StyleController = this.orderViewLayoutControl;
            this.commentsListBox.TabIndex = 9;
            // 
            // layoutControlCommentsList
            // 
            this.layoutControlCommentsList.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlCommentListBox,
            this.layoutControlNewCommentTextBox,
            this.layoutControlAddNewCommentButton});
            this.layoutControlCommentsList.Location = new System.Drawing.Point(0, 0);
            this.layoutControlCommentsList.Name = "layoutControlCommentsList";
            this.layoutControlCommentsList.Size = new System.Drawing.Size(629, 527);
            this.layoutControlCommentsList.Text = "Comments";
            // 
            // layoutControlCommentListBox
            // 
            this.layoutControlCommentListBox.Control = this.commentsListBox;
            this.layoutControlCommentListBox.Location = new System.Drawing.Point(0, 0);
            this.layoutControlCommentListBox.Name = "layoutControlCommentListBox";
            this.layoutControlCommentListBox.Size = new System.Drawing.Size(629, 418);
            this.layoutControlCommentListBox.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlCommentListBox.TextVisible = false;
            // 
            // newCommentTextBox
            // 
            this.newCommentTextBox.Location = new System.Drawing.Point(365, 464);
            this.newCommentTextBox.Multiline = true;
            this.newCommentTextBox.Name = "newCommentTextBox";
            this.newCommentTextBox.Size = new System.Drawing.Size(473, 105);
            this.newCommentTextBox.TabIndex = 10;
            // 
            // layoutControlNewCommentTextBox
            // 
            this.layoutControlNewCommentTextBox.Control = this.newCommentTextBox;
            this.layoutControlNewCommentTextBox.Location = new System.Drawing.Point(0, 418);
            this.layoutControlNewCommentTextBox.MaxSize = new System.Drawing.Size(477, 109);
            this.layoutControlNewCommentTextBox.MinSize = new System.Drawing.Size(477, 109);
            this.layoutControlNewCommentTextBox.Name = "layoutControlNewCommentTextBox";
            this.layoutControlNewCommentTextBox.Size = new System.Drawing.Size(477, 109);
            this.layoutControlNewCommentTextBox.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlNewCommentTextBox.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlNewCommentTextBox.TextVisible = false;
            // 
            // addCommentButton
            // 
            this.addCommentButton.Location = new System.Drawing.Point(842, 464);
            this.addCommentButton.Name = "addCommentButton";
            this.addCommentButton.Size = new System.Drawing.Size(148, 105);
            this.addCommentButton.StyleController = this.orderViewLayoutControl;
            this.addCommentButton.TabIndex = 11;
            this.addCommentButton.Text = "Add comment";
            // 
            // layoutControlAddNewCommentButton
            // 
            this.layoutControlAddNewCommentButton.Control = this.addCommentButton;
            this.layoutControlAddNewCommentButton.Location = new System.Drawing.Point(477, 418);
            this.layoutControlAddNewCommentButton.MaxSize = new System.Drawing.Size(152, 109);
            this.layoutControlAddNewCommentButton.MinSize = new System.Drawing.Size(152, 109);
            this.layoutControlAddNewCommentButton.Name = "layoutControlAddNewCommentButton";
            this.layoutControlAddNewCommentButton.Size = new System.Drawing.Size(152, 109);
            this.layoutControlAddNewCommentButton.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlAddNewCommentButton.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlAddNewCommentButton.TextVisible = false;
            // 
            // splitter
            // 
            this.splitter.AllowHotTrack = true;
            this.splitter.Location = new System.Drawing.Point(336, 0);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(5, 573);
            // 
            // ClientLookUpEdit
            // 
            this.ClientLookUpEdit.Location = new System.Drawing.Point(15, 169);
            this.ClientLookUpEdit.MenuManager = this.ribbon;
            this.ClientLookUpEdit.Name = "ClientLookUpEdit";
            this.ClientLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ClientLookUpEdit.Size = new System.Drawing.Size(326, 20);
            this.ClientLookUpEdit.StyleController = this.orderViewLayoutControl;
            this.ClientLookUpEdit.TabIndex = 12;
            // 
            // layoutControlClientLookUp
            // 
            this.layoutControlClientLookUp.Control = this.ClientLookUpEdit;
            this.layoutControlClientLookUp.Location = new System.Drawing.Point(0, 138);
            this.layoutControlClientLookUp.Name = "layoutControlClientLookUp";
            this.layoutControlClientLookUp.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlClientLookUp.Size = new System.Drawing.Size(336, 435);
            this.layoutControlClientLookUp.Text = "Client";
            this.layoutControlClientLookUp.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlClientLookUp.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ribbonPageOrderGroup
            // 
            this.ribbonPageOrderGroup.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageOrderGroup.Name = "ribbonPageOrderGroup";
            this.ribbonPageOrderGroup.Text = "Order";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Remove(Revert)";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // OrderViewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 767);
            this.Controls.Add(this.orderViewLayoutControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "OrderViewList";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "OrderViewList";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderViewLayoutControl)).EndInit();
            this.orderViewLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderNumberTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlStatusComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlOrderAndCommentGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCommentsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCommentListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlNewCommentTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAddNewCommentButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlClientLookUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageOrderView;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageFileGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem SaveAndNewBarButton;
        private DevExpress.XtraBars.BarButtonItem SaveBarButton;
        private DevExpress.XtraBars.BarButtonItem ClearBarButton;
        private DevExpress.XtraLayout.LayoutControl orderViewLayoutControl;
        private DevExpress.XtraGrid.GridControl OrderGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView orderGridView;
        private DevExpress.XtraEditors.DateEdit orderDateEdit;
        private DevExpress.XtraEditors.ComboBoxEdit StatusComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit orderNumberTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlOrderNumberTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlStatusComboBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlDateEdit;
        private DevExpress.XtraEditors.SimpleButton addCommentButton;
        private System.Windows.Forms.TextBox newCommentTextBox;
        private DevExpress.XtraEditors.ListBoxControl commentsListBox;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlOrderAndCommentGroup;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlCommentsList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlCommentListBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlNewCommentTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlAddNewCommentButton;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlDataGrid;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlOrderGrid;
        private DevExpress.XtraLayout.SplitterItem splitter;
        private DevExpress.XtraEditors.LookUpEdit ClientLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlClientLookUp;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageOrderGroup;
    }
}