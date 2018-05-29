namespace BANKretail
{
    partial class MainForm
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
            this.grbx_Debitors = new System.Windows.Forms.GroupBox();
            this.dgv_debitors = new System.Windows.Forms.DataGridView();
            this.grbx_debitorDetails = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_phoneNumber = new System.Windows.Forms.TextBox();
            this.txbx_debitorPostNumber = new System.Windows.Forms.TextBox();
            this.txbx_debitorName = new System.Windows.Forms.TextBox();
            this.txbx_debitorID = new System.Windows.Forms.TextBox();
            this.grbx_credits = new System.Windows.Forms.GroupBox();
            this.dgv_credits = new System.Windows.Forms.DataGridView();
            this.grbx_payments = new System.Windows.Forms.GroupBox();
            this.dgv_payments = new System.Windows.Forms.DataGridView();
            this.grbx_Search = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_nextRow = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txbx_searchedDebPhoneNumber = new System.Windows.Forms.TextBox();
            this.txbx_searchedDebPostNumber = new System.Windows.Forms.TextBox();
            this.txbx_searchedDebName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDebitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNewCreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passNewPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chbx_DB = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grbx_Debitors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_debitors)).BeginInit();
            this.grbx_debitorDetails.SuspendLayout();
            this.grbx_credits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_credits)).BeginInit();
            this.grbx_payments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payments)).BeginInit();
            this.grbx_Search.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_Debitors
            // 
            this.grbx_Debitors.Controls.Add(this.dgv_debitors);
            this.grbx_Debitors.Location = new System.Drawing.Point(13, 101);
            this.grbx_Debitors.Name = "grbx_Debitors";
            this.grbx_Debitors.Size = new System.Drawing.Size(317, 134);
            this.grbx_Debitors.TabIndex = 0;
            this.grbx_Debitors.TabStop = false;
            this.grbx_Debitors.Text = "Debitors";
            // 
            // dgv_debitors
            // 
            this.dgv_debitors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_debitors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_debitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_debitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_debitors.Location = new System.Drawing.Point(3, 16);
            this.dgv_debitors.Name = "dgv_debitors";
            this.dgv_debitors.Size = new System.Drawing.Size(311, 115);
            this.dgv_debitors.TabIndex = 0;
            this.dgv_debitors.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_RowPrePaint);
            // 
            // grbx_debitorDetails
            // 
            this.grbx_debitorDetails.Controls.Add(this.label4);
            this.grbx_debitorDetails.Controls.Add(this.label3);
            this.grbx_debitorDetails.Controls.Add(this.label2);
            this.grbx_debitorDetails.Controls.Add(this.label1);
            this.grbx_debitorDetails.Controls.Add(this.txbx_phoneNumber);
            this.grbx_debitorDetails.Controls.Add(this.txbx_debitorPostNumber);
            this.grbx_debitorDetails.Controls.Add(this.txbx_debitorName);
            this.grbx_debitorDetails.Controls.Add(this.txbx_debitorID);
            this.grbx_debitorDetails.Location = new System.Drawing.Point(336, 101);
            this.grbx_debitorDetails.Name = "grbx_debitorDetails";
            this.grbx_debitorDetails.Size = new System.Drawing.Size(453, 134);
            this.grbx_debitorDetails.TabIndex = 1;
            this.grbx_debitorDetails.TabStop = false;
            this.grbx_debitorDetails.Text = "Debitors details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Debitor Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Debitor Post Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Debitor Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Debitor ID";
            // 
            // txbx_phoneNumber
            // 
            this.txbx_phoneNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_phoneNumber.Location = new System.Drawing.Point(129, 98);
            this.txbx_phoneNumber.Name = "txbx_phoneNumber";
            this.txbx_phoneNumber.ReadOnly = true;
            this.txbx_phoneNumber.Size = new System.Drawing.Size(318, 20);
            this.txbx_phoneNumber.TabIndex = 3;
            // 
            // txbx_debitorPostNumber
            // 
            this.txbx_debitorPostNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_debitorPostNumber.Location = new System.Drawing.Point(129, 72);
            this.txbx_debitorPostNumber.Name = "txbx_debitorPostNumber";
            this.txbx_debitorPostNumber.ReadOnly = true;
            this.txbx_debitorPostNumber.Size = new System.Drawing.Size(318, 20);
            this.txbx_debitorPostNumber.TabIndex = 2;
            // 
            // txbx_debitorName
            // 
            this.txbx_debitorName.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_debitorName.Location = new System.Drawing.Point(129, 46);
            this.txbx_debitorName.Name = "txbx_debitorName";
            this.txbx_debitorName.ReadOnly = true;
            this.txbx_debitorName.Size = new System.Drawing.Size(318, 20);
            this.txbx_debitorName.TabIndex = 1;
            // 
            // txbx_debitorID
            // 
            this.txbx_debitorID.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_debitorID.Location = new System.Drawing.Point(129, 20);
            this.txbx_debitorID.Name = "txbx_debitorID";
            this.txbx_debitorID.ReadOnly = true;
            this.txbx_debitorID.Size = new System.Drawing.Size(318, 20);
            this.txbx_debitorID.TabIndex = 0;
            // 
            // grbx_credits
            // 
            this.grbx_credits.Controls.Add(this.dgv_credits);
            this.grbx_credits.Location = new System.Drawing.Point(13, 241);
            this.grbx_credits.Name = "grbx_credits";
            this.grbx_credits.Size = new System.Drawing.Size(776, 142);
            this.grbx_credits.TabIndex = 2;
            this.grbx_credits.TabStop = false;
            this.grbx_credits.Text = "Credits";
            // 
            // dgv_credits
            // 
            this.dgv_credits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_credits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_credits.Location = new System.Drawing.Point(3, 16);
            this.dgv_credits.Name = "dgv_credits";
            this.dgv_credits.Size = new System.Drawing.Size(770, 123);
            this.dgv_credits.TabIndex = 1;
            this.dgv_credits.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_RowPrePaint);
            // 
            // grbx_payments
            // 
            this.grbx_payments.Controls.Add(this.dgv_payments);
            this.grbx_payments.Location = new System.Drawing.Point(13, 389);
            this.grbx_payments.Name = "grbx_payments";
            this.grbx_payments.Size = new System.Drawing.Size(776, 140);
            this.grbx_payments.TabIndex = 3;
            this.grbx_payments.TabStop = false;
            this.grbx_payments.Text = "Payments";
            // 
            // dgv_payments
            // 
            this.dgv_payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_payments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_payments.Location = new System.Drawing.Point(3, 16);
            this.dgv_payments.Name = "dgv_payments";
            this.dgv_payments.Size = new System.Drawing.Size(770, 121);
            this.dgv_payments.TabIndex = 1;
            this.dgv_payments.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_RowPrePaint);
            // 
            // grbx_Search
            // 
            this.grbx_Search.Controls.Add(this.label8);
            this.grbx_Search.Controls.Add(this.chbx_DB);
            this.grbx_Search.Controls.Add(this.label7);
            this.grbx_Search.Controls.Add(this.label6);
            this.grbx_Search.Controls.Add(this.label5);
            this.grbx_Search.Controls.Add(this.btn_nextRow);
            this.grbx_Search.Controls.Add(this.btn_search);
            this.grbx_Search.Controls.Add(this.txbx_searchedDebPhoneNumber);
            this.grbx_Search.Controls.Add(this.txbx_searchedDebPostNumber);
            this.grbx_Search.Controls.Add(this.txbx_searchedDebName);
            this.grbx_Search.Location = new System.Drawing.Point(13, 27);
            this.grbx_Search.Name = "grbx_Search";
            this.grbx_Search.Size = new System.Drawing.Size(776, 68);
            this.grbx_Search.TabIndex = 4;
            this.grbx_Search.TabStop = false;
            this.grbx_Search.Text = "Search";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Телефон дебитора";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Пост номер дебитора";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Имя дебитора";
            // 
            // btn_nextRow
            // 
            this.btn_nextRow.Location = new System.Drawing.Point(694, 34);
            this.btn_nextRow.Name = "btn_nextRow";
            this.btn_nextRow.Size = new System.Drawing.Size(75, 23);
            this.btn_nextRow.TabIndex = 4;
            this.btn_nextRow.Text = "Next";
            this.btn_nextRow.UseVisualStyleBackColor = true;
            this.btn_nextRow.Click += new System.EventHandler(this.btn_nextRow_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(587, 34);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Искать";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txbx_searchedDebPhoneNumber
            // 
            this.txbx_searchedDebPhoneNumber.Location = new System.Drawing.Point(379, 35);
            this.txbx_searchedDebPhoneNumber.Name = "txbx_searchedDebPhoneNumber";
            this.txbx_searchedDebPhoneNumber.Size = new System.Drawing.Size(181, 20);
            this.txbx_searchedDebPhoneNumber.TabIndex = 2;
            // 
            // txbx_searchedDebPostNumber
            // 
            this.txbx_searchedDebPostNumber.Location = new System.Drawing.Point(192, 35);
            this.txbx_searchedDebPostNumber.Name = "txbx_searchedDebPostNumber";
            this.txbx_searchedDebPostNumber.Size = new System.Drawing.Size(181, 20);
            this.txbx_searchedDebPostNumber.TabIndex = 1;
            // 
            // txbx_searchedDebName
            // 
            this.txbx_searchedDebName.Location = new System.Drawing.Point(5, 35);
            this.txbx_searchedDebName.Name = "txbx_searchedDebName";
            this.txbx_searchedDebName.Size = new System.Drawing.Size(181, 20);
            this.txbx_searchedDebName.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.debitorToolStripMenuItem,
            this.creditToolStripMenuItem,
            this.paymentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDataToCSVToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveDataToCSVToolStripMenuItem
            // 
            this.saveDataToCSVToolStripMenuItem.Name = "saveDataToCSVToolStripMenuItem";
            this.saveDataToCSVToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.saveDataToCSVToolStripMenuItem.Text = "Save data to CSV";
            this.saveDataToCSVToolStripMenuItem.Click += new System.EventHandler(this.saveDataToCSVToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // debitorToolStripMenuItem
            // 
            this.debitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDebitorToolStripMenuItem});
            this.debitorToolStripMenuItem.Name = "debitorToolStripMenuItem";
            this.debitorToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debitorToolStripMenuItem.Text = "Debitor";
            // 
            // addNewDebitorToolStripMenuItem
            // 
            this.addNewDebitorToolStripMenuItem.Name = "addNewDebitorToolStripMenuItem";
            this.addNewDebitorToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addNewDebitorToolStripMenuItem.Text = "Add new debitor";
            this.addNewDebitorToolStripMenuItem.Click += new System.EventHandler(this.addNewDebitorToolStripMenuItem_Click);
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openNewCreditToolStripMenuItem});
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.creditToolStripMenuItem.Text = "Credit";
            // 
            // openNewCreditToolStripMenuItem
            // 
            this.openNewCreditToolStripMenuItem.Name = "openNewCreditToolStripMenuItem";
            this.openNewCreditToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openNewCreditToolStripMenuItem.Text = "Open new credit";
            this.openNewCreditToolStripMenuItem.Click += new System.EventHandler(this.openNewCreditToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passNewPaymentToolStripMenuItem});
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.paymentToolStripMenuItem.Text = "Payment";
            // 
            // passNewPaymentToolStripMenuItem
            // 
            this.passNewPaymentToolStripMenuItem.Name = "passNewPaymentToolStripMenuItem";
            this.passNewPaymentToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.passNewPaymentToolStripMenuItem.Text = "Pass new payment";
            this.passNewPaymentToolStripMenuItem.Click += new System.EventHandler(this.passNewPaymentToolStripMenuItem_Click);
            // 
            // chbx_DB
            // 
            this.chbx_DB.AutoSize = true;
            this.chbx_DB.Location = new System.Drawing.Point(566, 37);
            this.chbx_DB.Name = "chbx_DB";
            this.chbx_DB.Size = new System.Drawing.Size(15, 14);
            this.chbx_DB.TabIndex = 8;
            this.chbx_DB.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(563, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Искать в БД";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 540);
            this.Controls.Add(this.grbx_Search);
            this.Controls.Add(this.grbx_payments);
            this.Controls.Add(this.grbx_credits);
            this.Controls.Add(this.grbx_debitorDetails);
            this.Controls.Add(this.grbx_Debitors);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Bank manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.grbx_Debitors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_debitors)).EndInit();
            this.grbx_debitorDetails.ResumeLayout(false);
            this.grbx_debitorDetails.PerformLayout();
            this.grbx_credits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_credits)).EndInit();
            this.grbx_payments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payments)).EndInit();
            this.grbx_Search.ResumeLayout(false);
            this.grbx_Search.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_Debitors;
        private System.Windows.Forms.GroupBox grbx_debitorDetails;
        private System.Windows.Forms.GroupBox grbx_credits;
        private System.Windows.Forms.GroupBox grbx_payments;
        private System.Windows.Forms.DataGridView dgv_debitors;
        private System.Windows.Forms.DataGridView dgv_credits;
        private System.Windows.Forms.DataGridView dgv_payments;
        private System.Windows.Forms.TextBox txbx_debitorID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_phoneNumber;
        private System.Windows.Forms.TextBox txbx_debitorPostNumber;
        private System.Windows.Forms.TextBox txbx_debitorName;
        private System.Windows.Forms.GroupBox grbx_Search;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDebitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openNewCreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passNewPaymentToolStripMenuItem;
        private System.Windows.Forms.Button btn_nextRow;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txbx_searchedDebPhoneNumber;
        private System.Windows.Forms.TextBox txbx_searchedDebPostNumber;
        private System.Windows.Forms.TextBox txbx_searchedDebName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chbx_DB;
    }
}

