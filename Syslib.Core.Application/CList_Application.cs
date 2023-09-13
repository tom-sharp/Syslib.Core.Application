
namespace Syslib.Core.Application
{


	class Person 
	{
        public int Id { get; set; }
		public string? Name { get; set; }

    }


	internal class CList_Application
	{
		CList<Person> people = new();
		int id = 0;

		public void Run()
		{
			this.IsEmpyList();					// check if list is empty
			this.AddItemsToList();				// add items to list
			this.IsEmpyList();					// check if list is empty
			this.ForEachItemInList();           // do something with all items in list
			this.ForEachWhileItemInList();		// loop through list items unitil some evaluation is false
			this.IterateThroughlistItems();     // do something with list items
			this.SortListByName();              // Sort List by name
			this.SortListById();				// Sort list by id
			this.ChooseARandomPersonInList();   // select a random item from list
			this.FindItems();					// find items in list from properties
			this.FindObjects();					// find objects in list from referens
			this.InsertAnItem();                // insert an item in list
			this.ClearList();                   // empty list
			this.IsEmpyList();                  // check if list is empty

		}


		void IsEmpyList()
		{
			Console.WriteLine($"People list contain {people.Count()} persons and is it empty ? {people.IsEmpty()}");
		}

		void AddItemsToList()
		{


			Console.WriteLine("Adding 7 people to list");


			// add a single object

			id++;
			var person = new Person() { Id = id, Name = "Jane" };
			people.Add(person);



			// add an array of objects

			int arraysize = 3;
			Person[] arrayofpersons = new Person[arraysize];

			for (int i = 0; i < arrayofpersons.Length; i++) 
			{ 
				id++; 
				arrayofpersons[i] = new Person() { Id = id, Name = $"Adam{i}" };
			}

			people.Add(arrayofpersons);



			// add another list of persons to the list

			var newpersons = new CList<Person>();
			for (int i = 0; i < 3; i++) 
			{ 
				id++;
				newpersons.Add(new Person() { Id = id, Name = $"Eve{i}" }); 
			}

			people.Add(newpersons);



			// adding null items are ignored

			Person? nullperson = null;
			people.Add(nullperson);



		}


		void ForEachItemInList() 
		{
			Console.Write("List contain: ");
			this.people.ForEach(p=> Console.Write($"{p.Id} {p.Name}  "));
			Console.WriteLine();
		}

		void ForEachWhileItemInList()
		{

			// ForEachWhile will iterate through list multiple times
			// Make sure this loop will eventually result in a false return
			// or it will be an infinite loop

			this.people.ForEachWhile(p => {
				if (p == null) 
				{
					// end of list is reached, without evaluation below has generated a false return
					// decide what to do. return true will re-iterate the list items
					return true;
				}
				if (p.Name == "John") return false;
				if (p.Name == "Eve1") p.Name = "John";
				return true; 
			});
			Console.WriteLine();
		}



		void IterateThroughlistItems()
		{
			Console.Write("List contain: ");
			var person = this.people.First();
			while (person != null)
			{
				Console.Write($"{person.Id} {person.Name}  ");
				person = people.Next();
			}
			Console.WriteLine();
		}


		void SortListByName()
		{
			this.people.Sort((a,b) => string.Compare(a.Name,b.Name) == 1);

			Console.Write("Sort List (Name): ");
			this.people.ForEach(p => Console.Write($"{p.Id} {p.Name}  "));
			Console.WriteLine();
		}

		void SortListById()
		{
			this.people.Sort((a, b) => a.Id > b.Id);

			Console.Write("Sort List   (Id): ");
			this.people.ForEach(p => Console.Write($"{p.Id} {p.Name}  "));
			Console.WriteLine();
		}


		void ChooseARandomPersonInList()
		{
			var person = this.people.Random();
			Console.WriteLine($"A random person in list: {person.Name}");
		}


		void FindItems()
		{

			Console.Write("Find persons Ev*: ");

			// Find First 
			var person = people.First(p => {
				if (p.Name != null) return p.Name.StartsWith("Ev");
				return false;
			});

			while (person != null)
			{
				Console.Write($"{person.Id} {person.Name}  ");
				person = people.Next(p => {
					if (p.Name != null) return p.Name.StartsWith("Ev");
					return false;
				});
			}
			Console.Write("\n");

		}

		void FindObjects()
		{
			var nonexistingobject = new Person() { Id = 6, Name = "John" };
			var existingobject = people.First(p => p.Name == "John");

			Console.WriteLine($"Find object, Do {nonexistingobject.Id} {nonexistingobject.Name} Exist ?  {people.Find(nonexistingobject) != null}");
			Console.WriteLine($"Find object, Do {existingobject.Id} {existingobject.Name} Exist ?  {people.Find(existingobject) != null}");

		}

		void InsertAnItem()
		{
			Console.Write("List before insert: ");
			this.people.ForEach(p => Console.Write($"{p.Id} {p.Name}  "));
			Console.WriteLine();


			// locate to position in list
			var existingobject = people.First(p => p.Name == "John");

			// add new item
			id++;
			people.Insert(new Person() { Id = id, Name = "John2"});


			Console.Write("List after insert:  ");
			this.people.ForEach(p => Console.Write($"{p.Id} {p.Name}  "));
			Console.WriteLine();


		}

		void ClearList()
		{
			people.Clear();
		}

	}
}
