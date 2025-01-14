using System;
using System.Linq;
using System.Windows.Forms;
using MyFinancialCrm.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace MyFinancialCrm
{
    public partial class FrmBankProcess : Form
    {
        public FrmBankProcess()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void LoadAllBankProcesses()
        {
            dataGridView1.DataSource = db.BankProcesses.Select(b => new
            {
                b.Description,
                b.ProcessDate,
                b.ProcessType,
                b.Amount,
                b.BankId
            }).ToList();

        }
        private void FrmBankProcess_Load(object sender, EventArgs e)
        {
            LoadAllBankProcesses();
        }



        private void btnIdGoreGetir_Click(object sender, EventArgs e)
        {
            // BankId'ye göre getirme
            if (int.TryParse(txtBankId.Text, out int bankId))
            {
                var filteredData = db.BankProcesses.Where(bp => bp.BankId == bankId).ToList();
                dataGridView1.DataSource = filteredData;

                if (filteredData.Count == 0)
                {
                    MessageBox.Show("Girilen BankId'ye ait kayıt bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir BankId giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.BankProcesses.ToList();
        }

        private void btnTariheGoreGetir_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;

            var filteredData = db.BankProcesses.Where(bp => bp.ProcessDate == selectedDate).ToList();
            dataGridView1.DataSource = filteredData;

            if (filteredData.Count == 0)
            {
                MessageBox.Show("Seçilen tarihe ait kayıt bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("My Financial Crm programından çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnKategorilerForm_Click(object sender, EventArgs e)
        {
            FrmKategoriler frm = new FrmKategoriler();
            frm.Show();
            this.Hide();
        }

        private void btnBankalarForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnBillsForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmSpending frm = new FrmSpending();
            frm.Show();
            this.Hide();
        }

        private void btnBankaHareketleriForm_Click(object sender, EventArgs e)
        {
            FrmBankProcess frm = new FrmBankProcess();
            frm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show(); 
            this.Hide();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            FrmAyarlar frm = new FrmAyarlar();
            frm.Show();
            this.Hide();
        }
    }
}
