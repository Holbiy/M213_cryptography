namespace encryption
{
	class BasicCrypt : ICrypto
	{
		public byte[] DeCrypt(byte[] data)
		{
			for (int i = 0; i < data.Length; i++)
			{
				if (i % 2 == 0)
				{
					data[i]++;
				}
				else
				{
					data[i]--;
				}
			}

			return data;
		}

		public byte[] EnCrypt(byte[] data)
		{
			for (int i = 0; i < data.Length; i++)
			{
				if (i % 2 == 0)
				{
					data[i]--;
				}
				else
				{
					data[i]++;
				}
			}

			return data;
		}
	}
}
