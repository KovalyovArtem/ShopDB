namespace ShopDbBestVersion
{
    partial class insertTov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(insertTov));
            this.cmbxNameFirm = new System.Windows.Forms.ComboBox();
            this.firmiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDS = new ShopDbBestVersion.ShopDS();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxDontClose = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.tbxPrica = new System.Windows.Forms.TextBox();
            this.cmbxSkl = new System.Windows.Forms.ComboBox();
            this.skladiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbxOtd = new System.Windows.Forms.ComboBox();
            this.otdeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.otdeliTableAdapter = new ShopDbBestVersion.ShopDSTableAdapters.OtdeliTableAdapter();
            this.skladiTableAdapter = new ShopDbBestVersion.ShopDSTableAdapters.SkladiTableAdapter();
            this.firmiTableAdapter = new ShopDbBestVersion.ShopDSTableAdapters.FirmiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.firmiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdeliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbxNameFirm
            // 
            this.cmbxNameFirm.DataSource = this.firmiBindingSource;
            this.cmbxNameFirm.DisplayMember = "Name";
            this.cmbxNameFirm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxNameFirm.FormattingEnabled = true;
            this.cmbxNameFirm.Location = new System.Drawing.Point(138, 91);
            this.cmbxNameFirm.Name = "cmbxNameFirm";
            this.cmbxNameFirm.Size = new System.Drawing.Size(270, 21);
            this.cmbxNameFirm.TabIndex = 43;
            this.cmbxNameFirm.ValueMember = "Name";
            // 
            // firmiBindingSource
            // 
            this.firmiBindingSource.DataMember = "Firmi";
            this.firmiBindingSource.DataSource = this.shopDS;
            // 
            // shopDS
            // 
            this.shopDS.DataSetName = "ShopDS";
            this.shopDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(201, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 16);
            this.label10.TabIndex = 41;
            this.label10.Text = "Вы не ввели данные";
            this.label10.Visible = false;
            // 
            // cbxDontClose
            // 
            this.cbxDontClose.AutoSize = true;
            this.cbxDontClose.Location = new System.Drawing.Point(12, 190);
            this.cbxDontClose.Name = "cbxDontClose";
            this.cbxDontClose.Size = new System.Drawing.Size(149, 30);
            this.cbxDontClose.TabIndex = 40;
            this.cbxDontClose.Text = "Не закрывать окно при \r\nнажатии Добавить";
            this.cbxDontClose.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(324, 183);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 42);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "Отмена";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(225, 183);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 42);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(138, 144);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(270, 20);
            this.tbxQuantity.TabIndex = 37;
            // 
            // tbxPrica
            // 
            this.tbxPrica.Location = new System.Drawing.Point(138, 118);
            this.tbxPrica.Name = "tbxPrica";
            this.tbxPrica.Size = new System.Drawing.Size(270, 20);
            this.tbxPrica.TabIndex = 36;
            // 
            // cmbxSkl
            // 
            this.cmbxSkl.DataSource = this.skladiBindingSource;
            this.cmbxSkl.DisplayMember = "ID_Skl";
            this.cmbxSkl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSkl.FormattingEnabled = true;
            this.cmbxSkl.Location = new System.Drawing.Point(138, 39);
            this.cmbxSkl.Name = "cmbxSkl";
            this.cmbxSkl.Size = new System.Drawing.Size(270, 21);
            this.cmbxSkl.TabIndex = 35;
            this.cmbxSkl.ValueMember = "ID_Skl";
            // 
            // skladiBindingSource
            // 
            this.skladiBindingSource.DataMember = "Skladi";
            this.skladiBindingSource.DataSource = this.shopDS;
            // 
            // cmbxOtd
            // 
            this.cmbxOtd.DataSource = this.otdeliBindingSource;
            this.cmbxOtd.DisplayMember = "Name";
            this.cmbxOtd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxOtd.FormattingEnabled = true;
            this.cmbxOtd.Location = new System.Drawing.Point(138, 12);
            this.cmbxOtd.Name = "cmbxOtd";
            this.cmbxOtd.Size = new System.Drawing.Size(270, 21);
            this.cmbxOtd.TabIndex = 34;
            this.cmbxOtd.ValueMember = "ID_Otd";
            // 
            // otdeliBindingSource
            // 
            this.otdeliBindingSource.DataMember = "Otdeli";
            this.otdeliBindingSource.DataSource = this.shopDS;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(138, 66);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(270, 20);
            this.tbxName.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Количество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Наименование фирмы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Код склада";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Код отдела";
            // 
            // otdeliTableAdapter
            // 
            this.otdeliTableAdapter.ClearBeforeFill = true;
            // 
            // skladiTableAdapter
            // 
            this.skladiTableAdapter.ClearBeforeFill = true;
            // 
            // firmiTableAdapter
            // 
            this.firmiTableAdapter.ClearBeforeFill = true;
            // 
            // insertTov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 252);
            this.Controls.Add(this.cmbxNameFirm);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxDontClose);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.tbxPrica);
            this.Controls.Add(this.cmbxSkl);
            this.Controls.Add(this.cmbxOtd);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "insertTov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление товара";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.insertTov_FormClosing);
            this.Load += new System.EventHandler(this.insertTov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firmiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdeliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxNameFirm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbxDontClose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.TextBox tbxPrica;
        private System.Windows.Forms.ComboBox cmbxSkl;
        private System.Windows.Forms.ComboBox cmbxOtd;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ShopDS shopDS;
        private System.Windows.Forms.BindingSource otdeliBindingSource;
        private ShopDSTableAdapters.OtdeliTableAdapter otdeliTableAdapter;
        private System.Windows.Forms.BindingSource skladiBindingSource;
        private ShopDSTableAdapters.SkladiTableAdapter skladiTableAdapter;
        private System.Windows.Forms.BindingSource firmiBindingSource;
        private ShopDSTableAdapters.FirmiTableAdapter firmiTableAdapter;
    }
}