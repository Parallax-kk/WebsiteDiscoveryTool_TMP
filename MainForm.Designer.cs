namespace WebsiteDiscoveryTool
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overrideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pageHierarchyTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dataTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.memoTextBox = new System.Windows.Forms.TextBox();
            this.levelTextBox = new System.Windows.Forms.TextBox();
            this.indexTextBox = new System.Windows.Forms.TextBox();
            this.searchWordTextBox = new System.Windows.Forms.TextBox();
            this.pageNameLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.searchWordLabel = new System.Windows.Forms.Label();
            this.indexLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.imageLabel = new System.Windows.Forms.Label();
            this.memoLabel = new System.Windows.Forms.Label();
            this.pageNameTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.imageDataGridView = new System.Windows.Forms.DataGridView();
            this.treeView = new System.Windows.Forms.TreeView();
            this.relationshipDiagramtabPage = new System.Windows.Forms.TabPage();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addChildNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRootNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.pageHierarchyTabPage.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.dataTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDataGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(75, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.overrideToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.fileToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.newToolStripMenuItem.Text = "新規作成(&N)";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openProjectToolStripMenuItem.Text = "開く(&O)...";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // overrideToolStripMenuItem
            // 
            this.overrideToolStripMenuItem.Name = "overrideToolStripMenuItem";
            this.overrideToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.overrideToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.overrideToolStripMenuItem.Text = "上書き保存(&S)";
            this.overrideToolStripMenuItem.Click += new System.EventHandler(this.overrideToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "名前を付けて保存(&A)...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "終了(&X)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.editToolStripMenuItem.Text = "編集(&E)";
            this.editToolStripMenuItem.Visible = false;
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "元に戻す(&U)";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "ヘルプ(&H)";
            this.helpToolStripMenuItem.Visible = false;
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.pageHierarchyTabPage);
            this.tabControl.Controls.Add(this.relationshipDiagramtabPage);
            this.tabControl.Location = new System.Drawing.Point(13, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(820, 532);
            this.tabControl.TabIndex = 1;
            // 
            // pageHierarchyTabPage
            // 
            this.pageHierarchyTabPage.Controls.Add(this.tableLayoutPanel);
            this.pageHierarchyTabPage.Location = new System.Drawing.Point(4, 22);
            this.pageHierarchyTabPage.Name = "pageHierarchyTabPage";
            this.pageHierarchyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.pageHierarchyTabPage.Size = new System.Drawing.Size(812, 506);
            this.pageHierarchyTabPage.TabIndex = 0;
            this.pageHierarchyTabPage.Text = "ページ階層";
            this.pageHierarchyTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 582F));
            this.tableLayoutPanel.Controls.Add(this.dataTableLayoutPanel, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.treeView, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(812, 506);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // dataTableLayoutPanel
            // 
            this.dataTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.dataTableLayoutPanel.ColumnCount = 2;
            this.dataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.16495F));
            this.dataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.83505F));
            this.dataTableLayoutPanel.Controls.Add(this.memoTextBox, 1, 6);
            this.dataTableLayoutPanel.Controls.Add(this.levelTextBox, 1, 4);
            this.dataTableLayoutPanel.Controls.Add(this.indexTextBox, 1, 3);
            this.dataTableLayoutPanel.Controls.Add(this.searchWordTextBox, 1, 2);
            this.dataTableLayoutPanel.Controls.Add(this.pageNameLabel, 0, 0);
            this.dataTableLayoutPanel.Controls.Add(this.urlLabel, 0, 1);
            this.dataTableLayoutPanel.Controls.Add(this.searchWordLabel, 0, 2);
            this.dataTableLayoutPanel.Controls.Add(this.indexLabel, 0, 3);
            this.dataTableLayoutPanel.Controls.Add(this.levelLabel, 0, 4);
            this.dataTableLayoutPanel.Controls.Add(this.imageLabel, 0, 5);
            this.dataTableLayoutPanel.Controls.Add(this.memoLabel, 0, 6);
            this.dataTableLayoutPanel.Controls.Add(this.pageNameTextBox, 1, 0);
            this.dataTableLayoutPanel.Controls.Add(this.urlTextBox, 1, 1);
            this.dataTableLayoutPanel.Controls.Add(this.imageDataGridView, 1, 5);
            this.dataTableLayoutPanel.Location = new System.Drawing.Point(230, 0);
            this.dataTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.dataTableLayoutPanel.Name = "dataTableLayoutPanel";
            this.dataTableLayoutPanel.RowCount = 7;
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.dataTableLayoutPanel.Size = new System.Drawing.Size(582, 506);
            this.dataTableLayoutPanel.TabIndex = 1;
            // 
            // memoTextBox
            // 
            this.memoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memoTextBox.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.memoTextBox.Location = new System.Drawing.Point(130, 257);
            this.memoTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.memoTextBox.Multiline = true;
            this.memoTextBox.Name = "memoTextBox";
            this.memoTextBox.Size = new System.Drawing.Size(451, 248);
            this.memoTextBox.TabIndex = 13;
            this.memoTextBox.TextChanged += new System.EventHandler(this.memoTextBox_TextChanged);
            // 
            // levelTextBox
            // 
            this.levelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.levelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.levelTextBox.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.levelTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.levelTextBox.Location = new System.Drawing.Point(130, 85);
            this.levelTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.levelTextBox.Name = "levelTextBox";
            this.levelTextBox.Size = new System.Drawing.Size(451, 20);
            this.levelTextBox.TabIndex = 11;
            this.levelTextBox.TextChanged += new System.EventHandler(this.levelTextBox_TextChanged);
            this.levelTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.levelTextBox_KeyDown);
            // 
            // indexTextBox
            // 
            this.indexTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.indexTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.indexTextBox.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.indexTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.indexTextBox.Location = new System.Drawing.Point(130, 64);
            this.indexTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.indexTextBox.Name = "indexTextBox";
            this.indexTextBox.Size = new System.Drawing.Size(451, 20);
            this.indexTextBox.TabIndex = 10;
            this.indexTextBox.TextChanged += new System.EventHandler(this.indexTextBox_TextChanged);
            this.indexTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.indexTextBox_KeyDown);
            // 
            // searchWordTextBox
            // 
            this.searchWordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchWordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchWordTextBox.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.searchWordTextBox.Location = new System.Drawing.Point(130, 43);
            this.searchWordTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.searchWordTextBox.Name = "searchWordTextBox";
            this.searchWordTextBox.Size = new System.Drawing.Size(451, 20);
            this.searchWordTextBox.TabIndex = 9;
            this.searchWordTextBox.TextChanged += new System.EventHandler(this.searchWordTextBox_TextChanged);
            // 
            // pageNameLabel
            // 
            this.pageNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageNameLabel.Location = new System.Drawing.Point(1, 1);
            this.pageNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.pageNameLabel.Name = "pageNameLabel";
            this.pageNameLabel.Size = new System.Drawing.Size(128, 20);
            this.pageNameLabel.TabIndex = 0;
            this.pageNameLabel.Text = "ページ名";
            this.pageNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // urlLabel
            // 
            this.urlLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlLabel.Location = new System.Drawing.Point(1, 22);
            this.urlLabel.Margin = new System.Windows.Forms.Padding(0);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(128, 20);
            this.urlLabel.TabIndex = 1;
            this.urlLabel.Text = "URL";
            this.urlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.urlLabel.DoubleClick += new System.EventHandler(this.urlLabel_DoubleClick);
            this.urlLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.urlLabel_MouseDown);
            // 
            // searchWordLabel
            // 
            this.searchWordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchWordLabel.AutoSize = true;
            this.searchWordLabel.Location = new System.Drawing.Point(1, 43);
            this.searchWordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.searchWordLabel.Name = "searchWordLabel";
            this.searchWordLabel.Size = new System.Drawing.Size(128, 20);
            this.searchWordLabel.TabIndex = 2;
            this.searchWordLabel.Text = "検索ワード";
            this.searchWordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // indexLabel
            // 
            this.indexLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.indexLabel.AutoSize = true;
            this.indexLabel.Location = new System.Drawing.Point(1, 64);
            this.indexLabel.Margin = new System.Windows.Forms.Padding(0);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(128, 20);
            this.indexLabel.TabIndex = 3;
            this.indexLabel.Text = "インデックス";
            this.indexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // levelLabel
            // 
            this.levelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(1, 85);
            this.levelLabel.Margin = new System.Windows.Forms.Padding(0);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(128, 20);
            this.levelLabel.TabIndex = 4;
            this.levelLabel.Text = "レベル";
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageLabel
            // 
            this.imageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageLabel.AutoSize = true;
            this.imageLabel.Location = new System.Drawing.Point(1, 106);
            this.imageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(128, 150);
            this.imageLabel.TabIndex = 5;
            this.imageLabel.Text = "画像";
            this.imageLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageLabel_MouseDown);
            // 
            // memoLabel
            // 
            this.memoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoLabel.AutoSize = true;
            this.memoLabel.Location = new System.Drawing.Point(1, 257);
            this.memoLabel.Margin = new System.Windows.Forms.Padding(0);
            this.memoLabel.Name = "memoLabel";
            this.memoLabel.Size = new System.Drawing.Size(128, 248);
            this.memoLabel.TabIndex = 6;
            this.memoLabel.Text = "メモ";
            // 
            // pageNameTextBox
            // 
            this.pageNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pageNameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pageNameTextBox.Location = new System.Drawing.Point(130, 1);
            this.pageNameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.pageNameTextBox.Name = "pageNameTextBox";
            this.pageNameTextBox.Size = new System.Drawing.Size(451, 20);
            this.pageNameTextBox.TabIndex = 7;
            this.pageNameTextBox.TextChanged += new System.EventHandler(this.pageNameTextBox_TextChanged);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.urlTextBox.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.urlTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.urlTextBox.Location = new System.Drawing.Point(130, 22);
            this.urlTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(451, 20);
            this.urlTextBox.TabIndex = 8;
            this.urlTextBox.TextChanged += new System.EventHandler(this.urlTextBox_TextChanged);
            this.urlTextBox.DoubleClick += new System.EventHandler(this.urlLabel_DoubleClick);
            // 
            // imageDataGridView
            // 
            this.imageDataGridView.AllowUserToResizeColumns = false;
            this.imageDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imageDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.imageDataGridView.ColumnHeadersHeight = 150;
            this.imageDataGridView.ColumnHeadersVisible = false;
            this.imageDataGridView.Location = new System.Drawing.Point(130, 106);
            this.imageDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.imageDataGridView.MultiSelect = false;
            this.imageDataGridView.Name = "imageDataGridView";
            this.imageDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.imageDataGridView.RowHeadersVisible = false;
            this.imageDataGridView.RowHeadersWidth = 150;
            this.imageDataGridView.RowTemplate.Height = 150;
            this.imageDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imageDataGridView.Size = new System.Drawing.Size(451, 150);
            this.imageDataGridView.TabIndex = 12;
            this.imageDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.imageDataGridView_CellMouseDoubleClick);
            this.imageDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageDataGridView_MouseDown);
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.HideSelection = false;
            this.treeView.Location = new System.Drawing.Point(3, 3);
            this.treeView.Name = "treeView";
            this.treeView.ShowNodeToolTips = true;
            this.treeView.ShowRootLines = false;
            this.treeView.Size = new System.Drawing.Size(224, 500);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseClick);
            // 
            // relationshipDiagramtabPage
            // 
            this.relationshipDiagramtabPage.Location = new System.Drawing.Point(4, 22);
            this.relationshipDiagramtabPage.Name = "relationshipDiagramtabPage";
            this.relationshipDiagramtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.relationshipDiagramtabPage.Size = new System.Drawing.Size(812, 506);
            this.relationshipDiagramtabPage.TabIndex = 1;
            this.relationshipDiagramtabPage.Text = "相関図";
            this.relationshipDiagramtabPage.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openURLToolStripMenuItem,
            this.openImageToolStripMenuItem,
            this.addImageToolStripMenuItem,
            this.removeImageToolStripMenuItem,
            this.addChildNodeToolStripMenuItem,
            this.addRootNodeToolStripMenuItem,
            this.removeNodeToolStripMenuItem});
            this.contextMenuStrip.Name = "imageContextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(128, 158);
            // 
            // openURLToolStripMenuItem
            // 
            this.openURLToolStripMenuItem.Name = "openURLToolStripMenuItem";
            this.openURLToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.openURLToolStripMenuItem.Text = "開く";
            this.openURLToolStripMenuItem.Click += new System.EventHandler(this.openURLToolStripMenuItem_Click);
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.openImageToolStripMenuItem.Text = "別窓で開く";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // addImageToolStripMenuItem
            // 
            this.addImageToolStripMenuItem.Name = "addImageToolStripMenuItem";
            this.addImageToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.addImageToolStripMenuItem.Text = "追加";
            this.addImageToolStripMenuItem.Click += new System.EventHandler(this.addImageToolStripMenuItem_Click);
            // 
            // removeImageToolStripMenuItem
            // 
            this.removeImageToolStripMenuItem.Name = "removeImageToolStripMenuItem";
            this.removeImageToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.removeImageToolStripMenuItem.Text = "削除";
            this.removeImageToolStripMenuItem.Click += new System.EventHandler(this.removeImageToolStripMenuItem_Click);
            // 
            // addChildNodeToolStripMenuItem
            // 
            this.addChildNodeToolStripMenuItem.Name = "addChildNodeToolStripMenuItem";
            this.addChildNodeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.addChildNodeToolStripMenuItem.Text = "子を追加";
            this.addChildNodeToolStripMenuItem.Click += new System.EventHandler(this.addChildNodeToolStripMenuItem_Click);
            // 
            // addRootNodeToolStripMenuItem
            // 
            this.addRootNodeToolStripMenuItem.Name = "addRootNodeToolStripMenuItem";
            this.addRootNodeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.addRootNodeToolStripMenuItem.Text = "新規追加";
            this.addRootNodeToolStripMenuItem.Click += new System.EventHandler(this.addRootNodeToolStripMenuItem_Click);
            // 
            // removeNodeToolStripMenuItem
            // 
            this.removeNodeToolStripMenuItem.Name = "removeNodeToolStripMenuItem";
            this.removeNodeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.removeNodeToolStripMenuItem.Text = "削除";
            this.removeNodeToolStripMenuItem.Click += new System.EventHandler(this.removeNodeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 571);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "WebsiteDiscoveryTool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.pageHierarchyTabPage.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.dataTableLayoutPanel.ResumeLayout(false);
            this.dataTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDataGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overrideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageHierarchyTabPage;
        private System.Windows.Forms.TabPage relationshipDiagramtabPage;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addChildNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNodeToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel dataTableLayoutPanel;
        private System.Windows.Forms.Label pageNameLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label searchWordLabel;
        private System.Windows.Forms.Label indexLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.Label memoLabel;
        private System.Windows.Forms.TextBox pageNameTextBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox levelTextBox;
        private System.Windows.Forms.TextBox indexTextBox;
        private System.Windows.Forms.TextBox searchWordTextBox;
        private System.Windows.Forms.DataGridView imageDataGridView;
        private System.Windows.Forms.TextBox memoTextBox;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRootNodeToolStripMenuItem;
    }
}

