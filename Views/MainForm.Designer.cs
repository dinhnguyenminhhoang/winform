﻿namespace WinFormsCore.Views
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            groupBox1 = new GroupBox();
            cityComboBox = new ComboBox();
            updateButton = new Button();
            addButton = new Button();
            phoneNumberTextBox = new TextBox();
            label6 = new Label();
            countryTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            firstNametextBox = new TextBox();
            label3 = new Label();
            lastNameTextBox = new TextBox();
            label2 = new Label();
            customerBindingSource = new BindingSource(components);
            searchTextBox = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            chỉnhSửaToolStripMenuItem = new ToolStripMenuItem();
            xoaToolStripMenuItem = new ToolStripMenuItem();
            rowPerPagecomboBox = new ComboBox();
            label8 = new Label();
            nextPageBtn = new Button();
            button4 = new Button();
            currentPageLabel = new Label();
            sortComboBox = new ComboBox();
            label9 = new Label();
            columnSortByComboBox = new ComboBox();
            label10 = new Label();
            customerBindingSource1 = new BindingSource(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(249, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 0;
            label1.Text = "Quản lý khách hàng";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cityComboBox);
            groupBox1.Controls.Add(updateButton);
            groupBox1.Controls.Add(addButton);
            groupBox1.Controls.Add(phoneNumberTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(countryTextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(firstNametextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lastNameTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(22, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(627, 166);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "-";
            // 
            // cityComboBox
            // 
            cityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cityComboBox.FormattingEnabled = true;
            cityComboBox.Items.AddRange(new object[] { "Hanoi", "Ho Chi Minh City", "Hai Phong", "Da Nang", "Can Tho", "An Giang", "Bac Giang", "Bac Kan", "Bac Ninh", "Ben Tre", "Binh Dinh", "Binh Duong", "Binh Thuan", "Ca Mau", "Cao Bang", "Dak Lak", "Dak Nong", "Dien Bien", "Dong Nai", "Dong Thap", "Gia Lai", "Ha Giang", "Ha Nam", "Ha Tinh", "Hau Giang", "Hoa Binh", "Hung Yen", "Khanh Hoa", "Kien Giang", "Lai Chau", "Lam Dong", "Lang Son", "Lao Cai", "Long An", "Nam Dinh", "Nghe An", "Ninh Binh", "Ninh Thuan", "Phu Tho", "Phu Yen", "Quang Binh", "Quang Nam", "Quang Ngai", "Quang Ninh", "Soc Trang", "Son La", "Tay Ninh", "Thai Binh", "Thai Nguyen", "Thanh Hoa", "Tien Giang", "Tra Vinh", "Tuyen Quang", "Vinh Long", "Yen Bai", "Hoa Binh", "Binh Phuoc" });
            cityComboBox.Location = new Point(433, 33);
            cityComboBox.Name = "cityComboBox";
            cityComboBox.Size = new Size(178, 23);
            cityComboBox.TabIndex = 2;
            cityComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // updateButton
            // 
            updateButton.Enabled = false;
            updateButton.Location = new Point(463, 123);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(91, 28);
            updateButton.TabIndex = 11;
            updateButton.Text = "Cập nhật";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(350, 123);
            addButton.Name = "addButton";
            addButton.Size = new Size(91, 28);
            addButton.TabIndex = 10;
            addButton.Text = "Thêm mới";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(114, 128);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(178, 23);
            phoneNumberTextBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 128);
            label6.Name = "label6";
            label6.Size = new Size(99, 25);
            label6.TabIndex = 8;
            label6.Text = "Điện thoại";
            label6.Click += label6_Click;
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(433, 79);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(178, 23);
            countryTextBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(339, 79);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 6;
            label5.Text = "Quốc gia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(339, 31);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 4;
            label4.Text = "Tỉnh/TP";
            // 
            // firstNametextBox
            // 
            firstNametextBox.Location = new Point(114, 84);
            firstNametextBox.Name = "firstNametextBox";
            firstNametextBox.Size = new Size(178, 23);
            firstNametextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 79);
            label3.Name = "label3";
            label3.Size = new Size(41, 25);
            label3.TabIndex = 2;
            label3.Text = "Tên";
            label3.Click += label3_Click;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(114, 38);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(178, 23);
            lastNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 33);
            label2.Name = "label2";
            label2.Size = new Size(36, 25);
            label2.TabIndex = 0;
            label2.Text = "Họ";
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Models.Entities.Customer);
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(471, 213);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(178, 23);
            searchTextBox.TabIndex = 11;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(377, 213);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 10;
            label7.Text = "Tìm kiếm";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, countryDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn });
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.DataSource = customerBindingSource;
            dataGridView1.Location = new Point(22, 252);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(627, 160);
            dataGridView1.TabIndex = 12;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            cityDataGridViewTextBoxColumn.HeaderText = "City";
            cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            countryDataGridViewTextBoxColumn.HeaderText = "Country";
            countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { chỉnhSửaToolStripMenuItem, xoaToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(128, 48);
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            chỉnhSửaToolStripMenuItem.Size = new Size(127, 22);
            chỉnhSửaToolStripMenuItem.Text = "Chinh sua";
            chỉnhSửaToolStripMenuItem.Click += chinhSuaToolStripMenuItem_Click;
            // 
            // xoaToolStripMenuItem
            // 
            xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            xoaToolStripMenuItem.Size = new Size(127, 22);
            xoaToolStripMenuItem.Text = "Xoa";
            xoaToolStripMenuItem.Click += xoaToolStripMenuItem_Click;
            // 
            // rowPerPagecomboBox
            // 
            rowPerPagecomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rowPerPagecomboBox.FormattingEnabled = true;
            rowPerPagecomboBox.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "100" });
            rowPerPagecomboBox.Location = new Point(109, 428);
            rowPerPagecomboBox.Name = "rowPerPagecomboBox";
            rowPerPagecomboBox.Size = new Size(54, 23);
            rowPerPagecomboBox.TabIndex = 13;
            rowPerPagecomboBox.SelectedIndexChanged += rowPerPagecomboBox_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 426);
            label8.Name = "label8";
            label8.Size = new Size(82, 25);
            label8.TabIndex = 14;
            label8.Text = "Số dòng";
            // 
            // nextPageBtn
            // 
            nextPageBtn.Location = new Point(414, 428);
            nextPageBtn.Name = "nextPageBtn";
            nextPageBtn.Size = new Size(91, 28);
            nextPageBtn.TabIndex = 16;
            nextPageBtn.Text = "Trang kế";
            nextPageBtn.UseVisualStyleBackColor = true;
            nextPageBtn.Click += nextPageBtn_Click;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(301, 428);
            button4.Name = "button4";
            button4.Size = new Size(91, 28);
            button4.TabIndex = 15;
            button4.Text = "Trang trước";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // currentPageLabel
            // 
            currentPageLabel.AutoSize = true;
            currentPageLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentPageLabel.Location = new Point(548, 431);
            currentPageLabel.Name = "currentPageLabel";
            currentPageLabel.Size = new Size(101, 25);
            currentPageLabel.TabIndex = 17;
            currentPageLabel.Text = "Trang 1/10";
            // 
            // sortComboBox
            // 
            sortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sortComboBox.FormattingEnabled = true;
            sortComboBox.Items.AddRange(new object[] { "Giam", "Tang" });
            sortComboBox.Location = new Point(99, 213);
            sortComboBox.Name = "sortComboBox";
            sortComboBox.Size = new Size(75, 23);
            sortComboBox.Sorted = true;
            sortComboBox.TabIndex = 18;
            sortComboBox.SelectedIndexChanged += sortComboBox_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 213);
            label9.Name = "label9";
            label9.Size = new Size(78, 25);
            label9.TabIndex = 19;
            label9.Text = "Sắp xếp";
            // 
            // columnSortByComboBox
            // 
            columnSortByComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            columnSortByComboBox.FormattingEnabled = true;
            columnSortByComboBox.Location = new Point(227, 213);
            columnSortByComboBox.Name = "columnSortByComboBox";
            columnSortByComboBox.Size = new Size(87, 23);
            columnSortByComboBox.TabIndex = 20;
            columnSortByComboBox.SelectedIndexChanged += columnSortByComboBox_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(180, 213);
            label10.Name = "label10";
            label10.Size = new Size(41, 25);
            label10.TabIndex = 21;
            label10.Text = "Cột";
            // 
            // customerBindingSource1
            // 
            customerBindingSource1.DataSource = typeof(Models.Entities.Customer);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 523);
            Controls.Add(columnSortByComboBox);
            Controls.Add(label10);
            Controls.Add(sortComboBox);
            Controls.Add(label9);
            Controls.Add(currentPageLabel);
            Controls.Add(nextPageBtn);
            Controls.Add(button4);
            Controls.Add(rowPerPagecomboBox);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(searchTextBox);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "Quản lý khách hàng";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customerBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox lastNameTextBox;
        private Label label2;
        private TextBox countryTextBox;
        private Label label5;
        private Label label4;
        private TextBox firstNametextBox;
        private Label label3;
        private TextBox phoneNumberTextBox;
        private Label label6;
        private Button updateButton;
        private Button addButton;
        private ComboBox cityComboBox;
        private BindingSource customerBindingSource;
        private TextBox searchTextBox;
        private Label label7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ordersDataGridViewTextBoxColumn;
        private ComboBox rowPerPagecomboBox;
        private Label label8;
        private Button nextPageBtn;
        private Button button4;
        private Label currentPageLabel;
        private ComboBox sortComboBox;
        private Label label9;
        private ComboBox columnSortByComboBox;
        private Label label10;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private ToolStripMenuItem xoaToolStripMenuItem;
        private BindingSource customerBindingSource1;
    }
}