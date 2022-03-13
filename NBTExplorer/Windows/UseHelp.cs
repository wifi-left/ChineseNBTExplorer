using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NBTExplorer.Windows
{
	public partial class UseHelp : Form
	{
		public UseHelp()
		{
			InitializeComponent();
		}

		private void _buttonRefresh_Click(object sender, EventArgs e)
		{

		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{

		}

		private void _buttonOpen_Click(object sender, EventArgs e)
		{
			tip.Text = "打开一个NBT文件。\n此文件可以为 .nbt .mca 或 支持的类型。";
		}

		private void Tips1_Click(object sender, EventArgs e)
		{
			tip.Text = "你点我干啥！";
		}

		private void _buttonOpenFolder_Click(object sender, EventArgs e)
		{
			tip.Text = "打开一个文件夹。\n可以为任意文件夹。";
		}

		private void _buttonSave_Click(object sender, EventArgs e)
		{
			tip.Text = "保存当前项目。";
		}

		private void _buttonRefresh_Click_1(object sender, EventArgs e)
		{
			tip.Text = "重新从磁盘中读入文件。若需要在 Minecraft 游戏中重新读取，请使用 /reload";
		}

		private void _buttonCut_Click(object sender, EventArgs e)
		{
			tip.Text = "剪切。\n复制当前项到剪切板且删除当项。";
		}

		private void _buttonCopy_Click(object sender, EventArgs e)
		{
			tip.Text = "复制项目。";
		}

		private void _buttonPaste_Click(object sender, EventArgs e)
		{
			tip.Text = "粘贴项目。";
		}

		private void _buttonRename_Click(object sender, EventArgs e)
		{
			tip.Text = "重命名项目。";
		}

		private void _buttonEdit_Click(object sender, EventArgs e)
		{
			tip.Text = "修改项目。具体取决于当前您更改项目的类型。";
		}

		private void _buttonDelete_Click(object sender, EventArgs e)
		{
			tip.Text = "删除项目！";
		}

		private void _buttonAddTagByte_Click(object sender, EventArgs e)
		{
			tip.Text = "新增字节项目。Value : 0 / 1";
		}

		private void _buttonAddTagShort_Click(object sender, EventArgs e)
		{
			tip.Text = "新增短数字项目。Value : -32768 ~ 32767";
		}

		private void _buttonAddTagInt_Click(object sender, EventArgs e)
		{
			tip.Text = "新增数字项目。Value : -2147483648 ~ 2147483647";
		}

		private void _buttonAddTagLong_Click(object sender, EventArgs e)
		{
			tip.Text = "新增长数字项目。Value : -9223372036854775808 ~ 9223372036854775807";
		}

		private void _buttonAddTagFloat_Click(object sender, EventArgs e)
		{
			tip.Text = "新增单精度小数项目。（小数点后位数较少）";
		}

		private void _buttonAddTagDouble_Click(object sender, EventArgs e)
		{
			tip.Text = "新增双精度小数项目。（小数点后位数较多）";
		}

		private void _buttonAddTagByteArray_Click(object sender, EventArgs e)
		{
			tip.Text = "新增字节型数组队列。";
		}

		private void _buttonAddTagIntArray_Click(object sender, EventArgs e)
		{
			tip.Text = "新增整数数组队列。";
		}

		private void _buttonAddTagLongArray_Click(object sender, EventArgs e)
		{
			tip.Text = "新增长整数数组队列。";
		}

		private void _buttonAddTagString_Click(object sender, EventArgs e)
		{
			tip.Text = "新增一串文本。";
		}

		private void _buttonAddTagList_Click(object sender, EventArgs e)
		{
			tip.Text = "新增一个列表。";
		}

		private void _buttonAddTagCompound_Click(object sender, EventArgs e)
		{
			tip.Text = "新增一个包(类似于文件夹)。";
		}

		private void _buttonFindNext_Click(object sender, EventArgs e)
		{
			tip.Text = "查找。可能寻找时间较长。";
		}

		private void toolStripButton1_Click_1(object sender, EventArgs e)
		{
			tip.Text = "帮助。就是这个界面。";
		}

		private void page1_Click(object sender, EventArgs e)
		{

		}
	}
}
