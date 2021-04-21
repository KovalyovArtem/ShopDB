using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopDbBestVersion
{
    public partial class insertProd : Form
    {
        private SqlConnection sqlConnection = null;
        Form1 frm1 = new Form1();

        public insertProd(Form1 frm1_)
        {
            InitializeComponent();

            frm1 = frm1_;

            label10.Visible = false;
        }

        private void insertProd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDS.TovarbI". При необходимости она может быть перемещена или удалена.
            this.tovarbITableAdapter.Fill(this.shopDS.TovarbI);

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ShopDbBestVersion.Properties.Settings.ShopDBConnectionString"].ConnectionString);
            sqlConnection.Open();
        }

        private void insertProd_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.RefreshAllDgv();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbxNamaTov.Text) && !string.IsNullOrWhiteSpace(cmbxNamaTov.Text))
            {
                try
                {
                    SqlCommand sqlAdd = new SqlCommand("INSERT INTO Prodaji (ID_Tov, Date, Tovar, Prodano, Discount) VALUES (@ID_Tov, @Date, @Tovar, @Prodano, @Discount)", sqlConnection);
                    sqlAdd.Parameters.AddWithValue("ID_Tov", cmbxTov.SelectedValue);
                    sqlAdd.Parameters.AddWithValue("Date", Convert.ToDateTime(dtpDate.Text));
                    sqlAdd.Parameters.AddWithValue("Tovar", cmbxNamaTov.Text);
                    sqlAdd.Parameters.AddWithValue("Prodano", Convert.ToDouble(tbxProdano.Text));
                    sqlAdd.Parameters.AddWithValue("Discount", Convert.ToInt32(tbxDiscount.Text));
                    sqlAdd.ExecuteNonQuery();

                    if (!cbxDontClose.Checked)
                        this.Close();

                    label10.Visible = false;
                    cmbxNamaTov.Items.Clear();
                    tbxProdano.Clear();
                    tbxDiscount.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                label10.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
