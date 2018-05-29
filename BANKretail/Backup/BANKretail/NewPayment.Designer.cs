namespace BANKretail
{
    partial class NewPayment
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
            this.lbl_message = new System.Windows.Forms.Label();
            this.ltbx_creditBalance = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ltbx_creditAmount = new System.Windows.Forms.ListBox();
            this.ltbx_creditID = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_messageCreditAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_paymentPassDate = new System.Windows.Forms.DateTimePicker();
            this.ltbx_debitorName = new System.Windows.Forms.ListBox();
            this.ltbx_debitorID = new System.Windows.Forms.ListBox();
            this.btn_saveNewPayment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_paymentAmount = new System.Windows.Forms.TextBox();
            this.txbx_paymentID = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.grbx_debitorDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_debitorDetails
            // 
            this.grbx_debitorDetails.Controls.Add(this.btn_refresh);
            this.grbx_debitorDetails.Controls.Add(this.lbl_message);
            this.grbx_debitorDetails.Controls.Add(this.ltbx_creditBalance);
            this.grbx_debitorDetails.Controls.Add(this.label6);
            this.grbx_debitorDetails.Controls.Add(this.ltbx_creditAmount);
            this.grbx_debitorDetails.Controls.Add(this.ltbx_creditID);
            this.grbx_debitorDetails.Controls.Add(this.label7);
            this.grbx_debitorDetails.Controls.Add(this.lbl_messageCreditAmount);
            this.grbx_debitorDetails.Controls.Add(this.label5);
            this.grbx_debitorDetails.Controls.Add(this.dtp_paymentPassDate);
            this.grbx_debitorDetails.Controls.Add(this.ltbx_debitorName);
            this.grbx_debitorDetails.Controls.Add(this.ltbx_debitorID);
            this.grbx_debitorDetails.Controls.Add(this.btn_saveNewPayment);
            this.grbx_debitorDetails.Controls.Add(this.label3);
            this.grbx_debitorDetails.Controls.Add(this.label2);
            this.grbx_debitorDetails.Controls.Add(this.label1);
            this.grbx_debitorDetails.Controls.Add(this.txbx_paymentAmount);
            this.grbx_debitorDetails.Controls.Add(this.txbx_paymentID);
            this.grbx_debitorDetails.Location = new System.Drawing.Point(12, 4);
            this.grbx_debitorDetails.Name = "grbx_debitorDetails";
            this.grbx_debitorDetails.Size = new System.Drawing.Size(517, 331);
            this.grbx_debitorDetails.TabIndex = 4;
            this.grbx_debitorDetails.TabStop = false;
            this.grbx_debitorDetails.Text = "Debitors details";
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_message.Location = new System.Drawing.Point(335, 232);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(130, 13);
            this.lbl_message.TabIndex = 21;
            this.lbl_message.Text = "Введите сумму платежа";
            // 
            // ltbx_creditBalance
            // 
            this.ltbx_creditBalance.DisplayMember = "Balance";
            this.ltbx_creditBalance.FormattingEnabled = true;
            this.ltbx_creditBalance.Location = new System.Drawing.Point(378, 137);
            this.ltbx_creditBalance.Name = "ltbx_creditBalance";
            this.ltbx_creditBalance.Size = new System.Drawing.Size(133, 82);
            this.ltbx_creditBalance.TabIndex = 20;
            this.ltbx_creditBalance.ValueMember = "Balance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 19;
            // 
            // ltbx_creditAmount
            // 
            this.ltbx_creditAmount.DisplayMember = "Amount";
            this.ltbx_creditAmount.FormattingEnabled = true;
            this.ltbx_creditAmount.Location = new System.Drawing.Point(239, 137);
            this.ltbx_creditAmount.Name = "ltbx_creditAmount";
            this.ltbx_creditAmount.Size = new System.Drawing.Size(133, 82);
            this.ltbx_creditAmount.TabIndex = 18;
            this.ltbx_creditAmount.ValueMember = "ID";
            // 
            // ltbx_creditID
            // 
            this.ltbx_creditID.DisplayMember = "ID";
            this.ltbx_creditID.FormattingEnabled = true;
            this.ltbx_creditID.Location = new System.Drawing.Point(86, 137);
            this.ltbx_creditID.Name = "ltbx_creditID";
            this.ltbx_creditID.Size = new System.Drawing.Size(147, 82);
            this.ltbx_creditID.TabIndex = 17;
            this.ltbx_creditID.ValueMember = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Credit";
            // 
            // lbl_messageCreditAmount
            // 
            this.lbl_messageCreditAmount.AutoSize = true;
            this.lbl_messageCreditAmount.Location = new System.Drawing.Point(264, 140);
            this.lbl_messageCreditAmount.Name = "lbl_messageCreditAmount";
            this.lbl_messageCreditAmount.Size = new System.Drawing.Size(0, 13);
            this.lbl_messageCreditAmount.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date";
            // 
            // dtp_paymentPassDate
            // 
            this.dtp_paymentPassDate.Location = new System.Drawing.Point(86, 254);
            this.dtp_paymentPassDate.Name = "dtp_paymentPassDate";
            this.dtp_paymentPassDate.Size = new System.Drawing.Size(243, 20);
            this.dtp_paymentPassDate.TabIndex = 11;
            // 
            // ltbx_debitorName
            // 
            this.ltbx_debitorName.DisplayMember = "Name";
            this.ltbx_debitorName.FormattingEnabled = true;
            this.ltbx_debitorName.Location = new System.Drawing.Point(308, 49);
            this.ltbx_debitorName.Name = "ltbx_debitorName";
            this.ltbx_debitorName.Size = new System.Drawing.Size(203, 82);
            this.ltbx_debitorName.TabIndex = 10;
            this.ltbx_debitorName.ValueMember = "ID";
            this.ltbx_debitorName.SelectedIndexChanged += new System.EventHandler(this.ltbx_debitor_SelectedIndexChanged);
            // 
            // ltbx_debitorID
            // 
            this.ltbx_debitorID.DisplayMember = "ID";
            this.ltbx_debitorID.FormattingEnabled = true;
            this.ltbx_debitorID.Location = new System.Drawing.Point(86, 49);
            this.ltbx_debitorID.Name = "ltbx_debitorID";
            this.ltbx_debitorID.Size = new System.Drawing.Size(216, 82);
            this.ltbx_debitorID.TabIndex = 9;
            this.ltbx_debitorID.ValueMember = "ID";
            this.ltbx_debitorID.SelectedIndexChanged += new System.EventHandler(this.ltbx_debitor_SelectedIndexChanged);
            // 
            // btn_saveNewPayment
            // 
            this.btn_saveNewPayment.Location = new System.Drawing.Point(6, 298);
            this.btn_saveNewPayment.Name = "btn_saveNewPayment";
            this.btn_saveNewPayment.Size = new System.Drawing.Size(505, 23);
            this.btn_saveNewPayment.TabIndex = 8;
            this.btn_saveNewPayment.Text = "Pass new payment";
            this.btn_saveNewPayment.UseVisualStyleBackColor = true;
            this.btn_saveNewPayment.Click += new System.EventHandler(this.btn_saveNewPayment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount";
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
            // txbx_paymentAmount
            // 
            this.txbx_paymentAmount.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_paymentAmount.Location = new System.Drawing.Point(86, 228);
            this.txbx_paymentAmount.MaxLength = 12;
            this.txbx_paymentAmount.Name = "txbx_paymentAmount";
            this.txbx_paymentAmount.Size = new System.Drawing.Size(186, 20);
            this.txbx_paymentAmount.TabIndex = 2;
            this.txbx_paymentAmount.Leave += new System.EventHandler(this.txbx_paymentAmount_Leave);
            this.txbx_paymentAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_paymentAmount_KeyPress);
            // 
            // txbx_paymentID
            // 
            this.txbx_paymentID.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_paymentID.Location = new System.Drawing.Point(86, 20);
            this.txbx_paymentID.Name = "txbx_paymentID";
            this.txbx_paymentID.ReadOnly = true;
            this.txbx_paymentID.Size = new System.Drawing.Size(425, 20);
            this.txbx_paymentID.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(276, 227);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(53, 23);
            this.btn_refresh.TabIndex = 22;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // NewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 346);
            this.Controls.Add(this.grbx_debitorDetails);
            this.Name = "NewPayment";
            this.Text = "NewPayment";
            this.grbx_debitorDetails.ResumeLayout(false);
            this.grbx_debitorDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_debitorDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ltbx_creditAmount;
        private System.Windows.Forms.ListBox ltbx_creditID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_messageCreditAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_paymentPassDate;
        private System.Windows.Forms.ListBox ltbx_debitorName;
        private System.Windows.Forms.ListBox ltbx_debitorID;
        private System.Windows.Forms.Button btn_saveNewPayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_paymentAmount;
        private System.Windows.Forms.TextBox txbx_paymentID;
        private System.Windows.Forms.ListBox ltbx_creditBalance;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Button btn_refresh;
    }
}