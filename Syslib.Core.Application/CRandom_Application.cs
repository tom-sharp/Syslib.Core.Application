
namespace Syslib.Core.Application
{
	internal class CRandom_Application
	{

		public void Run()
		{
			this.CustomSeedInit();			// Use of Custom Randomization init with a custom value (not needed)
			this.RandomNumber();			// generate random positive integer numbers 0 - 99 999 999
			this.RandomByte();				// generate a random byte value between 0 - 99
			this.RandomBool();				// generate random bool
			this.RandomString();			// generate random strings
			this.RandomPassword();			// generate random password strings
			this.RandomHash();				// generate a random sha256 hash
			this.ShuffleArray();			// shuffle an array of data
			this.SelectRandomFromList();	// random select of an item in a list

		}



		void CustomSeedInit()
		{
			CRandom.Seed("Custom Init String");
			Console.WriteLine("CRandom Custom Init");
		}

		void RandomNumber()
		{
			Console.WriteLine($"Random number (0 - 99999999) {CRandom.Random.RandomNumber()}");
			Console.WriteLine($"Random number (0 - 10000)  {CRandom.Random.RandomNumber(max: 10000)}");
			Console.WriteLine($"Random number (100 - 999)  {CRandom.Random.RandomNumber(min: 100, max: 999)}");
		}

		void RandomByte()
		{
			Console.WriteLine($"Random byte (0 - 99)  {CRandom.Random.RandomByte()}");
		}

		void RandomBool()
		{
			Console.WriteLine($"Random bool (50/50 chance)  {CRandom.Random.RandomBool()}");
			Console.WriteLine($"Random bool (20/80 chance)  {CRandom.Random.RandomBool(percentchance: 20)}");
			Console.WriteLine($"Random bool (98/2 chance)   {CRandom.Random.RandomBool(percentchance: 98)}");
		}

		void RandomString()
		{
			Console.WriteLine($"Random string (20 char)   {CRandom.Random.RandomString(length: 20)}");
			Console.WriteLine($"Random string (20 char)   {CRandom.Random.RandomString(length: 20, enableupper: true)}");
			Console.WriteLine($"Random string (20 char)   {CRandom.Random.RandomString(length: 20, enableupper: true, enablenumber: true)}");
			Console.WriteLine($"Random string (20 char)   {CRandom.Random.RandomString(length: 20, enableupper: true, enablenumber: true, enablespecial: true)}");
		}

		void RandomPassword()
		{ 
			Console.WriteLine($"Random password (default)   {CRandom.Random.RandomPassword()}");
			Console.WriteLine($"Random password (custom)    {CRandom.Random.RandomPassword(passwordlength: 20)}");
			Console.WriteLine($"Random password (custom)    {CRandom.Random.RandomPassword(passwordlength: 20, enablespecialcharacters: false)}");
		}


		void RandomHash()
		{
			Console.WriteLine($"Random SHA256 hash   {CRandom.Random.RandomSHA256()}");
		}


		void ShuffleArray()
		{
			int arraysize = 10;
			int[] intarray = new int[arraysize];
			string[] arrayofstrings = { "Hello", "World", "One", "Two", "Three", "Four" };


			// shuffle array of integers

			for (int i = 0; i < arraysize; i++) intarray[i] = i;

			Console.Write("Random Shuffle: Array of integers: ");
			for (int i = 0; i < arraysize; i++) Console.Write($"{intarray[i]} ") ;

			CRandom.Random.Shuffle(intarray);

			Console.Write("   Shuffled: ");
			for (int i = 0; i < arraysize; i++) Console.Write($"{intarray[i]} ");
			Console.Write("\n");



			// Shuffle array of strings

			Console.Write("Random Shuffle: Array of strings: ");
			for (int i = 0; i < arrayofstrings.Length; i++) Console.Write($"{arrayofstrings[i]} ");

			CRandom.Random.Shuffle(arrayofstrings);

			Console.Write("   Shuffled: ");
			for (int i = 0; i < arrayofstrings.Length; i++) Console.Write($"{arrayofstrings[i]} ");
			Console.Write("\n");


		}

		void SelectRandomFromList()
		{
			var list = new CList<string>();
			string[] arrayofstrings = { "Hello", "World", "One", "Two", "Three", "Four"};

			list.Add(arrayofstrings);

			Console.Write("Random Select from List of strings: ");
			foreach (var str in list) { Console.Write($"{str} "); }

			Console.WriteLine($" Random selected: {CRandom.Random.SelectRandom(list, itemsInList: list.Count())}");

		}




	}


}
