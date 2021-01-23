using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtubusBiletSatisOtomasyonu
{
    public partial class Raporlama : Form
    {
        public Raporlama()
        {
            InitializeComponent();
        }

        private void Raporlama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'OtobusBiletDBDataSet.Kayıtlar' table. You can move, or remove it, as needed.
            this.KayıtlarTableAdapter.Fill(this.OtobusBiletDBDataSet.Kayıtlar);

            this.reportViewer1.RefreshReport();
        }
    }
}
