﻿namespace DemoQuanLyThuVien
{
    partial class fBookList
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvfBookList = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBookListPrice = new System.Windows.Forms.TextBox();
            this.txtBookListNameNXB = new System.Windows.Forms.TextBox();
            this.txtBookListAuthor = new System.Windows.Forms.TextBox();
            this.txtBookListYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBookListIdCategory = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBookListName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBookListId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnfRentList = new System.Windows.Forms.ToolStripMenuItem();
            this.cbBookListIdCategory = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Change = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvfBookList)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvfBookList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(124, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(584, 225);
            this.panel3.TabIndex = 3;
            // 
            // dtgvfBookList
            // 
            this.dtgvfBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvfBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.idCategory,
            this.releaseYear,
            this.nameAuthor,
            this.nameNXB,
            this.price,
            this.Delete,
            this.Change});
            this.dtgvfBookList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvfBookList.Location = new System.Drawing.Point(0, 0);
            this.dtgvfBookList.Name = "dtgvfBookList";
            this.dtgvfBookList.Size = new System.Drawing.Size(584, 225);
            this.dtgvfBookList.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbBookListIdCategory);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtBookListPrice);
            this.panel2.Controls.Add(this.txtBookListNameNXB);
            this.panel2.Controls.Add(this.txtBookListAuthor);
            this.panel2.Controls.Add(this.txtBookListYear);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtBookListIdCategory);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtBookListName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtBookListId);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(124, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 105);
            this.panel2.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(234, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 31);
            this.button4.TabIndex = 2;
            this.button4.Text = "Lưu";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(160, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "***";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtBookListPrice
            // 
            this.txtBookListPrice.Location = new System.Drawing.Point(390, 62);
            this.txtBookListPrice.Name = "txtBookListPrice";
            this.txtBookListPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBookListPrice.TabIndex = 1;
            // 
            // txtBookListNameNXB
            // 
            this.txtBookListNameNXB.Location = new System.Drawing.Point(390, 33);
            this.txtBookListNameNXB.Name = "txtBookListNameNXB";
            this.txtBookListNameNXB.Size = new System.Drawing.Size(100, 20);
            this.txtBookListNameNXB.TabIndex = 1;
            // 
            // txtBookListAuthor
            // 
            this.txtBookListAuthor.Location = new System.Drawing.Point(221, 33);
            this.txtBookListAuthor.Name = "txtBookListAuthor";
            this.txtBookListAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtBookListAuthor.TabIndex = 1;
            // 
            // txtBookListYear
            // 
            this.txtBookListYear.Location = new System.Drawing.Point(54, 36);
            this.txtBookListYear.Name = "txtBookListYear";
            this.txtBookListYear.Size = new System.Drawing.Size(100, 20);
            this.txtBookListYear.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(327, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giá";
            // 
            // txtBookListIdCategory
            // 
            this.txtBookListIdCategory.Location = new System.Drawing.Point(390, 7);
            this.txtBookListIdCategory.Name = "txtBookListIdCategory";
            this.txtBookListIdCategory.Size = new System.Drawing.Size(100, 20);
            this.txtBookListIdCategory.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(327, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên NXB";
            // 
            // txtBookListName
            // 
            this.txtBookListName.Location = new System.Drawing.Point(221, 7);
            this.txtBookListName.Name = "txtBookListName";
            this.txtBookListName.Size = new System.Drawing.Size(100, 20);
            this.txtBookListName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(160, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tác giả ";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(327, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "mã sách";
            // 
            // txtBookListId
            // 
            this.txtBookListId.Location = new System.Drawing.Point(54, 10);
            this.txtBookListId.Name = "txtBookListId";
            this.txtBookListId.Size = new System.Drawing.Size(100, 20);
            this.txtBookListId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(157, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sách";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Năm SX";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 361);
            this.panel1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnfRentList});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnfRentList
            // 
            this.mnfRentList.Name = "mnfRentList";
            this.mnfRentList.Size = new System.Drawing.Size(46, 20);
            this.mnfRentList.Text = "Home";
            // 
            // cbBookListIdCategory
            // 
            this.cbBookListIdCategory.FormattingEnabled = true;
            this.cbBookListIdCategory.Location = new System.Drawing.Point(496, 7);
            this.cbBookListIdCategory.Name = "cbBookListIdCategory";
            this.cbBookListIdCategory.Size = new System.Drawing.Size(57, 21);
            this.cbBookListIdCategory.TabIndex = 3;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã sách";
            this.id.Name = "id";
            this.id.Width = 30;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên sách";
            this.name.Name = "name";
            // 
            // idCategory
            // 
            this.idCategory.DataPropertyName = "idCategory";
            this.idCategory.HeaderText = "Mã sách";
            this.idCategory.Name = "idCategory";
            this.idCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idCategory.Width = 30;
            // 
            // releaseYear
            // 
            this.releaseYear.DataPropertyName = "releaseYear";
            this.releaseYear.HeaderText = "Năm SX";
            this.releaseYear.Name = "releaseYear";
            this.releaseYear.Width = 40;
            // 
            // nameAuthor
            // 
            this.nameAuthor.DataPropertyName = "nameAuthor";
            this.nameAuthor.HeaderText = "Tên tác giả";
            this.nameAuthor.Name = "nameAuthor";
            // 
            // nameNXB
            // 
            this.nameNXB.DataPropertyName = "nameNXB";
            this.nameNXB.HeaderText = "Tên NXB";
            this.nameNXB.Name = "nameNXB";
            this.nameNXB.Width = 40;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            this.price.Width = 55;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Xóa";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 35;
            // 
            // Change
            // 
            this.Change.HeaderText = "Sửa";
            this.Change.Name = "Change";
            this.Change.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Change.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Change.Width = 35;
            // 
            // fBookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 385);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "fBookList";
            this.Text = "fBookList";
            this.Load += new System.EventHandler(this.fBookList_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvfBookList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvfBookList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnfRentList;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBookListPrice;
        private System.Windows.Forms.TextBox txtBookListNameNXB;
        private System.Windows.Forms.TextBox txtBookListAuthor;
        private System.Windows.Forms.TextBox txtBookListYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBookListIdCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBookListName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBookListId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Change;
        private System.Windows.Forms.ComboBox cbBookListIdCategory;
    }
}