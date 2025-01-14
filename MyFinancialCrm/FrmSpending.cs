using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MyFinancialCrm.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MyFinancialCrm
{
    public partial class FrmSpending : Form
    {
        public FrmSpending()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void LoadSpendings()
        {
            var spendings = db.Spendings.Select(x => new
            {
                x.SpendingTitle,
                x.SpendingAmount,
                x.SpendingDate,
                CategoryName = x.Categories.CategoryName
            }).ToList();

            dataGridView1.DataSource = spendings;

            var categoryData = db.Spendings
        .GroupBy(e => e.Categories.CategoryName)
        .Select(g => new { Category = g.Key, Total = g.Sum(e => e.SpendingAmount) })
        .ToList();

            chart1.Series.Clear();
            Series series1 = chart1.Series.Add("Kategoriler");
            series1.ChartType = SeriesChartType.Pie;

            foreach (var item in categoryData)
            {
                series1.Points.AddXY(item.Category, item.Total);
            }

        }
        private void FrmSpending_Load(object sender, EventArgs e)
        {
            LoadSpendings();
            LoadSpendings();

            cmbKategoriGetir.DataSource = db.Categories.Select(c => c.CategoryName).ToList();
            cmbKategoriGetir.SelectedIndex = -1;

            cmbKategori.DataSource = db.Categories.Select(c => c.CategoryName).ToList();
            cmbKategori.SelectedIndex = -1;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("My Financial Crm programından çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnKategoriFiltrele_Click(object sender, EventArgs e)
        {
            string selectedCategory = cmbKategoriGetir.SelectedItem?.ToString();

            var filteredSpendings = db.Spendings
                     .Where(s => s.Categories.CategoryName == selectedCategory) 
                     .Select(x => new
       {
           x.SpendingTitle,
           x.SpendingAmount,
           x.SpendingDate,
           CategoryName = x.Categories.CategoryName 
       })
                     .ToList();

           
            dataGridView1.DataSource = filteredSpendings;
        }

        private void btnTumu_Click(object sender, EventArgs e)
        {
            LoadSpendings();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            LoadSpendings();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var newSpending = new Spendings
            {
                SpendingTitle = txtHarcama.Text,
                SpendingAmount = int.Parse(txtUcret.Text), 
                SpendingDate = dateTimePicker1.Value,
                CategoryId = db.Categories.FirstOrDefault(c => c.CategoryName == cmbKategori.Text)?.CategoryID,
            };

            
            db.Spendings.Add(newSpending);
            db.SaveChanges();

           
            MessageBox.Show("Harcama başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

          
            LoadSpendings();

           
            txtHarcama.Clear();
            txtUcret.Clear();
            cmbKategori.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Today;
        }

        private void cmbKategoriGetir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnKategorilerForm_Click(object sender, EventArgs e)
        {
            FrmKategoriler frm = new FrmKategoriler();
            frm.Show();
            this.Hide();
        }
    }
}
