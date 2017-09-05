namespace kanonierzyReader.GUI
{
    partial class MainWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.commentsPageTextBox = new System.Windows.Forms.TextBox();
            this.commentsLabel1 = new System.Windows.Forms.Label();
            this.commentsGrid = new System.Windows.Forms.DataGridView();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentsPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.commentsDownloadBtn = new System.Windows.Forms.Button();
            this.commentsPrevPageBtn = new System.Windows.Forms.Button();
            this.commentsNextPageBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mainNewsDetailsPanel = new System.Windows.Forms.Panel();
            this.mainNewsBrowserBtn = new System.Windows.Forms.Button();
            this.mainNewsRefreshBtn = new System.Windows.Forms.Button();
            this.mainNewsLabel1 = new System.Windows.Forms.Label();
            this.mainNewsLabel2 = new System.Windows.Forms.Label();
            this.mainNewsLabel3 = new System.Windows.Forms.Label();
            this.mainNewsLabel4 = new System.Windows.Forms.Label();
            this.mainNewsContentTextBox = new System.Windows.Forms.TextBox();
            this.mainNewsTitleTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.newsListBox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.newsLabel1 = new System.Windows.Forms.Label();
            this.newsYearComboBox1 = new System.Windows.Forms.ComboBox();
            this.newsLabel2 = new System.Windows.Forms.Label();
            this.newsMonthComboBox2 = new System.Windows.Forms.ComboBox();
            this.newsLabel3 = new System.Windows.Forms.Label();
            this.newsPageTextBox = new System.Windows.Forms.TextBox();
            this.newsDownloadBtn = new System.Windows.Forms.Button();
            this.newsPrevPageBtn = new System.Windows.Forms.Button();
            this.newsNextPageBtn = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tabsPanel = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.commentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).BeginInit();
            this.commentsPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.mainNewsDetailsPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // commentsPageTextBox
            // 
            this.commentsPageTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.commentsPageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commentsPageTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.commentsPageTextBox.Location = new System.Drawing.Point(162, 4);
            this.commentsPageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.commentsPageTextBox.Name = "commentsPageTextBox";
            this.commentsPageTextBox.Size = new System.Drawing.Size(55, 24);
            this.commentsPageTextBox.TabIndex = 8;
            this.commentsPageTextBox.Text = "1";
            // 
            // commentsLabel1
            // 
            this.commentsLabel1.AutoSize = true;
            this.commentsLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.commentsLabel1.Location = new System.Drawing.Point(4, 4);
            this.commentsLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.commentsLabel1.Name = "commentsLabel1";
            this.commentsLabel1.Size = new System.Drawing.Size(150, 23);
            this.commentsLabel1.TabIndex = 9;
            this.commentsLabel1.Text = "COMMENTS PAGE";
            // 
            // commentsGrid
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commentsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.commentsGrid.AutoGenerateColumns = false;
            this.commentsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.commentsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.commentsGrid.BackgroundColor = System.Drawing.Color.White;
            this.commentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.createdAtDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.contentDataGridViewTextBoxColumn});
            this.commentsGrid.DataSource = this.commentBindingSource;
            this.commentsGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.commentsGrid.GridColor = System.Drawing.Color.LightGray;
            this.commentsGrid.Location = new System.Drawing.Point(0, 76);
            this.commentsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.commentsGrid.MultiSelect = false;
            this.commentsGrid.Name = "commentsGrid";
            this.commentsGrid.RowHeadersVisible = false;
            this.commentsGrid.RowHeadersWidth = 10;
            this.commentsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.commentsGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commentsGrid.RowTemplate.Height = 24;
            this.commentsGrid.RowTemplate.ReadOnly = true;
            this.commentsGrid.Size = new System.Drawing.Size(902, 423);
            this.commentsGrid.TabIndex = 12;
            this.commentsGrid.TabStop = false;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.FillWeight = 200F;
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.Width = 120;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 92;
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.contentDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.contentDataGridViewTextBoxColumn.HeaderText = "Content";
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            // 
            // commentBindingSource
            // 
            this.commentBindingSource.DataSource = typeof(kanonierzyReader.Lib.Comment);
            // 
            // commentsPanel
            // 
            this.commentsPanel.BackColor = System.Drawing.Color.White;
            this.commentsPanel.Controls.Add(this.flowLayoutPanel2);
            this.commentsPanel.Controls.Add(this.label5);
            this.commentsPanel.Controls.Add(this.commentsGrid);
            this.commentsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.commentsPanel.Location = new System.Drawing.Point(0, 300);
            this.commentsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.commentsPanel.Name = "commentsPanel";
            this.commentsPanel.Size = new System.Drawing.Size(902, 499);
            this.commentsPanel.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.commentsLabel1);
            this.flowLayoutPanel2.Controls.Add(this.commentsPageTextBox);
            this.flowLayoutPanel2.Controls.Add(this.commentsDownloadBtn);
            this.flowLayoutPanel2.Controls.Add(this.commentsPrevPageBtn);
            this.flowLayoutPanel2.Controls.Add(this.commentsNextPageBtn);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(902, 41);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // commentsDownloadBtn
            // 
            this.commentsDownloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commentsDownloadBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.commentsDownloadBtn.Image = global::kanonierzyReader.GUI.Properties.Resources.download;
            this.commentsDownloadBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.commentsDownloadBtn.Location = new System.Drawing.Point(231, 3);
            this.commentsDownloadBtn.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.commentsDownloadBtn.MaximumSize = new System.Drawing.Size(145, 32);
            this.commentsDownloadBtn.Name = "commentsDownloadBtn";
            this.commentsDownloadBtn.Size = new System.Drawing.Size(145, 32);
            this.commentsDownloadBtn.TabIndex = 9;
            this.commentsDownloadBtn.Text = "Download";
            this.commentsDownloadBtn.UseVisualStyleBackColor = true;
            this.commentsDownloadBtn.Click += new System.EventHandler(this.CommentsDownloadBtn_Click);
            // 
            // commentsPrevPageBtn
            // 
            this.commentsPrevPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commentsPrevPageBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.commentsPrevPageBtn.Image = global::kanonierzyReader.GUI.Properties.Resources.prev_page;
            this.commentsPrevPageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.commentsPrevPageBtn.Location = new System.Drawing.Point(382, 3);
            this.commentsPrevPageBtn.MaximumSize = new System.Drawing.Size(145, 32);
            this.commentsPrevPageBtn.Name = "commentsPrevPageBtn";
            this.commentsPrevPageBtn.Size = new System.Drawing.Size(145, 32);
            this.commentsPrevPageBtn.TabIndex = 10;
            this.commentsPrevPageBtn.Text = "Prev Page";
            this.commentsPrevPageBtn.UseVisualStyleBackColor = true;
            this.commentsPrevPageBtn.Click += new System.EventHandler(this.CommentsPrevPageBtn_Click);
            // 
            // commentsNextPageBtn
            // 
            this.commentsNextPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commentsNextPageBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.commentsNextPageBtn.Image = global::kanonierzyReader.GUI.Properties.Resources.next_page;
            this.commentsNextPageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.commentsNextPageBtn.Location = new System.Drawing.Point(533, 3);
            this.commentsNextPageBtn.MaximumSize = new System.Drawing.Size(145, 32);
            this.commentsNextPageBtn.Name = "commentsNextPageBtn";
            this.commentsNextPageBtn.Size = new System.Drawing.Size(145, 32);
            this.commentsNextPageBtn.TabIndex = 11;
            this.commentsNextPageBtn.Text = "Next Page";
            this.commentsNextPageBtn.UseVisualStyleBackColor = true;
            this.commentsNextPageBtn.Click += new System.EventHandler(this.CommentsNextPageBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(0, 53);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(5, 23);
            this.label5.TabIndex = 10;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl.ImageList = this.imageList;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(15, 10);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(902, 300);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.mainNewsDetailsPanel);
            this.tabPage1.Controls.Add(this.mainNewsContentTextBox);
            this.tabPage1.Controls.Add(this.mainNewsTitleTextBox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 51);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(894, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MAIN";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mainNewsDetailsPanel
            // 
            this.mainNewsDetailsPanel.Controls.Add(this.mainNewsBrowserBtn);
            this.mainNewsDetailsPanel.Controls.Add(this.mainNewsRefreshBtn);
            this.mainNewsDetailsPanel.Controls.Add(this.mainNewsLabel1);
            this.mainNewsDetailsPanel.Controls.Add(this.mainNewsLabel2);
            this.mainNewsDetailsPanel.Controls.Add(this.mainNewsLabel3);
            this.mainNewsDetailsPanel.Controls.Add(this.mainNewsLabel4);
            this.mainNewsDetailsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainNewsDetailsPanel.Location = new System.Drawing.Point(4, 182);
            this.mainNewsDetailsPanel.Name = "mainNewsDetailsPanel";
            this.mainNewsDetailsPanel.Size = new System.Drawing.Size(886, 35);
            this.mainNewsDetailsPanel.TabIndex = 6;
            // 
            // mainNewsBrowserBtn
            // 
            this.mainNewsBrowserBtn.BackgroundImage = global::kanonierzyReader.GUI.Properties.Resources.mouse;
            this.mainNewsBrowserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainNewsBrowserBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainNewsBrowserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainNewsBrowserBtn.Location = new System.Drawing.Point(45, 0);
            this.mainNewsBrowserBtn.Name = "mainNewsBrowserBtn";
            this.mainNewsBrowserBtn.Size = new System.Drawing.Size(45, 35);
            this.mainNewsBrowserBtn.TabIndex = 4;
            this.toolTip.SetToolTip(this.mainNewsBrowserBtn, "Open Main News In Browser");
            this.mainNewsBrowserBtn.UseVisualStyleBackColor = true;
            this.mainNewsBrowserBtn.Click += new System.EventHandler(this.MainNewsBrowserBtn_Click);
            // 
            // mainNewsRefreshBtn
            // 
            this.mainNewsRefreshBtn.BackgroundImage = global::kanonierzyReader.GUI.Properties.Resources.refresh_button;
            this.mainNewsRefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainNewsRefreshBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainNewsRefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainNewsRefreshBtn.Location = new System.Drawing.Point(0, 0);
            this.mainNewsRefreshBtn.Name = "mainNewsRefreshBtn";
            this.mainNewsRefreshBtn.Size = new System.Drawing.Size(45, 35);
            this.mainNewsRefreshBtn.TabIndex = 3;
            this.toolTip.SetToolTip(this.mainNewsRefreshBtn, "Refresh Main News");
            this.mainNewsRefreshBtn.UseVisualStyleBackColor = true;
            this.mainNewsRefreshBtn.Click += new System.EventHandler(this.MainNewsRefreshBtn_Click);
            // 
            // mainNewsLabel1
            // 
            this.mainNewsLabel1.AutoSize = true;
            this.mainNewsLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainNewsLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainNewsLabel1.Location = new System.Drawing.Point(475, 0);
            this.mainNewsLabel1.Name = "mainNewsLabel1";
            this.mainNewsLabel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.mainNewsLabel1.Size = new System.Drawing.Size(55, 25);
            this.mainNewsLabel1.TabIndex = 0;
            this.mainNewsLabel1.Text = "added:";
            // 
            // mainNewsLabel2
            // 
            this.mainNewsLabel2.AutoSize = true;
            this.mainNewsLabel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainNewsLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainNewsLabel2.Location = new System.Drawing.Point(530, 0);
            this.mainNewsLabel2.Name = "mainNewsLabel2";
            this.mainNewsLabel2.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.mainNewsLabel2.Size = new System.Drawing.Size(96, 25);
            this.mainNewsLabel2.TabIndex = 0;
            this.mainNewsLabel2.Text = "_createdAt_";
            // 
            // mainNewsLabel3
            // 
            this.mainNewsLabel3.AutoSize = true;
            this.mainNewsLabel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainNewsLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainNewsLabel3.Location = new System.Drawing.Point(626, 0);
            this.mainNewsLabel3.Name = "mainNewsLabel3";
            this.mainNewsLabel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.mainNewsLabel3.Size = new System.Drawing.Size(81, 25);
            this.mainNewsLabel3.TabIndex = 0;
            this.mainNewsLabel3.Text = "comments:";
            // 
            // mainNewsLabel4
            // 
            this.mainNewsLabel4.AutoSize = true;
            this.mainNewsLabel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainNewsLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainNewsLabel4.Location = new System.Drawing.Point(707, 0);
            this.mainNewsLabel4.Name = "mainNewsLabel4";
            this.mainNewsLabel4.Padding = new System.Windows.Forms.Padding(0, 5, 20, 0);
            this.mainNewsLabel4.Size = new System.Drawing.Size(179, 25);
            this.mainNewsLabel4.TabIndex = 0;
            this.mainNewsLabel4.Text = "_numberOfComments_";
            // 
            // mainNewsContentTextBox
            // 
            this.mainNewsContentTextBox.BackColor = System.Drawing.Color.White;
            this.mainNewsContentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainNewsContentTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainNewsContentTextBox.Location = new System.Drawing.Point(4, 53);
            this.mainNewsContentTextBox.Multiline = true;
            this.mainNewsContentTextBox.Name = "mainNewsContentTextBox";
            this.mainNewsContentTextBox.ReadOnly = true;
            this.mainNewsContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainNewsContentTextBox.Size = new System.Drawing.Size(886, 129);
            this.mainNewsContentTextBox.TabIndex = 2;
            this.mainNewsContentTextBox.Text = "content";
            // 
            // mainNewsTitleTextBox
            // 
            this.mainNewsTitleTextBox.BackColor = System.Drawing.Color.White;
            this.mainNewsTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainNewsTitleTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainNewsTitleTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainNewsTitleTextBox.Location = new System.Drawing.Point(4, 23);
            this.mainNewsTitleTextBox.Multiline = true;
            this.mainNewsTitleTextBox.Name = "mainNewsTitleTextBox";
            this.mainNewsTitleTextBox.ReadOnly = true;
            this.mainNewsTitleTextBox.Size = new System.Drawing.Size(886, 30);
            this.mainNewsTitleTextBox.TabIndex = 1;
            this.mainNewsTitleTextBox.Text = "title1\r\ntitle2\r\ntitle3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.newsListBox);
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(894, 242);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ARCHIVE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // newsListBox
            // 
            this.newsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newsListBox.FormattingEnabled = true;
            this.newsListBox.HorizontalScrollbar = true;
            this.newsListBox.ItemHeight = 23;
            this.newsListBox.Location = new System.Drawing.Point(4, 40);
            this.newsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.newsListBox.Name = "newsListBox";
            this.newsListBox.Size = new System.Drawing.Size(886, 198);
            this.newsListBox.TabIndex = 7;
            this.toolTip.SetToolTip(this.newsListBox, "double click to open news details");
            this.newsListBox.SelectedIndexChanged += new System.EventHandler(this.NewsListBox_SelectedIndexChanged);
            this.newsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NewsListBox_MouseDoubleClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.newsLabel1);
            this.flowLayoutPanel1.Controls.Add(this.newsYearComboBox1);
            this.flowLayoutPanel1.Controls.Add(this.newsLabel2);
            this.flowLayoutPanel1.Controls.Add(this.newsMonthComboBox2);
            this.flowLayoutPanel1.Controls.Add(this.newsLabel3);
            this.flowLayoutPanel1.Controls.Add(this.newsPageTextBox);
            this.flowLayoutPanel1.Controls.Add(this.newsDownloadBtn);
            this.flowLayoutPanel1.Controls.Add(this.newsPrevPageBtn);
            this.flowLayoutPanel1.Controls.Add(this.newsNextPageBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(886, 36);
            this.flowLayoutPanel1.TabIndex = 12;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // newsLabel1
            // 
            this.newsLabel1.AutoSize = true;
            this.newsLabel1.Location = new System.Drawing.Point(4, 4);
            this.newsLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.newsLabel1.Name = "newsLabel1";
            this.newsLabel1.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.newsLabel1.Size = new System.Drawing.Size(49, 24);
            this.newsLabel1.TabIndex = 2;
            this.newsLabel1.Text = "YEAR";
            // 
            // newsYearComboBox1
            // 
            this.newsYearComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newsYearComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newsYearComboBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newsYearComboBox1.FormattingEnabled = true;
            this.newsYearComboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.newsYearComboBox1.Location = new System.Drawing.Point(60, 3);
            this.newsYearComboBox1.Name = "newsYearComboBox1";
            this.newsYearComboBox1.Size = new System.Drawing.Size(65, 28);
            this.newsYearComboBox1.TabIndex = 1;
            // 
            // newsLabel2
            // 
            this.newsLabel2.AutoSize = true;
            this.newsLabel2.Location = new System.Drawing.Point(132, 4);
            this.newsLabel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.newsLabel2.Name = "newsLabel2";
            this.newsLabel2.Padding = new System.Windows.Forms.Padding(10, 1, 0, 0);
            this.newsLabel2.Size = new System.Drawing.Size(82, 24);
            this.newsLabel2.TabIndex = 1;
            this.newsLabel2.Text = "MONTH";
            // 
            // newsMonthComboBox2
            // 
            this.newsMonthComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newsMonthComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newsMonthComboBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newsMonthComboBox2.FormattingEnabled = true;
            this.newsMonthComboBox2.Location = new System.Drawing.Point(221, 3);
            this.newsMonthComboBox2.Name = "newsMonthComboBox2";
            this.newsMonthComboBox2.Size = new System.Drawing.Size(65, 28);
            this.newsMonthComboBox2.TabIndex = 2;
            // 
            // newsLabel3
            // 
            this.newsLabel3.AutoSize = true;
            this.newsLabel3.Location = new System.Drawing.Point(293, 4);
            this.newsLabel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.newsLabel3.Name = "newsLabel3";
            this.newsLabel3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.newsLabel3.Size = new System.Drawing.Size(61, 23);
            this.newsLabel3.TabIndex = 3;
            this.newsLabel3.Text = "PAGE";
            // 
            // newsPageTextBox
            // 
            this.newsPageTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.newsPageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newsPageTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newsPageTextBox.Location = new System.Drawing.Point(362, 4);
            this.newsPageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.newsPageTextBox.Name = "newsPageTextBox";
            this.newsPageTextBox.Size = new System.Drawing.Size(55, 24);
            this.newsPageTextBox.TabIndex = 3;
            this.newsPageTextBox.Text = "1";
            // 
            // newsDownloadBtn
            // 
            this.newsDownloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newsDownloadBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newsDownloadBtn.Image = global::kanonierzyReader.GUI.Properties.Resources.download;
            this.newsDownloadBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newsDownloadBtn.Location = new System.Drawing.Point(431, 3);
            this.newsDownloadBtn.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.newsDownloadBtn.MaximumSize = new System.Drawing.Size(145, 32);
            this.newsDownloadBtn.Name = "newsDownloadBtn";
            this.newsDownloadBtn.Size = new System.Drawing.Size(145, 32);
            this.newsDownloadBtn.TabIndex = 4;
            this.newsDownloadBtn.Text = "Download";
            this.newsDownloadBtn.UseVisualStyleBackColor = true;
            this.newsDownloadBtn.Click += new System.EventHandler(this.NewsDownloadBtn_Click);
            // 
            // newsPrevPageBtn
            // 
            this.newsPrevPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newsPrevPageBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newsPrevPageBtn.Image = global::kanonierzyReader.GUI.Properties.Resources.prev_page;
            this.newsPrevPageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newsPrevPageBtn.Location = new System.Drawing.Point(582, 3);
            this.newsPrevPageBtn.MaximumSize = new System.Drawing.Size(145, 32);
            this.newsPrevPageBtn.Name = "newsPrevPageBtn";
            this.newsPrevPageBtn.Size = new System.Drawing.Size(145, 32);
            this.newsPrevPageBtn.TabIndex = 5;
            this.newsPrevPageBtn.Text = "Prev Page";
            this.newsPrevPageBtn.UseVisualStyleBackColor = true;
            this.newsPrevPageBtn.Click += new System.EventHandler(this.NewsPrevPage_Click);
            // 
            // newsNextPageBtn
            // 
            this.newsNextPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newsNextPageBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newsNextPageBtn.Image = global::kanonierzyReader.GUI.Properties.Resources.next_page;
            this.newsNextPageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newsNextPageBtn.Location = new System.Drawing.Point(733, 3);
            this.newsNextPageBtn.MaximumSize = new System.Drawing.Size(145, 32);
            this.newsNextPageBtn.Name = "newsNextPageBtn";
            this.newsNextPageBtn.Size = new System.Drawing.Size(145, 32);
            this.newsNextPageBtn.TabIndex = 6;
            this.newsNextPageBtn.Text = "Next Page";
            this.newsNextPageBtn.UseVisualStyleBackColor = true;
            this.newsNextPageBtn.Click += new System.EventHandler(this.NewsNextPage_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "home.png");
            this.imageList.Images.SetKeyName(1, "open-book.png");
            // 
            // tabsPanel
            // 
            this.tabsPanel.Controls.Add(this.tabControl);
            this.tabsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabsPanel.Location = new System.Drawing.Point(0, 0);
            this.tabsPanel.Name = "tabsPanel";
            this.tabsPanel.Size = new System.Drawing.Size(902, 300);
            this.tabsPanel.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 753);
            this.Controls.Add(this.commentsPanel);
            this.Controls.Add(this.tabsPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(920, 500);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "kanonierzyReader - browse news and comments";
            ((System.ComponentModel.ISupportInitialize)(this.commentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).EndInit();
            this.commentsPanel.ResumeLayout(false);
            this.commentsPanel.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.mainNewsDetailsPanel.ResumeLayout(false);
            this.mainNewsDetailsPanel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView commentsGrid;
        private System.Windows.Forms.Button commentsDownloadBtn;
        private System.Windows.Forms.TextBox commentsPageTextBox;
        private System.Windows.Forms.Label commentsLabel1;
        private System.Windows.Forms.BindingSource commentBindingSource;
        private System.Windows.Forms.Panel commentsPanel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox newsListBox;
        private System.Windows.Forms.Label newsLabel2;
        private System.Windows.Forms.Label newsLabel3;
        private System.Windows.Forms.Button newsDownloadBtn;
        private System.Windows.Forms.TextBox newsPageTextBox;
        private System.Windows.Forms.Label newsLabel1;
        private System.Windows.Forms.Panel tabsPanel;
        private System.Windows.Forms.Button commentsPrevPageBtn;
        private System.Windows.Forms.Button commentsNextPageBtn;
        private System.Windows.Forms.ComboBox newsYearComboBox1;
        private System.Windows.Forms.TextBox mainNewsContentTextBox;
        private System.Windows.Forms.Label mainNewsLabel3;
        private System.Windows.Forms.Label mainNewsLabel4;
        private System.Windows.Forms.Panel mainNewsDetailsPanel;
        private System.Windows.Forms.Label mainNewsLabel1;
        private System.Windows.Forms.Label mainNewsLabel2;
        private System.Windows.Forms.TextBox mainNewsTitleTextBox;
        private System.Windows.Forms.Button mainNewsRefreshBtn;
        private System.Windows.Forms.ComboBox newsMonthComboBox2;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button newsNextPageBtn;
        private System.Windows.Forms.Button newsPrevPageBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button mainNewsBrowserBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

