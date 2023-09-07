using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syslib.Core.Application
{
	internal class CRandom_Application
	{

		public void Run()
		{
			this.CustomSeedInit();      // Use of Custom Randomization init with a custom value (not needed)
			this.RanomNumber();			// generate random positive integer numbers

		}



		void CustomSeedInit()
		{
			CRandom.Seed("Custom Init String");
			Console.WriteLine("CRandom Custom Init");
		}

		void RanomNumber()
		{
			Console.WriteLine($"Random number () {CRandom.Random.RandomNumber()}");
			Console.WriteLine($"Random number (Max 10000)  {CRandom.Random.RandomNumber(max: 10000)}");
			Console.WriteLine($"Random number (100 - 999)  {CRandom.Random.RandomNumber(min: 100, max: 999)}");
		}



	}


}
