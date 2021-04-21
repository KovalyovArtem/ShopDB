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
    public partial class updateOtd : Form
    {
        private SqlConnection sqlConnection = null;
        Form1 frm1 = new Form1();

        public updateOtd(Form1 frm1_)
        {
            InitializeComponent();

            label1.Visible = false;

            frm1 = frm1_;
        }

        private void updateOtd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDS.Otdeli". При необходимости она может быть перемещена или удалена.
            this.otdeliTableAdapter.Fill(this.shopDS.Otdeli);

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ShopDbBestVersion.Properties.Settings.ShopDBConnectionString"].ConnectionString);
            sqlConnection.Open();
        }

        private void updateOtd_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.RefreshAllDgv();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxName.Text) && !string.IsNullOrWhiteSpace(tbxName.Text))
            {
                try
                {
                    SqlCommand sqlEdit = new SqlCommand("UPDATE Otdeli SET Name = @Name WHERE ID_Otd = @ID", sqlConnection);
                    sqlEdit.Parameters.AddWithValue("ID", cmbxID.SelectedValue);
                    sqlEdit.Parameters.AddWithValue("Name", tbxName.Text);
                    sqlEdit.ExecuteNonQuery();

                    if (!cbxDontClose.Checked)
                        this.Close();

                    label1.Visible = false;
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
