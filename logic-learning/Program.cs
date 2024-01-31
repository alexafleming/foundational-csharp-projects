// Random coin = new Random();
// int flip = coin.Next(0, 2);

// Console.WriteLine((flip == 0) ? "heads" : "tails");

string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin") && level > 55)
{
    Console.WriteLine("Welcome, Super Admin user.");
}
else if (permission.Contains("Admin"))
{
    Console.WriteLine("Welcome, Admin user.");
}
else if (permission.Contains("Manager") && level >= 20)
{
    Console.WriteLine("Contact an Admin for access.");
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}







