using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			this.IsEmpyList();			// check if list is empty
			this.AddItemsToList();      // add items to list
			this.IsEmpyList();          // check if list is empty
		}


		void IsEmpyList()
		{
			Console.WriteLine($"People list contain {people.Count()} persons and is it empty ? {people.IsEmpty()}");
		}

		void AddItemsToList()
		{

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
				arrayofpersons[i] = new Person() { Id = id, Name = "Adam" };
			}

			people.Add(arrayofpersons);



			// add another list of persons to the list

			var newpersons = new CList<Person>();
			for (int i = 0; i < 3; i++) 
			{ 
				id++;
				newpersons.Add(new Person() { Id = id, Name = "Eve" }); 
			}

			people.Add(newpersons);



			// adding null items are ignored

			Person? nullperson = null;
			people.Add(nullperson);



		}
	}
}
