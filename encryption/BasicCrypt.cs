namespace encryption
{
    class BasicCrypt : ICrypto
    {
        public byte[] EnCrypt(byte[] data)
        {
            byte[] enc = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                enc[i] = (byte)(i % 2 == 0 ? data[i] - 1 : data[i] + 1);
            }
            return enc;
        }

        public byte[] DeCrypt(byte[] data)
        {
            byte[] dec = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                dec[i] = (byte)(i % 2 == 0 ? data[i] + 1 : data[i] - 1);
            }
            return dec;
        }
    }
}
