﻿namespace SmartTest.DAL
{
    partial class ListUserForm
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
            this.lbUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.dtgvListUser = new System.Windows.Forms.DataGridView();
            this.TenNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbListUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbUser.Location = new System.Drawing.Point(12, 97);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(82, 13);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "Tên người dùng";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(100, 94);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(121, 20);
            this.txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(295, 94);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(124, 20);
            this.txtPass.TabIndex = 2;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbPass.Location = new System.Drawing.Point(237, 97);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(52, 13);
            this.lbPass.TabIndex = 3;
            this.lbPass.Text = "Mật khẩu";
            // 
            // dtgvListUser
            // 
            this.dtgvListUser.AllowUserToAddRows = false;
            this.dtgvListUser.AllowUserToDeleteRows = false;
            this.dtgvListUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNguoiDung,
            this.MatKhau});
            this.dtgvListUser.Location = new System.Drawing.Point(-1, 136);
            this.dtgvListUser.Name = "dtgvListUser";
            this.dtgvListUser.Size = new System.Drawing.Size(472, 149);
            this.dtgvListUser.TabIndex = 4;
            this.dtgvListUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TenNguoiDung
            // 
            this.TenNguoiDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNguoiDung.DataPropertyName = "TenNguoiDung";
            this.TenNguoiDung.HeaderText = "Tên người dùng";
            this.TenNguoiDung.Name = "TenNguoiDung";
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.MinimumWidth = 10;
            this.MatKhau.Name = "MatKhau";
            // 
            // lbListUser
            // 
            this.lbListUser.AutoSize = true;
            this.lbListUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbListUser.Location = new System.Drawing.Point(78, 25);
            this.lbListUser.Name = "lbListUser";
            this.lbListUser.Size = new System.Drawing.Size(331, 29);
            this.lbListUser.TabIndex = 5;
            this.lbListUser.Text = "DANH SÁCH NGƯỜI DÙNG";
            // 
            // ListUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 286);
            this.Controls.Add(this.lbListUser);
            this.Controls.Add(this.dtgvListUser);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lbUser);
            this.Name = "ListUserForm";
            this.Text = "Danh s¸ch người dïng";
            this.Load += new System.EventHandler(this.ListUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.DataGridView dtgvListUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.Label lbListUser;
    }
}