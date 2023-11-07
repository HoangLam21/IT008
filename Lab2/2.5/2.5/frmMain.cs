using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2._5
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void InitTree()
        {
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
        private void frmMain_Load(object sender, EventArgs e)
        {
            InitTree();
            treeView1.ImageList = imageList1;
            listView1.SmallImageList = imageList2;
            listView1.LargeImageList = imageList2;

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_BeforeCollapse_1(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 0;
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear();
            node.ImageIndex = 0;
            try
            {
                foreach (string dir in Directory.GetDirectories(node.FullPath))
                {
                    TreeNode n = node.Nodes.Add(Path.GetFileName(dir));
                    n.Nodes.Add("Temp");
                }
            }
            catch { }
        }
        private int GetImageIndex(string fileExtension)
        {
            switch (fileExtension)
            {
                case ".txt": return 5;
                case ".docx": return 4;
                case ".xlsx": return 3;
                case ".ppt": return 2;
                case ".png":
                case ".jpg": return 1;
                case ".pdf": return 7;
                default: return 0;
            }
        }
        private int iFolder;
        private int iFile;
        private void AddFolderListView(DirectoryInfo[] subfolder)
        {
            iFolder = 0;
            foreach (var item in subfolder)
            {
                string[] value = new string[5];
                value[0] = item.Name.ToString();
                value[1] = "Folder";
                value[2] = "N/A";
                value[3] = item.LastWriteTime.ToString();
                value[4] = item.FullName.ToString();
                ListViewItem item1 = new ListViewItem(value);
                item1.ImageIndex = 6;
                iFolder++;
                listView1.Items.Add(item1);
            }
        }
        private void AddFileListView(FileInfo[] subfile_info)
        {
            iFile = 0;
            foreach (var file in subfile_info)
            {
                string[] value = new string[5];
                value[0] = file.Name.ToString();
                value[1] = file.Extension;
                value[2] = (file.Length / 1024).ToString();
                value[3] = file.LastWriteTime.ToString();
                value[4] = file.FullName.ToString();
                ListViewItem item1 = new ListViewItem(value);
                item1.ImageIndex = GetImageIndex(value[1]);
                iFile++;
                listView1.Items.Add(item1);
            }
        }
        private void AddListView()
        {
            TreeNode selectedNode = treeView1.SelectedNode;
            if (selectedNode != null)
            {
                string path = selectedNode.FullPath;
                listView1.Items.Clear();
                DirectoryInfo[] subfolder_info = new DirectoryInfo(path).GetDirectories();
                AddFolderListView(subfolder_info);
                FileInfo[] subfile_info = new DirectoryInfo(path).GetFiles();
                AddFileListView(subfile_info);
            }
        }
        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddListView();
        }

        private Stack<string> path_stack = new Stack<string>();
        private Stack<string> path_stack2 = new Stack<string>();
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                ListViewItem item = listView1.FocusedItem;
                //Get full path of focused item
                string path = item.SubItems[4].Text;
                FileInfo inf = new FileInfo(path);
                //Run file, you don't need to know what type of file
                if (inf.Exists)
                {
                    Process.Start(path);
                    return;
                }
                //Open folder, you just plus folder name into current path
                DirectoryInfo inf2 = new DirectoryInfo(path + "\\");
                if (inf2.Exists)
                {
                    listView1.Items.Clear();
                    DirectoryInfo[] subfolder_info = new DirectoryInfo(path).GetDirectories();
                    AddFolderListView(subfolder_info);
                    FileInfo[] subfile_info = new DirectoryInfo(path).GetFiles();
                    AddFileListView(subfile_info);
                }
                else
                {
                    MessageBox.Show("Đường dẫn không được tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void toolStripUp_Click(object sender, EventArgs e)
        {
            TreeNode currentNode = treeView1.SelectedNode;
            try
            {
                TreeNode parentNode = currentNode.Parent;
                if (parentNode != null)
                {
                    string path = parentNode.FullPath;
                    if (path != null)
                    {
                        treeView1.SelectedNode = parentNode;
                        listView1.Items.Clear();
                        DirectoryInfo[] subfolder_info = new DirectoryInfo(path).GetDirectories();
                        AddFolderListView(subfolder_info);
                        FileInfo[] subfile_info = new DirectoryInfo(path).GetFiles();
                        AddFileListView(subfile_info);
                    }
                    else
                        MessageBox.Show("Đường dẫn không được tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void toolStripRefresh_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeView1.SelectedNode;
            string path = selectedNode.FullPath;
            listView1.Items.Clear();
            DirectoryInfo[] subfolder_info = new DirectoryInfo(path).GetDirectories();
            AddFolderListView(subfolder_info);
            FileInfo[] subfile_info = new DirectoryInfo(path).GetFiles();
            AddFileListView(subfile_info);
        }
        private void largeIconsToolStripMenuItem1_DoubleClick(object sender, EventArgs e)
        {
            this.listView1.View = View.LargeIcon;
        }

        private void smallIconsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.SmallIcon;
        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.List;
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.Tile;
        }


        private bool IsCopying = false;
        private bool IsCutting = false;
        private bool IsFolder = false;
        private bool IsListView = false;
        //Temp variable
        private ListViewItem itemPaste;
        private string path_Folder;
        private string path_File;
        private string path_Source;
        private string path_Destination;

        private void toolStripCut_Click(object sender, EventArgs e)
        {
            IsCutting = true;
            if (listView1.Focused)
            {
                IsListView = true;
                itemPaste = listView1.FocusedItem;
                itemPaste.ForeColor = Color.Gray;
                if (itemPaste == null) return;
                //Check cutting type: file or folder
                if (itemPaste.SubItems[1].Text.Trim() == "Folder")
                {
                    IsFolder = true;
                    path_Folder = itemPaste.SubItems[4].Text + "\\";
                }
                else
                {
                    IsFolder = false;
                    path_File = itemPaste.SubItems[4].Text;
                }
            }
            toolStripPaste.Enabled = true;
        }

        private void toolStripCopy_Click(object sender, EventArgs e)
        {
            IsCopying = true;
            if (listView1.Focused)
            {
                IsListView = true;
                itemPaste = listView1.FocusedItem;
                if (itemPaste == null) return;
                //Check copying type: file or folder

                if (itemPaste.SubItems[1].Text.Trim() == "Folder")
                {
                    IsFolder = true;
                    path_Folder = itemPaste.SubItems[4].Text + "\\";
                }
                else
                {
                    IsFolder = false;
                    path_File = itemPaste.SubItems[4].Text;
                }
            }
            toolStripPaste.Enabled = true;
        }

        private void toolStripPaste_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsListView)
                {
                    if (IsFolder)
                    {
                        ListViewItem selectedItem = listView1.SelectedItems[0];
                        path_Source = selectedItem.SubItems[0].Text;
                        TreeNode currentNode = treeView1.SelectedNode;
                        string path = currentNode.FullPath;
                        path_Destination = path;
                    }
                    else
                    { 
                        ListViewItem selectedItem = listView1.SelectedItems[0];
                        path_Source = selectedItem.SubItems[0].Text;
                        TreeNode currentNode = treeView1.SelectedNode;
                        string path = currentNode.FullPath;
                        path_Destination = path;
                    }
                }
                //Check pasting type: copy or cut

                if (IsCopying)
                {
                    if (IsFolder)
                    {
                        Directory.CreateDirectory(path_Destination);
                    }
                    else
                    {
                        FileSystem.FileCopy(path_Source, path_Destination);
                    }
                    IsCopying = false;
                }
                if (IsCutting)
                {
                    if (IsFolder)
                    {
                        Directory.Move(path_Source, path_Destination);
                    }
                    else
                    {
                        File.Move(path_Source, path_Destination);
                    }
                    IsCutting = false;
                }
                toolStripPaste.Enabled = true;
                toolStripRefresh_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
