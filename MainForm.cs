using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WebsiteDiscoveryTool
{
    public partial class MainForm : Form
    {
        enum RowCellType
        {
            PAGE_NAME = 0,
            URL,
            SEARCH_WORD,
            INDEX,
            LEVEL,
            IMAGE,
            MEMO
        }

        private readonly int DEFAULT_WINDOWS_HEIGHT = 610;
        private readonly int DEFAULT_MEMO_HEIGHT = 244;

        private PageData m_CurrentPageData = new PageData();
        public int m_SelectImageIndex = 0;
        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            AddNewPage("トップページ", null);
            treeView.SelectedNode = treeView.TopNode;
            treeView.Focus();
        }

        private void AddNewPage(string pageName, TreeNode parentNode)
        {
            PageData pageData = AddNewPageData(pageName, parentNode == null ? null : parentNode.Tag as PageData);

            AddNewNode(pageName, pageData, parentNode);

            m_CurrentPageData = pageData;
            UpdateDataView();
        }

        private PageData AddNewPageData(string name, PageData parentData = null)
        {
            PageData newPageData = new PageData
            {
                GUID = Guid.NewGuid(),
                PageName = name,
                URL = "",
                SearchWord = "",
                Index = 0,
                Level = 0,
                ImageData = new List<ImageData>(),
            };

            return newPageData;
        }

        private void AddNewNode(string name, PageData pageData, TreeNode parentNode = null)
        {
            TreeNode node = new TreeNode(name);
            node.Tag = pageData;
            if (parentNode != null)
                parentNode.Nodes.Add(node);
            else
                treeView.Nodes.Add(node);

            treeView.ExpandAll();
            treeView.SelectedNode = node;
        }

        private void UpdateDataView()
        {
            pageNameTextBox.Text = m_CurrentPageData.PageName;
            urlTextBox.Text = m_CurrentPageData.URL;
            searchWordTextBox.Text = m_CurrentPageData.SearchWord;
            indexTextBox.Text = m_CurrentPageData.Index.ToString();
            levelTextBox.Text = m_CurrentPageData.Level.ToString();

            imageDataGridView.ColumnCount = 0;
            imageDataGridView.RowTemplate.Height = 150;
            for (int i = 0; i < m_CurrentPageData.ImageData.Count; i++)
            {
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageColumn.Image = new Bitmap(m_CurrentPageData.ImageData[i].Path);
                imageColumn.Tag = m_CurrentPageData.ImageData[i].Guid;
                imageColumn.Width = 150;
                imageDataGridView.Columns.Add(imageColumn);
                imageDataGridView[i, 0].Value = m_CurrentPageData.ImageData[i].Image;
            }

            memoTextBox.Text = m_CurrentPageData.Memo;
        }

        private void RemovePage(TreeNode removedNode)
        {
            if (removedNode == treeView.TopNode)
                return;
            treeView.Nodes.Remove(removedNode);
        }

        private string SerializeTreeView()
        {
            List<SerializableTreeNode> serializableNodes = new List<SerializableTreeNode>();
            foreach (TreeNode node in treeView.Nodes)
            {
                serializableNodes.Add(new SerializableTreeNode(node));
            }
            return JsonConvert.SerializeObject(serializableNodes, Formatting.Indented);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
            AddNewPage("トップページ", null);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string json = SerializeTreeView();
            System.IO.File.WriteAllText("treeview.json", json);
        }

        private void overrideToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void treeView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeView.SelectedNode = treeView.GetNodeAt(e.X, e.Y);
                contextMenuStrip.Items.Clear();
                contextMenuStrip.Items.Add(addRootNodeToolStripMenuItem);
                contextMenuStrip.Items.Add(addChildNodeToolStripMenuItem);
                contextMenuStrip.Items.Add(removeNodeToolStripMenuItem);
                contextMenuStrip.Show(MousePosition);
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            m_CurrentPageData = treeView.SelectedNode.Tag as PageData;
            UpdateDataView();
        }

        private void urlLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip.Items.Clear();
                contextMenuStrip.Items.Add(openURLToolStripMenuItem);
                contextMenuStrip.Show(MousePosition);
            }
        }

        private void imageLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip.Items.Clear();
                contextMenuStrip.Items.Add(addImageToolStripMenuItem);
                contextMenuStrip.Show(MousePosition);
            }
        }

        private void imageDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip.Items.Clear();
                contextMenuStrip.Items.Add(addImageToolStripMenuItem);

                DataGridView.HitTestInfo info = ((DataGridView)sender).HitTest(e.X, e.Y);
                if (info.Type == DataGridViewHitTestType.Cell)
                {
                    contextMenuStrip.Items.Add(removeImageToolStripMenuItem);
                    contextMenuStrip.Items.Insert(0, openImageToolStripMenuItem);
                    m_SelectImageIndex = info.ColumnIndex;
                }

                contextMenuStrip.Show(MousePosition);
            }
        }

        private void urlLabel_DoubleClick(object sender, EventArgs e)
        {
            ProcessStartInfo pi = new ProcessStartInfo()
            {
                FileName = urlTextBox.Text,
                UseShellExecute = true,
            };

            if (Uri.IsWellFormedUriString(pi.FileName, UriKind.Absolute))
            {
                Process.Start(pi);
            }
        }

        private void imageDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                m_SelectImageIndex = e.ColumnIndex;
                openImageToolStripMenuItem_Click(null, null);
            }
        }

        private void addChildNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewPage("新しいページ", treeView.SelectedNode);
        }

        private void addRootNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewPage("新しいページ", null);
        }

        private void removeNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemovePage(treeView.SelectedNode);
        }

        private void openURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urlLabel_DoubleClick(null, null);
        }

        private (int width, int height) GetResizedDimensions(int originalWidth, int originalHeight, int maxWidth, int maxHeight)
        {
            if (originalWidth <= maxWidth && originalHeight <= maxHeight)
            {
                return (originalWidth, originalHeight);
            }

            double widthRatio = (double)maxWidth / originalWidth;
            double heightRatio = (double)maxHeight / originalHeight;
            double scale = Math.Min(widthRatio, heightRatio);

            return ((int)(originalWidth * scale), (int)(originalHeight * scale));
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var imageData = m_CurrentPageData.ImageData[m_SelectImageIndex];
            Image image = imageData.Image;

            Form form = new Form
            {
                Text = imageData.Path
            };

            (int newWidth, int newHeight) = GetResizedDimensions(image.Width, image.Height, 1920, 1080);
            form.Size = new Size(newWidth, newHeight);

            var pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = image
            };

            form.Controls.Add(pictureBox);
            form.Show();
        }

        private void addImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "画像ファイル(*.jpg;*.png)|*.jpg;*.png";
            ofd.Title = "画像ファイルを選択してください";
            ofd.RestoreDirectory = true;
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                Image img;
                using (var fs = new System.IO.FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    img = Image.FromStream(fs);
                }

                ImageData imageData = new ImageData()
                {
                    Guid = Guid.NewGuid(),
                    Image = img,
                    Path = filePath
                };
                m_CurrentPageData.ImageData.Add(imageData);

                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageColumn.Image = new Bitmap(imageData.Path);
                imageColumn.Tag = imageData.Guid;
                imageColumn.Width = 150;

                imageDataGridView.Columns.Add(imageColumn);
                imageDataGridView[imageDataGridView.Columns.Count - 1, 0].Value = imageData.Image;
            }
        }

        private void removeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_CurrentPageData.ImageData.RemoveAt(m_SelectImageIndex);
            imageDataGridView.Columns.RemoveAt(m_SelectImageIndex);
        }

        private void pageNameTextBox_TextChanged(object sender, EventArgs e)
        {
            m_CurrentPageData.PageName = pageNameTextBox.Text;
            treeView.SelectedNode.Text = m_CurrentPageData.PageName;
        }

        private void urlTextBox_TextChanged(object sender, EventArgs e)
        {
            m_CurrentPageData.URL = urlTextBox.Text;
        }

        private void searchWordTextBox_TextChanged(object sender, EventArgs e)
        {
            m_CurrentPageData.SearchWord = searchWordTextBox.Text;
            treeView.SelectedNode.ToolTipText = m_CurrentPageData.SearchWord;
        }

        private void indexTextBox_TextChanged(object sender, EventArgs e)
        {
            m_CurrentPageData.Index = int.Parse(indexTextBox.Text);
        }

        private void levelTextBox_TextChanged(object sender, EventArgs e)
        {
            m_CurrentPageData.Level = int.Parse(levelTextBox.Text);
        }

        private void memoTextBox_TextChanged(object sender, EventArgs e)
        {
            m_CurrentPageData.Memo = memoTextBox.Text;
        }
    }
}