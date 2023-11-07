namespace _2._5
{
    public partial class Form1 : Form
    {

        private bool isCutOperation;
        private ListViewItem clipboardItm;
        private FileSystemInfo clipboardItem;
        private object detailsToolStripMenuItem;


        public Form1()
        {
            InitializeComponent();
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string currentName = selectedItem.Text;

                // Hiển thị hộp thoại đổi tên (hoặc sử dụng TextBox trực tiếp trên ListViewItem)
                string newName = Microsoft.VisualBasic.Interaction.InputBox("Enter new name:", "Rename", currentName);

                if (!string.IsNullOrEmpty(newName))
                {
                    selectedItem.Text = newName;
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {selectedItem.Text}?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Thực hiện hành động xóa
                    listView1.Items.Remove(selectedItem);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Do you want to exit ?", "Message", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes) Application.Exit();
        }


        public class FileSystemInfoItem
        {
            public FileSystemInfo FileSystemInfo { get; set; }

            public FileSystemInfoItem(FileSystemInfo info)
            {
                FileSystemInfo = info;
            }

            public static implicit operator FileSystemInfo(FileSystemInfoItem v)
            {
                throw new NotImplementedException();
            }
        }

        private void CopySelectedFolder()
        {
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.Tag is DirectoryInfo)
            {
                DirectoryInfo selectedFolder = (DirectoryInfo)treeView1.SelectedNode.Tag;
                clipboardItem = new FileSystemInfoItem(selectedFolder);
                isCutOperation = false;
            }
        }

        private void CopySelectedItem()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Lưu trữ thông tin của item được chọn vào Clipboard
                clipboardItm = listView1.SelectedItems[0].Clone() as ListViewItem;
                isCutOperation = false;
            }
            else if (treeView1.SelectedNode != null && treeView1.SelectedNode.Tag is DirectoryInfo)
            {
                CopySelectedFolder();
            }
        }

        private void CutSelectedItem()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Lưu trữ thông tin của item được chọn vào Clipboard và thiết lập cờ cắt
                clipboardItm = (ListViewItem)listView1.SelectedItems[0].Clone();
                isCutOperation = true;

                // Xóa item nếu là thao tác cắt
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else if (treeView1.SelectedNode != null && treeView1.SelectedNode.Tag is DirectoryInfo)
            {
                CopySelectedFolder();
            }
        }

        private void CopyDirectory(string fullName, string v)
        {
            throw new NotImplementedException();
        }

        private void DisplayList(DirectoryInfo directory)
        {
            // Hiển thị danh sách thư mục và tập tin trong ListView
            listView1.Items.Clear();
            AddFolderListView(directory.GetDirectories());
            AddFileListView(directory.GetFiles());
        }

        private void LoadDrive()
        {
            treeView1.Nodes.Clear();

            string[] drives = Directory.GetLogicalDrives();
            TreeNode node = null;
            foreach (string drive in drives)
            {
                node = new TreeNode(drive);
                node.ImageIndex = 1;
                treeView1.Nodes.Add(node);
                node.Nodes.Add("Temp");
            }
        }
        private void PasteSelectedItem()
        {
            if (clipboardItem != null)
            {
                try
                {
                    FileSystemInfoItem fileInfoItem = clipboardItm.Tag as FileSystemInfoItem;

                    if (fileInfoItem != null)
                    {
                        // Đối tượng FileSystemInfo chứa thông tin về thư mục hoặc tập tin
                        FileSystemInfo fileInfo = fileInfoItem.FileSystemInfo;

                        // Đường dẫn thư mục đích (thay thế bằng đường dẫn thư mục bạn muốn paste)
                        string destinationPath = treeView1.SelectedNode.FullPath;

                        if (fileInfo is DirectoryInfo)
                        {
                            // Nếu là thư mục, thực hiện paste thư mục
                            DirectoryInfo sourceDir = (DirectoryInfo)fileInfo;
                            DirectoryInfo destinationDir = new DirectoryInfo(Path.Combine(destinationPath, sourceDir.Name));

                            CopyDirectory(sourceDir.FullName, destinationDir.FullName);
                        }
                        else if (fileInfo is FileInfo)
                        {
                            // Nếu là tập tin, thực hiện paste tập tin
                            FileInfo sourceFile = (FileInfo)fileInfo;
                            string destinationFilePath = Path.Combine(destinationPath, sourceFile.Name);

                            File.Copy(sourceFile.FullName, destinationFilePath, true);
                        }

                        // Nếu là thao tác cắt, không cần làm gì thêm vì đã xóa item gốc khi cut

                        // Refresh ListView
                        LoadDrive();
                        DisplayList((DirectoryInfo)treeView1.SelectedNode.Tag);

                        // Xóa thông tin trong Clipboard để tránh paste lặp lại
                        clipboardItem = null;
                        clipboardItm = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopySelectedItem();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CutSelectedItem();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteSelectedItem();
        }

        private void largeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetView(View.LargeIcon);
        }

        private void smallIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetView(View.SmallIcon);
        }

        private void listIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetView(View.List);
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetView(View.Details);
        }

        private void SetView(View view)
        {
            listView1.View = view;

            // Tùy chỉnh các thiết lập khác dựa trên chế độ xem nếu cần
            if (view == View.Details)
            {
                // Hiển thị các cột thông tin trong chế độ Details
                listView1.Columns.Clear();
                listView1.Columns.Add("Name", 200);
                listView1.Columns.Add("Type", 100);
                listView1.Columns.Add("Size", 100);
                listView1.Columns.Add("Last Modified", 150);
                listView1.Columns.Add("Path", 400);
            }
            else
            {
                // Ẩn các cột nếu không phải chế độ Details
                listView1.Columns.Clear();
            }
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("co gi hoi lien he hoi ban dao");
        }
    }
}