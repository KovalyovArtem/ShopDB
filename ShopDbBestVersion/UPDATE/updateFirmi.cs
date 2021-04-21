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
    public partial class updateFirmi : Form
    {
        private SqlConnection sqlConnection = null;
        Form1 frm1 = new Form1();

        public updateFirmi(Form1 frm1_)
        {
            InitializeComponent();

            label10.Visible = false;

            frm1 = frm1_;
        }

        private void updateFirmi_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDS.Firmi". При необходимости она может быть перемещена или удалена.
            this.firmiTableAdapter.Fill(this.shopDS.Firmi);

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ShopDbBestVersion.Properties.Settings.ShopDBConnectionString"].ConnectionString);
            sqlConnection.Open();
        }

        private void updateFirmi_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.RefreshAllDgv();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxName.Text) && !string.IsNullOrWhiteSpace(tbxName.Text))
            {
                try
                {
                    SqlCommand sqlEdit = new SqlCommand("UPDATE Firmi SET Name = @Name, Adress = @Adress, Telephone = @Telephone WHERE ID_Firm = @ID", sqlConnection);
                    sqlEdit.Parameters.AddWithValue("ID", cmbxID.SelectedValue);
                    sqlEdit.Parameters.AddWithValue("Name", tbxName.Text);
                    sqlEdit.Parameters.AddWithValue("Adress", tbxAdress.Text);
                    sqlEdit.Parameters.AddWithValue("Telephone", tbxTelephone.Text);
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
