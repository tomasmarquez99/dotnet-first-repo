using System;
namespace coreConsoleApplication
{
	internal class Student
	{
		// Data Members
		int studentId;
		string studentName;

		// Member Functions
		public void displayDetails()
		{
			Console.WriteLine("Student Id: " + studentId);
            Console.WriteLine("Student Name: " + studentName);
        }
	}
}

