namespace encryption
{
	public interface ICrypto
	{
		byte[] EnCrypt(byte[] data);

		byte[] DeCrypt(byte[] data);
	}
}
