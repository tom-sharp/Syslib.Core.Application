
namespace Syslib.Core.Application
{
	internal class CHash_Application
	{
	
		CStr helloworldstring = new CStr("Hello World!");
		byte[] helloworldarray = Hex.ToBuffer("48656c6c6f20576f726c6421");		// Hex string repr of Hello World!

		// pre-calculated hash values
		CHash helloworldMD5hash = new CHash().FromString("ed076287532e86365e841e92bfc50d8c");
		CHash helloworldSHA1hash = new CHash().FromString("2ef7bde608ce5404e97d5f042f95f89f1c232871");
		CHash helloworldSHA256hash = new CHash().FromString("7f83b1657ff1fc53b92dc18148a1d65dfc2d4b1fa3d677284addd200126d9069");
		CHash helloworldSHA384hash = new CHash().FromString("bfd76c0ebbd006fee583410547c1887b0292be76d582d96c242d2a792723e3fd6fd061f9d5cfd13b8f961358e6adba4a");
		CHash helloworldSHA512hash = new CHash().FromString("861844d6704e8573fec34d967e20bcfef3d424cf48be04e6dc08f2bd58c729743371015ead891cc3cf1c9d34b49264b510751b1ff9e537937bc46b5d6ff4ecc8");

		public void Run()
		{
			Console.WriteLine("EXAMPLES: CHash ----------------------------------------");
			this.MD5Example();
			this.SHA1Example();
			this.SHA256Example();
			this.SHA384Example();
			this.SHA512Example();
		}


		void ValidateHashType(CHash hash)
		{
			switch (hash.GetHashType()) 
			{
				case CHash.HashType.MD5:
					Console.WriteLine($"Hash '{hash}' is of type MD5 and  IsEqual to  Hello World! ? {hash.IsEqual(helloworldMD5hash)}"); break;
				case CHash.HashType.Sha1: Console.WriteLine($"Hash '{hash}' is of type SHA1 and  IsEqual to  Hello World! ? {hash.IsEqual(helloworldSHA1hash)}"); break;
				case CHash.HashType.Sha256: Console.WriteLine($"Hash '{hash}' is of type SHA256 and  IsEqual to  Hello World! ? {hash.IsEqual(helloworldSHA256hash)}"); break;
				case CHash.HashType.Sha384: Console.WriteLine($"Hash '{hash}' is of type SHA384 and  IsEqual to  Hello World! ? {hash.IsEqual(helloworldSHA384hash)}"); break;
				case CHash.HashType.Sha512: Console.WriteLine($"Hash '{hash}' is of type SHA512 and  IsEqual to  Hello World! ? {hash.IsEqual(helloworldSHA512hash)}"); break;
				case CHash.HashType.Unknown: Console.WriteLine($"Hash '{hash}' is Unknown"); break;
			}
			
		}


		void MD5Example()
		{

			// calc hash from a byte array
			var hash = CHash.CalcMD5(helloworldarray);
			this.ValidateHashType(hash);

		}

		void SHA1Example()
		{

			// calc hash from a byte array
			var hash = CHash.CalcSHA1(helloworldarray);
			this.ValidateHashType(hash);

		}


		void SHA256Example()
		{
			// calc hash from a byte array
			var hash = CHash.CalcSHA256(helloworldarray);
			this.ValidateHashType(hash);

			// calc hash from a CStr
			var hash1 = CHash.CalcSHA256(helloworldstring);
			this.ValidateHashType(hash1);

			// calc hash from a CStr
			var hash2 = CHash.CalcSHA256(new CStr("Something else"));
			this.ValidateHashType(hash2);


		}

		void SHA384Example()
		{

			// calc hash from a byte array
			var hash = CHash.CalcSHA384(helloworldarray);
			this.ValidateHashType(hash);

		}


		void SHA512Example()
		{

			// calc hash from a byte array
			var hash = CHash.CalcSHA512(helloworldarray);
			this.ValidateHashType(hash);

		}


	}
}
