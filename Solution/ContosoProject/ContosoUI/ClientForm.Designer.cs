namespace ContosoUI
{
    partial class ClientForm
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.adressLabel = new System.Windows.Forms.Label();
            this.telephonesLabel = new System.Windows.Forms.Label();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.ordersLabel = new System.Windows.Forms.Label();
            this.adressRichTextBox = new System.Windows.Forms.RichTextBox();
            this.telephonesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.commentsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ordersGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.orderNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveCloseButton = new DevExpress.XtraEditors.SimpleButton();
            this.closeButton = new DevExpress.XtraEditors.SimpleButton();
            this.isActiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.newCommentTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.addCommentButton = new DevExpress.XtraEditors.SimpleButton();
            this.firstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.middleNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cityTextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCommentTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(41, 42);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First name";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(298, 42);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(66, 13);
            this.middleNameLabel.TabIndex = 1;
            this.middleNameLabel.Text = "Middle name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(553, 42);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last name";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(42, 103);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(26, 13);
            this.cityLabel.TabIndex = 3;
            this.cityLabel.Text = "City";
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Location = new System.Drawing.Point(298, 100);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(40, 13);
            this.adressLabel.TabIndex = 4;
            this.adressLabel.Text = "Adress";
            // 
            // telephonesLabel
            // 
            this.telephonesLabel.AutoSize = true;
            this.telephonesLabel.Location = new System.Drawing.Point(553, 100);
            this.telephonesLabel.Name = "telephonesLabel";
            this.telephonesLabel.Size = new System.Drawing.Size(62, 13);
            this.telephonesLabel.TabIndex = 5;
            this.telephonesLabel.Text = "Telephones";
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Location = new System.Drawing.Point(496, 239);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(57, 13);
            this.commentsLabel.TabIndex = 6;
            this.commentsLabel.Text = "Comments";
            // 
            // ordersLabel
            // 
            this.ordersLabel.AutoSize = true;
            this.ordersLabel.Location = new System.Drawing.Point(43, 239);
            this.ordersLabel.Name = "ordersLabel";
            this.ordersLabel.Size = new System.Drawing.Size(40, 13);
            this.ordersLabel.TabIndex = 7;
            this.ordersLabel.Text = "Orders";
            // 
            // adressRichTextBox
            // 
            this.adressRichTextBox.Location = new System.Drawing.Point(301, 128);
            this.adressRichTextBox.Name = "adressRichTextBox";
            this.adressRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.adressRichTextBox.Size = new System.Drawing.Size(230, 82);
            this.adressRichTextBox.TabIndex = 13;
            this.adressRichTextBox.Text = "";
            // 
            // telephonesRichTextBox
            // 
            this.telephonesRichTextBox.Location = new System.Drawing.Point(556, 125);
            this.telephonesRichTextBox.Name = "telephonesRichTextBox";
            this.telephonesRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.telephonesRichTextBox.Size = new System.Drawing.Size(234, 82);
            this.telephonesRichTextBox.TabIndex = 14;
            this.telephonesRichTextBox.Text = "";
            // 
            // commentsRichTextBox
            // 
            this.commentsRichTextBox.Location = new System.Drawing.Point(499, 265);
            this.commentsRichTextBox.Name = "commentsRichTextBox";
            this.commentsRichTextBox.Size = new System.Drawing.Size(364, 182);
            this.commentsRichTextBox.TabIndex = 18;
            this.commentsRichTextBox.Text = "";
            // 
            // ordersGridControl
            // 
            this.ordersGridControl.Location = new System.Drawing.Point(46, 265);
            this.ordersGridControl.MainView = this.gridView1;
            this.ordersGridControl.Name = "ordersGridControl";
            this.ordersGridControl.Size = new System.Drawing.Size(439, 208);
            this.ordersGridControl.TabIndex = 23;
            this.ordersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.orderNumberGridColumn,
            this.statusGridColumn,
            this.dateGridColumn});
            this.gridView1.GridControl = this.ordersGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // orderNumberGridColumn
            // 
            this.orderNumberGridColumn.Caption = "Order number";
            this.orderNumberGridColumn.Name = "orderNumberGridColumn";
            this.orderNumberGridColumn.Visible = true;
            this.orderNumberGridColumn.VisibleIndex = 0;
            // 
            // statusGridColumn
            // 
            this.statusGridColumn.Caption = "Status";
            this.statusGridColumn.Name = "statusGridColumn";
            this.statusGridColumn.Visible = true;
            this.statusGridColumn.VisibleIndex = 1;
            // 
            // dateGridColumn
            // 
            this.dateGridColumn.Caption = "Date";
            this.dateGridColumn.Name = "dateGridColumn";
            this.dateGridColumn.Visible = true;
            this.dateGridColumn.VisibleIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(566, 504);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(95, 22);
            this.saveButton.TabIndex = 24;
            this.saveButton.Text = "Save";
            // 
            // saveCloseButton
            // 
            this.saveCloseButton.Location = new System.Drawing.Point(667, 504);
            this.saveCloseButton.Name = "saveCloseButton";
            this.saveCloseButton.Size = new System.Drawing.Size(95, 22);
            this.saveCloseButton.TabIndex = 25;
            this.saveCloseButton.Text = "Save and Close";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(768, 504);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(95, 22);
            this.closeButton.TabIndex = 26;
            this.closeButton.Text = "Close";
            // 
            // isActiveCheckEdit
            // 
            this.isActiveCheckEdit.Location = new System.Drawing.Point(44, 501);
            this.isActiveCheckEdit.Name = "isActiveCheckEdit";
            this.isActiveCheckEdit.Properties.Caption = "Active";
            this.isActiveCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.isActiveCheckEdit.TabIndex = 27;
            // 
            // newCommentTextEdit
            // 
            this.newCommentTextEdit.Location = new System.Drawing.Point(499, 454);
            this.newCommentTextEdit.Name = "newCommentTextEdit";
            this.newCommentTextEdit.Size = new System.Drawing.Size(331, 20);
            this.newCommentTextEdit.TabIndex = 28;
            // 
            // addCommentButton
            // 
            this.addCommentButton.Location = new System.Drawing.Point(836, 453);
            this.addCommentButton.Name = "addCommentButton";
            this.addCommentButton.Size = new System.Drawing.Size(28, 22);
            this.addCommentButton.TabIndex = 29;
            this.addCommentButton.Text = "+";
            // 
            // firstNameTextEdit
            // 
            this.firstNameTextEdit.Location = new System.Drawing.Point(44, 64);
            this.firstNameTextEdit.Name = "firstNameTextEdit";
            this.firstNameTextEdit.Size = new System.Drawing.Size(250, 20);
            this.firstNameTextEdit.TabIndex = 30;
            // 
            // middleNameTextEdit
            // 
            this.middleNameTextEdit.Location = new System.Drawing.Point(301, 64);
            this.middleNameTextEdit.Name = "middleNameTextEdit";
            this.middleNameTextEdit.Size = new System.Drawing.Size(250, 20);
            this.middleNameTextEdit.TabIndex = 31;
            // 
            // lastNameTextEdit
            // 
            this.lastNameTextEdit.Location = new System.Drawing.Point(556, 64);
            this.lastNameTextEdit.Name = "lastNameTextEdit";
            this.lastNameTextEdit.Size = new System.Drawing.Size(250, 20);
            this.lastNameTextEdit.TabIndex = 32;
            // 
            // cityTextEdit
            // 
            this.cityTextEdit.Location = new System.Drawing.Point(44, 125);
            this.cityTextEdit.Name = "cityTextEdit";
            this.cityTextEdit.Size = new System.Drawing.Size(230, 20);
            this.cityTextEdit.TabIndex = 33;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 561);
            this.Controls.Add(this.cityTextEdit);
            this.Controls.Add(this.lastNameTextEdit);
            this.Controls.Add(this.middleNameTextEdit);
            this.Controls.Add(this.firstNameTextEdit);
            this.Controls.Add(this.addCommentButton);
            this.Controls.Add(this.newCommentTextEdit);
            this.Controls.Add(this.isActiveCheckEdit);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveCloseButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ordersGridControl);
            this.Controls.Add(this.commentsRichTextBox);
            this.Controls.Add(this.telephonesRichTextBox);
            this.Controls.Add(this.adressRichTextBox);
            this.Controls.Add(this.ordersLabel);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.telephonesLabel);
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "ClientForm";
            this.Text = "Client form";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCommentTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.Label telephonesLabel;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.Label ordersLabel;
        private System.Windows.Forms.RichTextBox adressRichTextBox;
        private System.Windows.Forms.RichTextBox telephonesRichTextBox;
        private System.Windows.Forms.RichTextBox commentsRichTextBox;
        private DevExpress.XtraGrid.GridControl ordersGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton saveCloseButton;
        private DevExpress.XtraEditors.SimpleButton closeButton;
        private DevExpress.XtraEditors.CheckEdit isActiveCheckEdit;
        private DevExpress.XtraEditors.TextEdit newCommentTextEdit;
        private DevExpress.XtraEditors.SimpleButton addCommentButton;
        private DevExpress.XtraEditors.TextEdit firstNameTextEdit;
        private DevExpress.XtraEditors.TextEdit middleNameTextEdit;
        private DevExpress.XtraEditors.TextEdit lastNameTextEdit;
        private DevExpress.XtraEditors.TextEdit cityTextEdit;
        private DevExpress.XtraGrid.Columns.GridColumn orderNumberGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn statusGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn dateGridColumn;
    }
}