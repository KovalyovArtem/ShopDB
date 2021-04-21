namespace ShopDbBestVersion
{
    partial class updatePersons
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updatePersons));
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbxID = new System.Windows.Forms.ComboBox();
            this.cmbxDol = new System.Windows.Forms.ComboBox();
            this.cbxDontClose = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxOtd = new System.Windows.Forms.ComboBox();
            this.tbxSalary = new System.Windows.Forms.TextBox();
            this.tbxTelephone = new System.Windows.Forms.TextBox();
            this.tbxAdress = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.shopDS = new ShopDbBestVersion.ShopDS();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableAdapter = new ShopDbBestVersion.ShopDSTableAdapters.PersonsTableAdapter();
            this.dolzhnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dolzhnostTableAdapter = new ShopDbBestVersion.ShopDSTableAdapters.DolzhnostTableAdapter();
            this.otdeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otdeliTableAdapter = new ShopDbBestVersion.ShopDSTableAdapters.OtdeliTableAdapter();
            this.lbDol = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolzhnostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdeliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.personsBindingSource, "ID_Pers", true));
            this.dtpDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Date", true));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(102, 117);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(125, 20);
            this.dtpDate.TabIndex = 72;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 71;
            this.label11.Text = "ID";
            // 
            // cmbxID
            // 
            this.cmbxID.DataSource = this.personsBindingSource;
            this.cmbxID.DisplayMember = "ID_Pers";
            this.cmbxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxID.FormattingEnabled = true;
            this.cmbxID.Location = new System.Drawing.Point(102, 12);
            this.cmbxID.Name = "cmbxID";
            this.cmbxID.Size = new System.Drawing.Size(288, 21);
            this.cmbxID.TabIndex = 70;
            this.cmbxID.ValueMember = "ID_Pers";
            // 
            // cmbxDol
            // 
            this.cmbxDol.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.personsBindingSource, "ID_Pers", true));
            this.cmbxDol.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "ID_Dol", true));
            this.cmbxDol.DataSource = this.dolzhnostBindingSource;
            this.cmbxDol.DisplayMember = "ID_Dol";
            this.cmbxDol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxDol.FormattingEnabled = true;
            this.cmbxDol.Location = new System.Drawing.Point(102, 195);
            this.cmbxDol.Name = "cmbxDol";
            this.cmbxDol.Size = new System.Drawing.Size(288, 21);
            this.cmbxDol.TabIndex = 69;
            this.cmbxDol.ValueMember = "ID_Dol";
            // 
            // cbxDontClose
            // 
            this.cbxDontClose.AutoSize = true;
            this.cbxDontClose.Location = new System.Drawing.Point(9, 305);
            this.cbxDontClose.Name = "cbxDontClose";
            this.cbxDontClose.Size = new System.Drawing.Size(149, 30);
            this.cbxDontClose.TabIndex = 68;
            this.cbxDontClose.Text = "Не закрывать окно при \r\nнажатии Изменить";
            this.cbxDontClose.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(187, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 16);
            this.label10.TabIndex = 67;
            this.label10.Text = "Вы не ввели все данные";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "Ставка";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Код отдела";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Должность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Телефон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Фамилия";
            // 
            // cmbxOtd
            // 
            this.cmbxOtd.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.personsBindingSource, "ID_Pers", true));
            this.cmbxOtd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "ID_Otd", true));
            this.cmbxOtd.DataSource = this.otdeliBindingSource;
            this.cmbxOtd.DisplayMember = "ID_Otd";
            this.cmbxOtd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxOtd.FormattingEnabled = true;
            this.cmbxOtd.Location = new System.Drawing.Point(102, 235);
            this.cmbxOtd.Name = "cmbxOtd";
            this.cmbxOtd.Size = new System.Drawing.Size(288, 21);
            this.cmbxOtd.TabIndex = 57;
            this.cmbxOtd.ValueMember = "ID_Otd";
            // 
            // tbxSalary
            // 
            this.tbxSalary.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.personsBindingSource, "ID_Pers", true));
            this.tbxSalary.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Salary", true));
            this.tbxSalary.Location = new System.Drawing.Point(100, 275);
            this.tbxSalary.Name = "tbxSalary";
            this.tbxSalary.Size = new System.Drawing.Size(288, 20);
            this.tbxSalary.TabIndex = 56;
            // 
            // tbxTelephone
            // 
            this.tbxTelephone.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.personsBindingSource, "ID_Pers", true));
            this.tbxTelephone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Telephone", true));
            this.tbxTelephone.Location = new System.Drawing.Point(102, 169);
            this.tbxTelephone.Name = "tbxTelephone";
            this.tbxTelephone.Size = new System.Drawing.Size(288, 20);
            this.tbxTelephone.TabIndex = 55;
            // 
            // tbxAdress
            // 
            this.tbxAdress.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.personsBindingSource, "ID_Pers", true));
            this.tbxAdress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Adress", true));
            this.tbxAdress.Location = new System.Drawing.Point(102, 143);
            this.tbxAdress.Name = "tbxAdress";
            this.tbxAdress.Size = new System.Drawing.Size(288, 20);
            this.tbxAdress.TabIndex = 54;
            // 
            // tbxLastName
            // 
            this.tbxLastName.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.personsBindingSource, "ID_Pers", true));
            this.tbxLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "LastName", true));
            this.tbxLastName.Location = new System.Drawing.Point(102, 91);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(288, 20);
            this.tbxLastName.TabIndex = 53;
            // 
            // tbxName
            // 
            this.tbxName.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.personsBindingSource, "ID_Pers", true));
            this.tbxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Name", true));
            this.tbxName.Location = new System.Drawing.Point(102, 65);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(288, 20);
            this.tbxName.TabIndex = 52;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.personsBindingSource, "ID_Pers", true));
            this.tbxFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "SecondName", true));
            this.tbxFirstName.Location = new System.Drawing.Point(102, 39);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(288, 20);
            this.tbxFirstName.TabIndex = 51;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(308, 301);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 42);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "Отмена";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(212, 301);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 42);
            this.btnEdit.TabIndex = 49;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // shopDS
            // 
            this.shopDS.DataSetName = "ShopDS";
            this.shopDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "Persons";
            this.personsBindingSource.DataSource = this.shopDS;
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
            // 
            // dolzhnostBindingSource
            // 
            this.dolzhnostBindingSource.DataMember = "Dolzhnost";
            this.dolzhnostBindingSource.DataSource = this.shopDS;
            // 
            // dolzhnostTableAdapter
            // 
            this.dolzhnostTableAdapter.ClearBeforeFill = true;
            // 
            // otdeliBindingSource
            // 
            this.otdeliBindingSource.DataMember = "Otdeli";
            this.otdeliBindingSource.DataSource = this.shopDS;
            // 
            // otdeliTableAdapter
            // 
            this.otdeliTableAdapter.ClearBeforeFill = true;
            // 
            // lbDol
            // 
            this.lbDol.AutoSize = true;
            this.lbDol.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.dolzhnostBindingSource, "ID_Dol", true));
            this.lbDol.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dolzhnostBindingSource, "Name", true));
            this.lbDol.Location = new System.Drawing.Point(112, 219);
            this.lbDol.Name = "lbDol";
            this.lbDol.Size = new System.Drawing.Size(0, 13);
            this.lbDol.TabIndex = 73;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.otdeliBindingSource, "ID_Otd", true));
            this.label12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.otdeliBindingSource, "ID_Otd", true));
            this.label12.Location = new System.Drawing.Point(112, 259);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 74;
            // 
            // updatePersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 369);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbDol);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbxID);
            this.Controls.Add(this.cmbxDol);
            this.Controls.Add(this.cbxDontClose);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxOtd);
            this.Controls.Add(this.tbxSalary);
            this.Controls.Add(this.tbxTelephone);
            this.Controls.Add(this.tbxAdress);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "updatePersons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование сотрудника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.updatePersons_FormClosing);
            this.Load += new System.EventHandler(this.updatePersons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolzhnostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdeliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbxID;
        private System.Windows.Forms.ComboBox cmbxDol;
        private System.Windows.Forms.CheckBox cbxDontClose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxOtd;
        private System.Windows.Forms.TextBox tbxSalary;
        private System.Windows.Forms.TextBox tbxTelephone;
        private System.Windows.Forms.TextBox tbxAdress;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private ShopDS shopDS;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private ShopDSTableAdapters.PersonsTableAdapter personsTableAdapter;
        private System.Windows.Forms.BindingSource dolzhnostBindingSource;
        private ShopDSTableAdapters.DolzhnostTableAdapter dolzhnostTableAdapter;
        private System.Windows.Forms.BindingSource otdeliBindingSource;
        private ShopDSTableAdapters.OtdeliTableAdapter otdeliTableAdapter;
        private System.Windows.Forms.Label lbDol;
        private System.Windows.Forms.Label label12;
    }
}