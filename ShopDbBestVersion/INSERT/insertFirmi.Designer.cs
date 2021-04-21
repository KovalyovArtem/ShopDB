namespace ShopDbBestVersion
{
    partial class insertFirmi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(insertFirmi));
            this.tbxAdress = new System.Windows.Forms.TextBox();
            this.cbxDontClose = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTelephone = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxAdress
            // 
            this.tbxAdress.Location = new System.Drawing.Point(106, 38);
            this.tbxAdress.Name = "tbxAdress";
            this.tbxAdress.Size = new System.Drawing.Size(288, 20);
            this.tbxAdress.TabIndex = 67;
            // 
            // cbxDontClose
            // 
            this.cbxDontClose.AutoSize = true;
            this.cbxDontClose.Location = new System.Drawing.Point(15, 99);
            this.cbxDontClose.Name = "cbxDontClose";
            this.cbxDontClose.Size = new System.Drawing.Size(149, 30);
            this.cbxDontClose.TabIndex = 66;
            this.cbxDontClose.Text = "Не закрывать окно при \r\nнажатии Добавить";
            this.cbxDontClose.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(200, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 16);
            this.label10.TabIndex = 65;
            this.label10.Text = "Вы не ввели данные";
            this.label10.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Наименование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Адрес";
            // 
            // tbxTelephone
            // 
            this.tbxTelephone.Location = new System.Drawing.Point(106, 64);
            this.tbxTelephone.Name = "tbxTelephone";
            this.tbxTelephone.Size = new System.Drawing.Size(288, 20);
            this.tbxTelephone.TabIndex = 61;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(106, 12);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(288, 20);
            this.tbxName.TabIndex = 60;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(314, 95);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 42);
            this.btnClose.TabIndex = 59;
            this.btnClose.Text = "Отмена";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctnAdd
            // 
            this.ctnAdd.Location = new System.Drawing.Point(218, 95);
            this.ctnAdd.Name = "ctnAdd";
            this.ctnAdd.Size = new System.Drawing.Size(80, 42);
            this.ctnAdd.TabIndex = 58;
            this.ctnAdd.Text = "Добавить";
            this.ctnAdd.UseVisualStyleBackColor = true;
            this.ctnAdd.Click += new System.EventHandler(this.ctnAdd_Click);
            // 
            // insertFirmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(405, 167);
            this.Controls.Add(this.tbxAdress);
            this.Controls.Add(this.cbxDontClose);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxTelephone);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "insertFirmi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление фирмы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.insertFirmi_FormClosing);
            this.Load += new System.EventHandler(this.insertFirmi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxAdress;
        private System.Windows.Forms.CheckBox cbxDontClose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTelephone;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button ctnAdd;
    }
}