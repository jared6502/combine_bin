using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace combine_bin
{
	public partial class MergeBin : Form
	{
		public MergeBin()
		{
			InitializeComponent();
		}

		private void RemoveFile_Click(object sender, EventArgs e)
		{
			FileList.Items.Remove(FileList.SelectedItem);
		}

		private void AddFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();

			ofd.CheckFileExists = true;
			ofd.Multiselect = false;

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				FileList.Items.Add(ofd.FileName);
			}
		}

		private void MergeFiles_Click(object sender, EventArgs e)
		{
			Merger merger = new Merger();

			List<byte[]> InFileData = new List<byte[]>();

			SaveFileDialog sfd = new SaveFileDialog();

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				try
				{
					if (File.Exists(sfd.FileName))
					{
						File.Delete(sfd.FileName);
					}
				}
				catch (Exception ex)
				{
					AbortError("Save File Open Error - " + ex.Message);
				}

				try
				{
					foreach (string s in FileList.Items)
					{
						using (FileStream fs = new FileStream(s, FileMode.Open, FileAccess.Read))
						{
							byte[] data = new byte[fs.Length];
							fs.Read(data, 0, (int)fs.Length);
							InFileData.Add(data);
						}
					}
				}
				catch (Exception ex)
				{
					AbortError("File Read Error - " + ex.Message);
					return;
				}

				merger.Merge = Interleaved.Checked ? MergeType.Interleaved : MergeType.Sequential;
				merger.Inputs = InFileData;

				try
				{
					using (FileStream of = new FileStream(sfd.FileName, FileMode.CreateNew, FileAccess.Write))
					{
						byte[] data = merger.Output;
						of.Write(data, 0, data.Length);
					}
				}
				catch (Exception ex)
				{
					AbortError("Merge/Save Error - " + ex.Message);
					return;
				}
			}
		}

		private void AbortError(string message)
		{
			MessageBox.Show("Error:\n\n" + message + "\n\nOperation Aborted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
