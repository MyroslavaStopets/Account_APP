namespace Account_App
{
    partial class FormBankAccounts
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkAccSettings = new System.Windows.Forms.LinkLabel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelSort = new System.Windows.Forms.Label();
            this.dataGridViewBankAcc = new System.Windows.Forms.DataGridView();
            this.AccNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBankAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(942, 91);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 85);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your accounts: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.flowLayoutPanel2.Controls.Add(this.linkAccSettings);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 519);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(942, 66);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // linkAccSettings
            // 
            this.linkAccSettings.ActiveLinkColor = System.Drawing.Color.OldLace;
            this.linkAccSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkAccSettings.AutoSize = true;
            this.linkAccSettings.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkAccSettings.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkAccSettings.Location = new System.Drawing.Point(3, 0);
            this.linkAccSettings.Name = "linkAccSettings";
            this.linkAccSettings.Size = new System.Drawing.Size(182, 28);
            this.linkAccSettings.TabIndex = 0;
            this.linkAccSettings.TabStop = true;
            this.linkAccSettings.Text = "Account settings";
            this.linkAccSettings.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkAccSettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSearch.Location = new System.Drawing.Point(664, 123);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(350, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "What data you want find: ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(508, 145);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(136, 20);
            this.txtSearch.TabIndex = 17;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSort.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSort.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSort.Location = new System.Drawing.Point(209, 141);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(62, 24);
            this.btnSort.TabIndex = 16;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.BackColor = System.Drawing.Color.Snow;
            this.comboBoxSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "Account Number",
            "Owner name",
            "Owner surname",
            "Last year",
            "Sum on account"});
            this.comboBoxSearch.Location = new System.Drawing.Point(508, 108);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(136, 24);
            this.comboBoxSearch.TabIndex = 14;
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.BackColor = System.Drawing.Color.Snow;
            this.comboBoxSort.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Account Number",
            "Owner name",
            "Owner surname",
            "Last year",
            "Sum on account"});
            this.comboBoxSort.Location = new System.Drawing.Point(150, 108);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSort.TabIndex = 15;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelSearch.Location = new System.Drawing.Point(397, 108);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(95, 20);
            this.labelSearch.TabIndex = 12;
            this.labelSearch.Text = "Search by: ";
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelSort.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSort.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelSort.Location = new System.Drawing.Point(53, 107);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(74, 20);
            this.labelSort.TabIndex = 13;
            this.labelSort.Text = "Sort by: ";
            // 
            // dataGridViewBankAcc
            // 
            this.dataGridViewBankAcc.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridViewBankAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBankAcc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBankAcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBankAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBankAcc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccNumber,
            this.Firstname,
            this.Lastname,
            this.Last_year,
            this.Summ});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBankAcc.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewBankAcc.Location = new System.Drawing.Point(44, 206);
            this.dataGridViewBankAcc.Name = "dataGridViewBankAcc";
            this.dataGridViewBankAcc.Size = new System.Drawing.Size(714, 200);
            this.dataGridViewBankAcc.TabIndex = 20;
            this.dataGridViewBankAcc.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBankAcc_CellValueChange);
            // 
            // AccNumber
            // 
            this.AccNumber.DataPropertyName = "AccNumber";
            this.AccNumber.HeaderText = "Account number";
            this.AccNumber.Name = "AccNumber";
            // 
            // Firstname
            // 
            this.Firstname.DataPropertyName = "Firstname";
            this.Firstname.HeaderText = "Owner name";
            this.Firstname.Name = "Firstname";
            // 
            // Lastname
            // 
            this.Lastname.DataPropertyName = "Lastname";
            this.Lastname.HeaderText = "Owner surname";
            this.Lastname.Name = "Lastname";
            // 
            // Last_year
            // 
            this.Last_year.DataPropertyName = "Last_year";
            this.Last_year.HeaderText = "Last year";
            this.Last_year.Name = "Last_year";
            // 
            // Summ
            // 
            this.Summ.DataPropertyName = "Summ";
            this.Summ.HeaderText = "Sum on account";
            this.Summ.Name = "Summ";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.OldLace;
            this.btnDelete.Location = new System.Drawing.Point(221, 445);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(260, 41);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete selected row";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormBankAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(942, 585);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridViewBankAcc);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelSort);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormBankAccounts";
            this.Text = "Bank Accounts";
            this.Load += new System.EventHandler(this.FormBankAccounts_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBankAcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.DataGridView dataGridViewBankAcc;
        private System.Windows.Forms.LinkLabel linkAccSettings;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summ;
        private System.Windows.Forms.Button btnDelete;
    }
}