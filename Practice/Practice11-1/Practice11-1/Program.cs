// See https://aka.ms/new-console-template for more information

int indexOfList(string str, List<string> list)
{
    return list.IndexOf(str);
}

List<string> country =
    new List<string>
    {
        "China",
        "Japan",
        "Korea",
        "India",
        "Indonesia",
        "Malaysia",
        "Singapore",
        "Thailand",
        "Viet Nam",
        "Taiwan",
        "Mexico",
        "Brazil",
        "Canada",
        "USA",
        "the United Kingdom",
        "Italy",
        "Spain",
        "France",
        "Germany",
        "Australia",
        "New Zealand"
    };

List<int> population = new List<int>
{
    1425887, 123952, 51816, 1417173, 275501,
    33938, 5976, 71697, 98187, 23893, 127504,
    215313, 38454, 338290, 67509, 59037, 47559,
    64627, 83370, 26177, 5185
};

string input = "";
Console.WriteLine("Welcome to the World Population Database!");
while (true)
{
    Console.Write("\nInput a country (\"quit\" to exit): ");
    input = Console.ReadLine();
    if (input == "quit")
    {
        break;
    }
    int index = indexOfList(input, country);
    switch (index)
    {
        case -1:
            Console.WriteLine($"Sorry, we cannot find [{input}] in our database.");
            break;
        default:
            Console.WriteLine($"The population of {country[index]} is {population[index]} thousands.");
            break;
    }
}
Console.WriteLine("\nThank you for using World Population Database!");

