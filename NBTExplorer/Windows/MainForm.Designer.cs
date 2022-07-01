namespace NBTExplorer.Windows
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
			this._menuItemOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
			this._menuItemOpenMinecraftSaveFolder = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
			this._menuItemOpenInExplorer = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this._menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
			this._menuItemRefresh = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this._menuItemRecentFiles = new System.Windows.Forms.ToolStripMenuItem();
			this._menuItemRecentFolders = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this._menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._menuItemCut = new System.Windows.Forms.ToolStripMenuItem();
			this._menuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
			this._menuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this._menuItemRename = new System.Windows.Forms.ToolStripMenuItem();
			this._menuItemEditValue = new System.Windows.Forms.ToolStripMenuItem();
			this._menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
			this._menuItemMoveUp = new System.Windows.Forms.ToolStripMenuItem();
			this._menuItemMoveDown = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._menuItemFind = new System.Windows.Forms.ToolStripMenuItem();
			this._menuItemFindNext = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
			this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
			this.findBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.h帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this._buttonOpen = new System.Windows.Forms.ToolStripButton();
			this._buttonOpenFolder = new System.Windows.Forms.ToolStripButton();
			this._buttonSave = new System.Windows.Forms.ToolStripButton();
			this._buttonRefresh = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this._buttonCut = new System.Windows.Forms.ToolStripButton();
			this._buttonCopy = new System.Windows.Forms.ToolStripButton();
			this._buttonPaste = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this._buttonRename = new System.Windows.Forms.ToolStripButton();
			this._buttonEdit = new System.Windows.Forms.ToolStripButton();
			this._buttonDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this._buttonAddTagByte = new System.Windows.Forms.ToolStripButton();
			this._buttonAddTagShort = new System.Windows.Forms.ToolStripButton();
			this._buttonAddTagInt = new System.Windows.Forms.ToolStripButton();
			this._buttonAddTagLong = new System.Windows.Forms.ToolStripButton();
			this._buttonAddTagFloat = new System.Windows.Forms.ToolStripButton();
			this._buttonAddTagDouble = new System.Windows.Forms.ToolStripButton();
			this._buttonAddTagByteArray = new System.Windows.Forms.ToolStripButton();
			this._buttonAddTagIntArray = new System.Windows.Forms.ToolStripButton();
			this._buttonAddTagLongArray = new System.Windows.Forms.ToolStripButton();
			this._buttonAddTagString = new System.Windows.Forms.ToolStripButton();
			this._buttonAddTagList = new System.Windows.Forms.ToolStripButton();
			this._buttonAddTagCompound = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this._buttonFindNext = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._nodeTree = new NBTExplorer.Vendor.MultiSelectTreeView.MultiSelectTreeView();
			this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.导出所有告示牌实体EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(762, 25);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemOpen,
            this._menuItemOpenFolder,
            this._menuItemOpenMinecraftSaveFolder,
            this.toolStripSeparator12,
            this._menuItemOpenInExplorer,
            this.toolStripSeparator3,
            this._menuItemSave,
            this._menuItemRefresh,
            this.toolStripSeparator4,
            this._menuItemRecentFiles,
            this._menuItemRecentFolders,
            this.toolStripSeparator8,
            this._menuItemExit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
			this.fileToolStripMenuItem.Text = "文件(&F)";
			this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
			// 
			// _menuItemOpen
			// 
			this._menuItemOpen.Image = ((System.Drawing.Image)(resources.GetObject("_menuItemOpen.Image")));
			this._menuItemOpen.Name = "_menuItemOpen";
			this._menuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this._menuItemOpen.Size = new System.Drawing.Size(262, 22);
			this._menuItemOpen.Text = "打开文件(&O)";
			// 
			// _menuItemOpenFolder
			// 
			this._menuItemOpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("_menuItemOpenFolder.Image")));
			this._menuItemOpenFolder.Name = "_menuItemOpenFolder";
			this._menuItemOpenFolder.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
			this._menuItemOpenFolder.Size = new System.Drawing.Size(262, 22);
			this._menuItemOpenFolder.Text = "打开文件夹(&F)";
			// 
			// _menuItemOpenMinecraftSaveFolder
			// 
			this._menuItemOpenMinecraftSaveFolder.Name = "_menuItemOpenMinecraftSaveFolder";
			this._menuItemOpenMinecraftSaveFolder.Size = new System.Drawing.Size(262, 22);
			this._menuItemOpenMinecraftSaveFolder.Text = "打开 Minecraft 存档(&M)";
			// 
			// toolStripSeparator12
			// 
			this.toolStripSeparator12.Name = "toolStripSeparator12";
			this.toolStripSeparator12.Size = new System.Drawing.Size(259, 6);
			// 
			// _menuItemOpenInExplorer
			// 
			this._menuItemOpenInExplorer.Enabled = false;
			this._menuItemOpenInExplorer.Image = global::NBTExplorer.Properties.Resources.Icos_20198411425586;
			this._menuItemOpenInExplorer.Name = "_menuItemOpenInExplorer";
			this._menuItemOpenInExplorer.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
			this._menuItemOpenInExplorer.Size = new System.Drawing.Size(262, 22);
			this._menuItemOpenInExplorer.Text = "在资源管理器中显示";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(259, 6);
			// 
			// _menuItemSave
			// 
			this._menuItemSave.Image = ((System.Drawing.Image)(resources.GetObject("_menuItemSave.Image")));
			this._menuItemSave.Name = "_menuItemSave";
			this._menuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this._menuItemSave.Size = new System.Drawing.Size(262, 22);
			this._menuItemSave.Text = "保存(&S)";
			// 
			// _menuItemRefresh
			// 
			this._menuItemRefresh.Image = ((System.Drawing.Image)(resources.GetObject("_menuItemRefresh.Image")));
			this._menuItemRefresh.Name = "_menuItemRefresh";
			this._menuItemRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this._menuItemRefresh.Size = new System.Drawing.Size(262, 22);
			this._menuItemRefresh.Text = "刷新(&R)";
			this._menuItemRefresh.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(259, 6);
			// 
			// _menuItemRecentFiles
			// 
			this._menuItemRecentFiles.Name = "_menuItemRecentFiles";
			this._menuItemRecentFiles.Size = new System.Drawing.Size(262, 22);
			this._menuItemRecentFiles.Text = "最近文件";
			// 
			// _menuItemRecentFolders
			// 
			this._menuItemRecentFolders.Name = "_menuItemRecentFolders";
			this._menuItemRecentFolders.Size = new System.Drawing.Size(262, 22);
			this._menuItemRecentFolders.Text = "最近目录";
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(259, 6);
			// 
			// _menuItemExit
			// 
			this._menuItemExit.Image = ((System.Drawing.Image)(resources.GetObject("_menuItemExit.Image")));
			this._menuItemExit.Name = "_menuItemExit";
			this._menuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this._menuItemExit.Size = new System.Drawing.Size(262, 22);
			this._menuItemExit.Text = "退出(&E)";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemCut,
            this._menuItemCopy,
            this._menuItemPaste,
            this.toolStripSeparator7,
            this._menuItemRename,
            this._menuItemEditValue,
            this._menuItemDelete,
            this.toolStripSeparator10,
            this._menuItemMoveUp,
            this._menuItemMoveDown});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
			this.editToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
			this.editToolStripMenuItem.Text = "修改(&E)";
			// 
			// _menuItemCut
			// 
			this._menuItemCut.Image = ((System.Drawing.Image)(resources.GetObject("_menuItemCut.Image")));
			this._menuItemCut.Name = "_menuItemCut";
			this._menuItemCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this._menuItemCut.Size = new System.Drawing.Size(180, 22);
			this._menuItemCut.Text = "剪切";
			// 
			// _menuItemCopy
			// 
			this._menuItemCopy.Image = ((System.Drawing.Image)(resources.GetObject("_menuItemCopy.Image")));
			this._menuItemCopy.Name = "_menuItemCopy";
			this._menuItemCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this._menuItemCopy.Size = new System.Drawing.Size(180, 22);
			this._menuItemCopy.Text = "复制";
			// 
			// _menuItemPaste
			// 
			this._menuItemPaste.Image = ((System.Drawing.Image)(resources.GetObject("_menuItemPaste.Image")));
			this._menuItemPaste.Name = "_menuItemPaste";
			this._menuItemPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this._menuItemPaste.Size = new System.Drawing.Size(180, 22);
			this._menuItemPaste.Text = "粘贴";
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(177, 6);
			// 
			// _menuItemRename
			// 
			this._menuItemRename.Image = ((System.Drawing.Image)(resources.GetObject("_menuItemRename.Image")));
			this._menuItemRename.Name = "_menuItemRename";
			this._menuItemRename.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this._menuItemRename.Size = new System.Drawing.Size(180, 22);
			this._menuItemRename.Text = "重命名";
			// 
			// _menuItemEditValue
			// 
			this._menuItemEditValue.Image = ((System.Drawing.Image)(resources.GetObject("_menuItemEditValue.Image")));
			this._menuItemEditValue.Name = "_menuItemEditValue";
			this._menuItemEditValue.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this._menuItemEditValue.Size = new System.Drawing.Size(180, 22);
			this._menuItemEditValue.Text = "修改值";
			// 
			// _menuItemDelete
			// 
			this._menuItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("_menuItemDelete.Image")));
			this._menuItemDelete.Name = "_menuItemDelete";
			this._menuItemDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this._menuItemDelete.Size = new System.Drawing.Size(180, 22);
			this._menuItemDelete.Text = "删除";
			// 
			// toolStripSeparator10
			// 
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			this.toolStripSeparator10.Size = new System.Drawing.Size(177, 6);
			// 
			// _menuItemMoveUp
			// 
			this._menuItemMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("_menuItemMoveUp.Image")));
			this._menuItemMoveUp.Name = "_menuItemMoveUp";
			this._menuItemMoveUp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
			this._menuItemMoveUp.Size = new System.Drawing.Size(180, 22);
			this._menuItemMoveUp.Text = "上移";
			this._menuItemMoveUp.Click += new System.EventHandler(this._menuItemMoveUp_Click);
			// 
			// _menuItemMoveDown
			// 
			this._menuItemMoveDown.Image = ((System.Drawing.Image)(resources.GetObject("_menuItemMoveDown.Image")));
			this._menuItemMoveDown.Name = "_menuItemMoveDown";
			this._menuItemMoveDown.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
			this._menuItemMoveDown.Size = new System.Drawing.Size(180, 22);
			this._menuItemMoveDown.Text = "下移";
			this._menuItemMoveDown.Click += new System.EventHandler(this._menuItemMoveDown_Click);
			// 
			// searchToolStripMenuItem
			// 
			this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemFind,
            this._menuItemFindNext,
            this.toolStripSeparator9,
            this.replaceToolStripMenuItem,
            this.toolStripSeparator11,
            this.findBlockToolStripMenuItem});
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			this.searchToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
			this.searchToolStripMenuItem.Text = "查找(&S)";
			// 
			// _menuItemFind
			// 
			this._menuItemFind.Image = ((System.Drawing.Image)(resources.GetObject("_menuItemFind.Image")));
			this._menuItemFind.Name = "_menuItemFind";
			this._menuItemFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this._menuItemFind.Size = new System.Drawing.Size(180, 22);
			this._menuItemFind.Text = "寻找...(&F)";
			this._menuItemFind.Click += new System.EventHandler(this._menuItemFind_Click_1);
			// 
			// _menuItemFindNext
			// 
			this._menuItemFindNext.Image = ((System.Drawing.Image)(resources.GetObject("_menuItemFindNext.Image")));
			this._menuItemFindNext.Name = "_menuItemFindNext";
			this._menuItemFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this._menuItemFindNext.Size = new System.Drawing.Size(180, 22);
			this._menuItemFindNext.Text = "寻找下一个(&N)";
			// 
			// toolStripSeparator9
			// 
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new System.Drawing.Size(177, 6);
			// 
			// replaceToolStripMenuItem
			// 
			this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
			this.replaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
			this.replaceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.replaceToolStripMenuItem.Text = "替换...(&R)";
			this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
			// 
			// toolStripSeparator11
			// 
			this.toolStripSeparator11.Name = "toolStripSeparator11";
			this.toolStripSeparator11.Size = new System.Drawing.Size(177, 6);
			// 
			// findBlockToolStripMenuItem
			// 
			this.findBlockToolStripMenuItem.Name = "findBlockToolStripMenuItem";
			this.findBlockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.findBlockToolStripMenuItem.Text = "区块查找器...(&C)";
			this.findBlockToolStripMenuItem.Click += new System.EventHandler(this.findBlockToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemAbout,
            this.h帮助ToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
			this.helpToolStripMenuItem.Text = "帮助(&H)";
			// 
			// _menuItemAbout
			// 
			this._menuItemAbout.Image = ((System.Drawing.Image)(resources.GetObject("_menuItemAbout.Image")));
			this._menuItemAbout.Name = "_menuItemAbout";
			this._menuItemAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this._menuItemAbout.Size = new System.Drawing.Size(180, 22);
			this._menuItemAbout.Text = "关于(&A)";
			// 
			// h帮助ToolStripMenuItem
			// 
			this.h帮助ToolStripMenuItem.Image = global::NBTExplorer.Properties.Resources.Icos_20198411425524;
			this.h帮助ToolStripMenuItem.Name = "h帮助ToolStripMenuItem";
			this.h帮助ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.h帮助ToolStripMenuItem.Text = "帮助(&H)";
			this.h帮助ToolStripMenuItem.Click += new System.EventHandler(this.h帮助ToolStripMenuItem_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "TAG_Byte.png");
			this.imageList1.Images.SetKeyName(1, "TAG_Short.png");
			this.imageList1.Images.SetKeyName(2, "TAG_Int.png");
			this.imageList1.Images.SetKeyName(3, "TAG_Long.png");
			this.imageList1.Images.SetKeyName(4, "TAG_Float.png");
			this.imageList1.Images.SetKeyName(5, "TAG_Double.png");
			this.imageList1.Images.SetKeyName(6, "TAG_Byte_Array.png");
			this.imageList1.Images.SetKeyName(7, "TAG_String.png");
			this.imageList1.Images.SetKeyName(8, "TAG_List.png");
			this.imageList1.Images.SetKeyName(9, "TAG_Compound.png");
			this.imageList1.Images.SetKeyName(10, "folder.png");
			this.imageList1.Images.SetKeyName(11, "block.png");
			this.imageList1.Images.SetKeyName(12, "wooden-box.png");
			this.imageList1.Images.SetKeyName(13, "map.png");
			this.imageList1.Images.SetKeyName(14, "TAG_Int_Array.png");
			this.imageList1.Images.SetKeyName(15, "question-white.png");
			this.imageList1.Images.SetKeyName(16, "edit-code-s.png");
			this.imageList1.Images.SetKeyName(17, "TAG_Long_Array.png");
			this.imageList1.Images.SetKeyName(18, "THE_VOID.png");
			this.imageList1.Images.SetKeyName(19, "Unknow.png");
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._buttonOpen,
            this._buttonOpenFolder,
            this._buttonSave,
            this._buttonRefresh,
            this.toolStripSeparator1,
            this._buttonCut,
            this._buttonCopy,
            this._buttonPaste,
            this.toolStripSeparator6,
            this._buttonRename,
            this._buttonEdit,
            this._buttonDelete,
            this.toolStripSeparator2,
            this._buttonAddTagByte,
            this._buttonAddTagShort,
            this._buttonAddTagInt,
            this._buttonAddTagLong,
            this._buttonAddTagFloat,
            this._buttonAddTagDouble,
            this._buttonAddTagByteArray,
            this._buttonAddTagIntArray,
            this._buttonAddTagLongArray,
            this._buttonAddTagString,
            this._buttonAddTagList,
            this._buttonAddTagCompound,
            this.toolStripSeparator5,
            this._buttonFindNext,
            this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 25);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(762, 25);
			this.toolStrip1.Stretch = true;
			this.toolStrip1.TabIndex = 0;
			// 
			// _buttonOpen
			// 
			this._buttonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonOpen.Image = ((System.Drawing.Image)(resources.GetObject("_buttonOpen.Image")));
			this._buttonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonOpen.Name = "_buttonOpen";
			this._buttonOpen.Size = new System.Drawing.Size(23, 22);
			this._buttonOpen.Text = "打开文件";
			// 
			// _buttonOpenFolder
			// 
			this._buttonOpenFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonOpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("_buttonOpenFolder.Image")));
			this._buttonOpenFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonOpenFolder.Name = "_buttonOpenFolder";
			this._buttonOpenFolder.Size = new System.Drawing.Size(23, 22);
			this._buttonOpenFolder.Text = "打开目录";
			// 
			// _buttonSave
			// 
			this._buttonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("_buttonSave.Image")));
			this._buttonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonSave.Name = "_buttonSave";
			this._buttonSave.Size = new System.Drawing.Size(23, 22);
			this._buttonSave.Text = "保存";
			// 
			// _buttonRefresh
			// 
			this._buttonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("_buttonRefresh.Image")));
			this._buttonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonRefresh.Name = "_buttonRefresh";
			this._buttonRefresh.Size = new System.Drawing.Size(23, 22);
			this._buttonRefresh.Text = "刷新(警告：请确认操作后继续)";
			this._buttonRefresh.Click += new System.EventHandler(this._buttonRefresh_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// _buttonCut
			// 
			this._buttonCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonCut.Image = ((System.Drawing.Image)(resources.GetObject("_buttonCut.Image")));
			this._buttonCut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonCut.Name = "_buttonCut";
			this._buttonCut.Size = new System.Drawing.Size(23, 22);
			this._buttonCut.Text = "剪切";
			// 
			// _buttonCopy
			// 
			this._buttonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonCopy.Image = ((System.Drawing.Image)(resources.GetObject("_buttonCopy.Image")));
			this._buttonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonCopy.Name = "_buttonCopy";
			this._buttonCopy.Size = new System.Drawing.Size(23, 22);
			this._buttonCopy.Text = "复制";
			// 
			// _buttonPaste
			// 
			this._buttonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonPaste.Image = ((System.Drawing.Image)(resources.GetObject("_buttonPaste.Image")));
			this._buttonPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonPaste.Name = "_buttonPaste";
			this._buttonPaste.Size = new System.Drawing.Size(23, 22);
			this._buttonPaste.Text = "粘贴";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
			// 
			// _buttonRename
			// 
			this._buttonRename.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonRename.Image = ((System.Drawing.Image)(resources.GetObject("_buttonRename.Image")));
			this._buttonRename.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonRename.Name = "_buttonRename";
			this._buttonRename.Size = new System.Drawing.Size(23, 22);
			this._buttonRename.Text = "重命名";
			// 
			// _buttonEdit
			// 
			this._buttonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("_buttonEdit.Image")));
			this._buttonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonEdit.Name = "_buttonEdit";
			this._buttonEdit.Size = new System.Drawing.Size(23, 22);
			this._buttonEdit.Text = "修改";
			// 
			// _buttonDelete
			// 
			this._buttonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("_buttonDelete.Image")));
			this._buttonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonDelete.Name = "_buttonDelete";
			this._buttonDelete.Size = new System.Drawing.Size(23, 22);
			this._buttonDelete.Text = "删除";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// _buttonAddTagByte
			// 
			this._buttonAddTagByte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonAddTagByte.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagByte.Image")));
			this._buttonAddTagByte.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonAddTagByte.Name = "_buttonAddTagByte";
			this._buttonAddTagByte.Size = new System.Drawing.Size(23, 22);
			this._buttonAddTagByte.Text = "新建字节标签";
			// 
			// _buttonAddTagShort
			// 
			this._buttonAddTagShort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonAddTagShort.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagShort.Image")));
			this._buttonAddTagShort.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonAddTagShort.Name = "_buttonAddTagShort";
			this._buttonAddTagShort.Size = new System.Drawing.Size(23, 22);
			this._buttonAddTagShort.Text = "新增短数字标签";
			// 
			// _buttonAddTagInt
			// 
			this._buttonAddTagInt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonAddTagInt.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagInt.Image")));
			this._buttonAddTagInt.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonAddTagInt.Name = "_buttonAddTagInt";
			this._buttonAddTagInt.Size = new System.Drawing.Size(23, 22);
			this._buttonAddTagInt.Text = "新增整数标签";
			// 
			// _buttonAddTagLong
			// 
			this._buttonAddTagLong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonAddTagLong.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagLong.Image")));
			this._buttonAddTagLong.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonAddTagLong.Name = "_buttonAddTagLong";
			this._buttonAddTagLong.Size = new System.Drawing.Size(23, 22);
			this._buttonAddTagLong.Text = "新增长数字标签";
			// 
			// _buttonAddTagFloat
			// 
			this._buttonAddTagFloat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonAddTagFloat.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagFloat.Image")));
			this._buttonAddTagFloat.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonAddTagFloat.Name = "_buttonAddTagFloat";
			this._buttonAddTagFloat.Size = new System.Drawing.Size(23, 22);
			this._buttonAddTagFloat.Text = "新增单精度小数标签";
			// 
			// _buttonAddTagDouble
			// 
			this._buttonAddTagDouble.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonAddTagDouble.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagDouble.Image")));
			this._buttonAddTagDouble.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonAddTagDouble.Name = "_buttonAddTagDouble";
			this._buttonAddTagDouble.Size = new System.Drawing.Size(23, 22);
			this._buttonAddTagDouble.Text = "新增双精度小数标签";
			// 
			// _buttonAddTagByteArray
			// 
			this._buttonAddTagByteArray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonAddTagByteArray.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagByteArray.Image")));
			this._buttonAddTagByteArray.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonAddTagByteArray.Name = "_buttonAddTagByteArray";
			this._buttonAddTagByteArray.Size = new System.Drawing.Size(23, 22);
			this._buttonAddTagByteArray.Text = "新增字节数组标签";
			// 
			// _buttonAddTagIntArray
			// 
			this._buttonAddTagIntArray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonAddTagIntArray.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagIntArray.Image")));
			this._buttonAddTagIntArray.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonAddTagIntArray.Name = "_buttonAddTagIntArray";
			this._buttonAddTagIntArray.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this._buttonAddTagIntArray.Size = new System.Drawing.Size(23, 22);
			this._buttonAddTagIntArray.Text = "新增整数数组标签";
			// 
			// _buttonAddTagLongArray
			// 
			this._buttonAddTagLongArray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonAddTagLongArray.Image = global::NBTExplorer.Properties.Resources.TAG_Long_Array;
			this._buttonAddTagLongArray.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonAddTagLongArray.Name = "_buttonAddTagLongArray";
			this._buttonAddTagLongArray.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this._buttonAddTagLongArray.Size = new System.Drawing.Size(23, 22);
			this._buttonAddTagLongArray.Text = "新增长整数数组标签";
			// 
			// _buttonAddTagString
			// 
			this._buttonAddTagString.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonAddTagString.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagString.Image")));
			this._buttonAddTagString.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonAddTagString.Name = "_buttonAddTagString";
			this._buttonAddTagString.Size = new System.Drawing.Size(23, 22);
			this._buttonAddTagString.Text = "新增文本标签";
			// 
			// _buttonAddTagList
			// 
			this._buttonAddTagList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonAddTagList.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagList.Image")));
			this._buttonAddTagList.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonAddTagList.Name = "_buttonAddTagList";
			this._buttonAddTagList.Size = new System.Drawing.Size(23, 22);
			this._buttonAddTagList.Text = "新增列表标签";
			// 
			// _buttonAddTagCompound
			// 
			this._buttonAddTagCompound.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonAddTagCompound.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagCompound.Image")));
			this._buttonAddTagCompound.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonAddTagCompound.Name = "_buttonAddTagCompound";
			this._buttonAddTagCompound.Size = new System.Drawing.Size(23, 22);
			this._buttonAddTagCompound.Text = "新增项";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// _buttonFindNext
			// 
			this._buttonFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonFindNext.Image = ((System.Drawing.Image)(resources.GetObject("_buttonFindNext.Image")));
			this._buttonFindNext.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonFindNext.Name = "_buttonFindNext";
			this._buttonFindNext.Size = new System.Drawing.Size(23, 22);
			this._buttonFindNext.Text = "寻找 / 寻找下一个";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = global::NBTExplorer.Properties.Resources.Icos_20198411425524;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "帮助";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// BottomToolStripPanel
			// 
			this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.BottomToolStripPanel.Name = "BottomToolStripPanel";
			this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// TopToolStripPanel
			// 
			this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.TopToolStripPanel.Name = "TopToolStripPanel";
			this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// RightToolStripPanel
			// 
			this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.RightToolStripPanel.Name = "RightToolStripPanel";
			this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// LeftToolStripPanel
			// 
			this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.LeftToolStripPanel.Name = "LeftToolStripPanel";
			this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// ContentPanel
			// 
			this.ContentPanel.Size = new System.Drawing.Size(562, 376);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
			// 
			// testToolStripMenuItem
			// 
			this.testToolStripMenuItem.Name = "testToolStripMenuItem";
			this.testToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.testToolStripMenuItem.Text = "Test";
			// 
			// _nodeTree
			// 
			this._nodeTree.AllowDrop = true;
			this._nodeTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._nodeTree.ImageIndex = 0;
			this._nodeTree.ImageList = this.imageList1;
			this._nodeTree.ItemHeight = 18;
			this._nodeTree.Location = new System.Drawing.Point(0, 50);
			this._nodeTree.Margin = new System.Windows.Forms.Padding(0);
			this._nodeTree.Name = "_nodeTree";
			this._nodeTree.SelectedImageIndex = 0;
			this._nodeTree.SelectedNodes = ((System.Collections.Generic.List<System.Windows.Forms.TreeNode>)(resources.GetObject("_nodeTree.SelectedNodes")));
			this._nodeTree.Size = new System.Drawing.Size(762, 450);
			this._nodeTree.TabIndex = 0;
			// 
			// 工具TToolStripMenuItem
			// 
			this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出所有告示牌实体EToolStripMenuItem});
			this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
			this.工具TToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
			this.工具TToolStripMenuItem.Text = "工具(&T)";
			// 
			// 导出所有告示牌实体EToolStripMenuItem
			// 
			this.导出所有告示牌实体EToolStripMenuItem.Name = "导出所有告示牌实体EToolStripMenuItem";
			this.导出所有告示牌实体EToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.导出所有告示牌实体EToolStripMenuItem.Text = "导出所有告示牌实体(&E)";
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(762, 499);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this._nodeTree);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NBTExplorer (Fixed)";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private NBTExplorer.Vendor.MultiSelectTreeView.MultiSelectTreeView _nodeTree;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton _buttonOpen;
        private System.Windows.Forms.ToolStripButton _buttonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton _buttonRename;
        private System.Windows.Forms.ToolStripButton _buttonEdit;
        private System.Windows.Forms.ToolStripButton _buttonDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton _buttonAddTagByte;
        private System.Windows.Forms.ToolStripButton _buttonAddTagShort;
        private System.Windows.Forms.ToolStripButton _buttonAddTagInt;
        private System.Windows.Forms.ToolStripButton _buttonAddTagLong;
        private System.Windows.Forms.ToolStripButton _buttonAddTagFloat;
        private System.Windows.Forms.ToolStripButton _buttonAddTagDouble;
        private System.Windows.Forms.ToolStripButton _buttonAddTagByteArray;
        private System.Windows.Forms.ToolStripButton _buttonAddTagList;
        private System.Windows.Forms.ToolStripButton _buttonAddTagCompound;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripButton _buttonAddTagString;
        private System.Windows.Forms.ToolStripMenuItem _menuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem _menuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem _menuItemOpenFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem _menuItemSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem _menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem _menuItemFind;
        private System.Windows.Forms.ToolStripMenuItem _menuItemFindNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton _buttonFindNext;
        private System.Windows.Forms.ToolStripButton _buttonOpenFolder;
        private System.Windows.Forms.ToolStripMenuItem _menuItemOpenMinecraftSaveFolder;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStripButton _buttonAddTagIntArray;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _menuItemCut;
        private System.Windows.Forms.ToolStripMenuItem _menuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem _menuItemPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem _menuItemRename;
        private System.Windows.Forms.ToolStripMenuItem _menuItemEditValue;
        private System.Windows.Forms.ToolStripMenuItem _menuItemDelete;
        private System.Windows.Forms.ToolStripButton _buttonCut;
        private System.Windows.Forms.ToolStripButton _buttonCopy;
        private System.Windows.Forms.ToolStripButton _buttonPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _menuItemRecentFiles;
        private System.Windows.Forms.ToolStripMenuItem _menuItemRecentFolders;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton _buttonRefresh;
        private System.Windows.Forms.ToolStripMenuItem _menuItemRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem _menuItemMoveUp;
        private System.Windows.Forms.ToolStripMenuItem _menuItemMoveDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem findBlockToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem _menuItemOpenInExplorer;
        private System.Windows.Forms.ToolStripButton _buttonAddTagLongArray;
		private System.Windows.Forms.ToolStripMenuItem h帮助ToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 导出所有告示牌实体EToolStripMenuItem;
	}
}

