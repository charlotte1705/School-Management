using System;
namespace advanceprog
{
   class Menu
    {
		public static void showMenu(string schoolName)
		{
			Console.WriteLine("\t\t|__________________________________________|");
			Console.WriteLine($"\t\t	[ {schoolName} Wizarding School ]	");
			Console.WriteLine("\t\t											");
			Console.WriteLine("\t\t	[1] Add Student							");
			Console.WriteLine("\t\t	[2] Add Teacher							");
            Console.WriteLine("\t\t	[3] Find Teacher						");
            Console.WriteLine("\t\t	[4] Find Student						");
            Console.WriteLine("\t\t	[5] Show Students						");
			Console.WriteLine("\t\t	[6] Show Teachers						");
			Console.WriteLine("\t\t	[7] Exit								");
			Console.WriteLine("\t\t__________________________________________");
		
		}
	}
}
