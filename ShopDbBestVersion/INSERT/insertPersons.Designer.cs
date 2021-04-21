namespace ShopDbBestVersion
{
    partial class insertPersons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(insertPersons));
            this.cmbxDol = new System.Windows.Forms.ComboBox();
            this.dolzhnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDS = new ShopDbBestVersion.ShopDS();
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
            this.otdeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbxSalary = new System.Windows.Forms.TextBox();
            this.tbxTelephone = new System.Windows.Forms.TextBox();
            this.tbxAdress = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxFistName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dolzhnostTableAdapter = new ShopDbBestVersion.ShopDSTableAdapters.DolzhnostTableAdapter();
            this.otdeliTableAdapter = new ShopDbBestVersion.ShopDSTableAdapters.OtdeliTableAdapter();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dolzhnostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdeliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbxDol
            // 
            this.cmbxDol.DataSource = this.dolzhnostBindingSource;
            this.cmbxDol.DisplayMember = "Name";
            this.cmbxDol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxDol.FormattingEnabled = true;
            this.cmbxDol.Location = new System.Drawing.Point(108, 171);
            this.cmbxDol.Name = "cmbxDol";
            this.cmbxDol.Size = new System.Drawing.Size(288, 21);
            this.cmbxDol.TabIndex = 45;
            this.cmbxDol.ValueMember = "ID_Dol";
            // 
            // dolzhnostBindingSource
            // 
            this.dolzhnostBindingSource.DataMember = "Dolzhnost";
            this.dolzhnostBindingSource.DataSource = this.shopDS;
            // 
            // shopDS
            // 
            this.shopDS.DataSetName = "ShopDS";
            this.shopDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxDontClose
            // 
            this.cbxDontClose.AutoSize = true;
            this.cbxDontClose.Location = new System.Drawing.Point(17, 253);
            this.cbxDontClose.Name = "cbxDontClose";
            this.cbxDontClose.Size = new System.Drawing.Size(149, 30);
            this.cbxDontClose.TabIndex = 44;
            this.cbxDontClose.Text = "Не закрывать окно при \r\nнажатии Добавить";
            this.cbxDontClose.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(195, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "Вы не ввели данные";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Ставка";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Наименование отдела";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Должность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Телефон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Фамилия";
            // 
            // cmbxOtd
            // 
            this.cmbxOtd.DataSource = this.otdeliBindingSource;
            this.cmbxOtd.DisplayMember = "Name";
            this.cmbxOtd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxOtd.FormattingEnabled = true;
            this.cmbxOtd.Location = new System.Drawing.Point(140, 198);
            this.cmbxOtd.Name = "cmbxOtd";
            this.cmbxOtd.Size = new System.Drawing.Size(256, 21);
            this.cmbxOtd.TabIndex = 33;
            this.cmbxOtd.ValueMember = "ID_Otd";
            // 
            // otdeliBindingSource
            // 
            this.otdeliBindingSource.DataMember = "Otdeli";
            this.otdeliBindingSource.DataSource = this.shopDS;
            // 
            // tbxSalary
            // 
            this.tbxSalary.Location = new System.Drawing.Point(108, 223);
            this.tbxSalary.Name = "tbxSalary";
            this.tbxSalary.Size = new System.Drawing.Size(288, 20);
            this.tbxSalary.TabIndex = 32;
            // 
            // tbxTelephone
            // 
            this.tbxTelephone.Location = new System.Drawing.Point(108, 145);
            this.tbxTelephone.Name = "tbxTelephone";
            this.tbxTelephone.Size = new System.Drawing.Size(288, 20);
            this.tbxTelephone.TabIndex = 31;
            // 
            // tbxAdress
            // 
            this.tbxAdress.Location = new System.Drawing.Point(108, 119);
            this.tbxAdress.Name = "tbxAdress";
            this.tbxAdress.Size = new System.Drawing.Size(288, 20);
            this.tbxAdress.TabIndex = 30;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(108, 67);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(288, 20);
            this.tbxLastName.TabIndex = 28;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(108, 41);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(288, 20);
            this.tbxName.TabIndex = 27;
            // 
            // tbxFistName
            // 
            this.tbxFistName.Location = new System.Drawing.Point(108, 15);
            this.tbxFistName.Name = "tbxFistName";
            this.tbxFistName.Size = new System.Drawing.Size(288, 20);
            this.tbxFistName.TabIndex = 26;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(316, 249);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 42);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Отмена";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(220, 249);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 42);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dolzhnostTableAdapter
            // 
            this.dolzhnostTableAdapter.ClearBeforeFill = true;
            // 
            // otdeliTableAdapter
            // 
            this.otdeliTableAdapter.ClearBeforeFill = true;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(108, 93);
            this.dtpDate.MaxDate = new System.DateTime(2021, 4, 21, 19, 44, 55, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(141, 20);
            this.dtpDate.TabIndex = 46;
            this.dtpDate.Value = new System.DateTime(2021, 4, 21, 0, 0, 0, 0);
            // 
            // insertPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 320);
            this.Controls.Add(this.dtpDate);
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
            this.Controls.Add(this.tbxFistName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "insertPersons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового сотрудника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.insertPersons_FormClosing);
            this.Load += new System.EventHandler(this.insertPersons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dolzhnostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdeliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox tbxFistName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private ShopDS shopDS;
        private System.Windows.Forms.BindingSource dolzhnostBindingSource;
        private ShopDSTableAdapters.DolzhnostTableAdapter dolzhnostTableAdapter;
        private System.Windows.Forms.BindingSource otdeliBindingSource;
        private ShopDSTableAdapters.OtdeliTableAdapter otdeliTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}