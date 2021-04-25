namespace ShopDbBestVersion
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msbtnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReport = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.btnInsert = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lbSearch = new System.Windows.Forms.ToolStripLabel();
            this.tsWindows = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tbxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.spcMainForKey1 = new System.Windows.Forms.SplitContainer();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.spcMainForFKSec = new System.Windows.Forms.SplitContainer();
            this.dgvMainForeignKey = new System.Windows.Forms.DataGridView();
            this.dgvMainFK2 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbxSelectTableMain = new System.Windows.Forms.ToolStripComboBox();
            this.SecSpcMain = new System.Windows.Forms.SplitContainer();
            this.dgvSec = new System.Windows.Forms.DataGridView();
            this.SecSpcFK = new System.Windows.Forms.SplitContainer();
            this.SecDgvFK1 = new System.Windows.Forms.DataGridView();
            this.SecDgvFK2 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cbxSelectTableSec = new System.Windows.Forms.ToolStripComboBox();
            this.tovarbIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDS = new ShopDbBestVersion.ShopDS();
            this.dolzhnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dolzhnostTableAdapter = new ShopDbBestVersion.ShopDSTableAdapters.DolzhnostTableAdapter();
            this.skladiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladiTableAdapter = new ShopDbBestVersion.ShopDSTableAdapters.SkladiTableAdapter();
            this.firmiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmiTableAdapter = new ShopDbBestVersion.ShopDSTableAdapters.FirmiTableAdapter();
            this.otdeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otdeliTableAdapter = new ShopDbBestVersion.ShopDSTableAdapters.OtdeliTableAdapter();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableAdapter = new ShopDbBestVersion.ShopDSTableAdapters.PersonsTableAdapter();
            this.tovarbITableAdapter = new ShopDbBestVersion.ShopDSTableAdapters.TovarbITableAdapter();
            this.prodajiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodajiTableAdapter = new ShopDbBestVersion.ShopDSTableAdapters.ProdajiTableAdapter();
            this.fKDolzhnostPersonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otdeliPersonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otdeliTovarbIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladiTovarbIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dolzhnostTableAdapter1 = new ShopDbBestVersion.ShopDSTableAdapters.DolzhnostTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.tsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMainForKey1)).BeginInit();
            this.spcMainForKey1.Panel1.SuspendLayout();
            this.spcMainForKey1.Panel2.SuspendLayout();
            this.spcMainForKey1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcMainForFKSec)).BeginInit();
            this.spcMainForFKSec.Panel1.SuspendLayout();
            this.spcMainForFKSec.Panel2.SuspendLayout();
            this.spcMainForFKSec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainForeignKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainFK2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecSpcMain)).BeginInit();
            this.SecSpcMain.Panel1.SuspendLayout();
            this.SecSpcMain.Panel2.SuspendLayout();
            this.SecSpcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecSpcFK)).BeginInit();
            this.SecSpcFK.Panel1.SuspendLayout();
            this.SecSpcFK.Panel2.SuspendLayout();
            this.SecSpcFK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecDgvFK1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecDgvFK2)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tovarbIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolzhnostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdeliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodajiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDolzhnostPersonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdeliPersonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdeliTovarbIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladiTovarbIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1298, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.msbtnRefresh,
            this.btnReport});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 22);
            this.btnExit.Text = "Выход";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // msbtnRefresh
            // 
            this.msbtnRefresh.Name = "msbtnRefresh";
            this.msbtnRefresh.Size = new System.Drawing.Size(128, 22);
            this.msbtnRefresh.Text = "Обновить";
            this.msbtnRefresh.Click += new System.EventHandler(this.msbtnRefresh_Click);
            // 
            // btnReport
            // 
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(128, 22);
            this.btnReport.Text = "Отчёт";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHelp});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // btnHelp
            // 
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(180, 22);
            this.btnHelp.Text = "О программе";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // tsMain
            // 
            this.tsMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInsert,
            this.toolStripSeparator1,
            this.btnUpdate,
            this.toolStripSeparator2,
            this.btnDelete,
            this.toolStripSeparator3,
            this.btnRefresh,
            this.toolStripSeparator4,
            this.lbSearch,
            this.tsWindows,
            this.toolStripSeparator5,
            this.tbxSearch});
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1298, 25);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "toolStrip1";
            // 
            // btnInsert
            // 
            this.btnInsert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(63, 22);
            this.btnInsert.Text = "Добавить";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnUpdate
            // 
            this.btnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(65, 22);
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(55, 22);
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(65, 22);
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // lbSearch
            // 
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(42, 22);
            this.lbSearch.Text = "Поиск";
            // 
            // tsWindows
            // 
            this.tsWindows.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsWindows.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsWindows.Image = ((System.Drawing.Image)(resources.GetObject("tsWindows.Image")));
            this.tsWindows.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsWindows.Name = "tsWindows";
            this.tsWindows.Size = new System.Drawing.Size(96, 22);
            this.tsWindows.Text = "Разделить окно";
            this.tsWindows.Click += new System.EventHandler(this.tsWindows_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 25);
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.Location = new System.Drawing.Point(0, 49);
            this.spcMain.Name = "spcMain";
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.spcMainForKey1);
            this.spcMain.Panel1.Controls.Add(this.toolStrip1);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.SecSpcMain);
            this.spcMain.Panel2.Controls.Add(this.toolStrip2);
            this.spcMain.Size = new System.Drawing.Size(1298, 401);
            this.spcMain.SplitterDistance = 649;
            this.spcMain.TabIndex = 2;
            // 
            // spcMainForKey1
            // 
            this.spcMainForKey1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMainForKey1.Location = new System.Drawing.Point(0, 25);
            this.spcMainForKey1.Name = "spcMainForKey1";
            this.spcMainForKey1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcMainForKey1.Panel1
            // 
            this.spcMainForKey1.Panel1.Controls.Add(this.dgvMain);
            this.spcMainForKey1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // spcMainForKey1.Panel2
            // 
            this.spcMainForKey1.Panel2.Controls.Add(this.spcMainForFKSec);
            this.spcMainForKey1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.spcMainForKey1.Size = new System.Drawing.Size(649, 376);
            this.spcMainForKey1.SplitterDistance = 218;
            this.spcMainForKey1.TabIndex = 1;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.Size = new System.Drawing.Size(649, 218);
            this.dgvMain.TabIndex = 1;
            // 
            // spcMainForFKSec
            // 
            this.spcMainForFKSec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMainForFKSec.Location = new System.Drawing.Point(0, 0);
            this.spcMainForFKSec.Name = "spcMainForFKSec";
            this.spcMainForFKSec.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcMainForFKSec.Panel1
            // 
            this.spcMainForFKSec.Panel1.Controls.Add(this.dgvMainForeignKey);
            // 
            // spcMainForFKSec.Panel2
            // 
            this.spcMainForFKSec.Panel2.Controls.Add(this.dgvMainFK2);
            this.spcMainForFKSec.Size = new System.Drawing.Size(649, 154);
            this.spcMainForFKSec.SplitterDistance = 73;
            this.spcMainForFKSec.TabIndex = 0;
            // 
            // dgvMainForeignKey
            // 
            this.dgvMainForeignKey.AllowUserToAddRows = false;
            this.dgvMainForeignKey.AllowUserToDeleteRows = false;
            this.dgvMainForeignKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainForeignKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMainForeignKey.Location = new System.Drawing.Point(0, 0);
            this.dgvMainForeignKey.Name = "dgvMainForeignKey";
            this.dgvMainForeignKey.ReadOnly = true;
            this.dgvMainForeignKey.Size = new System.Drawing.Size(649, 73);
            this.dgvMainForeignKey.TabIndex = 0;
            // 
            // dgvMainFK2
            // 
            this.dgvMainFK2.AllowUserToAddRows = false;
            this.dgvMainFK2.AllowUserToDeleteRows = false;
            this.dgvMainFK2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainFK2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMainFK2.Location = new System.Drawing.Point(0, 0);
            this.dgvMainFK2.Name = "dgvMainFK2";
            this.dgvMainFK2.ReadOnly = true;
            this.dgvMainFK2.Size = new System.Drawing.Size(649, 77);
            this.dgvMainFK2.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cbxSelectTableMain});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(649, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(109, 22);
            this.toolStripLabel1.Text = "Выберите таблицу";
            // 
            // cbxSelectTableMain
            // 
            this.cbxSelectTableMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectTableMain.Items.AddRange(new object[] {
            "Отделы",
            "Продажи",
            "Склады",
            "Сотрудники",
            "Товары",
            "Фирмы",
            "Должность"});
            this.cbxSelectTableMain.Name = "cbxSelectTableMain";
            this.cbxSelectTableMain.Size = new System.Drawing.Size(121, 25);
            this.cbxSelectTableMain.SelectedIndexChanged += new System.EventHandler(this.cbxSelectTableMain_SelectedIndexChanged);
            // 
            // SecSpcMain
            // 
            this.SecSpcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecSpcMain.Location = new System.Drawing.Point(0, 25);
            this.SecSpcMain.Name = "SecSpcMain";
            this.SecSpcMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SecSpcMain.Panel1
            // 
            this.SecSpcMain.Panel1.Controls.Add(this.dgvSec);
            // 
            // SecSpcMain.Panel2
            // 
            this.SecSpcMain.Panel2.Controls.Add(this.SecSpcFK);
            this.SecSpcMain.Size = new System.Drawing.Size(645, 376);
            this.SecSpcMain.SplitterDistance = 217;
            this.SecSpcMain.TabIndex = 1;
            // 
            // dgvSec
            // 
            this.dgvSec.AllowUserToAddRows = false;
            this.dgvSec.AllowUserToDeleteRows = false;
            this.dgvSec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSec.Location = new System.Drawing.Point(0, 0);
            this.dgvSec.Name = "dgvSec";
            this.dgvSec.ReadOnly = true;
            this.dgvSec.Size = new System.Drawing.Size(645, 217);
            this.dgvSec.TabIndex = 1;
            // 
            // SecSpcFK
            // 
            this.SecSpcFK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecSpcFK.Location = new System.Drawing.Point(0, 0);
            this.SecSpcFK.Name = "SecSpcFK";
            this.SecSpcFK.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SecSpcFK.Panel1
            // 
            this.SecSpcFK.Panel1.Controls.Add(this.SecDgvFK1);
            // 
            // SecSpcFK.Panel2
            // 
            this.SecSpcFK.Panel2.Controls.Add(this.SecDgvFK2);
            this.SecSpcFK.Size = new System.Drawing.Size(645, 155);
            this.SecSpcFK.SplitterDistance = 74;
            this.SecSpcFK.TabIndex = 0;
            // 
            // SecDgvFK1
            // 
            this.SecDgvFK1.AllowUserToAddRows = false;
            this.SecDgvFK1.AllowUserToDeleteRows = false;
            this.SecDgvFK1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SecDgvFK1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecDgvFK1.Location = new System.Drawing.Point(0, 0);
            this.SecDgvFK1.Name = "SecDgvFK1";
            this.SecDgvFK1.ReadOnly = true;
            this.SecDgvFK1.Size = new System.Drawing.Size(645, 74);
            this.SecDgvFK1.TabIndex = 0;
            // 
            // SecDgvFK2
            // 
            this.SecDgvFK2.AllowUserToAddRows = false;
            this.SecDgvFK2.AllowUserToDeleteRows = false;
            this.SecDgvFK2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SecDgvFK2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecDgvFK2.Location = new System.Drawing.Point(0, 0);
            this.SecDgvFK2.Name = "SecDgvFK2";
            this.SecDgvFK2.ReadOnly = true;
            this.SecDgvFK2.Size = new System.Drawing.Size(645, 77);
            this.SecDgvFK2.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.cbxSelectTableSec});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(645, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(109, 22);
            this.toolStripLabel2.Text = "Выберите таблицу";
            // 
            // cbxSelectTableSec
            // 
            this.cbxSelectTableSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectTableSec.Items.AddRange(new object[] {
            "Отделы",
            "Продажи",
            "Склады",
            "Сотрудники",
            "Товары",
            "Фирмы",
            "Должность"});
            this.cbxSelectTableSec.Name = "cbxSelectTableSec";
            this.cbxSelectTableSec.Size = new System.Drawing.Size(121, 25);
            this.cbxSelectTableSec.SelectedIndexChanged += new System.EventHandler(this.cbxSelectTableSec_SelectedIndexChanged);
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
            // dolzhnostBindingSource
            // 
            this.dolzhnostBindingSource.DataMember = "Dolzhnost";
            this.dolzhnostBindingSource.DataSource = this.shopDS;
            // 
            // dolzhnostTableAdapter
            // 
            this.dolzhnostTableAdapter.ClearBeforeFill = true;
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
            // firmiBindingSource
            // 
            this.firmiBindingSource.DataMember = "Firmi";
            this.firmiBindingSource.DataSource = this.shopDS;
            // 
            // firmiTableAdapter
            // 
            this.firmiTableAdapter.ClearBeforeFill = true;
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
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "Persons";
            this.personsBindingSource.DataSource = this.shopDS;
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
            // 
            // tovarbITableAdapter
            // 
            this.tovarbITableAdapter.ClearBeforeFill = true;
            // 
            // prodajiBindingSource
            // 
            this.prodajiBindingSource.DataMember = "Prodaji";
            this.prodajiBindingSource.DataSource = this.shopDS;
            // 
            // prodajiTableAdapter
            // 
            this.prodajiTableAdapter.ClearBeforeFill = true;
            // 
            // fKDolzhnostPersonsBindingSource
            // 
            this.fKDolzhnostPersonsBindingSource.DataMember = "FK_Dolzhnost_Persons";
            this.fKDolzhnostPersonsBindingSource.DataSource = this.dolzhnostBindingSource;
            // 
            // otdeliPersonsBindingSource
            // 
            this.otdeliPersonsBindingSource.DataMember = "Otdeli_Persons";
            this.otdeliPersonsBindingSource.DataSource = this.otdeliBindingSource;
            // 
            // otdeliTovarbIBindingSource
            // 
            this.otdeliTovarbIBindingSource.DataMember = "Otdeli_TovarbI";
            this.otdeliTovarbIBindingSource.DataSource = this.otdeliBindingSource;
            // 
            // skladiTovarbIBindingSource
            // 
            this.skladiTovarbIBindingSource.DataMember = "Skladi_TovarbI";
            this.skladiTovarbIBindingSource.DataSource = this.skladiBindingSource;
            // 
            // dolzhnostTableAdapter1
            // 
            this.dolzhnostTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1298, 450);
            this.Controls.Add(this.spcMain);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopDB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel1.PerformLayout();
            this.spcMain.Panel2.ResumeLayout(false);
            this.spcMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.spcMainForKey1.Panel1.ResumeLayout(false);
            this.spcMainForKey1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMainForKey1)).EndInit();
            this.spcMainForKey1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.spcMainForFKSec.Panel1.ResumeLayout(false);
            this.spcMainForFKSec.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMainForFKSec)).EndInit();
            this.spcMainForFKSec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainForeignKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainFK2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.SecSpcMain.Panel1.ResumeLayout(false);
            this.SecSpcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SecSpcMain)).EndInit();
            this.SecSpcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSec)).EndInit();
            this.SecSpcFK.Panel1.ResumeLayout(false);
            this.SecSpcFK.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SecSpcFK)).EndInit();
            this.SecSpcFK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SecDgvFK1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecDgvFK2)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tovarbIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolzhnostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdeliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodajiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDolzhnostPersonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdeliPersonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdeliTovarbIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladiTovarbIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnInsert;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel lbSearch;
        private System.Windows.Forms.ToolStripButton tsWindows;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox tbxSearch;
        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbxSelectTableMain;
        private System.Windows.Forms.DataGridView dgvSec;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cbxSelectTableSec;
        private ShopDS shopDS;
        private ShopDSTableAdapters.DolzhnostTableAdapter dolzhnostTableAdapter;
        private System.Windows.Forms.BindingSource skladiBindingSource;
        private ShopDSTableAdapters.SkladiTableAdapter skladiTableAdapter;
        private System.Windows.Forms.BindingSource firmiBindingSource;
        private ShopDSTableAdapters.FirmiTableAdapter firmiTableAdapter;
        private System.Windows.Forms.BindingSource otdeliBindingSource;
        private ShopDSTableAdapters.OtdeliTableAdapter otdeliTableAdapter;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private ShopDSTableAdapters.PersonsTableAdapter personsTableAdapter;
        private System.Windows.Forms.BindingSource tovarbIBindingSource;
        private ShopDSTableAdapters.TovarbITableAdapter tovarbITableAdapter;
        private System.Windows.Forms.BindingSource prodajiBindingSource;
        private ShopDSTableAdapters.ProdajiTableAdapter prodajiTableAdapter;
        private System.Windows.Forms.SplitContainer spcMainForKey1;
        private System.Windows.Forms.DataGridView dgvMainForeignKey;
        private System.Windows.Forms.BindingSource fKDolzhnostPersonsBindingSource;
        private System.Windows.Forms.SplitContainer spcMainForFKSec;
        private System.Windows.Forms.DataGridView dgvMainFK2;
        private System.Windows.Forms.BindingSource otdeliPersonsBindingSource;
        private System.Windows.Forms.SplitContainer SecSpcMain;
        private System.Windows.Forms.SplitContainer SecSpcFK;
        private System.Windows.Forms.DataGridView SecDgvFK1;
        private System.Windows.Forms.DataGridView SecDgvFK2;
        private System.Windows.Forms.BindingSource dolzhnostBindingSource;
        private System.Windows.Forms.BindingSource otdeliTovarbIBindingSource;
        private System.Windows.Forms.BindingSource skladiTovarbIBindingSource;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem msbtnRefresh;
        private ShopDSTableAdapters.DolzhnostTableAdapter dolzhnostTableAdapter1;
        private System.Windows.Forms.ToolStripMenuItem btnReport;
        private System.Windows.Forms.ToolStripMenuItem btnHelp;
    }
}

