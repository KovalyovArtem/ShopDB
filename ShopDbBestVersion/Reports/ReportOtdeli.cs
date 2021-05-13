using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopDbBestVersion
{
    public partial class ReportOtdeli : Form
    {
        public ReportOtdeli()
        {
            InitializeComponent();
        }

        private void ReportOtdeli_Load(object sender, EventArgs e)
        {
            ShopDS.EnforceConstraints = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ShopDS.Otdeli". При необходимости она может быть перемещена или удалена.
            this.OtdeliTableAdapter.Fill(this.ShopDS.Otdeli);

            this.reportViewer1.RefreshReport();
        }
    }
}
