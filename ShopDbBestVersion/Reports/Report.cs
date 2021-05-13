using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ShopDbBestVersion
{
    public partial class Report : Form
    {
        private SqlConnection sqlConnection = null;

        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            this.ProdajiTableAdapter.Fill(this.ShopDS.Prodaji);
            this.TovarbITableAdapter.Fill(this.ShopDS.TovarbI);

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ShopDbBestVersion.Properties.Settings.ShopDBConnectionString"].ConnectionString);
            sqlConnection.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT ID_Prod, TovarbI.ID_Tov, Name, Prodano, Price = (Price - ((Price * Discount) / 100))  FROM Prodaji, TovarbI WHERE TovarbI.ID_Tov = Prodaji.ID_Tov", sqlConnection);
            DataSet ds = new DataSet();
            sqlData.Fill(ds);
            ds.Tables[0].Columns.Add("TotalPrice");
            dgvReport.DataSource = ds.Tables[0];
            ds.Tables[0].Columns["TotalPrice"].Expression = "Price * Prodano";


            //SqlCommand command = new SqlCommand("SELECT SUM(TotalPrice) FROM @table", sqlConnection);
            //command.Parameters.AddWithValue("table", sqlData);
            //lbTotalMoney.Text = command.ExecuteScalar().ToString();

            double summ = 0;

            for (int j = 0; j < dgvReport.RowCount; j++)
            {
                summ += Convert.ToDouble(dgvReport[5, j].Value);

            }
            lbTotalMoney.Text = "Итоговая сумма продаж за сегодня:   " + summ.ToString();
        }
    }
}
