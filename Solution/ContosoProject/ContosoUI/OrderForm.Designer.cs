namespace ContosoUI
{
    partial class OrderForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            this.orderNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.orderDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.orderItemsGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.orderNumberLabel = new DevExpress.XtraEditors.LabelControl();
            this.commentsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.isActiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.statusLabel = new DevExpress.XtraEditors.LabelControl();
            this.dateLabel = new DevExpress.XtraEditors.LabelControl();
            this.orderItemsLabel = new DevExpress.XtraEditors.LabelControl();
            this.commentsLabel = new DevExpress.XtraEditors.LabelControl();
            this.totalSumLabel = new DevExpress.XtraEditors.LabelControl();
            this.newCommentTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.addCommentButton = new DevExpress.XtraEditors.SimpleButton();
            this.closeButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveCloseButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.UAHLabel = new DevExpress.XtraEditors.LabelControl();
            this.sumTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.titileGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.priceGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isActiveGgridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCommentTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // orderNumberTextEdit
            // 
            this.orderNumberTextEdit.Location = new System.Drawing.Point(40, 64);
            this.orderNumberTextEdit.Name = "orderNumberTextEdit";
            this.orderNumberTextEdit.Size = new System.Drawing.Size(172, 20);
            this.orderNumberTextEdit.TabIndex = 0;
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Location = new System.Drawing.Point(272, 12);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(256, 22);
            this.dropDownButton1.StyleController = this.layoutControl1;
            this.dropDownButton1.TabIndex = 2;
            this.dropDownButton1.Text = "statusDropDownButton";
            // 
            // orderDateEdit
            // 
            this.orderDateEdit.EditValue = null;
            this.orderDateEdit.Location = new System.Drawing.Point(109, 146);
            this.orderDateEdit.Name = "orderDateEdit";
            this.orderDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.orderDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.orderDateEdit.Size = new System.Drawing.Size(159, 20);
            this.orderDateEdit.StyleController = this.layoutControl1;
            this.orderDateEdit.TabIndex = 5;
            // 
            // orderItemsGridControl
            // 
            this.orderItemsGridControl.Location = new System.Drawing.Point(40, 133);
            this.orderItemsGridControl.MainView = this.gridView1;
            this.orderItemsGridControl.Name = "orderItemsGridControl";
            this.orderItemsGridControl.Size = new System.Drawing.Size(400, 200);
            this.orderItemsGridControl.TabIndex = 6;
            this.orderItemsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.titileGridColumn,
            this.quantityGridColumn,
            this.priceGridColumn,
            this.isActiveGgridColumn});
            this.gridView1.GridControl = this.orderItemsGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // orderNumberLabel
            // 
            this.orderNumberLabel.Location = new System.Drawing.Point(40, 36);
            this.orderNumberLabel.Name = "orderNumberLabel";
            this.orderNumberLabel.Size = new System.Drawing.Size(67, 13);
            this.orderNumberLabel.TabIndex = 7;
            this.orderNumberLabel.Text = "Order number";
            // 
            // commentsRichTextBox
            // 
            this.commentsRichTextBox.Location = new System.Drawing.Point(109, 12);
            this.commentsRichTextBox.Name = "commentsRichTextBox";
            this.commentsRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.commentsRichTextBox.Size = new System.Drawing.Size(159, 130);
            this.commentsRichTextBox.TabIndex = 8;
            this.commentsRichTextBox.Text = "";
            // 
            // isActiveCheckEdit
            // 
            this.isActiveCheckEdit.Location = new System.Drawing.Point(40, 411);
            this.isActiveCheckEdit.Name = "isActiveCheckEdit";
            this.isActiveCheckEdit.Properties.Caption = "Active";
            this.isActiveCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.isActiveCheckEdit.TabIndex = 9;
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(347, 36);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(31, 13);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.Text = "Status";
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(272, 146);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(23, 13);
            this.dateLabel.StyleController = this.layoutControl1;
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "Date";
            // 
            // orderItemsLabel
            // 
            this.orderItemsLabel.Location = new System.Drawing.Point(40, 114);
            this.orderItemsLabel.Name = "orderItemsLabel";
            this.orderItemsLabel.Size = new System.Drawing.Size(56, 13);
            this.orderItemsLabel.TabIndex = 12;
            this.orderItemsLabel.Text = "Order items";
            // 
            // commentsLabel
            // 
            this.commentsLabel.Location = new System.Drawing.Point(489, 114);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(50, 13);
            this.commentsLabel.TabIndex = 13;
            this.commentsLabel.Text = "Comments";
            // 
            // totalSumLabel
            // 
            this.totalSumLabel.Location = new System.Drawing.Point(40, 349);
            this.totalSumLabel.Name = "totalSumLabel";
            this.totalSumLabel.Size = new System.Drawing.Size(28, 13);
            this.totalSumLabel.TabIndex = 14;
            this.totalSumLabel.Text = "Total:";
            // 
            // newCommentTextEdit
            // 
            this.newCommentTextEdit.Location = new System.Drawing.Point(109, 280);
            this.newCommentTextEdit.Name = "newCommentTextEdit";
            this.newCommentTextEdit.Size = new System.Drawing.Size(159, 20);
            this.newCommentTextEdit.StyleController = this.layoutControl1;
            this.newCommentTextEdit.TabIndex = 15;
            // 
            // addCommentButton
            // 
            this.addCommentButton.Location = new System.Drawing.Point(272, 280);
            this.addCommentButton.Name = "addCommentButton";
            this.addCommentButton.Size = new System.Drawing.Size(256, 22);
            this.addCommentButton.StyleController = this.layoutControl1;
            this.addCommentButton.TabIndex = 30;
            this.addCommentButton.Text = "+";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 332);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(256, 22);
            this.closeButton.StyleController = this.layoutControl1;
            this.closeButton.TabIndex = 33;
            this.closeButton.Text = "Close";
            // 
            // saveCloseButton
            // 
            this.saveCloseButton.Location = new System.Drawing.Point(272, 306);
            this.saveCloseButton.Name = "saveCloseButton";
            this.saveCloseButton.Size = new System.Drawing.Size(256, 22);
            this.saveCloseButton.StyleController = this.layoutControl1;
            this.saveCloseButton.TabIndex = 32;
            this.saveCloseButton.Text = "Save and Close";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 306);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(256, 22);
            this.saveButton.StyleController = this.layoutControl1;
            this.saveButton.TabIndex = 31;
            this.saveButton.Text = "Save";
            // 
            // UAHLabel
            // 
            this.UAHLabel.Location = new System.Drawing.Point(254, 349);
            this.UAHLabel.Name = "UAHLabel";
            this.UAHLabel.Size = new System.Drawing.Size(21, 13);
            this.UAHLabel.TabIndex = 34;
            this.UAHLabel.Text = "UAH";
            // 
            // sumTextEdit
            // 
            this.sumTextEdit.Location = new System.Drawing.Point(76, 346);
            this.sumTextEdit.Name = "sumTextEdit";
            this.sumTextEdit.Size = new System.Drawing.Size(172, 20);
            this.sumTextEdit.TabIndex = 35;
            // 
            // titileGridColumn
            // 
            this.titileGridColumn.Caption = "Title";
            this.titileGridColumn.Name = "titileGridColumn";
            this.titileGridColumn.Visible = true;
            this.titileGridColumn.VisibleIndex = 0;
            // 
            // quantityGridColumn
            // 
            this.quantityGridColumn.Caption = "Quantity";
            this.quantityGridColumn.Name = "quantityGridColumn";
            this.quantityGridColumn.Visible = true;
            this.quantityGridColumn.VisibleIndex = 1;
            // 
            // priceGridColumn
            // 
            this.priceGridColumn.Caption = "Price";
            this.priceGridColumn.Name = "priceGridColumn";
            this.priceGridColumn.Visible = true;
            this.priceGridColumn.VisibleIndex = 2;
            // 
            // isActiveGgridColumn
            // 
            this.isActiveGgridColumn.Caption = "Active";
            this.isActiveGgridColumn.Name = "isActiveGgridColumn";
            this.isActiveGgridColumn.Visible = true;
            this.isActiveGgridColumn.VisibleIndex = 3;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.saveButton);
            this.layoutControl1.Controls.Add(this.closeButton);
            this.layoutControl1.Controls.Add(this.saveCloseButton);
            this.layoutControl1.Controls.Add(this.commentsRichTextBox);
            this.layoutControl1.Controls.Add(this.dropDownButton1);
            this.layoutControl1.Controls.Add(this.orderDateEdit);
            this.layoutControl1.Controls.Add(this.addCommentButton);
            this.layoutControl1.Controls.Add(this.dateLabel);
            this.layoutControl1.Controls.Add(this.newCommentTextEdit);
            this.layoutControl1.Location = new System.Drawing.Point(0, 192);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(525, 256, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(540, 366);
            this.layoutControl1.TabIndex = 36;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 50D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 50D;
            this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 50D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition2.Height = 50D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition3.Height = 26D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition4.Height = 26D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition5.Height = 26D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.AutoSize;
            this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5});
            this.layoutControlGroup1.Size = new System.Drawing.Size(540, 366);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.commentsRichTextBox;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(260, 134);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dropDownButton1;
            this.layoutControlItem2.Location = new System.Drawing.Point(260, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(260, 134);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.orderDateEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 134);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem3.Size = new System.Drawing.Size(260, 134);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dateLabel;
            this.layoutControlItem4.Location = new System.Drawing.Point(260, 134);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem4.Size = new System.Drawing.Size(260, 134);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.newCommentTextEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 268);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem5.Size = new System.Drawing.Size(260, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.addCommentButton;
            this.layoutControlItem6.Location = new System.Drawing.Point(260, 268);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem6.Size = new System.Drawing.Size(260, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.saveButton;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 294);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem7.Size = new System.Drawing.Size(260, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.saveCloseButton;
            this.layoutControlItem8.Location = new System.Drawing.Point(260, 294);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem8.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem8.Size = new System.Drawing.Size(260, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.closeButton;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 320);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem9.Size = new System.Drawing.Size(260, 26);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 561);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.isActiveCheckEdit);
            this.Controls.Add(this.sumTextEdit);
            this.Controls.Add(this.UAHLabel);
            this.Controls.Add(this.totalSumLabel);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.orderItemsLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.orderNumberLabel);
            this.Controls.Add(this.orderItemsGridControl);
            this.Controls.Add(this.orderNumberTextEdit);
            this.Name = "OrderForm";
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCommentTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit orderNumberTextEdit;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraEditors.DateEdit orderDateEdit;
        private DevExpress.XtraGrid.GridControl orderItemsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl orderNumberLabel;
        private System.Windows.Forms.RichTextBox commentsRichTextBox;
        private DevExpress.XtraEditors.CheckEdit isActiveCheckEdit;
        private DevExpress.XtraEditors.LabelControl statusLabel;
        private DevExpress.XtraEditors.LabelControl dateLabel;
        private DevExpress.XtraEditors.LabelControl orderItemsLabel;
        private DevExpress.XtraEditors.LabelControl commentsLabel;
        private DevExpress.XtraEditors.LabelControl totalSumLabel;
        private DevExpress.XtraEditors.TextEdit newCommentTextEdit;
        private DevExpress.XtraEditors.SimpleButton addCommentButton;
        private DevExpress.XtraEditors.SimpleButton closeButton;
        private DevExpress.XtraEditors.SimpleButton saveCloseButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.LabelControl UAHLabel;
        private DevExpress.XtraEditors.TextEdit sumTextEdit;
        private DevExpress.XtraGrid.Columns.GridColumn titileGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn quantityGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn priceGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn isActiveGgridColumn;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
    }
}