namespace BANKretail
{
    partial class NewCredit
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
            this.grbx_debitorDetails = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbx_creditBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_creditOpenDate = new System.Windows.Forms.DateTimePicker();
            this.ltbx_debitorName = new System.Windows.Forms.ListBox();
            this.ltbx_debitorID = new System.Windows.Forms.ListBox();
            this.btn_saveNewCredit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_creditAmount = new System.Windows.Forms.TextBox();
            this.txbx_creditID = new System.Windows.Forms.TextBox();
            this.lbl_messageCreditAmount = new System.Windows.Forms.Label();
            this.grbx_debitorDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_debitorDetails
            // 
            this.grbx_debitorDetails.Controls.Add(this.lbl_messageCreditAmount);
            this.grbx_debitorDetails.Controls.Add(this.label4);
            this.grbx_debitorDetails.Controls.Add(this.txbx_creditBalance);
            this.grbx_debitorDetails.Controls.Add(this.label5);
            this.grbx_debitorDetails.Controls.Add(this.dtp_creditOpenDate);
            this.grbx_debitorDetails.Controls.Add(this.ltbx_debitorName);
            this.grbx_debitorDetails.Controls.Add(this.ltbx_debitorID);
            this.grbx_debitorDetails.Controls.Add(this.btn_saveNewCredit);
            this.grbx_debitorDetails.Controls.Add(this.label3);
            this.grbx_debitorDetails.Controls.Add(this.label2);
            this.grbx_debitorDetails.Controls.Add(this.label1);
            this.grbx_debitorDetails.Controls.Add(this.txbx_creditAmount);
            this.grbx_debitorDetails.Controls.Add(this.txbx_creditID);
            this.grbx_debitorDetails.Location = new System.Drawing.Point(12, 12);
            this.grbx_debitorDetails.Name = "grbx_debitorDetails";
            this.grbx_debitorDetails.Size = new System.Drawing.Size(453, 257);
            this.grbx_debitorDetails.TabIndex = 3;
            this.grbx_debitorDetails.TabStop = false;
            this.grbx_debitorDetails.Text = "Debitors details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Credit Balance";
            // 
            // txbx_creditBalance
            // 
            this.txbx_creditBalance.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_creditBalance.Location = new System.Drawing.Point(86, 189);
            this.txbx_creditBalance.Name = "txbx_creditBalance";
            this.txbx_creditBalance.ReadOnly = true;
            this.txbx_creditBalance.Size = new System.Drawing.Size(361, 20);
            this.txbx_creditBalance.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date";
            // 
            // dtp_creditOpenDate
            // 
            this.dtp_creditOpenDate.Location = new System.Drawing.Point(86, 163);
            this.dtp_creditOpenDate.Name = "dtp_creditOpenDate";
            this.dtp_creditOpenDate.Size = new System.Drawing.Size(243, 20);
            this.dtp_creditOpenDate.TabIndex = 11;
            // 
            // ltbx_debitorName
            // 
            this.ltbx_debitorName.DisplayMember = "Name";
            this.ltbx_debitorName.FormattingEnabled = true;
            this.ltbx_debitorName.Location = new System.Drawing.Point(264, 49);
            this.ltbx_debitorName.Name = "ltbx_debitorName";
            this.ltbx_debitorName.Size = new System.Drawing.Size(183, 82);
            this.ltbx_debitorName.TabIndex = 10;
            this.ltbx_debitorName.ValueMember = "ID";
            // 
            // ltbx_debitorID
            // 
            this.ltbx_debitorID.DisplayMember = "ID";
            this.ltbx_debitorID.FormattingEnabled = true;
            this.ltbx_debitorID.Location = new System.Drawing.Point(86, 49);
            this.ltbx_debitorID.Name = "ltbx_debitorID";
            this.ltbx_debitorID.Size = new System.Drawing.Size(172, 82);
            this.ltbx_debitorID.TabIndex = 9;
            this.ltbx_debitorID.ValueMember = "ID";
            // 
            // btn_saveNewCredit
            // 
            this.btn_saveNewCredit.Location = new System.Drawing.Point(10, 228);
            this.btn_saveNewCredit.Name = "btn_saveNewCredit";
            this.btn_saveNewCredit.Size = new System.Drawing.Size(437, 23);
            this.btn_saveNewCredit.TabIndex = 8;
            this.btn_saveNewCredit.Text = "Open new credit";
            this.btn_saveNewCredit.UseVisualStyleBackColor = true;
            this.btn_saveNewCredit.Click += new System.EventHandler(this.btn_saveNewCredit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Credit Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Debitor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Credit ID";
            // 
            // txbx_creditAmount
            // 
            this.txbx_creditAmount.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_creditAmount.Location = new System.Drawing.Point(86, 137);
            this.txbx_creditAmount.MaxLength = 8;
            this.txbx_creditAmount.Name = "txbx_creditAmount";
            this.txbx_creditAmount.Size = new System.Drawing.Size(172, 20);
            this.txbx_creditAmount.TabIndex = 2;
            this.txbx_creditAmount.TextChanged += new System.EventHandler(this.txbx_creditAmount_TextChanged);
            this.txbx_creditAmount.Leave += new System.EventHandler(this.txbx_creditAmount_Leave);
            this.txbx_creditAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_creditAmount_KeyPress);
            // 
            // txbx_creditID
            // 
            this.txbx_creditID.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_creditID.Location = new System.Drawing.Point(86, 20);
            this.txbx_creditID.Name = "txbx_creditID";
            this.txbx_creditID.ReadOnly = true;
            this.txbx_creditID.Size = new System.Drawing.Size(361, 20);
            this.txbx_creditID.TabIndex = 0;
            // 
            // lbl_messageCreditAmount
            // 
            this.lbl_messageCreditAmount.AutoSize = true;
            this.lbl_messageCreditAmount.Location = new System.Drawing.Point(264, 140);
            this.lbl_messageCreditAmount.Name = "lbl_messageCreditAmount";
            this.lbl_messageCreditAmount.Size = new System.Drawing.Size(0, 13);
            this.lbl_messageCreditAmount.TabIndex = 15;
            // 
            // NewCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 281);
            this.Controls.Add(this.grbx_debitorDetails);
            this.Name = "NewCredit";
            this.Text = "NewCredit";
            this.grbx_debitorDetails.ResumeLayout(false);
            this.grbx_debitorDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_debitorDetails;
        private System.Windows.Forms.Button btn_saveNewCredit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_creditAmount;
        private System.Windows.Forms.TextBox txbx_creditID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_creditOpenDate;
        private System.Windows.Forms.ListBox ltbx_debitorName;
        private System.Windows.Forms.ListBox ltbx_debitorID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbx_creditBalance;
        private System.Windows.Forms.Label lbl_messageCreditAmount;
    }
}