namespace _2._5
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            splitContainer1 = new SplitContainer();
            treeView1 = new TreeView();
            listView1 = new ListView();
            imageList2 = new ImageList(components);
            imageList1 = new ImageList(components);
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            renameToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            largeIconsToolStripMenuItem = new ToolStripMenuItem();
            smallIconsToolStripMenuItem = new ToolStripMenuItem();
            listIconsToolStripMenuItem = new ToolStripMenuItem();
            listToolStripMenuItem = new ToolStripMenuItem();
            detailToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripUp = new ToolStripButton();
            toolStripRefresh = new ToolStripButton();
            toolStripCut = new ToolStripButton();
            toolStripCopy = new ToolStripButton();
            toolStripPaste = new ToolStripButton();
            toolStripView = new ToolStripDropDownButton();
            largeIconsToolStripMenuItem1 = new ToolStripMenuItem();
            smallIconsToolStripMenuItem1 = new ToolStripMenuItem();
            listToolStripMenuItem1 = new ToolStripMenuItem();
            tileToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 105);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(treeView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listView1);
            splitContainer1.Size = new Size(2475, 1156);
            splitContainer1.SplitterDistance = 609;
            splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(609, 1156);
            treeView1.TabIndex = 1;
            treeView1.BeforeCollapse += treeView1_BeforeCollapse_1;
            treeView1.BeforeExpand += treeView1_BeforeExpand;
            treeView1.MouseDoubleClick += treeView1_MouseDoubleClick;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(1862, 1156);
            listView1.SmallImageList = imageList2;
            listView1.StateImageList = imageList2;
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth8Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "icons8-file-48.png");
            imageList2.Images.SetKeyName(1, "icons8-xlarge-icons-48.png");
            imageList2.Images.SetKeyName(2, "icons8-microsoft-powerpoint-2019-48.png");
            imageList2.Images.SetKeyName(3, "icons8-microsoft-excel-2019-48.png");
            imageList2.Images.SetKeyName(4, "icons8-microsoft-word-2019-48.png");
            imageList2.Images.SetKeyName(5, "icons8-txt-48.png");
            imageList2.Images.SetKeyName(6, "icons8-new-folder-48.png");
            imageList2.Images.SetKeyName(7, "icons8-pdf-48.png");
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-new-folder-48.png");
            imageList1.Images.SetKeyName(1, "icons8-new-folder-48.png");
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2475, 49);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { renameToolStripMenuItem, deleteToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(87, 45);
            fileToolStripMenuItem.Text = "File";
            // 
            // renameToolStripMenuItem
            // 
            renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            renameToolStripMenuItem.Size = new Size(299, 54);
            renameToolStripMenuItem.Text = "Rename ";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(299, 54);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(299, 54);
            exitToolStripMenuItem.Text = "Exit ";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyToolStripMenuItem, cutToolStripMenuItem, pasteToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(100, 45);
            editToolStripMenuItem.Text = "Edit ";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(262, 54);
            copyToolStripMenuItem.Text = "Copy ";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(262, 54);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(262, 54);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { largeIconsToolStripMenuItem, smallIconsToolStripMenuItem, listIconsToolStripMenuItem, listToolStripMenuItem, detailToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(119, 45);
            viewToolStripMenuItem.Text = "Views";
            // 
            // largeIconsToolStripMenuItem
            // 
            largeIconsToolStripMenuItem.Name = "largeIconsToolStripMenuItem";
            largeIconsToolStripMenuItem.Size = new Size(334, 54);
            largeIconsToolStripMenuItem.Text = "Large icons";
            // 
            // smallIconsToolStripMenuItem
            // 
            smallIconsToolStripMenuItem.Name = "smallIconsToolStripMenuItem";
            smallIconsToolStripMenuItem.Size = new Size(334, 54);
            smallIconsToolStripMenuItem.Text = "Small icons";
            // 
            // listIconsToolStripMenuItem
            // 
            listIconsToolStripMenuItem.Name = "listIconsToolStripMenuItem";
            listIconsToolStripMenuItem.Size = new Size(334, 54);
            listIconsToolStripMenuItem.Text = "List icons";
            // 
            // listToolStripMenuItem
            // 
            listToolStripMenuItem.Name = "listToolStripMenuItem";
            listToolStripMenuItem.Size = new Size(334, 54);
            listToolStripMenuItem.Text = "List";
            // 
            // detailToolStripMenuItem
            // 
            detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            detailToolStripMenuItem.Size = new Size(334, 54);
            detailToolStripMenuItem.Text = "Detail";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(104, 45);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(274, 54);
            aboutToolStripMenuItem.Text = "About ";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(40, 40);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripUp, toolStripRefresh, toolStripCut, toolStripCopy, toolStripPaste, toolStripView });
            toolStrip1.Location = new Point(0, 49);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(2475, 52);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripUp
            // 
            toolStripUp.Image = (Image)resources.GetObject("toolStripUp.Image");
            toolStripUp.ImageTransparentColor = Color.Magenta;
            toolStripUp.Name = "toolStripUp";
            toolStripUp.Size = new Size(101, 45);
            toolStripUp.Text = "Up";
            toolStripUp.Click += toolStripUp_Click;
            // 
            // toolStripRefresh
            // 
            toolStripRefresh.Image = (Image)resources.GetObject("toolStripRefresh.Image");
            toolStripRefresh.ImageTransparentColor = Color.Magenta;
            toolStripRefresh.Name = "toolStripRefresh";
            toolStripRefresh.Size = new Size(168, 45);
            toolStripRefresh.Text = "Refresh ";
            toolStripRefresh.Click += toolStripRefresh_Click;
            // 
            // toolStripCut
            // 
            toolStripCut.Image = (Image)resources.GetObject("toolStripCut.Image");
            toolStripCut.ImageTransparentColor = Color.Magenta;
            toolStripCut.Name = "toolStripCut";
            toolStripCut.Size = new Size(108, 45);
            toolStripCut.Text = "Cut";
            toolStripCut.Click += toolStripCut_Click;
            // 
            // toolStripCopy
            // 
            toolStripCopy.Image = (Image)resources.GetObject("toolStripCopy.Image");
            toolStripCopy.ImageTransparentColor = Color.Magenta;
            toolStripCopy.Name = "toolStripCopy";
            toolStripCopy.Size = new Size(132, 45);
            toolStripCopy.Text = "Copy";
            toolStripCopy.Click += toolStripCopy_Click;
            // 
            // toolStripPaste
            // 
            toolStripPaste.Image = (Image)resources.GetObject("toolStripPaste.Image");
            toolStripPaste.ImageTransparentColor = Color.Magenta;
            toolStripPaste.Name = "toolStripPaste";
            toolStripPaste.Size = new Size(132, 45);
            toolStripPaste.Text = "Paste";
            toolStripPaste.Click += toolStripPaste_Click;
            // 
            // toolStripView
            // 
            toolStripView.DropDownItems.AddRange(new ToolStripItem[] { largeIconsToolStripMenuItem1, smallIconsToolStripMenuItem1, listToolStripMenuItem1, tileToolStripMenuItem });
            toolStripView.Image = (Image)resources.GetObject("toolStripView.Image");
            toolStripView.ImageTransparentColor = Color.Magenta;
            toolStripView.Name = "toolStripView";
            toolStripView.Size = new Size(161, 45);
            toolStripView.Text = "Views";
            // 
            // largeIconsToolStripMenuItem1
            // 
            largeIconsToolStripMenuItem1.Name = "largeIconsToolStripMenuItem1";
            largeIconsToolStripMenuItem1.Size = new Size(334, 54);
            largeIconsToolStripMenuItem1.Text = "Large icons";
            largeIconsToolStripMenuItem1.DoubleClick += largeIconsToolStripMenuItem1_DoubleClick;
            // 
            // smallIconsToolStripMenuItem1
            // 
            smallIconsToolStripMenuItem1.Name = "smallIconsToolStripMenuItem1";
            smallIconsToolStripMenuItem1.Size = new Size(334, 54);
            smallIconsToolStripMenuItem1.Text = "Small icons";
            smallIconsToolStripMenuItem1.Click += smallIconsToolStripMenuItem1_Click;
            // 
            // listToolStripMenuItem1
            // 
            listToolStripMenuItem1.Name = "listToolStripMenuItem1";
            listToolStripMenuItem1.Size = new Size(334, 54);
            listToolStripMenuItem1.Text = "List";
            listToolStripMenuItem1.Click += listToolStripMenuItem1_Click;
            // 
            // tileToolStripMenuItem
            // 
            tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            tileToolStripMenuItem.Size = new Size(334, 54);
            tileToolStripMenuItem.Text = "Tile";
            tileToolStripMenuItem.Click += tileToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2475, 1156);
            Controls.Add(toolStrip1);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private TreeView treeView1;
        private ListView listView1;
        private ImageList imageList1;
        private ImageList imageList2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem renameToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem largeIconsToolStripMenuItem;
        private ToolStripMenuItem smallIconsToolStripMenuItem;
        private ToolStripMenuItem listIconsToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem;
        private ToolStripMenuItem detailToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripUp;
        private ToolStripButton toolStripRefresh;
        private ToolStripButton toolStripCut;
        private ToolStripButton toolStripCopy;
        private ToolStripDropDownButton toolStripView;
        private ToolStripMenuItem largeIconsToolStripMenuItem1;
        private ToolStripMenuItem smallIconsToolStripMenuItem1;
        private ToolStripMenuItem listToolStripMenuItem1;
        private ToolStripMenuItem tileToolStripMenuItem;
        private ToolStripButton toolStripPaste;
    }
}