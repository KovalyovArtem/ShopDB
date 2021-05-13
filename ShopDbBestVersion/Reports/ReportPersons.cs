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
    public partial class ReportPersons : Form
    {
        public ReportPersons()
        {
            InitializeComponent();
        }

        private void ReportPersons_Load(object sender, EventArgs e)
        {
            ShopDS.EnforceConstraints = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ShopDS.Persons". При необходимости она может быть перемещена или удалена.
            this.PersonsTableAdapter.Fill(this.ShopDS.Persons);

            this.reportViewer1.RefreshReport();
        }
    }
}
