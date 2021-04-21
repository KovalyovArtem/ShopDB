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
    public partial class insertTov : Form
    {
        private SqlConnection sqlConnection = null;
        Form1 frm1 = new Form1();

        public insertTov(Form1 frm1_)
        {
            InitializeComponent();

            frm1 = frm1_;

            label10.Visible = false;
        }

        private void insertTov_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDS.Firmi". При необходимости она может быть перемещена или удалена.
            this.firmiTableAdapter.Fill(this.shopDS.Firmi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDS.Skladi". При необходимости она может быть перемещена или удалена.
            this.skladiTableAdapter.Fill(this.shopDS.Skladi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDS.Otdeli". При необходимости она может быть перемещена или удалена.
            this.otdeliTableAdapter.Fill(this.shopDS.Otdeli);

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ShopDbBestVersion.Properties.Settings.ShopDBConnectionString"].ConnectionString);
            sqlConnection.Open();
        }

        private void insertTov_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.RefreshAllDgv();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxName.Text) && !string.IsNullOrWhiteSpace(tbxName.Text))
            {
                try
                {
                    SqlCommand sqlAdd = new SqlCommand("INSERT INTO TovarbI (ID_Otd, ID_Skl, Name, NameFirmi, Quantity, Price) VALUES (@ID_Otd, @ID_Skl, @Name, @NameFirmi, @Quantity, @Price)", sqlConnection);
                    sqlAdd.Parameters.AddWithValue("ID_Otd", cmbxOtd.SelectedValue);
                    sqlAdd.Parameters.AddWithValue("ID_Skl", cmbxSkl.SelectedValue);
                    sqlAdd.Parameters.AddWithValue("Name", tbxName.Text);
                    sqlAdd.Parameters.AddWithValue("NameFirmi", cmbxNameFirm.SelectedValue);
                    sqlAdd.Parameters.AddWithValue("Quantity", Convert.ToDouble(tbxQuantity.Text));
                    sqlAdd.Parameters.AddWithValue("Price", Convert.ToDouble(tbxPrica.Text));
                    sqlAdd.ExecuteNonQuery();

                    if (!cbxDontClose.Checked)
                        this.Close();

                    label10.Visible = false;
                    tbxName.Clear();
                    tbxPrica.Clear();
                    tbxQuantity.Clear();
                    cmbxNameFirm.Items.Clear();
                    cmbxOtd.Items.Clear();
                    cmbxSkl.Items.Clear();
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
