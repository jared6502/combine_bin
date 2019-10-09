using System;
using System.Collections.Generic;
using System.Text;

namespace combine_bin
{
	enum MergeType
	{
		None,
		Sequential,
		Interleaved
	}

	class Merger
	{
		public MergeType Merge
		{
			get
			{
				return merge;
			}
			set
			{
				modified = true;
				merge = value;
			}
		}

		public List<byte[]> Inputs
		{
			get
			{
				return inputs;
			}
			set
			{
				modified = true;
				inputs = value;
			}
		}

		public byte[] Output
		{
			get
			{
				if (modified)
				{
					MergeData();

					modified = false;
				}

				return output;
			}
		}

		protected MergeType merge;
		protected List<byte[]> inputs = null;
		protected byte[] output = null;
		protected bool modified = false;

		void MergeData()
		{
			int datasize = 0;
			int outsize = 0;

			//throw an exception here if there's a mismatch in data sizes and this is an interleaved merge
			if (merge == MergeType.Interleaved)
			{
				datasize = inputs[0].Length;

				foreach (byte[] arr in inputs)
				{
					if (arr.Length != datasize)
					{
						throw new InvalidOperationException("Input Data Size Mismatch");
					}
				}
			}

			//get total size of input data
			foreach (byte[] arr in inputs)
			{
				outsize += arr.Length;
			}

			output = new byte[outsize];

			//perform merge operation
			switch (merge)
			{
				case MergeType.Sequential:
					for (int i = 0; i < inputs.Count; i++)
					{
						for (int j = 0; j < inputs[i].Length; j++)
						{
							output[(i * inputs[i].Length) + j] = inputs[i][j];
						}
					}
					break;

				case MergeType.Interleaved:
					for (int i = 0; i < inputs[0].Length; i++)
					{
						for (int j = 0; j < inputs.Count; j++)
						{
							output[(i * inputs.Count) + j] = inputs[j][i];
						}
					}
					break;

				case MergeType.None:
				default:
					for (int i = 0; i < output.Length; i++)
					{
						output[i] = 0xFF;
					}
					break;
			}
		}
	}
}
