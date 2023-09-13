
namespace Syslib.Core.Application
{
	internal class Hex_Aplication
	{


		public void Run()
		{
			this.HexFromInt();
			this.HexFromBuffer();

		}


		void HexFromInt()
		{
			int number = 10000;
			var hex = Hex.FromInt(number);
			Console.WriteLine($"Hex value from Integer {hex}");
		}


		void HexFromBuffer()
		{
			var buffer = new CStr("Hello World!").Str();

			var hex = Hex.FromBuffer(buffer);

			Console.WriteLine($"Hex value from Buffer {hex}");

		}




	}
}
