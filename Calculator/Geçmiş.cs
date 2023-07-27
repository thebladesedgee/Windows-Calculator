using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Geçmiş : Form
    {
        public Geçmiş()
        {
            InitializeComponent();
        }

        private void Geçmiş_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı '_Calculator_ContextDataSet.HesaplamaGeçmişi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hesaplamaGeçmişiTableAdapter.Fill(this._Calculator_ContextDataSet.HesaplamaGeçmişi);

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Context context = new Context();
            HesaplamaGeçmişi hesaplamaGeçmişi = new HesaplamaGeçmişi();
            var tümveriler = context.geçmiş.ToList();
            context.geçmiş.RemoveRange(tümveriler);
            context.SaveChanges();

            MessageBox.Show("Tüm Veriler Silinmiştir...");

            dataGridView1.DataSource = null;
            


        }
    }
}
