namespace ServerManagement.Services;

public class CityRepository
{
    private static List<string> _cities = new List<string>()
    {
        "Toronto",
        "Montreal",
        "Ottawa",
        "Calgary",
        "Halifax"
    };

    public static List<string> GetAll() => _cities;
}
