using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ShopDbBestVersion
{
    public partial class insertDol : Form
    {
        private SqlConnection sqlConnection = null;
        Form1 frm1 = new Form1();

        public insertDol(Form1 frm1_)
        {
            InitializeComponent();

            frm1 = frm1_;
            label2.Visible = false;
        }

        private void insertDol_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ShopDbBestVersion.Properties.Settings.ShopDBConnectionString"].ConnectionString);
            sqlConnection.Open();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxName.Text) && !string.IsNullOrWhiteSpace(tbxName.Text))
            {
                try
                {
                    SqlCommand sqlAdd = new SqlCommand("INSERT INTO Dolzhnost (Name) VALUES (@Name)", sqlConnection);
                    sqlAdd.Parameters.AddWithValue("Name", tbxName.Text);
                    sqlAdd.ExecuteNonQuery();
                    if (!cbxDontClose.Checked)
                        this.Close();
                    label2.Visible = false;
                    tbxName.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                label2.Visible = true;
            }
        }

        private void insertDol_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.RefreshAllDgv();
        }
    }
}
