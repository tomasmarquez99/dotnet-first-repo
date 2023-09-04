// See https://aka.ms/new-console-template for more information
using coreConsoleApplication;

Console.WriteLine("Hello, World!");

string name = "Penarol";
int age = 23;
float discount = 1.23F;

Console.WriteLine("Name:" + name);
Console.WriteLine("Age:" + age);
Console.WriteLine("Discount" + discount);

bool isAuthenticated = true;

if (isAuthenticated)
    Console.WriteLine("You are logged In.");
else
    Console.WriteLine("You are not logged In.");

string result = isAuthenticated ? "You are logged In." : "You're not logged In.";
Console.WriteLine(result);

int temperature = 50;

if (temperature < 20)
    Console.WriteLine("Cold");
else if (temperature >= 20 && temperature <= 50)
    Console.WriteLine("Moderate");
else
    Console.WriteLine("Hot");

string userType = "admin";
switch(userType)
{
    case "admin":
        Console.WriteLine("You have full access");
        break;

    case "subadmin":
        Console.WriteLine("You can create or delete courses");
        break;

    case "user":
        Console.WriteLine("You can access the courses");
        break;

    default:
        Console.WriteLine("Trial user.");
        break;

}




/* arrays */

int[] marks = new int[5] { 1, 2, 3, 4, 5 };

foreach (int mark in marks)
    Console.WriteLine(mark);

int[,] multiArray = new int[3, 4];
multiArray[0, 0] = 23;

for (int i = 0; i < marks.Length; i++)
{
    Console.WriteLine(marks[0]);
}



/* Classes and Objects */


Student student = new Student();
student.displayDetails();