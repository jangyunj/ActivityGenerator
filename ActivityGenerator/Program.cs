var activityList = new List<string>() { "Movies", "Paintball", "Bowling", "Laser Tag", "LAN Party", "Hiking", "Biking" };

var random = new Random();

Console.Write("Welcome to the random activity generator! \nWould you like to generate a new activity? (Yes/No) ");

bool cont = Console.ReadLine().ToLower() == "yes" ? true : false;
if (cont == false)
{
    Console.WriteLine("Okay, have a great day :) Bye!");
    return; //exits out of the program 
}

Console.WriteLine("Awesome! First, what is your name? ");
string userName = Console.ReadLine();
Console.WriteLine($"Nice to meet you {userName}! Hope you are having a great day so far!");


while (cont)
{

    Console.WriteLine("Connecting to the database");
    for (int i = 0; i < 5; i++)
    {
        Console.Write(". ");
        Thread.Sleep(500);
    }
    Console.WriteLine("Choosing a random activity for you");
    for (int i = 0; i < 5; i++)
    {
        Console.Write(". ");
        Thread.Sleep(500);
    }

    int randomNumber = random.Next(activityList.Count);
    string randomActivity = activityList[randomNumber];

    Console.Write($"{userName}, your random activity is {randomActivity}.\n " +
        $"Would you like to proceed or select another activity? (Keep/Redo) ");

    cont = Console.ReadLine().ToLower() == "redo" ? true : false;

}

Console.WriteLine("Would you like to add any activities? (Yes/No) ");
bool addToList = Console.ReadLine().ToLower() == "yes" ? true : false;
while (addToList)
{
    Console.Write("What would you like to add? ");
    string userAddActivities = Console.ReadLine();
    activityList.Add(userAddActivities);

    foreach (var activity in activityList)
    {
        Console.Write($"{activity} ");
        Thread.Sleep(250);
    }

    Console.WriteLine("Would you like to add more? (Yes/No) ");
    addToList = Console.ReadLine().ToLower() == "yes" ? true : false;

}

if (addToList == false)
{
    Console.WriteLine("Alright, have a wonderful day! :)");
    Console.Write("Press any key to exit.");
    Console.ReadKey();
}

