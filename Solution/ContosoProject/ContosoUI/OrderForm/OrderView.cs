﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using Domain.Entities.Comments;

namespace ContosoUI.OrderForm
{
    public partial class OrderForm : DevExpress.XtraBars.Ribbon.RibbonForm, IOrderView
    {
        private OrderPresenter _presenter;
        private BindingSource binding;

        public OrderForm()
        {
            InitializeComponent();
            _presenter = new OrderPresenter(new OrderModel(), this);
        }

        public OrderForm(int id)
        {
            InitializeComponent();
            _presenter = new OrderPresenter(new OrderModel(), this);
            _presenter.UseOrderWithID(id);
        }

        private void OrderViewList_Load(object sender, EventArgs e)
        {
            binding = new BindingSource { DataSource = _presenter };

            clientLookUpEdit.Properties.DataSource = _presenter.ClientList;
            orderStatusLookUpEdit.Properties.DataSource = _presenter.StatusEnum;
            orderNumberTextEdit.DataBindings.Add("EditValue", binding, "OrderNumber");
            
            orderDateEdit.DataBindings.Add("EditValue", binding, "Date");
            orderGridControl.DataBindings.Add("DataSource", binding, "OrderItems");
            commentsListBox.DataBindings.Add("DataSource", binding, "Comments");

            repositoryProductLookUpEdit.DataSource = _presenter.Products;

            SetActivityOfComments();
        }

    private void SetActivityOfComments()
        {
            if (orderNumberTextEdit.Text == string.Empty)
            {
                commentsListBox.Enabled = false;
                newCommentTextBox.Enabled = false;
                addCommentButton.Enabled = false;
            }
            else
            {
                commentsListBox.Enabled = true;
                newCommentTextBox.Enabled = true;
                addCommentButton.Enabled = true;
            }
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void orderSaveBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            binding.EndEdit();
            _presenter.Save();
        }

        private void orderSaveAndNewBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            binding.EndEdit();
            _presenter.SaveAndNew();
        }

        private void ClearBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _presenter.New();
        }

        public void ShowView()
        {
            Show();
        }

        private void addCommentButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(newCommentTextBox.Text))
            {
                Comment comment = new Comment() { Author = null, EntityType = EntityType.Order, Text = newCommentTextBox.Text };
                _presenter.Comments.Add(comment);
                newCommentTextBox.Text = string.Empty;
                _presenter.Save();
            }
        }

        private void orderNumberTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetActivityOfComments();
        }

        private void orderGridControl_Click(object sender, EventArgs e)
        {

        }

        private void orderGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
        }
    }
}