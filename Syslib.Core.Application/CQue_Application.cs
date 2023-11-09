
namespace Syslib.Core.Application
{
	internal class CQue_Application
	{
		public void Run() 
		{ 
			Console.WriteLine("EXAMPLES: CQue ----------------------------------------");

			this.QueClearExample();             // Clear, Items and isEmpty
			this.QueItemsExample();				// Que function Last In First Out
			this.PushItemsExample();            // Push function First In First Out
			this.MixedItemsExample();			// Mix Que and push function

		}



		void QueClearExample() 
		{
			var que = new CQue<Person>();

			Console.WriteLine($"Que contain {que.Count()} items and is empty ? {que.IsEmpty} ");

			que.Que(new Person() { Id = 1, Name = "Jane", Age = 30});

			Console.WriteLine($"Que contain {que.Count()} items and is empty ? {que.IsEmpty} ");

			que.Clear();

			Console.WriteLine($"Que contain {que.Count()} items and is empty ? {que.IsEmpty} ");

		}


		void QueItemsExample()
		{
			var que = new CQue<Person>();
			var names = new RandomNames();

			Console.Write($"Que persons: ");
			for (int i = 0; i < 8; i++)
			{
				var person = new Person() { Id = i, Age = CRandom.Random.RandomNumber(10, 50), Name = names.GetRandomName() };
				que.Que(person);
				Console.Write($"{person.Name} ({person.Age}), ");
			}

			Console.Write($"\nQue {que.Count()} Order: ");

			while (!que.IsEmpty())
			{
				var person = que.Next();
				Console.Write($"{person.Name} ({person.Age}), ");
			}
			Console.Write("\n");

		}


		void PushItemsExample()
		{
			var que = new CQue<Person>();
			var names = new RandomNames();

			Console.Write($"Push persons: ");
			for (int i = 0; i < 8; i++)
			{
				var person = new Person() { Id = i, Age = CRandom.Random.RandomNumber(10, 50), Name = names.GetRandomName() };
				que.Push(person);
				Console.Write($"{person.Name} ({person.Age}), ");
			}

			Console.Write($"\nPush {que.Count()} Order: ");

			while (!que.IsEmpty())
			{
				var person = que.Next();
				Console.Write($"{person.Name} ({person.Age}), ");
			}
			Console.Write("\n");

		}


		void MixedItemsExample()
		{
			var que = new CQue<Person>();
			var names = new RandomNames();

			Console.Write($"Mixed persons: ");
			for (int i = 0; i < 4; i++)
			{
				var person = new Person() { Id = i, Age = CRandom.Random.RandomNumber(10, 50), Name = names.GetRandomName() };
				que.Que(person);
				Console.Write($"{person.Name} ({person.Age}), ");
			}
			for (int i = 0; i < 4; i++)
			{
				var person = new Person() { Id = i, Age = CRandom.Random.RandomNumber(10, 50), Name = names.GetRandomName() };
				que.Push(person);
				Console.Write($"{person.Name} ({person.Age}), ");
			}

			Console.Write($"\nMixed {que.Count()} Order: ");

			while (!que.IsEmpty())
			{
				var person = que.Next();
				Console.Write($"{person.Name} ({person.Age}), ");
			}
			Console.Write("\n");

		}






	}
}
