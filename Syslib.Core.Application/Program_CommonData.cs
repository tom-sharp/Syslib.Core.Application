
namespace Syslib.Core.Application
{



	class Person
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public int Age { get; set; }


	}


	class RandomNames
	{
		CList<string> namelist = new();

		string[] data =  { "Adam", "Eve", "Jane", "John" };

		public RandomNames() 
		{ 
			this.Init();
		}

		public string GetRandomName() 
		{
			return this.namelist.Random();
		}


		void Init() 
		{ 
			this.namelist.Add(data);
		}

	}




}
