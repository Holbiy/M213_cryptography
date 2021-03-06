using System;
using System.Text;

namespace encryption
{
	class Program
	{
		static void Main(string[] args)
		{
			ICrypto crypto = new BasicCrypt();

			string data = "Hello World!";
			string enc = GetString(crypto.EnCrypt(GetBytes(data)));
			string dec = GetString(crypto.DeCrypt(GetBytes(enc)));

			Console.WriteLine("Original:\t" + data);
			Console.WriteLine("Verschlüsselt:\t" + enc);
			Console.WriteLine("Entschlüsselt:\t" + dec);

			Console.ReadLine();
		}

		static byte[] GetBytes(string value)
		{
			return Encoding.ASCII.GetBytes(value);
		}

		static string GetString(byte[] value)
		{
			return Encoding.ASCII.GetString(value);
		}
	}
}
