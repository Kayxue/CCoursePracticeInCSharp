// See https://aka.ms/new-console-template for more information

List<FishData> database = new List<FishData>
{
    new() { engName = "Milk Fish", sciName = "Chanos chanos", avgLength = 40, avgWeight = 300, environment = 'S' },
    new()
    {
        engName = "Black King Fish", sciName = "Rachycentron canadum", avgLength = 150, avgWeight = 40000,
        environment = 'S'
    },
    new()
    {
        engName = "Grass carp", sciName = "Ctenopharyngodon idella", avgLength = 150, avgWeight = 35000,
        environment = 'F'
    },
    new()
    {
        engName = "Gold Head Cichlid", sciName = "Aulonocara baenschi", avgLength = 15, avgWeight = -1,
        environment = 'F'
    },
    new()
    {
        engName = "Ocellaris clownfish", sciName = "Amphiprion ocellaris", avgLength = 4, avgWeight = -1,
        environment = 'S'
    }
};

string input;
Console.WriteLine("Welcome to the NTOU Marine Education Encyclopedia!");
while(true)
{
    Console.Write("\nInput the name of fish (\"quit\" to exit): ");
    input = Console.ReadLine();
    if (input == "quit")
    {
        break;
    }

    FishData searchResult = database.Find(e => e.engName == input);
    if (searchResult.Equals(default(FishData)))
    {
        Console.WriteLine($"Sorry, we cannot find [{input}] in our database.");
        continue;
    }
    Console.WriteLine("{0} ({1}): average length {2}cm{3}, {4} fish.", searchResult.engName, searchResult.sciName,
        searchResult.avgLength, searchResult.avgWeight == -1 ? "" : $", average weight {searchResult.avgWeight}g",
        searchResult.environment == 'S' ? "seawater" : "freshwater");
}

Console.WriteLine("\nThank you for using the NTOU Marine Education Encyclopedia!");
struct FishData
{
    public string engName, sciName;
    public int avgLength, avgWeight;
    public char environment;
}
