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
    public partial class insertPersons : Form
    {
        private SqlConnection sqlConnection = null;
        Form1 frm1 = new Form1();

        public insertPersons(Form1 frm1_)
        {
            InitializeComponent();
            
            frm1 = frm1_;

            label10.Visible = false;
        }

        private void insertPersons_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDS.Otdeli". При необходимости она может быть перемещена или удалена.
            this.otdeliTableAdapter.Fill(this.shopDS.Otdeli);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDS.Dolzhnost". При необходимости она может быть перемещена или удалена.
            this.dolzhnostTableAdapter.Fill(this.shopDS.Dolzhnost);

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ShopDbBestVersion.Properties.Settings.ShopDBConnectionString"].ConnectionString);
            sqlConnection.Open();
        }

        private void insertPersons_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.RefreshAllDgv();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxName.Text) && !string.IsNullOrWhiteSpace(tbxName.Text))
            {
                try
                {
                    SqlCommand sqlAdd = new SqlCommand("INSERT INTO Persons (SecondName, Name, LastName, Date, Adress, Telephone, ID_Dol, ID_Otd, Salary) VALUES (@SecondName, @Name, @LastName, @Date, @Adress, @Telephone, @ID_Dol, @ID_Otd, @Salary)", sqlConnection);
                    sqlAdd.Parameters.AddWithValue("SecondName", tbxFistName.Text);
                    sqlAdd.Parameters.AddWithValue("Name", tbxName.Text);
                    sqlAdd.Parameters.AddWithValue("LastName", tbxLastName.Text);
                    sqlAdd.Parameters.AddWithValue("Date", Convert.ToDateTime(dtpDate.Text));
                    sqlAdd.Parameters.AddWithValue("Adress", tbxAdress.Text);
                    sqlAdd.Parameters.AddWithValue("Telephone", tbxTelephone.Text);
                    sqlAdd.Parameters.AddWithValue("ID_Dol", cmbxDol.SelectedValue);
                    sqlAdd.Parameters.AddWithValue("ID_Otd", cmbxOtd.SelectedValue);
                    sqlAdd.Parameters.AddWithValue("Salary", tbxSalary.Text);
                    sqlAdd.ExecuteNonQuery();

                    if (!cbxDontClose.Checked)
                        this.Close();

                    label10.Visible = false;

                    tbxFistName.Clear();
                    tbxName.Clear();
                    tbxLastName.Clear();
                    tbxAdress.Clear();
                    tbxTelephone.Clear();
                    cmbxDol.Items.Clear();
                    cmbxOtd.Items.Clear();
                    tbxSalary.Clear();
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
