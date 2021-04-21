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
    public partial class insertFirmi : Form
    {
        private SqlConnection sqlConnection = null;
        Form1 frm1 = new Form1();

        public insertFirmi(Form1 frm1_)
        {
            InitializeComponent();

            frm1 = frm1_;

            label10.Visible = false;
        }

        private void insertFirmi_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ShopDbBestVersion.Properties.Settings.ShopDBConnectionString"].ConnectionString);
            sqlConnection.Open();
        }

        private void insertFirmi_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.RefreshAllDgv();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxName.Text) && !string.IsNullOrWhiteSpace(tbxName.Text))
            {
                try
                {
                    SqlCommand sqlAdd = new SqlCommand("INSERT INTO Firmi (Name, Adress, Telephone) VALUES (@Name, @Adress, @Telephone)", sqlConnection);
                    sqlAdd.Parameters.AddWithValue("Name", tbxName.Text);
                    sqlAdd.Parameters.AddWithValue("Adress", tbxAdress.Text);
                    sqlAdd.Parameters.AddWithValue("Telephone", tbxTelephone.Text);
                    sqlAdd.ExecuteNonQuery();
                    if (!cbxDontClose.Checked)
                        this.Close();
                    label10.Visible = false;
                    tbxName.Clear();
                    tbxAdress.Clear();
                    tbxTelephone.Clear();
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
    }
}
