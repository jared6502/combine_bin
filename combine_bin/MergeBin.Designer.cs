namespace combine_bin
{
	partial class MergeBin
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
			this.FileList = new System.Windows.Forms.ListBox();
			this.AddFile = new System.Windows.Forms.Button();
			this.MergeFiles = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Interleaved = new System.Windows.Forms.RadioButton();
			this.Sequential = new System.Windows.Forms.RadioButton();
			this.RemoveFile = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.ReverseBits = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// FileList
			// 
			this.FileList.FormattingEnabled = true;
			this.FileList.ItemHeight = 20;
			this.FileList.Location = new System.Drawing.Point(12, 12);
			this.FileList.Name = "FileList";
			this.FileList.Size = new System.Drawing.Size(441, 324);
			this.FileList.TabIndex = 0;
			// 
			// AddFile
			// 
			this.AddFile.Location = new System.Drawing.Point(12, 351);
			this.AddFile.Name = "AddFile";
			this.AddFile.Size = new System.Drawing.Size(134, 60);
			this.AddFile.TabIndex = 1;
			this.AddFile.Text = "Add File";
			this.AddFile.UseVisualStyleBackColor = true;
			this.AddFile.Click += new System.EventHandler(this.AddFile_Click);
			// 
			// MergeFiles
			// 
			this.MergeFiles.Location = new System.Drawing.Point(12, 575);
			this.MergeFiles.Name = "MergeFiles";
			this.MergeFiles.Size = new System.Drawing.Size(104, 60);
			this.MergeFiles.TabIndex = 3;
			this.MergeFiles.Text = "Merge";
			this.MergeFiles.UseVisualStyleBackColor = true;
			this.MergeFiles.Click += new System.EventHandler(this.MergeFiles_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Interleaved);
			this.groupBox1.Controls.Add(this.Sequential);
			this.groupBox1.Location = new System.Drawing.Point(12, 417);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(441, 68);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Merge Type";
			// 
			// Interleaved
			// 
			this.Interleaved.AutoSize = true;
			this.Interleaved.Location = new System.Drawing.Point(183, 25);
			this.Interleaved.Name = "Interleaved";
			this.Interleaved.Size = new System.Drawing.Size(112, 24);
			this.Interleaved.TabIndex = 1;
			this.Interleaved.TabStop = true;
			this.Interleaved.Text = "Interleaved";
			this.Interleaved.UseVisualStyleBackColor = true;
			// 
			// Sequential
			// 
			this.Sequential.AutoSize = true;
			this.Sequential.Location = new System.Drawing.Point(6, 25);
			this.Sequential.Name = "Sequential";
			this.Sequential.Size = new System.Drawing.Size(109, 24);
			this.Sequential.TabIndex = 0;
			this.Sequential.TabStop = true;
			this.Sequential.Text = "Sequential";
			this.Sequential.UseVisualStyleBackColor = true;
			// 
			// RemoveFile
			// 
			this.RemoveFile.Location = new System.Drawing.Point(325, 351);
			this.RemoveFile.Name = "RemoveFile";
			this.RemoveFile.Size = new System.Drawing.Size(128, 60);
			this.RemoveFile.TabIndex = 5;
			this.RemoveFile.Text = "Remove File";
			this.RemoveFile.UseVisualStyleBackColor = true;
			this.RemoveFile.Click += new System.EventHandler(this.RemoveFile_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.ReverseBits);
			this.groupBox2.Location = new System.Drawing.Point(12, 491);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(441, 68);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Options";
			// 
			// ReverseBits
			// 
			this.ReverseBits.AutoSize = true;
			this.ReverseBits.Location = new System.Drawing.Point(6, 25);
			this.ReverseBits.Name = "ReverseBits";
			this.ReverseBits.Size = new System.Drawing.Size(160, 24);
			this.ReverseBits.TabIndex = 0;
			this.ReverseBits.Text = "Reverse Bit Order";
			this.ReverseBits.UseVisualStyleBackColor = true;
			// 
			// MergeBin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(466, 648);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.RemoveFile);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.MergeFiles);
			this.Controls.Add(this.AddFile);
			this.Controls.Add(this.FileList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MergeBin";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox FileList;
		private System.Windows.Forms.Button AddFile;
		private System.Windows.Forms.Button MergeFiles;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton Interleaved;
		private System.Windows.Forms.RadioButton Sequential;
		private System.Windows.Forms.Button RemoveFile;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox ReverseBits;
	}
}

