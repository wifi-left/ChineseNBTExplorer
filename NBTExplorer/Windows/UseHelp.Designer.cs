
namespace NBTExplorer.Windows
{
	partial class UseHelp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UseHelp));
			this.helpTabs = new System.Windows.Forms.TabControl();
			this.page1 = new System.Windows.Forms.TabPage();
			this.tip = new System.Windows.Forms.TextBox();
			this.Tips1 = new System.Windows.Forms.Label();
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
			this.helpTabs.SuspendLayout();
			this.page1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// helpTabs
			// 
			this.helpTabs.Controls.Add(this.page1);
			this.helpTabs.Location = new System.Drawing.Point(4, 4);
			this.helpTabs.Name = "helpTabs";
			this.helpTabs.SelectedIndex = 0;
			this.helpTabs.Size = new System.Drawing.Size(603, 288);
			this.helpTabs.TabIndex = 0;
			// 
			// page1
			// 
			this.page1.Controls.Add(this.tip);
			this.page1.Controls.Add(this.Tips1);
			this.page1.Controls.Add(this.toolStrip1);
			this.page1.Location = new System.Drawing.Point(4, 22);
			this.page1.Name = "page1";
			this.page1.Padding = new System.Windows.Forms.Padding(3);
			this.page1.Size = new System.Drawing.Size(595, 262);
			this.page1.TabIndex = 0;
			this.page1.Text = "基础认识";
			this.page1.UseVisualStyleBackColor = true;
			// 
			// tip
			// 
			this.tip.AcceptsReturn = true;
			this.tip.AcceptsTab = true;
			this.tip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tip.BackColor = System.Drawing.Color.White;
			this.tip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tip.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.tip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tip.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.tip.Location = new System.Drawing.Point(3, 78);
			this.tip.Multiline = true;
			this.tip.Name = "tip";
			this.tip.ReadOnly = true;
			this.tip.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.tip.Size = new System.Drawing.Size(589, 181);
			this.tip.TabIndex = 3;
			// 
			// Tips1
			// 
			this.Tips1.AutoSize = true;
			this.Tips1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Tips1.Location = new System.Drawing.Point(6, 37);
			this.Tips1.Name = "Tips1";
			this.Tips1.Size = new System.Drawing.Size(222, 28);
			this.Tips1.TabIndex = 2;
			this.Tips1.Text = "单击组件即可获得帮助";
			this.Tips1.Click += new System.EventHandler(this.Tips1_Click);
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
			this.toolStrip1.Location = new System.Drawing.Point(3, 3);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(589, 25);
			this.toolStrip1.Stretch = true;
			this.toolStrip1.TabIndex = 1;
			// 
			// _buttonOpen
			// 
			this._buttonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonOpen.Image = ((System.Drawing.Image)(resources.GetObject("_buttonOpen.Image")));
			this._buttonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonOpen.Name = "_buttonOpen";
			this._buttonOpen.Size = new System.Drawing.Size(23, 22);
			this._buttonOpen.Text = "打开文件";
			this._buttonOpen.Click += new System.EventHandler(this._buttonOpen_Click);
			// 
			// _buttonOpenFolder
			// 
			this._buttonOpenFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonOpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("_buttonOpenFolder.Image")));
			this._buttonOpenFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonOpenFolder.Name = "_buttonOpenFolder";
			this._buttonOpenFolder.Size = new System.Drawing.Size(23, 22);
			this._buttonOpenFolder.Text = "打开目录";
			this._buttonOpenFolder.Click += new System.EventHandler(this._buttonOpenFolder_Click);
			// 
			// _buttonSave
			// 
			this._buttonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("_buttonSave.Image")));
			this._buttonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonSave.Name = "_buttonSave";
			this._buttonSave.Size = new System.Drawing.Size(23, 22);
			this._buttonSave.Text = "保存";
			this._buttonSave.Click += new System.EventHandler(this._buttonSave_Click);
			// 
			// _buttonRefresh
			// 
			this._buttonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("_buttonRefresh.Image")));
			this._buttonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonRefresh.Name = "_buttonRefresh";
			this._buttonRefresh.Size = new System.Drawing.Size(23, 22);
			this._buttonRefresh.Text = "刷新(警告：请确认操作后继续)";
			this._buttonRefresh.Click += new System.EventHandler(this._buttonRefresh_Click_1);
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
			this._buttonCut.Click += new System.EventHandler(this._buttonCut_Click);
			// 
			// _buttonCopy
			// 
			this._buttonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonCopy.Image = ((System.Drawing.Image)(resources.GetObject("_buttonCopy.Image")));
			this._buttonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonCopy.Name = "_buttonCopy";
			this._buttonCopy.Size = new System.Drawing.Size(23, 22);
			this._buttonCopy.Text = "复制";
			this._buttonCopy.Click += new System.EventHandler(this._buttonCopy_Click);
			// 
			// _buttonPaste
			// 
			this._buttonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonPaste.Image = ((System.Drawing.Image)(resources.GetObject("_buttonPaste.Image")));
			this._buttonPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonPaste.Name = "_buttonPaste";
			this._buttonPaste.Size = new System.Drawing.Size(23, 22);
			this._buttonPaste.Text = "粘贴";
			this._buttonPaste.Click += new System.EventHandler(this._buttonPaste_Click);
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
			this._buttonRename.Click += new System.EventHandler(this._buttonRename_Click);
			// 
			// _buttonEdit
			// 
			this._buttonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("_buttonEdit.Image")));
			this._buttonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonEdit.Name = "_buttonEdit";
			this._buttonEdit.Size = new System.Drawing.Size(23, 22);
			this._buttonEdit.Text = "修改";
			this._buttonEdit.Click += new System.EventHandler(this._buttonEdit_Click);
			// 
			// _buttonDelete
			// 
			this._buttonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("_buttonDelete.Image")));
			this._buttonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonDelete.Name = "_buttonDelete";
			this._buttonDelete.Size = new System.Drawing.Size(23, 22);
			this._buttonDelete.Text = "删除";
			this._buttonDelete.Click += new System.EventHandler(this._buttonDelete_Click);
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
			this._buttonAddTagByte.Click += new System.EventHandler(this._buttonAddTagByte_Click);
			// 
			// _buttonAddTagShort
			// 
			this._buttonAddTagShort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonAddTagShort.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagShort.Image")));
			this._buttonAddTagShort.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonAddTagShort.Name = "_buttonAddTagShort";
			this._buttonAddTagShort.Size = new System.Drawing.Size(23, 22);
			this._buttonAddTagShort.Text = "新增短数字标签";
			this._buttonAddTagShort.Click += new System.EventHandler(this._buttonAddTagShort_Click);
			// 
			// _buttonAddTagInt
			// 
			this._buttonAddTagInt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonAddTagInt.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagInt.Image")));
			this._buttonAddTagInt.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonAddTagInt.Name = "_buttonAddTagInt";
			this._buttonAddTagInt.Size = new System.Drawing.Size(23, 22);
			this._buttonAddTagInt.Text = "新增整数标签";
			this._buttonAddTagInt.Click += new System.EventHandler(this._buttonAddTagInt_Click);
			// 
			// _buttonAddTagLong
			// 
			this._buttonAddTagLong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonAddTagLong.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagLong.Image")));
			this._buttonAddTagLong.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonAddTagLong.Name = "_buttonAddTagLong";
			this._buttonAddTagLong.Size = new System.Drawing.Size(23, 22);
			this._buttonAddTagLong.Text = "新增长数字标签";
			this._buttonAddTagLong.Click += new System.EventHandler(this._buttonAddTagLong_Click);
			// 
			// _buttonAddTagFloat
			// 
			this._buttonAddTagFloat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonAddTagFloat.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagFloat.Image")));
			this._buttonAddTagFloat.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonAddTagFloat.Name = "_buttonAddTagFloat";
			this._buttonAddTagFloat.Size = new System.Drawing.Size(23, 22);
			this._buttonAddTagFloat.Text = "新增单精度小数标签";
			this._buttonAddTagFloat.Click += new System.EventHandler(this._buttonAddTagFloat_Click);
			// 
			// _buttonAddTagDouble
			// 
			this._buttonAddTagDouble.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonAddTagDouble.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagDouble.Image")));
			this._buttonAddTagDouble.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonAddTagDouble.Name = "_buttonAddTagDouble";
			this._buttonAddTagDouble.Size = new System.Drawing.Size(23, 22);
			this._buttonAddTagDouble.Text = "新增双精度小数标签";
			this._buttonAddTagDouble.Click += new System.EventHandler(this._buttonAddTagDouble_Click);
			// 
			// _buttonAddTagByteArray
			// 
			this._buttonAddTagByteArray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonAddTagByteArray.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagByteArray.Image")));
			this._buttonAddTagByteArray.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonAddTagByteArray.Name = "_buttonAddTagByteArray";
			this._buttonAddTagByteArray.Size = new System.Drawing.Size(23, 22);
			this._buttonAddTagByteArray.Text = "新增字节数组标签";
			this._buttonAddTagByteArray.Click += new System.EventHandler(this._buttonAddTagByteArray_Click);
			// 
			// _buttonAddTagIntArray
			// 
			this._buttonAddTagIntArray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonAddTagIntArray.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagIntArray.Image")));
			this._buttonAddTagIntArray.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._buttonAddTagIntArray.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonAddTagIntArray.Name = "_buttonAddTagIntArray";
			this._buttonAddTagIntArray.Size = new System.Drawing.Size(23, 22);
			this._buttonAddTagIntArray.Text = "新增整数数组标签";
			this._buttonAddTagIntArray.Click += new System.EventHandler(this._buttonAddTagIntArray_Click);
			// 
			// _buttonAddTagLongArray
			// 
			this._buttonAddTagLongArray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonAddTagLongArray.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagLongArray.Image")));
			this._buttonAddTagLongArray.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._buttonAddTagLongArray.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonAddTagLongArray.Name = "_buttonAddTagLongArray";
			this._buttonAddTagLongArray.Size = new System.Drawing.Size(23, 22);
			this._buttonAddTagLongArray.Text = "新增长整数数组标签";
			this._buttonAddTagLongArray.Click += new System.EventHandler(this._buttonAddTagLongArray_Click);
			// 
			// _buttonAddTagString
			// 
			this._buttonAddTagString.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonAddTagString.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagString.Image")));
			this._buttonAddTagString.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonAddTagString.Name = "_buttonAddTagString";
			this._buttonAddTagString.Size = new System.Drawing.Size(23, 22);
			this._buttonAddTagString.Text = "新增文本标签";
			this._buttonAddTagString.Click += new System.EventHandler(this._buttonAddTagString_Click);
			// 
			// _buttonAddTagList
			// 
			this._buttonAddTagList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonAddTagList.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagList.Image")));
			this._buttonAddTagList.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonAddTagList.Name = "_buttonAddTagList";
			this._buttonAddTagList.Size = new System.Drawing.Size(23, 22);
			this._buttonAddTagList.Text = "新增列表标签";
			this._buttonAddTagList.Click += new System.EventHandler(this._buttonAddTagList_Click);
			// 
			// _buttonAddTagCompound
			// 
			this._buttonAddTagCompound.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._buttonAddTagCompound.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagCompound.Image")));
			this._buttonAddTagCompound.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._buttonAddTagCompound.Name = "_buttonAddTagCompound";
			this._buttonAddTagCompound.Size = new System.Drawing.Size(23, 22);
			this._buttonAddTagCompound.Text = "新增项";
			this._buttonAddTagCompound.Click += new System.EventHandler(this._buttonAddTagCompound_Click);
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
			this._buttonFindNext.Click += new System.EventHandler(this._buttonFindNext_Click);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = global::NBTExplorer.Properties.Resources.Icos_20198411425524;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "帮助";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
			// 
			// UseHelp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(605, 289);
			this.Controls.Add(this.helpTabs);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "UseHelp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "使用帮助";
			this.helpTabs.ResumeLayout(false);
			this.page1.ResumeLayout(false);
			this.page1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl helpTabs;
		private System.Windows.Forms.TabPage page1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton _buttonOpen;
		private System.Windows.Forms.ToolStripButton _buttonOpenFolder;
		private System.Windows.Forms.ToolStripButton _buttonSave;
		private System.Windows.Forms.ToolStripButton _buttonRefresh;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton _buttonCut;
		private System.Windows.Forms.ToolStripButton _buttonCopy;
		private System.Windows.Forms.ToolStripButton _buttonPaste;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
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
		private System.Windows.Forms.ToolStripButton _buttonAddTagIntArray;
		private System.Windows.Forms.ToolStripButton _buttonAddTagLongArray;
		private System.Windows.Forms.ToolStripButton _buttonAddTagString;
		private System.Windows.Forms.ToolStripButton _buttonAddTagList;
		private System.Windows.Forms.ToolStripButton _buttonAddTagCompound;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton _buttonFindNext;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.Label Tips1;
		private System.Windows.Forms.TextBox tip;
	}
}