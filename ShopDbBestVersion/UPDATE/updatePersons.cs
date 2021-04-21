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
    public partial class updatePersons : Form
    {
        private SqlConnection sqlConnection = null;
        Form1 frm1 = new Form1();

        public updatePersons(Form1 frm1_)
        {
            InitializeComponent();

            label10.Visible = false;

            frm1 = frm1_;
        }

        private void updatePersons_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDS.Otdeli". При необходимости она может быть перемещена или удалена.
            this.otdeliTableAdapter.Fill(this.shopDS.Otdeli);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDS.Dolzhnost". При необходимости она может быть перемещена или удалена.
            this.dolzhnostTableAdapter.Fill(this.shopDS.Dolzhnost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDS.Persons". При необходимости она может быть перемещена или удалена.
            this.personsTableAdapter.Fill(this.shopDS.Persons);

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ShopDbBestVersion.Properties.Settings.ShopDBConnectionString"].ConnectionString);
            sqlConnection.Open();
        }

        private void updatePersons_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.RefreshAllDgv();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxName.Text) && !string.IsNullOrWhiteSpace(tbxName.Text))
            {
                try
                {
                    SqlCommand sqlEdit = new SqlCommand("UPDATE Persons SET SecondName = @SecondName, Name = @Name, LastName = @LastName, Date = @Date, Adress = @Adress, Telephone = @Telephone, ID_Dol = @ID_Dol, ID_Otd = @ID_Otd, Salary = @Salary WHERE ID_Pers = @ID", sqlConnection);
                    sqlEdit.Parameters.AddWithValue("ID", cmbxID.SelectedValue);
                    sqlEdit.Parameters.AddWithValue("SecondName", tbxFirstName.Text);
                    sqlEdit.Parameters.AddWithValue("Name", tbxName.Text);
                    sqlEdit.Parameters.AddWithValue("LastName", tbxLastName.Text);
                    sqlEdit.Parameters.AddWithValue("Date", Convert.ToDateTime(dtpDate.Text));
                    sqlEdit.Parameters.AddWithValue("Adress", tbxAdress.Text);
                    sqlEdit.Parameters.AddWithValue("Telephone", tbxTelephone.Text);
                    sqlEdit.Parameters.AddWithValue("ID_Dol", cmbxDol.SelectedValue);
                    sqlEdit.Parameters.AddWithValue("ID_Otd", cmbxOtd.SelectedValue);
                    sqlEdit.Parameters.AddWithValue("Salary", tbxSalary.Text);
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
