namespace Examples.Patterns.Creational.Singleton;

public class DbContext
{
    private static DbContext? _context;

    private DbContext()
    {
        Console.WriteLine("Database context has been created");
    }

    public static DbContext Instance
    {
        get
        {
            _context ??= new DbContext();

            return _context;
        }
    }

    public string executeQuery(string sql)
    {
        return $"Database data fetched from query: {sql}";
    }
}
