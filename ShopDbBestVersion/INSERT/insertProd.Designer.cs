namespace ShopDbBestVersion
{
    partial class insertProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(insertProd));
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbxNamaTov = new System.Windows.Forms.ComboBox();
            this.tovarbIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDS = new ShopDbBestVersion.ShopDS();
            this.cbxDontClose = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDiscount = new System.Windows.Forms.TextBox();
            this.tbxProdano = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tovarbITableAdapter = new ShopDbBestVersion.ShopDSTableAdapters.TovarbITableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbxTov = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tovarbIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDS)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(101, 39);
            this.dtpDate.MaxDate = new System.DateTime(2021, 4, 21, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(2021, 4, 14, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(95, 20);
            this.dtpDate.TabIndex = 58;
            this.dtpDate.Value = new System.DateTime(2021, 4, 21, 0, 0, 0, 0);
            // 
            // cmbxNamaTov
            // 
            this.cmbxNamaTov.DataSource = this.tovarbIBindingSource;
            this.cmbxNamaTov.DisplayMember = "Name";
            this.cmbxNamaTov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxNamaTov.FormattingEnabled = true;
            this.cmbxNamaTov.Location = new System.Drawing.Point(101, 64);
            this.cmbxNamaTov.Name = "cmbxNamaTov";
            this.cmbxNamaTov.Size = new System.Drawing.Size(288, 21);
            this.cmbxNamaTov.TabIndex = 57;
            this.cmbxNamaTov.ValueMember = "Name";
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
            // cbxDontClose
            // 
            this.cbxDontClose.AutoSize = true;
            this.cbxDontClose.Location = new System.Drawing.Point(10, 160);
            this.cbxDontClose.Name = "cbxDontClose";
            this.cbxDontClose.Size = new System.Drawing.Size(149, 30);
            this.cbxDontClose.TabIndex = 56;
            this.cbxDontClose.Text = "Не закрывать окно при \r\nнажатии Добавить";
            this.cbxDontClose.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(188, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 16);
            this.label10.TabIndex = 55;
            this.label10.Text = "Вы не ввели данные";
            this.label10.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Дата продажи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Продано";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Товар";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Скидка";
            // 
            // tbxDiscount
            // 
            this.tbxDiscount.Location = new System.Drawing.Point(101, 117);
            this.tbxDiscount.Name = "tbxDiscount";
            this.tbxDiscount.Size = new System.Drawing.Size(288, 20);
            this.tbxDiscount.TabIndex = 50;
            // 
            // tbxProdano
            // 
            this.tbxProdano.Location = new System.Drawing.Point(101, 91);
            this.tbxProdano.Name = "tbxProdano";
            this.tbxProdano.Size = new System.Drawing.Size(288, 20);
            this.tbxProdano.TabIndex = 49;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(309, 156);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 42);
            this.btnClose.TabIndex = 48;
            this.btnClose.Text = "Отмена";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(213, 156);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 42);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tovarbITableAdapter
            // 
            this.tovarbITableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Код товара";
            // 
            // cmbxTov
            // 
            this.cmbxTov.DataSource = this.tovarbIBindingSource;
            this.cmbxTov.DisplayMember = "ID_Tov";
            this.cmbxTov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTov.FormattingEnabled = true;
            this.cmbxTov.Location = new System.Drawing.Point(101, 12);
            this.cmbxTov.Name = "cmbxTov";
            this.cmbxTov.Size = new System.Drawing.Size(288, 21);
            this.cmbxTov.TabIndex = 60;
            this.cmbxTov.ValueMember = "ID_Tov";
            // 
            // insertProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 228);
            this.Controls.Add(this.cmbxTov);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbxNamaTov);
            this.Controls.Add(this.cbxDontClose);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxDiscount);
            this.Controls.Add(this.tbxProdano);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "insertProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добаление продаж";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.insertProd_FormClosing);
            this.Load += new System.EventHandler(this.insertProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tovarbIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbxNamaTov;
        private System.Windows.Forms.CheckBox cbxDontClose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDiscount;
        private System.Windows.Forms.TextBox tbxProdano;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private ShopDS shopDS;
        private System.Windows.Forms.BindingSource tovarbIBindingSource;
        private ShopDSTableAdapters.TovarbITableAdapter tovarbITableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbxTov;
    }
}