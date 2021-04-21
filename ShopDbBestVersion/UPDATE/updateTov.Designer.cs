namespace ShopDbBestVersion
{
    partial class updateTov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateTov));
            this.label8 = new System.Windows.Forms.Label();
            this.cmbxID = new System.Windows.Forms.ComboBox();
            this.tovarbIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDS = new ShopDbBestVersion.ShopDS();
            this.cmbxNameFirmi = new System.Windows.Forms.ComboBox();
            this.firmiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.cbxDontClose = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
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
            this.tovarbITableAdapter = new ShopDbBestVersion.ShopDSTableAdapters.TovarbITableAdapter();
            this.otdeliTableAdapter = new ShopDbBestVersion.ShopDSTableAdapters.OtdeliTableAdapter();
            this.skladiTableAdapter = new ShopDbBestVersion.ShopDSTableAdapters.SkladiTableAdapter();
            this.firmiTableAdapter = new ShopDbBestVersion.ShopDSTableAdapters.FirmiTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tovarbIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdeliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "ID";
            // 
            // cmbxID
            // 
            this.cmbxID.DataSource = this.tovarbIBindingSource;
            this.cmbxID.DisplayMember = "ID_Tov";
            this.cmbxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxID.FormattingEnabled = true;
            this.cmbxID.Location = new System.Drawing.Point(140, 12);
            this.cmbxID.Name = "cmbxID";
            this.cmbxID.Size = new System.Drawing.Size(270, 21);
            this.cmbxID.TabIndex = 63;
            this.cmbxID.ValueMember = "ID_Tov";
            // 
            // tovarbIBindingSource
            // 
            this.tovarbIBindingSource.DataMember = "TovarbI";
            this.tovarbIBindingSource.DataSource = this.shopDS;
            // 
            // shopDS
            // 
            this.shopDS.DataSetName = "ShopDS";
            this.shopDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbxNameFirmi
            // 
            this.cmbxNameFirmi.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tovarbIBindingSource, "ID_Tov", true));
            this.cmbxNameFirmi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarbIBindingSource, "NameFirmi", true));
            this.cmbxNameFirmi.DataSource = this.firmiBindingSource;
            this.cmbxNameFirmi.DisplayMember = "Name";
            this.cmbxNameFirmi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxNameFirmi.FormattingEnabled = true;
            this.cmbxNameFirmi.Location = new System.Drawing.Point(140, 131);
            this.cmbxNameFirmi.Name = "cmbxNameFirmi";
            this.cmbxNameFirmi.Size = new System.Drawing.Size(270, 21);
            this.cmbxNameFirmi.TabIndex = 62;
            this.cmbxNameFirmi.ValueMember = "Name";
            // 
            // firmiBindingSource
            // 
            this.firmiBindingSource.DataMember = "Firmi";
            this.firmiBindingSource.DataSource = this.shopDS;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(202, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 16);
            this.label10.TabIndex = 60;
            this.label10.Text = "Вы не ввели все данные";
            this.label10.Visible = false;
            // 
            // cbxDontClose
            // 
            this.cbxDontClose.AutoSize = true;
            this.cbxDontClose.Location = new System.Drawing.Point(14, 230);
            this.cbxDontClose.Name = "cbxDontClose";
            this.cbxDontClose.Size = new System.Drawing.Size(149, 30);
            this.cbxDontClose.TabIndex = 59;
            this.cbxDontClose.Text = "Не закрывать окно при \r\nнажатии Изменить";
            this.cbxDontClose.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(326, 223);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 42);
            this.btnClose.TabIndex = 58;
            this.btnClose.Text = "Отмена";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(227, 223);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 42);
            this.btnEdit.TabIndex = 57;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tovarbIBindingSource, "ID_Tov", true));
            this.tbxQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarbIBindingSource, "Quantity", true));
            this.tbxQuantity.Location = new System.Drawing.Point(140, 184);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(270, 20);
            this.tbxQuantity.TabIndex = 56;
            // 
            // tbxPrice
            // 
            this.tbxPrice.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tovarbIBindingSource, "ID_Tov", true));
            this.tbxPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarbIBindingSource, "Price", true));
            this.tbxPrice.Location = new System.Drawing.Point(140, 158);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(270, 20);
            this.tbxPrice.TabIndex = 55;
            // 
            // cmbxSkl
            // 
            this.cmbxSkl.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tovarbIBindingSource, "ID_Tov", true));
            this.cmbxSkl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarbIBindingSource, "ID_Skl", true));
            this.cmbxSkl.DataSource = this.skladiBindingSource;
            this.cmbxSkl.DisplayMember = "ID_Skl";
            this.cmbxSkl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSkl.FormattingEnabled = true;
            this.cmbxSkl.Location = new System.Drawing.Point(140, 79);
            this.cmbxSkl.Name = "cmbxSkl";
            this.cmbxSkl.Size = new System.Drawing.Size(270, 21);
            this.cmbxSkl.TabIndex = 54;
            this.cmbxSkl.ValueMember = "ID_Skl";
            // 
            // skladiBindingSource
            // 
            this.skladiBindingSource.DataMember = "Skladi";
            this.skladiBindingSource.DataSource = this.shopDS;
            // 
            // cmbxOtd
            // 
            this.cmbxOtd.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tovarbIBindingSource, "ID_Tov", true));
            this.cmbxOtd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarbIBindingSource, "ID_Otd", true));
            this.cmbxOtd.DataSource = this.otdeliBindingSource;
            this.cmbxOtd.DisplayMember = "ID_Otd";
            this.cmbxOtd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxOtd.FormattingEnabled = true;
            this.cmbxOtd.Location = new System.Drawing.Point(140, 39);
            this.cmbxOtd.Name = "cmbxOtd";
            this.cmbxOtd.Size = new System.Drawing.Size(270, 21);
            this.cmbxOtd.TabIndex = 53;
            this.cmbxOtd.ValueMember = "ID_Otd";
            // 
            // otdeliBindingSource
            // 
            this.otdeliBindingSource.DataMember = "Otdeli";
            this.otdeliBindingSource.DataSource = this.shopDS;
            // 
            // tbxName
            // 
            this.tbxName.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tovarbIBindingSource, "ID_Tov", true));
            this.tbxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarbIBindingSource, "Name", true));
            this.tbxName.Location = new System.Drawing.Point(140, 106);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(270, 20);
            this.tbxName.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Количество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Наименование фирмы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Код склада";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Код отдела";
            // 
            // tovarbITableAdapter
            // 
            this.tovarbITableAdapter.ClearBeforeFill = true;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.otdeliBindingSource, "ID_Otd", true));
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.otdeliBindingSource, "Name", true));
            this.label7.Location = new System.Drawing.Point(147, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 65;
            // 
            // updateTov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 313);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbxID);
            this.Controls.Add(this.cmbxNameFirmi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxDontClose);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.tbxPrice);
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
            this.Name = "updateTov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать товар";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.updateTov_FormClosing);
            this.Load += new System.EventHandler(this.updateTov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tovarbIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdeliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbxID;
        private System.Windows.Forms.ComboBox cmbxNameFirmi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbxDontClose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.TextBox tbxPrice;
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
        private System.Windows.Forms.BindingSource tovarbIBindingSource;
        private ShopDSTableAdapters.TovarbITableAdapter tovarbITableAdapter;
        private System.Windows.Forms.BindingSource otdeliBindingSource;
        private ShopDSTableAdapters.OtdeliTableAdapter otdeliTableAdapter;
        private System.Windows.Forms.BindingSource skladiBindingSource;
        private ShopDSTableAdapters.SkladiTableAdapter skladiTableAdapter;
        private System.Windows.Forms.BindingSource firmiBindingSource;
        private ShopDSTableAdapters.FirmiTableAdapter firmiTableAdapter;
        private System.Windows.Forms.Label label7;
    }
}