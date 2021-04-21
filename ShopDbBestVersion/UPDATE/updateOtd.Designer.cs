namespace ShopDbBestVersion
{
    partial class updateOtd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateOtd));
            this.cmbxID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxDontClose = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.shopDS = new ShopDbBestVersion.ShopDS();
            this.otdeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otdeliTableAdapter = new ShopDbBestVersion.ShopDSTableAdapters.OtdeliTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.shopDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdeliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbxID
            // 
            this.cmbxID.DataSource = this.otdeliBindingSource;
            this.cmbxID.DisplayMember = "ID_Otd";
            this.cmbxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxID.FormattingEnabled = true;
            this.cmbxID.Location = new System.Drawing.Point(114, 12);
            this.cmbxID.Name = "cmbxID";
            this.cmbxID.Size = new System.Drawing.Size(220, 21);
            this.cmbxID.TabIndex = 30;
            this.cmbxID.ValueMember = "ID_Otd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "ID";
            // 
            // cbxDontClose
            // 
            this.cbxDontClose.AutoSize = true;
            this.cbxDontClose.Location = new System.Drawing.Point(276, 68);
            this.cbxDontClose.Name = "cbxDontClose";
            this.cbxDontClose.Size = new System.Drawing.Size(149, 30);
            this.cbxDontClose.TabIndex = 28;
            this.cbxDontClose.Text = "Не закрывать окно при \r\nнажатии Изменить";
            this.cbxDontClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(49, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Вы не ввели наименование отдела";
            this.label1.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(350, 39);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Отмена";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbxName
            // 
            this.tbxName.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.otdeliBindingSource, "ID_Otd", true));
            this.tbxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.otdeliBindingSource, "Name", true));
            this.tbxName.Location = new System.Drawing.Point(114, 39);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(220, 20);
            this.tbxName.TabIndex = 25;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(350, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Наименование";
            // 
            // shopDS
            // 
            this.shopDS.DataSetName = "ShopDS";
            this.shopDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // updateOtd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 112);
            this.Controls.Add(this.cmbxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxDontClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "updateOtd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать отделы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.updateOtd_FormClosing);
            this.Load += new System.EventHandler(this.updateOtd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdeliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxDontClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label2;
        private ShopDS shopDS;
        private System.Windows.Forms.BindingSource otdeliBindingSource;
        private ShopDSTableAdapters.OtdeliTableAdapter otdeliTableAdapter;
    }
}