using System;

namespace NBTExplorer.Windows
{
    partial class EditString
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
			this._stringField = new System.Windows.Forms.TextBox();
			this._buttonCancel = new System.Windows.Forms.Button();
			this._buttonOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _stringField
			// 
			this._stringField.Location = new System.Drawing.Point(12, 11);
			this._stringField.Multiline = true;
			this._stringField.Name = "_stringField";
			this._stringField.Size = new System.Drawing.Size(331, 107);
			this._stringField.TabIndex = 4;
			// 
			// _buttonCancel
			// 
			this._buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._buttonCancel.Location = new System.Drawing.Point(187, 124);
			this._buttonCancel.Name = "_buttonCancel";
			this._buttonCancel.Size = new System.Drawing.Size(75, 21);
			this._buttonCancel.TabIndex = 9;
			this._buttonCancel.Text = "取消";
			this._buttonCancel.UseVisualStyleBackColor = true;
			this._buttonCancel.Click += new System.EventHandler(this._buttonCancel_Click);
			// 
			// _buttonOK
			// 
			this._buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonOK.Location = new System.Drawing.Point(268, 124);
			this._buttonOK.Name = "_buttonOK";
			this._buttonOK.Size = new System.Drawing.Size(75, 21);
			this._buttonOK.TabIndex = 8;
			this._buttonOK.Text = "确定";
			this._buttonOK.UseVisualStyleBackColor = true;
			this._buttonOK.Click += new System.EventHandler(this._buttonOK_Click);
			// 
			// EditString
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._buttonCancel;
			this.ClientSize = new System.Drawing.Size(355, 156);
			this.Controls.Add(this._buttonCancel);
			this.Controls.Add(this._buttonOK);
			this.Controls.Add(this._stringField);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditString";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Edit String 修改字符串...";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		private void _buttonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		private System.Windows.Forms.TextBox _stringField;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.Button _buttonOK;
    }
}