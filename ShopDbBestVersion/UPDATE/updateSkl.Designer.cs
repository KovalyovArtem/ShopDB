namespace ShopDbBestVersion
{
    partial class updateSkl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateSkl));
            this.tbxRepresentative = new System.Windows.Forms.TextBox();
            this.tbxManager = new System.Windows.Forms.TextBox();
            this.tbxAdress = new System.Windows.Forms.TextBox();
            this.tbxTelephone = new System.Windows.Forms.TextBox();
            this.cmbxID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxDontClose = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.shopDS = new ShopDbBestVersion.ShopDS();
            this.skladiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladiTableAdapter = new ShopDbBestVersion.ShopDSTableAdapters.SkladiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.shopDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxRepresentative
            // 
            this.tbxRepresentative.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.skladiBindingSource, "ID_Skl", true));
            this.tbxRepresentative.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladiBindingSource, "Representative", true));
            this.tbxRepresentative.Location = new System.Drawing.Point(108, 119);
            this.tbxRepresentative.Name = "tbxRepresentative";
            this.tbxRepresentative.Size = new System.Drawing.Size(402, 20);
            this.tbxRepresentative.TabIndex = 77;
            // 
            // tbxManager
            // 
            this.tbxManager.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.skladiBindingSource, "ID_Skl", true));
            this.tbxManager.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladiBindingSource, "Manager", true));
            this.tbxManager.Location = new System.Drawing.Point(108, 92);
            this.tbxManager.Name = "tbxManager";
            this.tbxManager.Size = new System.Drawing.Size(402, 20);
            this.tbxManager.TabIndex = 76;
            // 
            // tbxAdress
            // 
            this.tbxAdress.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.skladiBindingSource, "ID_Skl", true));
            this.tbxAdress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladiBindingSource, "Adress", true));
            this.tbxAdress.Location = new System.Drawing.Point(108, 65);
            this.tbxAdress.Name = "tbxAdress";
            this.tbxAdress.Size = new System.Drawing.Size(402, 20);
            this.tbxAdress.TabIndex = 75;
            // 
            // tbxTelephone
            // 
            this.tbxTelephone.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.skladiBindingSource, "ID_Skl", true));
            this.tbxTelephone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladiBindingSource, "Telephone", true));
            this.tbxTelephone.Location = new System.Drawing.Point(108, 39);
            this.tbxTelephone.Name = "tbxTelephone";
            this.tbxTelephone.Size = new System.Drawing.Size(402, 20);
            this.tbxTelephone.TabIndex = 74;
            // 
            // cmbxID
            // 
            this.cmbxID.DataSource = this.skladiBindingSource;
            this.cmbxID.DisplayMember = "ID_Skl";
            this.cmbxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxID.FormattingEnabled = true;
            this.cmbxID.Location = new System.Drawing.Point(108, 12);
            this.cmbxID.Name = "cmbxID";
            this.cmbxID.Size = new System.Drawing.Size(402, 21);
            this.cmbxID.TabIndex = 73;
            this.cmbxID.ValueMember = "ID_Skl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "ID:";
            // 
            // cbxDontClose
            // 
            this.cbxDontClose.AutoSize = true;
            this.cbxDontClose.Location = new System.Drawing.Point(19, 149);
            this.cbxDontClose.Name = "cbxDontClose";
            this.cbxDontClose.Size = new System.Drawing.Size(149, 30);
            this.cbxDontClose.TabIndex = 71;
            this.cbxDontClose.Text = "Не закрывать окно при \r\nнажатии Изменить";
            this.cbxDontClose.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(192, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 16);
            this.label10.TabIndex = 70;
            this.label10.Text = "Вы не ввели все данные";
            this.label10.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Представитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Заведующий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Адрес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Телефон";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(313, 149);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 42);
            this.btnClose.TabIndex = 65;
            this.btnClose.Text = "Отмена";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(217, 149);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 42);
            this.btnEdit.TabIndex = 64;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // shopDS
            // 
            this.shopDS.DataSetName = "ShopDS";
            this.shopDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // skladiBindingSource
            // 
            this.skladiBindingSource.DataMember = "Skladi";
            this.skladiBindingSource.DataSource = this.shopDS;
            // 
            // skladiTableAdapter
            // 
            this.skladiTableAdapter.ClearBeforeFill = true;
            // 
            // updateSkl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 218);
            this.Controls.Add(this.tbxRepresentative);
            this.Controls.Add(this.tbxManager);
            this.Controls.Add(this.tbxAdress);
            this.Controls.Add(this.tbxTelephone);
            this.Controls.Add(this.cmbxID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxDontClose);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "updateSkl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать склад";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.updateSkl_FormClosing);
            this.Load += new System.EventHandler(this.updateSkl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxRepresentative;
        private System.Windows.Forms.TextBox tbxManager;
        private System.Windows.Forms.TextBox tbxAdress;
        private System.Windows.Forms.TextBox tbxTelephone;
        private System.Windows.Forms.ComboBox cmbxID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbxDontClose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private ShopDS shopDS;
        private System.Windows.Forms.BindingSource skladiBindingSource;
        private ShopDSTableAdapters.SkladiTableAdapter skladiTableAdapter;
    }
}