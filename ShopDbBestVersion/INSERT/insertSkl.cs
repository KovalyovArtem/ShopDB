using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ShopDbBestVersion
{
    public partial class insertSkl : Form
    {
        private SqlConnection sqlConnection = null;
        Form1 frm1 = new Form1();

        public insertSkl(Form1 frm1_)
        {
            InitializeComponent();

            frm1 = frm1_;

            label10.Visible = false;
        }

        private void insertSkl_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ShopDbBestVersion.Properties.Settings.ShopDBConnectionString"].ConnectionString);
            sqlConnection.Open();
        }

        private void insertSkl_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.RefreshAllDgv();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxAdress.Text) && !string.IsNullOrWhiteSpace(tbxAdress.Text) &&
                !string.IsNullOrEmpty(tbxRepresentative.Text) && !string.IsNullOrWhiteSpace(tbxRepresentative.Text) &&
                !string.IsNullOrEmpty(tbxTelephone.Text) && !string.IsNullOrWhiteSpace(tbxTelephone.Text))
            {
                try
                {
                    SqlCommand sqlAdd = new SqlCommand("INSERT INTO Skladi (Telephone, Adress, Manager, Representative) VALUES (@Telephone, @Adress, @Manager, @Representative)", sqlConnection);
                    sqlAdd.Parameters.AddWithValue("Telephone", tbxTelephone.Text);
                    sqlAdd.Parameters.AddWithValue("Adress", tbxAdress.Text);
                    sqlAdd.Parameters.AddWithValue("Manager", tbxTelephone.Text);
                    sqlAdd.Parameters.AddWithValue("Representative", tbxTelephone.Text);
                    sqlAdd.ExecuteNonQuery();

                    if (!cbxDontClose.Checked)
                        this.Close();

                    label10.Visible = false;
                    tbxRepresentative.Clear();
                    tbxAdress.Clear();
                    tbxTelephone.Clear();
                    tbxManager.Clear();
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
