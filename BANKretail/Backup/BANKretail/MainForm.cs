using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace BANKretail
{
    public partial class MainForm : Form
    {
        DAL dal = new DAL();
        ArrayList allDebitors;
        public MainForm()
        {
            InitializeComponent();

            

            allDebitors = dal.GetAllDebitors();
            dgv_debitors.DataSource = allDebitors;
            SettingsDGV_Debitors();
        }

        void SettingsDGV_Debitors()
        {
            try
            {
                dgv_debitors.Columns["ID"].Visible = false;
                dgv_debitors.Columns["PostNumber"].Visible = false;
                dgv_debitors.Columns["PhoneNumber"].Visible = false;

                dgv_debitors.TopLeftHeaderCell.Value = "#";
            }
            catch
            { 
            
            }
        }

        private void dgv_debitors_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txbx_debitorID.Text = dgv_debitors.Rows[e.RowIndex].Cells[0].Value.ToString();
            txbx_debitorName.Text = dgv_debitors.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            txbx_debitorPostNumber.Text = dgv_debitors.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString();

            string phone = dgv_debitors.Rows[e.RowIndex].Cells[3].Value.ToString();
            txbx_phoneNumber.Text = (phone == String.Empty) ? "Нет данных" : phone;

            dgv_credits.DataSource = dal.GetAllCreditsForDebitor(dgv_debitors.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgv_debitors.CellEnter += new DataGridViewCellEventHandler(dgv_debitors_CellEnter);
            dgv_credits.CellEnter += new DataGridViewCellEventHandler(dgv_credits_CellEnter);
        }

        void dgv_credits_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string creditorID = dgv_credits.CurrentRow.Cells[0].Value.ToString();
            dgv_payments.DataSource = dal.GetAllPaymentsForCredit(creditorID);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы действительно желаете закрыть приложение?", "Bank manager", MessageBoxButtons.OKCancel) == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewDebitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDebitor newDebitor = new NewDebitor();
            if (newDebitor.ShowDialog() == DialogResult.OK)
            {
                allDebitors.Clear();
                allDebitors = dal.GetAllDebitors();
                dgv_debitors.DataSource = allDebitors;
                
                MessageBox.Show("Новый дебитор успешно создан",
                       "Банк", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Новый дебитор не создан!!!",
                    "Банк", MessageBoxButtons.OK);
        }

        private void openNewCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCredit newCredit = new NewCredit();
            if (newCredit.ShowDialog() == DialogResult.OK)
            {
                dgv_credits.DataSource = 
                    dal.GetAllCreditsForDebitor(dgv_debitors.CurrentRow.Cells["ID"].Value.ToString());
                MessageBox.Show("Новый кредит успешно выдан",
                       "Банк", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Новый кредит не выдан!!!",
                    "Банк", MessageBoxButtons.OK);
        }

        private void passNewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPayment newPayment = new NewPayment();
            if (newPayment.ShowDialog() == DialogResult.OK)
            {
                dgv_credits.DataSource =
                    dal.GetAllCreditsForDebitor(dgv_debitors.CurrentRow.Cells["ID"].Value.ToString());
                MessageBox.Show("Новый платёж успешно принят",
                       "Банк", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Новый платёж не принят!!!",
                    "Банк", MessageBoxButtons.OK);
        }

        private void saveDataToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dal.SaveDBToLocalFile())
                MessageBox.Show("Данные БД были успешно сохранены в локальных файлах", 
                    "Банк менеджер", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else
                MessageBox.Show("Данные БД не были сохранены в локальных файлах!", 
                    "Банк менеджер", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

        }

        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            object headValue = ((DataGridView)sender).Rows[e.RowIndex].HeaderCell.Value;
            if (headValue == null || !headValue.Equals((e.RowIndex + 1).ToString()))
                ((DataGridView)sender).Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }
        


        List<DataGridViewRow> searchedRows;
        int currentRow;
        private void btn_search_Click(object sender, EventArgs e)
        {
            searchedRows = new List<DataGridViewRow>();
            string debName = txbx_searchedDebName.Text.Trim();
            string debPostNumber = txbx_searchedDebPostNumber.Text.Trim();
            string debPhoneNumber = txbx_searchedDebPhoneNumber.Text.Trim();

            if (!chbx_DB.Checked)
            {
                dgv_debitors.DataSource = allDebitors;
                foreach (DataGridViewRow row in dgv_debitors.Rows)
                {
                    if (
                        row.Cells["Name"].FormattedValue.ToString().Contains(debName) &&
                        row.Cells["PostNumber"].FormattedValue.ToString().Contains(debPostNumber) &&
                        row.Cells["PhoneNumber"].FormattedValue.ToString().Contains(debPhoneNumber)
                        )
                        searchedRows.Add(row);
                }
                if (searchedRows.Count == 0)
                {
                    MessageBox.Show("По данному запросу не найдено записей");
                    btn_nextRow.Enabled = false;
                    return;
                }

                MessageBox.Show("Найдено " + searchedRows.Count + " записей");
                btn_nextRow.Enabled = true;
                currentRow = -1;
                btn_nextRow_Click(null, null);
            }
            else
            {
                btn_nextRow.Enabled = false;
                ArrayList searchedDebitors = dal.SearchDebitors(debName, debPostNumber, debPhoneNumber);
                if (searchedDebitors == null || searchedDebitors.Count == 0)
                {
                    MessageBox.Show("Ничего не найдено");
                    return;
                }
                MessageBox.Show("Найдено " + searchedDebitors.Count + " записей");
                dgv_debitors.DataSource = searchedDebitors;
            }
            
        }

        private void btn_nextRow_Click(object sender, EventArgs e)
        {
            if (currentRow == searchedRows.Count - 1)
                currentRow = 0;
            else
                currentRow++;

            dgv_debitors.CurrentCell = searchedRows[currentRow].Cells[1];
        }
    }
}
