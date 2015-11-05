﻿using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Images;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using Domain.Entities.Comments;
using Domain.Entities.Users;

namespace ContosoUI.UserForm
{
    public partial class UserForm : RibbonForm, IUserView
    {
        private readonly UserPresenter _presenter;
        BindingSource binding = new BindingSource();

        public UserForm()
        {
            InitializeComponent();
            _presenter = new UserPresenter(this, new UserModel());
        }

        public UserForm(int id)
        {
            InitializeComponent();
            _presenter = new UserPresenter(this, new UserModel());
            _presenter.GetUser(id);
        }

        private void ShowDependentOnRole(Role role)
        {
            if (!role.Permissions.Where(x => x.Title == "Edit User").Any())
            {
                barSaveButton.Visibility = BarItemVisibility.Never;
                barSaveAndNewButton.Visibility = BarItemVisibility.Never;
                barNewButton.Visibility = BarItemVisibility.Never;
                userStateButton.Visibility = BarItemVisibility.Never;
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            binding.DataSource = _presenter;


            roleLookUpEdit.Properties.DataSource = _presenter.RoleList;
            roleLookUpEdit.Properties.ValueMember = "Id";
            roleLookUpEdit.Properties.DisplayMember = "Title";

            loginTextEdit.DataBindings.Add("EditValue", binding, "Login");
            firstNameTextEdit.DataBindings.Add("EditValue", binding, "FirstName");
            middleNameTextEdit.DataBindings.Add("EditValue", binding, "MiddleName");
            lastNameTextEdit.DataBindings.Add("EditValue", binding, "LastName");
            passwordTextEdit.DataBindings.Add("EditValue", binding, "Password");
            roleLookUpEdit.DataBindings.Add("EditValue", binding, "RoleID");
            permissionListBoxControl.DataBindings.Add("DataSource", binding, "Permissions");
            commentsListBoxControl.DataBindings.Add("DataSource", binding, "Comments");
            SetStateButtonState();
        }

        private void stateButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            _presenter.State = !_presenter.State;
            SetStateButtonState();
        }

       private void SetStateButtonState()
        {
            if (_presenter.State)
            {
                userStateButton.Caption = "Remove";
                userStateButton.LargeGlyph = ImageResourceCache.Default.GetImage("images/edit/delete_32x32.png");
            }
            else
            {
                userStateButton.Caption = "Activate";
                userStateButton.LargeGlyph = ImageResourceCache.Default.GetImage("images/actions/apply_32x32.png");
            }
        }
    

        private void barSaveButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            binding.EndEdit();
            _presenter.Save();
        }

        private void barSaveAndNewButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            binding.EndEdit();
            _presenter.SaveAndNew();
        }

        private void addCommentButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(newCommentTextBox.Text))
            {
                _presenter.Comments.Add(new Comment() {Author = Program.AuthUser, EntityType = EntityType.User, Text = newCommentTextBox.Text});
                newCommentTextBox.Text = string.Empty;
            }
        }

        private void newCommentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                addCommentButton_Click(this, e);
            }
        }

        private void roleLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            var role = roleLookUpEdit.EditValue as Role;
            if (role != null) _presenter.RoleID = role.Id;
        }

        private void barNewButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            _presenter.New();
            SetStateButtonState();
        }

        private void roleLookUpEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            binding.EndEdit();
        }
    }
}