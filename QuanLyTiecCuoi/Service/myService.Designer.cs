﻿namespace QuanLyTiecCuoi.Service
{
    partial class myService
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new QuanLyTiecCuoi.UIDesign.RJButton();
            this.btnEdit = new QuanLyTiecCuoi.UIDesign.RJButton();
            this.btnAdd = new QuanLyTiecCuoi.UIDesign.RJButton();
            this.searchServicename = new QuanLyTiecCuoi.UIDesign.TextBoxTemplate();
            this.Confirm = new System.Windows.Forms.Button();
            this.dataGridViewService = new System.Windows.Forms.DataGridView();
            this.ServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.searchServicename);
            this.panel2.Controls.Add(this.Confirm);
            this.panel2.Controls.Add(this.dataGridViewService);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(979, 681);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.BorderRadius1 = 10;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.BorderSize1 = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(766, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 40);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Xóa Dịch Vụ";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEdit.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEdit.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnEdit.BorderRadius = 10;
            this.btnEdit.BorderRadius1 = 10;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.BorderSize1 = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(567, 16);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(170, 40);
            this.btnEdit.TabIndex = 48;
            this.btnEdit.Text = "Chỉnh Sửa";
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderRadius1 = 10;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.BorderSize1 = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(369, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 40);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Thêm Dịch Vụ";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // searchServicename
            // 
            this.searchServicename.BackColor = System.Drawing.SystemColors.Window;
            this.searchServicename.BorderColor = System.Drawing.Color.RoyalBlue;
            this.searchServicename.BorderFocusColor = System.Drawing.Color.Navy;
            this.searchServicename.BorderRadius = 0;
            this.searchServicename.BorderSize = 2;
            this.searchServicename.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchServicename.ForeColor = System.Drawing.Color.Black;
            this.searchServicename.Location = new System.Drawing.Point(49, 14);
            this.searchServicename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchServicename.Multiline = false;
            this.searchServicename.Name = "searchServicename";
            this.searchServicename.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.searchServicename.PasswordChar = false;
            this.searchServicename.PlaceholderColor = System.Drawing.Color.DimGray;
            this.searchServicename.PlaceholderText = "Tìm Dịch Vụ";
            this.searchServicename.Size = new System.Drawing.Size(256, 37);
            this.searchServicename.TabIndex = 46;
            this.searchServicename.Texts = "";
            this.searchServicename.UnderlinedStyle = true;
            this.searchServicename._TextChanged += new System.EventHandler(this.searchFoodname__TextChanged);
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.Color.RoyalBlue;
            this.Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.Confirm.ForeColor = System.Drawing.Color.White;
            this.Confirm.Location = new System.Drawing.Point(362, 15);
            this.Confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(178, 50);
            this.Confirm.TabIndex = 44;
            this.Confirm.Text = "Xác Nhận";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Visible = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // dataGridViewService
            // 
            this.dataGridViewService.AllowUserToAddRows = false;
            this.dataGridViewService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewService.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewService.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewService.ColumnHeadersHeight = 70;
            this.dataGridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceId,
            this.ServiceName,
            this.ServiceType,
            this.ServicePrice});
            this.dataGridViewService.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewService.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewService.EnableHeadersVisualStyles = false;
            this.dataGridViewService.GridColor = System.Drawing.Color.RoyalBlue;
            this.dataGridViewService.Location = new System.Drawing.Point(0, 80);
            this.dataGridViewService.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewService.Name = "dataGridViewService";
            this.dataGridViewService.ReadOnly = true;
            this.dataGridViewService.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewService.RowHeadersVisible = false;
            this.dataGridViewService.RowHeadersWidth = 51;
            this.dataGridViewService.RowTemplate.Height = 100;
            this.dataGridViewService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewService.Size = new System.Drawing.Size(977, 572);
            this.dataGridViewService.TabIndex = 0;
            this.dataGridViewService.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewService_CellContentClick);
            // 
            // ServiceId
            // 
            this.ServiceId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ServiceId.HeaderText = "STT";
            this.ServiceId.MinimumWidth = 6;
            this.ServiceId.Name = "ServiceId";
            this.ServiceId.ReadOnly = true;
            this.ServiceId.Width = 49;
            // 
            // ServiceName
            // 
            this.ServiceName.HeaderText = "Tên Dịch Vụ";
            this.ServiceName.MinimumWidth = 6;
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            // 
            // ServiceType
            // 
            this.ServiceType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ServiceType.HeaderText = "Loại Dịch Vụ";
            this.ServiceType.MinimumWidth = 6;
            this.ServiceType.Name = "ServiceType";
            this.ServiceType.ReadOnly = true;
            this.ServiceType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ServiceType.Width = 200;
            // 
            // ServicePrice
            // 
            this.ServicePrice.HeaderText = "Đơn Giá";
            this.ServicePrice.MinimumWidth = 6;
            this.ServicePrice.Name = "ServicePrice";
            this.ServicePrice.ReadOnly = true;
            // 
            // myService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 676);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "myService";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Service_Load);
            this.Resize += new System.EventHandler(this.myService_Resize);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewService;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicePrice;
        private UIDesign.TextBoxTemplate searchServicename;
        private UIDesign.RJButton btnAdd;
        private UIDesign.RJButton btnEdit;
        private UIDesign.RJButton btnDelete;
    }
}