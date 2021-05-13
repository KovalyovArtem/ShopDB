using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ShopDbBestVersion
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;

        public Form1()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ShopDbBestVersion.Properties.Settings.ShopDBConnectionString"].ConnectionString);
            sqlConnection.Open();

            SqlCommand sqlDel = new SqlCommand("DELETE FROM Prodaji WHERE Date < @Date", sqlConnection);
            sqlDel.Parameters.AddWithValue("Date", DateTime.Today);
            sqlDel.ExecuteNonQuery();

            spcMain.Panel2.Visible = false;
            spcMain.Panel2Collapsed = true;

            #region КОНТЕЙНЕРЫ
            #region Скрытие Контейнеров ОСНОВНЫХ
            spcMainForKey1.Panel2.Visible = false;
            spcMainForKey1.Panel2Collapsed = true;
            spcMainForFKSec.Panel2.Visible = false;
            spcMainForFKSec.Panel2Collapsed = true;
            #endregion
            #region Скрытие Контейнеров ВТОРИЧНЫХ
            SecSpcMain.Panel2.Visible = false;
            SecSpcMain.Panel2Collapsed = true;
            SecSpcFK.Panel2.Visible = false;
            SecSpcFK.Panel2Collapsed = true;
            #endregion
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tovarbITableAdapter.Fill(this.shopDS.TovarbI);
            this.dolzhnostTableAdapter.Fill(this.shopDS.Dolzhnost);
            this.otdeliTableAdapter.Fill(this.shopDS.Otdeli);
            this.skladiTableAdapter.Fill(this.shopDS.Skladi);
            this.tovarbITableAdapter.Fill(this.shopDS.TovarbI);
            this.prodajiTableAdapter.Fill(this.shopDS.Prodaji);            
            this.personsTableAdapter.Fill(this.shopDS.Persons);
            this.firmiTableAdapter.Fill(this.shopDS.Firmi);
        }

        #region Выбор таблицы + Кнопка Разделения окна
        private void tsWindows_Click(object sender, EventArgs e)
        {
            if (tsWindows.Text == "Разделить окно")
            {
                spcMain.Panel2.Visible = true;
                spcMain.Panel2Collapsed = false;
                tsWindows.Text = "Объеденить";
            }
            else if (tsWindows.Text == "Объеденить")
            {
                spcMain.Panel2.Visible = false;
                spcMain.Panel2Collapsed = true;
                tsWindows.Text = "Разделить окно";
            }
        }

        private void cbxSelectTableMain_SelectedIndexChanged(object sender, EventArgs e) // Заполнение 1-го грида
        {
            tbxSearch.Clear();
            switch (cbxSelectTableMain.SelectedIndex)
            {
                case 0: //Отделы
                    btnUpdate.Text = "Изменить";
                    spcMainForKey1.Panel2.Visible = true;
                    spcMainForKey1.Panel2Collapsed = false;
                    spcMainForFKSec.Panel2.Visible = true;
                    spcMainForFKSec.Panel2Collapsed = false;
                    dgvMain.DataSource = null;
                    dgvMain.DataSource = otdeliBindingSource;
                    dgvMainForeignKey.DataSource = otdeliPersonsBindingSource;
                    dgvMainFK2.DataSource = otdeliTovarbIBindingSource;
                    break;
                case 1: //Продажи
                    btnUpdate.Text = "Применить";
                    spcMainForKey1.Panel2.Visible = false;
                    spcMainForKey1.Panel2Collapsed = true;
                    dgvMain.DataSource = null;
                    dgvMain.DataSource = prodajiBindingSource;
                    break;
                case 2: //Склады
                    btnUpdate.Text = "Изменить";
                    spcMainForKey1.Panel2.Visible = true;
                    spcMainForKey1.Panel2Collapsed = false;
                    spcMainForFKSec.Panel2.Visible = false;
                    spcMainForFKSec.Panel2Collapsed = true;
                    dgvMain.DataSource = null;
                    dgvMain.DataSource = skladiBindingSource;
                    dgvMainForeignKey.DataSource = skladiTovarbIBindingSource;
                    break;
                case 3: //Сотрудники
                    btnUpdate.Text = "Изменить";
                    spcMainForKey1.Panel2.Visible = false;
                    spcMainForKey1.Panel2Collapsed = true;
                    dgvMain.DataSource = null;
                    dgvMain.DataSource = personsBindingSource;
                    break;
                case 4: //Товары
                    btnUpdate.Text = "Изменить";
                    spcMainForKey1.Panel2.Visible = false;
                    spcMainForKey1.Panel2Collapsed = true;
                    dgvMain.DataSource = null;
                    dgvMain.DataSource = tovarbIBindingSource;
                    break;
                case 5: //Фирмы
                    btnUpdate.Text = "Изменить";
                    spcMainForKey1.Panel2.Visible = false;
                    spcMainForKey1.Panel2Collapsed = true;
                    dgvMain.DataSource = null;
                    dgvMain.DataSource = firmiBindingSource;
                    break;
                case 6: //Должность
                    btnUpdate.Text = "Изменить";
                    spcMainForFKSec.Panel2.Visible = false;
                    spcMainForFKSec.Panel2Collapsed = true;
                    spcMainForKey1.Panel2.Visible = true;
                    spcMainForKey1.Panel2Collapsed = false;
                    dgvMain.DataSource = null;
                    dgvMain.DataSource = dolzhnostBindingSource;
                    dgvMainForeignKey.DataSource = fKDolzhnostPersonsBindingSource;
                    break;
            }
        }

        private void cbxSelectTableSec_SelectedIndexChanged(object sender, EventArgs e) // Заполнение 2-го грида
        {
            switch (cbxSelectTableSec.SelectedIndex)
            {
                case 0: //Отделы
                    SecSpcMain.Panel2.Visible = true;
                    SecSpcMain.Panel2Collapsed = false;
                    SecSpcFK.Panel2.Visible = true;
                    SecSpcFK.Panel2Collapsed = false;
                    dgvMain.DataSource = null;
                    dgvSec.DataSource = otdeliBindingSource;
                    SecDgvFK1.DataSource = otdeliPersonsBindingSource;
                    SecDgvFK2.DataSource = otdeliTovarbIBindingSource;
                    break;
                case 1: //Продажи
                    SecSpcMain.Panel2.Visible = false;
                    SecSpcMain.Panel2Collapsed = true;
                    dgvMain.DataSource = null;
                    dgvSec.DataSource = prodajiBindingSource;
                    break;
                case 2: //Склады
                    SecSpcMain.Panel2.Visible = true;
                    SecSpcMain.Panel2Collapsed = false;
                    SecSpcFK.Panel2.Visible = false;
                    SecSpcFK.Panel2Collapsed = true;
                    dgvMain.DataSource = null;
                    dgvSec.DataSource = skladiBindingSource;
                    SecDgvFK1.DataSource = skladiTovarbIBindingSource;
                    break;
                case 3: //Сотрудники
                    SecSpcMain.Panel2.Visible = false;
                    SecSpcMain.Panel2Collapsed = true;
                    dgvMain.DataSource = null;
                    dgvSec.DataSource = personsBindingSource;
                    break;
                case 4: //Товары
                    SecSpcMain.Panel2.Visible = false;
                    SecSpcMain.Panel2Collapsed = true;
                    dgvMain.DataSource = null;
                    dgvSec.DataSource = tovarbIBindingSource;
                    break;
                case 5: //Фирмы
                    SecSpcMain.Panel2.Visible = false;
                    SecSpcMain.Panel2Collapsed = true;
                    dgvMain.DataSource = null;
                    dgvSec.DataSource = firmiBindingSource;
                    break;
                case 6: //Должность
                    SecSpcFK.Panel2.Visible = false;
                    SecSpcFK.Panel2Collapsed = true;
                    SecSpcMain.Panel2.Visible = true;
                    SecSpcMain.Panel2Collapsed = false;
                    dgvMain.DataSource = null;
                    dgvSec.DataSource = dolzhnostBindingSource;
                    SecDgvFK1.DataSource = fKDolzhnostPersonsBindingSource;
                    break;
            }
        }

        #endregion

        private void tbxSearch_TextChanged(object sender, EventArgs e) // ПОИСК
        {
            
            if (cbxSelectTableMain.Text == "Продажи")
            {
                prodajiBindingSource.Filter = string.Format("CONVERT(Date, System.String) LIKE '%{0}%' OR Tovar LIKE '%{0}%' " +
                    "OR Prodano LIKE '%{0}%' OR CONVERT(Discount, System.String) LIKE '%{0}%'", tbxSearch.Text);
            }
            if (cbxSelectTableMain.Text == "Склады")
            {
                skladiBindingSource.Filter = string.Format("Telephone LIKE '%{0}%' OR Adress LIKE '%{0}%' OR Manager LIKE '%{0}%' " +
                    "OR Representative LIKE '%{0}%'", tbxSearch.Text);
            }
            if (cbxSelectTableMain.Text == "Сотрудники")
            {
                personsBindingSource.Filter = string.Format("SecondName LIKE '%{0}%' OR Name LIKE '%{0}%' OR LastName LIKE '%{0}%' " +
                    "OR Adress LIKE '%{0}%' OR Telephone LIKE '%{0}%' OR CONVERT(Salary, System.String) LIKE '%{0}%' " +
                    "OR CONVERT(Date, System.String) LIKE '%{0}%'", tbxSearch.Text);
            }
            if (cbxSelectTableMain.Text == "Товары")
            {
                tovarbIBindingSource.Filter = string.Format("Name LIKE '%{0}%' OR NameFirmi LIKE '%{0}%' OR CONVERT(Quantity, System.String) LIKE '%{0}%' OR CONVERT(Price, System.String) LIKE '%{0}%'", tbxSearch.Text);
            }
            if (cbxSelectTableMain.Text == "Отделы")
            {
                otdeliBindingSource.Filter = string.Format("Name LIKE '%{0}%'", tbxSearch.Text);
            }
            if (cbxSelectTableMain.Text == "Должность")
            {
                dolzhnostBindingSource.Filter = string.Format("Name LIKE '%{0}%'", tbxSearch.Text);
            }
            if (cbxSelectTableMain.Text == "Фирмы")
            {
                firmiBindingSource.Filter = string.Format("Name LIKE '%{0}%' OR Adress LIKE '%{0}%' OR Telephone LIKE '%{0}%'", tbxSearch.Text);
            }
        }

        #region Основные кнопки(Удалить, Изменить, Добавить) и функции(Обновить)
        public void RefreshAllDgv() //Перерисовка DataGridView(Обновление)
        {
            shopDS.EnforceConstraints = false;
            this.dolzhnostTableAdapter.Fill(this.shopDS.Dolzhnost);
            this.otdeliTableAdapter.Fill(this.shopDS.Otdeli);
            this.skladiTableAdapter.Fill(this.shopDS.Skladi);
            this.tovarbITableAdapter.Fill(this.shopDS.TovarbI);
            this.prodajiTableAdapter.Fill(this.shopDS.Prodaji);
            this.personsTableAdapter.Fill(this.shopDS.Persons);
            this.firmiTableAdapter.Fill(this.shopDS.Firmi);
            shopDS.EnforceConstraints = true;
        }

        private void btnInsert_Click(object sender, EventArgs e) //Добавить
        {
            if (string.IsNullOrEmpty(cbxSelectTableMain.Text) && string.IsNullOrWhiteSpace(cbxSelectTableMain.Text))
            {
                MessageBox.Show("Выберите таблицу!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (cbxSelectTableMain.Text == "Фирмы")
                {
                    insertFirmi insertFirmi = new insertFirmi(this);
                    insertFirmi.Show();
                }
                else if (cbxSelectTableMain.Text == "Продажи")
                {
                    insertProd insertProd = new insertProd(this);
                    insertProd.Show();
                }
                else if(cbxSelectTableMain.Text == "Склады")
                {
                    insertSkl insertSkl = new insertSkl(this);
                    insertSkl.Show();
                }
                else if(cbxSelectTableMain.Text == "Сотрудники")
                {
                    insertPersons insertPersons = new insertPersons(this);
                    insertPersons.Show();
                }
                else if(cbxSelectTableMain.Text == "Товары")
                {
                    insertTov insertTov = new insertTov(this);
                    insertTov.Show();
                }
                else if(cbxSelectTableMain.Text == "Отделы")
                {
                    insertOtd insertOtd = new insertOtd(this);
                    insertOtd.Show();
                }
                else if(cbxSelectTableMain.Text == "Должность")
                {
                    insertDol insertDol = new insertDol(this);
                    insertDol.Show();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e) //Изменить
        {
            if (string.IsNullOrEmpty(cbxSelectTableMain.Text) && string.IsNullOrWhiteSpace(cbxSelectTableMain.Text))
            {
                MessageBox.Show("Выберите таблицу!");
            }
            else
            {
                if (cbxSelectTableMain.Text == "Фирмы")
                {
                    updateFirmi updateFirmi = new updateFirmi(this);
                    updateFirmi.Show();
                }
                else if (cbxSelectTableMain.Text == "Продажи")
                {
                    DialogResult res = MessageBox.Show("Вы действительно хотите применить изменения?", "Применить изменения", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    
                    switch (res)
                    {
                        case DialogResult.OK:
                            try
                            {
                                try
                                {
                                    btnReportProd_Click(sender, e);
                                    SqlCommand sqlEdit = new SqlCommand("UPDATE TovarbI SET TovarbI.Quantity = TovarbI.Quantity - Prodaji.Prodano FROM TovarbI INNER JOIN Prodaji ON TovarbI.ID_Tov = Prodaji.ID_Tov;" +
                                        "DELETE FROM Prodaji", sqlConnection);
                                    sqlEdit.ExecuteNonQuery();
                                    RefreshAllDgv();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                    }
                }
                else if (cbxSelectTableMain.Text == "Склады")
                {
                    updateSkl updateSkl = new updateSkl(this);
                    updateSkl.Show();
                }
                else if (cbxSelectTableMain.Text == "Сотрудники")
                {
                    updatePersons updatePersons = new updatePersons(this);
                    updatePersons.Show();
                }
                else if (cbxSelectTableMain.Text == "Товары")
                {
                    updateTov updateTov = new updateTov(this);
                    updateTov.Show();
                }
                else if (cbxSelectTableMain.Text == "Отделы")
                {
                    updateOtd updateOtd = new updateOtd(this);
                    updateOtd.Show();
                }
                else if (cbxSelectTableMain.Text == "Должность")
                {
                    updateDol updateDol = new updateDol(this);
                    updateDol.Show();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) //Удалить
        {
            if (string.IsNullOrEmpty(cbxSelectTableMain.Text) && string.IsNullOrWhiteSpace(cbxSelectTableMain.Text))
            {
                MessageBox.Show("Выберите таблицу!");
            }
            else 
            {
                if((MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (dgvMain.SelectedRows.Count > 0)
                    {
                        int selectedIndex = dgvMain.SelectedRows[0].Index;
                        int rowID = int.Parse(dgvMain[0, selectedIndex].Value.ToString());

                        if (cbxSelectTableMain.Text == "Продажи")
                        {
                            SqlCommand sqlDel = new SqlCommand("DELETE FROM Prodaji WHERE ID_Prod = @ID_Prod", sqlConnection);
                            sqlDel.Parameters.AddWithValue("ID_Prod", rowID);
                            sqlDel.ExecuteNonQuery();
                        }
                        if (cbxSelectTableMain.Text == "Склады")
                        {
                            SqlCommand sqlDel = new SqlCommand("DELETE FROM Skladi WHERE ID_Skl = @id", sqlConnection);
                            sqlDel.Parameters.AddWithValue("id", rowID);
                            sqlDel.ExecuteNonQuery();
                        }
                        if (cbxSelectTableMain.Text == "Сотрудники")
                        {
                            SqlCommand sqlDel = new SqlCommand("DELETE FROM Persons WHERE ID_Pers = @id", sqlConnection);
                            sqlDel.Parameters.AddWithValue("id", rowID);
                            sqlDel.ExecuteNonQuery();
                        }
                        if (cbxSelectTableMain.Text == "Товары")
                        {
                            SqlCommand sqlDel = new SqlCommand("DELETE FROM TovarbI WHERE ID_Tov = @id", sqlConnection);
                            sqlDel.Parameters.AddWithValue("id", rowID);
                            sqlDel.ExecuteNonQuery();
                        }
                        if (cbxSelectTableMain.Text == "Отделы")
                        {
                            SqlCommand sqlDel = new SqlCommand("DELETE FROM Otdeli WHERE ID_Otd = @id", sqlConnection);
                            sqlDel.Parameters.AddWithValue("id", rowID);
                            sqlDel.ExecuteNonQuery();
                        }
                        if (cbxSelectTableMain.Text == "Должность")
                        {
                            SqlCommand sqlDel = new SqlCommand("DELETE FROM Dolzhnost WHERE ID_Dol = @id;" +
                            "DELETE FROM Persons WHERE ID_Dol = @id", sqlConnection);
                            sqlDel.Parameters.AddWithValue("id", rowID);
                            sqlDel.ExecuteNonQuery();
                        }
                        if (cbxSelectTableMain.Text == "Фирмы")
                        {
                            SqlCommand sqlDel = new SqlCommand("DELETE FROM Firmi WHERE ID_Firm = @id", sqlConnection);
                            sqlDel.Parameters.AddWithValue("id", rowID);
                            sqlDel.ExecuteNonQuery();
                        }
                    }
                }
                RefreshAllDgv();
            }
        }
        #endregion

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshAllDgv();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void msbtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshAllDgv();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing)
                return;

            if (MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
            else
                sqlConnection.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            AboutProgramm aProg = new AboutProgramm();
            aProg.Show();
        }

        #region Отчёты
        private void btnReportPer_Click(object sender, EventArgs e)
        {
            ReportPersons reportPersons = new ReportPersons();
            reportPersons.ShowDialog();
        }

        private void btnReportOtd_Click(object sender, EventArgs e)
        {
            ReportOtdeli reportOtdeli = new ReportOtdeli();
            reportOtdeli.ShowDialog();
        }

        private void btnReportProd_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.ShowDialog();
        }
        #endregion
    }
}
