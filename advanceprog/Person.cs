using System;
namespace advanceprog
{
    abstract class Person
    {
       
		private string name;
		private int age;

		//get, set method
		public string Name { get => name; set => name = value; }
		public int Age { get => age; set => age = value; }

		//constructors

		public Person(string name, int age)
		{
			this.Name = name;
			this.Age = age;
		}

		public Person()
		{

		}

		public abstract void showInformation();
		
	}
}
