Console.WriteLine("Enter your age");

int userAge = Int32.Parse(Console.ReadLine()); //muudame string tüübi int väärtuseks

if (userAge >= 13)
{
    Console.WriteLine("Welcome to instagram!");
}

else
{
    Console.WriteLine("You are too young to use Instagram!");
}