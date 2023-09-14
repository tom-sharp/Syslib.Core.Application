

namespace Syslib.Core.Application
{
	internal class Hex_Aplication
	{


		public void Run()
		{
			this.ConvertAnIntegerToAHexString();			// convert an integer value to a hex string representation
			this.ConvertAByteArrayBufferToAHexString();		// convert a byte array buffer to it's  hex string representation
			this.ConvertAHexStringToAByteArrayBuffer();		// convert an hex string into a byte array
			this.ManualConversionsToHex();

		}


		void ConvertAnIntegerToAHexString()
		{
			int number1 = 1000;
			int number2 = -1000;
			int number3 = 1;
			var hexstring1 = Hex.FromInt(number1);
			var hexstring2 = Hex.FromInt(number2);
			var hexstring3 = Hex.FromInt(number3);
			Console.WriteLine($"Hex value from Integer '{number1}' -> {hexstring1}, '{number2}' -> {hexstring2}, '{number3}' -> {hexstring3}");
		}





		void ConvertAByteArrayBufferToAHexString()
		{
			var str = new CStr("Hello World!");
			var hexstring = Hex.FromBuffer(str.Str());
			Console.WriteLine($"Hex string value from byte array buffer '{str}' -> {hexstring}");

		}


		void ConvertAHexStringToAByteArrayBuffer()
		{
			string hexstring1 = "48656c6c6f20576f726c6421";
			string hexstring2 = "x48656c6c6f20576f726c6421";
			string hexstring3 = "0x48656c6c6f20576f726c6421";
			var str1 = new CStr(Hex.ToBuffer(hexstring1));
			var str2 = new CStr(Hex.ToBuffer(hexstring2));
			var str3 = new CStr(Hex.ToBuffer(hexstring3));
			Console.WriteLine($"Hex string value to a byte array buffer '{hexstring1}' -> {str1}");
			Console.WriteLine($"Hex string value to a byte array buffer '{hexstring2}' -> {str2}");
			Console.WriteLine($"Hex string value to a byte array buffer '{hexstring3}' -> {str3}");

		}


		void ManualConversionsToHex()
		{
			// Manual conversion to hex character from value 0-15
			// any other value will return x

			Console.Write("HexLower conversion ");
			for (int i = 0; i < 18; i++) { Console.Write($"{i}={(char)Hex.Lower(i)} "); }
			Console.Write("\n");

			Console.Write("HexUpper conversion ");
			for (int i = 0; i < 18; i++) { Console.Write($"{i}={(char)Hex.Upper(i)} "); }
			Console.Write("\n");

		}



	}
}
