using System.Reflection;
using Examples.Interfaces;

var patternGroups = Assembly.GetExecutingAssembly()
                        .GetTypes()
                        .Where(type => typeof(IPatternExample).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract)
                        .Select(type => (IPatternExample)Activator.CreateInstance(type)!)
                        .OrderBy(pattern => pattern.Name)
                        .GroupBy(pattern => pattern.Group)
                        .OrderBy(group => group.Key)
                        .ToList();

if (args.Length > 0)
{
    var pattern = patternGroups.SelectMany(group => group)
                            .FirstOrDefault(pattern => pattern.Name.Equals(args[0], StringComparison.OrdinalIgnoreCase));

    pattern?.Run();
}
else
{
    int index = 1;
    var flatList = new List<IPatternExample>();

    Console.WriteLine();
    foreach (var group in patternGroups)
    {
        Console.WriteLine($"--- {group.Key.ToString().ToUpper()} PATTERNS ---");
        foreach (var pattern in group)
        {
            Console.WriteLine($"{index++}. {pattern.Name}");
            flatList.Add(pattern);
        }
        Console.WriteLine();
    }

    Console.Write("\nSelect a pattern to run (or 'q' to exit): ");
    var input = Console.ReadLine();

    if (int.TryParse(input, out int choice) && choice > 0 && choice <= flatList.Count)
    {
        Console.Clear();
        Console.WriteLine();
        flatList[choice - 1].Run();
    }
}