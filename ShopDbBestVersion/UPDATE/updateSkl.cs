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
    public partial class updateSkl : Form
    {
        private SqlConnection sqlConnection = null;
        Form1 frm1 = new Form1();

        public updateSkl(Form1 frm1_)
        {
            InitializeComponent();

            label10.Visible = false;

            frm1 = frm1_;
        }

        private void updateSkl_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDS.Skladi". При необходимости она может быть перемещена или удалена.
            this.skladiTableAdapter.Fill(this.shopDS.Skladi);

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ShopDbBestVersion.Properties.Settings.ShopDBConnectionString"].ConnectionString);
            sqlConnection.Open();
        }

        private void updateSkl_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.RefreshAllDgv();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxAdress.Text) && !string.IsNullOrWhiteSpace(tbxAdress.Text) &&
                !string.IsNullOrEmpty(tbxRepresentative.Text) && !string.IsNullOrWhiteSpace(tbxRepresentative.Text) &&
                !string.IsNullOrEmpty(tbxTelephone.Text) && !string.IsNullOrWhiteSpace(tbxTelephone.Text))
            {
                try
                {
                    SqlCommand sqlEdit = new SqlCommand("UPDATE Skladi SET Telephone = @Telephone, Adress = @Adress, Manager = @Manager, Representative = @Representative WHERE ID_Skl = @ID", sqlConnection);
                    sqlEdit.Parameters.AddWithValue("ID", cmbxID.SelectedValue);
                    sqlEdit.Parameters.AddWithValue("Telephone", tbxTelephone.Text);
                    sqlEdit.Parameters.AddWithValue("Adress", tbxAdress.Text);
                    sqlEdit.Parameters.AddWithValue("Manager", tbxManager.Text);
                    sqlEdit.Parameters.AddWithValue("Representative", tbxRepresentative.Text);
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
