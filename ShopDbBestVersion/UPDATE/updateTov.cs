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
    public partial class updateTov : Form
    {
        private SqlConnection sqlConnection = null;
        Form1 frm1 = new Form1();

        public updateTov(Form1 frm1_)
        {
            InitializeComponent();

            label10.Visible = false;

            frm1 = frm1_;
        }

        private void updateTov_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDS.Firmi". При необходимости она может быть перемещена или удалена.
            this.firmiTableAdapter.Fill(this.shopDS.Firmi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDS.Skladi". При необходимости она может быть перемещена или удалена.
            this.skladiTableAdapter.Fill(this.shopDS.Skladi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDS.Otdeli". При необходимости она может быть перемещена или удалена.
            this.otdeliTableAdapter.Fill(this.shopDS.Otdeli);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDS.TovarbI". При необходимости она может быть перемещена или удалена.
            this.tovarbITableAdapter.Fill(this.shopDS.TovarbI);

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ShopDbBestVersion.Properties.Settings.ShopDBConnectionString"].ConnectionString);
            sqlConnection.Open();
        }

        private void updateTov_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.RefreshAllDgv();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxName.Text) && !string.IsNullOrWhiteSpace(tbxName.Text))
            {
                try
                {
                    SqlCommand sqlEdit = new SqlCommand("UPDATE TovarbI SET ID_Otd = @ID_Otd, ID_Skl = @ID_Skl, Name = @Name, NameFirmi = @NameFirmi, Quantity = @Quantity, Price = @Price WHERE ID_Tov = @ID", sqlConnection);
                    sqlEdit.Parameters.AddWithValue("ID", cmbxID.SelectedValue);
                    sqlEdit.Parameters.AddWithValue("ID_Otd", cmbxOtd.SelectedValue);
                    sqlEdit.Parameters.AddWithValue("ID_Skl", cmbxSkl.SelectedValue);
                    sqlEdit.Parameters.AddWithValue("Name", tbxName.Text);
                    sqlEdit.Parameters.AddWithValue("NameFirmi", cmbxNameFirmi.SelectedValue);
                    sqlEdit.Parameters.AddWithValue("Quantity", tbxQuantity.Text);
                    sqlEdit.Parameters.AddWithValue("Price", tbxPrice.Text);
                    sqlEdit.ExecuteNonQuery();

                    if (!cbxDontClose.Checked)
                        this.Close();

                    label10.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                label2.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
