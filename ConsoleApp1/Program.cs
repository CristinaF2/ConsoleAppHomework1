// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello,");
Console.WriteLine("Please input your First name:");
string firstName = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Please input your Last name:");
string lastName = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Please input your age:");
string age = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Please input your gender:");
string gender = Console.ReadLine();
Console.WriteLine();

int futureAge = Convert.ToInt32(age) + 20;

Console.WriteLine("Your details are as follows:");
Console.WriteLine($"     - First Name: {firstName}");
Console.WriteLine($"     - Last Name: {lastName}");
Console.WriteLine($"     - Gender: {gender}");
Console.WriteLine($"You will be {futureAge} years old in 20 years!");




